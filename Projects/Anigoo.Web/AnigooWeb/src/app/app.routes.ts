import { Routes } from '@angular/router';

export const routes: Routes = [
  {
    path: '',
    redirectTo: 'inicio',
    pathMatch: 'full',
  },
  {
    path: 'login-cadastro',
    loadComponent: () => import('./pages/login-cadastro/login-cadastro.component').then((x) => x.LoginCadastroComponent)
  },
  {
    path: 'inicio',
    loadComponent: () => import('./pages/inicio/inicio.component').then((x) => x.InicioComponent)
  }
];
