import { Component, Input, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HeaderComponent } from "../../shared/header/header.component";
import { MatIconModule } from '@angular/material/icon';
import { AnimeService } from 'src/app/core/services/anime.service';
import { listaBuscarAnimeResponse } from 'src/app/core/interfaces/listaBuscarAnimeResponse';
import { ActivatedRoute, Route } from '@angular/router';

@Component({
  selector: 'app-detalhes',
  standalone: true,
  imports: [CommonModule, HeaderComponent, MatIconModule],
  templateUrl: './detalhes.component.html',
  styleUrls: ['./detalhes.component.scss']
})
export class DetalhesComponent implements OnInit{
  id:number = 0;
  anime!: listaBuscarAnimeResponse

  constructor(private _animeService: AnimeService, private _routeActivated: ActivatedRoute) {}

  ngOnInit(): void {
    this.BuscarId()
    console.log(this.id);
    this.BuscarAnime();
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

  BuscarId()
  {
    this._routeActivated.params.subscribe(params => {
      this.id = +params['id'];
    });
  }

}
