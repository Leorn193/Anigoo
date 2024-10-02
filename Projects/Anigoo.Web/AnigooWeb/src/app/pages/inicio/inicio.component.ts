import { Component, OnInit, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CadastroComponent } from "../login-cadastro/components/cadastro/cadastro.component";
import { HeaderComponent } from "../../shared/header/header.component";
import { AnimeService } from 'src/app/core/services/anime.service';
import { listaBuscarAnimeResponse } from 'src/app/core/interfaces/listaBuscarAnimeResponse';
import { MatIconModule } from '@angular/material/icon';
import { register as registerSwiperElements} from 'swiper/element/bundle';
import { Router } from '@angular/router';

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

  constructor(private _animeService: AnimeService, private _router: Router) {}

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

  IrDetalhes(id: number)
  {
    this._router.navigate(['detalhes/' + id])
  }
}
