using System.Data.Entity;

//USING THIS DATAMODEL WE CAN ACCESS/MAKE INTERACTION WITH DATABASE AND DIFF API USING EF6
//We will add EF6 into this project.



namespace LoginDomain.DataModel
{
    /*So LoginContext will manage everything but yet DbContext  is not aware about our class like "User" class from Classes layer*/

    /* Diff function of DbContext API in EF's:
     * DbContext Class in this API : Orchestration all task like
     *                               Mapping class to database schema
     *                               Translate and Execute Queries
     *                               Track changes
     *                               Execute updates.
    */


    /*  Another Critical Class in this EF'S api is DbSet 
        DbSet - Organization Unit which maintains a particular set of types ( Here class - Users.)
                DbSet<User>
                DbSet is Same like repository(Concepts).
                Responsibilities : Maintain In-Memory collection of entity. [Here -- Collection of Users.]
                    Collection of any entity in our Model.
    */



    /*  Perform query through DbSets. Asking DbContext to query against DbSet<Users>
     *  And in turn EF interpretes into the database query.
     *  So when we define DbContext we need to tell Which DbSets into this model.
     *  so we will tell by below line
     *  public DbSet<Users> User{get;set;}
    */

    public class LoginContext : DbContext
    {

    }
}
