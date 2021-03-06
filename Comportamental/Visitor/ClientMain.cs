﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

/// <summary>
/// Representar uma operação a ser executada nos elementos de uma estrutura de objetos.
/// Visitor permite definir uma nova operação sem mudar as classes dos elementos sobre os quais opera.
/// </summary>
namespace Comportamental.Visitor
{
    public class ClientMain
    {
        public /*static*/ void Main(string[] args)
        {
            var minhaLista = new MinhaLista();
            Console.WriteLine(string.Join(",", minhaLista.ListaNumerica));
            Console.WriteLine(string.Join(",", minhaLista.ListaAlfabetica));

            Console.WriteLine("Crescente .......");
            minhaLista.AceiteVisita(new OrdenacaoCrescente());
            Console.WriteLine(string.Join(",", minhaLista.ListaNumerica));
            Console.WriteLine(string.Join(",", minhaLista.ListaAlfabetica));


            Console.WriteLine("Descrecente .....");
            minhaLista.AceiteVisita(new OrdenacaoDescendente());
            Console.WriteLine(string.Join(",", minhaLista.ListaNumerica));
            Console.WriteLine(string.Join(",", minhaLista.ListaAlfabetica));

            Console.ReadKey();
        }
    }
}
