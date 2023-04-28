using Newton_s_interpolating_polynomial.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newton_s_interpolating_polynomial
{
    public static class Menu
    {
        public static void InterpolationMenu()
        {
            Console.WriteLine("Enter the number of points");
            int number_of_points = int.Parse(Console.ReadLine());

            double[,] Datatable = Interpolation.setdatatable(number_of_points);                      //x ve y-leri userden alib data table qururuq

            Interpolation.showcoefficient(number_of_points, Datatable);                            //display the coefficients

            double[] variableprod = Interpolation.variableproducts(Datatable, number_of_points);   //(x-x0)(x-x1)(x-x2)....(x-x(n-1))

            Interpolation.showresult(Datatable, number_of_points, variableprod);                    //The value of Polynomial function in x
        }
    }
}
