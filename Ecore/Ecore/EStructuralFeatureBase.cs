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
	public class EStructuralFeatureBase 
	:ETypedElementImpl, EStructuralFeature
	{
		private bool _changeable = false;
		public virtual bool changeable
		{
		get { 
			return _changeable;
		}
		set { _changeable = value; }
		}
		private bool _unsettable = false;
		public virtual bool unsettable
		{
		get { 
			return _unsettable;
		}
		set { _unsettable = value; }
		}
		private bool _derived = false;
		public virtual bool derived
		{
		get { 
			return _derived;
		}
		set { _derived = value; }
		}
		private bool _transient = false;
		public virtual bool transient
		{
		get { 
			return _transient;
		}
		set { _transient = value; }
		}
		private bool _volatile = false;
		public virtual bool volatile_
		{
		get { 
			return _volatile;
		}
		set { _volatile = value; }
		}
		public virtual object defaultValue
		{
		get { 
			//TODO implement derivation
			return default(object);
		}
		}
		private string _defaultValueLiteral = "";
		public virtual string defaultValueLiteral
		{
		get { 
			return _defaultValueLiteral;
		}
		set { _defaultValueLiteral = value; }
		}
		public virtual EClass eContainingClass
		{
			get {
			
				if (eContainerFeatureID() != EcorePackageImpl.ESTRUCTURALFEATURE_ECONTAININGCLASS) return default(EClass);
				return (EClass)eInternalContainer();
			}
		}
		public virtual Type getContainerClass()
		{
		    throw new NotImplementedException();
		}
		public virtual int getFeatureID()
		{
		    throw new NotImplementedException();
		}
		
		protected override EClass eStaticClass() {
			return EcorePackageImpl.Literals.ESTRUCTURALFEATURE;
		}
		
		public override NotificationChain eInverseAdd(InternalEObject otherEnd, int featureID, NotificationChain msgs) {
			switch (featureID) {
				case EcorePackageImpl.ESTRUCTURALFEATURE_ECONTAININGCLASS:
					if (eInternalContainer() != null) {
						msgs = eBasicRemoveFromContainer(msgs);
					}
					return basicSetEContainingClass((EClass)otherEnd, msgs);
			}
			return base.eInverseAdd(otherEnd, featureID, msgs);
		}
		
		public override NotificationChain eInverseRemove(InternalEObject otherEnd, int featureID, NotificationChain msgs) {
			switch (featureID) {
				case EcorePackageImpl.ESTRUCTURALFEATURE_ECONTAININGCLASS:
					return basicSetEContainingClass(null, msgs);
			}
			return base.eInverseRemove(otherEnd, featureID, msgs);
		}
		
		public NotificationChain basicSetEContainingClass(EClass newobj, NotificationChain msgs) {
				msgs = eBasicSetContainer((InternalEObject)newobj, EcorePackageImpl.ESTRUCTURALFEATURE_ECONTAININGCLASS, msgs);
				return msgs;
		}
		
		public override Object eGet(int featureID, bool resolve, bool coreType) {
			switch (featureID) {
				case EcorePackageImpl.ESTRUCTURALFEATURE_EANNOTATIONS:
					return eAnnotations;
				case EcorePackageImpl.ESTRUCTURALFEATURE_NAME:
					return name;
				case EcorePackageImpl.ESTRUCTURALFEATURE_ORDERED:
					return ordered;
				case EcorePackageImpl.ESTRUCTURALFEATURE_UNIQUE:
					return unique;
				case EcorePackageImpl.ESTRUCTURALFEATURE_LOWERBOUND:
					return lowerBound;
				case EcorePackageImpl.ESTRUCTURALFEATURE_UPPERBOUND:
					return upperBound;
				case EcorePackageImpl.ESTRUCTURALFEATURE_MANY:
					return many;
				case EcorePackageImpl.ESTRUCTURALFEATURE_REQUIRED:
					return required;
				case EcorePackageImpl.ESTRUCTURALFEATURE_ETYPE:
					return eType;
				case EcorePackageImpl.ESTRUCTURALFEATURE_EGENERICTYPE:
					return eGenericType;
				case EcorePackageImpl.ESTRUCTURALFEATURE_CHANGEABLE:
					return changeable;
				case EcorePackageImpl.ESTRUCTURALFEATURE_VOLATILE:
					return volatile_;
				case EcorePackageImpl.ESTRUCTURALFEATURE_TRANSIENT:
					return transient;
				case EcorePackageImpl.ESTRUCTURALFEATURE_DEFAULTVALUELITERAL:
					return defaultValueLiteral;
				case EcorePackageImpl.ESTRUCTURALFEATURE_DEFAULTVALUE:
					return defaultValue;
				case EcorePackageImpl.ESTRUCTURALFEATURE_UNSETTABLE:
					return unsettable;
				case EcorePackageImpl.ESTRUCTURALFEATURE_DERIVED:
					return derived;
				case EcorePackageImpl.ESTRUCTURALFEATURE_ECONTAININGCLASS:
					return eContainingClass;
			}
			return base.eGet(featureID, resolve, coreType);
		}
		
		
		public override void eSet(int featureID, object newValue) {
			switch (featureID) {
				case EcorePackageImpl.ESTRUCTURALFEATURE_EANNOTATIONS:
					eAnnotations.Clear();
					eAnnotations.AddRange(((List<EObject>)newValue)?.Cast<EAnnotation>());
					return;
				case EcorePackageImpl.ESTRUCTURALFEATURE_NAME:
					name = (string) newValue;
					return;
				case EcorePackageImpl.ESTRUCTURALFEATURE_ORDERED:
					ordered = (bool) newValue;
					return;
				case EcorePackageImpl.ESTRUCTURALFEATURE_UNIQUE:
					unique = (bool) newValue;
					return;
				case EcorePackageImpl.ESTRUCTURALFEATURE_LOWERBOUND:
					lowerBound = (int) newValue;
					return;
				case EcorePackageImpl.ESTRUCTURALFEATURE_UPPERBOUND:
					upperBound = (int) newValue;
					return;
				case EcorePackageImpl.ESTRUCTURALFEATURE_ETYPE:
					eType = (EClassifier) newValue;
					return;
				case EcorePackageImpl.ESTRUCTURALFEATURE_EGENERICTYPE:
					eGenericType = (EGenericType) newValue;
					return;
				case EcorePackageImpl.ESTRUCTURALFEATURE_CHANGEABLE:
					changeable = (bool) newValue;
					return;
				case EcorePackageImpl.ESTRUCTURALFEATURE_VOLATILE:
					volatile_ = (bool) newValue;
					return;
				case EcorePackageImpl.ESTRUCTURALFEATURE_TRANSIENT:
					transient = (bool) newValue;
					return;
				case EcorePackageImpl.ESTRUCTURALFEATURE_DEFAULTVALUELITERAL:
					defaultValueLiteral = (string) newValue;
					return;
				case EcorePackageImpl.ESTRUCTURALFEATURE_UNSETTABLE:
					unsettable = (bool) newValue;
					return;
				case EcorePackageImpl.ESTRUCTURALFEATURE_DERIVED:
					derived = (bool) newValue;
					return;
			}
			base.eSet(featureID, newValue);
		}
		
		
	}
}
