/*  Напишите программу, которая принимает на вход координаты двух 
    точек и находит расстояние между ними в 2D пространстве.
    A (3,6); B (2,1) -> 5,09 
    A (7,-5); B (1,-1) -> 7,21
*/
double InputData(string message)
{
    Console.Write(message);
    string text = Console.ReadLine();
    double number = text == null ? 0 : double.Parse(text);
    return number;
}

Double DistanceBtnCoordinate(double ax, double ay, double bx, double by)
{
    double ab;
    ab = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2));
    Console.WriteLine(Math.Round(ab, 2));
    return ab;
}
double ax = InputData("Write X1 ");
double ay = InputData("Write Y1 ");
double bx = InputData("Write X2 ");
double by = InputData("Write Y2 ");
DistanceBtnCoordinate(ax, ay, bx, by);
