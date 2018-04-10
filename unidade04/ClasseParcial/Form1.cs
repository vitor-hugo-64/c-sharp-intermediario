using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClasseParcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Botao.Text = "BOTÂO"; // isso é um exemplo de aplicacao de classe parcial, aqui está sendo chamado os atributos da classe form, mas os atributos estão armazenados em outro arquivo

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
