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
using oclstdlib;

namespace Ecore
{
    public abstract class Switch<T>
    {


        public T defaultCase(EObject eObject)
        {
            return default(T);
        }



        protected T doSwitch(EClass eClass, EObject eObject)
        {
            if (isSwitchFor(eClass.ePackage))
            {
                return doSwitch(eClass.getClassifierID(), eObject);
            }
            else
            {
                OrderedSet<EClass> eSuperTypes = eClass.eSuperTypes;
                return eSuperTypes.isEmpty() ? defaultCase(eObject) : doSwitch(eSuperTypes.at(0), eObject);
            }
        }



        public T doSwitch(EObject eObject)
        {
            return doSwitch(eObject.eClass(), eObject);
        }



        protected virtual T doSwitch(int classifierID, EObject eObject)
        {
            return default(T);
        }



        protected abstract bool isSwitchFor(EPackage ePackage);
    }
}
