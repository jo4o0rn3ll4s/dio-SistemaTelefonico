using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Threading.Tasks;

namespace telefone.models
{
    public abstract class Smartphone
    {
        // Propriedades
        public string Numero { get; set; }
        protected string Modelo { get; set; }
        protected string IMEI { get; set; }
        protected int Memoria {get; set; }

        // Métodos
        public void Ligar(){
            System.Console.WriteLine("Realizando ligação...");
        }
        public void ReceberLigacao(){
            System.Console.WriteLine("Recebendo chamada...");
        }
        public abstract void InstalarAplicativo(string nome);
    }
}