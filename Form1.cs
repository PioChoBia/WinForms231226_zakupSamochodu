namespace WinForms231226_zakupSamochodu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //w comboBox1 wyœwletla nazwê pierwszej wartoœci
            comboBox1.Text = comboBox1.Items[0].ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //wstawienie dla wybranej marki ceny polu ceny
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    textBoxCena.Text = "41000";
                    break;
                case 1:
                    textBoxCena.Text = "31000";
                    break;
                case 2:
                    textBoxCena.Text = "45000";
                    break;
                case 3:
                    textBoxCena.Text = "28000";
                    break;
                case 4:
                    textBoxCena.Text = "32000";
                    break;
                case 5:
                    textBoxCena.Text = "36000";
                    break;              
            }
            Zaplata();
            Rata();
        }

        private void Rata()
        {
            double pv, rate, nper, pmt;
            pv= Double.Parse(textBoxDoZaplaty.Text);
            rate = Double.Parse(textBoxStopa.Text);
            nper=(double)(numericUpDownIleRat.Value);


            //równanie bankierów
            if (rate == 0) pmt = pv / nper;
            else
                pmt = -(pv * Math.Pow(1+rate, nper)/(1-Math.Pow(1+rate,nper)));
            textBoxRata.Text = pmt.ToString("N2");
        }

        private void Zaplata()
        {
            textBoxDoZaplaty.Text=
                ( Decimal.Parse(textBoxCena.Text)*
                  ( (decimal)100.0-numericUpDownRabat.Value )/100).ToString();
        }


        private void numericUpDownRabat_ValueChanged(object sender, EventArgs e)
        {
            //przy ka¿dej zmianie wartoœci rabatu automatycznie przelicza
            //wystarczy poruszyæ kursorem
            Zaplata();
            Rata();
        }

        private void textBoxStopa_TextChanged(object sender, EventArgs e)
        {

        }

        private void hScrollBarStopa_Scroll(object sender, ScrollEventArgs e)
        {
            textBoxStopa.Text=(hScrollBarStopa.Value/100.0).ToString();
            Rata();
        }

        private void numericUpDownIleRat_ValueChanged(object sender, EventArgs e)
        {
            Rata();
        }




    }
}