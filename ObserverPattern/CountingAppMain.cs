using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObserverPattern
{
    public partial class CountingAppMain : Form
    {
        private Counter counter;
        public CountingAppMain()
        {
            counter = new Counter();
            InitializeComponent();

            TextObserver textObserver = new TextObserver();
            textObserver.Show();

            counter.RegisterObserver(textObserver);

            Rectangle rectangle = new Rectangle();
            rectangle.Show();

            counter.RegisterObserver(rectangle);
        }



        private void buttonIncrease_Click(object sender, EventArgs e)
        {
            counter.Increament();
        }

        private void buttonDecrease_Click(object sender, EventArgs e)
        {
            counter.Decrement();
        }
    }
}
