using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassExempel.Model;


namespace ClassExempel
{
    class Program
    {
        static void Main(string[] args)
        {
            //Konstruktor finns i alla classer. Classer är blueprints/kakformer. Konstruktorn skapar en kaka/instans

            /*Dog myDog = new Dog();
            myDog.Name = "Fido";
            myDog.Gender = Gender.Male;
            myDog.Age = 7;*/

            Dog myDog = new Dog()
            {

                Name = "Fido",
                Gender = Gender.Male,
                Age = 7,


            };




            Console.WriteLine("My dogs name is:" + myDog.Name);
            Console.WriteLine("My dogs gender is:" + myDog.Gender);
            Console.WriteLine("My dogs age is:" + myDog.Age);
            Console.WriteLine(myDog.Bark());




            Cat myCat = new Cat();

            Console.ReadKey();




        }
    }

}
