import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { MultPage } from './mult.page';

const routes: Routes = [
  {
    path: '',
    component: MultPage
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class MultPageRoutingModule {}
