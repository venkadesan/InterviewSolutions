
(function () {
    var a = b = 3;
})();

console.log("a defined?" + (typeof a !== 'undefined'));
console.log("b defined?" + (typeof b !== 'undefined'));

var bar = null;
console.log(typeof bar != null && typeof bar === "object");

var myobject = {
    foo: "bar",
    func = (function(){
        var self = this;
        console.log("outer func: this.foo =" + this.foo);
        console.log("outer func: self.foo =" + self.foo);
        (function () {
            console.log("inner func:this.foo" + this.foo);
            console.log("inner func:self.foo" + self.foo);
        }());
    }
};

myobject.func();