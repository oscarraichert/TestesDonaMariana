using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesDonaMariana.WinApp.Repositorios
{
    public class RepositorioBase<T>
    {
        public List<T> Lista;

        public RepositorioBase()
        {
            Lista = new List<T>();
        }
    }
}
