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
            lblPuzzle = new Label();
            lblTips = new Label();
            label3 = new Label();
            label4 = new Label();
            txbTip = new TextBox();
            btnTipp = new Button();
            lblHint = new Label();
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
            // lblPuzzle
            // 
            lblPuzzle.BackColor = Color.Beige;
            lblPuzzle.Font = new Font("Consolas", 30F);
            lblPuzzle.Location = new Point(12, 116);
            lblPuzzle.Name = "lblPuzzle";
            lblPuzzle.Size = new Size(780, 155);
            lblPuzzle.TabIndex = 1;
            lblPuzzle.Text = "_ _ _ _  _  _ _  _ _ _ _ _";
            lblPuzzle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTips
            // 
            lblTips.BackColor = Color.Gainsboro;
            lblTips.Font = new Font("Consolas", 30F);
            lblTips.Location = new Point(12, 298);
            lblTips.Name = "lblTips";
            lblTips.Size = new Size(780, 155);
            lblTips.TabIndex = 1;
            lblTips.Text = "A, B, G, W, C,";
            lblTips.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 101);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 2;
            label3.Text = "feladvány:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 283);
            label4.Name = "label4";
            label4.Size = new Size(110, 15);
            label4.TabIndex = 2;
            label4.Text = "eddig tippelt betűk:";
            // 
            // txbTipp
            // 
            txbTip.Font = new Font("Segoe UI", 40F);
            txbTip.Location = new Point(23, 491);
            txbTip.Name = "txbTipp";
            txbTip.Size = new Size(89, 78);
            txbTip.TabIndex = 3;
            // 
            // btnTipp
            // 
            btnTipp.Font = new Font("Segoe UI", 30F);
            btnTipp.Location = new Point(118, 490);
            btnTipp.Name = "btnTipp";
            btnTipp.Size = new Size(115, 79);
            btnTipp.TabIndex = 4;
            btnTipp.Text = "Tipp";
            btnTipp.UseVisualStyleBackColor = true;
            // 
            // lblHint
            // 
            lblHint.BackColor = Color.Lavender;
            lblHint.Font = new Font("Segoe UI", 20F);
            lblHint.Location = new Point(12, 12);
            lblHint.Name = "lblHint";
            lblHint.Size = new Size(780, 89);
            lblHint.TabIndex = 5;
            lblHint.Text = "label1";
            lblHint.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FrmAkasztofa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1210, 627);
            Controls.Add(lblHint);
            Controls.Add(btnTipp);
            Controls.Add(txbTip);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblTips);
            Controls.Add(lblPuzzle);
            Controls.Add(pbAkasztofa);
            Name = "FrmAkasztofa";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbAkasztofa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbAkasztofa;
        private Label lblPuzzle;
        private Label lblTips;
        private Label label3;
        private Label label4;
        private TextBox txbTip;
        private Button btnTipp;
        private Label lblHint;
    }
}
