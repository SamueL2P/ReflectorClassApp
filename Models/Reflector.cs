using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectorClassApp.Models
{
    internal class Reflector
    {
        public string ShowDetails(Type type)
        {

            //GetMethods contains methods for getter , setter properties ,
            //user defined methods , base class System.Object

            //Using Binding Flags and where condition we can also diplay only user defined methods.

            //var userMethods = type.GetMethods(
            // BindingFlags.Public |
            // BindingFlags.Instance |
            // BindingFlags.Static |
            // BindingFlags.DeclaredOnly).Where(m => !m.IsSpecialName).Count();
            
            //without this the GetMethods will return 
            //1.User Defined Methods. 
            //2.Methods of base Class System.Object. eg : GetHashCode , GetType , etc
            //3.Methods for setter and getter properties. 

            return $"\nClass : {type.Name} \nMethods : {type.GetMethods().Length } " +
                $"\nConstructors : {type.GetConstructors().Length} \nProperties : {type.GetProperties().Length}";
            
        }

      
    }
}
