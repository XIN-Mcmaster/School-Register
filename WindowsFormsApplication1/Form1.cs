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
    public partial class Form1 : Form
    {
        private SqlConnection conn = null;
        private SqlDataAdapter da = null;
        private DataSet ds = null;
        private int rowIndex = -1;
        public static string progId;
        public static string studId;
        private static bool clicked = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getData();
            dg1.Click += dg1_click;
            //setControlState("default");
        }



        private void getData()
        {
            String connStr = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\XIN\\Desktop\\Term Four\\Web Service .NET C#\\SchoolRegister\\WindowsFormsApplication1\\Database.mdf;Integrated Security=True";
            try
            {
                conn = new SqlConnection(connStr);
                conn.Open();
                string sql = "SELECT * FROM [student]";
                da = new SqlDataAdapter(sql, conn);
                createCommands();
                ds = new DataSet();
                da.Fill(ds, "student"); // creates tClients table in the dataset 'ds'
                conn.Close();

                // bind and display
                bindingSource1.DataSource = ds;
                bindingSource1.DataMember = "student"; // this must match the stringin the Fill() method
                dg1.DataSource = bindingSource1;
                dg1.ClearSelection();


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
        
        
        private void dg1_click(object sender, EventArgs e)
        {
            if (dg1.Rows.Count > 0)
            {
                rowIndex = dg1.CurrentRow.Index;

                // align rowIndex with index of selection in DataSet tables
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    if (ds.Tables[0].Rows[i].RowState != DataRowState.Deleted)
                    {
                        if (dg1.CurrentRow.Cells[0].Value.ToString().Equals(ds.Tables[0].Rows[i].ItemArray[0].ToString()))
                        {
                            rowIndex = i;
                            break;
                        }
                    }
                }

                studentId.Text = dg1.CurrentRow.Cells[0].Value.ToString();
                studentFirstName.Text = dg1.CurrentRow.Cells[1].Value.ToString();
                studentLastName.Text = dg1.CurrentRow.Cells[2].Value.ToString();
                progId = dg1.CurrentRow.Cells[3].Value.ToString();
                studId = dg1.CurrentRow.Cells[0].Value.ToString();
                //setControlState("selected");

                clicked = true;
                setControlState("u/d");
            }
            
        }



        private void toProgram_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void toCourse_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void insertStudent_Click(object sender, EventArgs e)
        {
            if (dataGood())
            {
                if (isValidPrimaryKey("i"))
                {
                    // create NEW ROW for DataSet table
                    // ROW MUST be created with SCHEMA! ***
                    DataRow dr = ds.Tables["student"].NewRow();
                    dr["StudentId"] = Convert.ToInt32(studentId.Text);
                    dr["FirstName"] = studentFirstName.Text;
                    dr["LastName"] = studentLastName.Text;

                    // add new row to rows collection of table
                    ds.Tables[0].Rows.Add(dr); // Tables[0] refers to Tables["tClients"] -- permissible b/c only one table
                    clearText();
                    setControlState("db");
                   
                }
            }
            else
            {
                MessageBox.Show("Can not insert without data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }
        
        private void updateStudent_Click(object sender, EventArgs e)
        {
            if (dataGood())
            {
                if (isValidPrimaryKey("u"))
                {
                    DataRow dr = ds.Tables[0].Rows[rowIndex];
                    dr["StudentId"] = Convert.ToInt32(studentId.Text);
                    dr["FirstName"] = studentFirstName.Text;
                    dr["LastName"] = studentLastName.Text;

                    setControlState("db");
                    clearText();
                }
            }
           
        }
        private void deleteStudent_Click(object sender, EventArgs e)
        {
            if (dg1.CurrentRow.Cells[3].Value.ToString()== "")
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Confirm Record Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    ds.Tables[0].Rows[rowIndex].Delete();

                }
            }else{
                MessageBox.Show("The Student have a program,you cannot delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            
            setControlState("db");
            
        }
        
        private void updateDB_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                int updatedRows = da.Update(ds, "student");
                MessageBox.Show("Updating Database successfully");
                conn.Close();
               
            }
            catch (SqlException ex)
            {
                if (conn != null)
                {
                    conn.Close();
                }
                MessageBox.Show(ex.Message, "Error Updating Database");
            }
            setControlState("i");
         
        }


        private void createCommands()
        {
            //create INSERT command for DataAdapter
            SqlCommand cmd = new SqlCommand();
            string sql = "INSERT INTO [student] ([StudentId],[FirstName],[LastName] ) VALUES (@studentId, @firstName, @lastName)";
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.Parameters.Add("@studentId", SqlDbType.Int, 4, "StudentId"); //@acct must match in sql
            cmd.Parameters.Add("@firstName", SqlDbType.VarChar, 15, "FirstName");
            cmd.Parameters.Add("@lastName", SqlDbType.VarChar, 15, "LastName");
            //add command to DataAdapter
            da.InsertCommand = cmd;

            //create UPDATE command
            cmd = new SqlCommand();
            sql = "UPDATE [student] SET [StudentId] = @studentId, [FirstName]= @firstName, [LastName]= @lastName WHERE [StudentId] = @origStudentId";
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.Parameters.Add("@studentId", SqlDbType.Int, 4, "StudentId"); //@acct must match in sql
            cmd.Parameters.Add("@firstName", SqlDbType.VarChar, 15, "FirstName");
            cmd.Parameters.Add("@lastName", SqlDbType.VarChar, 15, "LastName");
            SqlParameter param = cmd.Parameters.Add("@origStudentId", SqlDbType.Int, 4, "StudentId");
            param.SourceVersion = DataRowVersion.Original;
            //add command to dataAdapter
            da.UpdateCommand = cmd;

            //create delete command
            cmd = new SqlCommand();
            sql = "DELETE FROM [student] WHERE [StudentId] = @origStudentId";
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.Parameters.Add("@origStudentId", SqlDbType.Int, 4, "StudentId").SourceVersion = DataRowVersion.Original;
            //add command
            da.DeleteCommand = cmd;
        }
        
        
        private bool dataGood()
        {
            if (studentId.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }

        private bool isValidPrimaryKey(string state)
        {
            return true;
        }

        
        private void clearText()
        {
            studentId.Text = "";
            studentFirstName.Text = "";
            studentLastName.Text = "";

            dg1.ClearSelection();
        }


        private void setControlState(string state)
        {
            if (state.Equals("i"))
            {
                insertStudent.Enabled = true;
                updateStudent.Enabled = false;
                deleteStudent.Enabled = false;
                updateDB.Enabled = false;
                toCourse.Enabled = false;
                toProgram.Enabled = false;
                
            }
            else if (state.Equals("u/d"))
            {
                insertStudent.Enabled = false;
                updateStudent.Enabled = true;
                deleteStudent.Enabled = true;
                toCourse.Enabled = true;
                toProgram.Enabled = true;
            }
            else if (state.Equals("db"))
            {
                insertStudent.Enabled = false;
                updateStudent.Enabled = false;
                deleteStudent.Enabled = false;
                updateDB.Enabled = true;
                toCourse.Enabled = false;
                toProgram.Enabled = false;
            }
 

        }

        private void studentInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome To Our School Registion System.");
        }

        private void studentId_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (c != 8)
            {
                if (c < 48 || c > 57)
                {
                    e.Handled = true;
                    MessageBox.Show("Can only be number！", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void studentFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (c != 8)
            {
                if ((c < 65 || c > 90) && (c < 97 || c > 122))
                {
                    e.Handled = true;
                    MessageBox.Show("Can not contain number！", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
               
            }
        }

        private void studentLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (c != 8)
            {
                if ((c < 65 || c > 90) && (c < 97 || c > 122) )
                {
                   
                    e.Handled = true;
                    MessageBox.Show("Can not contain number！", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
                
            }
        }

      


    }
}
