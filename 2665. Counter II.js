var createCounter = function(init) {
    var counter = init;
    return {
        increment : ()=>{
            counter++;
            return counter;
        },
        decrement : ()=>{
            counter--;
            return counter;
        },
        reset : ()=> {
            counter = init;
            return counter;
        }
    }
};