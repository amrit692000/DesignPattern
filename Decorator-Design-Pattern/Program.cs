class Program
    {
        static void Main(string[] args)
        {
            
            IComponent<string> component = new ConcreteComponent();

          
            var plainDecorator = new PlainDecorator(component);
            var upperCaseDecorator = new UpperCaseDecorator(component);
            var colorDecorator = new ColorDecorator(component);

            
            Console.WriteLine("Plain Decorator: " + plainDecorator.GetText());
            Console.WriteLine("Upper Case Decorator: " + upperCaseDecorator.GetText());
            Console.WriteLine("Color Decorator: " + colorDecorator.GetText());
        }
    }

