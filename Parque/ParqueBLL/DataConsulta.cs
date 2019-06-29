using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace ParqueBLL
{
    public class DataConsulta
    {
        [Display(Name = "De:")]
        [DataType(DataType.Date)]
        public DateTime DataInicial { get; set; }
        [Display(Name = "Até:")]
        [DataType(DataType.Date)]
        public DateTime DataFinal { get; set; }
        public int Mes { get; set; }
        public int Dia { get; set; }
    }
}
