﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class ConversoesExplicitas : IAulaItem
    {
        public void Executar()
        {
            double divida = 1_234_358_511_852.225;
            //long copia = divida;

            double salario = 1_125.89;
            long copiaSalario = (long)salario;
            Console.WriteLine(copiaSalario);

            Animal animal = new Gato();
            Gato gato = (Gato)animal; // cast = conversao explicita
        }
    }
}
