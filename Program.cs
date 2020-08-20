using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace giaiPTBac2
{
    class Program
    {
        static void Main(string[] args)
        {
            //testc9h
            //meo ngu
            //sss
            //ddd
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Chương Trình Giải Phương Trình Bậc 2: Ax^2+Bx+C=0 ");
            int A, B, C;
            string strA, strB, strC;
            float x1, x2;
            Console.Write("Nhập vào giá trị A: ");
            strA = Console.ReadLine();
            Console.Write("Nhập vào giá trị B: ");
            strB = Console.ReadLine();
            Console.Write("Nhập vào giá trị C: ");
            strC = Console.ReadLine();

            if (int.TryParse(strA, out A) == false || int.TryParse(strB, out B) == false || int.TryParse(strC, out C) == false)
            {
                Console.WriteLine("Dữ Liệu Nhập Vào Sai!");
            }
            else
            {
                if (A == 0)
                {
                    Console.WriteLine("Đây không phải là phương trình bậc 2");
                }
                else
                {
                    Console.WriteLine("Phương trình vừa nhập là : {0}x^2 + {1}x + {2} =0", A, B, C);
                    int delta = B * B - 4 * A * C;
                    if (delta == 0)
                    {
                        x1 = (float)-B / (2 * A);
                        Console.WriteLine("Phương trình có nghiệm kép là : " + x1);
                    }
                    else if (delta < 0)
                    {
                        Console.WriteLine("Phương trình vô nghiệm !");
                    }
                    else
                    {
                        x1 = (float)((-B + Math.Sqrt(delta)) / (2 * A));
                        x2 = (float)((-B - Math.Sqrt(delta)) / (2 * A));
                        Console.WriteLine("Phương trình có 2 nghiệm là: " + "x1 =" + x1 + "," + " x2 =" + x2);
                    }
                }    
            }
            Console.ReadKey();
                
        }
    }
}
