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
    public class EcoreUtil
    {

        public static string convertToString(EDataType eDataType, object value)
        {
            return eDataType.ePackage.eFactoryInstance.convertToString(eDataType, value);
        }

        public static string getIdentification(EObject eObject)
        {
            StringBuilder result = new StringBuilder(eObject.eClass().name);
            EClass eClass = eObject.eClass();
            if (eClass.instanceClassName == null)
            {
                result.Append('/');
                result.Append(eClass.ePackage.nsURI);
                result.Append('#');
                result.Append(eClass.name);
            }
            result.Append('@');
            result.Append(eObject.GetHashCode().ToString("X"));

            result.Append('{');
            //TODO result.Append(getURI(eObject));
            result.Append('}');

            return result.ToString();
        }

        public static string getID(EObject eObject)
        {
            EClass eClass = eObject.eClass();
            EAttribute eIDAttribute = eClass.eIDAttribute;
            return eIDAttribute == null || !eObject.eIsSet(eIDAttribute) ? null : convertToString(
              eIDAttribute.eAttributeType,
              eObject.eGet(eIDAttribute));
        }
    }
}
