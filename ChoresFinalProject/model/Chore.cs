/**************************************************************
* Name        : ChoresFinalProject
* Author      : Colby Boell
* Created     : 10/27/2021
* Course      : Data Structures 
* Version     : 1.0
* OS          : Windows 10, Visual Studio 2019, C#
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : This program overall description here
*               Input:  input choice, chore name, hours to complete chores, priority of chore
*               Output: information about chores, various list sorted in various ways
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or 
* unmodified. I have not given other fellow student(s) access to
* my program.         
***************************************************************/

namespace ChoresFinalProject
{
    public class Chore
    {
        //variables
        private string name;
        private double hoursToComplete;
        private char priorityLevel;

        //constructors
        public Chore() {
            name = null;
            hoursToComplete = 0;
            priorityLevel = 'D';
        }
        public Chore(string name, double hoursToComplete, char priorityLevel) {
            this.name = name;
            this.hoursToComplete = hoursToComplete;
            this.priorityLevel = priorityLevel;
        }
        //getters and setters
        public string getName() {
            return name;
        }
        public void setName(string name) {
            this.name = name;
        }
        public double getHoursToComplete() {
            return hoursToComplete;
        }
        public void setHourstToComplete(double hoursToComplete) {
            this.hoursToComplete = hoursToComplete;
        }

        public int getPriorityLevel() {
            return priorityLevel;
        }

        public void setPriorityLevel(char priorityLevel) {
            this.priorityLevel = priorityLevel;
        }

        //methods
        public string toString() {

            return"Chore: " + name + " | Hours To Complete: " + hoursToComplete + " | Priority Level: " + priorityLevel;
        }

    }
}
