using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Adding Exceptions 
namespace Data_Structures
{
    interface Exceptions : System.Exception
    {
        virtual string name;
    }

    class EmptyListException: System.Exception, Exceptions  
    {

        public EmptyListException(string nameObject): base ("The " + nameObject + "is empty")
        { 
        
        
        }
    
    }
}
