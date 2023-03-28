using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_telefonica
{
    public class Repositorio
    {
        public List<Cidade> Cidades { get; set; }=new List<Cidade>();

        public void Incluir(Cidade cidade)
        {
            Cidades.Add(cidade);
        }

        public void Remover(Cidade cidade)
        {
            Cidades.Remove(cidade);

        }
    }
}
