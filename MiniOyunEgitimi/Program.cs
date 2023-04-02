using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniOyunEgitimi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Min ve Max isminde iki fonksiyon; girilen ikişer parametrenin hangisinin büyük ve hangisinin küçük olduğunu döndürmeliler
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int MinNum = NewMath.Min(num1, num2);
            int MaxNum = NewMath.Max(num1, num2);


            //Factoriel isminde bir fonksiyon, girilen tek parametrenin faktöryelini bulmalı
            int n = Convert.ToInt32(Console.ReadLine());
            int factorial = NewMath.Factoriel(n);
            Console.WriteLine(factorial.ToString());


            //Sort isimli bir fonksiyon, parametreden array olarak girilen değerlerin sıralatılıp sıralı array'in döndürülmesini sağlamalı
            int[] myNum = { 35, 22, 30, 43 };
            myNum = NewMath.Sort(myNum);
            for (int i = 0; i < myNum.Length; i++)
            {
                Console.Write(myNum[i] + " ");
            }
        }
    }
}
