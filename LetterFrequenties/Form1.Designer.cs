namespace LetterFrequenties
{
    partial class frmLetterFrequentie
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbInT = new System.Windows.Forms.RichTextBox();
            this.btnTel = new System.Windows.Forms.Button();
            this.txbInL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbInT
            // 
            this.txbInT.Location = new System.Drawing.Point(123, 47);
            this.txbInT.Name = "txbInT";
            this.txbInT.Size = new System.Drawing.Size(665, 391);
            this.txbInT.TabIndex = 0;
            this.txbInT.Text = "";
            // 
            // btnTel
            // 
            this.btnTel.Location = new System.Drawing.Point(15, 81);
            this.btnTel.Name = "btnTel";
            this.btnTel.Size = new System.Drawing.Size(91, 23);
            this.btnTel.TabIndex = 1;
            this.btnTel.Text = "Tel";
            this.btnTel.UseVisualStyleBackColor = true;
            this.btnTel.Click += new System.EventHandler(this.btnTel_Click);
            // 
            // txbInL
            // 
            this.txbInL.Location = new System.Drawing.Point(123, 12);
            this.txbInL.Name = "txbInL";
            this.txbInL.Size = new System.Drawing.Size(28, 20);
            this.txbInL.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Letter om te tellen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tekst om in te tellen:";
            // 
            // lblOut
            // 
            this.lblOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOut.Location = new System.Drawing.Point(157, 9);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(631, 23);
            this.lblOut.TabIndex = 5;
            // 
            // frmLetterFrequentie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbInL);
            this.Controls.Add(this.btnTel);
            this.Controls.Add(this.txbInT);
            this.Name = "frmLetterFrequentie";
            this.Text = "Letter frequentie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txbInT;
        private System.Windows.Forms.Button btnTel;
        private System.Windows.Forms.TextBox txbInL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOut;
    }
}

