using System;
using System.Collections.Generic;

namespace ParqueBLL.Data
{
    public interface IPassaporteDAO
    {
        public Passaporte persistirCompra(Passaporte passaporte);
        public Passaporte ConsultaPassaporte(int id);
        public List<Passaporte> ConsultaComprasDia(int dia);
        public List<Passaporte> ConsultaComprasMes(int mes);
        public List<Passaporte> ConsultaVendasPeriodo(DateTime dataInicio, DateTime dataFim);
    }
}

