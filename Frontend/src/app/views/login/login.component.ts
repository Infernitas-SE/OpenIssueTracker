import { Component, OnInit } from '@angular/core';
import { SecurityService } from 'src/app/services/security/security-service.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {

  constructor(public securityService: SecurityService) { }

  ngOnInit(): void {
    this.securityService.logout();
  }

}
