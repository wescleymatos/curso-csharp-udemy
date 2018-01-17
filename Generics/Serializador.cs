using System.IO;
using Newtonsoft.Json;

namespace Generics
{
    public class Serializador
    {
        public static void Serializar(object obj)
        {
            var nomeClasse = obj.GetType().Name;
            var sw = new StreamWriter($@"C:\Users\Wescley\Documents\Development\{nomeClasse}.json");

            var serializado = JsonConvert.SerializeObject(obj);
            sw.Write(serializado);
            sw.Close();
        }

        public static T Deserializar<T> ()
        {
            var nomeClasse = typeof(T).Name;
            var sr = new StreamReader($@"C:\Users\Wescley\Documents\Development\{nomeClasse}.json");
            var conteudo = sr.ReadToEnd();

            return JsonConvert.DeserializeObject<T>(conteudo);
        }
    }
}