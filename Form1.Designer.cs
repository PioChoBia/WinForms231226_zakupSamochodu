namespace WinForms231226_zakupSamochodu
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxCena = new System.Windows.Forms.TextBox();
            this.numericUpDownRabat = new System.Windows.Forms.NumericUpDown();
            this.textBoxDoZaplaty = new System.Windows.Forms.TextBox();
            this.textBoxStopa = new System.Windows.Forms.TextBox();
            this.hScrollBarStopa = new System.Windows.Forms.HScrollBar();
            this.numericUpDownIleRat = new System.Windows.Forms.NumericUpDown();
            this.textBoxRata = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRabat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIleRat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "marka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "cena";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "rabat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "roczna stopa procentowa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "obliczamy kredyt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(90, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "do zapłaty";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(146, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(215, 30);
            this.label7.TabIndex = 8;
            this.label7.Text = "program kalkulujący zakup samochodu\r\nmożna wybrać markę";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(92, 405);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "wysokość miesięcznej raty";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(92, 361);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "ilosc rat miesięcznych";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Opel Astra",
            "Opel Zafira",
            "Skoda Felicja",
            "Dacia Duster",
            "Mercedes Vito",
            "Nissan Juke"});
            this.comboBox1.Location = new System.Drawing.Point(215, 78);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBoxCena
            // 
            this.textBoxCena.Location = new System.Drawing.Point(218, 126);
            this.textBoxCena.Name = "textBoxCena";
            this.textBoxCena.Size = new System.Drawing.Size(118, 23);
            this.textBoxCena.TabIndex = 10;
            // 
            // numericUpDownRabat
            // 
            this.numericUpDownRabat.Location = new System.Drawing.Point(215, 167);
            this.numericUpDownRabat.Name = "numericUpDownRabat";
            this.numericUpDownRabat.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownRabat.TabIndex = 11;
            this.numericUpDownRabat.ValueChanged += new System.EventHandler(this.numericUpDownRabat_ValueChanged);
            // 
            // textBoxDoZaplaty
            // 
            this.textBoxDoZaplaty.Location = new System.Drawing.Point(215, 219);
            this.textBoxDoZaplaty.Name = "textBoxDoZaplaty";
            this.textBoxDoZaplaty.Size = new System.Drawing.Size(100, 23);
            this.textBoxDoZaplaty.TabIndex = 12;
            // 
            // textBoxStopa
            // 
            this.textBoxStopa.Location = new System.Drawing.Point(261, 321);
            this.textBoxStopa.Name = "textBoxStopa";
            this.textBoxStopa.Size = new System.Drawing.Size(75, 23);
            this.textBoxStopa.TabIndex = 13;
            this.textBoxStopa.Text = "0";
            this.textBoxStopa.TextChanged += new System.EventHandler(this.textBoxStopa_TextChanged);
            // 
            // hScrollBarStopa
            // 
            this.hScrollBarStopa.Location = new System.Drawing.Point(380, 321);
            this.hScrollBarStopa.Name = "hScrollBarStopa";
            this.hScrollBarStopa.Size = new System.Drawing.Size(223, 24);
            this.hScrollBarStopa.SmallChange = 5;
            this.hScrollBarStopa.TabIndex = 14;
            this.hScrollBarStopa.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarStopa_Scroll);
            // 
            // numericUpDownIleRat
            // 
            this.numericUpDownIleRat.Location = new System.Drawing.Point(261, 364);
            this.numericUpDownIleRat.Name = "numericUpDownIleRat";
            this.numericUpDownIleRat.Size = new System.Drawing.Size(75, 23);
            this.numericUpDownIleRat.TabIndex = 15;
            this.numericUpDownIleRat.ValueChanged += new System.EventHandler(this.numericUpDownIleRat_ValueChanged);
            // 
            // textBoxRata
            // 
            this.textBoxRata.Location = new System.Drawing.Point(263, 405);
            this.textBoxRata.Name = "textBoxRata";
            this.textBoxRata.Size = new System.Drawing.Size(100, 23);
            this.textBoxRata.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(332, 219);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 15);
            this.label10.TabIndex = 17;
            this.label10.Text = "zł";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(346, 324);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 15);
            this.label11.TabIndex = 18;
            this.label11.Text = "%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxRata);
            this.Controls.Add(this.numericUpDownIleRat);
            this.Controls.Add(this.hScrollBarStopa);
            this.Controls.Add(this.textBoxStopa);
            this.Controls.Add(this.textBoxDoZaplaty);
            this.Controls.Add(this.numericUpDownRabat);
            this.Controls.Add(this.textBoxCena);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRabat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIleRat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private ComboBox comboBox1;
        private TextBox textBoxCena;
        private NumericUpDown numericUpDownRabat;
        private TextBox textBoxDoZaplaty;
        private TextBox textBoxStopa;
        private HScrollBar hScrollBarStopa;
        private NumericUpDown numericUpDownIleRat;
        private TextBox textBoxRata;
        private Label label10;
        private Label label11;
    }
}