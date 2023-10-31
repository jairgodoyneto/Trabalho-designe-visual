import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Barbeiro } from './Barbeiro';
const httpOptions = {
  headers: new HttpHeaders({
  'Content-Type' : 'application/json'
  })
}
@Injectable({
  providedIn: 'root'
})
export class BarbeirosService {
  apiUrl = 'http://localhost:5000/Barbeiro';
  constructor(private http: HttpClient) { }
  listar(): Observable<Barbeiro[]> {
    const url = `${this.apiUrl}/Listar Barbeiro`;
    return this.http.get<Barbeiro[]>(url);
  }
  buscar(id: number): Observable<Barbeiro> {
    const url = `${this.apiUrl}/buscar Barbeiro/${id}`;
    return this.http.get<Barbeiro>(url);
  }
  cadastrar(Barbeiro: Barbeiro): Observable<any> {
    const url = `${this.apiUrl}/inserir Barbeiro`;
    return this.http.post<Barbeiro>(url, Barbeiro, httpOptions);
  }
  atualizar(Barbeiro: Barbeiro): Observable<any> {
    const url = `${this.apiUrl}/mudar Barbeiro`;
    return this.http.put<Barbeiro>(url, Barbeiro, httpOptions);
  }
  excluir(id: number): Observable<any> {
    const url = `${this.apiUrl}/excluir barbeiro/${id}`;
    return this.http.delete<string>(url, httpOptions);
  }
}
