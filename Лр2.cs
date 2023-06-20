using System; 

  

class Point 

{ 

    private double x, y; 

    public Point(double x, double y) 

    { 

        this.x = x;  

        this.y = y; 

    } 

    public void PrintCoordinates() 

    { 

        Console.WriteLine("Point coordinates: ({0}, {1})", x, y); 

    } 

    public double DistanceToCenter() 

    { 

        return Math.Sqrt(x * x + y * y); 

    } 

    public void Move(double a, double b) 

    { 

        x += a; 

        y += b; 

    } 

     

    public double X 

    { 

        get { return x; } 

        set { x = value; } 

    } 

  

    public double Y 

    { 

        get { return y; } 

        set { y = value; } 

    } 

  

    

    public double ScaleFactor 

    { 

        set 

        { 

            x = value; 

            y= value; 

        } 

    } 

  

     

    public bool IsAtOrigin 

    { 

        get { return x == 0 && y == 0; } 

    } 

} 

class Program 

{ 

    static void Main(string[] args) 

    { 

        Point point = new Point(3, 4); 

        point.PrintCoordinates();  

  

        double distance = point.DistanceToCenter(); 

        Console.WriteLine($"Відстань від початку координат до точки: {distance}"); 

  

        point.Move(2, 3); 

        point.PrintCoordinates();  

  

        point.X = 10;  

        point.Y = 10; 

        point.PrintCoordinates(); 

        point.ScaleFactor = 2;  

        point.PrintCoordinates(); 

  

        bool isAtOrigin = point.IsAtOrigin;   

        if (!isAtOrigin) 

        { 

  

            Console.WriteLine("Точка не знаходиться на початку координат"); 

        } 

        else 

        { 

            Console.WriteLine("Точка знаходиться на початку координат"); 

        } 

    } 

} 