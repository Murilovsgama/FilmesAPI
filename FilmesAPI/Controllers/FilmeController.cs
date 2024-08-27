using FilmesAPI.Models;

using Microsoft.AspNetCore.Mvc;


namespace FilmesAPI.Controllers;

[ApiController]
[Route("[Controller]")] // Nomeando assim, basicamente ele vai cortar a controller do nome e manter apenas como Filme
                      // , assim caso eu renomeie essa classe, não vou precisar mudar o nome da rota
public class FilmeController :ControllerBase
{

    private static List <Filme> filmes =  new List<Filme> ();
    private static int id = 1;

    [HttpPost]
    public void AdicionaFilme([FromBody] Filme filme)
    {

        filme.ID = id++;
        filmes.Add(filme);
        Console.WriteLine(filme.Titulo);
        Console.WriteLine(filme.Genero);
        Console.WriteLine(filme.Duracao);
    }

    public IEnumerable<Filme> RecuperaFilmes()
    {
        return filmes;
    }

    [HttpGet("{id}")]
    public Filme? RecuperarPorID(int id)
    {
      return  filmes.FirstOrDefault(filme => filme.ID == id);
    }
}
