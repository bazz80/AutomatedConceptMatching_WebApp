"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var testing_1 = require("@angular/core/testing");
var platform_browser_1 = require("@angular/platform-browser");
var _matches_component_1 = require("./_matches.component");
var component;
var fixture;
describe('_matches component', function () {
    beforeEach((0, testing_1.async)(function () {
        testing_1.TestBed.configureTestingModule({
            declarations: [_matches_component_1._matchesComponent],
            imports: [platform_browser_1.BrowserModule],
            providers: [
                { provide: testing_1.ComponentFixtureAutoDetect, useValue: true }
            ]
        });
        fixture = testing_1.TestBed.createComponent(_matches_component_1._matchesComponent);
        component = fixture.componentInstance;
    }));
    it('should do something', (0, testing_1.async)(function () {
        expect(true).toEqual(true);
    }));
});
//# sourceMappingURL=_matches.component.spec.js.map