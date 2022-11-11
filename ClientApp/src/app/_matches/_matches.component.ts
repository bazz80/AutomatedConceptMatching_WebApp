import { AfterViewInit, Component, OnInit, ViewChild } from '@angular/core';
//import { MdbCollapseDirective } from 'mdb-angular-ui-kit/collapse';
import { FormControl, FormGroup } from '@angular/forms';

import { _matchConcept } from './_matchConcept';
import { MatchesService } from './_matches.service';


@Component({
    selector: 'app-_matches',
    templateUrl: './_matches.component.html',
    providers: [MatchesService],
    styleUrls: ['./_matches.component.css']
})
/** _matches component*/
export class _matchesComponent implements OnInit {

    searchForm: FormGroup;
    _matchConcepts: _matchConcept[] = [];
    searchText: string;


    /** _matches ctor */
    constructor(private MatchesService: MatchesService) { }

    ngOnInit() {
        //this.getAll();
        this.searchForm = new FormGroup({
            searchText: new FormControl()
        });
    }

    submit() {
        console.log(this.searchText);
        console.log(this.searchForm.value);
        this.MatchesService.getMatch(this.searchForm.value).subscribe(_matchConcepts => (this._matchConcepts = _matchConcepts));
    }


}