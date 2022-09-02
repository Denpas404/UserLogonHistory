using System;
using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogonHistoryClassLibrary
{
    public class FindAndCombindData
    {
        private string _userName;
        private string _machineName;

        private List<string> _combinedList;
                
        private DateTime _date;
        
               
        private void ExtractData()
        {
            _userName = UserPrincipal.Current.DisplayName;
            _machineName = Environment.MachineName;
            
            _date = DateTime.Now;
        }

        private void CombindDataToListOfList()
        {
            _combinedList = new List<string>();
            _combinedList.Add(_userName);
            _combinedList.Add(_machineName);
            _combinedList.Add(_date.ToString("HH:mm"));
            _combinedList.Add(_date.ToString("dd-MM-yyyy"));

        }

        public List<string> ReturnData()
        {
            ExtractData();
            CombindDataToListOfList();

            return _combinedList;
        }
    }
}
