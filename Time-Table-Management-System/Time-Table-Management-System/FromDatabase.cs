using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Table_Management_System
{
    class FromDatabase
    {
        string connect = "Server=DESKTOP-4370VSE; database=TimeTable; integrated security=true;";
        public string[] GetBatch()
        {
            string[] batch = null;
            try
            {
                SqlConnection con = new SqlConnection(connect);
                SqlDataAdapter da = new SqlDataAdapter("getbatches", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                da.Fill(ds, "tblBatch");
                DataTable dt = ds.Tables["tblBatch"];
                batch = new string[dt.Rows.Count];
                DataRow row;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    row = dt.Rows[i];
                    batch[i] = row["Bname"].ToString();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return batch;
        }

        public string[] GetCourses()
        {
            string[] course = null;
            try
            {
                SqlConnection con = new SqlConnection(connect);
                SqlDataAdapter da = new SqlDataAdapter("getCourses", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                da.Fill(ds, "tblCourse");
                DataTable dt = ds.Tables["tblcourse"];
                course = new string[dt.Rows.Count];
                DataRow row;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    row = dt.Rows[i];
                    course[i] = row["Cname"].ToString();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return course;
        }

        public string[] GetBatchCourses(string batch)
        {
            string[] course = null;
            try
            {
                SqlConnection con = new SqlConnection(connect);
                SqlDataAdapter da = new SqlDataAdapter("GetBatchCourse", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@batch", batch);
                DataSet ds = new DataSet();
                da.Fill(ds, "tblCourse");
                DataTable dt = ds.Tables["tblcourse"];
                course = new string[dt.Rows.Count];
                DataRow row;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    row = dt.Rows[i];
                    course[i] = row["Cname"].ToString();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return course;
        }

        public void DeleteCoursesTaken(string batch)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connect))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DeleteBatchCourse", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@batch", batch);
                    int rowAffected = cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void AddCourseTaken(string course, string batch)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connect))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("AddBatchCourse", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@course", course);
                    cmd.Parameters.AddWithValue("@batch", batch);
                    int rowAffected = cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void AddBatch(string name, int no)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connect))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("AddBatch", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@batchName", name);
                    cmd.Parameters.AddWithValue("@no", no);
                    int rowAffected = cmd.ExecuteNonQuery();
                    if (rowAffected > 0)
                    {
                        MessageBox.Show("Batch Added Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Failed! Please Try Again");
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string[] GetTeacher()
        {
            string[] teacher = null;
            try
            {
                SqlConnection con = new SqlConnection(connect);
                SqlDataAdapter da = new SqlDataAdapter("getTeachers", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                da.Fill(ds, "tblTeachers");
                DataTable dt = ds.Tables["tblteachers"];
                teacher = new string[dt.Rows.Count];
                DataRow row;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    row = dt.Rows[i];
                    teacher[i] = row["Tname"].ToString();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return teacher;
        }

        public string[] GetTeacherCourses(string teacher)
        {
            string[] course = null;
            try
            {
                SqlConnection con = new SqlConnection(connect);
                SqlDataAdapter da = new SqlDataAdapter("GetTeacherCourse", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@teacher", teacher);
                DataSet ds = new DataSet();
                da.Fill(ds, "tblCourse");
                DataTable dt = ds.Tables["tblcourse"];
                course = new string[dt.Rows.Count];
                DataRow row;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    row = dt.Rows[i];
                    course[i] = row["Cname"].ToString();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return course;
        }

        public void DeleteTeacherCourse(string teacher)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connect))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DeleteTeacherCourse", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@teacher", teacher);
                    int rowAffected = cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void AddTeacherCourse(string course, string teacher)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connect))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("AddTeacherCourse", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@course", course);
                    cmd.Parameters.AddWithValue("@teacher", teacher);
                    int rowAffected = cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void AddTeacher(string name, int id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connect))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("AddTeacher", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Tname", name);
                    cmd.Parameters.AddWithValue("@Tid", id);
                    int rowAffected = cmd.ExecuteNonQuery();
                    if (rowAffected > 0)
                    {
                        MessageBox.Show("Teacher Added Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Failed! Please Try Again");
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DeleteCourse(string course)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connect))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DeleteCourse", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@name", course);
                    int rowAffected = cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void AddCourse(string code, string name)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connect))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("AddCourse", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@number", code);
                    int rowAffected = cmd.ExecuteNonQuery();
                    if (rowAffected > 0)
                    {
                        MessageBox.Show("Course Added Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Failed! Please Try Again");
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
