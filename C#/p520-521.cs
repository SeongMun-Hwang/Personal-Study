using static System.Console;
using System;
using System.Collections;
using System.Linq.Expressions;
using System.Reflection;
namespace CsConsole
{
    class MainApp
    {    
        static void Main(string[] args)
        {
            //p520
            //1*2+(x-y)
            Expression const1=Expression.Constant(1);
            Expression const2=Expression.Constant(2);
            Expression leftExp=Expression.Multiply(const1, const2);

            Expression param1=Expression.Parameter(typeof(int));
            Expression param2=Expression.Parameter(typeof(int));

            Expression rightExp=Expression.Subtract(param1, param2);
            Expression exp = Expression.Add(leftExp, rightExp);

            Expression<Func<int, int, int>> expression =
                Expression<Func<int, int, int>>.Lambda<Func<int, int, int>>(
                    exp, new ParameterExpression[]
                    {
                        (ParameterExpression)param1,
                        (ParameterExpression)param2,
                    });
            Func<int, int, int> func = expression.Compile();
            WriteLine($"1 * 2 + ({7} - {8}) = {func(7,8)}");
            WriteLine();

            //p521
            //불변
            Expression<Func<int, int, int>> expression2 = (a, b) => 1 * 2 + (a - b);
            Func<int,int,int>func2=expression2.Compile();
            WriteLine($"1 * 2 + ({7} - {8}) = {func2(7, 8)}");

            ReadLine();
        }
    }
}