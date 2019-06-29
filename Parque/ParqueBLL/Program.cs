using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ParqueBLL
{
    class Program
    {
        static void Main(string[] args)
        {

            FachadaParque fachada = new FachadaParque();
            PromocoesAtivas promocoesuni = PromocoesAtivas.UNIVERSITARIO;
            PromocoesAtivas[] descontouni = { promocoesuni };

            PromocoesAtivas promocoesidoso = PromocoesAtivas.IDOSO;
            PromocoesAtivas[] descontoidoso = { promocoesidoso };

            PromocoesAtivas promocoespague = PromocoesAtivas.PAGUEBEM;
            PromocoesAtivas[] descontopague = { promocoespague };

            PromocoesAtivas promocoesseguro = PromocoesAtivas.SEGUROGARANTIDO;
            PromocoesAtivas[] descontoseguro = { promocoesseguro };

            using (var db = new ParqueContext())
            {

                if (db.Passaportes.Count() == 0)
                {
                    Seed(db);
                }
            }

         //  Console.WriteLine("Orçamento para igresso de 6 dias para estudante:");
         //  Console.ReadKey();
         //  IPassaporte passaporteuni = fachada.CriarPassaporte(1234, "João", 6, 100, 18, 7, 2019, descontouni);
         //
         //  Console.WriteLine("Valor total {0}", passaporteuni.valorTotal());
         //  Console.ReadKey();
         //
         //  Console.WriteLine("Orçamento para igresso de 5 dias para idoso:");
         //  Console.ReadKey();
         //  IPassaporte passaporteidoso = fachada.CriarPassaporte(543, "Maria", 6, 100, 7, 5, 2019, descontoidoso);
         //
         //  Console.WriteLine("Valor total {0}", passaporteidoso.valorTotal());
         //  Console.ReadKey();
         //
         //  Console.WriteLine("Orçamento para igresso de 4 dias para cartão PAGUEBEM:");
         //  Console.ReadKey();
         //  IPassaporte passaportepague = fachada.CriarPassaporte(654, "José", 4, 100, 1, 1, 2019, descontouni);
         //
         //  Console.WriteLine("Valor total {0}", passaportepague.valorTotal());
         //  Console.ReadKey();
         //
         //  Console.WriteLine("Orçamento para igresso de 3 dias para Segurados do SEGURO GARANTIDO:");
         //  Console.ReadKey();
         //  IPassaporte passaporteseguro = fachada.CriarPassaporte(765, "Manoel", 3, 100, 8, 12, 2019, descontouni);
         //
         //  Console.WriteLine("Valor total {0}", passaporteseguro.valorTotal());
         //  Console.ReadKey();
         //
         //
         //  if (fachada.ComprarPassaporte(fachada.CriarPassaporte(8765, "João", 6, 100, 13, 8, 2019, descontouni)))
         //  {
         //      Console.WriteLine("Passaporte de João comprado.");
         //  }
         //  else
         //  {
         //      Console.WriteLine("Não foi possível comprar o ingresso.");
         //  }
         //  Console.ReadKey();
         //  if (fachada.ConfirmarEntrada(new DateTime(2019, 4, 23), 102))
         //  {
         //      Console.WriteLine("Entrada confirmada.");
         //  }
         //  else
         //  {
         //      Console.WriteLine("Não é possível realizar a entrada novamente");
         //  }
         //  Console.ReadKey();


            #region #populando o banco
            static void Seed(ParqueContext context)
            {
                Console.WriteLine("Populando");

                var passaportes = new List<Passaporte> {

new Passaporte    {NomeCliente = "Manny Lorman", NroDias = 1, DataInicial = DateTime.Parse("3/12/2019",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Petra Haney`", NroDias = 5, DataInicial = DateTime.Parse("2/4/2019",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Dennie Vashchenko", NroDias = 6, DataInicial = DateTime.Parse("4/8/2019",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Colet Tarply", NroDias = 3, DataInicial = DateTime.Parse("12/15/2018",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Cody Duthie", NroDias = 2, DataInicial = DateTime.Parse("4/14/2019",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Robin Beneze", NroDias = 7, DataInicial = DateTime.Parse("11/13/2018",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Colene Dossit", NroDias = 4, DataInicial = DateTime.Parse("8/19/2018",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Jonis Bohey", NroDias = 1, DataInicial = DateTime.Parse("2/7/2019",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Ricky Bartle", NroDias = 2, DataInicial = DateTime.Parse("11/1/2018",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Cori Sibbson", NroDias = 3, DataInicial = DateTime.Parse("5/3/2019",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Elvyn Lynagh", NroDias = 4, DataInicial = DateTime.Parse("12/7/2018",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Brody Nattriss", NroDias = 5, DataInicial = DateTime.Parse("6/4/2018",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Gail Beardall", NroDias = 6, DataInicial = DateTime.Parse("5/9/2019",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Veda Parrot", NroDias = 7, DataInicial = DateTime.Parse("8/17/2018",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Deeann Theze", NroDias = 1, DataInicial = DateTime.Parse("6/10/2018",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Denis Cowper", NroDias = 2, DataInicial = DateTime.Parse("10/28/2018",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Cullin Spring", NroDias = 3, DataInicial = DateTime.Parse("10/16/2018",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Stan Wardrop", NroDias = 4, DataInicial = DateTime.Parse("10/6/2018",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Linell Garton", NroDias = 5, DataInicial = DateTime.Parse("6/10/2018",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Kimberlee McEneny", NroDias = 6, DataInicial = DateTime.Parse("4/7/2019",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Marybeth Clemensen", NroDias = 7, DataInicial = DateTime.Parse("5/1/2019",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Helena Hoy", NroDias = 1, DataInicial = DateTime.Parse("7/7/2018",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Tarrah Pates", NroDias = 2, DataInicial = DateTime.Parse("3/2/2019",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Kessia Deniskevich", NroDias = 3, DataInicial = DateTime.Parse("4/18/2019",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Kassia Moran", NroDias = 4, DataInicial = DateTime.Parse("10/30/2018",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Lesly Trayes", NroDias = 5, DataInicial = DateTime.Parse("8/31/2018",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Orland Casellas", NroDias = 6, DataInicial = DateTime.Parse("7/28/2018",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Garry Vardon", NroDias = 7, DataInicial = DateTime.Parse("6/19/2018",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Karon Chaffey", NroDias = 1, DataInicial = DateTime.Parse("11/9/2018",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Georgeanne Hegdonne", NroDias = 2, DataInicial = DateTime.Parse("7/24/2018",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Muriel Woodcraft", NroDias = 3, DataInicial = DateTime.Parse("11/17/2018",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Edlin Woolbrook", NroDias = 4, DataInicial = DateTime.Parse("12/23/2018",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Garald Shillington", NroDias = 5, DataInicial = DateTime.Parse("11/13/2018",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Holly-anne Sprigin", NroDias = 6, DataInicial = DateTime.Parse("9/13/2018",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Berte Lusted", NroDias = 7, DataInicial = DateTime.Parse("12/18/2018",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Creight Hargey", NroDias = 1, DataInicial = DateTime.Parse("9/25/2018",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Malachi Densell", NroDias = 2, DataInicial = DateTime.Parse("11/27/2018",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Garnet Ninnotti", NroDias = 3, DataInicial = DateTime.Parse("4/21/2019",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Markus Twiddell", NroDias = 4, DataInicial = DateTime.Parse("4/7/2019",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Branden Jarrard", NroDias = 5, DataInicial = DateTime.Parse("1/28/2019",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Kipper Cleare", NroDias = 6, DataInicial = DateTime.Parse("10/30/2018",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Deeyn McDougle", NroDias = 7, DataInicial = DateTime.Parse("2/2/2019",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Haywood Ciotto", NroDias = 1, DataInicial = DateTime.Parse("4/2/2019",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Selene McCullagh", NroDias = 2, DataInicial = DateTime.Parse("7/13/2018",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Marilee Gusticke", NroDias = 3, DataInicial = DateTime.Parse("5/14/2019",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Bianka Darridon", NroDias = 4, DataInicial = DateTime.Parse("10/2/2018",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Gauthier Moston", NroDias = 5, DataInicial = DateTime.Parse("5/3/2019",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Cele Emmanuel", NroDias = 6, DataInicial = DateTime.Parse("11/26/2018",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Jobie Dalby", NroDias = 7, DataInicial = DateTime.Parse("4/24/2019",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Maxie MacConnal", NroDias = 1, DataInicial = DateTime.Parse("12/31/2018",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Thomasine Ferrara", NroDias = 2, DataInicial = DateTime.Parse("10/8/2018",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Clarette Leer", NroDias = 3, DataInicial = DateTime.Parse("12/13/2018",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Monroe Rochester", NroDias = 4, DataInicial = DateTime.Parse("2/7/2019",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Olga Mallard", NroDias = 5, DataInicial = DateTime.Parse("8/18/2018",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Penn Dusting", NroDias = 6, DataInicial = DateTime.Parse("6/16/2018",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Lay Gravatt", NroDias = 7, DataInicial = DateTime.Parse("12/30/2018",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Jodi Dymock", NroDias = 1, DataInicial = DateTime.Parse("1/14/2019",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Jaymie Velden", NroDias = 2, DataInicial = DateTime.Parse("4/24/2019",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Ignaz Ellinor", NroDias = 3, DataInicial = DateTime.Parse("7/12/2018",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Tabina Sheirlaw", NroDias = 4, DataInicial = DateTime.Parse("10/31/2018",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Fabian Petras", NroDias = 5, DataInicial = DateTime.Parse("7/20/2018",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Josephina Kew", NroDias = 6, DataInicial = DateTime.Parse("4/4/2019",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Horton Hatwells", NroDias = 7, DataInicial = DateTime.Parse("12/23/2018",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Darci Besnardeau", NroDias = 1, DataInicial = DateTime.Parse("6/8/2018",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Ritchie Jerams", NroDias = 2, DataInicial = DateTime.Parse("1/25/2019",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Kizzie Toxell", NroDias = 3, DataInicial = DateTime.Parse("12/20/2018",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Sibyl Downer", NroDias = 4, DataInicial = DateTime.Parse("6/15/2018",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "My Pinckney", NroDias = 5, DataInicial = DateTime.Parse("3/23/2019",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Libby Sidgwick", NroDias = 6, DataInicial = DateTime.Parse("7/21/2018",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Orren Purrier", NroDias = 7, DataInicial = DateTime.Parse("7/27/2018",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Meade Kerwick", NroDias = 1, DataInicial = DateTime.Parse("9/25/2018",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Anjanette Wemes", NroDias = 2, DataInicial = DateTime.Parse("11/15/2018",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Florie Bedbury", NroDias = 3, DataInicial = DateTime.Parse("4/8/2019",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Ardeen Lathwell", NroDias = 4, DataInicial = DateTime.Parse("11/19/2018",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Rosalyn Dagnall", NroDias = 5, DataInicial = DateTime.Parse("5/3/2019",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Petrina Dumingos", NroDias = 6, DataInicial = DateTime.Parse("6/4/2018",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Heda Livezey", NroDias = 7, DataInicial = DateTime.Parse("9/4/2018",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Mitchael Edeler", NroDias = 1, DataInicial = DateTime.Parse("7/27/2018",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Kahaleel Puckey", NroDias = 2, DataInicial = DateTime.Parse("1/2/2019",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Leticia Sarten", NroDias = 3, DataInicial = DateTime.Parse("3/22/2019",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Salomo Plank", NroDias = 4, DataInicial = DateTime.Parse("2/25/2019",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Ceciley Knight", NroDias = 5, DataInicial = DateTime.Parse("12/24/2018",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Alphard Edmund", NroDias = 6, DataInicial = DateTime.Parse("5/20/2019",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Flossie Yabsley", NroDias = 7, DataInicial = DateTime.Parse("10/8/2018",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Adela Liebrecht", NroDias = 1, DataInicial = DateTime.Parse("3/24/2019",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Danette Hinrichsen", NroDias = 2, DataInicial = DateTime.Parse("11/5/2018",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Wanda Hallifax", NroDias = 3, DataInicial = DateTime.Parse("5/10/2019",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Jarred Wrightam", NroDias = 4, DataInicial = DateTime.Parse("8/20/2018",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Lodovico Petrecz", NroDias = 5, DataInicial = DateTime.Parse("8/12/2018",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Cristionna Josebury", NroDias = 6, DataInicial = DateTime.Parse("7/3/2018",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Benito Ellsom", NroDias = 7, DataInicial = DateTime.Parse("9/13/2018",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Carolin Bletcher", NroDias = 1, DataInicial = DateTime.Parse("3/19/2019",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Rosene Monnoyer", NroDias = 2, DataInicial = DateTime.Parse("11/4/2018",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Joni Purdom", NroDias = 3, DataInicial = DateTime.Parse("2/13/2019",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Violet Ratnage", NroDias = 4, DataInicial = DateTime.Parse("11/4/2018",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Joly Karolyi", NroDias = 5, DataInicial = DateTime.Parse("11/24/2018",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Florida Schollick", NroDias = 6, DataInicial = DateTime.Parse("7/17/2018",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Leda Egleton", NroDias = 7, DataInicial = DateTime.Parse("2/25/2019",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Wileen Collabine", NroDias = 1, DataInicial = DateTime.Parse("7/12/2018",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Andros Yerrington", NroDias = 2, DataInicial = DateTime.Parse("2/20/2019",new CultureInfo("en-US"))},
new Passaporte    {NomeCliente = "Rosemary Raddish", NroDias = 3, DataInicial = DateTime.Parse("5/1/2019",new CultureInfo("en-US"))}
                  };

                var entradas = new List<Entrada> {
                new Entrada { DataEntrada = DateTime.Parse("3/12/2019", new CultureInfo("en-US")), PassaporteID = 1 },
               new Entrada { DataEntrada = DateTime.Parse("4/14/2019", new CultureInfo("en-US")), PassaporteID = 2 },
               new Entrada { DataEntrada = DateTime.Parse("12/16/2018", new CultureInfo("en-US")), PassaporteID = 3 },
               new Entrada { DataEntrada = DateTime.Parse("8/20/2018", new CultureInfo("en-US")), PassaporteID = 4 },
               new Entrada { DataEntrada = DateTime.Parse("2/04/2019", new CultureInfo("en-US")), PassaporteID = 5 },
               new Entrada { DataEntrada = DateTime.Parse("4/10/2019", new CultureInfo("en-US")), PassaporteID = 6 },
               new Entrada { DataEntrada = DateTime.Parse("11/16/2018", new CultureInfo("en-US")), PassaporteID = 7 },
               new Entrada { DataEntrada = DateTime.Parse("2/07/2019", new CultureInfo("en-US")), PassaporteID = 8 },
               new Entrada { DataEntrada = DateTime.Parse("11/01/2018", new CultureInfo("en-US")), PassaporteID = 9 },
               new Entrada { DataEntrada = DateTime.Parse("5/3/2019", new CultureInfo("en-US")), PassaporteID = 10 },
               new Entrada { DataEntrada = DateTime.Parse("12/7/2018", new CultureInfo("en-US")), PassaporteID = 11 },
               new Entrada { DataEntrada = DateTime.Parse("6/4/2018", new CultureInfo("en-US")), PassaporteID = 12 },
               new Entrada { DataEntrada = DateTime.Parse("5/9/2019", new CultureInfo("en-US")), PassaporteID = 13 },
               new Entrada { DataEntrada = DateTime.Parse("8/17/2018", new CultureInfo("en-US")), PassaporteID = 14 },
               new Entrada { DataEntrada = DateTime.Parse("8/18/2018", new CultureInfo("en-US")), PassaporteID = 14 },
               new Entrada { DataEntrada = DateTime.Parse("8/19/2018", new CultureInfo("en-US")), PassaporteID = 14 },
               new Entrada { DataEntrada = DateTime.Parse("8/20/2018", new CultureInfo("en-US")), PassaporteID = 14 },
               new Entrada { DataEntrada = DateTime.Parse("8/21/2018", new CultureInfo("en-US")), PassaporteID = 14 },
               new Entrada { DataEntrada = DateTime.Parse("8/22/2018", new CultureInfo("en-US")), PassaporteID = 14 },
               new Entrada { DataEntrada = DateTime.Parse("8/23/2018", new CultureInfo("en-US")), PassaporteID = 14 },
               new Entrada { DataEntrada = DateTime.Parse("6/10/2018", new CultureInfo("en-US")), PassaporteID = 15 },
               new Entrada { DataEntrada = DateTime.Parse("10/28/2018", new CultureInfo("en-US")), PassaporteID = 16 },
               new Entrada { DataEntrada = DateTime.Parse("10/29/2018", new CultureInfo("en-US")), PassaporteID = 16 },
               new Entrada { DataEntrada = DateTime.Parse("10/16/2018", new CultureInfo("en-US")), PassaporteID = 17 },
               new Entrada { DataEntrada = DateTime.Parse("10/6/2018", new CultureInfo("en-US")), PassaporteID = 18 },
               new Entrada { DataEntrada = DateTime.Parse("6/10/2018", new CultureInfo("en-US")), PassaporteID = 19 },
               new Entrada { DataEntrada = DateTime.Parse("4/7/2019", new CultureInfo("en-US")), PassaporteID = 20 },
               new Entrada { DataEntrada = DateTime.Parse("5/1/2019", new CultureInfo("en-US")), PassaporteID = 21 },
               new Entrada { DataEntrada = DateTime.Parse("7/7/2018", new CultureInfo("en-US")), PassaporteID = 22 },
               new Entrada { DataEntrada = DateTime.Parse("3/2/2019", new CultureInfo("en-US")), PassaporteID = 23 },
               new Entrada { DataEntrada = DateTime.Parse("4/18/2019", new CultureInfo("en-US")), PassaporteID = 24 },
               new Entrada { DataEntrada = DateTime.Parse("10/30/2018", new CultureInfo("en-US")), PassaporteID = 25 },
               new Entrada { DataEntrada = DateTime.Parse("8/31/2018", new CultureInfo("en-US")), PassaporteID = 26 },
               new Entrada { DataEntrada = DateTime.Parse("7/28/2018", new CultureInfo("en-US")), PassaporteID = 27 },
               new Entrada { DataEntrada = DateTime.Parse("6/19/2018", new CultureInfo("en-US")), PassaporteID = 28 },
               new Entrada { DataEntrada = DateTime.Parse("1/9/2018", new CultureInfo("en-US")), PassaporteID = 29 },
               new Entrada { DataEntrada = DateTime.Parse("7/24/2018", new CultureInfo("en-US")), PassaporteID = 30 }
            };
                var descontos = new List<Descontos>
                {
                    new Descontos {NomeDesconto = "UNIVERSITARIO", Status= "HABILITADO"},
                    new Descontos {NomeDesconto = "PAGUEBEM", Status= "DESABILITADO"},
                    new Descontos {NomeDesconto = "IDOSO", Status= "HABILITADO"},
                    new Descontos {NomeDesconto = "SEGUROGARANTIDO", Status= "HABILITADO"}
                };
                context.Passaportes.AddRange(passaportes);
                context.SaveChanges();
                context.Entrada.AddRange(entradas);
                context.SaveChanges();
                context.Desconto.AddRange(descontos);
                context.SaveChanges();
                #endregion
            }

        }
    }
}

