using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace DZ_Less8_3
{
    [Serializable]
    public class QuestTrueFalse
    {
        public string quest;
        public bool trueFalse;
        public QuestTrueFalse() { }
        public QuestTrueFalse(string quest, bool answer)
        {
            this.quest = quest;
            trueFalse = answer;
        }
    }

    public class ListQuests
    {
        public delegate void onEvent(object sender);
        public delegate void onError(string message);
        public delegate void onCreate();
        public delegate void onAdd(string quest, bool answer);
        public delegate void onRemove(int index);

        public event onEvent OnLoad;
        public event onEvent OnSave;
        public static event onEvent OnCreate;
        public event onAdd OnAdd;
        public event onRemove OnRemove;
        public event onError OnError;

        string fileName;
        List<QuestTrueFalse> list;
        bool changed = false;

        public string FileName { set { fileName = value; } }

        public ListQuests (string fileName)
        {
            this.fileName = fileName;
            list = new List<QuestTrueFalse>();
            OnCreate?.Invoke(this);
        }

        public void Add(string quest, bool answer)
        {
            list.Add(new QuestTrueFalse(quest, answer));
            changed = true;
            OnAdd?.Invoke(quest, answer);
        }

        public void Remove(int index)
        {
            if (list != null && index < list.Count && index >= 0)
            {
                list.RemoveAt(index);
                changed = true;
                OnRemove?.Invoke(index);
            }
        }

        public QuestTrueFalse this[int index]
        {
            get { return list[index]; }
        }

        public void Save()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<QuestTrueFalse>));
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
            changed = false;
            OnSave?.Invoke(this);
        }

        public void SaveAs(string fileName)
        {
            this.fileName = fileName;
            Save();
        }

        public void Load()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<QuestTrueFalse>));
            Stream fStream;
            try
            {
                fStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            }
            catch
            {
                OnError?.Invoke(string.Format("Ошибка открытия файла \"{0}\"",fileName));
                return;
            }
            list = (List<QuestTrueFalse>)xmlFormat.Deserialize(fStream);
            fStream.Close();
            OnLoad?.Invoke(this);
        }

        public int Count
        {
            get { return list.Count; }
        }

        public bool Changed
        {
            get { return changed; }
        }
    }
}
