using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pos
{
    public partial class frmemp : Form
    {
        DataTable dt;
        DataRowCollection drc;
        DataSet ds;
        public frmemp()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new frmempadd().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(button4.Text == "수정완료")
            {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                textBox5.Enabled = false;
                textBox6.Enabled = false;
                textBox7.Enabled = false;
                button4.Text = "정보수정";
            } else
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                textBox5.Enabled = true;
                textBox6.Enabled = true;
                textBox7.Enabled = true;
                textBox1.Focus();
                button4.Text = "수정완료";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmemp_Load(object sender, EventArgs e)
        {
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["pos"].ConnectionString))
            {
                string xmlstr = "";
                con.Open();
                string empselect = "select * from dbo.CON_EMP";
                SqlDataAdapter adapter = new SqlDataAdapter(empselect, con);
                ds = new DataSet();
                adapter.Fill(ds);

                // 그리드뷰에 출력
                dataGridView1.DataSource = ds.Tables[0];

                // 네비게이터에 출력
                dt = ds.Tables[0];
                drc = dt.Rows;
                
                xmlstr += @"<Employees>";
                foreach (DataRow item in drc)
                {
                    xmlstr += @"<Employee>" +
                        @"<EmpID>" + item[0] + "</EmpID>" +
                        @"<EmpName>" + item[1] + "</EmpName>" +
                        @"<EmpAge>" + item[4] + "</EmpAge>" +
                        @"<EmpRegnum>" + item[7] + "</EmpRegnum>" +
                        @"<EmpTel>" + item[2] + "</EmpTel>" +
                        @"<EmpAddr>" + item[3] + "</EmpAddr>" +
                        @"<EmpPosnum>" + item[6] + "</EmpPosnum>" +
                    @"</Employee>";
                }
                xmlstr += @"</Employees>";

                byte[] xmlByes = Encoding.UTF8.GetBytes(xmlstr);
                MemoryStream stream = new MemoryStream(xmlByes, false);

                ds = new DataSet();
                ds.ReadXml(stream);

                bindingSource1.DataSource = ds;
                bindingSource1.DataMember = "Employee";

                textBox1.DataBindings.Add("Text", bindingSource1, "EmpID");
                textBox2.DataBindings.Add("Text", bindingSource1, "EmpName");
                textBox3.DataBindings.Add("Text", bindingSource1, "EmpAge");
                textBox4.DataBindings.Add("Text", bindingSource1, "EmpRegnum");
                textBox5.DataBindings.Add("Text", bindingSource1, "EmpTel");
                textBox6.DataBindings.Add("Text", bindingSource1, "EmpAddr");
                textBox7.DataBindings.Add("Text", bindingSource1, "EmpPosnum");

                bindingNavigator1.BindingSource = bindingSource1;
            }
        }
    }
}
