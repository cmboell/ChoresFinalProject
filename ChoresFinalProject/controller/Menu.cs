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
    public class Menu
    {
        //methods
        public static void showmenu()
        {
            //prints out menu options
            Console.WriteLine("Select A Chores List Option");
            Console.WriteLine("____________________________");
            Console.WriteLine("1: Add A Chore ");
            Console.WriteLine("2: View Chores In The List");
            Console.WriteLine("3: View Chores By Priority");
            Console.WriteLine("4: Sort Chores By Hours");
            Console.WriteLine("5: Show Total Amount Of Chores");
            Console.WriteLine("6: Remove A Chore");
            Console.WriteLine("7: Exit");
        }
    }
}
