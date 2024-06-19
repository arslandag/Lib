namespace Library;

public static class Square
{
    private const int POWER = 2;
    
    public static double AreaOfCircle (double radius)
    {
        var result = Math.PI * Math.Pow(radius, POWER);

        return result;
        
    }
    
    public static double AreaOfCircle (int radius)
    {
        var result = Math.PI * Math.Pow(radius, POWER);

        return result;
    }
    
    public static double AreaOfTriangle(double a, double b, double c)
    {
        var perimetr = a + b + c;
        
        var result = Math.Sqrt(perimetr) * (perimetr - a) * (perimetr - b) * (perimetr - c); 
        
        return result;
    }

    public static double AreaOfTriangle(int a, int b, int c)
    {
        var perimetr = a + b + c;

        var result = Math.Sqrt(perimetr) * (perimetr - a) * (perimetr - b) * (perimetr - c);

        return result;
    }
}
