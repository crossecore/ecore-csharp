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
	public class EObjectBase 
	:BasicEObjectImpl, EObject
	{
		public virtual void eSet(EStructuralFeature feature,
		object newValue
		)
		{
		    throw new NotImplementedException();
		}
		public virtual EReference eContainmentFeature()
		{
		    throw new NotImplementedException();
		}
		public virtual List<EObject> eContents()
		{
		    throw new NotImplementedException();
		}
		public virtual TreeIterator<EObject> eAllContents()
		{
		    throw new NotImplementedException();
		}
		public virtual List<EObject> eCrossReferences()
		{
		    throw new NotImplementedException();
		}
		public virtual void eUnset(EStructuralFeature feature
		)
		{
		    throw new NotImplementedException();
		}
		public virtual bool eIsSet(EStructuralFeature feature
		)
		{
		    throw new NotImplementedException();
		}
		public virtual object eGet(EStructuralFeature feature
		)
		{
		    throw new NotImplementedException();
		}
		public virtual EClass eClass()
		{
		    throw new NotImplementedException();
		}
		public virtual EObject eContainer()
		{
		    throw new NotImplementedException();
		}
		public virtual object eInvoke(EOperation operation,
		List<object> arguments
		)
		{
		    throw new NotImplementedException();
		}
		public virtual Resource eResource()
		{
		    throw new NotImplementedException();
		}
		public virtual bool eIsProxy()
		{
		    throw new NotImplementedException();
		}
		public virtual object eGet(EStructuralFeature feature,
		bool resolve
		)
		{
		    throw new NotImplementedException();
		}
		public virtual EStructuralFeature eContainingFeature()
		{
		    throw new NotImplementedException();
		}
		
		protected override EClass eStaticClass() {
			return EcorePackageImpl.Literals.EOBJECT;
		}
		
		
		
		public override Object eGet(int featureID, bool resolve, bool coreType) {
			switch (featureID) {
			}
			return base.eGet(featureID, resolve, coreType);
		}
		
		
		public override void eSet(int featureID, object newValue) {
			switch (featureID) {
			}
			base.eSet(featureID, newValue);
		}
		
		
	}
}
