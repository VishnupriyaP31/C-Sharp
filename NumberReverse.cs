using System;
namespace Practice{
    class Reverse{
        static void Main(string[] args){
            int n=Convert.ToInt32(Console.ReadLine());
            int temp=n,r,res=0;
            while(n>0){
                r=n%10;
                res=res*10+r;
                n=n/10;
            }
            Console.WriteLine(res);
        }
    }
}
