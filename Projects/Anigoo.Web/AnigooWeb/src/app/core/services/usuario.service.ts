import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { CadastroUsuarioRequest } from 'src/app/core/interfaces/cadastroUsuarioRequest';

@Injectable({
  providedIn: 'root'
})
export class UsuarioService {

  private readonly API = 'https://localhost:7221/Api/Usuario';

  constructor(private http: HttpClient) { }

  Cadastrar(usuarioCadatro: CadastroUsuarioRequest) : Observable<any>
  {
    return this.http.post(`${this.API}/Cadastrar`, usuarioCadatro)
  }
}
