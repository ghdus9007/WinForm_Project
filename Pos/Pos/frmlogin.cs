using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pos
{
    public partial class frmlogin : Form
    {
        DataTable dt;
        DataRowCollection drc;
        DataSet ds;
        public frmlogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            this.Hide();
            new Form1().ShowDialog();
            this.Close();
=======
            if(textBox3.Text != "" && textBox4.Text != "")
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["pos"].ConnectionString))
                {
                    try
                    {
                        con.Open();
                        string login = "select count(*), EMP_NAME, EMP_ID, EMP_PW from CON_EMP group by EMP_NAME, EMP_ID, EMP_PW having EMP_ID = '" + textBox3.Text + "' and EMP_PW = " + textBox4.Text;
                        SqlDataAdapter adapter = new SqlDataAdapter(login, con);
                        ds = new DataSet();
                        adapter.Fill(ds);

                        dt = ds.Tables[0];
                        drc = dt.Rows;

                        if(drc.Count.ToString() == "1")
                        {
                            foreach (DataRow dr in drc)
                            {
                                this.Hide();
                                Form1 form1 = new Form1();
                                form1.label1.Text = dr[1].ToString();
                                form1.ShowDialog();
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("아이디 또는 비밀번호가 일치하지 않습니다");
                            textBox3.Text = "";
                            textBox4.Text = "";
                            textBox3.Focus();
                        }

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("아이디 또는 비밀번호가 일치하지 않습니다");
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox3.Focus();
                    }
                }
            } else
            {
                MessageBox.Show("아이디 또는 비밀번호를 입력해주세요.");
                textBox3.Focus();
            }
            
        }

        private void textBox4_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(null, null);
            }
>>>>>>> 5b09e592626262352de4ccd24febeebc9c38fdf9
        }
    }
}
