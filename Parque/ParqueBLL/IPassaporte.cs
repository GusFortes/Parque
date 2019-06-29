using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace ParqueBLL
{
    public interface IPassaporte
    {
        int ID { get; set; }
        int PassaporteID { get; }
        String NomeCliente { get; }
        int NroDias { get; }
        decimal ValorBasico { get; }
        DateTime DataInicial { get; }
        decimal valorDoDia(int nrodia);
        decimal valorTotal();

    }
}