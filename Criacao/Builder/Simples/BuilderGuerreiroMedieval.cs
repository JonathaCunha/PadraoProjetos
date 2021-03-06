﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Criacao.Builder
{
    public class BuilderGuerreiroMedieval : BuilderGuerreiro
    {
        public BuilderGuerreiroMedieval()
        {
            Guerreiro.Tipo = "Medieval";
        }
        public override void AdicionarEscudo()
        {
            Guerreiro.AdicionarEscudo("Escudo Medieval");
        }

        public override void AdicionarEspada()
        {
            Guerreiro.AdicionarEspada("Espada Medieval");
        }

        public override void AdicionarFlecha()
        {
            Guerreiro.AdicionarFlecha("Flecha Medieval");
        }
    }
}
