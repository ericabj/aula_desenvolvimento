using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChaveFacil
{
    public partial class FrmChaveFacil : Form
    {
        public FrmChaveFacil()
        {
            InitializeComponent();
            Form2 form2 = new Form2();
        }

        private void retirarchave(Button devolver, Button retirar, Panel janela)
        {
            devolver.Enabled = true;
            retirar.Enabled = false;
            janela.BackColor = Color.Red;
            Form2 form2 = new Form2();
            form2.ShowDialog();
            string nomefuncionario = Form2.a;
        }
        private void devolverchave(Button devolver, Button retirar, Panel janela)
        {
            devolver.Enabled = false;
            retirar.Enabled = true;
            janela.BackColor = Color.Lime;
            Form2 form2 = new Form2();
            form2.ShowDialog();
            string nomefuncionario = Form2.a;
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnRtrS1_Click(object sender, EventArgs e)
        {
            retirarchave(btnDvlrS1, btnRtrS1, panel1);
            
        }

        private void btnDvlrS1_Click(object sender, EventArgs e)
        {
            devolverchave(btnDvlrS1, btnRtrS1, panel1);

        }


        private void btretirars2_Click(object sender, EventArgs e)
        {
            retirarchave(btdevolvers2, btretirars2, painel2);
        }

        private void btdevolvers2_Click(object sender, EventArgs e)
        {
            devolverchave(btdevolvers2,btretirars2, painel2);
        }
    }
}
