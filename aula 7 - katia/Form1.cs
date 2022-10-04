using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula_7___katia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        List<Pet> listpet = new List<Pet>();


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Pet animal = new Pet();
            animal.Animal = txtPet.Text;
            animal.Idade = Convert.ToInt32(txtIdade.Text);
            animal.Especie = cbxEspecie.Text;
            animal.Dono = txtDono.Text;
            listpet.Add(animal);
            limpar();
        }

        private void limpar()
        {
            txtPet.Text = null;
            txtDono.Text = null;
            txtIdade.Text = null;
            cbxEspecie.SelectedIndex = -1;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            int op = 0;
            for (int i = 0; i < listpet.Count; i++)
            {
                if (txtPet.Text.Equals(listpet[i].Animal))
                {
                    txtDono.Text = listpet[i].Dono;
                    txtIdade.Text = listpet[i].Idade.ToString();
                    cbxEspecie.Text = listpet[i].Especie;
                    op = 1;
                    break;
                }
            }
            if (op == 0)
            {
                MessageBox.Show("Pet não encontrado!");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listpet.Count; i++)
            {
                if (txtPet.Text.Equals(listpet[i].Animal))
                {
                    listpet.RemoveAt(i);
                }
            }
        }
    }
}