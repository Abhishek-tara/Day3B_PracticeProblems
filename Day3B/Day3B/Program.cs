namespace Day3B
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ConstructorTypes obj = new ConstructorTypes();
            ConstructorTypes obj_One = new ConstructorTypes("Bruce",33); 
            obj_One.Output();
            //Copy Constructor
            ConstructorTypes obj_Two = new ConstructorTypes("Ferrari", "485Hp");
            ConstructorTypes construct = new ConstructorTypes(obj_Two);
            Console.WriteLine("Copy Constructor : " + construct.car);
            Console.WriteLine("Copy Constructor : " + construct.Hp);
        }
    }
}
