using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models;

public class Filme
{
    public int ID { get; set; }
    [Required(ErrorMessage ="Titulo do filme é obrigatório.")]
    [MaxLength(100, ErrorMessage = "O genero deve conter no máximo 100 caracteres")]
    public string Titulo { get; set; }
    [Required(ErrorMessage = "Genero do filme é obrigatório.")]
    [MaxLength(100, ErrorMessage ="O genero deve conter no máximo 100 caracteres")]
    public string Genero { get; set; }
    [Required(ErrorMessage = "Duracao do filme é obrigatório.")]
    [Range(60 , 600, ErrorMessage ="A duração do filme deve ser entre 60 e 600 minutos")]
    public int Duracao { get; set; }
}
