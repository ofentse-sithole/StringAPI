namespace StringAPI.Model
{
    public class ClientService
    {
        //ReverseString Method
        public string ReverseString(string input)
        {
            string reversed = string.Empty;
            for (int count = input.Length - 1; count >= 0; count--)
            {
                reversed += input[count];
            }
            return reversed;

        }

        //IsPalindrome Method
        public bool IsPalindrome(string input)
        {
            var reversed = ReverseString(input);
            return input.Equals(reversed, StringComparison.OrdinalIgnoreCase);
        }
    }
}
