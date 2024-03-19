using System.Net.WebSockets;
using System.Xml.Serialization;

namespace SerializationCopy
{
    // good variant

    static class ExtentionMethod
    {
        public static T DeepCopyXml<T>(this T obj)
        {
            

            using var ms = new MemoryStream();
            var ser = new XmlSerializer(typeof(T));
            ser.Serialize(ms, obj);
            ms.Position = 0;

            return (T)ser.Deserialize(ms)!;
        }
    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return $"{Id} {Name}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var user = new User { Id = 1, Name = "Demo" };
            var user2=user.DeepCopyXml();
            user2.Id = 10;
            user2.Name = "Demo2";
            Console.WriteLine(user);
            Console.WriteLine(user2);
        }
    }
}
