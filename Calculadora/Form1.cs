using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LblResultado.Text = "";
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            DialogResult Sair;
            Sair = MessageBox.Show("Deseja mesmo sair do sistema?", "Pergunta",  MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Sair.Equals(DialogResult.No))
            {
            }
            else 
            { 
                Application.Exit();
            }
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            double n1 = 0;
            double n2 = 0;

            double resultado = 0;

            n1 = Convert.ToDouble(TxtNum1.Text);
            n2 = Convert.ToDouble(TxtNum2.Text);

            switch(CboTipoCalc.SelectedItem.ToString())
            {
                case "Div":
                    resultado = n1 / n2;
                    break;
                case "Soma":
                    resultado = n1 + n2;
                    break;
                case "Mult":
                    resultado = n1 * n2;
                    break;
                case "Sub":
                    resultado = n1 - n2;
                    break;

            }

            /* COM IF E ELSE
             //SE FOR DIVISÃO 
             if (CboTipoCalc.SelectedItem.ToString() == "Div")
             {
                 resultado = n1 / n2;
             }else { }

             //SE FOR SOMA
             if (CboTipoCalc.SelectedItem.ToString() == "Soma")
             {
                 resultado = n1 + n2;
             }else { }

             //SE FOR MULTIPLICAÇÃO
             if (CboTipoCalc.SelectedItem.ToString() == "Mult")
             {
                 resultado = n1 * n2;
             }else { }

             //SE FOR SUBTRAÇÃO
             if (CboTipoCalc.SelectedItem.ToString() == "Sub")
             {
                 resultado = n1 - n2;
             }else { }
            */

            LblResultado.Text = Convert.ToString(resultado);
           
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtNum1.Clear();
            TxtNum2.Clear();
            LblResultado.Text = ""; 
        }
    }
}
