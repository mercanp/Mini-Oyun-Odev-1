using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniOyunEgitimi
{

    internal class NewMath
    {
        //Min ve Max isminde iki fonksiyon; girilen ikişer parametrenin hangisinin büyük ve hangisinin küçük olduğunu döndürmeliler
        public static int Min(int num1, int num2)
        {
            if (num1 < num2)
            {
                return num1;
            }
            else if (num1 == num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }

        }

        public static int Max(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            else if (num1 == num2)
            {
                return num2;
            }
            else
            {
                return num2;
            }
        }


        //Factoriel isminde bir fonksiyon, girilen tek parametrenin faktöryelini bulmalı
        public static int Factoriel(int n)
        {
            if (n == 1 || n == 0)
            {
                return 1;
            }
            else
            {
                return n * Factoriel(n - 1);
            }
        }


        //Sort isimli bir fonksiyon, parametreden array olarak girilen değerlerin sıralatılıp sıralı array'in döndürülmesini sağlamalı
        public static int[] Sort(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = 0; j < nums.Length - 1 - i; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        int temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }


                }
            }

            return nums;
        }

    }
}

