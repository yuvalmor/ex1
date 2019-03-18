using System.Collections.Generic;
using System;

namespace Excercise_1
{
    public delegate double funcPointer(double value);

    public class FunctionsContainer
    {
       funcPointer doNothing = x => x;
       private Dictionary<string, funcPointer> dictionary = new Dictionary<string, funcPointer>();
       public funcPointer this [string index]
        {
            get
            {
                if (!dictionary.ContainsKey(index))
                {
                    dictionary[index] = doNothing;
                }
                return dictionary[index];
            }
            set
            {
                dictionary[index] = value;
            }
        }
        public List<string> getAllMissions()
        {
            List<string> list = new List<string>();
            foreach (var name in dictionary)
            {
                list.Add(name.Key);
            }
            return list;
        }
    }
}
