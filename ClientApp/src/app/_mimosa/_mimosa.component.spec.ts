import { TestBed, async, ComponentFixture, ComponentFixtureAutoDetect } from '@angular/core/testing';
import { BrowserModule, By } from "@angular/platform-browser";
import { _mimosaComponent } from './_mimosa.component';

let component: _mimosaComponent;
let fixture: ComponentFixture<_mimosaComponent>;

describe('_mimosa component', () => {
    beforeEach(async(() => {
        TestBed.configureTestingModule({
            declarations: [ _mimosaComponent ],
            imports: [ BrowserModule ],
            providers: [
                { provide: ComponentFixtureAutoDetect, useValue: true }
            ]
        });
        fixture = TestBed.createComponent(_mimosaComponent);
        component = fixture.componentInstance;
    }));

    it('should do something', async(() => {
        expect(true).toEqual(true);
    }));
});