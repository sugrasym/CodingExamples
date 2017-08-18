using System;

namespace CodingExamples.Console
{
    class Program
    {
        /// <summary>
        /// the default entrypoint in most languages is a static method called "main"
        /// most times it will take arguments.
        /// This is a method/function. For all intensive purposes this can be called either.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Run the method to show the dog examples
            ShowDogExamples();

            //a note about scope. fido, the local variable declared in the ShowDogExamples
            //method no longer exists. he is destroyed after that method is done.
            //so this won't work fido = new Dog(); or this fido.Bark();, but you could create a
            //new local variable at this scope called fido, just remember he isn't the real fido.

            //show some cats and inheritance
            ShowAnimalExamples();

            //wait for the user to press enter
            //since our project namespace is .Console, we are 
            //overriding the System.Console namespace.
            //so we'll explicitly say what Console class we mean.
            System.Console.ReadLine();
        }

        private static void ShowAnimalExamples()
        {
            //create local var called shasta that represents a cat,
            //we use the constructor for cats that lets you define the color
            //to initialize shasta with the color Black
            var shasta = new Cat("Black");

            //write out her Meow string
            System.Console.WriteLine(shasta.Meow());

            //have shasta use her base class method to make noise (which ends up being a meow)
            System.Console.WriteLine(shasta.MakeNoise());

            //make a local variable called gary which is a Dog class and has a color of White
            var gary = new Dog("White");

            //call his Animal.MakeNoise() method
            gary.MakeNoise();
        }

        private static void ShowDogExamples()
        {
            //var declaration is called implicit declaration
            //implicit means that we don't know the exact type of the variable (object)
            //but we know that whatever we are assigning to it is what we want.
            //we then assign it to a local variable called fido
            //implicit (using var) requires you to assign on declaration
            var fido = new Dog();

            //fido's friend bork is declared with explicit declaration
            //one advantage of this is you can declare a variable and not use it.
            Dog bork = new Dog();

            // make a new bark object that represents what fido returned from his bark method
            var fidosBark = fido.Bark();

            //write out their barks, but for bork's use the method call directly,
            //vs using the local variable, which was the result of fido's Bark method call.
            //since Console.WriteLine takes a string parameter both of these methods work
            System.Console.WriteLine(fidosBark);
            System.Console.WriteLine(bork.Bark());
        }

        //this would be an example of a property on the Program class 
        //that could represent a Dog object available at any level
        public Dog GlobalFido { get; set; }
    }
}
