using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.CodeDom;
using System.Reflection;
using System.Diagnostics.Eventing.Reader;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Collections.Concurrent;

namespace GRHW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customerList = getCustomerList();
            
            Console.WriteLine("How would you like to sort? \n a. Sort by sorted by favorite color then by last name ascending \n b. sorted by birth date, ascending.\n c.sorted by last name, descending\n Please Type either 'A', 'B' or 'C'. ");
           string optionPicked =  Console.ReadLine();
            List<Customer> sortedList = sortTheList(optionPicked, customerList);
            foreach (var item in sortedList)
            {
                
                //LastName FirstName Email FavoriteColor DateOfBirth
                Console.WriteLine(item.LastName + " " + item.FirstName + " " + item.Email + " " + item.FavoriteColor + " " + string.Format("{0:M/D/YYYY}", item.DateOfBirth));
            }
           

            Console.ReadLine();



            // Give  option of how it should be printed (sorting options)
        }

        public static List<Customer> sortTheList(string answer, List<Customer> list)
        {
            if (answer == "A")
            {
                var firstSortedList = list.OrderBy(x => x.FavoriteColor).ToList();
                
                var sortedListA = firstSortedList.OrderBy(x => x.LastName).ToList();
                
                return sortedListA;
            } else if (answer == "B")
            {
                var sortedListB = list.OrderBy(x => x.DateOfBirth).ToList();
                return sortedListB;
            } else if (answer == "C")
            {
                var sortedListC = list.OrderBy(x => x.LastName).ToList();
                return sortedListC;
            }

            return list;
        }

        

        public static List<Customer>  getCustomerList ()
        {
            List<Customer> listOfCustomers = new List<Customer>();
            string line;
            string[] customerData;
            //string filepathname;
            try
            {
            for(int i = 0; i <3; i++)
                {

            //Receive input of file path 
            Console.WriteLine("Please Enter the .txt File Path. Please Format with Double \\ between each folder (instead of 1)'");
            string filepath = Console.ReadLine();
            
            //Read file and parse out data into object - making sure they are in the same format
            System.IO.StreamReader file = new System.IO.StreamReader(filepath);
            while ((line = file.ReadLine()) != null && line != "")
            {
                if (line.Contains(','))
                {
                    customerData = line.Split(',');

                }
                else if (line.Contains('|'))
                {
                    customerData = line.Split('|');
                }
                else
                {
                    customerData = line.Split(' ');
                }

                Customer item = new Customer();
                item.LastName = customerData[0];
                item.FirstName = customerData[1];
                item.Email = customerData[2];
                item.FavoriteColor = customerData[3];
                item.DateOfBirth = customerData[4];

                listOfCustomers.Add(item);

            }

                    file.Close();


                }
                

            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return listOfCustomers;
        }

    }
 }

