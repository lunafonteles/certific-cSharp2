using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class OperadoresISeAS : IAulaItem
    {
        public void Executar()
        {
            Animal animal = new Animal();
            Gato gato = new Gato();
            Cliente cliente = new Cliente("José da Silva", 30);

            Alimentar(animal);
            Alimentar(animal);
            Alimentar(cliente);
        }

        //public void Alimentar(object obj)
        //{
        //    Animal animal = null;
        //    if (obj is Animal)
        //    {
        //        animal = (Animal)obj;
        //    }
        //    {
        //        if (animal == null)
        //        {
        //            Console.WriteLine("obj nao eh um animal");
        //        }
        //        else
        //        {
        //            animal.Beber();
        //            animal.Comer();
        //        }
        //    }
        //}

        //uma forma mais simplificada 
        //public void Alimentar(object obj)
        //{
        //    Animal animal = obj as Animal;

        //        if (animal == null)
        //        {
        //            Console.WriteLine("obj nao eh um animal");
        //            return;
        //        }
        //        animal.Beber();
        //        animal.Comer();
        //    }

        //}


        //uma outra forma
        public void Alimentar(object obj)
        {
            if (obj is Animal animal)
            {
                animal.Beber();
                animal.Comer();
                return;
            }
            Console.WriteLine("obj nao eh um animal");
        }

    }
}

