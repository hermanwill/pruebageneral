using System;

namespace VSCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1, x2,v1,v2, salto,recorre;
            bool sino;
            const int limite=10000;

            x1=0;
            x2=2000;
            v1=2500;
            v2=2000;
            salto=0;
            sino =false;

            for (var i=x1; i<=limite;)
            {
                i=i+v1;
                salto++;

                if (i<=limite)
                {
                    recorre=0;
                    for (var x=x2; x<=limite;)
                    {
                        x=x+v2;
                        recorre++;
                        if (x==limite && i==x && salto==recorre)
                        {
                            sino=true;
                            Console.WriteLine($"Salto Final: {salto} En Posicion x1: {i} y x2: {x}");
                        }
                        else if(salto==recorre && x<=limite)
                        {
                            Console.WriteLine($"Salto: {salto} Posicion x1: {i} y x2: {x}");
                            
                        }
                    }
                }
                
            }
            if(sino)
            {
                Console.WriteLine("SI Se Cumple la Condicion");
            }
            else
            {
                Console.WriteLine("NO Se cumple la condicion");
            }
        }
    }
}
