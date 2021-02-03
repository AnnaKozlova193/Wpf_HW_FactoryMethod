using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Wpf_HW_FactoryMethod.Сlasses
{
    class Square : IFigure
    {
        public string Draw()
        {
            Random rnd = new Random();
            int num = rnd.Next(3,170);
            string text = "Square";
            // вызываем форму "  ShowShapes" передаём в нее данные
            ShowShapes show = new ShowShapes(text,num);
            show.Show();
            Thread.Sleep(1400);
            show.Close();

            return "Square";

        }
    }
}
