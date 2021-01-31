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
using oclstdlib;
namespace Ecore{
	
	public interface EObject 
	: Notifier
	{
		EClass eClass();
		bool eIsProxy();
		Resource eResource();
		EObject eContainer();
		EStructuralFeature eContainingFeature();
		EReference eContainmentFeature();
		List<EObject> eContents();
		TreeIterator<EObject> eAllContents();
		List<EObject> eCrossReferences();
		object eGet(EStructuralFeature feature);
		object eGet(EStructuralFeature feature,bool resolve);
		void eSet(EStructuralFeature feature,object newValue);
		bool eIsSet(EStructuralFeature feature);
		void eUnset(EStructuralFeature feature);
		object eInvoke(EOperation operation,List<object> arguments);
	}
}
