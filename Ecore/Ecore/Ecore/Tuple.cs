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
    public class Tuple<T, T2>
    {
        private T first;
        private T2 second;


        public Tuple(T first, T2 second)
        {
            First = first;
            Second = second;
        }

        public T First
        {
            get{
                return first;
            }
            set
            {
                first = value;
            }
        }

        public T2 Second
        {
            get
            {
                return second;
            }
            set
            {
                second = value;
            }
        }
    }
}
