using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Permission_Management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Add 4 users with none permissions (Admin, operator, manager,senior)
            User operatorUser = new User("operator");
            User seniorUser = new User("senior");
            User managerUser = new User("manager");
            User adminUser = new User("admin");
            /**
             * 
             * Add read permission to operatorUser look at line 25 to line 31
             * Add read, write, execute permissions to manager
             * Add read, write permissions to senior
             * Add full permission(read,write,execution) to admin
             */
            // Operator: Read
            operatorUser.AddPermission(Permissions.Read);
            if(operatorUser.HasPermission(Permissions.Read))
                Console.WriteLine("Operator has read permission");
            else
                Console.WriteLine("Operator does not have read permission");

            // Manager: Read, Write, Execute
            managerUser.AddPermission(Permissions.Read);
            managerUser.AddPermission(Permissions.Write);
            managerUser.AddPermission(Permissions.Execute);
            if (operatorUser.HasPermission(Permissions.Execute))
                Console.WriteLine("Manager has execute permission");
            else
                Console.WriteLine("Manager does not have execute permission");

            // Senior: Read, Write
            seniorUser.AddPermission(Permissions.Read);
            seniorUser.AddPermission(Permissions.Write);
            if (seniorUser.HasPermission(Permissions.Write))
                Console.WriteLine("Senior has write permission");
            else
                Console.WriteLine("Senior does not have write permission");

            // Admin: Read, Write, Execute
            adminUser.AddPermission(Permissions.Read);
            adminUser.AddPermission(Permissions.Write);
            adminUser.AddPermission(Permissions.Execute);
            if (adminUser.HasPermission(Permissions.Read | Permissions.Write | Permissions.Execute))
                Console.WriteLine("Admin has full permission");
            else
                Console.WriteLine("Admin does not have full permissions");

            // Remove Write from Senior
            seniorUser.RemovePermission(Permissions.Write);
            /**
             * Look at tasks description in lab3.1 and complete the remaining tasks
             */

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();


        }
    }
}
