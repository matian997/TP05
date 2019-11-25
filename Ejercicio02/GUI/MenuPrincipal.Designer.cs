using System;

namespace Ejercicio02.GUI
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.IdCliente = new System.Windows.Forms.Label();
            this.btnGetClientAccounts = new System.Windows.Forms.Button();
            this.txtIdClient = new System.Windows.Forms.TextBox();
            this.txtIdAccount = new System.Windows.Forms.TextBox();
            this.idAccount = new System.Windows.Forms.Label();
            this.btnGetAccountMovements = new System.Windows.Forms.Button();
            this.listViewAccountMovements = new System.Windows.Forms.ListView();
            this.columnIdMovement = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewAccounts = new System.Windows.Forms.ListView();
            this.columnIdAccount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnOverdraftLimit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnBalance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBoxCuentas = new System.Windows.Forms.GroupBox();
            this.groupBoxMovimientos = new System.Windows.Forms.GroupBox();
            this.groupBoxCuentas.SuspendLayout();
            this.groupBoxMovimientos.SuspendLayout();
            this.SuspendLayout();
            // 
            // IdCliente
            // 
            this.IdCliente.AutoSize = true;
            this.IdCliente.Location = new System.Drawing.Point(5, 19);
            this.IdCliente.Name = "IdCliente";
            this.IdCliente.Size = new System.Drawing.Size(65, 13);
            this.IdCliente.TabIndex = 1;
            this.IdCliente.Text = "Id de cliente";
            this.IdCliente.Click += new System.EventHandler(this.idCliente_Click);
            // 
            // btnGetClientAccounts
            // 
            this.btnGetClientAccounts.Location = new System.Drawing.Point(223, 14);
            this.btnGetClientAccounts.Name = "btnGetClientAccounts";
            this.btnGetClientAccounts.Size = new System.Drawing.Size(136, 23);
            this.btnGetClientAccounts.TabIndex = 2;
            this.btnGetClientAccounts.Text = "Buscar";
            this.btnGetClientAccounts.UseVisualStyleBackColor = true;
            this.btnGetClientAccounts.Click += new System.EventHandler(this.btnGetClientAccounts_Click);
            // 
            // txtIdClient
            // 
            this.txtIdClient.Location = new System.Drawing.Point(76, 17);
            this.txtIdClient.Name = "txtIdClient";
            this.txtIdClient.Size = new System.Drawing.Size(141, 20);
            this.txtIdClient.TabIndex = 3;
            this.txtIdClient.TextChanged += new System.EventHandler(this.txtIdClient_TextChanged);
            // 
            // txtIdAccount
            // 
            this.txtIdAccount.Location = new System.Drawing.Point(80, 16);
            this.txtIdAccount.Name = "txtIdAccount";
            this.txtIdAccount.Size = new System.Drawing.Size(132, 20);
            this.txtIdAccount.TabIndex = 4;
            // 
            // idAccount
            // 
            this.idAccount.AutoSize = true;
            this.idAccount.Location = new System.Drawing.Point(7, 19);
            this.idAccount.Name = "idAccount";
            this.idAccount.Size = new System.Drawing.Size(67, 13);
            this.idAccount.TabIndex = 5;
            this.idAccount.Text = "Id de cuenta";
            // 
            // btnGetAccountMovements
            // 
            this.btnGetAccountMovements.Location = new System.Drawing.Point(218, 14);
            this.btnGetAccountMovements.Name = "btnGetAccountMovements";
            this.btnGetAccountMovements.Size = new System.Drawing.Size(143, 23);
            this.btnGetAccountMovements.TabIndex = 6;
            this.btnGetAccountMovements.Text = "Buscar";
            this.btnGetAccountMovements.UseVisualStyleBackColor = true;
            this.btnGetAccountMovements.Click += new System.EventHandler(this.btnGetAccountMovements_Click);
            // 
            // listViewAccountMovements
            // 
            this.listViewAccountMovements.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnIdMovement,
            this.columnDate,
            this.columnDescription,
            this.columnAmount});
            this.listViewAccountMovements.HideSelection = false;
            this.listViewAccountMovements.Location = new System.Drawing.Point(415, 79);
            this.listViewAccountMovements.Name = "listViewAccountMovements";
            this.listViewAccountMovements.Size = new System.Drawing.Size(351, 295);
            this.listViewAccountMovements.TabIndex = 7;
            this.listViewAccountMovements.UseCompatibleStateImageBehavior = false;
            this.listViewAccountMovements.View = System.Windows.Forms.View.Details;
            this.listViewAccountMovements.SelectedIndexChanged += new System.EventHandler(this.listViewAccountMovements_SelectedIndexChanged);
            // 
            // columnIdMovement
            // 
            this.columnIdMovement.Text = "IdMovement";
            this.columnIdMovement.Width = 71;
            // 
            // columnDate
            // 
            this.columnDate.Text = "Date";
            this.columnDate.Width = 80;
            // 
            // columnDescription
            // 
            this.columnDescription.Text = "Description";
            this.columnDescription.Width = 140;
            // 
            // columnAmount
            // 
            this.columnAmount.Text = "Amount";
            // 
            // listViewAccounts
            // 
            this.listViewAccounts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnIdAccount,
            this.columnName,
            this.columnOverdraftLimit,
            this.columnBalance});
            this.listViewAccounts.HideSelection = false;
            this.listViewAccounts.Location = new System.Drawing.Point(26, 79);
            this.listViewAccounts.Name = "listViewAccounts";
            this.listViewAccounts.Size = new System.Drawing.Size(351, 295);
            this.listViewAccounts.TabIndex = 8;
            this.listViewAccounts.UseCompatibleStateImageBehavior = false;
            this.listViewAccounts.View = System.Windows.Forms.View.Details;
            this.listViewAccounts.SelectedIndexChanged += new System.EventHandler(this.listViewAccounts_SelectedIndexChanged);
            // 
            // columnIdAccount
            // 
            this.columnIdAccount.Text = "IdAccount";
            this.columnIdAccount.Width = 62;
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 110;
            // 
            // columnOverdraftLimit
            // 
            this.columnOverdraftLimit.Text = "OverdraftLimit";
            this.columnOverdraftLimit.Width = 101;
            // 
            // columnBalance
            // 
            this.columnBalance.Text = "Balance";
            this.columnBalance.Width = 120;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(691, 391);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBoxCuentas
            // 
            this.groupBoxCuentas.Controls.Add(this.txtIdClient);
            this.groupBoxCuentas.Controls.Add(this.btnGetClientAccounts);
            this.groupBoxCuentas.Controls.Add(this.IdCliente);
            this.groupBoxCuentas.Location = new System.Drawing.Point(18, 36);
            this.groupBoxCuentas.Name = "groupBoxCuentas";
            this.groupBoxCuentas.Size = new System.Drawing.Size(368, 349);
            this.groupBoxCuentas.TabIndex = 10;
            this.groupBoxCuentas.TabStop = false;
            this.groupBoxCuentas.Text = "Cuentas";
            this.groupBoxCuentas.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBoxMovimientos
            // 
            this.groupBoxMovimientos.Controls.Add(this.idAccount);
            this.groupBoxMovimientos.Controls.Add(this.txtIdAccount);
            this.groupBoxMovimientos.Controls.Add(this.btnGetAccountMovements);
            this.groupBoxMovimientos.Location = new System.Drawing.Point(405, 36);
            this.groupBoxMovimientos.Name = "groupBoxMovimientos";
            this.groupBoxMovimientos.Size = new System.Drawing.Size(369, 349);
            this.groupBoxMovimientos.TabIndex = 11;
            this.groupBoxMovimientos.TabStop = false;
            this.groupBoxMovimientos.Text = "Movimientos";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 419);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.listViewAccounts);
            this.Controls.Add(this.listViewAccountMovements);
            this.Controls.Add(this.groupBoxCuentas);
            this.Controls.Add(this.groupBoxMovimientos);
            this.Name = "MenuPrincipal";
            this.Text = "Bank";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.groupBoxCuentas.ResumeLayout(false);
            this.groupBoxCuentas.PerformLayout();
            this.groupBoxMovimientos.ResumeLayout(false);
            this.groupBoxMovimientos.PerformLayout();
            this.ResumeLayout(false);

        }

        private void idCliente_Click(object sender, EventArgs e)
        {
        
        }

        private void txtIdClient_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void listViewAccountMovements_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void listViewAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        #endregion
        private System.Windows.Forms.Label IdCliente;
        private System.Windows.Forms.Button btnGetClientAccounts;
        private System.Windows.Forms.TextBox txtIdClient;
        private System.Windows.Forms.TextBox txtIdAccount;
        private System.Windows.Forms.Label idAccount;
        private System.Windows.Forms.Button btnGetAccountMovements;
        private System.Windows.Forms.ListView listViewAccountMovements;
        private System.Windows.Forms.ListView listViewAccounts;
        private System.Windows.Forms.ColumnHeader columnIdAccount;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnOverdraftLimit;
        private System.Windows.Forms.ColumnHeader columnBalance;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ColumnHeader columnIdMovement;
        private System.Windows.Forms.ColumnHeader columnDate;
        private System.Windows.Forms.ColumnHeader columnDescription;
        private System.Windows.Forms.ColumnHeader columnAmount;
        private System.Windows.Forms.GroupBox groupBoxCuentas;
        private System.Windows.Forms.GroupBox groupBoxMovimientos;
    }
}