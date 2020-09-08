
(function () {
    var a = b = 3;
})();

console.log("a defined?" + (typeof a !== 'undefined'));
console.log("b defined?" + (typeof b !== 'undefined'));

var bar = null;
console.log(typeof bar !== null && typeof bar === "object");


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
        bar: "hello";
    };
};


console.log("foo1 returns:");
console.log(foo1());
console.log("foo2 returns:");
console.log(foo2());


/* Finds The lowest common multiple of two numbers  */
function LCMCalculator() {
    let checkInt = function (x) {
        if (x % 1 !== 0) {
            throw new TypeError(x + "is not an integration");
        }
        this.a = checkInt(x);
        this.b = checkInt(y);
    };
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
console.log(0.1 + 0.2 === 0.3);


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
    return (str === str.split('').reverse().join(''));
}

var paliText = 'liril';
console.log('palindrom:' + isPalindrome(paliText));

function sum(x) {
    if (arguments.length === 2) {
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



for (let i = 0; i < 5; i++) {
    var btn = document.createElement('button');
    btn.appendChild(document.createTextNode('Button ' + i));
    btn.addEventListener('click', function () { console.log(i) });
    document.body.appendChild(btn);
}


var d = [];

['zebra', 'house'].forEach(function (k) {
    d[k] = undefined;
});

var arr1 = "John".split('');
var arr2 = arr1.reverse();
var arr3 = "venkat".split('');
arr2.push(arr3);
console.log("array1 : length=" + arr1.length + " last=" + arr1.slice(-1));
console.log("array2 : length=" + arr2.length + " last=" + arr2.slice(-1));


console.log(1 + "2" + "2");
console.log(1 + +"2" + "2");
console.log(1 + -"1" + "2");
console.log(+"1" + -"1" + "2");
console.log("A" - "B" + "2");
console.log("A" - "B" + 2);


//debugger;
function GetHugeList() {
    var list = [];
    for (var i = 0; i < 1000; i++) {
        list[i] = i;
    }
    return list;
}

var list = GetHugeList();
var nextListItem = function () {
    var item = list.pop();
    if (item) {
        setTimeout(nextListItem, 0);
    }
}


var globalVar = "xyz";

(function outerFunc(outerArg) {
    var outerVar = "a";
    (function innterFun(innerArg) {
        var innerVar = "b";
        console.log("outerArg =" + outerArg + "\n" +
            "innerArg =" + innerArg + "\n" +
            "outerArg =" + outerArg + "\n" +
            "ounterVar =" + outerVar + "\n" +
            "innerVar = " + innerVar + "\n" +
            "globalVar = " + globalVar + "n");

    })(456);
})(123);


// Difference between var and let.
for (let i = 0; i < 5; i++) {
    setTimeout(function () { console.log(i); }, i * 1000);
}

debugger;

console.log("0 || 1 = " + (0 || 1));
console.log("1 || 2 = " + (1 || 2));
console.log("0 && 1 = " + (0 && 1));
console.log("1 && 2 = " + (1 && 2));

console.log(false === '0');
console.log(false === '0');

var a = {},
    b = { key: 'b' },
    c = { key: 'c' };

a[b] = 123;
a[c] = 456;
console.log(a[b]);

console.log(function f(n) { return ((n > 1) ? n * f(n - 1) : n) }(10));

(function (x) {
    return (function (y) {
        console.log(x);
    })(2)
})(1);


//var hero = {
//    _name = 'John Doe',
//    getSecretIdentity: function () {
//        return this._name;
//    }
//};

//var storeSecretIdentity = hero.getSecretIdentity;

//console.log(storeSecretIdentity());
//consoel.log(hero.getSecretIdentity());



console.log(1 < 2 < 3);
console.log(3 > 2 > 1);


//ECMA script adding before and start.
var myArray = ['1', 'b', 'c', 'd'];
console.log('before adding: ' + myArray);
myArray = ['start', ...myArray, 'end'];
console.log('after adding: ' + myArray);

var a = [1, 2, 3];
a[6] = 10;
console.log('Number:' + a[6]);
console.log('Empty Slots:' + a[4]);

console.log("type checking type of undefined to type of NULL" + typeof undefined === typeof NULL);
console.log("type of type of " + typeof typeof 1);


var b = 1;
function outer() {
    var b = 2
    function inner() {
        b++;
        var b = 3;
        console.log(b);
    }
    inner();
}
outer();

let saying = new Map();
saying.set('dog', 'woof');
saying.set('cat', 'meow');


saying.size;
saying.get('dog');
saying.get('elephant');

saying.has('dog');
saying.has('duck');
saying.delete('dog');
saying.has('dog');

for (let [key, value] of saying) {
    console.log(key + 'goes' + value);
}
saying.clear();
saying.size;


let handler = {
    get: function (target, name) {
        return name in target ? target[name] : 42;
    }
};

let p = new Proxy({}, handler);
p.a = 1;
console.log(p.a, p.b);


