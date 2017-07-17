function drawSprites(renderer, stage){
    PIXI.loader
        .add("images/ryanhead.jpg")
        .once('complete', function(loader, resources){
            afterImageLoad(renderer, stage);
        })
        .load();
}

function afterImageLoad(renderer, stage){
    var sprite = new PIXI.Sprite(
        PIXI.loader.resources["images/ryanhead.jpg"].texture
    );

    stage.addChild(sprite);
    renderer.render(stage);
}