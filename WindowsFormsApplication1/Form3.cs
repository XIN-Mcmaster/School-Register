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
    public partial class Form3 : Form
    {
        private SqlConnection conn = null;
        private SqlDataAdapter da = null;
        private DataSet ds = null;
        private int rowIndex = -1;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            getData();
            dg3.Click += dg3_click;
        }

        private void getData()
        {
            String connStr = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\XIN\\Desktop\\Term Four\\Web Service .NET C#\\SchoolRegister\\WindowsFormsApplication1\\Database.mdf;Integrated Security=True";
            // i will modify the address later
            try
            {
                conn = new SqlConnection(connStr);
                conn.Open();
                string sql = "SELECT * FROM [course]";
                da = new SqlDataAdapter(sql, conn);
                ds = new DataSet();
                da.Fill(ds, "course"); // creates tClients table in the dataset 'ds'

                sql = "SELECT [course].CourseId,[course].CourseName FROM [course] INNER JOIN [stuCourse] ON [course].CourseId = [stuCourse].CourseId AND StudentId = " + Form1.studId;
                da = new SqlDataAdapter(sql, conn);
                da.Fill(ds, "myCourse");

                sql = "SELECT  * FROM [stuCourse]";
                da = new SqlDataAdapter(sql, conn);
                da.Fill(ds, "stuCourse");

                createCommands();
                conn.Close();


                // bind and display
                bindingSource1.DataSource = ds;
                bindingSource1.DataMember = "course"; // this must match the stringin the Fill() method
                dg3.DataSource = bindingSource1;
                dg3.ClearSelection();

                bindingSource2.DataSource = ds;
                bindingSource2.DataMember = "myCourse"; // this must match the stringin the Fill() method
                dg4.DataSource = bindingSource2;
                dg4.ClearSelection();

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
            //create INSERT command for DataAdapter
            SqlCommand cmd = new SqlCommand();
            string sql = "INSERT INTO [stuCourse] ([StudentId],[CourseId] ) VALUES (" + Form1.studId + ", @courseId)";
            cmd.Connection = conn;
            cmd.CommandText = sql;
            //cmd.Parameters.Add("@studentId", SqlDbType.Int, 4, "StudentId"); //@acct must match in sql
            cmd.Parameters.Add("@courseId", SqlDbType.Int, 10, "CourseId");

            //add command to DataAdapter
            da.InsertCommand = cmd;


            //create delete command
            cmd = new SqlCommand();
            sql = "DELETE FROM [stuCourse] WHERE [CourseId] = @courseId AND StudentId = " + Form1.studId;
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.Parameters.Add("@courseId", SqlDbType.Int, 4, "CourseId").SourceVersion = DataRowVersion.Original;
            //add command
            da.DeleteCommand = cmd;
        }

        private void dg3_click(object sender, EventArgs e)
        {
            if (dg3.Rows.Count > 0)
            {
                rowIndex = dg3.CurrentRow.Index;

                // align rowIndex with index of selection in DataSet tables
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    if (ds.Tables[0].Rows[i].RowState != DataRowState.Deleted)
                    {
                        if (dg3.CurrentRow.Cells[0].Value.ToString().Equals(ds.Tables[0].Rows[i].ItemArray[0].ToString()))
                        {
                            rowIndex = i;
                            break;
                        }
                    }
                }

                courseNum.Text = dg3.CurrentRow.Cells[0].Value.ToString();
                courseName.Text = dg3.CurrentRow.Cells[1].Value.ToString();
                credit.Text = dg3.CurrentRow.Cells[2].Value.ToString();

                //setControlState("u/d");
            }

        }

        private void toStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void toProgram_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void addCourse_Click(object sender, EventArgs e)
        {
            try
            {

                if (dataGood())
                {
                    if (isValidPrimaryKey("i"))
                    {
                        // create NEW ROW for DataSet table
                        // ROW MUST be created with SCHEMA! ***
                        DataRow dr = ds.Tables["myCourse"].NewRow();
                        dr["CourseId"] = Convert.ToInt32(courseNum.Text);
                        dr["CourseName"] = courseName.Text;
                        //dr["Credit"] = Convert.ToInt32(courseName.Text);


                        // add new row to rows collection of table
                        ds.Tables[1].Rows.Add(dr); // Tables[0] refers to Tables["tClients"] -- permissible b/c only one table


                        dr = ds.Tables[2].NewRow();
                        dr["studentId"] = Form1.studId;
                        dr["CourseId"] = Convert.ToInt32(courseNum.Text);
                        ds.Tables[2].Rows.Add(dr);
                        clearText();
                        //formatGrid();
                    }
                }

                conn.Open();
                int updatedRows = da.Update(ds, "stuCourse");
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

        private bool dataGood()
        {
            return true;
        }

        private bool isValidPrimaryKey(string state)
        {
            return true;
        }
        private void clearText()
        {
            courseNum.Text = "";
            courseName.Text = "";

            dg3.ClearSelection();
        }

        private void deleteCourse_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record?", "Confirm Record Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                // delete row
                ds.Tables[1].Rows[rowIndex].Delete();
                ds.Tables[2].Rows[1].Delete();
                //formatGrid();
            }
            try
            {
                conn.Open();
                int updatedRows = da.Update(ds, "stuCourse");
                conn.Close();
                MessageBox.Show("Delete successfully!!");
                //lblUpdatedRows.Text = "Updated Rows = " + updatedRows;
                //formatGrid();
            }
            catch (SqlException ex)
            {
                if (conn != null)
                {
                    conn.Close();
                }
                MessageBox.Show(ex.Message, "Error Deleting Database");
            }
        }

        private void dg4_click(object sender, EventArgs e)
        {
            if (dg4.Rows.Count > 0)
            {
                rowIndex = dg4.CurrentRow.Index;

                // align rowIndex with index of selection in DataSet tables
                for (int i = 0; i < ds.Tables[1].Rows.Count; i++)
                {
                    if (ds.Tables[1].Rows[i].RowState != DataRowState.Deleted)
                    {
                        if (dg4.CurrentRow.Cells[0].Value.ToString().Equals(ds.Tables[1].Rows[i].ItemArray[0].ToString()))
                        {
                            rowIndex = i;
                            break;
                        }
                    }
                }

                courseNum.Text = dg4.CurrentRow.Cells[0].Value.ToString();
                courseName.Text = dg4.CurrentRow.Cells[1].Value.ToString();
                //credit.Text = dg3.CurrentRow.Cells[2].Value.ToString();

                //setControlState("u/d");
            }
        }
    }
}
