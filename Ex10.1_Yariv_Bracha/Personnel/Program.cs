namespace Personnel
{
    class Program
    {
        public static void Main(string[] args)
        {
            FileReaderHelper helper = new FileReaderHelper(args[0]);
            helper.ReadFileLines();
        }
            
    }
}
