var once = function (fn) {
    let ans = true;
    return function (...args) {
        if (ans) {
            ans = false;
            return fn(...args);
        }
    }
};