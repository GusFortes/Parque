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
        PassaporteDAO passaporteDao = new PassaporteDAO();
        ValidaEntrada validaEntrada = new ValidaEntrada();
        EntradaDAO entradaDao = new EntradaDAO();
        Passaporte passaporte;
        DescontoDAO descontoDao = new DescontoDAO();
        static Passaporte passaporteConfirmado = new Passaporte();
        IPassaporte passaporteOrcado;

        public IPassaporte CriarPassaporte(int id, String umCliente,
                                                  int umNroDias,
                                                  decimal umValorBasico,
                                                  int dia,
                                                  int mes,
                                                  int ano,
                                                  PromocoesAtivas[] descontos)
        {


            passaporteOrcado = PassaporteFactory.CriarPassaporte(id, umCliente, umNroDias, umValorBasico, dia, mes, ano, descontos);

            passaporteConfirmado.NomeCliente = passaporteOrcado.NomeCliente;
            passaporteConfirmado.NroDias = passaporteOrcado.NroDias;
            passaporteConfirmado.ValorTotal = passaporteOrcado.valorTotal();
            passaporteConfirmado.DataInicial = passaporteOrcado.DataInicial;


            return passaporteOrcado;
        }

        public List<Descontos> ConsultaDescontosHabilitados()
        {
            return descontoDao.ConsultaDescontosHabilitados();
        }

        public object ConsultaVendasPeriodo(DateTime dataInicio, DateTime dataFim)
        {
            return passaporteDao.ConsultaVendasPeriodo(dataInicio, dataFim);
        }

        public List<Entrada> ConsultaEntradaPeriodo(DateTime dataInicial, DateTime dataFinal)
        {
            return entradaDao.ConsultaEntradaPeriodo(dataInicial, dataFinal);
        }

        public Descontos ConsultaDescontosPorID(int id)
        {
            return descontoDao.ConsultaDescontoPorID(id);
        }

        public List<Passaporte> Consultames(int mes)
        {
            return passaporteDao.ConsultaVendasMes(mes);
        }

        public List<Passaporte> ConsultaDia(int dia)
        {
            return passaporteDao.ConsultaVendasDia(dia);
        }

        public Passaporte ComprarPassaporte()
        {
            return passaporteDao.persistirCompra(passaporteConfirmado);
        }

        public Boolean ConfirmarEntrada(DateTime dataEntrada, int id)
        {

            this.passaporte = passaporteDao.ConsultaPassaporte(id);
            if (this.passaporte == null)
            {
                return false;
            }
            if (entradaDao.consultaEntrada(dataEntrada, passaporte.ID))
            {
                if (validaEntrada.ValidarEntrada(dataEntrada, passaporte.DataInicial, passaporte.NroDias))
                {
                    return entradaDao.persistirEntrada(dataEntrada, passaporte.ID);
                }
            }
            return false;
        }

        public IEnumerable<Descontos> ConsultaDescontos()
        {
            return descontoDao.ConsultaDescontos();
        }
        public void AlterarDesconto(int id)
        {
            descontoDao.AlteraDescontos(id);
        }
    }
}