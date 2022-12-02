namespace QueueApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new QueueControl());

            //int totalLocket = 3;
            //for (int i = 1; i <= totalLocket; i++)
            //{
            //    LocketClass locket1 = new LocketClass();
            //}

            LocketClass locket1 = new LocketClass("Locket 1", 1);
            LocketClass locket2 = new LocketClass("Locket 2", 2);
            LocketClass locket3 = new LocketClass("Locket 3", 3);
        }
    }
}