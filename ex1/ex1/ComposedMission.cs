using System;
using System.Collections.Generic;

namespace Excercise_1
{
    /**
     * The class ComposedMission represent complicated missions,
     * That assambled from simpliest missions.
    **/
    public class ComposedMission : IMission
    {
        // The variable missionType holds the mission type
        const string missionType = "Composed";
        public event EventHandler<double> OnCalculate;
        // Linked list that holds all the missions to preform
        LinkedList<mission> linkedList = new LinkedList<mission>();
        // Property Type
        public string Type
        {
            get;
        }
        // Property Name
        public string Name
        {
            get;
        }
        // Constructor
        public ComposedMission(string missionName)
        {
            Name = missionName;
            Type = missionType;
        }
        /**
         * Calculate the composed mission, step by step: 
         * The result of the last mission is the input to the next mission.
         * And invoke the event if its not null.
        **/
        public double Calculate(double value)
        {
            // Initial the answer whith the received value
            double answer = value;
            // Active every mission in the list
            foreach (mission mission in linkedList)
            {
                answer = mission(answer);
            }
            OnCalculate?.Invoke(this, answer);
            return answer;
        }
        // Add the recived mission to the list
        public ComposedMission Add(mission mission)
        {
            linkedList.AddLast(mission);
            return this;
        }
    }
}
