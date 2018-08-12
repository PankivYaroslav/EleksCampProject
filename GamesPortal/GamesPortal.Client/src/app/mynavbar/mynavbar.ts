import { Component, OnInit } from '@angular/core';
import { AlertService, AuthenticationService } from '../_services';
import { Observable } from 'rxjs';

@Component({
    selector: 'mynavbar',
    templateUrl: 'mynavbar.html',
    styleUrls: [ 'mynavbar.css' ]
})
export class MyNavBarComponent implements OnInit {
    public isCollapsed = true;
    public isLoggedIn: boolean;

    constructor(private authenticationService: AuthenticationService){}
    
    ngOnInit(): void {
        this.isLoggedIn = AuthenticationService.isLoggedIn;
    }
    
    public onLogout(): void {
        this.authenticationService.logout();
        this.isLoggedIn = AuthenticationService.isLoggedIn;
    }
}
