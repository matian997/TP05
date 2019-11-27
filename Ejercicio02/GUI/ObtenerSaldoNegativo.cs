using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio02.AccountManager.IO;

namespace Ejercicio02.GUI
{
    public partial class ObtenerSaldoNegativo : Form
    {
        public ObtenerSaldoNegativo()
        {
            InitializeComponent();
        }

        private void ObtenerSaldoNegativo_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            AccountManager.Bank bank = new AccountManager.Bank();
            listViewAccounts.Items.Clear();
            var accounts = bank.GetAccountsNegativeAMount();
            foreach (AccountDTO acc in accounts)
            {
                ListViewItem item = new ListViewItem();
                item = listViewAccounts.Items.Add(acc.Id.ToString());
                item.SubItems.Add(acc.Name);
                item.SubItems.Add(acc.OverDraftLimit.ToString());
                item.SubItems.Add(acc.Balance.ToString());
            }
        }

        private void listViewAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
