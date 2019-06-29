using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;


namespace ParqueBLL
{
    public class Entrada
    {
      //  public Entrada()
      //  {
      //  }
      //
      //  public Entrada(DateTime dataEntrada, int passaporteID)
      //  {
      //
      //      DataEntrada = dataEntrada;
      //      PassaporteID = passaporteID;
      //  }

        public int ID { get; set; }
        [Display(Name = "Data da Entrada")]
        [DataType(DataType.Date)]
        public DateTime DataEntrada { get; set; }
        [Display(Name = "ID do Passaporte")]
        public int PassaporteID { get; set; }
        public Passaporte Passaporte { get; set; }

    }
}
