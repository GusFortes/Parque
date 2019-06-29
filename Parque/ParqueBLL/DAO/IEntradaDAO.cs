using ParqueBLL.Data;
using System;

namespace ParqueBLL
{
    public interface IEntradaDAO
    {

        public bool persistirEntrada(DateTime data, int id);
        

        public  bool consultaEntrada(DateTime data, int id);
    }
}