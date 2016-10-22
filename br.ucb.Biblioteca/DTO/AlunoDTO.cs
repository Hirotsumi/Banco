using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.ucb.Biblioteca.DTO
{
    public class AlunoDTO
    {
        public int Id { get; set; }
        public string nome { get; set; }

        public AlunoDTO(int id, string nome)
        {
            this.Id = id;
            this.nome = nome;
        }
    }
}
