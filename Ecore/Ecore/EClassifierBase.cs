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
	public class EClassifierBase 
	:ENamedElementImpl, EClassifier
	{
		public virtual Type instanceClass
		{
		get { 
			//TODO implement derivation
			return default(Type);
		}
		}
		private string _instanceClassName = "";
		public virtual string instanceClassName
		{
		get { 
			return _instanceClassName;
		}
		set { _instanceClassName = value; }
		}
		private string _instanceTypeName = "";
		public virtual string instanceTypeName
		{
		get { 
			return _instanceTypeName;
		}
		set { _instanceTypeName = value; }
		}
		public virtual object defaultValue
		{
		get { 
			//TODO implement derivation
			return default(object);
		}
		}
		private OrderedSet<ETypeParameter> _eTypeParameters;
		
		public virtual OrderedSet<ETypeParameter> eTypeParameters
		{
			get {
				if(_eTypeParameters==null){
					_eTypeParameters = new OrderedSet<ETypeParameter>(this, EcorePackageImpl.ECLASSIFIER_ETYPEPARAMETERS, EOPPOSITE_FEATURE_BASE - EcorePackageImpl.ECLASSIFIER_ETYPEPARAMETERS);
				}
				return _eTypeParameters;
			}
		
		}
		public virtual EPackage ePackage
		{
			get {
			
				if (eContainerFeatureID() != EcorePackageImpl.ECLASSIFIER_EPACKAGE) return default(EPackage);
				return (EPackage)eInternalContainer();
			}
		}
		public virtual bool isInstance(object object_
		)
		{
		    throw new NotImplementedException();
		}
		public virtual int getClassifierID()
		{
		    throw new NotImplementedException();
		}
		
		protected override EClass eStaticClass() {
			return EcorePackageImpl.Literals.ECLASSIFIER;
		}
		
		public override NotificationChain eInverseAdd(InternalEObject otherEnd, int featureID, NotificationChain msgs) {
			switch (featureID) {
				case EcorePackageImpl.ECLASSIFIER_EPACKAGE:
					if (eInternalContainer() != null) {
						msgs = eBasicRemoveFromContainer(msgs);
					}
					return basicSetEPackage((EPackage)otherEnd, msgs);
			}
			return base.eInverseAdd(otherEnd, featureID, msgs);
		}
		
		public override NotificationChain eInverseRemove(InternalEObject otherEnd, int featureID, NotificationChain msgs) {
			switch (featureID) {
				case EcorePackageImpl.ECLASSIFIER_EPACKAGE:
					return basicSetEPackage(null, msgs);
			}
			return base.eInverseRemove(otherEnd, featureID, msgs);
		}
		
		public NotificationChain basicSetEPackage(EPackage newobj, NotificationChain msgs) {
				msgs = eBasicSetContainer((InternalEObject)newobj, EcorePackageImpl.ECLASSIFIER_EPACKAGE, msgs);
				return msgs;
		}
		
		public override Object eGet(int featureID, bool resolve, bool coreType) {
			switch (featureID) {
				case EcorePackageImpl.ECLASSIFIER_EANNOTATIONS:
					return eAnnotations;
				case EcorePackageImpl.ECLASSIFIER_NAME:
					return name;
				case EcorePackageImpl.ECLASSIFIER_INSTANCECLASSNAME:
					return instanceClassName;
				case EcorePackageImpl.ECLASSIFIER_INSTANCECLASS:
					return instanceClass;
				case EcorePackageImpl.ECLASSIFIER_DEFAULTVALUE:
					return defaultValue;
				case EcorePackageImpl.ECLASSIFIER_INSTANCETYPENAME:
					return instanceTypeName;
				case EcorePackageImpl.ECLASSIFIER_EPACKAGE:
					return ePackage;
				case EcorePackageImpl.ECLASSIFIER_ETYPEPARAMETERS:
					return eTypeParameters;
			}
			return base.eGet(featureID, resolve, coreType);
		}
		
		
		public override void eSet(int featureID, object newValue) {
			switch (featureID) {
				case EcorePackageImpl.ECLASSIFIER_EANNOTATIONS:
					eAnnotations.Clear();
					eAnnotations.AddRange(((List<EObject>)newValue)?.Cast<EAnnotation>());
					return;
				case EcorePackageImpl.ECLASSIFIER_NAME:
					name = (string) newValue;
					return;
				case EcorePackageImpl.ECLASSIFIER_INSTANCECLASSNAME:
					instanceClassName = (string) newValue;
					return;
				case EcorePackageImpl.ECLASSIFIER_INSTANCETYPENAME:
					instanceTypeName = (string) newValue;
					return;
				case EcorePackageImpl.ECLASSIFIER_ETYPEPARAMETERS:
					eTypeParameters.Clear();
					eTypeParameters.AddRange(((List<EObject>)newValue)?.Cast<ETypeParameter>());
					return;
			}
			base.eSet(featureID, newValue);
		}
		
		
	}
}
