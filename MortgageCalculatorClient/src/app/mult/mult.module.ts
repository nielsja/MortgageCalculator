import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { MultPageRoutingModule } from './mult-routing.module';

import { MultPage } from './mult.page';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    MultPageRoutingModule
  ],
  declarations: [MultPage]
})
export class MultPageModule {}
