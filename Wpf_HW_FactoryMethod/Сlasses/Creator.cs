using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_HW_FactoryMethod.Сlasses
{
    class Creator
    {
        public IFigure CreateFigure(int num)
        {
            if (num % 2 == 0)
            {
                return new Circle();
            }
            if (num % 3 == 0)
            {
                return new Line();
            }

            return new Square();

        }
        
    }
}
