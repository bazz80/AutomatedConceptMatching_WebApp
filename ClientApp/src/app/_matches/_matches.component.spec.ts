import { TestBed, async, ComponentFixture, ComponentFixtureAutoDetect } from '@angular/core/testing';
import { BrowserModule, By } from "@angular/platform-browser";
import { _matchesComponent } from './_matches.component';

let component: _matchesComponent;
let fixture: ComponentFixture<_matchesComponent>;

describe('_matches component', () => {
    beforeEach(async(() => {
        TestBed.configureTestingModule({
            declarations: [ _matchesComponent ],
            imports: [ BrowserModule ],
            providers: [
                { provide: ComponentFixtureAutoDetect, useValue: true }
            ]
        });
        fixture = TestBed.createComponent(_matchesComponent);
        component = fixture.componentInstance;
    }));

    it('should do something', async(() => {
        expect(true).toEqual(true);
    }));
});