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
	public class ETypedElementBase 
	:ENamedElementImpl, ETypedElement
	{
		private bool _unique = false;
		public virtual bool unique
		{
		get { 
			return _unique;
		}
		set { _unique = value; }
		}
		private bool _ordered = false;
		public virtual bool ordered
		{
		get { 
			return _ordered;
		}
		set { _ordered = value; }
		}
		private int _lowerBound = 0;
		public virtual int lowerBound
		{
		get { 
			return _lowerBound;
		}
		set { _lowerBound = value; }
		}
		private int _upperBound = 0;
		public virtual int upperBound
		{
		get { 
			return _upperBound;
		}
		set { _upperBound = value; }
		}
		public virtual bool many
		{
		get { 
			//TODO implement derivation
			return default(bool);
		}
		}
		public virtual bool required
		{
		get { 
			//TODO implement derivation
			return default(bool);
		}
		}
		private EGenericType _eGenericType;
		public virtual EGenericType eGenericType
		{
			get {
			
				return _eGenericType;
			}
			set {
				if (value != _eGenericType) {
					NotificationChain msgs = null;
					if (_eGenericType != null){
						msgs = ((InternalEObject)_eGenericType).eInverseRemove(this, EOPPOSITE_FEATURE_BASE - EcorePackageImpl.ETYPEDELEMENT_EGENERICTYPE, null, msgs);
					}
					if (value != null){
						msgs = ((InternalEObject)value).eInverseAdd(this, EOPPOSITE_FEATURE_BASE - EcorePackageImpl.ETYPEDELEMENT_EGENERICTYPE, null, msgs);
					}
					msgs = basicSetEGenericType(value, msgs);
					if (msgs != null) {
						msgs.dispatch();
					}
				}
				else if (eNotificationRequired()){
					eNotify(new ENotificationImpl(this, NotificationImpl.SET,EcorePackageImpl.ETYPEDELEMENT_EGENERICTYPE , value, value));
				}
				}
		}
		private EClassifier _eType;
		public virtual EClassifier eType
		{
			get {
			
				return _eType;
			}
			set {
				var oldvalue = _eType;
				_eType = value;
				if (eNotificationRequired()){
					eNotify(new ENotificationImpl(this, NotificationImpl.SET,EcorePackageImpl.ETYPEDELEMENT_ETYPE , oldvalue, value));
				}
				}
		}
		
		protected override EClass eStaticClass() {
			return EcorePackageImpl.Literals.ETYPEDELEMENT;
		}
		
		
		public NotificationChain basicSetEGenericType(EGenericType newobj, NotificationChain msgs) {
			var oldobj = _eGenericType;
			_eGenericType = newobj;
			if (eNotificationRequired()) {
				var notification = new ENotificationImpl(this, NotificationImpl.SET, EcorePackageImpl.ETYPEDELEMENT_EGENERICTYPE, oldobj, newobj);
				if (msgs == null){
					msgs = notification;
				}
				else{
					msgs.add(notification);
				}
			}
			return msgs;
		}
		public NotificationChain basicSetEType(EClassifier newobj, NotificationChain msgs) {
			var oldobj = _eType;
			_eType = newobj;
			if (eNotificationRequired()) {
				var notification = new ENotificationImpl(this, NotificationImpl.SET, EcorePackageImpl.ETYPEDELEMENT_ETYPE, oldobj, newobj);
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
				case EcorePackageImpl.ETYPEDELEMENT_EANNOTATIONS:
					return eAnnotations;
				case EcorePackageImpl.ETYPEDELEMENT_NAME:
					return name;
				case EcorePackageImpl.ETYPEDELEMENT_ORDERED:
					return ordered;
				case EcorePackageImpl.ETYPEDELEMENT_UNIQUE:
					return unique;
				case EcorePackageImpl.ETYPEDELEMENT_LOWERBOUND:
					return lowerBound;
				case EcorePackageImpl.ETYPEDELEMENT_UPPERBOUND:
					return upperBound;
				case EcorePackageImpl.ETYPEDELEMENT_MANY:
					return many;
				case EcorePackageImpl.ETYPEDELEMENT_REQUIRED:
					return required;
				case EcorePackageImpl.ETYPEDELEMENT_ETYPE:
					return eType;
				case EcorePackageImpl.ETYPEDELEMENT_EGENERICTYPE:
					return eGenericType;
			}
			return base.eGet(featureID, resolve, coreType);
		}
		
		
		public override void eSet(int featureID, object newValue) {
			switch (featureID) {
				case EcorePackageImpl.ETYPEDELEMENT_EANNOTATIONS:
					eAnnotations.Clear();
					eAnnotations.AddRange(((List<EObject>)newValue)?.Cast<EAnnotation>());
					return;
				case EcorePackageImpl.ETYPEDELEMENT_NAME:
					name = (string) newValue;
					return;
				case EcorePackageImpl.ETYPEDELEMENT_ORDERED:
					ordered = (bool) newValue;
					return;
				case EcorePackageImpl.ETYPEDELEMENT_UNIQUE:
					unique = (bool) newValue;
					return;
				case EcorePackageImpl.ETYPEDELEMENT_LOWERBOUND:
					lowerBound = (int) newValue;
					return;
				case EcorePackageImpl.ETYPEDELEMENT_UPPERBOUND:
					upperBound = (int) newValue;
					return;
				case EcorePackageImpl.ETYPEDELEMENT_ETYPE:
					eType = (EClassifier) newValue;
					return;
				case EcorePackageImpl.ETYPEDELEMENT_EGENERICTYPE:
					eGenericType = (EGenericType) newValue;
					return;
			}
			base.eSet(featureID, newValue);
		}
		
		
	}
}
