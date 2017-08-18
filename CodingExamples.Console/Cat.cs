using System;

namespace CodingExamples.Console
{
    public class Cat : Animal
    {
        public Cat()
        {
            
        }

        /// <summary>
        /// Another constructor, that allows you to provide 1 paramater (the color of the animal)
        /// passes the color parameter to the Animal constructor to assign, instead of the method 
        /// the Dog class uses, which sets it directly from the Dog constructor
        /// </summary>
        /// <param name="color">A string representing the color of the animal</param>
        public Cat(string color) : base(color)
        {
            Color = color;
        }

        public override string MakeNoise()
        {
            return Meow();
        }
        public string Meow()
        {
            return "Meowwwww"; 
        }
    }
}