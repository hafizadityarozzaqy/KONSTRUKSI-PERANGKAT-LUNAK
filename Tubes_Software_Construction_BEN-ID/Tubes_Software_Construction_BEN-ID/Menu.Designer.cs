
namespace Tubes_Software_Construction_BEN_ID
{
    partial class Menu
    {

        public enum field { infosaldo, isisaldo, riwayat, pesanfeed, isibbm };
        public static string[] tulisan = { "300.000", "ISI SALDO", "RIWAYAT", "PESAN FEED", "ISI BBM" };

        public static string gettulisan(field username)
        {
            return tulisan[(int)username];
        }

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
            this.isisaldo = new System.Windows.Forms.Button();
            this.riwayat = new System.Windows.Forms.Button();
            this.pesanfeed = new System.Windows.Forms.Button();
            this.isibbm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.infosaldo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // isisaldo
            // 
            this.isisaldo.Location = new System.Drawing.Point(64, 205);
            this.isisaldo.Name = "isisaldo";
            this.isisaldo.Size = new System.Drawing.Size(75, 53);
            this.isisaldo.TabIndex = 1;
            this.isisaldo.UseVisualStyleBackColor = true;
            // 
            // riwayat
            // 
            this.riwayat.Location = new System.Drawing.Point(213, 205);
            this.riwayat.Name = "riwayat";
            this.riwayat.Size = new System.Drawing.Size(75, 53);
            this.riwayat.TabIndex = 2;
            this.riwayat.UseVisualStyleBackColor = true;
            // 
            // pesanfeed
            // 
            this.pesanfeed.Location = new System.Drawing.Point(139, 274);
            this.pesanfeed.Name = "pesanfeed";
            this.pesanfeed.Size = new System.Drawing.Size(75, 49);
            this.pesanfeed.TabIndex = 3;
            this.pesanfeed.UseVisualStyleBackColor = true;
            // 
            // isibbm
            // 
            this.isibbm.Location = new System.Drawing.Point(139, 329);
            this.isibbm.Name = "isibbm";
            this.isibbm.Size = new System.Drawing.Size(75, 48);
            this.isibbm.TabIndex = 4;
            //this.isibbm.Text = gettulisan(field.isibbm);
            this.isibbm.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "SALDO :";
            // 
            // infosaldo
            // 
            this.infosaldo.AutoSize = true;
            this.infosaldo.Location = new System.Drawing.Point(116, 164);
            this.infosaldo.Name = "infosaldo";
            this.infosaldo.Size = new System.Drawing.Size(0, 13);
            this.infosaldo.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(105, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "--------------------------------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(109, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 59);
            this.label4.TabIndex = 14;
            this.label4.Text = "BEN-ID";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tubes_Software_Construction_BEN_ID.Properties.Resources.Search1;
            this.ClientSize = new System.Drawing.Size(354, 512);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.infosaldo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.isibbm);
            this.Controls.Add(this.pesanfeed);
            this.Controls.Add(this.riwayat);
            this.Controls.Add(this.isisaldo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button isisaldo;
        private System.Windows.Forms.Button riwayat;
        private System.Windows.Forms.Button pesanfeed;
        private System.Windows.Forms.Button isibbm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label infosaldo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
    }
}