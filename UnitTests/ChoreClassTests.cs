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
using ChoresFinalProject;
using System;
using Xunit;

namespace UnitTests
{
    public class ChoreClassTests
    {
        private static Chore a = new Chore();
        private static string name = "Clean House";
        private static int hours = 5;
        private static char priority = 'A';

        [Fact] //test chore getters and setters to equal expected
        public void TestChoreClassGettersAndSetters()
        {
            a.setName("Clean House");
            a.setHourstToComplete(5);
            a.setPriorityLevel('A');

            Assert.Equal(a.getName(), name);
            Assert.Equal(a.getHoursToComplete(), hours);
            Assert.Equal(a.getPriorityLevel(), priority);
        }

        [Fact] //test chore getters and setters not equal
        public void TestChoreClassGettersAndSettersNotEqual()
        {
            string expectedName = "Change Car Oil";
            int expectedHours = 6;
            char expectedPriority = 'D';


            a.setName("Clean House");
            a.setHourstToComplete(5);
            a.setPriorityLevel('A');

            Assert.NotEqual(a.getName(), expectedName);
            Assert.NotEqual(a.getHoursToComplete(), expectedHours);
            Assert.NotEqual(a.getPriorityLevel(), expectedPriority);
        }

        [Fact] //tests getters and setters for name variable
        public void TestNameGetAndSet() {

            string expected = "Clean House";

            a.setName(name);

            Assert.Equal(a.getName(), expected);
        }

        [Fact] //tests getters and setters for name variable not equal 
        public void TestNameGetAndSetNotEqual()
        {

            string expected = "Dishes";

            a.setName(name);

            Assert.NotEqual(a.getName(), expected);
        }

        [Fact] //test getters and setters for hours to complete variable
        public void TestHoursGetAndSet() {
            int expected = 5;

            a.setHourstToComplete(hours);

            Assert.Equal(a.getHoursToComplete(), expected);
        }

        [Fact] //test getters and setters for hours to complete variable not equal
        public void TestHoursGetAndSetNotEqual()
        {
            int expected = 3;

            a.setHourstToComplete(hours);

            Assert.NotEqual(a.getHoursToComplete(), expected);
        }

        [Fact] //test priority level variables getters and setters
        public void TestPriorityGetAndSet() {
            char expected = 'A';

            a.setPriorityLevel(priority);

            Assert.Equal(a.getPriorityLevel(), expected);
        }

        [Fact] //test priority level variables getters and setters not equal
        public void TestPriorityGetAndSetNotEqual()
        {
            char expected = 'A';

            a.setPriorityLevel(priority);

            Assert.Equal(a.getPriorityLevel(), expected);
        }

        [Fact] //tests the toString method in the chores class
        public void testChoreToString() {
            String expected = "Chore: Dishes | Hours To Complete: 1 | Priority Level: A";
            Chore a = new Chore("Dishes", 1, 'A');
            String actual = a.toString();
            Assert.Equal(actual, expected);
        }
        [Fact] //tests the toString method in the chores class not equal
        public void testChoreToStringNotEqual()
        {
            String expected = "Chore: Bathe Dog | Hours To Complete: 2 | Priority Level: B";
            Chore a = new Chore("Dishes", 1, 'A');
            String actual = a.toString();
            Assert.NotEqual(actual, expected);
        }

        [Fact] //test chore getters and setters to equal expected when duplicate chore
        public void TestChoreClassGettersAndSettersDuplicateChoreEqual()
        {
            Chore b = new Chore();
            a.setName("Clean House");
            a.setHourstToComplete(5);
            a.setPriorityLevel('A');

            b = a;
            Assert.Equal(a, b);
            Assert.Equal(a.getName(), b.getName());
            Assert.Equal(a.getHoursToComplete(), b.getHoursToComplete());
            Assert.Equal(a.getPriorityLevel(), b.getPriorityLevel());
            Assert.Equal(a.toString(), b.toString());
        }

        [Fact] //test chore getters and setters to equal expected when duplicate chore
        public void TestChoreClassGettersAndSettersSeperateChoresNotEqual()
        {
            Chore b = new Chore();
            a.setName("Clean House");
            a.setHourstToComplete(5);
            a.setPriorityLevel('A');

            b.setName("Dishes");
            b.setHourstToComplete(1);
            b.setPriorityLevel('C');

            Assert.NotEqual(a, b);
            Assert.NotEqual(a.getName(), b.getName());
            Assert.NotEqual(a.getHoursToComplete(), b.getHoursToComplete());
            Assert.NotEqual(a.getPriorityLevel(), b.getPriorityLevel());
            Assert.NotEqual(a.toString(), b.toString());
        }

        [Fact]
        public void testPriorityLevelIsNotInt() {
            a.setPriorityLevel('A');

            Assert.IsNotType<int>(a.getPriorityLevel());
        }
        [Fact]
        public void testPriorityLevelIsNotString()
        {
            a.setPriorityLevel('A');

            Assert.IsNotType<string>(a.getPriorityLevel());
        }
        [Fact]
        public void testPriorityLevelIsCharAfterConverted()
        {                                    //test to make sure priority level
            String expected = "a";          //is type char after converted
            char Actual = Convert.ToChar(expected.ToUpper());

            Assert.IsType<char>(a.getPriorityLevel());
        }
    }
}
