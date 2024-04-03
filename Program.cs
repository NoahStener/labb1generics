using System.ComponentModel.DataAnnotations;

namespace labb1generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BoxCollection boxCollection = new BoxCollection();

            boxCollection.Add(new Box(10, 10, 10));
            boxCollection.Add(new Box(15, 20, 5));
            boxCollection.Add(new Box(20, 15, 5));
            boxCollection.Add(new Box(8, 8, 5));
            boxCollection.Add(new Box(12,12,5));

            Display(boxCollection);

            Console.WriteLine("----------------------------");

            //lägger till objekt med samma dimmensioner som redan finns
            boxCollection.Add(new Box(10, 10, 10));


            Console.WriteLine("----------------------------");

            //Remove box med 8 8 5 dimensioner
            boxCollection.Remove(new Box(8, 8, 5));
            Display(boxCollection);


            Box boxToFind = new Box(20, 15, 5);

            Console.WriteLine("Contains height: {0}, Width: {1}, length {2}",
                boxToFind.Height.ToString(), boxToFind.Width.ToString(), boxToFind.Length.ToString(),
                boxCollection.Contains(boxToFind));



            Console.WriteLine("------------------------------");
            Display(boxCollection);






            Console.ReadKey();

        }

        public static void Display(BoxCollection boxes)
        {
            Console.WriteLine("\tHeight:\tWidth:\tLength:");
            foreach(Box box in boxes)
            {
                Console.WriteLine("\t{0} \t{1} \t{2}",
                box.Height.ToString(),box.Width.ToString(),box.Length.ToString());
            }

        }
    }
}
