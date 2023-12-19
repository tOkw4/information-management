using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace INFORMATION_MANAGEMENT
{
    public partial class ADD_STUDENT : Form
    {
        public ADD_STUDENT()
        {
            InitializeComponent();
        }

        private void addstudentbttn_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost; user id= root; password=; database= student record";
            string query = "INSERT INTO tbl_student_name(`NAME`, `FIRST NAME`, `MIDDLE INITIAL`) VALUES ('" + this.last.Text + "','" + this.first.Text + "','" + this.middle.Text + "')";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Succesfully saved");
            conn.Close();
        
        
        }
    }
}
