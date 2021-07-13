using System.Collections.Generic;

namespace MultiValueDictionary
{
    public class DictionaryApp: IDictionaryApp
    {
        /// <summary>
        /// generic collection to store keys and values.
        /// </summary>
        private Dictionary<string, List<string>> multiValDictionary = new Dictionary<string, List<string>>();

        /// <summary>
        /// Adds an element with the specified key and value into the DictionaryApp.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public string AddMember(string key, string value)
        {
        
                if (!multiValDictionary.ContainsKey(key))
                {
                    multiValDictionary[key] = new List<string>() { value };
                    return "Added";
                }
                else
                {
                    if (!multiValDictionary[key].Contains(value))
                    {
                        multiValDictionary[key].Add(value);
                        return "Added";
                    }
                    else
                    {
                        return "Error: member already exists for key";
                    }

                }
        }

        /// <summary>
        /// Clears all the dictionary elements
        /// </summary>
        /// <returns></returns>
        public string Clear()
        {
            if (multiValDictionary.Count > 0)
                multiValDictionary.Clear();

            return "Cleared";

        }

        /// <summary>
        /// Gets all the members from the dictionary list
        /// </summary>
        /// <returns></returns>
        public List<string> GetAllMembers()
        {
            List<string> lst = new List<string>();
            foreach (var item in multiValDictionary)
            {
                foreach (var ele in item.Value)
                {
                    lst.Add(ele);
                }
            }

            return lst;
        }

        /// <summary>
        /// Gets all the Items from the dictionary list
        /// </summary>
        /// <returns></returns>
        public List<string> GetItems()
        {
            List<string> lst = new List<string>();
            foreach (var item in multiValDictionary)
            {
                foreach (var ele in item.Value)
                {
                    lst.Add(item.Key + ": " + ele);
                }
            }

            return lst;
        }

        /// <summary>
        /// Get Keys.
        /// </summary>
        /// <returns></returns>
        public List<string> GetKeys()
        {
            List<string> lst = new List<string>();
            foreach (var item in multiValDictionary)
            {
                lst.Add(item.Key);
            }

            return lst;
        }

        /// <summary>
        /// Get Members for specific key
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public List<string> GetMembers(string key)
        {
            List<string> lst = new List<string>();
            if (multiValDictionary.ContainsKey(key))
            {
                foreach (var item in multiValDictionary[key])
                {
                    lst.Add(item);
                }
            }          

            return lst;
        }

        /// <summary>
        /// Checks if key exists
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool KeyExists(string key)
        {
            return multiValDictionary.ContainsKey(key);
        }

        /// <summary>
        /// Check if member exists
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool MemberExists(string key, string value)
        {
            if (!multiValDictionary.ContainsKey(key))
            {
                return false;
            }
            else
            {
                return multiValDictionary[key].Contains(value);

            }
        }


        /// <summary>
        /// Remove all the items in the dictionary
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string RemoveAll(string key)
        {
            if (!multiValDictionary.ContainsKey(key))
            {
                return "ERROR, key does not exists";
            }
            else
            {
                multiValDictionary.Remove(key);
                return "Removed";
            }
        }

        /// <summary>
        /// Remove member from the dictionary of the specific key.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public string RemoveMember(string key, string value)
        {
            
            if (!multiValDictionary.ContainsKey(key))
            {
                return "ERROR, key does not exists";
            }
            else
            {
                if (!multiValDictionary[key].Contains(value))
                {

                    return "ERROR, member does not exists";
                }
                else
                {
                    if (multiValDictionary[key].Count == 1)
                        multiValDictionary.Remove(key);
                    else
                        multiValDictionary[key].Remove(value);


                    return "Removed";

                }
            }
        }


        /// <summary>
        /// Count of total items in dictionary app.
        /// </summary>
        /// <returns></returns>
        public int CountAll()
        {
            int counter = 0;
            foreach (var item in multiValDictionary)
            {
                counter += multiValDictionary[item.Key].Count;
            }

            return counter;
        }

    }
}
