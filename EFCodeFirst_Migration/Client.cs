using EFCodeFirst_Migration.Context;
using EFCodeFirst_Migration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst_Migration
{
    public class Client
    {
        /// <summary>
        /// Get all students
        /// </summary>
        public void GetAllStudent()
        {
            using (var db = new DataContext())
            {
                var studentList = db.Students.ToList();

                foreach (var student in studentList)
                {
                    Console.WriteLine("ID: {0}, FullName: {1}, EnrollmentDate: {2}",
                        student.ID, student.FullName, student.EnrollmentDate);
                }
            }
        }

        /// <summary>
        /// Add a new student
        /// </summary>
        /// <param name="fullName">fullName</param>
        public void AddStudent(string fullName)
        {
            Student student = new Student();
            student.FullName = fullName;

            using (var db = new DataContext())
            {
                db.Students.Add(student);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Update student with a new name by ID
        /// </summary>
        /// <param name="studentID">studentID</param>
        /// <param name="fullName">fullName</param>
        public void UpdateStudent(string studentID, string fullName)
        {
            int ID = Convert.ToInt32(studentID);

            using (var db = new DataContext())
            {
                var student = db.Students.Where(c => c.ID == ID).FirstOrDefault();

                if (student == null)
                {
                    Console.WriteLine("Hoc sinh voi ID nay khong ton tai\n");
                }
                else
                {
                    student.FullName = fullName;
                    db.SaveChanges();
                    Console.WriteLine("Thay doi ten thanh cong\n");
                }
            }
        }

        /// <summary>
        /// Get all courses
        /// </summary>
        public void GetAllCourse()
        {
            using (var db = new DataContext())
            {
                var courseList = db.Courses.ToList();

                foreach (var course in courseList)
                {
                    Console.WriteLine("ID: {0}, Title: {1}, Credit: {2}",
                        course.CourseID, course.Title, course.Credits);
                }
            }
        }

        /// <summary>
        /// Add a new course
        /// </summary>
        /// <param name="title">title</param>
        /// <param name="credit">credit</param>
        public void AddCourse(string title, string credit)
        {
            int creditNumber = Convert.ToInt32(credit);

            Course course = new Course();
            course.Title = title;
            course.Credits = creditNumber;

            using (var db = new DataContext())
            {
                db.Courses.Add(course);
                db.SaveChanges();
                Console.WriteLine("Them khoa hoc moi thanh cong\n");
            }
        }

        /// <summary>
        /// Get all enrollment information
        /// </summary>
        public void GetEnrollmentInfo()
        {
            using (var db = new DataContext())
            {
                var enrollments = db.Enrollments.ToList();

                foreach(var enrollment in enrollments)
                {
                    Console.WriteLine("Enrollment ID: {0}, StudentName: {1}, CourseName: {2}, CourseCredit: {3}",
                        enrollment.EnrollmentID, enrollment.Student.FullName, enrollment.Course.Title, enrollment.Course.Credits);
                }
            }
        }

        /// <summary>
        /// A student enrolls a course
        /// </summary>
        /// <param name="studentID"></param>
        /// <param name="courseID"></param>
        public void EnrollACourse(string studentID, string courseID)
        {
            int studentId = Convert.ToInt32(studentID); 
            int courseId = Convert.ToInt32(courseID);   

            Enrollment enrollment = new Enrollment();
            enrollment.StudentID = studentId;
            enrollment.CourseID = courseId;

            using (var db = new DataContext())
            {
                db.Enrollments.Add(enrollment);
                db.SaveChanges();
                Console.WriteLine("Dang ky khoa hoc thanh cong\n");
            }
        }
    }
}
