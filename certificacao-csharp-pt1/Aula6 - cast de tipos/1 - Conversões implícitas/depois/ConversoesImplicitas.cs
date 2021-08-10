using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class ConversoesImplicitas : IAulaItem
    {
        public void Executar()
        {
            int inteiro = 8_945_223_34;
            long inteirolongo = inteiro;
            Console.WriteLine(inteirolongo);

            Gato gato = new Gato();
            Animal animal = gato;
            Console.WriteLine(animal.GetType());
            IAnimal ianimal = gato;
            Console.WriteLine(ianimal.GetType());
            
                
        }
    }
}

