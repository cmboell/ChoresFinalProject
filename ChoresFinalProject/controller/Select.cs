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
    public class Select : Menu
    {
      
        public static void select()
        {   //variables
            SinglyLinkedList<String> choresList = new SinglyLinkedList<String>(); //creates new linked list
            PriorityQueue pQ = new PriorityQueue(); //creates new priority queue
            Chore myChore = new Chore(); //creates new chore
            MergeSort sort = new MergeSort(); //creates new merge sort

            string val, chore, priority1, pos1;
            int pos, choice, nextPos, yes = 0;
            double hours;
            char priority;

            
            try
            {
                while (yes == 0) //when user value = 0 the app doesn't end
                {
                    showmenu(); //calls show menu method

                    //output to have user input option from list
                    Console.WriteLine("Enter your choice:");

                    //user input to choose option from menu
                    while (!int.TryParse(Console.ReadLine(), out choice))
                    { //to make sure user choice is a number
                        Console.WriteLine("Please enter a number 1 - 7:");
                    }

                    //switch statement with menu options
                    switch (choice)
                    {
                        case 1: //option to enter a new chore
                            Console.WriteLine("Chore:");

                            chore = Console.ReadLine();

                            Console.WriteLine("Hours to complete:");

                            while (!double.TryParse(Console.ReadLine(), out hours))
                            { //to make sure hours entered is a number
                                Console.WriteLine("Please enter A Valid Amount Of Hours:");
                            }

                            do //do while loop to ensure we get proper input
                            {
                                Console.WriteLine("Priority Level (A-D, A being highest priority):");
                                //priority input                                
                                priority1 = Console.ReadLine().ToUpper();
                            }
                            while (priority1 != "A" && priority1 != "B" && priority1 != "C" && priority1 != "D");
                            priority = Convert.ToChar(priority1); //converts our priority to char

                            //assigning value
                            nextPos = choresList.count() + 1;

                            Console.WriteLine("Position In List:");
                            do //do while loop to ensure we get proper input
                            {
                                Console.WriteLine("(Enter 1 To Put In Front Of List Or " + nextPos.ToString() + " To Put At End Of List)"); ;
                                pos1 = Console.ReadLine();
                            }
                            while (pos1 == "0" || pos1 != "1" && pos1 != nextPos.ToString());
                            pos = Convert.ToInt32(pos1);

                            //assigns values
                            myChore.setName(chore);
                            myChore.setHourstToComplete(hours);
                            myChore.setPriorityLevel(priority);

                            //adding to each thing
                            pQ.enqueue(chore, hours, priority);

                            val = myChore.toString();

                            choresList.insert(val, pos);

                            sort.push(chore, hours, priority);
                            break;

                        case 2: //option to list all chores in list
                            Console.WriteLine("Current Chores In List:");
                            choresList.printall();
                            break;

                        case 3: //option to sort chores by priority
                            Console.WriteLine("Chores Sorted By Priority:");
                            pQ.printQueue();
                            break;

                        case 4: //sort the chores list by hours
                            sort.head = sort.mergeSort(sort.head);
                            Console.Write("\n Sorted By Hours To Complete : \n");
                            sort.printList(sort.head);
                            break;

                        case 5: //option to see total number of chores
                            Console.WriteLine("Number of items:" + choresList.count());
                            break;

                        case 6: //option to remove a chore from the list by position
                            Console.WriteLine("Position Of Chore You Would Like To Remove:");
                            //exception handling to make sure we get a number
                            while (!int.TryParse(Console.ReadLine(), out pos))
                            { //to make sure user choice is a number
                                Console.WriteLine("Please enter a valid number:");
                            }
                            choresList.delete(pos);
                            break;

                        case 7: //option to exit
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Invalid, Please Enter A Number 1-7:");
                            break;
                    }

                    Console.WriteLine("Press 0 To Select Another Choice:");
                    Console.WriteLine("(Press Another Number To Exit)");
                    yes = Convert.ToInt32(Console.ReadLine());//input for users choice
                }
            }
            catch (Exception e) //error exception
            {
                Console.WriteLine(e);
                Environment.Exit(100);

            }
        }
    }
}
