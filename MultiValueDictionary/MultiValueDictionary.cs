using Microsoft.Extensions.DependencyInjection;
using MultiValueDictionary.BAL;
using System;
using System.Collections.Generic;

namespace MultiValueDictionary
{
    public class MultiValueDictionary 
    {               
        static void Main(string[] args)
        {
            //setup our DI
            var serviceProvider = new ServiceCollection()
           .AddSingleton<IBusiness, Business>()
           .AddSingleton<IDictionaryApp, DictionaryApp>()
           .BuildServiceProvider();

            //do the actual work here
            var businessObj = serviceProvider.GetService<IBusiness>();
            Console.WriteLine("Enter action, key and values to add to multi valued dictionary");
            string enteredString;
            do 
            { 
                //capturing the string the is entered on the command line.
                enteredString = Console.ReadLine();
                //calling specific service to do the action.
                InvokeResource(enteredString, businessObj);

            } while (!String.IsNullOrEmpty(enteredString));
             
        }

        /// <summary>
        /// Common functionality to print list of items, if empty returns empty result statement.
        /// </summary>
        /// <param name="items"></param>
        private static void GetData(List<string> items)
        {
            if (items.Count > 0)
            {
                for (int i = 0; i < items.Count; i++)
                {
                    Console.WriteLine((i+1) + ") " + items[i]);
                }
            }
            else
            {
                Console.WriteLine("(empty set)");
            }
        }

        /// <summary>
        /// Checks if provided string is valid entry 
        /// </summary>
        /// <param name="keywords"></param>
        /// <returns></returns>
        private static bool isValidEntry(string[] keywords)
        {
            var action = keywords[0].Trim().ToUpper();

            if (action == "ADD" || action == "REMOVE" || action == "MEMBEREXISTS")
                return keywords.Length == 3;

            if (action == "MEMBERS" || action == "REMOVEALL" || action == "KEYEXISTS")
                return keywords.Length == 2;

            if (action == "KEYS" || action == "CLEAR" || action == "ALLMEMBERS" || action == "ITEMS" || action == "COUNTALL")
                return keywords.Length == 1;

            return false;
        }

        /// <summary>
        /// Calling specific service to do the action.
        /// </summary>
        /// <param name="enteredString"></param>
        /// <param name="businessObj"></param>
        private static void InvokeResource(string enteredString,IBusiness businessObj)
        {

            if (String.IsNullOrEmpty(enteredString))
                Console.WriteLine("");

            var keywords = enteredString.Split(' ');

            if (isValidEntry(keywords))
            {
                var action =keywords.Length>0 ? keywords[0].Trim().ToUpper() : "";
                var key = keywords.Length>1? keywords[1].Trim().ToLower() : "";
                var value =keywords.Length>2? keywords[2].Trim().ToLower() : "";
                switch (action)
                {
                    case "ADD":
                        Console.WriteLine(businessObj.AddMember(key, value));
                        break;
                    case "REMOVE":
                        Console.WriteLine(businessObj.RemoveMember(key, value));
                        break;
                    case "MEMBEREXISTS":
                        Console.WriteLine(businessObj.MemberExists(key, value));
                        break;
                    case "MEMBERS":
                        var data = businessObj.GetMembers(key);
                        if (data.Count == 0)
                        {
                            Console.WriteLine("ERROR, key does not exist.");
                        }
                        else
                        {
                            foreach (var item in data)
                            {
                                Console.WriteLine(item);
                            }
                        }
                        break;
                    case "REMOVEALL":
                        Console.WriteLine(businessObj.RemoveAll(key));
                        break;
                    case "KEYEXISTS":
                        Console.WriteLine(businessObj.KeyExists(key));
                        break;
                    case "KEYS":
                        GetData(businessObj.GetKeys());
                        break;
                    case "CLEAR":
                        Console.WriteLine(businessObj.Clear());
                        break;
                    case "ALLMEMBERS":
                        GetData(businessObj.GetAllMembers());
                        break;
                    case "ITEMS":
                        GetData(businessObj.GetItems());
                        break;
                    case "COUNTALL":
                        Console.WriteLine(businessObj.CountAll());
                        break;
                    default:
                        Console.WriteLine("Invalid Entry");
                        break;
                }


            }
            else
            {
                Console.WriteLine("Invalid Entry");
            }


        }


    }
}
