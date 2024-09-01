import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatIconModule } from '@angular/material/icon';
import { FormBuilder, FormGroup, FormsModule, ReactiveFormsModule } from '@angular/forms';
import { CadastroUsuarioRequest } from 'src/app/core/interfaces/cadastroUsuarioRequest';
import { UsuarioService } from 'src/app/core/services/usuario.service';

@Component({
  selector: 'app-cadastro',
  standalone: true,
  imports: [CommonModule, MatIconModule, FormsModule, ReactiveFormsModule],
  templateUrl: './cadastro.component.html',
  styleUrls: ['./cadastro.component.scss']
})
export class CadastroComponent implements OnInit {

  formularioCadastro!: FormGroup;
  usuarioDados!: CadastroUsuarioRequest;

  constructor(private _formBuilder: FormBuilder, private _usuarioService: UsuarioService) {}

  ngOnInit(): void {
    this.ConfigurarFormulario();
  }

  ConfigurarFormulario()
  {
    this.formularioCadastro = this._formBuilder.group({
      nome: '',
      nomeUsuario: '',
      email: '',
      telefone: '',
      senha: '',
      confirmarSenha: ''
    })
  }

  CadastrarUsuario()
  {
    this.usuarioDados = {
      nome: this.formularioCadastro.value.nome ?? '',
      usuario: this.formularioCadastro.value.nomeUsuario ?? '',
      email: this.formularioCadastro.value.email ?? '',
      telefone: this.formularioCadastro.value.telefone ?? '',
      senha: this.formularioCadastro.value.senha ?? '',
      confirmaSenha: this.formularioCadastro.value.confirmarSenha ?? ''
    }
    console.log('a');
    this._usuarioService.Cadastrar(this.usuarioDados).subscribe();
  }

}
