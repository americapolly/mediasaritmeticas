using System;

namespace programa {
  class Program {
    static void main(string[] args) {
      double x, y, media;
      
      Console.Write("Digite o primeiro número: ");
      x = double.Parse(Console.ReadLine());
      Console.Write("Digite o segundo número: ");
      y = double.Parse(Console.ReadLine());
      media = (x + y)/2.0;
      Console.WriteLine("Media = ", + media);
     }
    }
   } 
