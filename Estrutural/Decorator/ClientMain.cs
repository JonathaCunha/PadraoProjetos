﻿using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Dinamicamente(em tempo de execução), agregar responsabilidades adicionais a objetos.
/// Os Decorators fornecem uma alternativa flexível ao uso de subclasses para extensão de funcionalidades.
/// </summary>
namespace Estrutural.Decorator
{
    class ClientMain
    {
        public static void Main(string[] args)
        {
            APIAplicacao api = new DecotatorAPIComLog();
            api.ObtenhaNomesDeClientes();
            Console.ReadKey();
        }
    }
}