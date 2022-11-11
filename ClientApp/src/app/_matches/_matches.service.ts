import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, of } from 'rxjs';
import { Router } from '@angular/router';



@Injectable({
    providedIn: 'root'
})

export class MatchesService {

    public baseUrl = "/Match/GetAll";
    public searchUrl = "/Match/GetMatches/"
    //public searchTermUrl: string;
    //public searchTerm: string;

    httpOptions = {
        Headers: new HttpHeaders({ 'Content-Type': 'application/json' })
    };

    constructor(private httpClient: HttpClient) { }

       
    public getMatch(searchTerm: string): Observable<any> {
        console.log(this.searchUrl, searchTerm);
        let searchStr = Object.values(searchTerm);
        let searchTermUrl = (this.searchUrl + searchStr);
        console.log(searchTerm);
        console.log(searchTermUrl);
        //this.searchTermUrl = this.searchTermUrl.toString();
        return this.httpClient.get(searchTermUrl);
    }

}