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
    public partial class AgregarMovimientos : Form
    {
        public AgregarMovimientos()
        {
            InitializeComponent();
        }

        private void AgregarMovimientos_Load(object sender, EventArgs e)
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
                int accountId = Convert.ToInt32(txtAccountId.Text);
                DateTime date = dateTimeFecha.Value;
                string description = txtDescription.Text;
                int amount = Convert.ToInt32(txtAmount.Text);
                txtAccountId.Text = String.Empty;
                txtDescription.Text = String.Empty;
                txtAmount.Text = String.Empty;
                AccountManager.Bank bank = new AccountManager.Bank();
                if (bank.NewAccountMovement(accountId, description, amount, date))
                {
                    MessageBox.Show("Movimiento agregado correctamente.");
                }
                else
                {
                    MessageBox.Show("La cuenta no existe.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Formato incorrecto, por favor verifique los datos.");
            }
        }
    }
}
