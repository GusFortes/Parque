using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ParqueBLL
{
    class EntradaDAO : IEntradaDAO
    {
        private readonly ParqueContext db = new ParqueContext();


        public bool persistirEntrada(DateTime data, int id)
        {
            db.Entrada.Add(new Entrada { DataEntrada = data, PassaporteID = id });
            db.SaveChanges();
            return true;
        }

        public Boolean consultaEntrada(DateTime data, int id)
        {
            var entradas = from p in db.Entrada
                           where p.PassaporteID == id
                           select p;
            foreach (Entrada entrada in entradas)
            {
                if (entrada.DataEntrada == data)
                {
                    return false;
                }
            }
            return true;
        }

        internal List<Entrada> ConsultaEntradaPeriodo(DateTime dataInicial, DateTime dataFinal)
        {
            List<Entrada> entradas = new List<Entrada>();
            var ent = from e in db.Entrada
                              where (e.DataEntrada >= dataInicial) && (e.DataEntrada <= dataFinal)
                              select e;
            foreach (Entrada entrada in ent)
            {
                entradas.Add(entrada);
            }

            return entradas;
        }
    }
}
