import { Component, OnInit, CUSTOM_ELEMENTS_SCHEMA, OnChanges, SimpleChanges} from '@angular/core';
import { CommonModule } from '@angular/common';
import { HeaderComponent } from "../../shared/header/header.component";
import { MatIconModule } from '@angular/material/icon';
import { AnimeService } from 'src/app/core/services/anime.service';
import { listaBuscarAnimeResponse } from 'src/app/core/interfaces/listaBuscarAnimeResponse';
import { ActivatedRoute, Router } from '@angular/router';
import { register as registerSwiperElements} from 'swiper/element/bundle';

registerSwiperElements();

@Component({
  selector: 'app-detalhes',
  standalone: true,
  imports: [CommonModule, HeaderComponent, MatIconModule],
  templateUrl: './detalhes.component.html',
  styleUrls: ['./detalhes.component.scss'],
  schemas: [CUSTOM_ELEMENTS_SCHEMA]
})
export class DetalhesComponent implements OnInit{
  id:number = 0;
  anime!: listaBuscarAnimeResponse
  listaAnime!: listaBuscarAnimeResponse[];

  constructor(private _animeService: AnimeService, private _routeActivated: ActivatedRoute, private _router: Router) {}

  ngOnInit(): void {
    this.BuscarId()
    this.BuscarAnime();
    this.BuscarAnimes();
  }

  BuscarAnime()
  {
    this._animeService.GetById(this.id).subscribe(
      (data) => {
        this.anime = data;
        console.log(this.anime);
      },
      (error) => {
        console.error('Erro ao carregar anime', error);
      }
    )
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

  BuscarId()
  {
    this._routeActivated.params.subscribe(params => {
      this.id = +params['id'];
    });
  }

  IrDetalhes(id: number)
  {
    this._router.navigate(['detalhes', id], { queryParamsHandling: 'merge' }).then(() => {
      window.location.reload();
    });
  }
}
