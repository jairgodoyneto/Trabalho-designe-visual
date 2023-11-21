import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HorarioLivre } from './HorarioLivre';
const httpOptions = {
  headers: new HttpHeaders({
  'Content-Type' : 'application/json'
  })
}
@Injectable({
  providedIn: 'root'
})
export class HorarioLivreService {
  apiUrl = 'http://localhost:5000/HorarioLivre';
  constructor(private http: HttpClient) { }
  listar(): Observable<HorarioLivre[]>{
    const url = `${this.apiUrl}/Listar Horarios`;
    return this.http.get<HorarioLivre[]>(url);
  }
  buscar(id:number): Observable<HorarioLivre>{
    const url = `${this.apiUrl}/buscar Horario/${id}`;
    return this.http.get<HorarioLivre>(url);
  }
  cadastrar(horario: HorarioLivre): Observable<any>{
    const url = `${this.apiUrl}/inserir Horario`
    return this.http.post<HorarioLivre>(url,horario,httpOptions);
  }
  atualizar(horario: HorarioLivre): Observable<any>{
    const url = `${this.apiUrl}/Alterar Horario`;
    return this.http.put<HorarioLivre>(url,horario,httpOptions);
  }
  excluir(id:number):Observable<any>{
    const url = `${this.apiUrl}/excluir Horario/${id}`;
    return this.http.delete<string>(url,httpOptions);
  }
}
