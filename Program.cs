using System; 

class Program
{
    static int UtvärderaUttryck(string uttryck)
    {
        Stack<int> values = new Stack<int>();
        Stack<char> operators = new Stack<char>();

        for(int i = 0; i < uttryck.Length; i++)
        {
            char c = uttryck[i];
            if(char.IsDigit(c))
            {
                int num = c -'0';
                while(i + 1 < uttryck.Length && char.IsDigit(uttryck[i + 1]))
                {
                    num = num * 10 +(uttryck[i + 1] - '0');
                    i++; 
                }
                values.Push(num);
            }
            
        }
    }

    static void ApplyOperator(Stack<int> values, Stack<char> operators)
    {
        char op = operators.Pop();
        int right = values.Pop();
        int left = values.Pop();

        if (op == '+')
        {
            values.Push(left + right);
        }
        else if (op == '-')
        {
            values.Push(left - right);
        }
        else if (op == '*')
        {
            values.Push(left * right);
        }
    }
}
