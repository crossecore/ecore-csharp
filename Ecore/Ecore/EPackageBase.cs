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
	public class EPackageBase 
	:ENamedElementImpl, EPackage
	{
		private string _nsURI = "";
		public virtual string nsURI
		{
		get { 
			return _nsURI;
		}
		set { _nsURI = value; }
		}
		private string _nsPrefix = "";
		public virtual string nsPrefix
		{
		get { 
			return _nsPrefix;
		}
		set { _nsPrefix = value; }
		}
		public virtual EPackage eSuperPackage
		{
			get {
			
				if (eContainerFeatureID() != EcorePackageImpl.EPACKAGE_ESUPERPACKAGE) return default(EPackage);
				return (EPackage)eInternalContainer();
			}
		}
		private OrderedSet<EClassifier> _eClassifiers;
		
		public virtual OrderedSet<EClassifier> eClassifiers
		{
			get {
				if(_eClassifiers==null){
					_eClassifiers = new OrderedSet<EClassifier>(this, EcorePackageImpl.EPACKAGE_ECLASSIFIERS, EcorePackageImpl.ECLASSIFIER_EPACKAGE);
				}
				return _eClassifiers;
			}
		
		}
		private EFactory _eFactoryInstance;
		public virtual EFactory eFactoryInstance
		{
			get {
			
				return _eFactoryInstance;
			}
			set {
				if (value != _eFactoryInstance) {
					NotificationChain msgs = null;
					if (_eFactoryInstance != null){
						msgs = ((InternalEObject)_eFactoryInstance).eInverseRemove(this, EcorePackageImpl.EFACTORY_EPACKAGE, typeof(EPackage), msgs);
					}
					if (value != null){
						msgs = ((InternalEObject)value).eInverseAdd(this, EcorePackageImpl.EFACTORY_EPACKAGE, typeof(EPackage), msgs);
					}
					msgs = basicSetEFactoryInstance(value, msgs);
					if (msgs != null) {
						msgs.dispatch();
					}
				}
				else if (eNotificationRequired()){
					eNotify(new ENotificationImpl(this, NotificationImpl.SET,EcorePackageImpl.EPACKAGE_EFACTORYINSTANCE , value, value));
				}
				}
		}
		private OrderedSet<EPackage> _eSubpackages;
		
		public virtual OrderedSet<EPackage> eSubpackages
		{
			get {
				if(_eSubpackages==null){
					_eSubpackages = new OrderedSet<EPackage>(this, EcorePackageImpl.EPACKAGE_ESUBPACKAGES, EcorePackageImpl.EPACKAGE_ESUPERPACKAGE);
				}
				return _eSubpackages;
			}
		
		}
		public virtual EClassifier getEClassifier(string name
		)
		{
		    throw new NotImplementedException();
		}
		
		protected override EClass eStaticClass() {
			return EcorePackageImpl.Literals.EPACKAGE;
		}
		
		public override NotificationChain eInverseAdd(InternalEObject otherEnd, int featureID, NotificationChain msgs) {
			switch (featureID) {
				case EcorePackageImpl.EPACKAGE_ESUPERPACKAGE:
					if (eInternalContainer() != null) {
						msgs = eBasicRemoveFromContainer(msgs);
					}
					return basicSetESuperPackage((EPackage)otherEnd, msgs);
				case EcorePackageImpl.EPACKAGE_ECLASSIFIERS:
					return eClassifiers.basicAdd((EClassifier)otherEnd, msgs);
				case EcorePackageImpl.EPACKAGE_EFACTORYINSTANCE:
					if (_eFactoryInstance != null){
						msgs = ((InternalEObject)_eFactoryInstance).eInverseRemove(this, EcorePackageImpl.EPACKAGE_EFACTORYINSTANCE, typeof(EFactory), msgs);
					}
					return basicSetEFactoryInstance((EFactory)otherEnd, msgs);
				case EcorePackageImpl.EPACKAGE_ESUBPACKAGES:
					return eSubpackages.basicAdd((EPackage)otherEnd, msgs);
			}
			return base.eInverseAdd(otherEnd, featureID, msgs);
		}
		
		public override NotificationChain eInverseRemove(InternalEObject otherEnd, int featureID, NotificationChain msgs) {
			switch (featureID) {
				case EcorePackageImpl.EPACKAGE_ESUPERPACKAGE:
					return basicSetESuperPackage(null, msgs);
				case EcorePackageImpl.EPACKAGE_ECLASSIFIERS:
					return eClassifiers.basicRemove((EClassifier)otherEnd, msgs);
				case EcorePackageImpl.EPACKAGE_EFACTORYINSTANCE:
					return basicSetEFactoryInstance(null, msgs);
				case EcorePackageImpl.EPACKAGE_ESUBPACKAGES:
					return eSubpackages.basicRemove((EPackage)otherEnd, msgs);
			}
			return base.eInverseRemove(otherEnd, featureID, msgs);
		}
		
		public NotificationChain basicSetESuperPackage(EPackage newobj, NotificationChain msgs) {
				msgs = eBasicSetContainer((InternalEObject)newobj, EcorePackageImpl.EPACKAGE_ESUPERPACKAGE, msgs);
				return msgs;
		}
		public NotificationChain basicSetEFactoryInstance(EFactory newobj, NotificationChain msgs) {
			var oldobj = _eFactoryInstance;
			_eFactoryInstance = newobj;
			if (eNotificationRequired()) {
				var notification = new ENotificationImpl(this, NotificationImpl.SET, EcorePackageImpl.EPACKAGE_EFACTORYINSTANCE, oldobj, newobj);
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
				case EcorePackageImpl.EPACKAGE_EANNOTATIONS:
					return eAnnotations;
				case EcorePackageImpl.EPACKAGE_NAME:
					return name;
				case EcorePackageImpl.EPACKAGE_NSURI:
					return nsURI;
				case EcorePackageImpl.EPACKAGE_NSPREFIX:
					return nsPrefix;
				case EcorePackageImpl.EPACKAGE_EFACTORYINSTANCE:
					return eFactoryInstance;
				case EcorePackageImpl.EPACKAGE_ECLASSIFIERS:
					return eClassifiers;
				case EcorePackageImpl.EPACKAGE_ESUBPACKAGES:
					return eSubpackages;
				case EcorePackageImpl.EPACKAGE_ESUPERPACKAGE:
					return eSuperPackage;
			}
			return base.eGet(featureID, resolve, coreType);
		}
		
		
		public override void eSet(int featureID, object newValue) {
			switch (featureID) {
				case EcorePackageImpl.EPACKAGE_EANNOTATIONS:
					eAnnotations.Clear();
					eAnnotations.AddRange(((List<EObject>)newValue)?.Cast<EAnnotation>());
					return;
				case EcorePackageImpl.EPACKAGE_NAME:
					name = (string) newValue;
					return;
				case EcorePackageImpl.EPACKAGE_NSURI:
					nsURI = (string) newValue;
					return;
				case EcorePackageImpl.EPACKAGE_NSPREFIX:
					nsPrefix = (string) newValue;
					return;
				case EcorePackageImpl.EPACKAGE_EFACTORYINSTANCE:
					eFactoryInstance = (EFactory) newValue;
					return;
				case EcorePackageImpl.EPACKAGE_ECLASSIFIERS:
					eClassifiers.Clear();
					eClassifiers.AddRange(((List<EObject>)newValue)?.Cast<EClassifier>());
					return;
				case EcorePackageImpl.EPACKAGE_ESUBPACKAGES:
					eSubpackages.Clear();
					eSubpackages.AddRange(((List<EObject>)newValue)?.Cast<EPackage>());
					return;
			}
			base.eSet(featureID, newValue);
		}
		
		
	}
}
