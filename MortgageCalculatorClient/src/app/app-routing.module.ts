import { NgModule } from '@angular/core';
import { PreloadAllModules, RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
    path: 'home',
    loadChildren: () => import('./home/home.module').then( m => m.HomePageModule)
  },
  {
    path: '',
    redirectTo: 'calc',
    pathMatch: 'full'
  },
  {
    path: 'calc',
    loadChildren: () => import('./calc/calc.module').then( m => m.CalcPageModule)
  },  {
    path: 'mult',
    loadChildren: () => import('./mult/mult.module').then( m => m.MultPageModule)
  },


];

@NgModule({
  imports: [
    RouterModule.forRoot(routes, { preloadingStrategy: PreloadAllModules })
  ],
  exports: [RouterModule]
})
export class AppRoutingModule { }
