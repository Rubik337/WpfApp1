using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Calculation
    {
        public static int GetQuantityForProduct(int productType, int materialType, int count, float width, float length)
        {
            int result = 0;
            double material=0, product=0;
            double multiply;

            if (productType < -1 || productType > 3 ||
                materialType < -1 || materialType > 2 ||
                count < 0 || length < 0 || width < 0)
            {
                return -1;
            }
            else {
                switch (productType)
                {
                    case 0: product = 1.1; break;
                    case 1: product = 2.5; break;
                    case 2: product = 8.43; break;
                }
                switch (materialType)
                {
                    case 0: material = 0.3; break;
                    case 1: material = 0.12; break;
                }

                multiply = width * length * count * product;
                result = Convert.ToInt32(multiply + Math.Ceiling(material / 100));
                return result;
            }

               // anektod
               // 
        }
    }
}
