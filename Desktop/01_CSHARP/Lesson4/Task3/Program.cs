//Считать с консоли строку,состоящую из цифр и латинских букв

string GetLettersFromString(string s)
{
    string letters = " ";
    foreach (char e in s)
    {
        if(char.IsAsciiLetter(e) == true)
        {
            letters = letters + e;
        }
    }
    return letters;
}
string str = Console.ReadLine();
string rezult = GetLettersFromString(str);

System.Console.WriteLine(rezult);
