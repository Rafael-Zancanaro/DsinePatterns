﻿using Strategy.Commom;
using Strategy.Interfaces;

namespace Strategy.ComCorrente
{
    public class DescontoPorMaisDeQuinhentosReais : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
            => orcamento.Valor > Constantes.ValorQuinhentos
                ? orcamento.Valor * Constantes.IcccJurusMedio
                : Proximo.Desconta(orcamento);
    }
}