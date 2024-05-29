using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace telefone.models
{
    public class Nokia : Smartphone
    {
        // Construtores
        public Nokia(){}
        public Nokia(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        // Métodos
        public override void InstalarAplicativo(string nome)
        {
            System.Console.WriteLine($"Buscando {nome} na microsoft store...");
        }
    }
}