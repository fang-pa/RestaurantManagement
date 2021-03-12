using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
namespace RestaurantManagement
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\RestaurantManagement\Deltafood.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SqlDataAdapter datafood;
        DataTable menufood = new DataTable();
        DataTable in_select = new DataTable();
        public Form1()
        {
            InitializeComponent();
            using (cmd = new SqlCommand("SELECT F_Name,F_Price,F_Pic,TF_Name FROM Food F,TypeFood TyFd WHERE F.TF_ID=TyFd.TF_ID AND F_Status=1", con))
            {
                using (datafood = new SqlDataAdapter(cmd))
                {
                    datafood.Fill(menufood);
                }
            }
            Da_Sh_Menu.DataSource = menufood;
            in_select = menufood.Clone();
            Da_SEL_Menu.DataSource = in_select;

            Da_Sh_Menu.DataSource = menufood;
            Da_Sh_Menu.Columns["F_Name"].HeaderText = "ชื่ออาหาร";
            Da_Sh_Menu.Columns["F_Price"].HeaderText = "ราคา";
            Da_Sh_Menu.Columns["F_Pic"].HeaderText = "รูปภาพ";
            Da_Sh_Menu.Columns["TF_Name"].HeaderText = "ประเภท";
            
            Da_SEL_Menu.DataSource = in_select;
            in_select.Columns.Add("FoodAmount", typeof(int));

            Da_SEL_Menu.Columns["F_Name"].HeaderText = "ชื่ออาหาร";
            Da_SEL_Menu.Columns["F_Price"].HeaderText = "ราคา";
            Da_SEL_Menu.Columns["F_Pic"].HeaderText = "รูปภาพ";
            Da_SEL_Menu.Columns["TF_Name"].HeaderText = "ประเภท";
            Da_SEL_Menu.Columns["FoodAmount"].HeaderText = "จำนวน";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("SELECT * FROM TypeFood", con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            DataTable typefood = new DataTable();
            typefood.Columns.Add("TypeFood", typeof(string));
            typefood.Load(reader);
            con.Close();
        }

        private void Bt_Add_Click(object sender, EventArgs e)
        {
            int index = Da_Sh_Menu.SelectedCells[0].RowIndex;
            in_select.ImportRow(menufood.Rows[index]);
            Da_SEL_Menu.DataSource = null;
            Da_SEL_Menu.DataSource = in_select;
        }

        private void Bt_Ad_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(amount_of_F.Text);
            value = value + 1;
            amount_of_F.Text = value.ToString();
        }

        private void Bt_Del_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(amount_of_F.Text);
            if (value - 1 != 0)
            {
                value = value - 1;
                amount_of_F.Text = value.ToString();

            }
        }

        private void Bt_Delete_Click(object sender, EventArgs e)
        {
            int Selected = Da_SEL_Menu.SelectedCells[0].RowIndex;
            Da_SEL_Menu.Rows.RemoveAt(Selected);
        }

        private void Bt_Clear_Click(object sender, EventArgs e)
        {
            in_select.Rows.Clear();
            Da_SEL_Menu.DataSource = in_select;
        }

        private void Bt_Confirm_Click(object sender, EventArgs e)
        {

        }
    }
}
