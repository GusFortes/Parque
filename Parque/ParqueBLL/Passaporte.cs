using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;


namespace ParqueBLL
{
    public class Passaporte
    {
        public int ID { get; set; }
        public int PassaporteID { get; }
        [Display(Name = "Nome")]
        public string NomeCliente { get; set; }
        [Display(Name = "Número de dias")]
        public int NroDias { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal ValorTotal { get; set; }
        [Display(Name = "Data Inicial")]
        [DataType(DataType.Date)]
        public DateTime DataInicial { get; set; }
        public List<CheckBoxListItem> Promocoes { get; set; }
        public  Passaporte()
        {
            Promocoes = new List<CheckBoxListItem>();
                       
        }
    }
}
