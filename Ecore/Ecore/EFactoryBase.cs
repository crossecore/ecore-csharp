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
	public class EFactoryBase 
	:EModelElementImpl, EFactory
	{
		private EPackage _ePackage;
		public virtual EPackage ePackage
		{
			get {
			
				return _ePackage;
			}
			set {
				if (value != _ePackage) {
					NotificationChain msgs = null;
					if (_ePackage != null){
						msgs = ((InternalEObject)_ePackage).eInverseRemove(this, EcorePackageImpl.EPACKAGE_EFACTORYINSTANCE, typeof(EFactory), msgs);
					}
					if (value != null){
						msgs = ((InternalEObject)value).eInverseAdd(this, EcorePackageImpl.EPACKAGE_EFACTORYINSTANCE, typeof(EFactory), msgs);
					}
					msgs = basicSetEPackage(value, msgs);
					if (msgs != null) {
						msgs.dispatch();
					}
				}
				else if (eNotificationRequired()){
					eNotify(new ENotificationImpl(this, NotificationImpl.SET,EcorePackageImpl.EFACTORY_EPACKAGE , value, value));
				}
				}
		}
		public virtual object createFromString(EDataType eDataType,
		string literalValue
		)
		{
		    throw new NotImplementedException();
		}
		public virtual string convertToString(EDataType eDataType,
		object instanceValue
		)
		{
		    throw new NotImplementedException();
		}
		public virtual EObject create(EClass eClass
		)
		{
		    throw new NotImplementedException();
		}
		
		protected override EClass eStaticClass() {
			return EcorePackageImpl.Literals.EFACTORY;
		}
		
		public override NotificationChain eInverseAdd(InternalEObject otherEnd, int featureID, NotificationChain msgs) {
			switch (featureID) {
				case EcorePackageImpl.EFACTORY_EPACKAGE:
					if (_ePackage != null){
						msgs = ((InternalEObject)_ePackage).eInverseRemove(this, EcorePackageImpl.EFACTORY_EPACKAGE, typeof(EPackage), msgs);
					}
					return basicSetEPackage((EPackage)otherEnd, msgs);
			}
			return base.eInverseAdd(otherEnd, featureID, msgs);
		}
		
		public override NotificationChain eInverseRemove(InternalEObject otherEnd, int featureID, NotificationChain msgs) {
			switch (featureID) {
				case EcorePackageImpl.EFACTORY_EPACKAGE:
					return basicSetEPackage(null, msgs);
			}
			return base.eInverseRemove(otherEnd, featureID, msgs);
		}
		
		public NotificationChain basicSetEPackage(EPackage newobj, NotificationChain msgs) {
			var oldobj = _ePackage;
			_ePackage = newobj;
			if (eNotificationRequired()) {
				var notification = new ENotificationImpl(this, NotificationImpl.SET, EcorePackageImpl.EFACTORY_EPACKAGE, oldobj, newobj);
				if (msgs == null){
					msgs = notification;
				}
				else{
					msgs.add(notification);
				}
			}
			return msgs;
		}
		
		public override Object eGet(int featureID, bool resolve, bool coreType) {
			switch (featureID) {
				case EcorePackageImpl.EFACTORY_EANNOTATIONS:
					return eAnnotations;
				case EcorePackageImpl.EFACTORY_EPACKAGE:
					return ePackage;
			}
			return base.eGet(featureID, resolve, coreType);
		}
		
		
		public override void eSet(int featureID, object newValue) {
			switch (featureID) {
				case EcorePackageImpl.EFACTORY_EANNOTATIONS:
					eAnnotations.Clear();
					eAnnotations.AddRange(((List<EObject>)newValue)?.Cast<EAnnotation>());
					return;
				case EcorePackageImpl.EFACTORY_EPACKAGE:
					ePackage = (EPackage) newValue;
					return;
			}
			base.eSet(featureID, newValue);
		}
		
		
	}
}
