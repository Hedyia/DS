namespace DS
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                bool exp = IsValid("{}");
                System.Console.WriteLine(exp.ToString());
            }
            catch (System.Exception)
            {

                System.Console.WriteLine("False");
            }

        }
        public static bool IsPair(char open, char close)
        {
            if (open == '[' && close == ']') return true;
            if (open == '{' && close == '}') return true;
            if (open == '(' && close == ')') return true;
            return false;
        }

        public static bool IsValid(string expr)
        {
            var stack = new Stack<char>();
            foreach (var character in expr)
            {
                if (character == '[' || character == '{' || character == '(')
                {
                    stack.Push(character);
                }
                else if (character == ']' || character == '}' || character == ')')
                {
                    if (!IsPair(stack.Top, character))
                    {
                        return false;
                    }
                    else
                    {
                        stack.Pop();
                    }
                }

            }
            return stack.IsEmpty;
        }
    }
}
