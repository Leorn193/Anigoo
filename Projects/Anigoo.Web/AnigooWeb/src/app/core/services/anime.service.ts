import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AnimeService {

private readonly API = 'https://localhost:7221/Api/Anime';

  constructor(private http: HttpClient) { }

  Get() : Observable<any>
  {
    return this.http.get<any>(this.API);
  }

  GetById(id:number) :Observable<any>
  {
    return this.http.get<any>(`${this.API}/${id}`)
  }
}
