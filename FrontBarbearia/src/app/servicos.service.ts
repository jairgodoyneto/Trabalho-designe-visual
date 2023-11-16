import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Servico } from './Servico';
const httpOptions = {
  headers: new HttpHeaders({
  'Content-Type' : 'application/json'
  })
}
@Injectable({
  providedIn: 'root'
})
export class ServicosService {
  apiUrl = 'http://localhost:5000/Servico';
  constructor(private http: HttpClient) { }
  listar(): Observable<Servico[]> {
    const url = `${this.apiUrl}/Listar servicos`;
    return this.http.get<Servico[]>(url);
  }
  buscar(id: number): Observable<Servico> {
    const url = `${this.apiUrl}/buscar Servico/${id}`;
    return this.http.get<Servico>(url);
  }
  cadastrar(Servico: Servico): Observable<any> {
    const url = `${this.apiUrl}/inserir Servico/`;
    return this.http.post<Servico>(url, Servico, httpOptions);
  }
  atualizar(Servico: Servico): Observable<any> {
    const url = `${this.apiUrl}/alterar servico`;
    return this.http.put<Servico>(url, Servico, httpOptions);
  }
  excluir(id: number): Observable<any> {
    const url = `${this.apiUrl}/excluir servico/${id}`;
    return this.http.delete<string>(url, httpOptions);
  }
}
