import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';

import { _mimosaConcept } from './_mimosaConcept';
import { MimosaService } from './_mimosa.service';


@Component({
    selector: 'app-_mimosa',
    templateUrl: './_mimosa.component.html',
    providers: [MimosaService],
    styleUrls: ['./_mimosa.component.css']
})
/** _mimosa component*/
export class _mimosaComponent implements OnInit {

    _mimosaConcepts: _mimosaConcept[] = [];

    /** _mimosa ctor */
    constructor(private MimosaService: MimosaService) { }

    ngOnInit() {
        this.getMimosa();
    }

    getMimosa(): void {
        this.MimosaService.getMimosa()
            .subscribe(_mimosaConcepts => (this._mimosaConcepts = _mimosaConcepts));
    }


}