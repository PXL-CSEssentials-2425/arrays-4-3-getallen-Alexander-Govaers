Console.WriteLine("==== SOM bepalen van 3 getallen ====");

int[] getallenUser = new int[3];

Console.WriteLine("Geef getal 1/3 : ");
getallenUser[0] = int.Parse(Console.ReadLine());

Console.WriteLine("Geef getal 2/3 : ");
getallenUser[1] = int.Parse(Console.ReadLine());

Console.WriteLine("Geef getal 3/3 : ");
getallenUser[2] = int.Parse(Console.ReadLine());

Console.ReadLine();

Console.WriteLine($"De som van deze getallen is {getallenUser.Sum()} ");