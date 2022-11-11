import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';

import { _plcsConcept } from './_plcsConcept';
import { PlcsService } from './_plcs.service';


@Component({
    selector: 'app-_plcs',
    templateUrl: './_plcs.component.html',
    providers: [PlcsService],
    styleUrls: ['./_plcs.component.css']
})
/** _plcs component*/
export class _plcsComponent implements OnInit {
    _plcsConcepts: _plcsConcept[] = [];
    /** _plcs ctor */
    constructor(private PlcsService: PlcsService) { }

    ngOnInit() {
        this.getPlcs();
    }

    getPlcs(): void {
        this.PlcsService.getPlcs()
            .subscribe(_plcsConcepts => (this._plcsConcepts = _plcsConcepts));
    }

}

