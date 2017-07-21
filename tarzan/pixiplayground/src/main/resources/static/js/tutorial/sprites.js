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

function afterImageLoad(renderer, stage){
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

    stage.addChild(ryanSprite);
    renderer.render(stage);

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
    var rocket = new Sprite(tileset);

    //Position the rocket sprite on the canvas
    rocket.x = 32;
    rocket.y = 32;

    stage.addChild(rocket);
    renderer.render(stage);

    /*
        Begin texture atlas
     */

    //get treasure sprite
    var atlasTextures = loader.resources["images/treasureHunter.json"].textures;
    var treasure = new Sprite(atlasTextures["treasure.png"]);

    //Position the treasure next to the right edge of the canvas
    treasure.x = stage.width - treasure.width - 48;
    treasure.y = stage.height / 2 - treasure.height / 2;
    stage.addChild(treasure);

    //render
    renderer.render(stage);

}