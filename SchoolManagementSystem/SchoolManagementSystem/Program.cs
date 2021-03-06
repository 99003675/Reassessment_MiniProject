using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem
{
    class Program
    {
        static List<Student> students = new List<Student>(5);
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Enter User Id:");
                String userid = Console.ReadLine();

                Console.WriteLine("Enter Password:");
                String password = Console.ReadLine();

                Admin admnObj = new Admin();
                Payment paymtObj = new Payment();


                if (admnObj.UserId == userid && admnObj.Password == password)

                {

                    while (true)

                    {
                        Console.WriteLine("***********WELCOME TO DELHI PUBLIC SCHOOL************");
                        Console.WriteLine("***********SELECT OPTION***********");
                        Console.WriteLine("1. ADD STUDENT DETAILS");
                        Console.WriteLine("2. REMOVE STUDENT DETAILS");
                        Console.WriteLine("3. MODIFY STUDENT DETAILS");
                        Console.WriteLine("4. DISPLAY STUDENT DETAILS");


                        Console.WriteLine("ENTER SELECTED OPTION");
                        int select = Convert.ToInt32(Console.ReadLine());


                        Student[] studentObj = new Student[5];

                        switch (select)

                        {
                            case 1:

                                Console.WriteLine("How many student you want to add?");
                                int number = Convert.ToInt32(Console.ReadLine());

                                if (number > 0 && number < 6)
                                {
                                    for (int i = 0; i < number; i++)
                                    {
                                        studentObj[i] = new Student();

                                        Console.WriteLine("ENTER FIRST NAME");
                                        studentObj[i].FirstName = Console.ReadLine();

                                        Console.WriteLine("ENTER LAST NAME");
                                        studentObj[i].LastName = Console.ReadLine();

                                        Console.WriteLine("ENTER GENDER");
                                        studentObj[i].Gender = Console.ReadLine();

                                        Console.WriteLine("ENTER DATE OF ADMISSION");
                                        studentObj[i].DateOfAdmission = DateTime.Parse(Console.ReadLine());

                                        Console.WriteLine("ENTER DATE OF BIRTH");
                                        studentObj[i].DateOfBirth = DateTime.Parse(Console.ReadLine());

                                        Console.WriteLine("ENTER ADDRESS");
                                        studentObj[i].Address = Console.ReadLine();

                                        studentObj[i].RollNumber = i + 1;
                                        
                                        
                                        Console.WriteLine("ENTER GRADE");
                                        studentObj[i].Grade = Convert.ToInt32(Console.ReadLine());

                                        studentObj[i].Fees = paymtObj.CalFees(studentObj[i].Grade);

                                        Console.WriteLine("ENTER COURSE NAME");
                                        studentObj[i].CourseName = Console.ReadLine();

                                        students.Add(studentObj[i]);

                                    }

                                    foreach (Student student in students)
                                    {
                                        Console.WriteLine("Student Roll Number : " + student.RollNumber);
                                        Console.WriteLine("Student First Name : " + student.FirstName);
                                        Console.WriteLine("Student Last  Name : " + student.LastName);
                                        Console.WriteLine("Student Gender : " + student.Gender);
                                        Console.WriteLine("Student Date of Admission : " + student.DateOfAdmission);
                                        Console.WriteLine("Student Date of Birth : " + student.DateOfBirth);
                                        Console.WriteLine("Student Address: " + student.Address);
                                        Console.WriteLine("Student Grade: " + student.Grade);
                                        Console.WriteLine("Student Fees: " + student.Fees);
                                        Console.WriteLine("Student Course Name : " + student.CourseName);
                                    }

                                }

                                else
                                    Console.WriteLine("Can not enter more than 5 students at a time");
                                break;



                            case 2:


                                Console.WriteLine("Enter RollNumber You Want to Delete");
                                int rollnumber = Convert.ToInt32(Console.ReadLine());

                                foreach (Student student in students)
                                {
                                    if (rollnumber == student.RollNumber)
                                    {
                                        students.Remove(student);
                                        break;
                                    }

                                }

                                break;


                            case 3:

                                Console.WriteLine("Enter RollNumber You Want to Modify");
                                int roll_number = Convert.ToInt32(Console.ReadLine());

                                foreach (Student student in students)
                                {
                                    if (roll_number == student.RollNumber)
                                    {
                                        Console.WriteLine("****SELECT THE OPTION YOU WANT TO MODIFY*****");
                                        Console.WriteLine("1. FIRST NAME");
                                        Console.WriteLine("2. LAST NAME");
                                        Console.WriteLine("3. GENDER");
                                        Console.WriteLine("4. DATE OF ADMISSION");
                                        Console.WriteLine("5. DATE OF BIRTH");
                                        Console.WriteLine("6. ADDRESS");
                                        Console.WriteLine("7. GRADE");
                                        Console.WriteLine("8. COURSE NAME");

                                        Console.WriteLine("Enter Selected Option");
                                        int choice = Convert.ToInt32(Console.ReadLine());

                                        if (choice == 1)
                                        {
                                            Console.WriteLine("Enter  First Name to Modify");
                                            String firstname = Console.ReadLine();
                                            student.FirstName = firstname;
                                        }

                                        if (choice == 2)
                                        {
                                            Console.WriteLine("Enter Last Name to Modify");
                                            String lastname = Console.ReadLine();
                                            student.LastName = lastname;
                                        }

                                        if (choice == 3)
                                        {
                                            Console.WriteLine("Enter Gender to Modify");
                                            String gender = Console.ReadLine();
                                            student.Gender = gender;
                                        }

                                        if (choice == 4)
                                        {
                                            Console.WriteLine("Enter Date Of Admission to Modify");
                                            DateTime date_of_admission = Convert.ToDateTime(Console.ReadLine());
                                            student.DateOfAdmission= date_of_admission;
                                        }

                                        if (choice == 5)
                                        {
                                            Console.WriteLine("Enter Date Of Birth to Modify");
                                            DateTime date_of_birth = Convert.ToDateTime(Console.ReadLine());
                                            student.DateOfBirth = date_of_birth;
                                        }

                                        if (choice == 6)
                                        {

                                            Console.WriteLine("Enter Address to Modify");
                                            String address = Console.ReadLine();
                                            student.Address = address;
                                        }


                                        if (choice == 7)
                                        {
                                            Console.WriteLine("Enter Grade to Modify");
                                            int course_id = Convert.ToInt32(Console.ReadLine());
                                            student.Grade = course_id;
                                        }
                                        if (choice == 8)
                                        {
                                            Console.WriteLine("Enter Course Name to Modify");
                                            String course_name = Console.ReadLine();
                                            student.CourseName = course_name;
                                        }


                                    }
                                    Console.WriteLine("Student Roll Number : " + student.RollNumber);
                                    Console.WriteLine("Student First Name : " + student.FirstName);
                                    Console.WriteLine("Student Last  Name : " + student.LastName);
                                    Console.WriteLine("Student Gender : " + student.Gender);
                                    Console.WriteLine("Student Date of Admission : " + student.DateOfAdmission);
                                    Console.WriteLine("Student Date of Birth : " + student.DateOfBirth);
                                    Console.WriteLine("Student Address : " + student.Address);
                                    Console.WriteLine("Student Grade " + student.Grade);
                                    Console.WriteLine("Student Fees: " + student.Fees);
                                    Console.WriteLine("Student Course Name : " + student.CourseName);

                                }
                                break;

                            case 4:

                                foreach (Student student in students)
                                {
                                    Console.WriteLine("Student Roll Number : " + student.RollNumber);
                                    Console.WriteLine("Student First Name : " + student.FirstName);
                                    Console.WriteLine("Student Last  Name : " + student.LastName);
                                    Console.WriteLine("Student Gender : " + student.Gender);
                                    Console.WriteLine("Student Date of Admission : " + student.DateOfAdmission);
                                    Console.WriteLine("Student Date of Birth : " + student.DateOfBirth);
                                    Console.WriteLine("Student Address : " + student.Address);
                                    Console.WriteLine("Student Grade: " + student.Grade);
                                    Console.WriteLine("Student Fees: " + student.Fees);
                                    Console.WriteLine("Student Course Name : " + student.CourseName);
                                }

                                break;


                            default:
                                Console.WriteLine("INVALID ENTRY");
                                break;
                        }
                    }
                }
                else
                    Console.WriteLine("INVALID USER ID OR PASSWORD");
            }


            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }

        }
    }
}
