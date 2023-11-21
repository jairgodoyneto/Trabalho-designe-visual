import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Agenda } from './Agenda';
const httpOptions = {
  headers: new HttpHeaders({
  'Content-Type' : 'application/json'
  })
}
@Injectable({
  providedIn: 'root'
})
export class AgendasService {

  apiUrl = 'http://localhost:5000/Agenda';
  constructor(private http: HttpClient) { }
  listar(): Observable<Agenda[]> {
    const url = `${this.apiUrl}/Listar Agenda`;
    return this.http.get<Agenda[]>(url);
  }
  buscar(id: number): Observable<Agenda> {
    const url = `${this.apiUrl}/buscar Agenda/${id}`;
    return this.http.get<Agenda>(url);
  }
  cadastrar(Agenda: Agenda): Observable<any> {
    const url = `${this.apiUrl}/cadastrar Agenda/`;
    return this.http.post<Agenda>(url, Agenda, httpOptions);
  }
  atualizar(Agenda: Agenda): Observable<any> {
    const url = `${this.apiUrl}/alterar Agenda`;
    return this.http.put<Agenda>(url, Agenda, httpOptions);
  }
  excluir(id: number): Observable<any> {
    const url = `${this.apiUrl}/excluir Agenda/${id}`;
    return this.http.delete<string>(url, httpOptions);
  }
}
