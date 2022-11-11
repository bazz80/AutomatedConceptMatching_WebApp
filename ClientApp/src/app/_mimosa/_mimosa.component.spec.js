"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var testing_1 = require("@angular/core/testing");
var platform_browser_1 = require("@angular/platform-browser");
var _mimosa_component_1 = require("./_mimosa.component");
var component;
var fixture;
describe('_mimosa component', function () {
    beforeEach((0, testing_1.async)(function () {
        testing_1.TestBed.configureTestingModule({
            declarations: [_mimosa_component_1._mimosaComponent],
            imports: [platform_browser_1.BrowserModule],
            providers: [
                { provide: testing_1.ComponentFixtureAutoDetect, useValue: true }
            ]
        });
        fixture = testing_1.TestBed.createComponent(_mimosa_component_1._mimosaComponent);
        component = fixture.componentInstance;
    }));
    it('should do something', (0, testing_1.async)(function () {
        expect(true).toEqual(true);
    }));
});
//# sourceMappingURL=_mimosa.component.spec.js.map