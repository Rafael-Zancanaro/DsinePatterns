﻿using Strategy.Commom;
using Strategy.Interfaces;

namespace Strategy.ComCorrente
{
    public class DescontoPorCincoItens : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
            => orcamento.Itens.Count > 5
                ? orcamento.Valor * Constantes.UmPorCento
                : Proximo.Desconta(orcamento);
    }
}