using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace StudentManagement
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string connectionstring = "Server =.;Database = TestDatabase;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;";

            if (!string.IsNullOrEmpty(txtId.Text) && !string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtSurname.Text))
            {
                using (SqlConnection con = new(connectionstring))
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    SqlParameter param = new SqlParameter();
                    SqlParameter param2 = new SqlParameter();
                    SqlParameter param3 = new SqlParameter();
                    param.ParameterName = "@Name";
                    param.Value = txtName.Text;

                    param2.ParameterName = "@id";
                    param2.Value = Convert.ToInt32(txtId.Text);

                    param3.ParameterName = "@Surname";
                    param3.Value = txtSurname.Text;

                    param.SqlDbType = System.Data.SqlDbType.VarChar;
                    param2.SqlDbType = System.Data.SqlDbType.Int;
                    param3.SqlDbType = System.Data.SqlDbType.VarChar;

                    cmd.Parameters.Add(param);
                    cmd.Parameters.Add(param2);
                    cmd.Parameters.Add(param3);

                    //Sorgu
                    cmd.CommandText = "update Users set Name=@Name,Surname=@Surname where ID=@id";
                    cmd.ExecuteNonQuery();
                }
            }
            BringAllData();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string connectionstring = "Server =.;Database = TestDatabase;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;";
            if (!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtSurname.Text))
            {
                using (SqlConnection con = new(connectionstring))
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    SqlParameter param = new SqlParameter();
                    SqlParameter param2 = new SqlParameter();
                    SqlParameter param3 = new SqlParameter();
                    param.ParameterName = "@Name";
                    param.Value = txtName.Text;


                    param2.ParameterName = "@Surname";
                    param2.Value = txtSurname.Text;

                    param.SqlDbType = System.Data.SqlDbType.VarChar;
                    param2.SqlDbType = System.Data.SqlDbType.VarChar;


                    cmd.Parameters.Add(param);
                    cmd.Parameters.Add(param2);


                    //Sorgu
                    cmd.CommandText = "insert into Users(name,Surname) values(@Name,@Surname)";
                    cmd.ExecuteNonQuery();
                }
            }
            BringAllData();

        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            string connectionstring = "Server =.;Database = TestDatabase;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;";

            using (SqlConnection con = new(connectionstring))
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();

                if (string.IsNullOrEmpty(txtId.Text) && string.IsNullOrEmpty(txtName.Text) && string.IsNullOrEmpty(txtSurname.Text))
                {
                    cmd.CommandText = "select * from Users";

                }
                else
                {
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@Name";
                    param.Value = txtName.Text;
                    param.SqlDbType = System.Data.SqlDbType.NVarChar;
                    cmd.Parameters.Add(param);

                    cmd.CommandText = "select * from Users where Name=@Name";
                }


                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                adapter.Fill(dt);

                dataGridView1.DataSource = dt;




            }



        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string connectionstring = "Server =.;Database = TestDatabase;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;";

            if (!string.IsNullOrEmpty(txtId.Text) && !string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtSurname.Text))
            {
                using (SqlConnection con = new(connectionstring))
                {

                    con.Open();
                    SqlCommand cmd = con.CreateCommand();


                    if (string.IsNullOrEmpty(txtId.Text) && string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtSurname.Text))
                    {
                        SqlParameter param2 = new SqlParameter();
                        param2.ParameterName = "@Sname";
                        param2.Value = txtSurname.Text;
                        param2.SqlDbType = System.Data.SqlDbType.VarChar;
                        cmd.Parameters.Add(param2);
                        cmd.CommandText = "Delete from Users where Surname=@Sname";

                    }
                    else if (string.IsNullOrEmpty(txtId.Text) && !string.IsNullOrEmpty(txtName.Text) && string.IsNullOrEmpty(txtSurname.Text))
                    {


                        SqlParameter param = new SqlParameter();
                        param.ParameterName = "@Name";
                        param.Value = txtName.Text;
                        param.SqlDbType = SqlDbType.VarChar;
                        cmd.Parameters.Add(param);
                        cmd.CommandText = "Delete from Users where Name=@Name";

                    }
                    else
                    {
                        SqlParameter param1 = new SqlParameter();
                        param1.ParameterName = "@id";
                        param1.Value = txtId.Text;
                        param1.SqlDbType = SqlDbType.Int;
                        cmd.Parameters.Add(param1);
                        cmd.CommandText = "Delete from Users where ID=@id";
                    }
                    cmd.ExecuteNonQuery();
                }
            }
            BringAllData();


        }

        private void BringAllData()
        {
            string connectionstring = "Server =.;Database = TestDatabase;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;";
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();


                cmd.CommandText = "select * from Users";

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }
    }
}
