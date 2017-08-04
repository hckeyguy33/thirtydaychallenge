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

/**
 * return an array of lines to draw and 'cut' the pizza
 * @param pizza
 * @param slices
 */
function cutPizza(pizza, slices){

    var cuts = [];

    return cuts;


}