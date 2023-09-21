namespace Exercise3_3
{
    internal class Program
    {   
        // 13. Lägger till attribut i Bird
        // 14. Lägger till atributet i Animal
        static void Main(string[] args)
        {
            IPerson wolfman = new Wolfman();
            Console.WriteLine($"Wolfman talk: {wolfman.Talk()}");

            Dog dog = new Dog();
            Console.WriteLine($"Is dogs man's best friend? {dog.MansBestFriend}");
        }
    }
}