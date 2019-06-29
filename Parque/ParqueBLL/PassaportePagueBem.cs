using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParqueBLL
{
    class PassaportePagueBem: PassaporteDecorator
    {
        public PassaportePagueBem(IPassaporte umPassaporte): base(umPassaporte) { }

        public override decimal valorDoDia(int nrodia)
        {
            decimal valBase = base.valorDoDia(nrodia);

            if (NroDias < 7 )
            {
                return valBase;
            }

            return valBase - (valBase * 0.02M);
        }


        public override string ToString()
        {
            return base.ToString() + "\n\tPacote com desconto cartão PagueBem";
        }
    }
}
