export interface listaBuscarAnimeResponse
{
  id: number,
  nomeAnime: string,
  autor: string,
  lancamento: number,
  temporadas: number,
  episodios: number,
  classificacao: number,
  finalizado: boolean,
  sinopse: string,
  caminhoImagem: string,
  nomeGenero: string[],
  nomeStreaming: string[],
  avaliacao: number,
}
