class Program
    {
        static void Main(string[] args)
        {
            
            IComponent<string> component = new ConcreteComponent();

          
            var plainDecorator = new PlainDecorator(component);
            var upperCaseDecorator = new UpperCaseDecorator(component);
            var colorDecorator = new ColorDecorator(component);

            
            Console.WriteLine("" + plainDecorator.GetText());
            Console.WriteLine("" + upperCaseDecorator.GetText());
            Console.WriteLine("" + colorDecorator.GetText());
        }
    }

