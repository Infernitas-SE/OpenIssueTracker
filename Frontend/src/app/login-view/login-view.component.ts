import { Component, Input, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { LoginUser } from '../Models/LoginUser';
import { SecurityService } from '../security-service.service';

@Component({
  selector: 'app-login-view',
  templateUrl: './login-view.component.html',
  styleUrls: ['./login-view.component.scss']
})
export class LoginViewComponent implements OnInit {

  @Input() error: string | null = null;
  loginButtonDisabled: boolean = false;
  loginForm: FormGroup = new FormGroup({
    username: new FormControl('', Validators.required),
    password: new FormControl('', Validators.required)
  });

  constructor(private securityService: SecurityService) { }

  ngOnInit(): void
  {
    this.loginForm.valueChanges.subscribe(x => this.error = null);
  }

  async login()
  {
    if (this.loginForm.valid)
    {
      var creds = new LoginUser(this.loginForm.get('username')?.value, this.loginForm.get('password')?.value);
      this.loginButtonDisabled = true;
      var ok = await this.securityService.Login(creds);
      if (ok)
      {
          
      }
    }
  }

}
