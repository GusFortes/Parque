using System;
namespace ParqueBLL
{
    public class ValidaEntrada
    {
        public Boolean ValidarEntrada(DateTime dataEntrada, DateTime dataInicial, int nroDias)
        {
            DateTime finalDate = dataInicial.AddDays(nroDias -1);
            if ((dataInicial.Ticks <= dataEntrada.Ticks) && (dataEntrada.Ticks <= finalDate.Ticks))
            {
                return true;
            }
            return false;

        }
    }
}