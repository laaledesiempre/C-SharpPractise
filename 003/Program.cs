﻿/* Random random = new Random();
string[] orderIDs = new string[5];

for (int i = 0; i < orderIDs.Length; i++)
{
    int prefixValue = random.Next(65, 70);
    string prefix = Convert.ToChar(prefixValue).ToString();
    string suffix = random.Next(1, 1000).ToString("000");

    orderIDs[i] = prefix + suffix;
}

foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
} */

// Example 1:
/* Console
.
WriteLine
(
"Hello Example 1!"
)
;

// Example 2:
string firstWord="Hello";string lastWord="Example 2";Console.WriteLine(firstWord+" "+lastWord+"!"); */

string str = "The quick brown fox jumps over the lazy dog.";

char[] message = str.ToCharArray();
// Reverse the chars

Array.Reverse(message);

int amoutOfO = 0;
// count the o's

foreach (char letter in message) 
{
    if (letter == 'o') 
    {
        amoutOfO++;
    } 
}
// convert it back to a string
string new_message = new String(message);

Console.WriteLine(new_message);

Console.WriteLine($"'o' appears {amoutOfO} times.");