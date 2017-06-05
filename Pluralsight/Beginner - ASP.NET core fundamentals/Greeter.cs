using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood
{
    //the interface describes the capabilities of every Greeter.
    //An interface is defined as a syntactical contract that all the classes inheriting the interface should follow. 
    //The interface defines the 'what' part of the syntactical contract and the deriving classes define the 'how' part of the syntactical contract.
    //Interfaces contain only the declaration of the members. It is the responsibility of the deriving class to define the members. 
    //It often helps in providing a standard structure that the deriving classes would follow.
    //Interface statements are public by default.
    //We are using the concept of an interface so that the implementation is not tied to a particular implementation of a Greeter. So, interface doesn't care if info comes from a JSON file or an XML web service
    public interface IGreeter 
    {
        string GetGreeting();//Every Greeter has the ability to get a greeting.
    }
    public class Greeter : IGreeter
    {
        public string GetGreeting()
        {
            return "Hello from Greeter!";
        }
    }
}
