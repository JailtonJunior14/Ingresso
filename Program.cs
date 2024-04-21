using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ingresso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contM =0, contI =0;
		   double contVM =0, contVI =0;
		    for (int lote=1; lote <= 30; lote++) 
			{
                if (lote <= 10) 
				{
                    Console.WriteLine("Meia[M] Inteira[I] Lote I");
					string ing = Console.ReadLine().ToLower().Substring(0,1);
					switch (ing) {
                        case "m":
						    contM++;
						    contVM += 100/2;
						break;
						case "i":
						    contI++;
							contVI+= 100;
						break;
						
                    }
                }
				else if (lote <= 20) 
				{
                    Console.WriteLine("Meia[M] Inteira[I] Lote II");
					string ing = Console.ReadLine().ToLower().Substring(0,1);
					switch (ing) {
                        case "m":
						    contM++;
						    contVM += 150/2;
						break;
						case "i":
						    contI++;
							contVI+= 150;
						break;
						
                    }
                }
				else if (lote <=30)
				{
                    Console.WriteLine("Meia[M] Inteira[I] Lote III");
					string ing = Console.ReadLine().ToLower().Substring(0,1);
					switch (ing) {
                        case "m":
						    contM++;
						    contVM += 200/2;
						break;
						case "i":
						    contI++;
							contVI+= 200;
						break;
						
                    }
                }
            }
			Console.WriteLine("Total faturado: " + (contVM+contVI).ToString("C"));
			Console.WriteLine("Total meia: " + contVM.ToString("C"));
			Console.WriteLine("Total inteira: " + contVI.ToString("C"));
			Console.ReadKey();
        }
    }
}
