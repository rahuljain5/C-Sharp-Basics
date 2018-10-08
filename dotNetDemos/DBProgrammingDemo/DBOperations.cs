using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DBProgrammingDemo
{
    class DBOperations
    {
        public static int InsertRow(SqlConnection conn, Student student)
        {
            conn.Open();
            string insertSql = "insert into students values (@name, @dob, @std, @section, @gender)";
            SqlCommand cmd = new SqlCommand(insertSql, conn);
            cmd.Parameters.AddWithValue("@name", student.Name);
            cmd.Parameters.AddWithValue("@dob", student.DoB);
            cmd.Parameters.AddWithValue("@std", student.Standard);
            cmd.Parameters.AddWithValue("@section", student.Section);
            cmd.Parameters.AddWithValue("@gender", student.Gender);
            int count = cmd.ExecuteNonQuery();
            conn.Close();
            return count;
        }
        public static List<Student> GetRowById(SqlConnection conn, int rollNo)
        {
            List<Student> students = new List<Student>();
            Student student;
            conn.Open();
            string sql = String.Format("select * from students where RollNo = @rollno");
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@rollno", rollNo);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                student = new Student { RollNo = (int)reader["RollNo"], Name = reader["name"].ToString().TrimEnd(), DoB = (DateTime)reader["DoB"], Standard = (int)reader["Standard"], Gender = reader["Gender"].ToString(), Section = reader["Section"].ToString() };
                students.Add(student);
            }
            reader.Close();
            conn.Close();
            return students;
        }
        public static List<Student> GetAllStudents(SqlConnection conn)
        {
            List<Student> students = new List<Student>();
            conn.Open();
            string sql = String.Format("select * from students");
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Student student = new Student { RollNo = (int)reader["RollNo"], Name = reader["name"].ToString().TrimEnd(), DoB = (DateTime)reader["DoB"], Standard = (int)reader["Standard"], Gender = reader["Gender"].ToString(), Section = reader["Section"].ToString() };
                students.Add(student);
            }
            reader.Close();
            conn.Close();
            return students;
        }
        static public int DeleteRowById(SqlConnection conn, int rollNo)
        {
            conn.Open();
            string sql = String.Format("delete from students where RollNo = @rollno");
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@rollno", rollNo);
            int count = cmd.ExecuteNonQuery();
            conn.Close();
            return count;
        }
    }

}
