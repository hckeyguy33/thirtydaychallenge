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
 * Strategy #1
 *
 * return an array of lines to draw and 'cut' the pizza
 * @param pizza
 * @param slices
 */
function cutPizza(pizza, slices, even){
    //determine how many cuts are necessary for visual

    if (slices <= 1){
        return []; //no cuts necessary
    }
    else if (even && (slices % 2) == 0){
        slices = slices / 2; //for even slices, only takes half the amount of cuts for odd numbers
    } else {
        //all cuts are necessary
    }

    var cuts = [];


    //Start cutting towards the 12'o-clock position, and cut slices as necessary
    for (var i = 0; i < slices; i++){
        //TODO


    }

    return cuts;


}

/**
 * Strategy #2
 *
 * Given the diameter of the pie, how many slices are necessary,
 * and optionally how many should be "small" slices, return an array
 * of "slice" objects that can be drawn for the user, and their respective
 * rotations to align with the pie
 *
 * @param pizza
 * @param slices
 * @param small
 */
function getSlices(diameter, slices, small){
    //STEP 0 - check parameters
    //all parameters are required to be integers

    //diameter should be at least 180 pixels to not create problems
    if (!Number.isInteger(diameter) || diameter < 180){
        //TODO return error
    }

    //slices should be defined and greater than 0
    if (!Number.isInteger(slices) || slices <= 1){
        //return no slices
        return [];
    }

    //optional small slices should make sense
    var smallSlices = false;
    if (Number.isInteger(small)){
        if (small >= slices){
            //TODO Return error
        } else if (small > 0){
            smallSlices = true;
        }
    }

    var slices = [slices];

    //STEP 1 - determine the angles for each slice

    //even slice angle comes in handy either way
    var evenAngle = 360 / slices;

    if (smallSlices == false){
        //proceed to generate slices of equal size
        console.log("Slice angle = " + evenAngle);
        console.log("Added up = " + evenAngle * slices);
        //TODO
    } else {
        //get two angles - one for "regular" slices, one for "small" slices

        var smallAngle = evenAngle * .75; // small slice is 75% of an even slice
        var angleDiff = evenAngle - smallAngle;
        var bigAngle = evenAngle + (angleDiff / (slices - small)); //get the 'big' slice angle

        //check work, throw exception if math doesn't add up
        if ((smallAngle * small) + (bigAngle * (slices - small)) != 360){
            //TODO throw error
            console.log("Error!")
        }

        console.log("Small Slice = " + smallAngle);
        console.log("Large slice = " + bigAngle);
        console.log("Added up = " + ((smallAngle * small) + (bigAngle * (slices - small))));

    }
}

