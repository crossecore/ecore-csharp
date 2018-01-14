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


namespace oclstdlib
{
    public class OclVoid
    {
        public static OclVoid NULL = new OclVoid();

        protected OclVoid()
        {

        }

        public Set<T> oclAsSet<T>()
        {
            return new Set<T>();
        }

        /*
        public bool oclIsInState(OclState statespec) 
        {
            return false;
        }
        

        public bool oclIsInvalid()
        {
            return false;
        }

        public bool oclIsKindOf(Type type)
        {
            return OclInvalid.INVALID;
        }

        public bool oclIsNew()
        {
            return false;
        }

        public bool oclIsTypeOf(Type type)
        {
            return OclInvalid.INVALID;
        }

        public bool oclIsUndefined(Type type)
        {
            return true;
        }

        public Type oclType()
        {
            return typeof(OclVoid);
        }

        */

    }
}
