
namespace Tubes_Software_Construction_BEN_ID
{
    partial class Pembayaran
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
            this.BtnSALDO = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnKEMBALI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSALDO
            // 
            this.BtnSALDO.Location = new System.Drawing.Point(89, 173);
            this.BtnSALDO.Name = "BtnSALDO";
            this.BtnSALDO.Size = new System.Drawing.Size(194, 49);
            this.BtnSALDO.TabIndex = 0;
            this.BtnSALDO.Text = "SALDO";
            this.BtnSALDO.UseVisualStyleBackColor = true;
            this.BtnSALDO.Click += new System.EventHandler(this.BtnSALDO_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Agency FB", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "METODE PEMBAYARAN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(89, 252);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 47);
            this.button2.TabIndex = 2;
            this.button2.Text = "M-BANKING";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BtnMBANKING_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(89, 335);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(194, 46);
            this.button3.TabIndex = 3;
            this.button3.Text = "DANA";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.BtnDANA_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(89, 420);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(194, 44);
            this.button4.TabIndex = 4;
            this.button4.Text = "OVO";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.BtnOVO_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(89, 504);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(194, 45);
            this.button5.TabIndex = 5;
            this.button5.Text = "LINK AJA";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.BtnLINKAJA_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(33, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "----------------------------------------------------------";
            // 
            // BtnKEMBALI
            // 
            this.BtnKEMBALI.Location = new System.Drawing.Point(148, 586);
            this.BtnKEMBALI.Name = "BtnKEMBALI";
            this.BtnKEMBALI.Size = new System.Drawing.Size(76, 34);
            this.BtnKEMBALI.TabIndex = 7;
            this.BtnKEMBALI.Text = "Kembali";
            this.BtnKEMBALI.UseVisualStyleBackColor = true;
            this.BtnKEMBALI.Click += new System.EventHandler(this.BtnKEMBALI_Click);
            // 
            // Pembayaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tubes_Software_Construction_BEN_ID.Properties.Resources.Search2;
            this.ClientSize = new System.Drawing.Size(370, 680);
            this.Controls.Add(this.BtnKEMBALI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSALDO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pembayaran";
            this.Text = "Pembayaran";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSALDO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnKEMBALI;
    }
}