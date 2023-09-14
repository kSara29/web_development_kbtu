var cancellable = function(fn, args, t) {
    let timeoutId = setTimeout(() => fn(...args), t);
    return () => clearTimeout(timeoutId);
};