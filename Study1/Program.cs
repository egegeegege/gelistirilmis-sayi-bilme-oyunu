
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* 
             ÖDEV
             Sistemin rastgele üretmiş olduğu sayıyı kullanıcının bulması için bir kod bloğu yazarak eğer kullanıcının girdiği sayı üretilen sayıdan büyük ise kullanıcının büyük bir sayı girdiğini,
            küçük sayı girdiyse kullanıcının küçük sayı girdiği uyarısını veriniz.
            bu oyunda kullanıcının 5 hakkı olmalı.
            Rastegele üretilen sayı (10,100) arasında olmalıdır.            
             try catch, do while, break, if
             */

            try
            {
                Random random = new Random();
                int number = random.Next(10, 101);


                int hak = 0;
                do
                {
                    Console.WriteLine("bir sayı giriniz");
                    int tahmin = int.Parse(Console.ReadLine());

                    hak++;
                    if (tahmin > number)
                    {
                        Console.WriteLine("tahmininiz üretilen sayının üstünde");
                    }
                    else if (tahmin < number)
                    {
                        Console.WriteLine("tahmininiz üretilen sayının altında");
                    }
                    else
                    {
                        Console.WriteLine("tebrikler tahmininiz doğru");
                        break;
                    }

                } while (hak < 5);


            }
            catch (Exception)
            {
                Console.WriteLine("bir hata meydana geldi");
            }
            Console.ReadLine();
        }
    }
}
