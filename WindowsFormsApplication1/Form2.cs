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

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        private SqlConnection conn = null;
        private SqlDataAdapter da = null;
        private DataSet ds = null;
        private int rowIndex = -1;
        public int id = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void toStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void toCourse_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            getData();
            dg2.Click += dg2_click;
        }

        private void getData()
        {
            String connStr = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\XIN\\Desktop\\Term Four\\Web Service .NET C#\\SchoolRegister\\WindowsFormsApplication1\\Database.mdf;Integrated Security=True";
            try
            {
                conn = new SqlConnection(connStr);
                conn.Open();
                string sql = "SELECT * FROM [program]";
                da = new SqlDataAdapter(sql, conn);
                //SqlCommandBuilder cb = new SqlCommandBuilder(da);

                ds = new DataSet();
                da.Fill(ds, "program"); // creates program table in the dataset 'ds'
                sql = "SELECT * FROM [student]";
                da = new SqlDataAdapter(sql, conn);
                da.Fill(ds, "student");

                if (Form1.progId != "")
                {
                    id = Convert.ToInt32(Form1.progId);
                    myProg.Text = ds.Tables[0].Rows[id - 1][1].ToString();
                }
                createCommands();
                conn.Close();



                // bind and display
                bindingSource1.DataSource = ds;
                bindingSource1.DataMember = "program"; // this must match the stringin the Fill() method
                dg2.DataSource = bindingSource1;
                dg2.ClearSelection();


            }
            catch (SqlException ex)
            {
                if (conn != null)
                {
                    conn.Close();
                }

                MessageBox.Show(ex.Message, "Error Reading Data");
            }
        }

        private void createCommands()
        {

            //create UPDATE command
            SqlCommand cmd = new SqlCommand();
            String sql;
            sql = "UPDATE [student] SET [ProgId] = @progId WHERE [StudentId] = " + Form1.studId;
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.Parameters.Add("@progId", SqlDbType.Int, 4, "ProgId");

            //add command to dataAdapter
            da.UpdateCommand = cmd;
        }

        private void dg2_click(object sender, EventArgs e)
        {
            if (dg2.Rows.Count > 0)
            {
                rowIndex = dg2.CurrentRow.Index;

                // align rowIndex with index of selection in DataSet tables
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    if (ds.Tables[0].Rows[i].RowState != DataRowState.Deleted)
                    {
                        if (dg2.CurrentRow.Cells[0].Value.ToString().Equals(ds.Tables[0].Rows[i].ItemArray[0].ToString()))
                        {
                            rowIndex = i;
                            break;
                        }
                    }
                }

                programNum.Text = dg2.CurrentRow.Cells[0].Value.ToString();
                programName.Text = dg2.CurrentRow.Cells[1].Value.ToString();


                //setControlState("u/d");
            }

        }

        private void enrollButton_Click(object sender, EventArgs e)
        {
            try
            {
                myProg.Text = programName.Text;
                DataRow dr = ds.Tables[1].Rows[1];    //?????
                dr["ProgId"] = Convert.ToInt32(programNum.Text); ;
                //dr["ProgName"] = myProg.Text;

                conn.Open();
                int updatedRows = da.Update(ds, "student");
                conn.Close();
                //lblUpdatedRows.Text = "Updated Rows = " + updatedRows;
                //formatGrid();
            }
            catch (SqlException ex)
            {
                if (conn != null)
                {
                    conn.Close();
                }
                MessageBox.Show(ex.Message, "Error Updating Database");
            }
        }
    }
}
