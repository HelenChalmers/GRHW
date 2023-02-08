using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.CodeDom;
using System.Reflection;
using System.Diagnostics.Eventing.Reader;

namespace GRHW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create customer object 
            //Receive input of file path 
            Console.WriteLine("Please Enter the .txt File Path. Please Format with Double \\ between each folder (instead of 1)'");
            string filepath = Console.ReadLine();

            //Read file and parse out data into object - making sure they are in the same format
            string line;
            string[] customerData;
            List<Customer> listOfCustomers = new List<Customer>();
            System.IO.StreamReader file = new System.IO.StreamReader(filepath);
            while ((line = file.ReadLine()) != null)
            {
                if (line.Contains(','))
                {
                    customerData = line.Split(',');

                }else if (line.Contains('|'))
                {
                    customerData = line.Split('|');
                }else
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
            //Combine
            // Give  option of how it should be printed (sorting options)

        }

    }
 }

