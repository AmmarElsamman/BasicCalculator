
namespace BasicCalculator
{
    /// <summary>
    /// Class to handle the  memory
    /// </summary>
    public class MemoryData
    {
        /// <summary>
        /// setting the memory
        /// </summary>
        public double Memory { get; set; }

        /// <summary>
        /// constructor
        /// </summary>
        public MemoryData()
        {
            this.Memory = 0;
        }

        /// <summary>
        /// Adds value to the memory
        /// </summary>
        /// <param name="value">given value to add</param>
        /// <returns></returns>
        public string Add(double value)
        {
            Memory += value;
            return Memory.ToString();
        }

        /// <summary>
        /// Subtracts the value from the memory
        /// </summary>
        /// <param name="value">Given value to subtract</param>
        /// <returns></returns>
        public string Subtract(double value)
        {
            Memory -= value;
            return Memory.ToString();
        }
    }
}
