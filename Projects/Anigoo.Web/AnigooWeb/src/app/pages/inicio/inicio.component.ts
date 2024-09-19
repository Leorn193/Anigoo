import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CadastroComponent } from "../login-cadastro/components/cadastro/cadastro.component";
import { HeaderComponent } from "../../shared/header/header.component";
import { AnimeService } from 'src/app/core/services/anime.service';
import { listaBuscarAnimeResponse } from 'src/app/core/interfaces/listaBuscarAnimeResponse';

@Component({
  selector: 'app-inicio',
  standalone: true,
  imports: [CommonModule, CadastroComponent, HeaderComponent],
  templateUrl: './inicio.component.html',
  styleUrls: ['./inicio.component.scss']
})
export class InicioComponent implements OnInit {

  listaAnime!: listaBuscarAnimeResponse[];

  constructor(private _animeService: AnimeService) {}

  ngOnInit(): void {
    this.BuscarAnimes();
  }

  BuscarAnimes()
  {
    this._animeService.Get().subscribe(
      (data) => {
        this.listaAnime = data;
        console.log(this.listaAnime);
      },
      (error) => {
        console.error('Erro ao carregar animes:', error);
      }
    )
  }

}
