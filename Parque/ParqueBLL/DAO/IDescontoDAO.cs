using System;
using System.Collections.Generic;
using System.Text;

namespace ParqueBLL.DAO
{
   public interface IDescontoDAO
    {
        public IEnumerable<Descontos> ConsultaDescontos();

        public Boolean AlteraDescontos(int id);

    }
}
