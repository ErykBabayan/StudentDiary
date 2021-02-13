using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace StudentDiary
{
    class FileHelper<T> where T : new() // T = Typ generyczny czyli typ obiektu Lista string int itd itd zostanie podane przy tworzeniu obiektu
    {                                   // where ()
        private string _filePath;


        public FileHelper(string filePath) // ścieżka do pliku będzie przekazywana przez konstruktor dlatego, że przy tworzeniu obiektu
        {                                  // i TEJ klasy zostanie przekazana scieżka z klasy MAIN
            _filePath = filePath;
        }

        public void SerializeToFile(T students)
        {
            var serializer = new XmlSerializer(typeof(T)); // przypisanie do zmiennej serializer

            using (var streamWriter = new StreamWriter(_filePath)) // streamWriter w using dla samoczynnego wywołania metody dispose
            {
                serializer.Serialize(streamWriter, students);
                streamWriter.Close();
            }
        }

        public T DeserializeFromFile()
        {
            if (!File.Exists(_filePath))
            {
                return new T();
            }

            var deserializer = new XmlSerializer(typeof(T));

            using (var streamReader = new StreamReader(_filePath))
            {
                var students = (T)deserializer.Deserialize(streamReader);
                streamReader.Close();
                return students;

            }


        }


    }
}
