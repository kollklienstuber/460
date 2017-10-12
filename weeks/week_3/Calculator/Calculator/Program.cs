using System;


namespace Calculator
{
    /*
       Command lind postfix Calculator. Code translated from Calculator.java code 
       for cs 460.
       ----------------------------
       -- -- Koll Klienstuber -- --
       ----------------------------
   */
    class Program
    {
         /**
         * Interface data structure used to hold the operands for the calculator
         */
        private IADTStack stack = new LinkedStack();

        //
        private ADTStack Stack
        {
            get { return stack; }
        }




        static void Main(string[] args)
        {
            Program calc = new Program();
            bool calculateAgain = true;
            Console.Write("Postfix Calculato: \t Recognizes the following operators: + - * /");
            while (calculateAgain)
            {
                calculateAgain = calc.RunCalculation();
            }
            Console.Write("Goodbye...");

        }


        private bool RunCalculation()
        {
            Console.Write("Please enter q to quit or exit the command window:\n> ");

            string input, output = " ";

            input = Console.ReadLine();
            //check and see if wanting to quit
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
            Console.Write("\n\t>>> " + input + " = " + output);
            return true;
        }

        private string EvaluatePostFixInput(string input)
        {
            if (input.Equals("") || input == null)
                throw new ArgumentException("Null or the empty string are not valid postfix expressions!!!");
            Stack.Clear(); // Clear stack before doig a new calculation.

            //temp variables to work with
            double a, b, c, x; 
            int counter = 0;
            string[] variables = input.Trim().Split(' ');
            foreach (string var1 in variables)
            {
                if (Double.TryParse(var1, out x))
                {
                    Stack.Push((x));
                    counter++;
                }
                else // Must be an operator or some other character and or word.
                {
                    if (var1.Length > 1)
                        throw new ArgumentException("Input Error: " + var1 + " is not an allowed number or operator");
                    // may be an operator, so pop two values off stack and perform operation
                    if (Stack.IsEmpty())
                        throw new ArgumentException("Improper input format. Stack became empty when expecting second operand.");
                    b = (double)Stack.Pop();
                    if (Stack.IsEmpty())
                        throw new ArgumentException("Improper input format. Stack became empty when expecting first operand.");
                    a = (double)Stack.Pop();
                    // Send values to another method to perform operation.
                    c = Evaluate(a, b, var1, ref counter);
                    // Push answer from operation back onto the stack.
                    Stack.Push(c);
                }
            } // end foreach
            if (counter > 1)
                throw new ArgumentException("Input Error: Improper operand to operator ratio.");
            return Stack.Pop().ToString();
        }


        private double Evaluate(double a, double b, string s, ref int stackCount)
        {
            double c = 0.0;
            if (s.Equals("+"))
                c = (a + b);
            else if (s.Equals("-"))
                c = (a - b);
            else if (s.Equals("*"))
                c = (a * b);
            else if (s.Equals("/"))
            {
                try
                {
                    c = (a / b);
                    if (Double.IsNegativeInfinity(c) || Double.IsPositiveInfinity(c))
                        throw new ArgumentException("Can't divide by zero.");
                }
                catch (ArithmeticException ex)
                {
                    throw new ArgumentException(ex.Message);
                }
            }
            else
                throw new ArgumentException("Bad operator: " + s + ", is not one of +, -, *, or /");

            stackCount = stackCount - 1; 
            return c;
        }

    }
}













