using Biblioteca.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Models
{
    public class Livro
    {
        public Guid Id { get; set; }
        public long ISBN { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Genero { get; set; }
        public TipoDeMidia TipoDeMidia { get; set; }
    }    
}
