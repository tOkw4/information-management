using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INFORMATION_MANAGEMENT
{
    public partial class STUDENTRECORD : Form
    {
        public STUDENTRECORD()
        {
            InitializeComponent();
        }

        private void addstudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADD_STUDENT aDD = new ADD_STUDENT();
            aDD.ShowDialog();
            this.Show();

        }

        private void add_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADD aDD = new ADD();
            aDD.ShowDialog();
            this.Show();
        }

        private void view_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost; user id= root; password=; database= student record";
            string query = "SELECT * FROM tbl_student_name";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void del_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost; user id= root; password=; database= student record";
            string query = "DELETE FROM tbl_student_name WHERE `STUDENT ID`= '" + this.studentid.Text + "'";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Succesfully Deleted");
            conn.Close();
        }

        private void studentid_TextChanged(object sender, EventArgs e)
        {
            string connection = "server=localhost; user id= root; password=; database= student record";
            MySqlConnection con = new MySqlConnection(connection);
            MySqlDataAdapter da;
            DataTable dt;
            con.Open();
            da = new MySqlDataAdapter("SELECT * FROM tbl_student_name WHERE `STUDENT ID` LIKE '" + this.studentid.Text + "%' OR `NAME` LIKE '" + this.studentid.Text + "%' " +
                "OR `FIRST NAME` LIKE '" + this.studentid.Text + "%' OR `MIDDLE INITIAL` LIKE '" + this.studentid.Text + "%'", con);

            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void STUDENTRECORD_Load(object sender, EventArgs e)
        {
            string connection = "server=localhost; user id= root; password=; database= student record";
            string query = "SELECT * FROM tbl_student_name";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
 
        
    }
}
