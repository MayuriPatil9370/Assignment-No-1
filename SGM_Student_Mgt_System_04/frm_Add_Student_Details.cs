using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SGM_Student_Mgt_System_04
{
    public partial class frm_Add_Student_Details : Form
    {
        public frm_Add_Student_Details()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=SGM_04_DB;Integrated Security=True");
        
        void Con_Open()
        {
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
        }
        void Con_Close()
        {
            if (Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (Char)Keys.Back)))
            {
                e.Handled = true;
            }
        }
        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (Char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }
        void Clear_Controls()
        {
            tb_Roll_No.Text = Convert.ToString(Auto_Incr());
            tb_Name.Clear();
            tb_Mobile_No.Clear();
            cmd_Course.SelectedIndex = -1;
            dtp_DOB.Text = "31-12-2003";
        }
        int Auto_Incr()
        {
            int Cnt = 0;
            Con_Open();
            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;
            Cmd.CommandText = "Select Count(*)From Student_Details";

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            if (Cnt > 0)
            {
                Cmd.CommandText = "Select Max(Roll_No)From Student_Details";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar()) + 1;
            }
            else
            {
                Cnt = 101;
            }
            Con_Close();
            return Cnt;
        }
        void Bind_Combobox()
        {
            Con_Open();
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;
            Cmd.CommandText = "Select Distinct(Course_Name)From tb_Course";

            SqlDataReader Dr = Cmd.ExecuteReader();

            while (Dr.Read())
            {
                cmd_Course.Items.Add(Dr.GetString(Dr.GetOrdinal("Course_Name")));
            }
            Con_Close();
        }

        private void frm_Add_Student_Details_Load(object sender, EventArgs e)
        {
            
          
            Clear_Controls();
            tb_Roll_No.Focus();

            Bind_Combobox();

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if(tb_Roll_No.Text!="" && tb_Name.Text!="" && tb_Mobile_No.Text !="" && cmd_Course.Text !="")
            {
                SqlCommand Cmd=new SqlCommand();

                Cmd.Connection=Con;
                Cmd.CommandText="Insert Into Student_Details (Roll_No,Name,DOB,Mobile_No,Course) Values (@RNo,@Name,@DOB,@MobNo,@Course)";

                Cmd.Parameters.Add("RNo",SqlDbType.Int).Value=tb_Roll_No.Text;
                Cmd.Parameters.Add("Name", SqlDbType.VarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("DOB",SqlDbType.Date).Value=dtp_DOB.Value.Date;
                Cmd.Parameters.Add("MobNo",SqlDbType.Decimal).Value=tb_Mobile_No.Text;
                Cmd.Parameters.Add("Course",SqlDbType.NVarChar).Value=cmd_Course.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Saved");
                Clear_Controls();
            }
            else
            {
                MessageBox.Show("Fill All Fields");
            }
            Con_Close();



        }

        

       
       
    }
}
