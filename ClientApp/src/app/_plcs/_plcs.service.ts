 import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, of } from 'rxjs';


@Injectable({
    providedIn: 'root'
})

export class PlcsService {

    public baseUrl = "/Plcs/GetPlcs";

    httpOptions = {
        Headers: new HttpHeaders({ 'Content-Type': 'application/json' })
    };

    constructor(private httpClient: HttpClient) { }

    // get all concepts from controller
    public getPlcs(): Observable<any> {
        return this.httpClient.get(this.baseUrl);
    }
}