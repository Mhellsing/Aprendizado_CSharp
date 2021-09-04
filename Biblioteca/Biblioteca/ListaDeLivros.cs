using Biblioteca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class ListaDeLivros
    {
        public List<Livro> listaDeLivros = new List<Livro>
        {
            new Livro
            {Id = Guid.NewGuid(),
             ISBN = 216547961,
             Titulo = "O Senhor dos Anéis",
             Autor = "JRR Tolkien",
             Genero = "Fantasia",
             TipoDeMidia = Enums.TipoDeMidia.MidiaFisica
            },

            new Livro
            {Id = Guid.NewGuid(),
             ISBN = 335469873,
             Titulo = "Fundação",
             Autor = "Isaac Asimov",
             Genero = "Ficcção Científica",
             TipoDeMidia = Enums.TipoDeMidia.MidiaDigital
            }

        };
    }
}
