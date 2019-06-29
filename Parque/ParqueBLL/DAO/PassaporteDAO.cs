using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParqueBLL.Data
{
    public class PassaporteDAO : IPassaporteDAO
    {
        int count = 0;

        private readonly ParqueContext db = new ParqueContext();
        public Passaporte persistirCompra(Passaporte passaporte)
        {
            db.Passaportes.AddRange(new Passaporte {
                NomeCliente = passaporte.NomeCliente, ValorTotal= passaporte.ValorTotal,
                NroDias = passaporte.NroDias, DataInicial = passaporte.DataInicial});
            db.SaveChanges();

            var pass = from p in db.Passaportes
                       select p;

            foreach (Passaporte p in pass)
            {
                count++;
            }

            passaporte.ID = count + 1;

            return passaporte;
        }

        public Passaporte ConsultaPassaporte(int id)
        {
            var entrada = from e in db.Passaportes
                          where e.ID == id
                          select e;
            foreach (Passaporte passaporte in entrada)
            {
                return new Passaporte { ID = id, DataInicial = passaporte.DataInicial, NroDias = passaporte.NroDias };

            }
            return null;
        }

        public List<Passaporte> ConsultaComprasDia(int dia)
        {
            List<Passaporte> compras = new List<Passaporte>();

            var passaportes = from p in db.Passaportes
                              where p.DataInicial.Day == dia
                              select p;

            foreach(Passaporte passa in passaportes)
            {
                compras.Add(passa);
            }


            return compras;
        }

        public List<Passaporte> ConsultaVendasPeriodo(DateTime dataInicio, DateTime dataFim)
        {

            List<Passaporte> compras = new List<Passaporte>();
            var passaportes = from p in db.Passaportes
                              where(p.DataInicial >= dataInicio) && (p.DataInicial <= dataFim)
                              select p;
             foreach (Passaporte passa in passaportes)
            {
                compras.Add(passa);
            }

            return compras;
        }

        public List<Passaporte> ConsultaComprasMes(int mes)
        {
            List<Passaporte> compras = new List<Passaporte>();

            var passaportes = from p in db.Passaportes
                              where p.DataInicial.Month == mes
                              select p;

            foreach (Passaporte passa in passaportes)
            {
                compras.Add(passa);
            }


            return compras;
        }


    }
}
