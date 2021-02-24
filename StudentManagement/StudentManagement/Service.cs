using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    class Service
    {
        School schoolOne = new School();      
        public void GetSchool()
        {
            int result;
            Console.WriteLine("Please Enter School Id : ");
            string registerNo = Console.ReadLine();
            while (true)
            {
                if (string.IsNullOrEmpty(registerNo))
                {
                    Console.WriteLine("Please Enter School Id With Numbers and don't Keep Empty : ");
                    registerNo = Console.ReadLine();
                }
                else if (!int.TryParse(registerNo, out result))
                {
                    Console.WriteLine("Please Enter School Id With Numbres only : ");
                    registerNo = Console.ReadLine();
                }
                else if(registerNo=="0")
                {
                    Console.WriteLine("Please Enter School Id With Numbres and Don't Enter Zero : ");
                    registerNo = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }
            schoolOne.SchoolId = int.Parse(registerNo);
            Console.WriteLine("Enter School Name : ");
            schoolOne.SchoolName = Console.ReadLine();
            while (true)
            {
                if (string.IsNullOrEmpty(schoolOne.SchoolName))
                {

                    Console.WriteLine("Please Enter School Name and don't Keep Empty : ");
                    schoolOne.SchoolName = Console.ReadLine();
                }
                else if (int.TryParse(schoolOne.SchoolName, out result))
                {
                    Console.WriteLine("Please Enter School Name With String Value Only : ");
                    schoolOne.SchoolName = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }
            List<School> schools = new List<School>();
            schools.Add(schoolOne);
            Console.ReadKey();
        }
    }
}
