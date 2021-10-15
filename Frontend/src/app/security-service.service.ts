import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { User } from './Models/User';
import { LoginUser } from './Models/LoginUser';

@Injectable({
  providedIn: 'root'
})
export class SecurityService {
  private currentUser?: User;
  private isAuthenticated: boolean = false;

  constructor(private httpClient: HttpClient) { }

  public IsAuthenticated()
  {
    return this.isAuthenticated;
  }

  public GetAuthLevel(): number
  {
    return this.currentUser?.authLevel ?? 0;
  }

  public async Login(creds: LoginUser): Promise<boolean>
  {
    return new Promise(async (resolve, reject) => 
    {
      resolve(true);
    })
  }
}
