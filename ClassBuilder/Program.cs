using System.Text;
// Builder for generate class and fields
// test passed 28.02.2024 by Orkhan 
namespace ClassBuilder
{
    class ClassElement
    {
        public string Type { get; set; } = default!;
        public string Name { get; set; } = default!;
        public string Access { get; set; } = default!;

         const int STEP = 2;

        public List<ClassElement> ClassElements= new List<ClassElement>();
        public ClassElement() { }

        public ClassElement(string type, string name, string access)
        {
            Type = type;
            Name = name;
            Access = access;
        }

      
        // print classelem  
        public override string ToString()
        {
            var i = new string(' ', STEP);
            var sb = new StringBuilder();
            sb.Append($"{this.Access} {this.Type} {this.Name}\n");
            sb.Append("{\n");
            foreach (var  e in ClassElements)
            {
                sb.Append($"{i}{e.Access} {e.Type} {e.Name}");
                sb.Append(Environment.NewLine);
            }
            sb.Append("}\n");
            return sb.ToString();
        }
    }

    class CodeBuilder
    {
        public readonly string rootName;
        public readonly string rootAccess;
        public readonly string rootType;

        protected ClassElement root=new ClassElement();

        public CodeBuilder(string rootName)
        {
            this.rootName = rootName;
            root.Name = rootName;
            this.rootAccess = "public";
            root.Access = this.rootAccess;
            this.rootType = "class";
            root.Type = this.rootType;
            
        }
       
        //Fluent 
        public CodeBuilder AddField(string childName,string childType,string childAccess="public")
        {
            var e= new ClassElement(childType,childName,childAccess);
            // add field to list
            root.ClassElements.Add(e);
            return this;
        }

        public override string ToString()=> root.ToString();

        public void Clean()
        {
            root = new ClassElement{ Name = rootName,Access=rootAccess,Type=rootType};
        }

        public ClassElement Build() => root;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = new CodeBuilder("Person")
                .AddField("Name", "string")
                .AddField("Age","int");
                
            Console.WriteLine(builder);
        }
    }
}
