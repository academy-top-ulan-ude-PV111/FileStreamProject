using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.IO.Compression;

namespace FileStreamProject
{
    [Serializable]
    class User
    {
        public string? Name { set; get; }
        public int Age { set; get; }

    }

    internal class Program
    {
        static byte[] ObjectToByteArray(object obj)
        {
            if (obj == null) return null;
            BinaryFormatter binaryFormatter = new();
            MemoryStream memoryStream = new();
            binaryFormatter.Serialize(memoryStream, obj);

            return memoryStream.ToArray();
        }

        static object ByteArrayToObject(byte[] byteArray)
        {
            BinaryFormatter binaryFormatter = new();
            MemoryStream memoryStream = new();

            memoryStream.Write(byteArray, 0, byteArray.Length);
            memoryStream.Seek(0, SeekOrigin.Begin);
            
            Object obj = binaryFormatter.Deserialize(memoryStream);

            return obj;
        }
        static void Main(string[] args)
        {
            //FileStream? file = null;
            //try
            //{
            //    file = new FileStream("myfile.bin", FileMode.OpenOrCreate);
            //}
            //catch(Exception e)
            //{

            //}
            //finally
            //{
            //    file?.Close();
            //}

            //string filePath = @"myfile.bin";

            //User user = new User() { Name = "Bob", Age = 34 };

            //string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";

            //byte[] buffer = Encoding.Default.GetBytes(text);



            //using (FileStream stream = new FileStream(filePath, FileMode.OpenOrCreate))
            //{
            //    stream.Write(buffer, 0, buffer.Length);
            //}

            //BinaryWriter
            //using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(filePath, FileMode.OpenOrCreate)))
            //{
            //    binaryWriter.Write(user.Name);
            //    binaryWriter.Write(user.Age);

            //    binaryWriter.Write(ObjectToByteArray(user));
            //}

            //BinaryReader
            //using(BinaryReader binaryReader = new(File.Open(filePath, FileMode.Open)))
            //{
            //    string name = binaryReader.ReadString();
            //    int age = binaryReader.ReadInt32();

            //    List<byte> buffer = new();
            //    while(true)
            //    {
            //        try
            //        {
            //            byte b = binaryReader.ReadByte();
            //            buffer.Add(b);
            //        }
            //        catch(EndOfStreamException e)
            //        {
            //            break;
            //        }
            //    }

            //    object obj = ByteArrayToObject(buffer.ToArray());
            //    User userNew = (User)obj;

            //    Console.WriteLine(name);
            //    Console.WriteLine(age);
            //    Console.WriteLine(userNew.Name);
            //    Console.WriteLine(userNew.Age);
            //}


            // StreamWriter
            //string pathTxt = @"myfile.txt";

            //string text = "Этот конструктор создает объект StreamWriter с кодировкой UTF-8 без Byte-Order метки (BOM), " +
            //    "поэтому GetPreamble метод возвращает пустой массив байтов. Кодировка по умолчанию UTF-8 " +
            //    "для этого конструктора вызывает исключение для недопустимых байтов. Это поведение отличается от поведения, " +
            //    "предоставленного объектом Encoding в Encoding.UTF8 свойстве. Чтобы указать СПЕЦИФИКАЦИю и определить, " +
            //    "возникает ли исключение в недопустимых байтах, используйте конструктор, принимающий объект " +
            //    "кодировки в качестве параметра, например StreamWriter(String, Boolean, Encoding) .";

            //string text2 = "При компиляции набора символов с определенным параметром культуры и получении " +
            //    "тех же символов с другим параметром культуры символы могут оказаться неинтерпретируемыми " +
            //    "и могут вызвать исключение.";

            //using(StreamWriter writer = new StreamWriter(pathTxt, false))
            //{
            //    writer.WriteLine(text);
            //}

            //using(StreamWriter writer2 = new StreamWriter(pathTxt, true))
            //{
            //    writer2.WriteLine(text2);
            //}

            //StreamReader
            //using(StreamReader reader = new StreamReader(pathTxt))
            //{
            //    string textRead;
            //    while ((textRead = reader.ReadLine()) != null)
            //        Console.WriteLine(textRead);
            //}

            //FileZip.CreateFromDirectory("../", "myzip.zip");



        }
    }
}