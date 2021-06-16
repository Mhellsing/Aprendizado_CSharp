using Ex_Interfaces.Entities;
using System;
using System.Collections.Generic;

namespace Ex_Interfaces.Services
{
    interface IServicoDePagamentoOnline
    {
        public List<Parcelas> CalcularValorDasParcelas(double valorTotalDoContrato, DateTime dataInicialDoContrato, int numeroDeParcelas);
    }
}
