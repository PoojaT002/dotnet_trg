using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTestDec12
{
    public class ArchConnected
    {
        SqlConnection con;
        public ArchConnected()
        {
            con = new SqlConnection("uid=sa;pwd=Infinite@2025;database=EduTrackdb;server=ICS-LT-9Q8M9K3");

        }

        //task 1 Display all courses
        public void DisplayCourse()
        {
           
                con.Open();
                SqlCommand cmd = new SqlCommand("select CourseId, CourseName, Credits, Semester from Courses", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine($"{dr[0]} | {dr[1]} | {dr[2]} | {dr[3]}");
                }

         con.Close();
        }

        //task 2 Add a new student

        public void AddStudent()
        {
            con.Open();
            Console.Write("Enter fullname:");
            string fullname = Console.ReadLine();

            Console.Write("Enter email:");
            string email = Console.ReadLine();

            Console.Write("Enter year of study:");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Department name: ");
            string department = Console.ReadLine();

            SqlCommand cmd = new SqlCommand("insert into Students(FullName,Email,Department,YearOfStudy) VALUES(@n,@e,@d,@y)", con);
            cmd.Parameters.AddWithValue("@n", fullname);
            cmd.Parameters.AddWithValue("@e", email);
            cmd.Parameters.AddWithValue("@d", department);
            cmd.Parameters.AddWithValue("@y", year);
            cmd.ExecuteNonQuery();

            Console.WriteLine("Student Added");
            con.Close();
        }

        //task 3 Search students by department
        public void SearchStudentbyDept()
        {
            con.Open();

            Console.Write("Enter department: ");
            string department = Console.ReadLine();

            SqlCommand cmd = new SqlCommand("select StudentId, FullName, Email FROM Students WHERE Department = @dept", con);

            cmd.Parameters.AddWithValue("@dept", department);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine($"{dr[0]} | {dr[1]} | {dr[2]}");
            }
            con.Close();
        }

        //task 4 Display enrolled courses for a student
        public void DisplayCourseStudent()
        {
            con.Open();

            Console.Write("Enter StudentId: ");
            int studentId = Convert.ToInt32(Console.ReadLine());

            SqlCommand cmd = new SqlCommand(@"select c.CourseName, c.Credits, e.EnrollDate, e.Grade
            from Enrollments e inner join Courses c ON e.CourseId = c.CourseId
            where e.StudentId = @sid", con);
            cmd.Parameters.AddWithValue("@sid", studentId);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine($"{dr[0]} | {dr[1]} | {dr[2]} | {dr[3]}");
            }
            con.Close();
        }

        //task 5 Update grade (Connected Mode)

        public void UpdateGrades()
        {
            con.Open();

            Console.Write("Enter Grade: ");
            string grade = Console.ReadLine();
            Console.Write("Enter EnrollmenttId: ");
            int enrollmentId = Convert.ToInt32(Console.ReadLine());

            SqlCommand cmd = new SqlCommand("update Enrollments set Grade = @g where EnrollmentId = @id", con);
            cmd.Parameters.AddWithValue("@g", grade);
            cmd.Parameters.AddWithValue("@id", enrollmentId);
            cmd.ExecuteNonQuery();
            Console.WriteLine("Grade Updated");

            con.Close();
        }

    }
}


