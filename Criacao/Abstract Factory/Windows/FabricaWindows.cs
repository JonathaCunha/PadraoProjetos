﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Criacao.Abstract_Factory
{
    public class FabricaWindows : FabricaAbstrata
    {
        public override BotaoAbstrato CrieBotao()
        {
            return new BotaoWindows();
        }

        public override JanelaAbstrata CrieJanela()
        {
            return new JanelaWindows();
        }
    }
}
