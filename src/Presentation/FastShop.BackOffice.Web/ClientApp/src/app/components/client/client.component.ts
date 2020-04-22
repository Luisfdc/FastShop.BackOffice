import { Component, OnInit, EventEmitter } from '@angular/core';
import { Client } from '../../types/client';
import { ClientService } from '../../services/client.service';

@Component({
  selector: 'app-client',
  templateUrl: './client.component.html',
  styleUrls: ['./client.component.css']
})
export class ClientComponent implements OnInit {
  client: Client;
  private _clientService: ClientService;
  document: string;

  event = new EventEmitter<number>();

  constructor(clientService: ClientService) {
    this._clientService = clientService;
  }

  ngOnInit(): void {
  }

  getClient(): void {
    this._clientService.getClient(this.document).subscribe(result => {
      this.client = result;
      this.event.emit(this.client.id);
    });
  }


}
