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

    public class SinglyLinkedListTests
    {
        [Fact]
        public void testToSeeIfSinglyLinkedListIsEmpty() //test to see if list is empty
        {
            SinglyLinkedList<String> a = new SinglyLinkedList<String>();
            Assert.True(a.isEmpty());
        }

        [Fact]
        public void testToSeeIfSinglyLinkedListIsNotEmpty() //test to see if list is not empty
        {
            SinglyLinkedList<String> a = new SinglyLinkedList<String>();
            a.insert("Chore: Dishes | Hours To Complete: 1 | Priority Level: C", 1);
            a.insert("Chore: Mow | Hours To Complete: 2 | Priority Level: A", 2);
            Assert.False(a.isEmpty());
        }

        [Fact]
        public void testToSeeIfSinglyLinkedCountIsCorrect() //test to see if list is not empty
        {
            int expected = 2;
            SinglyLinkedList<String> a = new SinglyLinkedList<String>();
            a.insert("Chore: Dishes | Hours To Complete: 1 | Priority Level: C", 1);
            a.insert("Chore: Mow | Hours To Complete: 2 | Priority Level: A", 2);

            Assert.Equal(expected, a.count());
        }

        [Fact]
        public void testToSeeIfSinglyLinkedCountIsNotCorrect() //test to see if list is not empty
        {
            int expected = 1;
            SinglyLinkedList<String> a = new SinglyLinkedList<String>();
            a.insert("Chore: Dishes | Hours To Complete: 1 | Priority Level: C", 1);
            a.insert("Chore: Mow | Hours To Complete: 2 | Priority Level: A", 2);

            Assert.NotEqual(expected, a.count());
        }

        [Fact]
        public void testToSeeIfSinglyLinkedListDelete() //test to see if list is not empty
        {
            int expected = 1;
            SinglyLinkedList<String> a = new SinglyLinkedList<String>();
            a.insert("Chore: Dishes | Hours To Complete: 1 | Priority Level: C", 1);
            a.insert("Chore: Mow | Hours To Complete: 2 | Priority Level: A", 2);

            a.delete(1);
            Assert.Equal(expected, a.count());
        }
    }
}
