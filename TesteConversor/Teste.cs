using ConversorNumeroRomanoParaArabico;
using System;
using System.Windows.Forms;

namespace TesteConversor
{
    public partial class Teste : Form
    {
        private ConvertXToN conversor = new();
        public Teste()
        {
            InitializeComponent();
        }

        private void buttonConverter_Click(object sender, EventArgs e)
        {
            textBoxRomanoConvertido.Text = conversor.ConverterParaRomano(Convert.ToInt32(numericUpDownDecimais.Value));

        }

        private void buttonConverterDeVoltaDecimal_Click(object sender, EventArgs e)
        {
            if(numericUpDownDecimais.Value > 0 || textBoxRomanoConvertido.Text != String.Empty)
            textBoxDeVoltaDecimais.Text = Convert.ToString(conversor.ConverterParaDecimal(textBoxRomanoConvertido.Text));
        }

        private void buttonMaisCem_Click(object sender, EventArgs e)
        {
            if (numericUpDownDecimais.Value <= 3900)
                if (numericUpDownDecimais.Value == 3900)
                    numericUpDownDecimais.Value += 99;
                else
                    numericUpDownDecimais.Value += 100;
        }

        private void buttonMaisQuinhentos_Click(object sender, EventArgs e)
        {
            if (numericUpDownDecimais.Value <= 3500)
                if (numericUpDownDecimais.Value == 3500)
                    numericUpDownDecimais.Value += 499;
                else
                    numericUpDownDecimais.Value += 500;
        }

        private void buttonMaisMil_Click(object sender, EventArgs e)
        {
            if (numericUpDownDecimais.Value <= 3000)
                if (numericUpDownDecimais.Value == 3000)
                    numericUpDownDecimais.Value += 999;
                else
                    numericUpDownDecimais.Value += 1000;
        }

        private void buttonMenosCem_Click(object sender, EventArgs e)
        {
            if (numericUpDownDecimais.Value >= 100)
                numericUpDownDecimais.Value -= 100;
        }
        private void buttonMenos500_Click(object sender, EventArgs e)
        {
            if (numericUpDownDecimais.Value >= 500)
                numericUpDownDecimais.Value -= 500;
        }

        private void buttonMenos1000_Click(object sender, EventArgs e)
        {
            if (numericUpDownDecimais.Value >= 1000)
                numericUpDownDecimais.Value -= 1000;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            numericUpDownDecimais.Value = 0;
            textBoxRomanoConvertido.Clear();
            textBoxDeVoltaDecimais.Clear();
        }

        private void timerTemp_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1)
                timerTemp.Stop();
            Opacity += .1;
        }

        private void buttonRandom_Click(object sender, EventArgs e)
        {
            Random r = new();
            numericUpDownDecimais.Value = r.Next(1, 3999);
        }
    }
}
