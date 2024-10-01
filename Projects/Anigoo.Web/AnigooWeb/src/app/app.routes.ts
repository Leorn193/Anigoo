import { Routes } from '@angular/router';

export const routes: Routes = [
  {
    path: '',
    redirectTo: 'detalhes',
    pathMatch: 'full',
  },
  {
    path: 'login-cadastro',
    loadComponent: () => import('./pages/login-cadastro/login-cadastro.component').then((x) => x.LoginCadastroComponent)
  },
  {
    path: 'inicio',
    loadComponent: () => import('./pages/inicio/inicio.component').then((x) => x.InicioComponent)
  },
  {
    path: 'detalhes/:id',
    loadComponent: () => import('./pages/detalhes/detalhes.component').then((x) => x.DetalhesComponent)
  }
];
