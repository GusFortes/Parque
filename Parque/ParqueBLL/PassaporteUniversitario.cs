using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParqueBLL
{
    class PassaporteUniversitario : PassaporteDecorator
    {
        public PassaporteUniversitario(IPassaporte umPassaporte) : base(umPassaporte) { }

        public override decimal valorDoDia(int nrodia)
        {
            decimal valBase = base.valorDoDia(nrodia);

            if (NroDias < 5 || nrodia == 1)
            {
                return valBase;
            }

            return valBase - (valBase * 0.10M);
        }


        public override string ToString()
        {
            return base.ToString() + "\n\tPacote com desconto universitário";
        }
    }
}
