

int sum = 0;

for(int i = 1; i < 4; i++) //i väärtus on 0(null) ja i-- = i-1
{
    Console.WriteLine($"i = {i}"); //siin on kuvatavad väärtused
    Console.WriteLine($"Current total: {sum}");
    sum = sum + i; //sum += 1;
}
//Console.WriteLine($"Final total {sum}");

