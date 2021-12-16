using System;


namespace task5
{
    class task5
    {
        static void Main(string[] args)
        {
            int n;

            do{
                Console.Write("Please enter a number:");    
            }while(!int.TryParse(Console.ReadLine(), out n));
        
            n++;
            bool[] v = new bool[n];
            for(int i = 0; i < n; i++){
                v[i] = true;
            }

            for(int i=2;i*i<n;i++){
                if(v[i]){
                    for(int j=i*i;j<n;j+=i){
                        v[j] = false;
                    }
                }
            }

            Console.WriteLine("These numbers are prime: ");

            for(int i = 2;i<n;i++){
                if(v[i]){
                    Console.Write("{0} ", i);
                }
            }
        }
    }
}



