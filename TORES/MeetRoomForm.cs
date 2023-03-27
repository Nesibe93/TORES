using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TORES
{
    public partial class frmMeetRoom : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-V653CLI\SQLEXPRESS01;Initial Catalog=TORESDB;Integrated Security=True");

        //string connectionString;
        public frmMeetRoom()
        {
            InitializeComponent();
        }

        private void RoomLoad()
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM datRoom", connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbxMeetRoom.DataSource = dt;
            cbxMeetRoom.DisplayMember = "RoomName";
            cbxMeetRoom.ValueMember = "RoomID";
            connection.Close();
        }

        private void RoomPropLoad()
        {

        }
        private void DatagwLoad()
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM datRoom", connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgwMeetRoom.DataSource = dt;
            connection.Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxMeetRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            // comboboxtaki tıklanan değere göre checkboxın enabled / falsed değerini ayarlama yapılacak


            string selectedValue = cbxMeetRoom.SelectedItem.ToString();



        }
        private void frmMeetRoom_Load(object sender, EventArgs e)
        {
            RoomLoad();
            DatagwLoad();
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            // Kullanıcının karar verdiği odanın SelectedValue değerini rezervasyon istek formuna parametre olarak gönderilecek
        }
    }
}
