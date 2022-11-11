import { TestBed, async, ComponentFixture, ComponentFixtureAutoDetect } from '@angular/core/testing';
import { BrowserModule, By } from "@angular/platform-browser";
import { _plcsComponent } from './_plcs.component';

let component: _plcsComponent;
let fixture: ComponentFixture<_plcsComponent>;

describe('_plcs component', () => {
    beforeEach(async(() => {
        TestBed.configureTestingModule({
            declarations: [ _plcsComponent ],
            imports: [ BrowserModule ],
            providers: [
                { provide: ComponentFixtureAutoDetect, useValue: true }
            ]
        });
        fixture = TestBed.createComponent(_plcsComponent);
        component = fixture.componentInstance;
    }));

    it('should do something', async(() => {
        expect(true).toEqual(true);
    }));
});