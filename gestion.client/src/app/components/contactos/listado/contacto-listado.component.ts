import { HttpClient } from '@angular/common/http';
import { Component, OnInit, signal } from '@angular/core';
import { lastValueFrom } from 'rxjs';

interface Contacto {
  contactoId: number;
  nombre: string;
}

@Component({
  selector: 'app-contacto-listado',
  templateUrl: './contacto-listado.component.html',
  standalone: true,
})
export class ContactoListadoComponent implements OnInit {
  contactos = signal<Contacto[]>([]);

  constructor(private http: HttpClient) {}

  ngOnInit() {
    this.getContactos();
  }

  async getContactos() {
    const contactos = await lastValueFrom(
      this.http.get<Contacto[]>('/api/contactos/todos')
    );

    this.contactos.set(contactos);
  }
}
