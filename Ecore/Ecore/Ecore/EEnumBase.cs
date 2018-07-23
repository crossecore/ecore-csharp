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
	public class EEnumBase 
	:EDataTypeImpl, EEnum
	{
		private OrderedSet<EEnumLiteral> _eLiterals;
		
		public virtual OrderedSet<EEnumLiteral> eLiterals
		{
			get {
				if(_eLiterals==null){
					_eLiterals = new OrderedSet<EEnumLiteral>(this, EcorePackageImpl.EENUM_ELITERALS, EcorePackageImpl.EENUMLITERAL_EENUM);
				}
				return _eLiterals;
			}
		
		}
		public virtual EEnumLiteral getEEnumLiteral(int value
		)
		{
		    throw new NotImplementedException();
		}
		public virtual EEnumLiteral getEEnumLiteral(string name
		)
		{
		    throw new NotImplementedException();
		}
		public virtual EEnumLiteral getEEnumLiteralByLiteral(string literal
		)
		{
		    throw new NotImplementedException();
		}
		
		protected override EClass eStaticClass() {
			return EcorePackageImpl.Literals.EENUM;
		}
		
		public override NotificationChain eInverseAdd(InternalEObject otherEnd, int featureID, NotificationChain msgs) {
			switch (featureID) {
				case EcorePackageImpl.EENUM_ELITERALS:
					return eLiterals.basicAdd((EEnumLiteral)otherEnd, msgs);
			}
			return base.eInverseAdd(otherEnd, featureID, msgs);
		}
		
		public override NotificationChain eInverseRemove(InternalEObject otherEnd, int featureID, NotificationChain msgs) {
			switch (featureID) {
				case EcorePackageImpl.EENUM_ELITERALS:
					return eLiterals.basicRemove((EEnumLiteral)otherEnd, msgs);
			}
			return base.eInverseRemove(otherEnd, featureID, msgs);
		}
		
		
		public override Object eGet(int featureID, bool resolve, bool coreType) {
			switch (featureID) {
				case EcorePackageImpl.EENUM_EANNOTATIONS:
					return eAnnotations;
				case EcorePackageImpl.EENUM_NAME:
					return name;
				case EcorePackageImpl.EENUM_INSTANCECLASSNAME:
					return instanceClassName;
				case EcorePackageImpl.EENUM_INSTANCECLASS:
					return instanceClass;
				case EcorePackageImpl.EENUM_DEFAULTVALUE:
					return defaultValue;
				case EcorePackageImpl.EENUM_INSTANCETYPENAME:
					return instanceTypeName;
				case EcorePackageImpl.EENUM_EPACKAGE:
					return ePackage;
				case EcorePackageImpl.EENUM_ETYPEPARAMETERS:
					return eTypeParameters;
				case EcorePackageImpl.EENUM_SERIALIZABLE:
					return serializable;
				case EcorePackageImpl.EENUM_ELITERALS:
					return eLiterals;
			}
			return base.eGet(featureID, resolve, coreType);
		}
		
		
		public override void eSet(int featureID, object newValue) {
			switch (featureID) {
				case EcorePackageImpl.EENUM_EANNOTATIONS:
					eAnnotations.Clear();
					eAnnotations.AddRange(((List<EObject>)newValue)?.Cast<EAnnotation>());
					return;
				case EcorePackageImpl.EENUM_NAME:
					name = (string) newValue;
					return;
				case EcorePackageImpl.EENUM_INSTANCECLASSNAME:
					instanceClassName = (string) newValue;
					return;
				case EcorePackageImpl.EENUM_INSTANCETYPENAME:
					instanceTypeName = (string) newValue;
					return;
				case EcorePackageImpl.EENUM_ETYPEPARAMETERS:
					eTypeParameters.Clear();
					eTypeParameters.AddRange(((List<EObject>)newValue)?.Cast<ETypeParameter>());
					return;
				case EcorePackageImpl.EENUM_SERIALIZABLE:
					serializable = (bool) newValue;
					return;
				case EcorePackageImpl.EENUM_ELITERALS:
					eLiterals.Clear();
					eLiterals.AddRange(((List<EObject>)newValue)?.Cast<EEnumLiteral>());
					return;
			}
			base.eSet(featureID, newValue);
		}
		
		
	}
}
