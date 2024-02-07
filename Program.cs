using estudos_cs_curso2.Classes;
/*
Banda weezer = new Banda("Weezer");

Album albumDoWeezer = new Album("Blue Album");

Musica musica1 = new Musica(weezer, "My Name Is Jonas")
{
    Duracao = 354,
    Disponivel = true,
};

Musica musica2 = new Musica(weezer, "No One Else")
{
    Duracao = 238,
    Disponivel = false,
};

albumDoWeezer.AdicionarMusica(musica1);
albumDoWeezer.AdicionarMusica(musica2);
weezer.AdicionarAlbum(albumDoWeezer);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
albumDoWeezer.ExibirMusicasDoAlbum();
weezer.ExibirDiscografia();
*/

Podcast folioes = new Podcast("Mateus Ramgund", "Foliões");
Episodio olinda = new Episodio(2, "Olinda", 53);
olinda.AdicionarConvidados("Aline Pereira");
folioes.AdicionarEpisodio(olinda);

Episodio piloto = new Episodio(1, "Piloto", 40);
piloto.AdicionarConvidados("Filipe Ramgund");
folioes.AdicionarEpisodio(piloto);

folioes.ExibirDetalhes();
Console.WriteLine(olinda.Resumo);
Console.WriteLine(piloto.Resumo);
