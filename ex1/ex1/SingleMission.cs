using System;

namespace Excercise_1
{
    /**
     * The class SingleMission represent single mission.
    **/
    public class SingleMission : IMission
    {
        const string missionType = "Single";
        private mission singleMission;
        public event EventHandler<double> OnCalculate;
        // Property Name
        public string Name
        {
            get;
        }
        // Property Type
        public string Type
        {
            get;
        }
        // Constructor
        public SingleMission(mission missionToPerform, string name)
        {
            Name = name;
            singleMission = missionToPerform;
            Type = missionType;
        }
        /**
         * Calculate and return the result of the mission with the received value,
         * And invoke the event if its not null. 
        **/
        public double Calculate(double value)
        {
            double answer = singleMission(value);
            OnCalculate?.Invoke(this,answer);
            return answer;
        }
    }
}
