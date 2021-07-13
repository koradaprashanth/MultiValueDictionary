using System.Collections.Generic;

namespace MultiValueDictionary.BAL
{
    public class Business : IBusiness
    {
        private readonly IDictionaryApp _dictionaryApp;

        /// <summary>
        /// Constructor to pass dictionary app object.
        /// </summary>
        /// <param name="dictionaryApp"></param>
        public Business(IDictionaryApp dictionaryApp)
        {
            _dictionaryApp = dictionaryApp;
        }

        /// <summary>
        /// Adds an element with the specified key and value into the DictionaryApp.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public string AddMember(string key, string value)
        {
            return _dictionaryApp.AddMember(key, value);
        }

        /// <summary>
        /// Clears all the dictionary elements
        /// </summary>
        /// <returns></returns>
        public string Clear()
        {
            return _dictionaryApp.Clear();
        }

        /// <summary>
        /// Gets all the members from the dictionary list
        /// </summary>
        /// <returns></returns>
        public List<string> GetAllMembers()
        {
            return _dictionaryApp.GetAllMembers();
        }

        /// <summary>
        /// Gets all the Items from the dictionary list
        /// </summary>
        /// <returns></returns>
        public List<string> GetItems()
        {
            return _dictionaryApp.GetItems();
        }

        /// <summary>
        /// Get Keys.
        /// </summary>
        /// <returns></returns>
        public List<string> GetKeys()
        {
            return _dictionaryApp.GetKeys();
        }

        /// <summary>
        /// Get Members for specific key
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public List<string> GetMembers(string key)
        {
            return _dictionaryApp.GetMembers(key);
        }

        /// <summary>
        /// Checks if key exists
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool KeyExists(string key)
        {
            return _dictionaryApp.KeyExists(key);
        }

        /// <summary>
        /// Check if member exists
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool MemberExists(string key, string value)
        {
            return _dictionaryApp.MemberExists(key, value);
        }

        /// <summary>
        /// Remove all the items in the dictionary
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string RemoveAll(string key)
        {
            return _dictionaryApp.RemoveAll(key);
        }

        /// <summary>
        /// Remove member from the dictionary of the specific key.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public string RemoveMember(string key, string value)
        {
            return _dictionaryApp.RemoveMember(key, value);
        }


        /// <summary>
        /// Count of total items in dictionary app.
        /// </summary>
        /// <returns></returns>
        public int CountAll()
        {
            return _dictionaryApp.CountAll();
        }
    }
}
