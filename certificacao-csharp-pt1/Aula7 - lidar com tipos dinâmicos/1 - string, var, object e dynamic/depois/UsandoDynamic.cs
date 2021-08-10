using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class UsandoDynamic : IAulaItem
    {
        public void Executar()
        {
            //tipo é definido na compilação
            string s = "certificação c#";
            //tipo é definido na compilação (por inferencia)
            var v = "certificação c#";
            //tipo é definido na compilação
            object o = "certificação c#";
            //tipo é definido na execução, por isso as operações nao aparecem
            dynamic d = "certificação c#";

            Console.WriteLine(s);
            Console.WriteLine(v);
            Console.WriteLine(o);
            Console.WriteLine(d);

            s = s.ToUpper();
            v = v.ToUpper();
            o = ((string)o).ToUpper();
            d = d.ToUpper();

            Console.WriteLine(s);
            Console.WriteLine(v);
            Console.WriteLine(o);
            Console.WriteLine(d);

            //s = 123;
            o = 123;
            d = 123;

            o = (int)o + 4;
            d = d + 4;
            Console.WriteLine(o);
            Console.WriteLine(d);

        }
    }
}
