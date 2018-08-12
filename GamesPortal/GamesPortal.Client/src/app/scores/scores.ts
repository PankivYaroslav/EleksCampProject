import { Component, OnInit } from '@angular/core';
import { Score } from '../_models/score';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { User } from '../_models';
import { map } from 'rxjs/operators';

@Component({
    templateUrl: 'scores.html',
    styleUrls: ['scores.css']
})
export class ScoresComponent implements OnInit {
    public scores: Array<Score>;
    public currentUser: User;

    constructor(private http: HttpClient){
        this.currentUser = JSON.parse(localStorage.getItem('currentUser'));
    }

    ngOnInit(): void {
        let headers = new HttpHeaders();
        headers.append('Authorization', 'Bearer ' + this.currentUser.token);
        this.http.get<Score[]>(`${config.apiUrl}/score`, { headers: headers }).pipe(
        map((res) => res)).subscribe(res => {
            this.scores = res;
        });
    }
    
}
