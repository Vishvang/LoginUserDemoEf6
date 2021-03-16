using System.Data.Entity;

//USING THID DATAMODEL WE CAN ACCESS/MAKE INTERACTION WITH DATABASE AND DIFF API USING EF6
//We will add EF6 into this project.

namespace LoginDomain.DataModel
{
    //So LoginContext will manage everything but still yet dbcontext  is not aware about our class like 
    //"User" class from Classes layer

    public class LoginContext:DbContext
    {
        
    }
}
