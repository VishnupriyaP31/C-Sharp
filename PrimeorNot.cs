using System;
namespace Practice{
    class Program{
        static void Main(string[] args){
            int n=Convert.ToInt32(Console.ReadLine());
            if((n%2!=0 && n%3!=0 && n%5!=0 && n%7!=0)||(n==2 || n==3 || n==5 || n==7)){
                Console.WriteLine("Given number is Prime");
            }
            else{
                Console.WriteLine("Given number is not Prime");
            }
        }
    }
}
