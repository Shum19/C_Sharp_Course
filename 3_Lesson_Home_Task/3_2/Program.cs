/*  Задача 2: Напишите программу, которая принимает на вход координаты 
    двух точек и находит расстояние между ними в 3D пространстве.
    A (3,6,8); B (2,1,-7), -> 15.84 
    A (7,-5, 0); B (1,-1,9) -> 11.53
*/ 
int InputData(string message)
{
    Console.Write(message);
    string text = Console.ReadLine();
    int number = text == null ? 0 : int.Parse(text);
    return number;
}

double DistanceOfCoordinetes(int ax, int ay, int az, int bx, int by, int bz)
{
    double distanceAB = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2));
    distanceAB = Math.Round(distanceAB, 2);
    Console.Write($"A ({ax}, {ay}, {az}); B ({bx}, {by}, {bz}) -> {distanceAB}");
    return distanceAB;
}
Console.WriteLine ("Write coordinates of point A:");
int aX = InputData("Ax = ");
int aY = InputData("Ay = ");
int aZ = InputData("Az = ");
Console.WriteLine ("Write coordinates of point B:");
int bX = InputData("Bx = ");
int bY = InputData("By = ");
int bZ = InputData("Bz = ");
DistanceOfCoordinetes(aX, aY, aZ, bX, bY, bZ);

