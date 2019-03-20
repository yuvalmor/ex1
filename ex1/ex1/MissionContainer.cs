using System.Collections.Generic;

namespace Excercise_1
{
    public delegate double mission(double value);
    /**
     * The class FunctionsContainer holds the function in the program using dictionary.
     **/
    public class FunctionsContainer
    {
       // Mission the do nothing
       mission doNothing = x => x;
       // Dictionery - the key holds the mission name, and the value is the mission itself 
       private Dictionary<string, mission> dictionary = new Dictionary<string, mission>();
       // Indexer
       public mission this [string index]
        {
            get {
                // If the index not exist, we create it with the do nothing function
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
        //The method getAllMissions - return list with all of the functions names.
        public List<string> getAllMissions()
        {
            List<string> list = new List<string>();
            foreach (var d in dictionary)
            {
                list.Add(d.Key);
            }
            return list;
        }
    }
}
