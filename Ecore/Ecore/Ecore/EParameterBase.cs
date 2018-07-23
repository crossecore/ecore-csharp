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
	public class EParameterBase 
	:ETypedElementImpl, EParameter
	{
		public virtual EOperation eOperation
		{
			get {
			
				if (eContainerFeatureID() != EcorePackageImpl.EPARAMETER_EOPERATION) return default(EOperation);
				return (EOperation)eInternalContainer();
			}
		}
		
		protected override EClass eStaticClass() {
			return EcorePackageImpl.Literals.EPARAMETER;
		}
		
		public override NotificationChain eInverseAdd(InternalEObject otherEnd, int featureID, NotificationChain msgs) {
			switch (featureID) {
				case EcorePackageImpl.EPARAMETER_EOPERATION:
					if (eInternalContainer() != null) {
						msgs = eBasicRemoveFromContainer(msgs);
					}
					return basicSetEOperation((EOperation)otherEnd, msgs);
			}
			return base.eInverseAdd(otherEnd, featureID, msgs);
		}
		
		public override NotificationChain eInverseRemove(InternalEObject otherEnd, int featureID, NotificationChain msgs) {
			switch (featureID) {
				case EcorePackageImpl.EPARAMETER_EOPERATION:
					return basicSetEOperation(null, msgs);
			}
			return base.eInverseRemove(otherEnd, featureID, msgs);
		}
		
		public NotificationChain basicSetEOperation(EOperation newobj, NotificationChain msgs) {
				msgs = eBasicSetContainer((InternalEObject)newobj, EcorePackageImpl.EPARAMETER_EOPERATION, msgs);
				return msgs;
		}
		
		public override Object eGet(int featureID, bool resolve, bool coreType) {
			switch (featureID) {
				case EcorePackageImpl.EPARAMETER_EANNOTATIONS:
					return eAnnotations;
				case EcorePackageImpl.EPARAMETER_NAME:
					return name;
				case EcorePackageImpl.EPARAMETER_ORDERED:
					return ordered;
				case EcorePackageImpl.EPARAMETER_UNIQUE:
					return unique;
				case EcorePackageImpl.EPARAMETER_LOWERBOUND:
					return lowerBound;
				case EcorePackageImpl.EPARAMETER_UPPERBOUND:
					return upperBound;
				case EcorePackageImpl.EPARAMETER_MANY:
					return many;
				case EcorePackageImpl.EPARAMETER_REQUIRED:
					return required;
				case EcorePackageImpl.EPARAMETER_ETYPE:
					return eType;
				case EcorePackageImpl.EPARAMETER_EGENERICTYPE:
					return eGenericType;
				case EcorePackageImpl.EPARAMETER_EOPERATION:
					return eOperation;
			}
			return base.eGet(featureID, resolve, coreType);
		}
		
		
		public override void eSet(int featureID, object newValue) {
			switch (featureID) {
				case EcorePackageImpl.EPARAMETER_EANNOTATIONS:
					eAnnotations.Clear();
					eAnnotations.AddRange(((List<EObject>)newValue)?.Cast<EAnnotation>());
					return;
				case EcorePackageImpl.EPARAMETER_NAME:
					name = (string) newValue;
					return;
				case EcorePackageImpl.EPARAMETER_ORDERED:
					ordered = (bool) newValue;
					return;
				case EcorePackageImpl.EPARAMETER_UNIQUE:
					unique = (bool) newValue;
					return;
				case EcorePackageImpl.EPARAMETER_LOWERBOUND:
					lowerBound = (int) newValue;
					return;
				case EcorePackageImpl.EPARAMETER_UPPERBOUND:
					upperBound = (int) newValue;
					return;
				case EcorePackageImpl.EPARAMETER_ETYPE:
					eType = (EClassifier) newValue;
					return;
				case EcorePackageImpl.EPARAMETER_EGENERICTYPE:
					eGenericType = (EGenericType) newValue;
					return;
			}
			base.eSet(featureID, newValue);
		}
		
		
	}
}
