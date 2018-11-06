using System;

namespace TestTuesday
{
    class Program
    {
        static void Main(string[] args)
        {
        
           
            int[] number = new int[4];
            int[] Cheques = new int[3];
            int Maxnumber = 0;
          
            for(int i=0;i<number.Length;i++){
                Console.Write("Enter amount #"+(i+1)+": ");
                number[i]=int.Parse(Console.ReadLine());
                if(number[i] > Maxnumber){
                    Maxnumber = number[i];
                }
                else if(number[i] > Maxnumber){
                    Maxnumber = number[i];
                }
            }

            Console.WriteLine("You shold write the following cheques");
            if(Maxnumber%2 == 1){
          
                for(int j=0;j<Cheques.Length;j++){
                    if(j == 0)
                    {
                        Cheques[j] = 5;
                        Maxnumber -= 5;
                    }
                    else if(j == 1)
                    {
                        Maxnumber = Maxnumber - (5*2);
                        Cheques[j] = (5*2);
                    }
                    else
                    {
                        Cheques[j] = Maxnumber;
                    }
                    Console.WriteLine("#{0} {1}",j+1, Cheques[j]);
                }
            }
            else
            {
                 for(int j=0;j<Cheques.Length;j++){
                    if(j == 0)
                    {
                        Cheques[j] = Maxnumber/4;
                        Maxnumber = (Cheques[j]*2);
                    }
                    else if(j == 1)
                    {
                        Cheques[j] = Maxnumber/2;
                    }
                    else
                    {
                        Cheques[j] = Cheques[0]+Cheques[1];
                    }
                    Console.WriteLine("#{0} {1}",j+1, Cheques[j]);
                }
            }
            
        }
    }
}
