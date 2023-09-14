function createCounter(n) {
    return function () {
        return n++;
    };
}

function callCounter(n, calls) {
    const counter = createCounter(n);
    const result = [];

    for (let i = 0; i < calls.length; i++) {
        if (calls[i] === "call") {
            result.push(counter());
        }
    }

    return result;
}