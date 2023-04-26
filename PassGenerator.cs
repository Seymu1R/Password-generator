namespace Ipassgenerator
{
    public class PassGenerator
    {
        private string digits = "0123456789";
        private string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        private string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

        private string GeneratePassword(string characterSet, int length)
        {
            Random random = new Random();
            string password = new string(Enumerable.Repeat(characterSet, length).Select(s => s[random.Next(s.Length)]).ToArray());
            return password;
        }

        public string GenerateNumericPassword(int length)
        {
            string characterSet = digits;
            return GeneratePassword(characterSet, length);
        }

        public string GenerateLetterPassword(int length)
        {
            string characterSet = letters;
            return GeneratePassword(characterSet, length);
        }

        public string GenerateMixedPassword(int length)
        {
            string characterSet = characters;
            return GeneratePassword(characterSet, length);
        }

        public string Digits
        {
            get { return digits; }
            set { digits = value; }
        }

        public string Letters
        {
            get { return letters; }
            set { letters = value; }
        }

        public string Characters
        {
            get { return characters; }
            set
            {
                characters = value;
                digits = new string(characters.Where(char.IsDigit).Distinct().ToArray());
                letters = new string(characters.Where(char.IsLetter).Distinct().ToArray());
            }
        }
    }
}
