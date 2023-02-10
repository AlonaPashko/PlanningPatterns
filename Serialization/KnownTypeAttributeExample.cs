using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PlanningPatterns.Serialization
{
    internal class KnownTypeAttributeExample
    {
        //the KnownTypeAttribute specifies types to be used during deserialization
        [KnownType(typeof(USAddress))]
        
        [DataContract]
        
        class Person3
        {
            [DataMember]
            string fullNameValue;
            [DataMember]
            Address address; //adress is abstract
        }

        [DataContract]
        public class USAddress : Address
        {
            public override string FullAdress => throw new NotImplementedException();
        }

    }
}
