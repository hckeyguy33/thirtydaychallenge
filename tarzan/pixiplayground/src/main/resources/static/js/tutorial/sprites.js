function drawSprites(renderer, stage){
    loader
        //.add("ryanHead", "images/ryanhead.jpg") //alternative
        .add("images/ryanhead.jpg")
        .add("images/megahead.jpg")
        .add("images/small.jpg")
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
    var sprite = new Sprite(
        //loader.resources.ryanHead.texture //alternative
        //loader.resources.["ryanHead"].texture //another alternative
        loader.resources["images/ryanhead.jpg"].texture
    );

    stage.addChild(sprite);
    renderer.render(stage);
}