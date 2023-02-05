using System;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace Nullbale_types_Student_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            int chosen;
            do
            {
                Console.WriteLine("\n1. Butun telebelere bax.");
                Console.WriteLine("2. Yeni telebe elave et.");
                Console.WriteLine("3. Telebeler uzre axtaris et.");
                Console.WriteLine("4. Telebelerin adlarina bax.");
                Console.WriteLine("5. Siyahida adin olub olmadigina bax.");
                Console.WriteLine("0. Menudan cix! \n");

                Console.WriteLine("Secim Edin:");
                chosen = Convert.ToInt32(Console.ReadLine());
                chooseOfPanel(chosen);
            } while (chosen != 0);
            showStudent();
        }


        static void chooseOfPanel(int num)
        {
            switch (num)
            {
                case 1:
                    //Console.WriteLine("\nTelebelere baxilir \n");
                    showStudent();
                    break;
                case 2:
                    //Console.WriteLine("\nTelebe elave edilir \n");
                    CreateStudents();
                    break;
                case 3:
                    Console.WriteLine("\nTelebeler uzre axtaris edir \n");
                    break;
                case 4:
                    Console.WriteLine("\nTelebeler adlarina baxilir \n");
                    break;
                case 5:
                    Console.WriteLine("\nSiyahida adin olub olmadigina bax \n");
                    break;
                case 0:
                    Console.WriteLine("\nMenudan cixir \n");
                    break;
                default:
                    Console.WriteLine("\nDuzgun eded daxil edin! \n");
                    break;
            }
        }
        #region Choosen 2
        static void CreateStudents()
        {
            Console.WriteLine("\nZehmet olmasa Telebenin Fullname'sini qeyd edin:");
            string createStudent = Console.ReadLine();
            while (createStudent.Length! < 3)
            {
                Console.WriteLine("Adinizi duzgun daxil edin!");
                createStudent = Console.ReadLine();
            }

            makeFullname(createStudent);
        }
        static void makeFullname(string name)
        {
            var arr = name.Split(' ');
            string newStr = "";

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != "")
                {
                    newStr += arr[i].Substring(0, 1).ToUpper() + arr[i].Substring(1).ToLower() + " ";
                }
            }
            newStr.TrimEnd();
            AddStudent(newStr);
        }

        static void AddStudent(string studentName)
        {
            string[] studentNames = new string[studentName.Length];
            for (int i = 0; i < studentName.Length; i++)
            {
               if (studentName[i]!=' ')
                studentNames[i] = studentName;
                Console.WriteLine($"{studentNames[i]}. adli telebe yaradildi.");
                break;
            }
            studentArr(ref studentNames);
        }
        static string[] studentArr(ref string[] studentCallFromList)
        {
            string[] studentAddToList = new string[studentCallFromList.Length+1];

            string empty2 = " ";
            int count = 0;
            int empty = 0;
            for (int i = 0; i < studentCallFromList.Length; i++)
            {
                if (studentCallFromList[i] != null)
                {
                    studentAddToList[count] = studentCallFromList[i];
                    count++;
                }
                empty++;
            }
           return studentCallFromList = studentAddToList;
        }
        #endregion
        #region Choosen 1
        static void showStudent()
        {
            //string[] name = new string[] {};
            //var names = studentArr(ref name);
            //int count = 0;
            //for (int i = 0; i < names.Length; i++)
            //{
            //    if (names[i]!="")
            //    {
            //        Console.WriteLine($"{i}ci Telebe");
            //        Console.WriteLine(names[i]);
            //        count++; 
            //    }
            //}
        }
        #endregion

    }
}
