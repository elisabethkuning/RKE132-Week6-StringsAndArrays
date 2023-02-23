string hello = " we are the champions?";

int stringLength = hello.Length;
//string trimmedString = hello.Trim();
//{
//    Console.WriteLine($"{i} symbol in string; {hello[i]}");
//}

hello = hello.Trim();

char firstLetter = hello[0];
Console.WriteLine(firstLetter);

//hello = hello.Replace(hello[0], 'H');
hello = hello.Replace(hello[0], char.ToUpper(hello[0])).Replace('?', '!');

firstLetter = hello[0];
Console.WriteLine(firstLetter);

Console.WriteLine(hello);

//int wordCounter = 1;
//for (int i = 0; i < hello.Length; i++)
//{
//    if (char.IsWhiteSpace(hello[i]))
//    { 
//        wordCounter++; 
//    }  
//}

//Console.WriteLine($"Word count in {hello}: {wordCounter} words.");


//for(int i = 0; i < hello.Length;i++)
//{
//    if(hello[i] == ' ')
//    { 
//        wordCounter++;
//    } 
//}

//Console.WriteLine($"Word count in {hello}: {wordCounter + 1} words.");

//Console.WriteLine(hello.Length);

//Console.WriteLine(trimmedString.Length);
// viimase sümboli asukoht on alati (length-1)
