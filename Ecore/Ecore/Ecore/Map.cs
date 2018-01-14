/* CrossEcore is a cross-platform modeling framework that generates C#, TypeScript, 
 * JavaScript, Swift code from Ecore models with embedded OCL (http://www.crossecore.org/).
 * The original Eclipse Modeling Framework is available at https://www.eclipse.org/modeling/emf/.
 * 
 * contributor: Simon Schwichtenberg
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecore
{
    public class Map<TKey, TValue> : Dictionary<TKey, TValue>
    {

        private TValue defaultCase = default(TValue);

        public TValue Get(TKey key)
        {
            if (key==null)
            {
                return defaultCase;
            }
            else if (this.ContainsKey(key))
            {
                return this[key];
            }
            else
            {
                return default(TValue);

            }
        }

        public void Put(TKey key, TValue value)
        {
            if (key==null)
            {
                defaultCase = value;
            }
            else
            {
                base.Add(key, value);
            }
        }
    }
}
