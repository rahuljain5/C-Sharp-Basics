using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace DBProgrammingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;
            //Step 1: Create DataBase and Table
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=.;Initial Catalog=Student;Integrated Security=True";
            int sqlResult;
            do
            {
                Console.WriteLine("1. Create New Student.\n2. Delete by Roll Number\n3. Change Section\n4. View Student Details by roll Number\n5. View All students\n6. Exit");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1: Student student1 = NewEntry();
                            sqlResult = DBOperations.InsertRow(conn, student1);
                            Console.WriteLine(sqlResult + " Record(s) Affected"); break;
                    case 2:
                        int rowId = GetRowId();
                        sqlResult = DBOperations.DeleteRowById(conn, rowId);
                        Console.WriteLine(sqlResult + " Record(s) Affected"); break;
                    case 3:
                        sqlResult = Update(conn);
                        Console.WriteLine(sqlResult + " Record(s) Affected"); break;
                    case 4:
                        int row = GetRowId();
                        List<Student> student = DBOperations.GetRowById(conn, row);
                        Print(student);
                        break;
                    case 5:
                        List<Student> students = DBOperations.GetAllStudents(conn);
                        Print(students);
                        break;
                    case 6: Environment.Exit(0); break;
                    default: Console.WriteLine("Invalid option"); break;
                }
            }
            while (true);
        }
        static public Student NewEntry()
        {
            Student student = new Student();
            Console.WriteLine("Enter Name: ");
            student.Name = Console.ReadLine();
            Console.WriteLine("Enter DOB: ");
            student.DoB = DateTime.Parse( Console.ReadLine());
            Console.WriteLine("Enter class: ");
            student.Standard = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Section: ");
            student.Section = Console.ReadLine();
            Console.WriteLine("Enter Gender: ");
            student.Gender = Console.ReadLine();
            return student;   
        }
       
        static public int Update(SqlConnection conn)
        {
            conn.Open();
            Console.WriteLine("Enter Roll Number: ");
            int rollno = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter new Section: ");
            char section = char.Parse(Console.ReadLine());

            string sql = String.Format("update students set Section = @section where RollNo = @rollno");
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@section", section);
            int count = cmd.ExecuteNonQuery();
            conn.Close();
            return count;
        }
        static int GetRowId()
        {
            Console.WriteLine("Enter Roll Number: ");
            int rollno = int.Parse(Console.ReadLine());
            return rollno;
        }
        static void Print(List<Student> students)
        {
            Console.WriteLine("name\tDoB\t\tStandard\tSection\tGender");
            foreach (var student in students)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", student.Name, student.DoB, student.Standard, student.Section, student.Gender);
            }
        }
    }
}
