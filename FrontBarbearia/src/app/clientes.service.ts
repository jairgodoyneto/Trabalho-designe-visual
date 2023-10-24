import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Cliente } from './Cliente';
const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type' : 'application/json'
  })
}

@Injectable({
  providedIn: 'root'
})
export class ClientesService {
  apiUrl = 'http://localhost:5000/Cliente';
  constructor(private http: HttpClient) { }
  listar(): Observable<Cliente[]> {
    const url = `${this.apiUrl}/Listar Clientes`;
    return this.http.get<Cliente[]>(url);
  }
  buscar(id: number): Observable<Cliente> {
    const url = `${this.apiUrl}/buscar Cliente/${id}`;
    return this.http.get<Cliente>(url);
  }
  cadastrar(Cliente: Cliente): Observable<any> {
    const url = `${this.apiUrl}/inserirCliente`;
    return this.http.post<Cliente>(url, Cliente, httpOptions);
  }
  atualizar(Cliente: Cliente): Observable<any> {
    const url = `${this.apiUrl}/alterar cliente`;
    return this.http.put<Cliente>(url, Cliente, httpOptions);
  }
  excluir(id: number): Observable<any> {
    const url = `${this.apiUrl}/excluir cliente/${id}`;
    return this.http.delete<string>(url, httpOptions);
  }
}
