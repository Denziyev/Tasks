using Newton_s_interpolating_polynomial;

public class Program
{

    public static void Main(string[] args)
    {
        Console.WriteLine("0.Exit");
        Console.WriteLine("1.For Newton Interpolating Polynomial");
        string request=Console.ReadLine();
         

        while (request!="0") 
        { 
            switch (request)
            {
                case "1":
                    Menu.InterpolationMenu();
                   break;
                case "2":
                    break;
            }
            Console.WriteLine("0.Exit");
            Console.WriteLine("1.For Newton Interpolating Polynomial");
            request = Console.ReadLine();
        }




        
    }
}