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
	public class EDataTypeBase 
	:EClassifierImpl, EDataType
	{
		private bool _serializable = false;
		public virtual bool serializable
		{
		get { 
			return _serializable;
		}
		set { _serializable = value; }
		}
		
		protected override EClass eStaticClass() {
			return EcorePackageImpl.Literals.EDATATYPE;
		}
		
		
		
		public override Object eGet(int featureID, bool resolve, bool coreType) {
			switch (featureID) {
				case EcorePackageImpl.EDATATYPE_EANNOTATIONS:
					return eAnnotations;
				case EcorePackageImpl.EDATATYPE_NAME:
					return name;
				case EcorePackageImpl.EDATATYPE_INSTANCECLASSNAME:
					return instanceClassName;
				case EcorePackageImpl.EDATATYPE_INSTANCECLASS:
					return instanceClass;
				case EcorePackageImpl.EDATATYPE_DEFAULTVALUE:
					return defaultValue;
				case EcorePackageImpl.EDATATYPE_INSTANCETYPENAME:
					return instanceTypeName;
				case EcorePackageImpl.EDATATYPE_EPACKAGE:
					return ePackage;
				case EcorePackageImpl.EDATATYPE_ETYPEPARAMETERS:
					return eTypeParameters;
				case EcorePackageImpl.EDATATYPE_SERIALIZABLE:
					return serializable;
			}
			return base.eGet(featureID, resolve, coreType);
		}
		
		
		public override void eSet(int featureID, object newValue) {
			switch (featureID) {
				case EcorePackageImpl.EDATATYPE_EANNOTATIONS:
					eAnnotations.Clear();
					eAnnotations.AddRange(((List<EObject>)newValue)?.Cast<EAnnotation>());
					return;
				case EcorePackageImpl.EDATATYPE_NAME:
					name = (string) newValue;
					return;
				case EcorePackageImpl.EDATATYPE_INSTANCECLASSNAME:
					instanceClassName = (string) newValue;
					return;
				case EcorePackageImpl.EDATATYPE_INSTANCETYPENAME:
					instanceTypeName = (string) newValue;
					return;
				case EcorePackageImpl.EDATATYPE_ETYPEPARAMETERS:
					eTypeParameters.Clear();
					eTypeParameters.AddRange(((List<EObject>)newValue)?.Cast<ETypeParameter>());
					return;
				case EcorePackageImpl.EDATATYPE_SERIALIZABLE:
					serializable = (bool) newValue;
					return;
			}
			base.eSet(featureID, newValue);
		}
		
		
	}
}
