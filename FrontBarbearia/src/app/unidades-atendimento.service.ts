import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { unidadeAtendimento } from './unidadeAtendimento';
const httpOptions = {
  headers: new HttpHeaders({
  'Content-Type' : 'application/json'
  })
}
@Injectable({
  providedIn: 'root'
})
export class UnidadesAtendimentoService {
  apiUrl = 'http://localhost:5000/Unidade';
  constructor(private http: HttpClient) { }
  listar(): Observable<unidadeAtendimento[]>{
    const url = `${this.apiUrl}/Listar unidades`;
    return this.http.get<unidadeAtendimento[]>(url);
  }
  buscar(id:number): Observable<unidadeAtendimento>{
    const url = `${this.apiUrl}/buscar unidade/${id}`;
    return this.http.get<unidadeAtendimento>(url);
  }
  cadastrar(unidade: unidadeAtendimento): Observable<any>{
    const url = `${this.apiUrl}/inserir Unidade`
    return this.http.post<unidadeAtendimento>(url,unidade,httpOptions);
  }
  atualizar(unidade: unidadeAtendimento): Observable<any>{
    const url = `${this.apiUrl}/alterar unidade`;
    return this.http.put<unidadeAtendimento>(url,unidade,httpOptions);
  }
  excluir(id:number):Observable<any>{
    const url = `${this.apiUrl}/excluir unidade/${id}`;
    return this.http.delete<string>(url,httpOptions);
  }

}
