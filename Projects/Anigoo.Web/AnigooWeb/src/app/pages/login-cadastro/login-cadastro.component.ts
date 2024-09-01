import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HeaderComponent } from "../../shared/header/header.component";
import { LoginComponent } from "./components/login/login.component";
import { CadastroComponent } from "./components/cadastro/cadastro.component";

@Component({
  selector: 'app-login-cadastro',
  standalone: true,
  imports: [CommonModule, HeaderComponent, LoginComponent, CadastroComponent],
  templateUrl: './login-cadastro.component.html',
  styleUrls: ['./login-cadastro.component.scss']
})
export class LoginCadastroComponent {
}
