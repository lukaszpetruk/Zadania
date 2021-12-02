using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Ksiegowosc
{
    [Serializable]
    class Workers
    {
        public string workerName { get; set; }
        public string Results { get; set; }
        public DateTime when { get; set; }
        public string sourcePath = @"C:\Users\xopero\source\repos\Zadania\Ksiegowosc\Pracownicy\";
        public Workers()
        {
            sourcePath = "";
        }
        public Workers(string sourcePath)
        {
            OpenFile(sourcePath);
        }
        private void OpenFile(string sourcePath)
        {
            this.sourcePath = sourcePath;
            BinaryFormatter formatter = new BinaryFormatter();
            Workers tempWorkers;
            using (Stream input = File.OpenRead(sourcePath))
            {
                tempWorkers = (Workers)formatter.Deserialize(input);
            }
            workerName = tempWorkers.workerName;
            Results = tempWorkers.Results;
            when = tempWorkers.when;
        }
     
        public void Save(string fileName)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (Stream output = File.OpenWrite(fileName))
            {
                formatter.Serialize(output, this);
            }
        }
    }
}
