
Random rnd= new Random();

int myRandomNum;

int randomSum = 0;

for(int i = 0; i < 3; i++)
{
    myRandomNum= rnd.Next(0, 11);//algpunkt sisse arvatud, lõpp-punkt jäetakse välja
    randomSum = randomSum + myRandomNum;
    Console.WriteLine($"My random number is: {myRandomNum}");
}

Console.WriteLine($"Random sum total: {randomSum}");


//int myRandomNum = rnd.Next(0, 11); Sel juhul genereerib ühe
//Console.WriteLine($"My random number is: {myRandomNum}"); numbri vahemikus1-10