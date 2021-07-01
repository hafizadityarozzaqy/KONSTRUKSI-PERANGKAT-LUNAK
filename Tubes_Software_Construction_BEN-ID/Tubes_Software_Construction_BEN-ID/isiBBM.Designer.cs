
namespace Tubes_Software_Construction_BEN_ID
{
    partial class IsiBBM
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
            this.Label5 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.LinkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.textBBM = new System.Windows.Forms.TextBox();
            this.textHarga = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Location = new System.Drawing.Point(90, 570);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(168, 17);
            this.Label5.TabIndex = 28;
            this.Label5.Text = "Melanjutkan Pembayaran";
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(121, 539);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(105, 28);
            this.Button1.TabIndex = 27;
            this.Button1.Text = "LANJUT";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // LinkLabel1
            // 
            this.LinkLabel1.AutoSize = true;
            this.LinkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.LinkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabel1.LinkColor = System.Drawing.Color.Black;
            this.LinkLabel1.Location = new System.Drawing.Point(115, 77);
            this.LinkLabel1.Name = "LinkLabel1";
            this.LinkLabel1.Size = new System.Drawing.Size(123, 32);
            this.LinkLabel1.TabIndex = 21;
            this.LinkLabel1.TabStop = true;
            this.LinkLabel1.Text = "ISI BBM";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(68, 282);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(52, 17);
            this.Label2.TabIndex = 20;
            this.Label2.Text = "Harga";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(68, 206);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(99, 17);
            this.Label1.TabIndex = 19;
            this.Label1.Text = "Memilih BBM";
            // 
            // textBBM
            // 
            this.textBBM.Location = new System.Drawing.Point(71, 227);
            this.textBBM.Name = "textBBM";
            this.textBBM.Size = new System.Drawing.Size(100, 22);
            this.textBBM.TabIndex = 29;
            // 
            // textHarga
            // 
            this.textHarga.Location = new System.Drawing.Point(71, 303);
            this.textHarga.Name = "textHarga";
            this.textHarga.Size = new System.Drawing.Size(100, 22);
            this.textHarga.TabIndex = 30;
            // 
            // IsiBBM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tubes_Software_Construction_BEN_ID.Properties.Resources.Search2;
            this.ClientSize = new System.Drawing.Size(360, 670);
            this.Controls.Add(this.textHarga);
            this.Controls.Add(this.textBBM);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.LinkLabel1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IsiBBM";
            this.Text = "BakaraIsiBBM";
            this.Load += new System.EventHandler(this.BakaraIsiBBM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.LinkLabel LinkLabel1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox textBBM;
        private System.Windows.Forms.TextBox textHarga;
    }
}