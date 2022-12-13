using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;

namespace PlanningPatterns
{
    public class RectangleShape
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public int Area()
        {
            return Height * Width;
        }
        //public void Draw(Form form)
        //{
        //    SolidBrush myBrush = new SolidBrush(System.Drawing.Color.Red);
        //    Graphics formGraphics = form.CreateGraphics();
        //    formGraphics.FillRectangle(myBrush, new Rectangle(0, 0, Width, Height));
        //}
    }
}
