﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Criacao.Builder
{
    public class BuilderGuerreiroFuturo : BuilderGuerreiro
    {
        public BuilderGuerreiroFuturo()
        {
            Guerreiro.Tipo = "Futuro";
        }

        public override void AdicionarEscudo()
        {
            Guerreiro.AdicionarEscudo("Escudo do Futuro");
        }

        public override void AdicionarEspada()
        {
            Guerreiro.AdicionarEspada("Espada do Futuro");
        }

        public override void AdicionarFlecha()
        {
            Guerreiro.AdicionarFlecha("Flecha");
        }
    }
}
