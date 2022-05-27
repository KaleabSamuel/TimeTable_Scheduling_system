using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_Table_Management_System
{
    class DAL
    {
        string constr = "server=DESKTOP-4370VSE; database=timetable; Integrated Security=true;";
        public DataTable getBatches()
        {
            DataTable ds = new DataTable();
            SqlConnection con = new SqlConnection(constr);

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("getbatches", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
            }
            catch (SqlException e)
            {
                Console.Write(e.Message);
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            finally
            {
                con.Close();
            }
            return ds;

        }

        public DataTable getRooms()
        {
            DataTable ds = new DataTable();
            SqlConnection con = new SqlConnection(constr);

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("getRooms", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
            }
            catch (SqlException e)
            {
                Console.Write(e.Message);
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            finally
            {
                con.Close();
            }
            return ds;

        }

        public DataTable getBatchCourses()
        {
            DataTable ds = new DataTable();
            SqlConnection con = new SqlConnection(constr);

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("CourseBatchTeacher", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
            }
            catch (SqlException e)
            {
                Console.Write(e.Message);
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            finally
            {
                con.Close();
            }
            return ds;

        }

        public DataTable getCourseTeacher()
        {
            DataTable ds = new DataTable();
            SqlConnection con = new SqlConnection(constr);

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("CourseTeacher", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
            }
            catch (SqlException e)
            {
                Console.Write(e.Message);
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            finally
            {
                con.Close();
            }
            return ds;

        }

        public DataTable getUnavailable()
        {
            DataTable ds = new DataTable();
            SqlConnection con = new SqlConnection(constr);

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("getunavailable", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
            }
            catch (SqlException e)
            {
                Console.Write(e.Message);
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            finally
            {
                con.Close();
            }
            return ds;

        }

        public DataTable getDayTime()
        {
            DataTable ds = new DataTable();
            SqlConnection con = new SqlConnection(constr);

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("getDateTime", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
            }
            catch (SqlException e)
            {
                Console.Write(e.Message);
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            finally
            {
                con.Close();
            }
            return ds;

        }
    }
}
