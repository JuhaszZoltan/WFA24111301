namespace WFA24111301
{
    partial class FrmAkasztofa
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pbAkasztofa = new PictureBox();
            lblFeladvany = new Label();
            lblTippek = new Label();
            label3 = new Label();
            label4 = new Label();
            txbTipp = new TextBox();
            btnTipp = new Button();
            ((System.ComponentModel.ISupportInitialize)pbAkasztofa).BeginInit();
            SuspendLayout();
            // 
            // pbAkasztofa
            // 
            pbAkasztofa.Location = new Point(798, 12);
            pbAkasztofa.Name = "pbAkasztofa";
            pbAkasztofa.Size = new Size(400, 600);
            pbAkasztofa.TabIndex = 0;
            pbAkasztofa.TabStop = false;
            // 
            // lblFeladvany
            // 
            lblFeladvany.BackColor = Color.Beige;
            lblFeladvany.Font = new Font("Consolas", 30F);
            lblFeladvany.Location = new Point(12, 39);
            lblFeladvany.Name = "lblFeladvany";
            lblFeladvany.Size = new Size(780, 155);
            lblFeladvany.TabIndex = 1;
            lblFeladvany.Text = "_ _ _ _  _  _ _  _ _ _ _ _";
            lblFeladvany.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTippek
            // 
            lblTippek.BackColor = Color.Gainsboro;
            lblTippek.Font = new Font("Consolas", 30F);
            lblTippek.Location = new Point(12, 230);
            lblTippek.Name = "lblTippek";
            lblTippek.Size = new Size(780, 155);
            lblTippek.TabIndex = 1;
            lblTippek.Text = "A, B, G, W, C,";
            lblTippek.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 24);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 2;
            label3.Text = "feladvány:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 215);
            label4.Name = "label4";
            label4.Size = new Size(110, 15);
            label4.TabIndex = 2;
            label4.Text = "eddig tippelt betűk:";
            // 
            // txbTipp
            // 
            txbTipp.Font = new Font("Segoe UI", 40F);
            txbTipp.Location = new Point(47, 457);
            txbTipp.Name = "txbTipp";
            txbTipp.Size = new Size(89, 78);
            txbTipp.TabIndex = 3;
            // 
            // btnTipp
            // 
            btnTipp.Font = new Font("Segoe UI", 30F);
            btnTipp.Location = new Point(142, 456);
            btnTipp.Name = "btnTipp";
            btnTipp.Size = new Size(115, 79);
            btnTipp.TabIndex = 4;
            btnTipp.Text = "Tipp";
            btnTipp.UseVisualStyleBackColor = true;
            // 
            // FrmAkasztofa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1210, 627);
            Controls.Add(btnTipp);
            Controls.Add(txbTipp);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblTippek);
            Controls.Add(lblFeladvany);
            Controls.Add(pbAkasztofa);
            Name = "FrmAkasztofa";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbAkasztofa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbAkasztofa;
        private Label lblFeladvany;
        private Label lblTippek;
        private Label label3;
        private Label label4;
        private TextBox txbTipp;
        private Button btnTipp;
    }
}
