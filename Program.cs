using estudos_cs_curso2.Classes;

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