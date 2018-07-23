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
	public class EReferenceBase 
	:EStructuralFeatureImpl, EReference
	{
		public virtual bool container
		{
		get { 
			//TODO implement derivation
			return default(bool);
		}
		}
		private bool _containment = false;
		public virtual bool containment
		{
		get { 
			return _containment;
		}
		set { _containment = value; }
		}
		private bool _resolveProxies = false;
		public virtual bool resolveProxies
		{
		get { 
			return _resolveProxies;
		}
		set { _resolveProxies = value; }
		}
		private EReference _eOpposite;
		public virtual EReference eOpposite
		{
			get {
			
				return _eOpposite;
			}
			set {
				var oldvalue = _eOpposite;
				_eOpposite = value;
				if (eNotificationRequired()){
					eNotify(new ENotificationImpl(this, NotificationImpl.SET,EcorePackageImpl.EREFERENCE_EOPPOSITE , oldvalue, value));
				}
				}
		}
		private OrderedSet<EAttribute> _eKeys;
		
		public virtual OrderedSet<EAttribute> eKeys
		{
			get {
				if(_eKeys==null){
					_eKeys = new OrderedSet<EAttribute>(this, EcorePackageImpl.EREFERENCE_EKEYS, EOPPOSITE_FEATURE_BASE - EcorePackageImpl.EREFERENCE_EKEYS);
				}
				return _eKeys;
			}
		
		}
		public virtual EClass eReferenceType
		{
			get {
			
				//TODO implement derivation
				return default(EClass);
			}
		}
		
		protected override EClass eStaticClass() {
			return EcorePackageImpl.Literals.EREFERENCE;
		}
		
		
		public NotificationChain basicSetEOpposite(EReference newobj, NotificationChain msgs) {
			var oldobj = _eOpposite;
			_eOpposite = newobj;
			if (eNotificationRequired()) {
				var notification = new ENotificationImpl(this, NotificationImpl.SET, EcorePackageImpl.EREFERENCE_EOPPOSITE, oldobj, newobj);
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
				case EcorePackageImpl.EREFERENCE_EANNOTATIONS:
					return eAnnotations;
				case EcorePackageImpl.EREFERENCE_NAME:
					return name;
				case EcorePackageImpl.EREFERENCE_ORDERED:
					return ordered;
				case EcorePackageImpl.EREFERENCE_UNIQUE:
					return unique;
				case EcorePackageImpl.EREFERENCE_LOWERBOUND:
					return lowerBound;
				case EcorePackageImpl.EREFERENCE_UPPERBOUND:
					return upperBound;
				case EcorePackageImpl.EREFERENCE_MANY:
					return many;
				case EcorePackageImpl.EREFERENCE_REQUIRED:
					return required;
				case EcorePackageImpl.EREFERENCE_ETYPE:
					return eType;
				case EcorePackageImpl.EREFERENCE_EGENERICTYPE:
					return eGenericType;
				case EcorePackageImpl.EREFERENCE_CHANGEABLE:
					return changeable;
				case EcorePackageImpl.EREFERENCE_VOLATILE:
					return volatile_;
				case EcorePackageImpl.EREFERENCE_TRANSIENT:
					return transient;
				case EcorePackageImpl.EREFERENCE_DEFAULTVALUELITERAL:
					return defaultValueLiteral;
				case EcorePackageImpl.EREFERENCE_DEFAULTVALUE:
					return defaultValue;
				case EcorePackageImpl.EREFERENCE_UNSETTABLE:
					return unsettable;
				case EcorePackageImpl.EREFERENCE_DERIVED:
					return derived;
				case EcorePackageImpl.EREFERENCE_ECONTAININGCLASS:
					return eContainingClass;
				case EcorePackageImpl.EREFERENCE_CONTAINMENT:
					return containment;
				case EcorePackageImpl.EREFERENCE_CONTAINER:
					return container;
				case EcorePackageImpl.EREFERENCE_RESOLVEPROXIES:
					return resolveProxies;
				case EcorePackageImpl.EREFERENCE_EOPPOSITE:
					return eOpposite;
				case EcorePackageImpl.EREFERENCE_EREFERENCETYPE:
					return eReferenceType;
				case EcorePackageImpl.EREFERENCE_EKEYS:
					return eKeys;
			}
			return base.eGet(featureID, resolve, coreType);
		}
		
		
		public override void eSet(int featureID, object newValue) {
			switch (featureID) {
				case EcorePackageImpl.EREFERENCE_EANNOTATIONS:
					eAnnotations.Clear();
					eAnnotations.AddRange(((List<EObject>)newValue)?.Cast<EAnnotation>());
					return;
				case EcorePackageImpl.EREFERENCE_NAME:
					name = (string) newValue;
					return;
				case EcorePackageImpl.EREFERENCE_ORDERED:
					ordered = (bool) newValue;
					return;
				case EcorePackageImpl.EREFERENCE_UNIQUE:
					unique = (bool) newValue;
					return;
				case EcorePackageImpl.EREFERENCE_LOWERBOUND:
					lowerBound = (int) newValue;
					return;
				case EcorePackageImpl.EREFERENCE_UPPERBOUND:
					upperBound = (int) newValue;
					return;
				case EcorePackageImpl.EREFERENCE_ETYPE:
					eType = (EClassifier) newValue;
					return;
				case EcorePackageImpl.EREFERENCE_EGENERICTYPE:
					eGenericType = (EGenericType) newValue;
					return;
				case EcorePackageImpl.EREFERENCE_CHANGEABLE:
					changeable = (bool) newValue;
					return;
				case EcorePackageImpl.EREFERENCE_VOLATILE:
					volatile_ = (bool) newValue;
					return;
				case EcorePackageImpl.EREFERENCE_TRANSIENT:
					transient = (bool) newValue;
					return;
				case EcorePackageImpl.EREFERENCE_DEFAULTVALUELITERAL:
					defaultValueLiteral = (string) newValue;
					return;
				case EcorePackageImpl.EREFERENCE_UNSETTABLE:
					unsettable = (bool) newValue;
					return;
				case EcorePackageImpl.EREFERENCE_DERIVED:
					derived = (bool) newValue;
					return;
				case EcorePackageImpl.EREFERENCE_CONTAINMENT:
					containment = (bool) newValue;
					return;
				case EcorePackageImpl.EREFERENCE_RESOLVEPROXIES:
					resolveProxies = (bool) newValue;
					return;
				case EcorePackageImpl.EREFERENCE_EOPPOSITE:
					eOpposite = (EReference) newValue;
					return;
				case EcorePackageImpl.EREFERENCE_EKEYS:
					eKeys.Clear();
					eKeys.AddRange(((List<EObject>)newValue)?.Cast<EAttribute>());
					return;
			}
			base.eSet(featureID, newValue);
		}
		
		
	}
}
