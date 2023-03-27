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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace TORES
{
    public partial class frmMeetRoom : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-V653CLI\SQLEXPRESS01;Initial Catalog=TORESDB;Integrated Security=True");
        
        public frmMeetRoom()
        {
            InitializeComponent();
        }

        private void RoomLoad()
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM datRoom", connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxMeetRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = cbxMeetRoom.SelectedIndex.ToString();

            switch (selected)
            {
                case "Ephesus1":
                   
                    break;
                case "Phokaia2":
                    
                    break;
                case "Milet3":
                    
                    break;
                case "Aspendos4":
                   
                    break;
                case "Theos5":
                    
                    break;
                case "Aizanoi6":
                   
                    break;
                case "Anavarza7":
                    
                    break;
                case "Zeugma8":
                    chckbBoard.Enabled = true;
                    chckbInternet.Enabled = true;
                    break;
                case "Knidos9":
                    chckbBoard.Enabled = true;
                    chckbInternet.Enabled = true;
                    break;
                case "Apollon10":
                    chckbBoard.Enabled = true;
                    chckbInternet.Enabled = true;
                    break;
                default:
                    break;
            }

        }
        private void frmMeetRoom_Load(object sender, EventArgs e)
        {
          cbxMeetRoom.SelectedIndex = 0;
            nudRoomCapacity.Enabled = false;
            chckbBoard.Enabled = false;
            chckbInternet.Enabled = false;
            chckbIPTV.Enabled = false;
            chckbProjection.Enabled = false;
            chckbVOIP.Enabled = false;
        }
    }
}
