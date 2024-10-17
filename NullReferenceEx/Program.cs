namespace NullReferenceEx
{
    public class Student
    {
        public string Name { get; set; }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Student student = null;

            try
            {
                Console.WriteLine(student.Name);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}



