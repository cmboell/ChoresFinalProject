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
	public class SinglyLinkedList<T> : ChoresList<T>
	{
		public SinglyLinkedList()
		{
			first = last = null;
		}

		public bool isEmpty() {
			return count() == 0;
		}
		public void insert(T val, int pos)//inserts item 
		{
			ListNode<T> newnode = new ListNode<T>(val); //empty list   
			if (first == null && last == null)
			{
				newnode.next = null;
				first = newnode;
				last = newnode;
				Console.WriteLine("Inserted:" + newnode.val);
			}
			else if (pos == 1)//insertion at beginning of list
			{
				newnode.next = first;
				first = newnode;
				Console.WriteLine("Added: " + newnode.val);//confirms we have added to list
			}
			else if (pos > 1 && pos < count())
			{
				ListNode<T> ta;
				ta = first;
				for (int t = 1; t < pos - 1; t = t + 1)
				{
					ta = ta.next;
				}
				newnode.next = ta.next;
				ta.next = newnode;
				Console.WriteLine("Added: " + newnode.val);
			}
			else if (pos == count() + 1)
			{
				newnode.next = null;
				//The next link of the item is null
				last.next = newnode;
				last = newnode;
				Console.WriteLine("Added: " + newnode.val);
			}
			else Console.WriteLine("Invalid position!");
		}
		//delete item   
		public void delete(int pos)
		{
			if (count() > 0)
			{
				//make sure the list is not empty.
				ListNode<T> temp, del;
				if (pos == 1)
				{
					if (count() == 1)//deletes first item
					{
						first = null; //if only one item in list
						last = null;
					}
					else
					{
					   //list with more than one item
						temp = first;
						first = first.next;
						temp = null;
					}
					Console.WriteLine("Deleted Chore"); //confirms deleted
				}
				else if (pos > 1 && pos <= count())
				{
					temp = first;
					int i;
					for (i = 1; i < pos - 1; i = i + 1)
					{
						temp = temp.next;
					}
					del = temp.next;
				    //item to be deleted
					temp.next = del.next;
					if (del.next == null) last = temp; //delete last item
					del = null;
					Console.WriteLine("Deleted Chore");
				}
				else Console.WriteLine("Invalid position!");
			}
			else Console.WriteLine("No item found");
		}
		//method that counts chores in list
		public int count()
		{
			ListNode<T> i;
			int t = 0;
			for (i = first; i != null; i = i.next)
			{
				t = t + 1;
			}
			return t;
		}
		//method that shows all chores
		public void printall()
		{
			ListNode<T> t;
			if (count() > 0)
			{
				Console.WriteLine("All items in the list:");
				for (t = first; t != null; t = t.next)
				{
					Console.WriteLine(t.val);
				}
			}
			else Console.WriteLine("No item found!");
		}

	}
}



