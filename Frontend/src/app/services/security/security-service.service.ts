import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { User } from 'src/models/User';
import { CookieService } from 'ngx-cookie-service';

@Injectable({
  providedIn: 'root'
})
export class SecurityService {

  constructor(private httpClient: HttpClient, private cookieService: CookieService) { }

  private currentUser?: User;

  public login = () => this.currentUser = { username: "Oliver Karger", authLvl: 10 }
  public logout()
  {
    this.currentUser = undefined;
  }
  public getAuthLvl()
  {
    if (this.CheckPermissions())
    {
      if (this.cookieService.check('authLvl') && (this.cookieService.get('authLvl') === this.currentUser?.authLvl.toString()))
      {
        return this.cookieService.get('authLvl');
      }
    }
    return 0;
  }
  public isSignedIn = () => this.cookieService.check('auth') && this.cookieService.check('authLvl');

  public CheckPermissions()
  {
    return this.httpClient.post("/api/v1/security/check_permission", 
    {
      'username': this.currentUser?.username,
      'authLvl': this.currentUser?.authLvl
    }).subscribe(result => 
      {
        return result;
      }, e => console.log(e));
  }
}
