using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PlanningPatterns.Serialization
{
    internal class DataContractExample
    {
        [DataContract]

        class Person
        {
            [DataMember]
            string LastName { get; set; }
            [DataMember]
            string FirstName { get; set; }

            public Person(string firstNameValue, string lastNameValue)
            {
                FirstName = firstNameValue;
                LastName = lastNameValue;
            }
        }
        [DataContract]
        
        class Person2 
        {
            [DataMember]
            string lastName;

            [DataMember]
            string firstName;

            string fullName;
            public string FullName { get => fullName; }

            //this ctor isn't call during deserealization
            public Person2(string lastName, string firstName)
            {
                this.lastName = lastName;
                this.firstName = firstName;
                fullName = firstName + " " + lastName;
            }
            //this method is called after the object is completely deserealized.
            //use it instead the ctor
            [OnDeserialized]
            void OnDeserialized(StreamingContext context)
            {
                fullName = firstName + " " + lastName;
            }
        }
    }
}
