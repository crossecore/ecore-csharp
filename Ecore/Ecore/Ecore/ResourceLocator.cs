/* CrossEcore is a cross-platform modeling framework that generates C#, TypeScript, 
 * JavaScript, Swift code from Ecore models with embedded OCL (http://www.crossecore.org/).
 * The original Eclipse Modeling Framework is available at https://www.eclipse.org/modeling/emf/.
 * 
 * contributor: Simon Schwichtenberg
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ecore
{
    public class ResourceLocator
    {

        public static ResourceLocator INSTANCE = new ResourceLocator();

        private Dictionary<string, string> messages = new Dictionary<string, string>();

        public void init()
        {

            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "Ecore.plugin.properties";//Ecore = default namespace

            Stream stream = assembly.GetManifestResourceStream(resourceName);

            string line;
            StreamReader file = new StreamReader(stream);
            while ((line = file.ReadLine()) != null)
            {

                if (!line.StartsWith("#"))
                {
                    var parts = line.Split('=');


                    if (parts.Count()==2)
                    {
                        var key = parts[0].Trim();
                        var value = parts[1].Trim();
                        value = value.Replace("''", ",");
                        //TODO escape everyhing between pairs of '
                        value = value.Replace("'{'", "{{");
                        value = value.Replace("'}'","}}");
                        messages.Add(key, value);

                    }
                }

                
            }

            file.Close();
        }

        public string getString(string key, object[] substitutions)
        {
            if (messages!=null && messages.ContainsKey(key))
            {
                return String.Format(messages[key], substitutions);
            }

            return key;
        }

        public string getString(string key)
        {


            return key;
        }
    }
}
