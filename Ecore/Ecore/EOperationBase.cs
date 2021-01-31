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
	public class EOperationBase 
	:ETypedElementImpl, EOperation
	{
		public virtual EClass eContainingClass
		{
			get {
			
				if (eContainerFeatureID() != EcorePackageImpl.EOPERATION_ECONTAININGCLASS) return default(EClass);
				return (EClass)eInternalContainer();
			}
		}
		private OrderedSet<EParameter> _eParameters;
		
		public virtual OrderedSet<EParameter> eParameters
		{
			get {
				if(_eParameters==null){
					_eParameters = new OrderedSet<EParameter>(this, EcorePackageImpl.EOPERATION_EPARAMETERS, EcorePackageImpl.EPARAMETER_EOPERATION);
				}
				return _eParameters;
			}
		
		}
		private OrderedSet<EGenericType> _eGenericExceptions;
		
		public virtual OrderedSet<EGenericType> eGenericExceptions
		{
			get {
				if(_eGenericExceptions==null){
					_eGenericExceptions = new OrderedSet<EGenericType>(this, EcorePackageImpl.EOPERATION_EGENERICEXCEPTIONS, EOPPOSITE_FEATURE_BASE - EcorePackageImpl.EOPERATION_EGENERICEXCEPTIONS);
				}
				return _eGenericExceptions;
			}
		
		}
		private OrderedSet<ETypeParameter> _eTypeParameters;
		
		public virtual OrderedSet<ETypeParameter> eTypeParameters
		{
			get {
				if(_eTypeParameters==null){
					_eTypeParameters = new OrderedSet<ETypeParameter>(this, EcorePackageImpl.EOPERATION_ETYPEPARAMETERS, EOPPOSITE_FEATURE_BASE - EcorePackageImpl.EOPERATION_ETYPEPARAMETERS);
				}
				return _eTypeParameters;
			}
		
		}
		private OrderedSet<EClassifier> _eExceptions;
		
		public virtual OrderedSet<EClassifier> eExceptions
		{
			get {
				if(_eExceptions==null){
					_eExceptions = new OrderedSet<EClassifier>(this, EcorePackageImpl.EOPERATION_EEXCEPTIONS, EOPPOSITE_FEATURE_BASE - EcorePackageImpl.EOPERATION_EEXCEPTIONS);
				}
				return _eExceptions;
			}
		
		}
		public virtual bool isOverrideOf(EOperation someOperation
		)
		{
		    throw new NotImplementedException();
		}
		public virtual int getOperationID()
		{
		    throw new NotImplementedException();
		}
		
		protected override EClass eStaticClass() {
			return EcorePackageImpl.Literals.EOPERATION;
		}
		
		public override NotificationChain eInverseAdd(InternalEObject otherEnd, int featureID, NotificationChain msgs) {
			switch (featureID) {
				case EcorePackageImpl.EOPERATION_ECONTAININGCLASS:
					if (eInternalContainer() != null) {
						msgs = eBasicRemoveFromContainer(msgs);
					}
					return basicSetEContainingClass((EClass)otherEnd, msgs);
				case EcorePackageImpl.EOPERATION_EPARAMETERS:
					return eParameters.basicAdd((EParameter)otherEnd, msgs);
			}
			return base.eInverseAdd(otherEnd, featureID, msgs);
		}
		
		public override NotificationChain eInverseRemove(InternalEObject otherEnd, int featureID, NotificationChain msgs) {
			switch (featureID) {
				case EcorePackageImpl.EOPERATION_ECONTAININGCLASS:
					return basicSetEContainingClass(null, msgs);
				case EcorePackageImpl.EOPERATION_EPARAMETERS:
					return eParameters.basicRemove((EParameter)otherEnd, msgs);
			}
			return base.eInverseRemove(otherEnd, featureID, msgs);
		}
		
		public NotificationChain basicSetEContainingClass(EClass newobj, NotificationChain msgs) {
				msgs = eBasicSetContainer((InternalEObject)newobj, EcorePackageImpl.EOPERATION_ECONTAININGCLASS, msgs);
				return msgs;
		}
		
		public override Object eGet(int featureID, bool resolve, bool coreType) {
			switch (featureID) {
				case EcorePackageImpl.EOPERATION_EANNOTATIONS:
					return eAnnotations;
				case EcorePackageImpl.EOPERATION_NAME:
					return name;
				case EcorePackageImpl.EOPERATION_ORDERED:
					return ordered;
				case EcorePackageImpl.EOPERATION_UNIQUE:
					return unique;
				case EcorePackageImpl.EOPERATION_LOWERBOUND:
					return lowerBound;
				case EcorePackageImpl.EOPERATION_UPPERBOUND:
					return upperBound;
				case EcorePackageImpl.EOPERATION_MANY:
					return many;
				case EcorePackageImpl.EOPERATION_REQUIRED:
					return required;
				case EcorePackageImpl.EOPERATION_ETYPE:
					return eType;
				case EcorePackageImpl.EOPERATION_EGENERICTYPE:
					return eGenericType;
				case EcorePackageImpl.EOPERATION_ECONTAININGCLASS:
					return eContainingClass;
				case EcorePackageImpl.EOPERATION_ETYPEPARAMETERS:
					return eTypeParameters;
				case EcorePackageImpl.EOPERATION_EPARAMETERS:
					return eParameters;
				case EcorePackageImpl.EOPERATION_EEXCEPTIONS:
					return eExceptions;
				case EcorePackageImpl.EOPERATION_EGENERICEXCEPTIONS:
					return eGenericExceptions;
			}
			return base.eGet(featureID, resolve, coreType);
		}
		
		
		public override void eSet(int featureID, object newValue) {
			switch (featureID) {
				case EcorePackageImpl.EOPERATION_EANNOTATIONS:
					eAnnotations.Clear();
					eAnnotations.AddRange(((List<EObject>)newValue)?.Cast<EAnnotation>());
					return;
				case EcorePackageImpl.EOPERATION_NAME:
					name = (string) newValue;
					return;
				case EcorePackageImpl.EOPERATION_ORDERED:
					ordered = (bool) newValue;
					return;
				case EcorePackageImpl.EOPERATION_UNIQUE:
					unique = (bool) newValue;
					return;
				case EcorePackageImpl.EOPERATION_LOWERBOUND:
					lowerBound = (int) newValue;
					return;
				case EcorePackageImpl.EOPERATION_UPPERBOUND:
					upperBound = (int) newValue;
					return;
				case EcorePackageImpl.EOPERATION_ETYPE:
					eType = (EClassifier) newValue;
					return;
				case EcorePackageImpl.EOPERATION_EGENERICTYPE:
					eGenericType = (EGenericType) newValue;
					return;
				case EcorePackageImpl.EOPERATION_ETYPEPARAMETERS:
					eTypeParameters.Clear();
					eTypeParameters.AddRange(((List<EObject>)newValue)?.Cast<ETypeParameter>());
					return;
				case EcorePackageImpl.EOPERATION_EPARAMETERS:
					eParameters.Clear();
					eParameters.AddRange(((List<EObject>)newValue)?.Cast<EParameter>());
					return;
				case EcorePackageImpl.EOPERATION_EEXCEPTIONS:
					eExceptions.Clear();
					eExceptions.AddRange(((List<EObject>)newValue)?.Cast<EClassifier>());
					return;
				case EcorePackageImpl.EOPERATION_EGENERICEXCEPTIONS:
					eGenericExceptions.Clear();
					eGenericExceptions.AddRange(((List<EObject>)newValue)?.Cast<EGenericType>());
					return;
			}
			base.eSet(featureID, newValue);
		}
		
		
	}
}
