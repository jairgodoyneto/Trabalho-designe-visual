
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { AtendimentoAvulso } from './AtendimentoAvulso';
const httpOptions = {
  headers: new HttpHeaders({
  'Content-Type' : 'application/json'
  })
}
@Injectable({
  providedIn: 'root'
})
export class AtendimentosAvulsoService {

  apiUrl = 'http://localhost:5000/AtendimentoAvulso';
  constructor(private http: HttpClient) { }
  listar(): Observable<AtendimentoAvulso[]> {
    const url = `${this.apiUrl}/Listar Atendimento Avulsos`;
    return this.http.get<AtendimentoAvulso[]>(url);
  }
  buscar(id: number): Observable<AtendimentoAvulso> {
    const url = `${this.apiUrl}/buscar Atendimento Avulso/${id}`;
    return this.http.get<AtendimentoAvulso>(url);
  }
  cadastrar(AtendimentoAvulso: AtendimentoAvulso): Observable<any> {
    const url = `${this.apiUrl}/Novo Atendimento Avulso/`;
    return this.http.post<AtendimentoAvulso>(url, AtendimentoAvulso, httpOptions);
  }
  atualizar(AtendimentoAvulso: AtendimentoAvulso): Observable<any> {
    const url = `${this.apiUrl}/alterar Atendimento Avulso`;
    return this.http.put<AtendimentoAvulso>(url, AtendimentoAvulso, httpOptions);
  }
  excluir(id: number): Observable<any> {
    const url = `${this.apiUrl}/excluir Atendimento Avulso/${id}`;
    return this.http.delete<string>(url, httpOptions);
  }
}


