using System;
using System.Collections.Generic;
using System.Text;

namespace MultiValueDictionary.BAL
{
    public interface IBusiness
    {
        /// <summary>
        /// Adds an element with the specified key and value into the DictionaryApp.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        string AddMember(string key, string value);

        /// <summary>
        /// Remove member from the dictionary of the specific key.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        string RemoveMember(string key, string value);


        /// <summary>
        /// Clears all the dictionary elements
        /// </summary>
        /// <returns></returns>
        string Clear();

        /// <summary>
        /// Checks if key exists
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        bool KeyExists(string key);

        /// <summary>
        /// Check if member exists
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        bool MemberExists(string key, string value);

        /// <summary>
        /// Gets all the members from the dictionary list
        /// </summary>
        /// <returns></returns>
        List<string> GetAllMembers();

        /// <summary>
        /// Gets all the Items from the dictionary list
        /// </summary>
        /// <returns></returns>
        List<string> GetItems();

        /// <summary>
        /// Remove all the items in the dictionary
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        string RemoveAll(string key);


        /// <summary>
        /// Get Members for specific key
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        List<string> GetMembers(string key);

        /// <summary>
        /// Get Keys.
        /// </summary>
        /// <returns></returns>
        List<string> GetKeys();


        /// <summary>
        /// Count of total items in dictionary app.
        /// </summary>
        /// <returns></returns>
        int CountAll();
    }
}
