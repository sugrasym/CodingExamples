using System;

namespace CodingExamples.Console
{
    /// <summary>
    /// This is a class definition for a canine.
    /// </summary>
    public class Dog : Animal
    {

        /// <summary>
        /// This is the constructor. When a new Dog is created this runs first.
        /// A constructor is just a glorified method/function
        /// </summary>
        public Dog()
        {
            System.Console.WriteLine("New dog created!");
        }

        /// <summary>
        /// Assigns the provided string parameter to the Color property.
        /// </summary>
        /// <param name="color"></param>
        public Dog(string color) 
        {
            Color = color;
        }

        /// <summary>
        /// A string representing the genus and species of the dog.
        /// Could be something like Bulldog or Pomeranian
        /// </summary>
        public string Breed { get; set; }

        #region Methods/Functions
        //Methods are things that the class can do, in this case, things a dog can do,
        //like bark, poop, run, wag their tail, sleep, etc
        /// <summary>
        /// Returns a string representing the sound of the dog bark.
        /// Examples: Woof, Hooo, Yip, Bork
        /// </summary>
        /// <returns></returns>
        public string Bark()
        {
            return "Bark!";
        }

        public override string MakeNoise()
        {
            return Bark();
        }
        #endregion

        #region Properties
        /// <summary>
        /// An integer representing the dog's bark volume on a scale of 0-100
        /// Pekingese for example, with their raspy quiet barks would be around 0-19
        /// German Shepard would be 80+
        /// </summary>
        public int BarkVolume { get; set; }
        #endregion

    }
}