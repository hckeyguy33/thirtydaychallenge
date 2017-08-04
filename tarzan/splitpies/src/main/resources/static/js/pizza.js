var pizza;

function getPlainPizza(renderer){
    var circle = new Graphics();
    circle.beginFill(0xFFFF00);
    var x = renderer.view.width / 2;
    var y = renderer.view.height / 2;
    var radius = renderer.view.width / 2;
    circle.drawCircle(x, y, radius);
    circle.endFill();
    return circle;
}

function drawPizza(renderer, stage){
    pizza = getPlainPizza(renderer);
    stage.addChild(pizza);
    renderer.render(stage);
}