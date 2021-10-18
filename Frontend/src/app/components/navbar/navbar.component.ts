import { Component } from '@angular/core';
import { SecurityService } from 'src/app/services/security/security-service.service';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.scss']
})
export class NavbarComponent {
  constructor(public securityService: SecurityService) 
  { 
    securityService.login();
  }
}
