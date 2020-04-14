using System.Web.Script.Serialization;
using System.IO;

namespace _01_Generics
{
    //Responsavel pela serialização e criação dos arquivos
    public class Serializador
    {
        //Passar o bojeto a ser serializado
        public static void Serializar(object obj)
        {
            StreamWriter streamWriter = new StreamWriter(@"C:\Users\jpssi\Documents\Udemy\Arquivo C# Avançado\03_"+ obj.GetType().Name +".txt");

            JavaScriptSerializer serializador = new JavaScriptSerializer();
            string objSerializado = serializador.Serialize(obj);

            streamWriter.Write(objSerializado);
            streamWriter.Close();
        }

        public static T Deserializar <T>()
        {
            StreamReader streamReader = new StreamReader(@"C:\Users\jpssi\Documents\Udemy\Arquivo C# Avançado\03_" + typeof(T).Name + ".txt");
            string Conteudo = streamReader.ReadToEnd();

            JavaScriptSerializer serializador = new JavaScriptSerializer();
            T obj = (T)serializador.Deserialize(Conteudo, typeof(T));

            return obj;
        }
    }
}
