Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// Your code goes here
if (daysUntilExpiration <= 0)
{
    Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration <= 1)
{
    discountPercentage=20;
    Console.WriteLine("Your subscription expires within a day!");
}
else if (daysUntilExpiration <= 5)
{
    discountPercentage=10;
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}
if (discountPercentage>0) {
    Console.WriteLine($"Renew now and save {discountPercentage}%!");
}// Por que guardo este codigo? me parece que fue una interesante forma de aplicar la solucion ponendo la menor cantidad de caracteres en memoria :D
//why i saved this? cus i think that is a very good way to apply to the question using less memory