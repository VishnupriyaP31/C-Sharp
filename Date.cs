using System;
class Program{
    static void Main(string[] args){
        Program sc=new Program();
        sc.TodayDate();
    }
    void TodayDate(){
        DateTime date=DateTime.Now;
        Console.WriteLine(date.ToString("dd/mm/yyyy"));
    }
}
