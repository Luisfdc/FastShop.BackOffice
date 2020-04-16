import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { OrderModule } from './components/order/order.module';
import { ClientModule } from './components/client/client.module';


const routes: Routes = [];

@NgModule({
  imports: [
    OrderModule,
    ClientModule,
    RouterModule.forRoot(routes)
  ],
  exports: [RouterModule]
})
export class AppRoutingModule { }
