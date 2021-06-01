using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;

using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Application.Files.Xml
{
    public class Xml<T> : IFile<T>
    {
        //private readonly string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\";

        //TODO implementar IFile --> Ok
        public bool Read(string file, out T data)
        {
            data = default;
            bool readData = false;
            try
            {
                if (File.Exists(file))
                {
                    using (XmlTextReader auxReader = new XmlTextReader(file))
                    {
                        XmlSerializer nuevoXml = new XmlSerializer(typeof(T));
                        data = (T)nuevoXml.Deserialize(auxReader);
                        readData = true;
                    }
                }
            }
            catch (FileNotFoundException exFile)
            {
                throw exFile;
            }
            return readData;
        }

        public bool Save(string file, T data)
        {
            bool saveData = false;
            try
            {
                using (XmlTextWriter auxWriter = new XmlTextWriter(file, Encoding.UTF8))
                {
                    XmlSerializer nuevoXml = new XmlSerializer(typeof(T));
                    nuevoXml.Serialize(auxWriter, data);
                    saveData = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return saveData;
        }
    }
}
