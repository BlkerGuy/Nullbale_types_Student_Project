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
            //       TAM HAZIR
            string[] students = new string[0];
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
                //chooseOfPanel(chosen);

                switch (chosen)
                {
                    case 1:
                        for (int i = 0; i < students.Length; i++)
                        {
                            if (students[i] != null)
                            {
                                //Console.WriteLine("\nTelebeler:");
                                Console.WriteLine(students[i]);
                            }
                        }
                        break;
                    case 2:
                        //Console.WriteLine("\nTelebe elave edilir \n");
                        Console.WriteLine("\nZehmet olmasa Telebenin Fullname'sini qeyd edin:");
                        string createStudent = Console.ReadLine();
                        while (createStudent.Length! < 3)
                        {
                            Console.WriteLine("Adinizi duzgun daxil edin!");
                            createStudent = Console.ReadLine();
                        }
                        makeFullname(ref createStudent);
                        Array.Resize(ref students, students.Length + 1);
                        students[students.Length - 1] = createStudent;
                        Console.WriteLine("Telebe yaradildi ve sisteme elave olundu.");
                        break;
                    case 3:
                        Console.WriteLine("Axtardiginiz Telebenin Fullname:");
                        string searchStudents = Console.ReadLine();

                        for (int i = 0; i < students.Length; i++)
                        {
                            if (students[i].Contains(searchStudents,StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine(students[i]);
                            }
                        }
                        break;
                    case 4:
                        for (int i = 0; i < students.Length; i++)
                        {
                            Console.WriteLine(students[i].Substring(0, students[i].IndexOf(' ')));
                        }
                        break;
                    case 5:
                        Console.WriteLine("\nTelebenin Soyad sonlugunu daxil edin:");
                        string surnameEnding = Console.ReadLine();
                        for (int i = 0; i < students.Length; i++)
                        {
                            if (students[i].EndsWith(surnameEnding))
                                Console.WriteLine(students[i]);
                        }
                        break;
                    case 0:
                        Console.WriteLine("\nMenudan cixir \n");
                        break;
                    default:
                        Console.WriteLine("\nDuzgun eded daxil edin! \n");
                        break;
                }
            } while (chosen != 0);
        }
        static void makeFullname(ref string name)
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

            name = newStr.TrimEnd();

        }

    }
}
