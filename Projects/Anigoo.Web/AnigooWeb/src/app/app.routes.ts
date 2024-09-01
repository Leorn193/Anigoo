import { Routes } from '@angular/router';

export const routes: Routes = [
  {
    path: '',
    redirectTo: 'login-cadastro',
    pathMatch: 'full',
  },
  {
    path: 'login-cadastro',
    loadComponent: () => import('./pages/login-cadastro/login-cadastro.component').then((x) => x.LoginCadastroComponent)
  },
];
