namespace FruitServer
{
    /// <summary>
    /// A fruit consisting only of a type
    /// </summary>
    public class Fruit
    {
        /// <summary>
        /// The actual type of fruit
        /// </summary>
        public string typeOfFruit { get; set; }


        public Fruit()
        {
        }


        public Fruit(string typeOfFruit)
        {
            this.typeOfFruit = typeOfFruit;
        }
    }
}