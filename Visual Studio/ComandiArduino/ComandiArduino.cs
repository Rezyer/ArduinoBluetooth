using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComandiArduino
{
    public partial class ComandiArduino : Form
    {
        Boolean radioOpenClose = true;
        public ComandiArduino()
        {
            InitializeComponent();
        }

        private void cmdMagazzino_Click(object sender, EventArgs e)
        {
            serialPort.Open();
            serialPort.Write("M");
            serialPort.Write(Environment.NewLine);
            serialPort.Close();
        }

        private void cmdPiazzale_Click(object sender, EventArgs e)
        {
            serialPort.Open();
            serialPort.Write("P");
            serialPort.Write(Environment.NewLine);
            serialPort.Close();
        }

        private void cmdGarage_Click(object sender, EventArgs e)
        {
            serialPort.Open();
            serialPort.Write("G");
            serialPort.Write(Environment.NewLine);
            serialPort.Close();
        }

        private void cmdSbarra_Click(object sender, EventArgs e)
        {
            serialPort.Open();
            serialPort.Write("H");
            serialPort.Write(Environment.NewLine);
            serialPort.Close();

            if (radioOpenClose == true)
            {
                radioOpen.Checked = true;
                radioOpenClose = false;
            }
            else
            {
                radioClose.Checked = true;
                radioOpenClose = true;
            }
        }
    }
}
