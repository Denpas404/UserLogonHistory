using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLogonHistoryClassLibrary;

namespace UserLogonHistoryConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FindAndCombindData findAndCombindData = new FindAndCombindData();
            ReadWriteToFile readWriteToFile = new ReadWriteToFile();


            foreach (var item in findAndCombindData.ReturnData())
            {
                Console.WriteLine(item);
            }




            



            

            Console.ReadLine();
        }

        private void SearchADForLastLogOn()
        {
            /*
            TEST TEST TEST
            */

            //DirectorySearcher search = new DirectorySearcher("LDAP://DC=my,DC=domain,DC=com");
            //search.Filter = "(SAMAccountName=MyAccount)";
            //search.PropertiesToLoad.Add("lastLogonTimeStamp");


            //SearchResult searchResult = search.FindOne();


            //long lastLogonTimeStamp = long.Parse(searchResult.Properties["lastLogonTimeStamp"][0].ToString());
            //DateTime lastLogon = DateTime.FromFileTime(lastLogOn);


            //Console.WriteLine("The user last logged on at {0}.", lastLogon);        }
        } //Virker ikke endnu 
    }
}
