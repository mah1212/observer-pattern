using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObserverPattern.Observer;

namespace ObserverPattern
{
    public partial class TextObserver : Form, IObserver
    {
        public TextObserver()
        {
            InitializeComponent();
        }

        public void Update(int count)
        {
            SetText(count);
        }

        private void SetText(int count)
        {
            labelTextObserver.Text = count.ToString();
        }
    }
}
