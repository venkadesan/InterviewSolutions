
(function () {
    var a = b = 3;
})();

console.log("a defined?" + (typeof a !== 'undefined'));
console.log("b defined?" + (typeof b !== 'undefined'));

var bar = null;
console.log(typeof bar != null && typeof bar === "object");


var myobject = {
    foo: "bar",
    func: function () {
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


/* Finds The lowest common multiple of two numbers  */
function LCMCalculator() {
    let checkInt = function (x) {
        if (x % 1 !== 0) {
            throw new TypeError(x + "is not an integration");
        };
        this.a = checkInt(x)
        this.b = checkInt(y);
    }


}

/*    */
LCMCalculator.prototype = {
    constructor: LCMCalculator,
    gcd: function () {
        let a = Math.abs(this.a), b = Math.abs(this.b), t;
        if (a < b) {
            [a, b] = [b, a];
        }
        while (b !== 0) {
            t = b;
            b = a % b;
            a = t;
        }
    }
}

console.log(0.1 + 0.2);
console.log(0.1 + 0.2 == 0.3);


function AreTheNumbersEqual(num1, num2) {
    return Math.abs(num1 - num2) < Number.EPSILON;
}

console.log(AreTheNumbersEqual(0.1 + 0.1, 0.2));

(function () {
    console.log(1);
    setTimeout(function () { console.log(2) }, 1000);
    setTimeout(function () { console.log(3) }, 0);
    console.log(4);
})();

function isPalindrome(str) {
    str = str.replace(/\W/g, '').toLowerCase();
    return (str == str.split('').reverse().join(''));
}

var paliText = 'liril';
console.log('palindrom:' + isPalindrome(paliText));

function sum(x) {
    if (arguments.length == 2) {
        return arguments[0] + arguments[1];
    }
    else {
        return function (y) { return x + y; };
    }
}

//function sum(x, y) {
//    if (y != undefined) {
//        return x + y;
//    }
//    else {
//       return function(y) { return x + y;}

//    }
//}

console.log("Passing as 2 arguments: Sum:" + sum(2, 4));
console.log("Passing as 1 argument: " + sum(2)(3));

debugger;

for (let i = 0; i < 5; i++) {
    var btn = document.createElement('button');
    btn.appendChild(document.createTextNode('Button ' + i));
    btn.addEventListener('click', function () { console.log(i) });
    document.body.appendChild(btn);
}


