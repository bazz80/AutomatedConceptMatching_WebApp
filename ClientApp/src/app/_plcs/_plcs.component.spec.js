"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var testing_1 = require("@angular/core/testing");
var platform_browser_1 = require("@angular/platform-browser");
var _plcs_component_1 = require("./_plcs.component");
var component;
var fixture;
describe('_plcs component', function () {
    beforeEach((0, testing_1.async)(function () {
        testing_1.TestBed.configureTestingModule({
            declarations: [_plcs_component_1._plcsComponent],
            imports: [platform_browser_1.BrowserModule],
            providers: [
                { provide: testing_1.ComponentFixtureAutoDetect, useValue: true }
            ]
        });
        fixture = testing_1.TestBed.createComponent(_plcs_component_1._plcsComponent);
        component = fixture.componentInstance;
    }));
    it('should do something', (0, testing_1.async)(function () {
        expect(true).toEqual(true);
    }));
});
//# sourceMappingURL=_plcs.component.spec.js.map