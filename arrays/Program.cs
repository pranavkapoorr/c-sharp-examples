using System;

namespace arrays{
    class Program{
        static String[] myArray = {"element-0","element-1","element-2","element-3","element-4","element-5","element-6","element-7","element-8","element-9"};
        static void Main(string[] args){
            foreach (var item in myArray){
                Console.WriteLine(item);
            }
        }
    }
}
