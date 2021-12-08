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
using System;


namespace ChoresFinalProject
{
    public class MergeSort
    {
		//variables
		public node head = null;

		//nested node class
		public class node
		{
			//variables
			public string chore;
			public double numOfHours;
			public char priority;
			public node next;

			//constructor
			public node(string chore, double numOfHours, char priority)
			{
				this.chore = chore;
				this.numOfHours = numOfHours;
				this.priority = priority;
			}
		}

		public node sortedMerge(node a, node b)
		{
			node result = null;
			if (a == null)
				return b;
			if (b == null)
				return a;

			//chooses one of the 2 then reoccures
			if (a.numOfHours <= b.numOfHours)
			{
				result = a;
				result.next = sortedMerge(a.next, b);
			}
			else
			{
				result = b;
				result.next = sortedMerge(a, b.next);
			}
			return result;
		}

		public node mergeSort(node h)
		{
			// if head is null
			if (h == null || h.next == null)
			{
				return h;
			}

			//gets middle
			node middle = getMiddle(h);
			node nextofmiddle = middle.next;

			//sets next to null
			middle.next = null;

			// apply sort on left
			node left = mergeSort(h);

			// apply sort on right
			node right = mergeSort(nextofmiddle);

			// merges both lists
			node sortedlist = sortedMerge(left, right);
			return sortedlist;
		}

		//method to get middle
		public node getMiddle(node h)
		{
			if (h == null)
				return h;
			node fastptr = h.next;
			node slowptr = h;

			while (fastptr != null) // Move fastptr by two and slow ptr by one
			{                       // Finally slowptr will point to middle node
				fastptr = fastptr.next;
				if (fastptr != null)
				{
					slowptr = slowptr.next;
					fastptr = fastptr.next;
				}
			}
			return slowptr;
		}

		public void push(string chore, double new_data, char priority)
		{
		
			node newNode = new node(chore, new_data, priority);

			newNode.next = head; //links old list to new node

			head = newNode; //moves head to new node
		}

		//method to print the list
		public void printList(node headref)
		{
			while (headref != null)
			{
				Console.WriteLine("Chore: " + headref.chore + " |Hours To Complete: " + headref.numOfHours + " |Priority Level: " + headref.priority);
				headref = headref.next;
			}
		}
	}
}
