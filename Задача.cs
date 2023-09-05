/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
    static void SwitchFinger(int fingers){
        switch (fingers)
        {
            case 1:
            Console.WriteLine("Большой палец!");
            break;
            
            case 2:
            Console.WriteLine("Указательный палец!");
            break;
            
            case 3:
            Console.WriteLine("Средниq палец!");
            break;
            
            case 4:
            Console.WriteLine("палец!");
            break;
            
            case 5:
            Console.WriteLine("Мизинец!");
            break;
            
            default:
            Console.WriteLine("Введите число от 1 до 5");
            break;
        }
    }
  static void Main() {
    
    Console.Write("Введите число для определения:");
    int fingers = Convert.ToInt32(Console.ReadLine());
    
    int finger1 = fingers % 10;
    int finger2 = fingers / 10;
    
    
    HelloWorld.SwitchFinger(finger1);
    HelloWorld.SwitchFinger(finger2);
  }
}
