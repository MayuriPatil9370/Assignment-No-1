using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace My_Controls
{
    public partial class frm_My_Controls : Form
    {
        public frm_My_Controls()
        {
            InitializeComponent();
        }

        private void frm_My_Controls_Load(object sender, EventArgs e)
        {
            lbl_Username.Text = "Welcome " + Shared_Class.Username;
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Are You Sure Want To Logout??", "LOGOUT", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (Res == DialogResult.Yes)
            {
                frm_Login Obj = new frm_Login();
                Obj.Show();
                this.Hide();
            }
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string Output = "";
            if (tb_Student_Name.Text != "" && (rb_Male.Checked == true || rb_Female.Checked == true) && (rb_Afternoon.Checked == true || rb_Evening.Checked == true))
            {
                lbl_Error1.Visible = false;
                lbl_Error2.Visible = false;
                lbl_Error3.Visible = false;
            }
            if (tb_Student_Name.Text != "")
            {
                if (rb_Female.Checked == true)
                {
                    Output = tb_Student_Name.Text + " is " + rb_Female.Text + ",";
                }
                else if (rb_Male.Checked == true)
                {
                    Output = tb_Student_Name.Text + " is " + rb_Male.Text + ",";
                }
                else
                {
                    lbl_Error2.Text = "Select Gender";
                    lbl_Error2.Visible = true;
                }
            }
            else
            {
                lbl_Error1.Text = "Fill Student Name";
                lbl_Error1.Visible = true;
            }
            if (rb_Morning.Checked == true)
            {
                Output += " want batch time at " + rb_Morning.Text + " ,";
            }
            else if (rb_Afternoon.Checked == true)
            {
                Output += " want batch time at " + rb_Afternoon.Text + ",";
            }
            else if (rb_Evening.Checked == true)
            {
                Output += " want batch time at " + rb_Evening.Text + ",";
            }
            else
            {
                lbl_Error3.Text = "Select Prefered Batch Time";
                lbl_Error3.Visible = true;
            }
            tb_Output1.Text = Output;
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            string Prog = tb_Student_Name.Text + " Knows ";
            if (cb_C.Checked == true)
            {
                if (cb_CPP.Checked == false && cb_CSharp.Checked == false && cb_Java.Checked == false)
                {
                    Prog += " " + cb_C.Text + " .";
                }
                else
                {
                    Prog += " " + cb_C.Text + " ,";
                }
            }

            if (cb_CPP.Checked == true)
            {
                if (cb_CSharp.Checked == false && cb_Java.Checked == false)
                {
                    Prog += " " + cb_CPP.Text + " .";
                }
                else
                {
                    Prog += " " + cb_CPP.Text + " ,";
                }
            }
            if (cb_CSharp.Checked == true)
            {
                if (cb_Java.Checked == false)
                {
                    Prog += " " + cb_CSharp.Text + " .";
                }
                else
                {
                    Prog += " " + cb_CSharp.Text + " ,";
                }
            }
            if (cb_Java.Checked ==true)
            {
                Prog += " " + cb_Java.Text + " .";
            }
            if (cb_C.Checked == false && cb_CPP.Checked == false && cb_CSharp.Checked == false && cb_Java.Checked == false)
            {
                Prog = tb_Student_Name.Text + " Dont Have Knowledge Of Any Programming Skills";
            }

            if (rb_Female.Checked == true)
            {
                Prog += " And She Wants To Be ";
            }
            else if (rb_Male.Checked == true)
            {
                Prog += " And He Wnats To Be ";
            }
            else
            {
                Prog += " Want To Be ";
            }
            for (int i = 0; i <= (clb_Choices.Items.Count - 1); i++)
            {
                if (clb_Choices.GetItemChecked(i))
                {
                    Prog += " " + clb_Choices.Items[i].ToString();
                }
            }
            tb_Output2.Text = Prog;
        }

    }
}
