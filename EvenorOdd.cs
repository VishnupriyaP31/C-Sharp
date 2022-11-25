using System;
namespace Practice{
    class Program{
        static void Main(string[] args){
            int n=Convert.ToInt32(Console.ReadLine());
            if(n%2==0){
                Console.WriteLine("Given number "+n+" is Even");
            }
            else{
                Console.WriteLine("Given number "+n+" is Odd");
            }
        }
    }
}
