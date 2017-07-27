function drawSprites(renderer, stage){
    loader
        //.add("ryanHead", "images/ryanhead.jpg") //alternative
        .add("images/ryanhead.jpg")
        .add("images/megahead.jpg")
        .add("images/small.jpg")
        .add("images/tileset.png")
        .add("images/treasureHunter.json")
        .on("progress", loadProgressHandler)
        .once('complete', function(loader, resources){
            afterImageLoad(renderer, stage);
        })
        .load();
}

function loadProgressHandler(loader, resource){
    //Display the file `url` currently being loaded
    console.log("loading: " + resource.url);

    //Display the precentage of files currently loaded
    console.log("progress: " + loader.progress + "%");
}

//let the rocket/treasure be accessed by other functions
var rocket, treasure;

//for game loop
var state;

function afterImageLoad(renderer, stage){
    var spriteGroup = new Container();


    var ryanSprite = new Sprite(
        //loader.resources.ryanHead.texture //alternative
        //loader.resources.["ryanHead"].texture //another alternative
        loader.resources["images/ryanhead.jpg"].texture
    );

    //move ryan's head
    ryanSprite.x = 196;
    ryanSprite.y = 196;
    //ryanSprite.position(96, 96); //alternative

    //make head tiny
    ryanSprite.width = 80;
    ryanSprite.height = 120;

    //OR resize it proportionately
    ryanSprite.scale.x = 0.5;
    ryanSprite.scale.y = 0.5;
    //ryanSprite.scale.set(0.5, 0.5); //alternative

    //rotate the head on default anchor (top left of image)
    //ryanSprite.rotation = 0.5;

    //rotate the head from the middle
    ryanSprite.anchor.x = 0.5;
    ryanSprite.anchor.y = 0.5;
    //ryanSprite.anchor.set(0.5, 0.5); //alternative
    ryanSprite.rotation = 0.5;

    spriteGroup.addChild(ryanSprite);

    //TODO anchor vs pivot... confusing

    /*
        begin tilesets
     */

    //load tileset and use rocket image
    var tileset = loader.resources["images/tileset.png"].texture;

    //Create a rectangle object that defines the position and
    //size of the sub-image you want to extract from the texture
    var rectangle = new Rectangle(192, 128, 64, 64);

    //Tell the texture to use that rectangular section
    tileset.frame = rectangle;

    //Create the sprite from the texture
    rocket = new Sprite(tileset);

    //Position the rocket sprite on the canvas
    rocket.x = 32;
    rocket.y = 32;

    //initialize the rockets velocity for later
    rocket.vx = 0;
    rocket.vy = 0;

    stage.addChild(rocket);
    renderer.render(stage);

    /*
        Begin texture atlas
     */

    //get treasure sprite
    var atlasTextures = loader.resources["images/treasureHunter.json"].textures;
    treasure = new Sprite(atlasTextures["treasure.png"]);

    //Position the treasure next to the right edge of the canvas
    treasure.x = stage.width - treasure.width - 48;
    treasure.y = stage.height / 2 - treasure.height / 2;

    //TODO why is the stage size so small? (64x64)
    spriteGroup.addChild(treasure);

    //tweak the sprite group
    spriteGroup.width = 1000;
    spriteGroup.height = 1000;
    spriteGroup.x = 100;
    spriteGroup.y = 100;

    //add sprite group to stage
    stage.addChild(spriteGroup);

    //render
    renderer.render(stage);

    /**
     * Setup keybindings for UDLR control of rocket
     */
    setupKeyBindings(rocket);

    //make the rocket move
    state = play;
    rocketMove();
}

function setupKeyBindings(sprite){
    //Capture the keyboard arrow keys
    var left = keyboard(37),
        up = keyboard(38),
        right = keyboard(39),
        down = keyboard(40);

    //Left arrow key `press` method
    left.press = function() {

        //Change the sprite's velocity when the key is pressed
        sprite.vx = -5;
        sprite.vy = 0;
    };

    //Left arrow key `release` method
    left.release = function() {

        //If the left arrow has been released, and the right arrow isn't down,
        //and the sprite isn't moving vertically:
        //Stop the sprite
        if (!right.isDown && sprite.vy === 0) {
            sprite.vx = 0;
        }
    };

    //Up
    up.press = function() {
        sprite.vy = -5;
        sprite.vx = 0;
    };
    up.release = function() {
        if (!down.isDown && sprite.vx === 0) {
            sprite.vy = 0;
        }
    };

    //Right
    right.press = function() {
        sprite.vx = 5;
        sprite.vy = 0;
    };
    right.release = function() {
        if (!left.isDown && sprite.vy === 0) {
            sprite.vx = 0;
        }
    };

    //Down
    down.press = function() {
        sprite.vy = 5;
        sprite.vx = 0;
    };
    down.release = function() {
        if (!up.isDown && sprite.vx === 0) {
            sprite.vy = 0;
        }
    };
}

function rocketMove(){
    requestAnimationFrame(rocketMove);

    state();

    renderer.render(stage);
}

function play(){
    //use velocity to update x/y positions
    rocket.x += rocket.vx;
    rocket.y += rocket.vy;

    if (hitTestRectangle(rocket, treasure)){
        console.log("hit!"); //TODO do something cooler
    }
}

function keyboard(keyCode) {
    var key = {};
    key.code = keyCode;
    key.isDown = false;
    key.isUp = true;
    key.press = undefined;
    key.release = undefined;
    //The `downHandler`
    key.downHandler = function (event) {
        if (event.keyCode === key.code) {
            if (key.isUp && key.press) key.press();
            key.isDown = true;
            key.isUp = false;
        }
        event.preventDefault();
    };

    //The `upHandler`
    key.upHandler = function (event) {
        if (event.keyCode === key.code) {
            if (key.isDown && key.release) key.release();
            key.isDown = false;
            key.isUp = true;
        }
        event.preventDefault();
    };

    //Attach event listeners
    window.addEventListener(
        "keydown", key.downHandler.bind(key), false
    );
    window.addEventListener(
        "keyup", key.upHandler.bind(key), false
    );

    return key;
}

function hitTestRectangle(r1, r2) {

    //Define the variables we'll need to calculate
    var hit, combinedHalfWidths, combinedHalfHeights, vx, vy;

    //hit will determine whether there's a collision
    hit = false;

    //Find the center points of each sprite
    r1.centerX = r1.getGlobalPosition().x + r1.width / 2;
    r1.centerY = r1.getGlobalPosition().y + r1.height / 2;
    r2.centerX = r2.getGlobalPosition().x + r2.width / 2;
    r2.centerY = r2.getGlobalPosition().y + r2.height / 2;

    //Find the half-widths and half-heights of each sprite
    r1.halfWidth = r1.width / 2;
    r1.halfHeight = r1.height / 2;
    r2.halfWidth = r2.width / 2;
    r2.halfHeight = r2.height / 2;

    //Calculate the distance vector between the sprites
    vx = r1.centerX - r2.centerX;
    vy = r1.centerY - r2.centerY;

    //Figure out the combined half-widths and half-heights
    combinedHalfWidths = r1.halfWidth + r2.halfWidth;
    combinedHalfHeights = r1.halfHeight + r2.halfHeight;

    //Check for a collision on the x axis
    if (Math.abs(vx) < combinedHalfWidths) {

        //A collision might be occuring. Check for a collision on the y axis
        if (Math.abs(vy) < combinedHalfHeights) {

            //There's definitely a collision happening
            hit = true;
        } else {
            //There's no collision on the y axis
            hit = false;
        }
    } else {

        //There's no collision on the x axis
        hit = false;
    }

    //`hit` will be either `true` or `false`
    return hit;
};
