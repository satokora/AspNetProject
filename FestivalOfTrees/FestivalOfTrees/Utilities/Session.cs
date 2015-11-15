using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FestivalOfTrees.Utilities
{
    public class Session : ISession
    {
        //Hashtable to store the values..
        Hashtable hsValues = new Hashtable();
        //Default constructor
        public Session()
        {
        }
        public object getAttribute(string strKey)
        {
            //get the value for the key specified
            return hsValues[strKey];
        }
        public void setAttribute(string strKey, Object objValue)
        {
            //add a new value, if the key already exists then it will //be overridden
            hsValues.Add(strKey, objValue);
        }
        public object removeAttribute(string strKey)
        {
            object obj = hsValues[strKey]; //fetch the value
            hsValues.Remove(strKey);
            return obj; //return the value that is removed
        }
    }
}