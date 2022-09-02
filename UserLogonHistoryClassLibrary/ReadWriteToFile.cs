using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UserLogonHistoryClassLibrary
{
    public class ReadWriteToFile
    {
        private string _path;
        private string fileName = "data.txt";
        private string[] _dataFromFileArray;
        private StringBuilder _sb;
        private StreamWriter _sw;


        public List<string> ReadFile()
        {
            _path = Path.Combine(Environment.CurrentDirectory, fileName);
           
            if (!File.Exists(_path))
            {
                using (_sw = File.CreateText(_path))
                {
                }
                _sw.Close();

                return new List<string>();
            }

            _dataFromFileArray = File.ReadAllLines(fileName);

            List<string> samletListe = new List<string>(_dataFromFileArray);

            return samletListe;
        }

        //Method save 
        public void SaveToFile(List<string> saveList)
        {
            _path = Path.Combine(Environment.CurrentDirectory, fileName);

            foreach (var item in saveList)
            {
                _sb.Append(item + ";");
            }

            if (!File.Exists(_path))
            {
                using (_sw = File.CreateText(_path))
                {
                    _sw.Write(_sb.ToString().TrimEnd(';'));
                }
            }
            else
            {
                using (_sw = File.AppendText(_path))
                {
                    _sw.Write("\n" + _sb.ToString().TrimEnd(';'));
                }
            }
            _sw.Close();
        }


    }//Class end
}
