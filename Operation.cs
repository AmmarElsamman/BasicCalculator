using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
    /// <summary>
    /// A class to hold information about the calculator operation
    /// </summary>
    public class Operation
    {
        #region Public Properties

        /// <summary>
        /// The left side of the opertation
        /// </summary>
        public string LeftSide { get; set; }

        /// <summary>
        /// the right side of the operation
        /// </summary>
        public string RightSide { get; set; }

        /// <summary>
        /// The type of operation to preform
        /// </summary>
        public OperationType OperationType { get; set; }

        #endregion

        #region Constructor
         
        /// <summary>
        /// constructor
        /// </summary>
        public Operation()
        {
            //creating empty strings
            this.LeftSide = string.Empty;
            this.RightSide = string.Empty;
        }

        #endregion
    }
}
