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
        Boolean radioOpenClose = true;  // Variabile booleana che indica lo stato dei radio buttons
        public ComandiArduino()
        {
            InitializeComponent();
        }

        private void cmdMagazzino_Click(object sender, EventArgs e) // Pulsante Magazzino
        {
            serialPort.Open();                      // Apertura porta seriale
            serialPort.Write("M");                  // Trasmissione carattere
            serialPort.Write(Environment.NewLine);  // Trasmissione fine riga
            serialPort.Close();                     // Chiusura porta seriale
        }

        private void cmdPiazzale_Click(object sender, EventArgs e)  // Pulsante Piazzale
        {
            serialPort.Open();
            serialPort.Write("P");
            serialPort.Write(Environment.NewLine);
            serialPort.Close();
        }

        private void cmdGarage_Click(object sender, EventArgs e)    // Pulsante Garage
        {
            serialPort.Open();
            serialPort.Write("G");
            serialPort.Write(Environment.NewLine);
            serialPort.Close();
        }

        private void cmdSbarra_Click(object sender, EventArgs e)    // Pulsante Sbarra
        {
            serialPort.Open();
            serialPort.Write("H");
            serialPort.Write(Environment.NewLine);
            serialPort.Close();

            if (radioOpenClose == true)             // Controllo stato radio buttons (se la sbarra è chiusa)
            {
                radioOpen.Checked = true;           // Marcatura radio button "Alzata"
                radioOpenClose = false;             // Stato radio buttons: Sbarra aperta
            }
            else                                    // Controllo stato radio buttons (se la sbarra è aperta)
            {
                radioClose.Checked = true;          // Marcatura radio button "Abbassata"
                radioOpenClose = true;              // Stato radio buttons: Sbarra chiusa
            }
        }
    }
}
