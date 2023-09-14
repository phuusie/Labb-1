// LABB 1

string input = Console.ReadLine();
Console.WriteLine("");

double sum = 0;

char[] numbers = "0123456789".ToCharArray();

for (int i = 0; i < input.Length; i++)
{
    string output = String.Empty;

    if (numbers.Contains(input[i]))
    {
        output += input[i];
    }

    for (int j = i + 1; j < input.Length; j++)
    {
        if (numbers.Contains(input[j]))
        {
            output += input[j];
        }
        else
        {
            break;
        }

        if (input[i] == input[j])
        {
            Console.Write(input.Substring(0, i));

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(output);

            Console.ResetColor();
            Console.WriteLine(input.Substring(j + 1));

            sum += double.Parse(output);
            break;
        }
        else if (!numbers.Contains(input[j]))
        {
            break;
        }
    }
}

Console.WriteLine("\nInput: " + input + "\nTotal: " + sum);
