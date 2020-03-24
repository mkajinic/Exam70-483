using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;

namespace Exam70_483
{
    class _2_5_TestLambdaExpressionTree
    {
        public static void RunLambdaTree()
        {
            
            
            //Build Expression tree
      //   Expression<Func<int, int>> square = num => num * num;

            // The parameter for the expression is an integer
            ParameterExpression numParam = Expression.Parameter(typeof(int), "num");

            // The opertion to be performed is to square the parameter
            BinaryExpression squareOperation = Expression.Multiply(numParam, numParam);

            //this creates expression tree that describes the square operation
            Expression<Func<int, int>> square = Expression.Lambda<Func<int, int>>(squareOperation, new ParameterExpression[] { numParam });


            //Compile the tree to make an executable method and assign it the a delegate
            Func<int, int> doSquare = square.Compile();

            //call delegate
            Console.WriteLine("square of 3: {0} ", doSquare(3));

            Console.ReadLine();
        }
        
    }
}
