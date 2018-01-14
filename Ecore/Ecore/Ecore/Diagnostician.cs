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
    public class Diagnostician : EValidator
    {
        protected Dictionary<EPackage, object> eValidatorRegistry;
    
        public static Diagnostician INSTANCE = new Diagnostician();

        public bool validate(EObject eObject, DiagnosticChain diagnostics, Dictionary<object, object> context)
        {
            throw new NotImplementedException();
        }

        public bool validate(EClass eClass, EObject eObject, DiagnosticChain diagnostics, Dictionary<object, object> context)
        {
            Object eValidator=null;
            EClass eType = eClass;
            //while ((eValidator = eValidatorRegistry.get(eType.eContainer())) == null)

            while(!eValidatorRegistry.ContainsKey(eType.eContainer() as EPackage))
            {
                eValidator = eValidatorRegistry[eType.eContainer() as EPackage];
                List<EClass> eSuperTypes = eType.eSuperTypes;
                if (eSuperTypes.Count ==0)
                {
                    //TODO return a defaultCase
                    eValidator = null;// eValidatorRegistry.get(null);
                    break;
                }
                else
                {
                    eType = eSuperTypes.ElementAt(0);
                }
            }
            //bool circular = context.get(EObjectValidator.ROOT_OBJECT) == eObject;
            //TODO containskey check
            bool circular = context[EObjectValidator.ROOT_OBJECT] == eObject;
            bool result = doValidate((EValidator)eValidator, eClass, eObject, diagnostics, context);
            if ((result || diagnostics != null) && !circular)
            {
                result &= doValidateContents(eObject, diagnostics, context);
            }
            return result;
        }

        public bool validate(EDataType eDataType, Object value, DiagnosticChain diagnostics, Dictionary<object, object> context)
        {
            Object eValidator = eValidatorRegistry[eDataType.eContainer() as EPackage];
            if (eValidator == null)
            {
                //TODO default case
                eValidator = null;// eValidatorRegistry.get(null);
            }

            return doValidate((EValidator)eValidator, eDataType, value, diagnostics, context);
        }

        protected bool doValidate(EValidator eValidator, EDataType eDataType, Object value, DiagnosticChain diagnostics, Dictionary<Object, Object> context)
        {
            return eValidator.validate(eDataType, value, diagnostics, context);
        }

        protected bool doValidate(EValidator eValidator, EClass eClass, EObject eObject, DiagnosticChain diagnostics, Dictionary<Object, Object> context)
        {
            return eValidator.validate(eClass, eObject, diagnostics, context);
        }

        protected bool doValidateContents(EObject eObject, DiagnosticChain diagnostics, Dictionary<Object, Object> context)
        {
            List<EObject> eContents = eObject.eContents();

            
            if (eContents.Count>0)
            {
                bool result = true;
                foreach (EObject child in eContents)
                {
                    result &= validate(child, diagnostics, context);
                }

                return result;
            }
            else
            {
                return true;
            }
        }
    }
}
