using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_telefonica
{
    public class Repositorio
    {
        public List<Cidade> cidades { get; set; }=new List<Cidade>();

        public void Incluir(Cidade cidade)
        {
            cidades.Add(cidade);
        }

        public void Remover(Cidade cidade)
        {
            cidades.Remove(cidade);

        }
    }
}
