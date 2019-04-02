using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace Wpfpueba_json
{
    class Rola
    {
        public string nombre { get; set; }
        public string artists { get; set; }
        public string external_urls { get; set;  }

        public string Abrir()
        {
            
            string path = @"C:\Users\xtratech2\Desktop\lista2.json";
            StreamReader jsonStream = File.OpenText(path);
            
            string reader = jsonStream.ReadToEnd();
            JObject textJ = JObject.Parse(reader);
            
            IList<JToken> resultados = textJ["items"]["artists"].Children().ToList();
            IList<Rola> rolas = new List<Rola>();

            foreach (JToken resultado in resultados)
            {
                Rola rola = JsonConvert.DeserializeObject<Rola>(resultado.ToString());
                rolas.Add(rola);
                
                nombre = rola.nombre;
                Console.WriteLine(nombre);

            }
            
            return rolas.ToString();
        }

    }
    class serio
    {
        
    }

    
}
