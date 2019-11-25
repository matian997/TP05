using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio02.AccountManager;
using Ejercicio02.AccountManager.IO;

namespace Ejercicio02.GUI
{
    public partial class MenuPrincipal : Form
    {
        private Bank bank;
        public MenuPrincipal()
        {
            InitializeComponent();
            bank = new Bank();
        }

        private void btnGetClientAccounts_Click(object sender, EventArgs e)
        {
            int idClient = Convert.ToInt32(txtIdClient.Text);
            txtIdClient.Text = String.Empty;
            listViewAccounts.Items.Clear();
            var accounts = bank.GetClientAccounts(idClient);
            foreach (AccountDTO acc in accounts)
            {
                ListViewItem item = new ListViewItem();
                item = listViewAccounts.Items.Add(acc.Id.ToString());
                item.SubItems.Add(acc.Name);
                item.SubItems.Add(acc.OverDraftLimit.ToString());
                item.SubItems.Add(acc.Balance.ToString());
            }
        }
        private void btnGetAccountMovements_Click(object sender, EventArgs e)
        {
            try
            {
                int idAccount = Convert.ToInt32(txtIdAccount.Text);
                txtIdAccount.Text = String.Empty;
                listViewAccountMovements.Items.Clear();
                var movements = bank.GetAccountMovements(idAccount);
                if (movements.Count() == 0)
                {
                    MessageBox.Show("No se encuentra movimientos en la cuenta, o la cuenta no existe.");
                }
                else
                {
                    foreach (AccountMovementDTO mov in movements)
                    {
                        ListViewItem item = new ListViewItem();
                        item = listViewAccountMovements.Items.Add(mov.Id.ToString());
                        item.SubItems.Add(mov.Date.ToString());
                        item.SubItems.Add(mov.Description);
                        item.SubItems.Add(mov.Amount.ToString());
                    }
                }
            }
            catch (FormatException exc)
            {
                MessageBox.Show("Formato incorrecto, solo caracteres numericos.");
            }
        }
  
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
