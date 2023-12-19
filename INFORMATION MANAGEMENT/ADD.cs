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
    public partial class ADD : Form
    {
        public ADD()
        {
            InitializeComponent();
        }

        private void addbttn_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost; user id= root; password=; database= student record";
            string query = "UPDATE tbl_student_name " +
    "SET `INFORMATION MANAGEMENT` = '" + this.im.Text + "', " +
    "`SYSTEM ADMIN` = '" + this.sam.Text + "', " +
    "`ETHICAL HACKING` = '" + this.eh.Text + "', " +
    "`INTERNET TECH` = '" + this.it.Text + "', " +
    "`ASSURANCE` = '" + this.ias.Text + "', " +
    "`METHODS OF RESEARCH` = '" + this.mor.Text + "', " +
    "`SIA` = '" + this.sia.Text + "' " +
    "WHERE `STUDENT ID` = '" + this.STUDENT_ID.Text + "'";



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
