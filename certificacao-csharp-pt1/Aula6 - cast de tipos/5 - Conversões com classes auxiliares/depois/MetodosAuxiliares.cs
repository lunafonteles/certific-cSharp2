using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class MetodosAuxiliares : IAulaItem
    {
        public void Executar()
        {
            string textoDigitado = "123";
            //int numeroConvertido = textoDigitado; nao da certo nem com `as`

            int numeroConvertido = int.Parse(textoDigitado);
            Console.WriteLine(numeroConvertido);

            textoDigitado = "abc";
            //numeroConvertido = int.Parse(textoDigitado);
            //cuidado pra usar o parse pq ele supoe q vc esta colocando uma string numerica, que pode ser convertida pra int
            
            //o resultado é 0 pq nao consegue converter as letras pra numeros.
            if (int.TryParse(textoDigitado, out numeroConvertido)){
                Console.WriteLine(numeroConvertido);
            }
            else
            {
            Console.WriteLine("texto nao eh um numero");
            }
            textoDigitado = "R$ 123,45"; // se colocar simbolo $ eh convertido pra 0, a nao ser que seja definido que eh um valor de moeda
            decimal.TryParse(textoDigitado, 
                System.Globalization.NumberStyles.Currency, //moeda
                System.Globalization.CultureInfo.CurrentCulture, //pt-br
                out decimal valorConvertido);
            Console.WriteLine(valorConvertido);

            
        }
    }
}
