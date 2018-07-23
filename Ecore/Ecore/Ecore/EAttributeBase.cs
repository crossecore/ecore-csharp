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
	public class EAttributeBase 
	:EStructuralFeatureImpl, EAttribute
	{
		private bool _iD = false;
		public virtual bool iD
		{
		get { 
			return _iD;
		}
		set { _iD = value; }
		}
		public virtual EDataType eAttributeType
		{
			get {
			
				//TODO implement derivation
				return default(EDataType);
			}
		}
		
		protected override EClass eStaticClass() {
			return EcorePackageImpl.Literals.EATTRIBUTE;
		}
		
		
		
		public override Object eGet(int featureID, bool resolve, bool coreType) {
			switch (featureID) {
				case EcorePackageImpl.EATTRIBUTE_EANNOTATIONS:
					return eAnnotations;
				case EcorePackageImpl.EATTRIBUTE_NAME:
					return name;
				case EcorePackageImpl.EATTRIBUTE_ORDERED:
					return ordered;
				case EcorePackageImpl.EATTRIBUTE_UNIQUE:
					return unique;
				case EcorePackageImpl.EATTRIBUTE_LOWERBOUND:
					return lowerBound;
				case EcorePackageImpl.EATTRIBUTE_UPPERBOUND:
					return upperBound;
				case EcorePackageImpl.EATTRIBUTE_MANY:
					return many;
				case EcorePackageImpl.EATTRIBUTE_REQUIRED:
					return required;
				case EcorePackageImpl.EATTRIBUTE_ETYPE:
					return eType;
				case EcorePackageImpl.EATTRIBUTE_EGENERICTYPE:
					return eGenericType;
				case EcorePackageImpl.EATTRIBUTE_CHANGEABLE:
					return changeable;
				case EcorePackageImpl.EATTRIBUTE_VOLATILE:
					return volatile_;
				case EcorePackageImpl.EATTRIBUTE_TRANSIENT:
					return transient;
				case EcorePackageImpl.EATTRIBUTE_DEFAULTVALUELITERAL:
					return defaultValueLiteral;
				case EcorePackageImpl.EATTRIBUTE_DEFAULTVALUE:
					return defaultValue;
				case EcorePackageImpl.EATTRIBUTE_UNSETTABLE:
					return unsettable;
				case EcorePackageImpl.EATTRIBUTE_DERIVED:
					return derived;
				case EcorePackageImpl.EATTRIBUTE_ECONTAININGCLASS:
					return eContainingClass;
				case EcorePackageImpl.EATTRIBUTE_ID:
					return iD;
				case EcorePackageImpl.EATTRIBUTE_EATTRIBUTETYPE:
					return eAttributeType;
			}
			return base.eGet(featureID, resolve, coreType);
		}
		
		
		public override void eSet(int featureID, object newValue) {
			switch (featureID) {
				case EcorePackageImpl.EATTRIBUTE_EANNOTATIONS:
					eAnnotations.Clear();
					eAnnotations.AddRange(((List<EObject>)newValue)?.Cast<EAnnotation>());
					return;
				case EcorePackageImpl.EATTRIBUTE_NAME:
					name = (string) newValue;
					return;
				case EcorePackageImpl.EATTRIBUTE_ORDERED:
					ordered = (bool) newValue;
					return;
				case EcorePackageImpl.EATTRIBUTE_UNIQUE:
					unique = (bool) newValue;
					return;
				case EcorePackageImpl.EATTRIBUTE_LOWERBOUND:
					lowerBound = (int) newValue;
					return;
				case EcorePackageImpl.EATTRIBUTE_UPPERBOUND:
					upperBound = (int) newValue;
					return;
				case EcorePackageImpl.EATTRIBUTE_ETYPE:
					eType = (EClassifier) newValue;
					return;
				case EcorePackageImpl.EATTRIBUTE_EGENERICTYPE:
					eGenericType = (EGenericType) newValue;
					return;
				case EcorePackageImpl.EATTRIBUTE_CHANGEABLE:
					changeable = (bool) newValue;
					return;
				case EcorePackageImpl.EATTRIBUTE_VOLATILE:
					volatile_ = (bool) newValue;
					return;
				case EcorePackageImpl.EATTRIBUTE_TRANSIENT:
					transient = (bool) newValue;
					return;
				case EcorePackageImpl.EATTRIBUTE_DEFAULTVALUELITERAL:
					defaultValueLiteral = (string) newValue;
					return;
				case EcorePackageImpl.EATTRIBUTE_UNSETTABLE:
					unsettable = (bool) newValue;
					return;
				case EcorePackageImpl.EATTRIBUTE_DERIVED:
					derived = (bool) newValue;
					return;
				case EcorePackageImpl.EATTRIBUTE_ID:
					iD = (bool) newValue;
					return;
			}
			base.eSet(featureID, newValue);
		}
		
		
	}
}
