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
	public class EGenericTypeBase 
	:BasicEObjectImpl, EGenericType
	{
		private EGenericType _eLowerBound;
		public virtual EGenericType eLowerBound
		{
			get {
			
				return _eLowerBound;
			}
			set {
				if (value != _eLowerBound) {
					NotificationChain msgs = null;
					if (_eLowerBound != null){
						msgs = ((InternalEObject)_eLowerBound).eInverseRemove(this, EOPPOSITE_FEATURE_BASE - EcorePackageImpl.EGENERICTYPE_ELOWERBOUND, null, msgs);
					}
					if (value != null){
						msgs = ((InternalEObject)value).eInverseAdd(this, EOPPOSITE_FEATURE_BASE - EcorePackageImpl.EGENERICTYPE_ELOWERBOUND, null, msgs);
					}
					msgs = basicSetELowerBound(value, msgs);
					if (msgs != null) {
						msgs.dispatch();
					}
				}
				else if (eNotificationRequired()){
					eNotify(new ENotificationImpl(this, NotificationImpl.SET,EcorePackageImpl.EGENERICTYPE_ELOWERBOUND , value, value));
				}
				}
		}
		private ETypeParameter _eTypeParameter;
		public virtual ETypeParameter eTypeParameter
		{
			get {
			
				return _eTypeParameter;
			}
			set {
				var oldvalue = _eTypeParameter;
				_eTypeParameter = value;
				if (eNotificationRequired()){
					eNotify(new ENotificationImpl(this, NotificationImpl.SET,EcorePackageImpl.EGENERICTYPE_ETYPEPARAMETER , oldvalue, value));
				}
				}
		}
		private EGenericType _eUpperBound;
		public virtual EGenericType eUpperBound
		{
			get {
			
				return _eUpperBound;
			}
			set {
				if (value != _eUpperBound) {
					NotificationChain msgs = null;
					if (_eUpperBound != null){
						msgs = ((InternalEObject)_eUpperBound).eInverseRemove(this, EOPPOSITE_FEATURE_BASE - EcorePackageImpl.EGENERICTYPE_EUPPERBOUND, null, msgs);
					}
					if (value != null){
						msgs = ((InternalEObject)value).eInverseAdd(this, EOPPOSITE_FEATURE_BASE - EcorePackageImpl.EGENERICTYPE_EUPPERBOUND, null, msgs);
					}
					msgs = basicSetEUpperBound(value, msgs);
					if (msgs != null) {
						msgs.dispatch();
					}
				}
				else if (eNotificationRequired()){
					eNotify(new ENotificationImpl(this, NotificationImpl.SET,EcorePackageImpl.EGENERICTYPE_EUPPERBOUND , value, value));
				}
				}
		}
		private EClassifier _eClassifier;
		public virtual EClassifier eClassifier
		{
			get {
			
				return _eClassifier;
			}
			set {
				var oldvalue = _eClassifier;
				_eClassifier = value;
				if (eNotificationRequired()){
					eNotify(new ENotificationImpl(this, NotificationImpl.SET,EcorePackageImpl.EGENERICTYPE_ECLASSIFIER , oldvalue, value));
				}
				}
		}
		private OrderedSet<EGenericType> _eTypeArguments;
		
		public virtual OrderedSet<EGenericType> eTypeArguments
		{
			get {
				if(_eTypeArguments==null){
					_eTypeArguments = new OrderedSet<EGenericType>(this, EcorePackageImpl.EGENERICTYPE_ETYPEARGUMENTS, EOPPOSITE_FEATURE_BASE - EcorePackageImpl.EGENERICTYPE_ETYPEARGUMENTS);
				}
				return _eTypeArguments;
			}
		
		}
		public virtual EClassifier eRawType
		{
			get {
			
				//TODO implement derivation
				return default(EClassifier);
			}
		}
		public virtual bool isInstance(object object_
		)
		{
		    throw new NotImplementedException();
		}
		
		protected override EClass eStaticClass() {
			return EcorePackageImpl.Literals.EGENERICTYPE;
		}
		
		
		public NotificationChain basicSetELowerBound(EGenericType newobj, NotificationChain msgs) {
			var oldobj = _eLowerBound;
			_eLowerBound = newobj;
			if (eNotificationRequired()) {
				var notification = new ENotificationImpl(this, NotificationImpl.SET, EcorePackageImpl.EGENERICTYPE_ELOWERBOUND, oldobj, newobj);
				if (msgs == null){
					msgs = notification;
				}
				else{
					msgs.add(notification);
				}
			}
			return msgs;
		}
		public NotificationChain basicSetETypeParameter(ETypeParameter newobj, NotificationChain msgs) {
			var oldobj = _eTypeParameter;
			_eTypeParameter = newobj;
			if (eNotificationRequired()) {
				var notification = new ENotificationImpl(this, NotificationImpl.SET, EcorePackageImpl.EGENERICTYPE_ETYPEPARAMETER, oldobj, newobj);
				if (msgs == null){
					msgs = notification;
				}
				else{
					msgs.add(notification);
				}
			}
			return msgs;
		}
		public NotificationChain basicSetEUpperBound(EGenericType newobj, NotificationChain msgs) {
			var oldobj = _eUpperBound;
			_eUpperBound = newobj;
			if (eNotificationRequired()) {
				var notification = new ENotificationImpl(this, NotificationImpl.SET, EcorePackageImpl.EGENERICTYPE_EUPPERBOUND, oldobj, newobj);
				if (msgs == null){
					msgs = notification;
				}
				else{
					msgs.add(notification);
				}
			}
			return msgs;
		}
		public NotificationChain basicSetEClassifier(EClassifier newobj, NotificationChain msgs) {
			var oldobj = _eClassifier;
			_eClassifier = newobj;
			if (eNotificationRequired()) {
				var notification = new ENotificationImpl(this, NotificationImpl.SET, EcorePackageImpl.EGENERICTYPE_ECLASSIFIER, oldobj, newobj);
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
				case EcorePackageImpl.EGENERICTYPE_EUPPERBOUND:
					return eUpperBound;
				case EcorePackageImpl.EGENERICTYPE_ETYPEARGUMENTS:
					return eTypeArguments;
				case EcorePackageImpl.EGENERICTYPE_ERAWTYPE:
					return eRawType;
				case EcorePackageImpl.EGENERICTYPE_ELOWERBOUND:
					return eLowerBound;
				case EcorePackageImpl.EGENERICTYPE_ETYPEPARAMETER:
					return eTypeParameter;
				case EcorePackageImpl.EGENERICTYPE_ECLASSIFIER:
					return eClassifier;
			}
			return base.eGet(featureID, resolve, coreType);
		}
		
		
		public override void eSet(int featureID, object newValue) {
			switch (featureID) {
				case EcorePackageImpl.EGENERICTYPE_EUPPERBOUND:
					eUpperBound = (EGenericType) newValue;
					return;
				case EcorePackageImpl.EGENERICTYPE_ETYPEARGUMENTS:
					eTypeArguments.Clear();
					eTypeArguments.AddRange(((List<EObject>)newValue)?.Cast<EGenericType>());
					return;
				case EcorePackageImpl.EGENERICTYPE_ELOWERBOUND:
					eLowerBound = (EGenericType) newValue;
					return;
				case EcorePackageImpl.EGENERICTYPE_ETYPEPARAMETER:
					eTypeParameter = (ETypeParameter) newValue;
					return;
				case EcorePackageImpl.EGENERICTYPE_ECLASSIFIER:
					eClassifier = (EClassifier) newValue;
					return;
			}
			base.eSet(featureID, newValue);
		}
		
		
	}
}
