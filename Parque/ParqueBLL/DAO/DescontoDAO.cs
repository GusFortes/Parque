using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ParqueBLL.DAO
{
    public class DescontoDAO : IDescontoDAO
    {
        private readonly ParqueContext db = new ParqueContext();

        public bool AlteraDescontos(int id)
        {
            var descontos = from d in db.Desconto
                            where d.ID == id
                            select d;

            foreach (Descontos d in descontos)
            {
                if (d.Status == "HABILITADO")
                {
                    d.Status = "DESABILITADO";
                    //             
                }
                else
                {
                    d.Status = "HABILITADO";
                    //db.SaveChanges();
                }
            }
            db.SaveChanges();
            return true;
        }

        public IEnumerable<Descontos> ConsultaDescontos()
        {
            return db.Desconto.AsEnumerable();
        }
        
        public List <Descontos> ConsultaDescontosHabilitados()
        {
            List<Descontos> descontoshabilitados = new List<Descontos>();
            var descontos = from d in db.Desconto
                            where d.Status == "HABILITADO"
                            select d;
            foreach(Descontos descontosativos in descontos)
            {
                descontoshabilitados.Add(descontosativos);
            }
            return descontoshabilitados;
        }

    }
}
