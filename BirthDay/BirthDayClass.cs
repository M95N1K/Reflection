using System;
using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;
using System.Windows.Forms;

namespace BirthDay
{
    [Serializable]
    public class BirthDayClass
    {
        public string name;
        public string firstname;
        //public DateTime birthday;
        public int year;
        public int month;
        public int day;
        internal int NumOfYear
        {
            get {
                DateTime current = DateTime.Now;
                return current.Year - this.year;
            }
        }
        public BirthDayClass(){ }
        public BirthDayClass(string name, string firstname, DateTime birthDay)
        {
            this.name = name;
            this.firstname = firstname;
            this.year = birthDay.Year;
            this.month = birthDay.Month;
            this.day = birthDay.Day;
        }
    }

    public class ListBirthDay
    {
        public delegate void onEvent(object sender);
        public delegate void onAdd(string name, string firstname, DateTime birthDay);
        public delegate void onRemove(int index);
        public delegate void onError(string message);

        public event onEvent OnLoad;
        public event onAdd OnAdd;
        public event onRemove OnRemove;
        public event onError OnError;
        readonly string fileName = "data.xml";
        
        List<BirthDayClass> list;
        
        
        public bool Changed
        {
            get { return changed; }
        }
        bool changed = false;

        public ListBirthDay()
        {
            list = new List<BirthDayClass>();
        }

        public void Add(string name, string firstname, DateTime birthDay)
        {
            list.Add(new BirthDayClass(name, firstname, birthDay));
            changed = true;
            OnAdd?.Invoke(name, firstname, birthDay);
        }

        public void Remove(int index)
        {
            list.RemoveAt(index);
            changed = true;
            OnRemove?.Invoke(index);
        }

        public BirthDayClass this[int index]
        {
            get { return list[index]; }
        }

        public int Count
        {
            get { return list.Count; }
        }

        public void Save()
        {
            BirthDaySerialize(fileName, list);
            changed = false;
        }

        public void Load()
        {
            list = BirthDayDesirealize(fileName);
            if (list != null)
                OnLoad?.Invoke(this);
        }

        public void Import(string fileName)
        {
            List<BirthDayClass> importList = BirthDayDesirealize(fileName);
            int count = Count;
            bool comp = false;
            for (int i = 0; i < importList.Count; i++)
            {
                comp = true;
                for (int c = 0; c < count; c++)
                {
                    if (Compar(this[c], importList[i]))
                    {
                        comp = false;
                    }
                }
                if (comp)
                {
                    DateTime tmp = new DateTime(importList[i].year, importList[i].month, importList[i].day);
                    Add(importList[i].name, importList[i].firstname, tmp);
                }
            }
        }

        public void Export(string fileName)
        {
            BirthDaySerialize(fileName, list);
        }

        private bool Compar(BirthDayClass firstRec, BirthDayClass secondRec)
        {
            if (firstRec.day == secondRec.day && firstRec.month == secondRec.month && firstRec.year == secondRec.year
                && firstRec.name == secondRec.name && firstRec.firstname == secondRec.firstname)
                return true;
            return false;
        }

        public List<BirthDayClass> CurrentBirthDay(DateTime date)
        {
            List<BirthDayClass> result = new List<BirthDayClass>();
            DateTime current = date;
            for (int i = 0; i < Count; i++)
            {
                if (this[i].day == current.Day && this[i].month == current.Month)
                    result.Add(this[i]);
            }
            return result;
        }

        private List<BirthDayClass> BirthDayDesirealize(string fileName)
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<BirthDayClass>));
            Stream fStream;
            List<BirthDayClass> tmp;
            try
            {
                fStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                tmp = (List<BirthDayClass>)xmlFormat.Deserialize(fStream);
            }
            catch
            {
                OnError?.Invoke(string.Format("Ошибка открытия файла \"{0}\"", fileName));
                return null;
            }

            fStream.Close();
            return tmp;
        }

        private void BirthDaySerialize(string fileName , List<BirthDayClass> list)
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<BirthDayClass>));
            Stream fStream;
            try
            {
                fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            }
            catch
            {
                OnError?.Invoke(string.Format("Ошибка сохранения файла \"{0}\"", fileName));
                return;
            }
            xmlFormat.Serialize(fStream, list);
            fStream.Close();
        }

        public void IsNotSave()
        {
            if (!changed)
                return;
            if (MessageBox.Show("Файл не сохранен!!!\nХотите его сохранить?", "Внимание!!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Save();
        }
    }
}
