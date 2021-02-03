using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Wpf_HW_FactoryMethod.Сlasses
{
    class Line : IFigure
    {
        public string Draw()
        {
            Random rnd = new Random();
            int num = rnd.Next(10,300);
            string text = "Line";
            // вызываем форму "  ShowShapes" передаём в нее данные
            ShowShapes show = new ShowShapes(text,num);
            show.Show();
            Thread.Sleep(1400);
            show.Close();

            return "Line";
        }
    }
}
