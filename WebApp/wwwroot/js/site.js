﻿
(function () {
    var a = b = 3;
})();

console.log("a defined?" + (typeof a !== 'undefined'));
console.log("b defined?" + (typeof b !== 'undefined'));

var bar = null;
console.log(typeof bar != null && typeof bar === "object");


var myobject = {
    foo: "bar",
    func: function() {
        var self = this;
        console.log("outer func: this.foo =" + this.foo);
        console.log("outer func: self.foo =" + self.foo);
        (function () {
            console.log("inner func:  this.foo = " + this.foo);
            console.log("inner func:  self.foo = " + self.foo);
        }());

    }
};

myobject.func();

function foo1() {
    return {
        bar: "hello"
    };
}

function foo2() {
    return
    {
        bar: "hello"
    };
}


console.log("foo1 returns:");
console.log(foo1());
console.log("foo2 returns:");
console.log(foo2());


function LCMCalculator() {
    let checkInt = function (x) {
        if (x % 1 !== 0) {
            throw new TypeError(x + "is not an integration");
        };
        this.a = checkInt(x)
        this.b = checkInt(y);
    }
}

LCMCalculator.prototype = {
    constructor: LCMCalculator,
    gcd: function () {
        let a = Math.abs(this.a), b = Math.abs(this.b), t;
        if (a < b) {
            [a,b] =[]
        }
    }
}



