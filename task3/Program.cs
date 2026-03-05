namespace task3
{
    internal class Program
    {
        public static double calcGPA(int[] g)
        {
            double gpa = 0;
            foreach (int grade in g)
            {
                if (grade >= 90)
                    gpa += 4.0;
                else if (grade >= 85)
                    gpa += 3.7;
                else if (grade >= 80)
                    gpa += 3.3;
                else if (grade >= 75)
                    gpa += 3.0;
                else if (grade >= 70)
                    gpa += 2.7;
                else if (grade >= 65)
                    gpa += 2.4;
                else if (grade >= 60)
                    gpa += 2.1;
                else if (grade >= 50)
                    gpa += 2.0;
                else
                    gpa += 0;
            }
            gpa /= g.Length;
            return gpa;
        }
        public static string rating(double gpa)
        {
            if (gpa >= 3.5)
                return "A";
            else if (gpa >= 3.0)
                return "B+";
            else if (gpa >= 2.5)
                return "B";
            else if (gpa >= 2.0)
                return "C";
            else if (gpa >= 1.0)
                return "D";
            else
                return "F";
        }
        static void Main(string[] args)
        {
            Console.Write("Please enter subjects number: ");
            int subjects_num = int.Parse(Console.ReadLine());

            int[] grades = new int[subjects_num];
            for (int i = 0; i < subjects_num; i++){
                Console.Write($"subject ({i+1}) grade: ");
                grades[i] = int.Parse(Console.ReadLine());
            }

            double GPA = calcGPA(grades);
            string Rating = rating(GPA);

            Console.WriteLine($"GPA = {GPA} \nRating = {Rating}");
        }
    }
}
