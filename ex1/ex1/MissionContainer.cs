
using System.Collections.Generic;

namespace Excercise_1
{
    public delegate double func(double value);

    public class FunctionsContainer
    {
        private Dictionary<string, func> dictionary = new Dictionary<string, func>();
       public func this [string index]
        {
            get
            {
                return dictionary[index];
            }
            set
            {
                dictionary[index] = value;
            }
        }
    }
}
