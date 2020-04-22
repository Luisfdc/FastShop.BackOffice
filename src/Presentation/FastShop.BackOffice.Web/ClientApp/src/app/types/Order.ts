import { Client } from './client';
import { OrderItem } from './OrderItem';

export class Order {
  id: number;
  createAt: Date;
  updateAt: Date;
  paymentType: number;
  status: number;
  clientId: number;
  client: Client
  items: OrderItem[];
  amount: number;
}
