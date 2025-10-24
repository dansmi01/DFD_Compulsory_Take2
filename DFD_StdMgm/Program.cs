// See https://aka.ms/new-console-template for more information
using DFD_StdMgm;

namespace StudentMgm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AppDbContext())
            {
                
                //needs to be run for changes to be executed
                context.SaveChanges();

                //output the models from the memory database 
                //Done as a wau of testing if model flow where funtioning correct.
                //var allStudents = context.Students.ToList();
            }
        }
    }
}