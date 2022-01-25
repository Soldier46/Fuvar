
namespace grafikusmegoldas
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTaxiID = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIndulas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTávolság = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtViteldíj = new System.Windows.Forms.TextBox();
            this.txtBorravaló = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFizetésmódja = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdőtartam = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnKilépés = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(187, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fuvar Adatai:";
            // 
            // txtTaxiID
            // 
            this.txtTaxiID.Location = new System.Drawing.Point(281, 113);
            this.txtTaxiID.Name = "txtTaxiID";
            this.txtTaxiID.Size = new System.Drawing.Size(100, 23);
            this.txtTaxiID.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(163, 334);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 356);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Betöltés";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(100, 356);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 5;
            this.btnSort.Text = "Rendezés";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Taxi ID:";
            // 
            // txtIndulas
            // 
            this.txtIndulas.Location = new System.Drawing.Point(281, 142);
            this.txtIndulas.Name = "txtIndulas";
            this.txtIndulas.Size = new System.Drawing.Size(100, 23);
            this.txtIndulas.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Indulás";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Távolság";
            // 
            // txtTávolság
            // 
            this.txtTávolság.Location = new System.Drawing.Point(281, 205);
            this.txtTávolság.Name = "txtTávolság";
            this.txtTávolság.Size = new System.Drawing.Size(100, 23);
            this.txtTávolság.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 237);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Viteldíj";
            // 
            // txtViteldíj
            // 
            this.txtViteldíj.Location = new System.Drawing.Point(281, 234);
            this.txtViteldíj.Name = "txtViteldíj";
            this.txtViteldíj.Size = new System.Drawing.Size(100, 23);
            this.txtViteldíj.TabIndex = 2;
            // 
            // txtBorravaló
            // 
            this.txtBorravaló.Location = new System.Drawing.Point(281, 267);
            this.txtBorravaló.Name = "txtBorravaló";
            this.txtBorravaló.Size = new System.Drawing.Size(100, 23);
            this.txtBorravaló.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(196, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Borravaló";
            // 
            // txtFizetésmódja
            // 
            this.txtFizetésmódja.Location = new System.Drawing.Point(281, 296);
            this.txtFizetésmódja.Name = "txtFizetésmódja";
            this.txtFizetésmódja.Size = new System.Drawing.Size(100, 23);
            this.txtFizetésmódja.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(196, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fizetés módja";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtIdőtartam
            // 
            this.txtIdőtartam.Location = new System.Drawing.Point(281, 171);
            this.txtIdőtartam.Name = "txtIdőtartam";
            this.txtIdőtartam.Size = new System.Drawing.Size(100, 23);
            this.txtIdőtartam.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(196, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Időtartam";
            // 
            // btnKilépés
            // 
            this.btnKilépés.Location = new System.Drawing.Point(407, 356);
            this.btnKilépés.Name = "btnKilépés";
            this.btnKilépés.Size = new System.Drawing.Size(75, 23);
            this.btnKilépés.TabIndex = 7;
            this.btnKilépés.Text = "Kilépés";
            this.btnKilépés.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 403);
            this.Controls.Add(this.btnKilépés);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtFizetésmódja);
            this.Controls.Add(this.txtBorravaló);
            this.Controls.Add(this.txtViteldíj);
            this.Controls.Add(this.txtTávolság);
            this.Controls.Add(this.txtIdőtartam);
            this.Controls.Add(this.txtIndulas);
            this.Controls.Add(this.txtTaxiID);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTaxiID;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIndulas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTávolság;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtViteldíj;
        private System.Windows.Forms.TextBox txtBorravaló;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFizetésmódja;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIdőtartam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnKilépés;
    }
}

