namespace ComandiArduino
{
    partial class ComandiArduino
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmdMagazzino = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioOpen = new System.Windows.Forms.RadioButton();
            this.radioClose = new System.Windows.Forms.RadioButton();
            this.cmdPiazzale = new System.Windows.Forms.Button();
            this.cmdGarage = new System.Windows.Forms.Button();
            this.cmdSbarra = new System.Windows.Forms.Button();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // cmdMagazzino
            // 
            this.cmdMagazzino.BackColor = System.Drawing.Color.Yellow;
            this.cmdMagazzino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdMagazzino.Location = new System.Drawing.Point(294, 252);
            this.cmdMagazzino.Margin = new System.Windows.Forms.Padding(7);
            this.cmdMagazzino.Name = "cmdMagazzino";
            this.cmdMagazzino.Size = new System.Drawing.Size(351, 118);
            this.cmdMagazzino.TabIndex = 0;
            this.cmdMagazzino.Text = "Magazzino";
            this.cmdMagazzino.UseVisualStyleBackColor = false;
            this.cmdMagazzino.Click += new System.EventHandler(this.cmdMagazzino_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(283, 136);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Comando Luci";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1199, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Comando Sbarra";
            // 
            // radioOpen
            // 
            this.radioOpen.AutoSize = true;
            this.radioOpen.Location = new System.Drawing.Point(1515, 252);
            this.radioOpen.Margin = new System.Windows.Forms.Padding(7);
            this.radioOpen.Name = "radioOpen";
            this.radioOpen.Size = new System.Drawing.Size(125, 41);
            this.radioOpen.TabIndex = 6;
            this.radioOpen.TabStop = true;
            this.radioOpen.Text = "Alzata";
            this.radioOpen.UseVisualStyleBackColor = true;
            // 
            // radioClose
            // 
            this.radioClose.AutoSize = true;
            this.radioClose.Checked = true;
            this.radioClose.Location = new System.Drawing.Point(1515, 324);
            this.radioClose.Margin = new System.Windows.Forms.Padding(7);
            this.radioClose.Name = "radioClose";
            this.radioClose.Size = new System.Drawing.Size(188, 41);
            this.radioClose.TabIndex = 7;
            this.radioClose.TabStop = true;
            this.radioClose.Text = "Abbassata";
            this.radioClose.UseVisualStyleBackColor = true;
            // 
            // cmdPiazzale
            // 
            this.cmdPiazzale.BackColor = System.Drawing.Color.Lime;
            this.cmdPiazzale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPiazzale.Location = new System.Drawing.Point(294, 412);
            this.cmdPiazzale.Margin = new System.Windows.Forms.Padding(7);
            this.cmdPiazzale.Name = "cmdPiazzale";
            this.cmdPiazzale.Size = new System.Drawing.Size(351, 118);
            this.cmdPiazzale.TabIndex = 8;
            this.cmdPiazzale.Text = "Piazzale";
            this.cmdPiazzale.UseVisualStyleBackColor = false;
            this.cmdPiazzale.Click += new System.EventHandler(this.cmdPiazzale_Click);
            // 
            // cmdGarage
            // 
            this.cmdGarage.BackColor = System.Drawing.Color.Red;
            this.cmdGarage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGarage.Location = new System.Drawing.Point(294, 571);
            this.cmdGarage.Margin = new System.Windows.Forms.Padding(7);
            this.cmdGarage.Name = "cmdGarage";
            this.cmdGarage.Size = new System.Drawing.Size(351, 118);
            this.cmdGarage.TabIndex = 9;
            this.cmdGarage.Text = "Garage";
            this.cmdGarage.UseVisualStyleBackColor = false;
            this.cmdGarage.Click += new System.EventHandler(this.cmdGarage_Click);
            // 
            // cmdSbarra
            // 
            this.cmdSbarra.BackColor = System.Drawing.Color.Cyan;
            this.cmdSbarra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSbarra.Location = new System.Drawing.Point(1203, 229);
            this.cmdSbarra.Margin = new System.Windows.Forms.Padding(7);
            this.cmdSbarra.Name = "cmdSbarra";
            this.cmdSbarra.Size = new System.Drawing.Size(290, 164);
            this.cmdSbarra.TabIndex = 10;
            this.cmdSbarra.Text = "Sbarra di accesso";
            this.cmdSbarra.UseVisualStyleBackColor = false;
            this.cmdSbarra.Click += new System.EventHandler(this.cmdSbarra_Click);
            // 
            // ComandiArduino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1900, 1041);
            this.Controls.Add(this.cmdSbarra);
            this.Controls.Add(this.cmdGarage);
            this.Controls.Add(this.cmdPiazzale);
            this.Controls.Add(this.radioClose);
            this.Controls.Add(this.radioOpen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdMagazzino);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "ComandiArduino";
            this.Text = "Comandi Arduino";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdMagazzino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioOpen;
        private System.Windows.Forms.RadioButton radioClose;
        private System.Windows.Forms.Button cmdPiazzale;
        private System.Windows.Forms.Button cmdGarage;
        private System.Windows.Forms.Button cmdSbarra;
        private System.IO.Ports.SerialPort serialPort;
    }
}

