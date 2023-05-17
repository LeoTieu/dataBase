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
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = "provider= Microsoft.ace.oledb.12.0; Data Source=dbPhonebook.accdb";
            conn.Open();
            OleDbCommand comm = new OleDbCommand();
            comm.CommandText = "select * from ContactList";
            comm.Connection = conn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = comm;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void ButtonInsert_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = "provider= Microsoft.ace.oledb.12.0; Data Source=dbPhonebook.accdb";
            conn.Open();
            OleDbCommand comm = new OleDbCommand();
            comm.CommandText = "insert into ContactList(Fname, Lname, Email, Mobile) " +
                "values('"+TFname.Text+"', '"+TLname.Text+"', '"+TEmail.Text+"','"+TMobile.Text+"')";
            comm.Connection = conn;
            comm.ExecuteNonQuery();
            conn.Close();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = "provider= Microsoft.ace.oledb.12.0; Data Source=dbPhonebook.accdb";
            conn.Open();
            OleDbCommand comm = new OleDbCommand();
            comm.CommandText = "delete from ContactList where (Fname = '" + TFname.Text + "') and (LName = '" + TLname.Text + "')";
            comm.Connection = conn;
            comm.ExecuteNonQuery();
            conn.Close();
        }
    }
}
