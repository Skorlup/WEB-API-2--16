using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2
{
    public class Converter
    {
        public char[] Converting(int b)
        {
            b = Convert.ToInt32(Console.ReadLine());
            int k = 0;
            var long2 = 0;
            var long16 = 0;
            var mas = new int[100];
            do
            {
                k = b % 10;
                if (k > 1)
                {
                    Close();
                }
                b = b / 10;
                mas[long2] = k;
                long2++;
            } while (b > 0);
            if (long2 % 4 == 0)
            {
                long16 = long2 / 4;
            }
            else
            {
                long16 = (long2 / 4) + 1;
            }
            k = 0;
            var m = 0;
            var result = new int[long2];
            for (int x = 0; x < long2; x++)  //Math.Pow(x, stepen)
            {
                if (k < 4)
                {
                    var Base = 2;
                    var exponent = Convert.ToDouble(k);
                    if (x == 0)
                    {
                        result[m] = mas[x] * Convert.ToInt16(Math.Pow(Base, exponent));
                    }
                    else if (x == 1 || x == 5)
                    {
                        result[m] = result[m] + (mas[x] * Convert.ToInt16(Math.Pow(Base, exponent)));
                    }
                    else
                    {
                        result[m] = result[m] + (mas[x] * Convert.ToInt16(Math.Pow(Base, exponent)));
                    }
                    k++;
                }
                else
                {
                    k = 0;
                    m++;
                    result[m] = mas[x] * Convert.ToInt16(Math.Pow(2, 0));
                    k++;
                }
            }
            var result16 = new char[long16];
            for (int i = 0; i < result16.Length; i++)
            {
                if (result[i] > 9)
                {
                    switch (result[i])
                    {
                        case 10:
                            {
                                result16[i] = 'A';
                                break;
                            }
                        case 11:
                            {
                                result16[i] = 'B';
                                break;
                            }
                        case 12:
                            {
                                result16[i] = 'C';
                                break;
                            }
                        case 13:
                            {
                                result16[i] = 'D';
                                break;
                            }
                        case 14:
                            {
                                result16[i] = 'E';
                                break;
                            }
                        case 15:
                            {
                                result16[i] = 'F';
                                break;
                            }
                    }
                }
                else
                {
                    result16[i] = Convert.ToChar(result[i]);
                }

            }
            return result16;
        }
        public void Close()
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
    }
}
