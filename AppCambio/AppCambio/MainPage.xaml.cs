using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using System.Globalization;

namespace AppCambio
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                NumberFormatInfo nfi = new CultureInfo("pt-BR").NumberFormat;

                double valor_dolares = Convert.ToDouble(txt_dolares.Text);
                double valor_cotacao = Convert.ToDouble(txt_cotacao.Text);

                double valor_reais = valor_cotacao * valor_dolares;
                lbl_resultado.Text = $"O valor em reais é { valor_reais.ToString("C", nfi) } ";
                lbl_resultado.TextColor = Color.Black;

            } catch(Exception ex)
            {
                //lbl_resultado.Text = ex.Message;
                lbl_resultado.Text = "Ops, occoreu um erro ao fazer o cálculo. Verifique os valores.";
                lbl_resultado.TextColor = Color.Red;
            }
        }
    }
}
