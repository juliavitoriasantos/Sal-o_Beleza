using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salão_Beleza
{
    internal class Tipo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Status {  get; set; }
        public Tipo(int id, string nome, string status): this(nome, status)
        {
            Id = id;
            
        }
        public Tipo(string nome, string status)
        {
            this.Nome = nome;
            this.Status = status;
        }
    }
}
