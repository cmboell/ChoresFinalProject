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
    class Program : Select
    { 
        //main method
        public static void Main(String[] args)
        {
            //output
            Console.WriteLine("!Chores List!");
            Console.WriteLine("____________________________");
            //calls menu method
            select();
        }
    }
}

