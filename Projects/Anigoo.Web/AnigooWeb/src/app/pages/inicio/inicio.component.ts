import { Component, OnInit, CUSTOM_ELEMENTS_SCHEMA, AfterViewInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CadastroComponent } from "../login-cadastro/components/cadastro/cadastro.component";
import { HeaderComponent } from "../../shared/header/header.component";
import { AnimeService } from 'src/app/core/services/anime.service';
import { listaBuscarAnimeResponse } from 'src/app/core/interfaces/listaBuscarAnimeResponse';
import { MatIconModule } from '@angular/material/icon';
import { register as registerSwiperElements} from 'swiper/element/bundle';

registerSwiperElements();

@Component({
  selector: 'app-inicio',
  standalone: true,
  imports: [CommonModule, CadastroComponent, HeaderComponent, MatIconModule],
  templateUrl: './inicio.component.html',
  styleUrls: ['./inicio.component.scss'],
  schemas: [CUSTOM_ELEMENTS_SCHEMA]
})
export class InicioComponent implements OnInit {

  listaAnime!: listaBuscarAnimeResponse[];
  page: number = 1;

  constructor(private _animeService: AnimeService) {}

  ngOnInit(): void {
    this.BuscarAnimes();
  }


  BuscarAnimes()
  {
    this._animeService.Get(this.page).subscribe(
      (data) => {
        this.listaAnime = data;
        console.log(this.listaAnime);
      },
      (error) => {
        console.error('Erro ao carregar animes:', error);
      }
    )
  }

  VoltarPagina()
  {
    console.log('voltou');
    this.page = this.page - 1;
    this.BuscarAnimes();
  }

  PassarPagina()
  {
    console.log('avancou');
    this.page = this.page + 1;
    this.BuscarAnimes();
  }

}
