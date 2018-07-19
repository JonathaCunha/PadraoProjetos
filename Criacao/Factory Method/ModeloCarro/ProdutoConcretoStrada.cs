﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Criacao.Factory_Method
{
    class ProdutoConcretoStrada : ProdutoCarro
    {
        public ProdutoConcretoStrada()
        {
            Nome = "Strada";
            tamanhoAroRoda = 14;
        }
    }
}
