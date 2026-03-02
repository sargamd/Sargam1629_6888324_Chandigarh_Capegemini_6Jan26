using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WIndowAppExample
{
    public partial class GVOperationWithDataSet : Form
    {
        //string connectionstring = "Data Source=LAPTOP-HP1513\\SQLEXPRESS01;Initial Catalog=Employee1_SP;TrustServerCertificate=True;Integrated Security=True";
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-HP1513\\SQLEXPRESS01;Initial Catalog=Employee1_SP;TrustServerCertificate=True;Integrated Security=True");
        SqlCommandBuilder Bldr; SqlDataAdapter da; DataRow rec;
        DataSet ds;

        public GVOperationWithDataSet()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                rec = ds.Tables[0].NewRow();
                rec[0] = txtEmpId.Text;
                rec[1] = txtEmpName.Text;
                rec[2] = txtEmpDesig.Text;
                rec[3] = txtEmpDOJ.Text;
                rec[4] = txtEmpSal.Text;
                rec[5] = txtDeptNo.Text;
                ds.Tables[0].Rows.Add(rec);
                MessageBox.Show("Record is Inserted into dataset Table");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("Select *  from Employeetb", con);
            ds = new DataSet();
            da.Fill(ds, "Employeetb");
            dataGridView1.DataSource = ds.Tables[0];
            da.FillSchema(ds, SchemaType.Source, "Employeetb");
            Bldr = new SqlCommandBuilder(da);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void salary_label_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                if (x is TextBox)
                    x.Text = "";
            }

        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            try
            {
                rec = ds.Tables[0].Select("EmpId=" + txtEmpId.Text)[0];
                txtEmpName.Text = rec[1].ToString();
                txtEmpDesig.Text = rec[2].ToString();
                txtEmpDOJ.Text = rec[3].ToString();
                txtEmpSal.Text = rec[4].ToString();
                txtDeptNo.Text = rec[5].ToString();
                btnUpdate.Enabled = true;
                MessageBox.Show("record find");
            }
            catch
            {
                MessageBox.Show("record Not Found");
            }

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                rec[1] = txtEmpName.Text;
                rec[2] = txtEmpDesig.Text;
                rec[3] = txtEmpDOJ.Text;
                rec[4] = txtEmpSal.Text;
                rec[5] = txtDeptNo.Text;
                btnUpdate.Enabled = false;
                MessageBox.Show("record is updated into dataset Table");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                rec = ds.Tables[0].Select("EmpId" + txtEmpId.Text)[0];
                rec.Delete();
                MessageBox.Show("Record is deleted from dataset Table");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnUpdateDB_Click(object sender, EventArgs e)
        {
            try
            {
                if (ds.HasChanges() == true)
                {
                    da.Update(ds, "Employeetb");
                    MessageBox.Show("Dataset data is Upadated into database");
                }
                else
                {
                    MessageBox.Show("No modifiaction in Dataset");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
