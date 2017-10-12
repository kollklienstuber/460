using System;

namespace Homework3
{
    /*
        Command line postfix Calculator. Code translated from Calculator.java code 
        for cs 460.

        ----------------------------
        -- -- Koll Klienstuber -- --
        ----------------------------

    */ 
    class PostFixCalc
    {

        //data structure used to hold + - / * for our postfix calculator
        private ICalculatorStackAdt MainStack
        {
            get { return stackOne; }
        }
        private ICalculatorStackAdt stackOne = new LinkedStack();

       
        static void Main(string[] args)
        {
            PostFixCalc calc = new PostFixCalc();
            bool Calculation = true;
            Console.Write("Hi whoever is currently using this Posstfix Calculator. Recognized operators I support: + - * /");
            while (Calculation)

            {
                Calculation = calc.RunCalculation();
            }


            Console.Write("Goodbye forever...");
        }

     


        private bool RunCalculation()
        {
            Console.Write("\n Please enter q to quit or exit the command window:\n> ");

            string input, output = " ";
            //find out if we are wanting to quit
            input = Console.ReadLine();
            
            if (input.Trim().ToLower().StartsWith("q"))
            {
                return false;
            }
            // Go ahead with calculation
            try
            {
                output = EvaluatePostFixInput(input);
            }
            catch (ArgumentException ex)
            {
                output = ex.Message;
            }
            Console.Write("\n\n\t>>> " + input + " = " + output);
            return true;
        }
        private string EvaluatePostFixInput(string input)
        {
            if (input.Equals("") || input == null)
                throw new ArgumentException("Null or the empty string are not valid postfix expressions!!!");
            MainStack.Clear(); // Clear stack before doig a new calculation.

            //temp variables to work with
            double a, b, c, x;
            int counter = 0;
            string[] variables = input.Trim().Split(' ');
            foreach (string var1 in variables)
            {

                if (Double.TryParse(var1, out x))
                {
                    MainStack.Push((x));
                    counter++;
                }
                else // Must be an operator or some other character and or word.
                {
                    if (var1.Length > 1)
                        throw new ArgumentException("Input Error: " + var1 + " is not an allowed number or operator");
                    // pop two values if operator
                    if (MainStack.IsEmpty())
                        throw new ArgumentException("Improper input format. Stack became empty when expecting second operand.");
                    b = (double)MainStack.Pop();
                    if (MainStack.IsEmpty())
                        throw new ArgumentException("Improper input format. Stack became empty when expecting first operand.");
                    a = (double)MainStack.Pop();
                    // send to other method for evaluating
                    c = Evaluate(a, b, var1, ref counter);
                    // Push answer to the back
                    MainStack.Push(c);
                }
            } 
           
            return MainStack.Pop().ToString();
        }


        private double Evaluate(double a, double b, string str, ref int stackCount)
        {
            double initial = 0.0;
            if (str.Equals("+"))
                initial = (a + b);
            else if (str.Equals("-"))
                initial = (a - b);
            else if (str.Equals("*"))
                initial = (a * b);
            else if (str.Equals("/"))
            {
                try
                {
                    initial = (a / b);
                    if (Double.IsNegativeInfinity(initial) || Double.IsPositiveInfinity(initial))
                        throw new ArgumentException("You're trying to divide by zero and we can't really have that happen");
                }
                catch (ArithmeticException ex)
                {
                    throw new ArgumentException(ex.Message);
                }
            }
            else
                throw new ArgumentException("Invalid operation was entered: " + str + ", isn't supported and should be +, -, *, or /");

            stackCount = stackCount - 1;
            return initial;
        }

    }
}

