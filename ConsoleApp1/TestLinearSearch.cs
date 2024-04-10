using System;

namespace ConsoleApp1
{
    class TestLinearSearch
    {
        static void Main(string[] args)
        {
            int searchInt; //search Key
            int position; //loction of search key in array

            //create array and output it
            LinearArray SearchArray = new LinearArray(10);
            //input frist int from user
            Console.WriteLine(SearchArray);

            //create array and output it
            Console.Write("please enter an intger value ( -1 to quit): ");
            searchInt = Convert.ToInt32(Console.ReadLine()); //display array

            //repeatedly input an intger; -1 trminates the app
            while (searchInt != -1)
            {
                //perform linear search
                position = SearchArray.LinearSearch(searchInt);
                if (position != -1)
                    Console.WriteLine("the intger {0} was found in postoin {1}. \n" ,
                        searchInt,position
                        );
                else //intger was not found
                    Console.WriteLine("the intger {0} was not found in postoin {1}. \n",
                        searchInt
                        );
                //input next int from user
                Console.Write("please enter an integer value (-1 to quite): ");
                searchInt = Convert.ToInt32(Console.ReadLine());
            }

        }
    }
 }



