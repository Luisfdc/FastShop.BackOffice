import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { OrderComponent } from './order.component';

@NgModule({
  imports: [
    RouterModule.forChild([
      { path: 'order/:id', component: OrderComponent },
      { path: 'order', component: OrderComponent }
    ])
  ],
  exports: [RouterModule]
})
export class OrderRoutingModule { }
