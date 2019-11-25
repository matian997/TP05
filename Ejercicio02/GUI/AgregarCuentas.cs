using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio02.GUI
{
    public partial class AgregarCuentas : Form
    {
        public AgregarCuentas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form menuPrincial = new MenuPrincipal();
            menuPrincial.Show();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int idCliente = Convert.ToInt32(txtClientId.Text);
                string name = txtName.Text;
                int overdraftlimit = Convert.ToInt32(txtOverdraftLimit.Text);
                txtClientId.Text = String.Empty;
                txtName.Text = String.Empty;
                txtOverdraftLimit.Text = String.Empty;
                AccountManager.Bank bank = new AccountManager.Bank();
                if (bank.NewAccount(idCliente, name, overdraftlimit))
                {
                    MessageBox.Show("Cuenta agregada correctamente.");
                }
                else
                {
                    MessageBox.Show("El cliente no existe.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Formato incorrecto, por favor verifique los datos.");
            }
        }
    }
}
