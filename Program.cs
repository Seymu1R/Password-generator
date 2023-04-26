namespace Ipassgenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zəhmət olmasa şifrənin uzunluğunu girin: ");
            int length = int.Parse(Console.ReadLine());

            Console.WriteLine("1) Password yalnız reqemlərdən ibarət olsun. ");
            Console.WriteLine("2) Password yalnız herflerdən ibarət olsun. ");
            Console.WriteLine("3) Password hem herflerden hem reqemlerdən ibarət olsun. ");
            Console.Write("Zəhmət olmasa seçiminizi edin (1-3): ");
            int choice = int.Parse(Console.ReadLine());

            PassGenerator passGenerator = new PassGenerator();

            string password = "";
            switch (choice)
            {
                case 1:
                    password = passGenerator.GenerateNumericPassword(length);
                    break;
                case 2:
                    password = passGenerator.GenerateLetterPassword(length);
                    break;
                case 3:
                    password = passGenerator.GenerateMixedPassword(length);
                    break;
                default:
                    Console.WriteLine("Nəsə düz getmədi.");
                    break;
            }

            Console.WriteLine("Passüord: " + password);

        }
    }
}