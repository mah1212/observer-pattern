using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObserverPattern.Observer;

namespace ObserverPattern
{
    public partial class Rectangle : Form, IObserver
    {
        public Rectangle()
        {
            InitializeComponent();
        }

        public void Update(int count)
        {
            UpdateRectangle(count);
        }

        private void UpdateRectangle(int count)
        {
            this.CreateGraphics().Clear(this.BackColor);
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();

            formGraphics.FillRectangle(myBrush, new System.Drawing.Rectangle(0, 0, count*10, count*10));
            myBrush.Dispose();
            formGraphics.Dispose();
        }
    }
}
