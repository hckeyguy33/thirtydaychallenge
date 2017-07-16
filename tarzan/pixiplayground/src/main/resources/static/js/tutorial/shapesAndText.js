function getRectangle(){
    //draw a rectangle
    var rectangle = new PIXI.Graphics();
    rectangle.beginFill(0x66CCFF);
    rectangle.lineStyle(4, 0xFF3300, 1);
    rectangle.drawRect(0, 0, 64, 64);
    rectangle.endFill();
    rectangle.x = 170;
    rectangle.y = 170;
    return rectangle;
}

function getCircle(){
    var circle = new PIXI.Graphics();
    circle.beginFill(0x9966FF);
    circle.drawCircle(64, 130, 32);
    circle.endFill();
    //circle.x = 64;
    //circle.y = 130;
    return circle;
}

function getEllipse(){
    var ellipse = new PIXI.Graphics();
    ellipse.beginFill(0xFFFF00);
    ellipse.drawEllipse(0, 0, 50, 20);
    ellipse.endFill();
    ellipse.x = 180;
    ellipse.y = 130;
    return ellipse;
}

function getRoundedRectangle(){
    var roundBox = new PIXI.Graphics();
    roundBox.lineStyle(4, 0x99CCFF, 1);
    roundBox.beginFill(0xFF9933);
    roundBox.drawRoundedRect(0, 0, 84, 36, 10)
    roundBox.endFill();
    roundBox.x = 48;
    roundBox.y = 190;
    return roundBox;
}

function getLine(){
    var line = new PIXI.Graphics();
    line.lineStyle(4, 0xFFFFFF, 1);
    line.moveTo(0, 0);
    line.lineTo(80, 50);
    line.x = 32;
    line.y = 32;
    return line;
}

function getTriangle(){
    var triangle = new PIXI.Graphics();
    triangle.beginFill(0x66FF33);

    //Use `drawPolygon` to define the triangle as
    //a path array of x/y positions

    triangle.drawPolygon([
        -32, 64,             //First point
        32, 64,              //Second point
        0, 0                 //Third point
    ]);

    //Fill shape's color
    triangle.endFill();

    //Position the triangle after you've drawn it.
    //The triangle's x/y position is anchored to its first point in the path
    triangle.x = 180;
    triangle.y = 22;

    return triangle;
}

function getText(text){
    var message = new PIXI.Text(
        text, {fontFamily: "Arial", fontSize: 32, fill: "white"}
    );

    message.position.set(54, 96);

    return message;
}

function drawShapesAndText(renderer, stage){
    //Create a container object called the `stage`
    //var stage = new PIXI.Container();

    //draw a rectangle
    var rectangle = getRectangle();
    stage.addChild(rectangle);

    //draw a circle
    var circle = getCircle();
    stage.addChild(circle);

    //draw an ellipse
    var ellipse = getEllipse();
    stage.addChild(ellipse);

    //draw a rounded rectangle
    var roundBox = getRoundedRectangle();
    stage.addChild(roundBox);

    //draw a line
    var line = getLine();
    stage.addChild(line);

    var triangle = getTriangle();
    stage.addChild(triangle);

    //draw some text
    var text = getText("Hello, world!");
    stage.addChild(text);

    //render stage
    renderer.render(stage);
}