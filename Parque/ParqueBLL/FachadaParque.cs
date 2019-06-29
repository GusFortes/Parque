using ParqueBLL.DAO;
using ParqueBLL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParqueBLL
{
    public class FachadaParque
    {
        PassaporteDAO compra = new PassaporteDAO();
        ValidaEntrada valida = new ValidaEntrada();
        EntradaDAO entradadao = new EntradaDAO();
        Passaporte passaporte;
        DescontoDAO descontodao = new DescontoDAO();
        static Passaporte passaporteconfirmado = new Passaporte();
        IPassaporte passaporteorcado;

        public IPassaporte CriarPassaporte(int id, String umCliente,
                                                  int umNroDias,
                                                  decimal umValorBasico,
                                                  int dia,
                                                  int mes,
                                                  int ano,
                                                  PromocoesAtivas[] descontos)
        {


            passaporteorcado = PassaporteFactory.CriarPassaporte(id, umCliente, umNroDias, umValorBasico, dia, mes, ano, descontos);

            passaporteconfirmado.NomeCliente = passaporteorcado.NomeCliente;
            passaporteconfirmado.NroDias = passaporteorcado.NroDias;
            passaporteconfirmado.ValorTotal = passaporteorcado.valorTotal();
            passaporteconfirmado.DataInicial = passaporteorcado.DataInicial;


            return passaporteorcado;
        }

        public List<Descontos> ConsultaDescontosHabilitados()
        {
            return descontodao.ConsultaDescontosHabilitados();
        }

        public object ConsultaVendasPeriodo(DateTime dataInicio, DateTime dataFim)
        {
            return compra.ConsultaVendasPeriodo(dataInicio, dataFim);
        }

        public List<Passaporte> Consultames(int mes)
        {
            return compra.ConsultaComprasMes(mes);
        }

        public List<Passaporte> ConsultaDia(int dia)
        {
            return compra.ConsultaComprasDia(dia);
        }

        public Passaporte ComprarPassaporte()
        {
          return compra.persistirCompra(passaporteconfirmado);         
        }

        public Boolean ConfirmarEntrada(DateTime dataEntrada, int id)
        {

            this.passaporte = compra.ConsultaPassaporte(id);
            if (this.passaporte == null)
            {
                return false;
            }
            if (entradadao.consultaEntrada(dataEntrada, passaporte.ID))
            {
                if (valida.ValidarEntrada(dataEntrada, passaporte.DataInicial, passaporte.NroDias))
                {
                    return entradadao.persistirEntrada(dataEntrada, passaporte.ID);
                }
            }
            return false;
        }

        public IEnumerable<Descontos> ConsultaDescontos()
        {
            return descontodao.ConsultaDescontos();
        }
        public void AlterarDesconto(int id)
        {
            descontodao.AlteraDescontos(id);
        }
    }
}