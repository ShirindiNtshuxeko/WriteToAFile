namespace WriteToAFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string DocumentPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filepath = Path.Combine(DocumentPath, "New.txt");

            Console.WriteLine("Please enter your name: ");
            string TextToWrite = Console.ReadLine();

            using (StreamWriter writer = new StreamWriter(filepath, true)) 
            {
                writer.WriteLine(TextToWrite);
            }

            Console.WriteLine("Successfully");
        }
    }
}
