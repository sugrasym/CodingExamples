namespace CodingExamples.Console
{
    public class Animal
    {
        public Animal()
        {

        }
        public Animal(string color)
        {
            Color = color;
        }

        public virtual string MakeNoise()
        {
            return "...";
        }
        //Properties are all the things the describe the class.
        //These are things you would find on an ID card. Think of them like stats.
        //Things like height, width, gender, girth, etc
        /// <summary>
        /// Description of color. Examples: Orange, Blue, White
        /// Could be used differently, thought, and could be a hex or rgb values (comma separated)
        /// Hex example: #FFFFFF (White) #FF0000 (Red)
        /// RGB values example: 255,255,255 (White) 255,0,0 (Red)
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// A string that represents the identity of this animal, i.e. what he responds to
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// A bool representing the animal's sex. 
        /// false = female
        /// true = male
        /// </summary>
        public bool Gender { get; set; }

        /// <summary>
        /// The weight of the animal in pounds (lbs)
        /// Could be in other units, like kilograms (kgs)
        /// or in other precisions, with something like a double, float, or decimal type.
        /// Those types would allow you to store decimal places as the weight value.
        /// For example 86.65 instead of 86 with an integer
        /// </summary>
        public int Weight { get; set; }

        /// <summary>
        /// An integer representing the length of the animal's tail
        /// </summary>
        public int TailLength { get; set; }

    }
}