using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;

namespace BNSBlacklistRecordGenerator
{
    [DataContract]
    public class DictionarySerializer
    {
        [DataMember]
        public Dictionary<string,string> Map_list {set; get;}
    
        public DictionarySerializer()
        {
            Map_list = new Dictionary<string, string>();
        }

        public DictionarySerializer(Dictionary<string,string> dic)
        {
            Map_list = dic;
        }

        private static DataContractSerializer serializer;

        public static void Serialize(string filePath, DictionarySerializer sTest)
        {
            serializer = new DataContractSerializer(typeof(DictionarySerializer));

            using (var writer = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                serializer.WriteObject(writer, sTest);
            } 
        }
   
        public static DictionarySerializer DeSerialize(string filePath)
        {
            serializer = new DataContractSerializer(typeof(DictionarySerializer));

            DictionarySerializer serializeTest;

            using (var reader = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                serializeTest = serializer.ReadObject(reader) as DictionarySerializer;
            }

            return serializeTest;
        }
    }
}
