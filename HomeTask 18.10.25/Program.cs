namespace HomeTask_18._10._25
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Secimlerden birini secin");
                Console.WriteLine("1. Create new Student");
                Console.WriteLine("2. Delete Student");
                Console.WriteLine("3. Print All Students");
                Console.WriteLine("4. Print Fav Students");
                Console.WriteLine("0. Exit");
                Console.Write("Seçiminiz: ");

                char choice = Convert.ToChar(Console.ReadLine());


                switch (choice)
                {
                    case '1':
                        Student.CreateNewStudent();
                        break;
                    case '2':
                        Student.DeleteStudent();
                        break;
                    case '3':
                        Student.PrintAllStudents();
                        break;

                    case '4':
                        Student.PrintFavStudents();
                        break;

                    case '0':
                        Console.WriteLine("Proqramdan çıxılır. Sağ olun!");
                        return;
                    default:
                        Console.WriteLine("Yanlış seçim. Yenidən cəhd edin.");
                        break;
                }

                Console.WriteLine("\nDavama basmaq üçün Enter...");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}


