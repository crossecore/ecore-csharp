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
    public class OclAny
    {
        public static OclAny Invalid = new OclAny();
    }

    /*
    public class MyString : OclAny
    {
        protected string wrapped;

        public MyString(string x)
        {
            wrapped = x;
        }

        public MyString Substring(int begin, int end)
        {
            try { 
                var result = this.wrapped.Substring(begin, end);
                return new MyString(result);
            }
            catch(Exception e)
            {
                
                return Invalid as MyString;
            }
            

        }
    }
    */
}
