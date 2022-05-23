using Classes.Math;


namespace Classes
{

    class Program
    {
        static void Main(string[] args)
        {
            var john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introduce();

            var james = new Person();
            james.FirstName = "James";
            james.LastName = "Doe";
            james.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            System.Console.WriteLine(result);
            var resultMulti = calculator.Multiply(5, 7);
            System.Console.WriteLine(resultMulti);

            
        }
    }
}
