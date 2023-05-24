using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPhoneBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Skapar en koppling med databasen.
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = "provider= Microsoft.ace.oledb.12.0; Data Source=dbPhonebook.accdb";
            // Öppnar databasen.
            conn.Open();
            OleDbCommand comm = new OleDbCommand();
            // Välj alla från kontaktlistan.
            comm.CommandText = "select * from ContactList";
            comm.Connection = conn;
            // Resten av kommandon fyller hela dataGrid.
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = comm;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            // Stänger databasen.
            conn.Close();
        }

        private void ButtonInsert_Click(object sender, EventArgs e)
        {
            // Skapar en koppling med databasen.
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = "provider= Microsoft.ace.oledb.12.0; Data Source=dbPhonebook.accdb";
            // Öppnar databsen.
            conn.Open();
            OleDbCommand comm = new OleDbCommand();
            // Lägger in fname, lname, email och mobil.
            comm.CommandText = "insert into ContactList(Fname, Lname, Email, Mobile) " +
                "values('"+TFname.Text+"', '"+TLname.Text+"', '"+TEmail.Text+"','"+TMobile.Text+"')";
            comm.Connection = conn;
            comm.ExecuteNonQuery();
            // Stänger databasen.
            conn.Close();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            // Skapar koppling med databasen.
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = "provider= Microsoft.ace.oledb.12.0; Data Source=dbPhonebook.accdb";
            // Öppnar databasen.
            conn.Open();
            OleDbCommand comm = new OleDbCommand();
            // Raderar kontaktlistan där förnamn och efternamn passar in med input.
            comm.CommandText = "delete from ContactList where (Fname = '" + TFname.Text + "') and (LName = '" + TLname.Text + "')";
            comm.Connection = conn;
            comm.ExecuteNonQuery();
            // Stänger databasen.
            conn.Close();
        }
    }
}
