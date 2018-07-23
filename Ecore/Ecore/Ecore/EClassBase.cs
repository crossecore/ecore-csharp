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
	public class EClassBase 
	:EClassifierImpl, EClass
	{
		private bool _abstract = false;
		public virtual bool abstract_
		{
		get { 
			return _abstract;
		}
		set { _abstract = value; }
		}
		private bool _interface = false;
		public virtual bool interface_
		{
		get { 
			return _interface;
		}
		set { _interface = value; }
		}
		
		public virtual OrderedSet<EAttribute> eAllAttributes
		{
			get {
				//TODO implement derivation
				return default(OrderedSet<EAttribute>);
			}
		
		}
		
		public virtual OrderedSet<EOperation> eAllOperations
		{
			get {
				//TODO implement derivation
				return default(OrderedSet<EOperation>);
			}
		
		}
		
		public virtual OrderedSet<EReference> eAllContainments
		{
			get {
				//TODO implement derivation
				return default(OrderedSet<EReference>);
			}
		
		}
		private OrderedSet<EStructuralFeature> _eStructuralFeatures;
		
		public virtual OrderedSet<EStructuralFeature> eStructuralFeatures
		{
			get {
				if(_eStructuralFeatures==null){
					_eStructuralFeatures = new OrderedSet<EStructuralFeature>(this, EcorePackageImpl.ECLASS_ESTRUCTURALFEATURES, EcorePackageImpl.ESTRUCTURALFEATURE_ECONTAININGCLASS);
				}
				return _eStructuralFeatures;
			}
		
		}
		
		public virtual OrderedSet<EClass> eAllSuperTypes
		{
			get {
				//TODO implement derivation
				return default(OrderedSet<EClass>);
			}
		
		}
		
		public virtual OrderedSet<EReference> eReferences
		{
			get {
				//TODO implement derivation
				return default(OrderedSet<EReference>);
			}
		
		}
		public virtual EAttribute eIDAttribute
		{
			get {
			
				//TODO implement derivation
				return default(EAttribute);
			}
		}
		
		public virtual OrderedSet<EReference> eAllReferences
		{
			get {
				//TODO implement derivation
				return default(OrderedSet<EReference>);
			}
		
		}
		
		public virtual OrderedSet<EAttribute> eAttributes
		{
			get {
				//TODO implement derivation
				return default(OrderedSet<EAttribute>);
			}
		
		}
		private OrderedSet<EClass> _eSuperTypes;
		
		public virtual OrderedSet<EClass> eSuperTypes
		{
			get {
				if(_eSuperTypes==null){
					_eSuperTypes = new OrderedSet<EClass>(this, EcorePackageImpl.ECLASS_ESUPERTYPES, EOPPOSITE_FEATURE_BASE - EcorePackageImpl.ECLASS_ESUPERTYPES);
				}
				return _eSuperTypes;
			}
		
		}
		
		public virtual OrderedSet<EStructuralFeature> eAllStructuralFeatures
		{
			get {
				//TODO implement derivation
				return default(OrderedSet<EStructuralFeature>);
			}
		
		}
		private OrderedSet<EGenericType> _eGenericSuperTypes;
		
		public virtual OrderedSet<EGenericType> eGenericSuperTypes
		{
			get {
				if(_eGenericSuperTypes==null){
					_eGenericSuperTypes = new OrderedSet<EGenericType>(this, EcorePackageImpl.ECLASS_EGENERICSUPERTYPES, EOPPOSITE_FEATURE_BASE - EcorePackageImpl.ECLASS_EGENERICSUPERTYPES);
				}
				return _eGenericSuperTypes;
			}
		
		}
		
		public virtual OrderedSet<EGenericType> eAllGenericSuperTypes
		{
			get {
				//TODO implement derivation
				return default(OrderedSet<EGenericType>);
			}
		
		}
		private OrderedSet<EOperation> _eOperations;
		
		public virtual OrderedSet<EOperation> eOperations
		{
			get {
				if(_eOperations==null){
					_eOperations = new OrderedSet<EOperation>(this, EcorePackageImpl.ECLASS_EOPERATIONS, EcorePackageImpl.EOPERATION_ECONTAININGCLASS);
				}
				return _eOperations;
			}
		
		}
		public virtual int getFeatureCount()
		{
		    throw new NotImplementedException();
		}
		public virtual bool isSuperTypeOf(EClass someClass
		)
		{
		    throw new NotImplementedException();
		}
		public virtual int getOperationCount()
		{
		    throw new NotImplementedException();
		}
		public virtual int getFeatureID(EStructuralFeature feature
		)
		{
		    throw new NotImplementedException();
		}
		public virtual EOperation getEOperation(int operationID
		)
		{
		    throw new NotImplementedException();
		}
		public virtual EStructuralFeature getEStructuralFeature(int featureID
		)
		{
		    throw new NotImplementedException();
		}
		public virtual EOperation getOverride(EOperation operation
		)
		{
		    throw new NotImplementedException();
		}
		public virtual EGenericType getFeatureType(EStructuralFeature feature
		)
		{
		    throw new NotImplementedException();
		}
		public virtual EStructuralFeature getEStructuralFeature(string featureName
		)
		{
		    throw new NotImplementedException();
		}
		public virtual int getOperationID(EOperation operation
		)
		{
		    throw new NotImplementedException();
		}
		
		protected override EClass eStaticClass() {
			return EcorePackageImpl.Literals.ECLASS;
		}
		
		public override NotificationChain eInverseAdd(InternalEObject otherEnd, int featureID, NotificationChain msgs) {
			switch (featureID) {
				case EcorePackageImpl.ECLASS_ESTRUCTURALFEATURES:
					return eStructuralFeatures.basicAdd((EStructuralFeature)otherEnd, msgs);
				case EcorePackageImpl.ECLASS_EOPERATIONS:
					return eOperations.basicAdd((EOperation)otherEnd, msgs);
			}
			return base.eInverseAdd(otherEnd, featureID, msgs);
		}
		
		public override NotificationChain eInverseRemove(InternalEObject otherEnd, int featureID, NotificationChain msgs) {
			switch (featureID) {
				case EcorePackageImpl.ECLASS_ESTRUCTURALFEATURES:
					return eStructuralFeatures.basicRemove((EStructuralFeature)otherEnd, msgs);
				case EcorePackageImpl.ECLASS_EOPERATIONS:
					return eOperations.basicRemove((EOperation)otherEnd, msgs);
			}
			return base.eInverseRemove(otherEnd, featureID, msgs);
		}
		
		
		public override Object eGet(int featureID, bool resolve, bool coreType) {
			switch (featureID) {
				case EcorePackageImpl.ECLASS_EANNOTATIONS:
					return eAnnotations;
				case EcorePackageImpl.ECLASS_NAME:
					return name;
				case EcorePackageImpl.ECLASS_INSTANCECLASSNAME:
					return instanceClassName;
				case EcorePackageImpl.ECLASS_INSTANCECLASS:
					return instanceClass;
				case EcorePackageImpl.ECLASS_DEFAULTVALUE:
					return defaultValue;
				case EcorePackageImpl.ECLASS_INSTANCETYPENAME:
					return instanceTypeName;
				case EcorePackageImpl.ECLASS_EPACKAGE:
					return ePackage;
				case EcorePackageImpl.ECLASS_ETYPEPARAMETERS:
					return eTypeParameters;
				case EcorePackageImpl.ECLASS_ABSTRACT:
					return abstract_;
				case EcorePackageImpl.ECLASS_INTERFACE:
					return interface_;
				case EcorePackageImpl.ECLASS_ESUPERTYPES:
					return eSuperTypes;
				case EcorePackageImpl.ECLASS_EOPERATIONS:
					return eOperations;
				case EcorePackageImpl.ECLASS_EALLATTRIBUTES:
					return eAllAttributes;
				case EcorePackageImpl.ECLASS_EALLREFERENCES:
					return eAllReferences;
				case EcorePackageImpl.ECLASS_EREFERENCES:
					return eReferences;
				case EcorePackageImpl.ECLASS_EATTRIBUTES:
					return eAttributes;
				case EcorePackageImpl.ECLASS_EALLCONTAINMENTS:
					return eAllContainments;
				case EcorePackageImpl.ECLASS_EALLOPERATIONS:
					return eAllOperations;
				case EcorePackageImpl.ECLASS_EALLSTRUCTURALFEATURES:
					return eAllStructuralFeatures;
				case EcorePackageImpl.ECLASS_EALLSUPERTYPES:
					return eAllSuperTypes;
				case EcorePackageImpl.ECLASS_EIDATTRIBUTE:
					return eIDAttribute;
				case EcorePackageImpl.ECLASS_ESTRUCTURALFEATURES:
					return eStructuralFeatures;
				case EcorePackageImpl.ECLASS_EGENERICSUPERTYPES:
					return eGenericSuperTypes;
				case EcorePackageImpl.ECLASS_EALLGENERICSUPERTYPES:
					return eAllGenericSuperTypes;
			}
			return base.eGet(featureID, resolve, coreType);
		}
		
		
		public override void eSet(int featureID, object newValue) {
			switch (featureID) {
				case EcorePackageImpl.ECLASS_EANNOTATIONS:
					eAnnotations.Clear();
					eAnnotations.AddRange(((List<EObject>)newValue)?.Cast<EAnnotation>());
					return;
				case EcorePackageImpl.ECLASS_NAME:
					name = (string) newValue;
					return;
				case EcorePackageImpl.ECLASS_INSTANCECLASSNAME:
					instanceClassName = (string) newValue;
					return;
				case EcorePackageImpl.ECLASS_INSTANCETYPENAME:
					instanceTypeName = (string) newValue;
					return;
				case EcorePackageImpl.ECLASS_ETYPEPARAMETERS:
					eTypeParameters.Clear();
					eTypeParameters.AddRange(((List<EObject>)newValue)?.Cast<ETypeParameter>());
					return;
				case EcorePackageImpl.ECLASS_ABSTRACT:
					abstract_ = (bool) newValue;
					return;
				case EcorePackageImpl.ECLASS_INTERFACE:
					interface_ = (bool) newValue;
					return;
				case EcorePackageImpl.ECLASS_ESUPERTYPES:
					eSuperTypes.Clear();
					eSuperTypes.AddRange(((List<EObject>)newValue)?.Cast<EClass>());
					return;
				case EcorePackageImpl.ECLASS_EOPERATIONS:
					eOperations.Clear();
					eOperations.AddRange(((List<EObject>)newValue)?.Cast<EOperation>());
					return;
				case EcorePackageImpl.ECLASS_ESTRUCTURALFEATURES:
					eStructuralFeatures.Clear();
					eStructuralFeatures.AddRange(((List<EObject>)newValue)?.Cast<EStructuralFeature>());
					return;
				case EcorePackageImpl.ECLASS_EGENERICSUPERTYPES:
					eGenericSuperTypes.Clear();
					eGenericSuperTypes.AddRange(((List<EObject>)newValue)?.Cast<EGenericType>());
					return;
			}
			base.eSet(featureID, newValue);
		}
		
		
	}
}
