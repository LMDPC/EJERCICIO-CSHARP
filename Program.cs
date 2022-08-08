using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Totalamountpoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] partidos = { "1:0", "2:0", "3:0", "4:0", "2:1", "3:1", "4:1", "3:2", "4:2", "4:3" };
            process objt = new process();
            Console.WriteLine("Inicia proceso");
            objt.resultado(partidos);          
            Console.WriteLine("Fin proceso");
            Console.ReadKey();

        }

        public class process
        {
            public void resultado(string[]partidos)
            {
                int Puntos = 0;
                for (int i = 0; i < partidos.Length;i++)
                {
                    #region proceso
                    Console.WriteLine("Partido: {0}", partidos[i]);
                    string ValX = partidos[i].ToString().Substring(0,1);
                    Console.WriteLine("Valor de X: {0}",ValX);
                    int IvalX = Convert.ToInt32(ValX);
                    string Valy = partidos[i].ToString().Substring(2,1);
                    Console.WriteLine("Valor de Y: {0}", Valy);
                    int Ivaly = Convert.ToInt32(Valy);

                    if (IvalX > Ivaly)
                    {
                        Puntos = Puntos + 3;
                    }
                    else if(IvalX < Ivaly)
                    {
                        Puntos = Puntos + 0;
                    }
                    else if(IvalX == Ivaly)
                    {
                        Puntos = Puntos + 1;
                    }

                    Console.WriteLine("Total de puntos por el momento es: {0}: ",Puntos);
                    #endregion

                }
            }
        }
    }
}
