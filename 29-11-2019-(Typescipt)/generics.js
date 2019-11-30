var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
var Cleaner = /** @class */ (function () {
    function Cleaner() {
    }
    return Cleaner;
}());
var House = /** @class */ (function (_super) {
    __extends(House, _super);
    function House() {
        return _super !== null && _super.apply(this, arguments) || this;
    }
    return House;
}(Cleaner));
var room1 = /** @class */ (function (_super) {
    __extends(room1, _super);
    function room1() {
        return _super !== null && _super.apply(this, arguments) || this;
    }
    return room1;
}(House));
function createInstance(c) {
    return new c();
}
createInstance(room1).kichen; // typechecks!
