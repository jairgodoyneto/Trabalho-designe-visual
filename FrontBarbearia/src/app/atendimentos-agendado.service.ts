import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { AtendimentoAgendado } from './AtendimentoAgendado';
const httpOptions = {
  headers: new HttpHeaders({
  'Content-Type' : 'application/json'
  })
}
@Injectable({
  providedIn: 'root'
})
export class AtendimentosAgendadoService {
  apiUrl = 'http://localhost:5000/Atendimento';
  constructor(private http: HttpClient) { }
  listar(): Observable<AtendimentoAgendado[]> {
    const url = `${this.apiUrl}/Listar Atendimentos`;
    return this.http.get<AtendimentoAgendado[]>(url);
  }
  buscar(id: number): Observable<AtendimentoAgendado> {
    const url = `${this.apiUrl}/buscar Atendimento/${id}`;
    return this.http.get<AtendimentoAgendado>(url);
  }
  cadastrar(AtendimentoAgendado: AtendimentoAgendado): Observable<any> {
    const url = `${this.apiUrl}/Novo Atendimento/`;
    return this.http.post<AtendimentoAgendado>(url, AtendimentoAgendado, httpOptions);
  }
  atualizar(AtendimentoAgendado: AtendimentoAgendado): Observable<any> {
    const url = `${this.apiUrl}/alterar Atendimento Avulso`;
    return this.http.put<AtendimentoAgendado>(url, AtendimentoAgendado, httpOptions);
  }
  excluir(id: number): Observable<any> {
    const url = `${this.apiUrl}/excluir Atendimento/${id}`;
    return this.http.delete<string>(url, httpOptions);
  }
}
