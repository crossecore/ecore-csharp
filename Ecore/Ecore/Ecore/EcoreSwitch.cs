/* CrossEcore is a cross-platform modeling framework that generates C#, TypeScript, 
 * JavaScript, Swift code from Ecore models with embedded OCL (http://www.crossecore.org/).
 * The original Eclipse Modeling Framework is available at https://www.eclipse.org/modeling/emf/.
 * 
 * contributor: Simon Schwichtenberg
 */
 
namespace Ecore{
	public class EcoreSwitch<T> : Switch<T> {
	
		protected static EcorePackage modelPackage;
		
		protected override bool isSwitchFor(EPackage ePackage)
		{
			return ePackage == modelPackage;
		}

		public EcoreSwitch()
		{
			if (modelPackage == null)
			{
				modelPackage = EcorePackageImpl.eINSTANCE;
			}
		}
		
		protected override T doSwitch(int classifierID, EObject theEObject) {
			switch (classifierID) {
				case EcorePackageImpl.EATTRIBUTE: {
					var eattribute = (EAttribute) theEObject;
					var result = caseEAttribute(eattribute);
					
					if (result == null) result = caseEModelElement(eattribute);
					if (result == null) result = caseENamedElement(eattribute);
					if (result == null) result = caseETypedElement(eattribute);
					if (result == null) result = caseEStructuralFeature(eattribute);
					
					if (result == null) result = defaultCase(theEObject);
					return result;
				}
				case EcorePackageImpl.EANNOTATION: {
					var eannotation = (EAnnotation) theEObject;
					var result = caseEAnnotation(eannotation);
					
					if (result == null) result = caseEModelElement(eannotation);
					
					if (result == null) result = defaultCase(theEObject);
					return result;
				}
				case EcorePackageImpl.ECLASS: {
					var eclass = (EClass) theEObject;
					var result = caseEClass(eclass);
					
					if (result == null) result = caseEModelElement(eclass);
					if (result == null) result = caseENamedElement(eclass);
					if (result == null) result = caseEClassifier(eclass);
					
					if (result == null) result = defaultCase(theEObject);
					return result;
				}
				case EcorePackageImpl.ECLASSIFIER: {
					var eclassifier = (EClassifier) theEObject;
					var result = caseEClassifier(eclassifier);
					
					if (result == null) result = caseEModelElement(eclassifier);
					if (result == null) result = caseENamedElement(eclassifier);
					
					if (result == null) result = defaultCase(theEObject);
					return result;
				}
				case EcorePackageImpl.EDATATYPE: {
					var edatatype = (EDataType) theEObject;
					var result = caseEDataType(edatatype);
					
					if (result == null) result = caseEModelElement(edatatype);
					if (result == null) result = caseENamedElement(edatatype);
					if (result == null) result = caseEClassifier(edatatype);
					
					if (result == null) result = defaultCase(theEObject);
					return result;
				}
				case EcorePackageImpl.EENUM: {
					var eenum = (EEnum) theEObject;
					var result = caseEEnum(eenum);
					
					if (result == null) result = caseEModelElement(eenum);
					if (result == null) result = caseENamedElement(eenum);
					if (result == null) result = caseEClassifier(eenum);
					if (result == null) result = caseEDataType(eenum);
					
					if (result == null) result = defaultCase(theEObject);
					return result;
				}
				case EcorePackageImpl.EENUMLITERAL: {
					var eenumliteral = (EEnumLiteral) theEObject;
					var result = caseEEnumLiteral(eenumliteral);
					
					if (result == null) result = caseEModelElement(eenumliteral);
					if (result == null) result = caseENamedElement(eenumliteral);
					
					if (result == null) result = defaultCase(theEObject);
					return result;
				}
				case EcorePackageImpl.EFACTORY: {
					var efactory = (EFactory) theEObject;
					var result = caseEFactory(efactory);
					
					if (result == null) result = caseEModelElement(efactory);
					
					if (result == null) result = defaultCase(theEObject);
					return result;
				}
				case EcorePackageImpl.EMODELELEMENT: {
					var emodelelement = (EModelElement) theEObject;
					var result = caseEModelElement(emodelelement);
					
					
					if (result == null) result = defaultCase(theEObject);
					return result;
				}
				case EcorePackageImpl.ENAMEDELEMENT: {
					var enamedelement = (ENamedElement) theEObject;
					var result = caseENamedElement(enamedelement);
					
					if (result == null) result = caseEModelElement(enamedelement);
					
					if (result == null) result = defaultCase(theEObject);
					return result;
				}
				case EcorePackageImpl.EOBJECT: {
					var eobject = (EObject) theEObject;
					var result = caseEObject(eobject);
					
					
					if (result == null) result = defaultCase(theEObject);
					return result;
				}
				case EcorePackageImpl.EOPERATION: {
					var eoperation = (EOperation) theEObject;
					var result = caseEOperation(eoperation);
					
					if (result == null) result = caseEModelElement(eoperation);
					if (result == null) result = caseENamedElement(eoperation);
					if (result == null) result = caseETypedElement(eoperation);
					
					if (result == null) result = defaultCase(theEObject);
					return result;
				}
				case EcorePackageImpl.EPACKAGE: {
					var epackage = (EPackage) theEObject;
					var result = caseEPackage(epackage);
					
					if (result == null) result = caseEModelElement(epackage);
					if (result == null) result = caseENamedElement(epackage);
					
					if (result == null) result = defaultCase(theEObject);
					return result;
				}
				case EcorePackageImpl.EPARAMETER: {
					var eparameter = (EParameter) theEObject;
					var result = caseEParameter(eparameter);
					
					if (result == null) result = caseEModelElement(eparameter);
					if (result == null) result = caseENamedElement(eparameter);
					if (result == null) result = caseETypedElement(eparameter);
					
					if (result == null) result = defaultCase(theEObject);
					return result;
				}
				case EcorePackageImpl.EREFERENCE: {
					var ereference = (EReference) theEObject;
					var result = caseEReference(ereference);
					
					if (result == null) result = caseEModelElement(ereference);
					if (result == null) result = caseENamedElement(ereference);
					if (result == null) result = caseETypedElement(ereference);
					if (result == null) result = caseEStructuralFeature(ereference);
					
					if (result == null) result = defaultCase(theEObject);
					return result;
				}
				case EcorePackageImpl.ESTRUCTURALFEATURE: {
					var estructuralfeature = (EStructuralFeature) theEObject;
					var result = caseEStructuralFeature(estructuralfeature);
					
					if (result == null) result = caseEModelElement(estructuralfeature);
					if (result == null) result = caseENamedElement(estructuralfeature);
					if (result == null) result = caseETypedElement(estructuralfeature);
					
					if (result == null) result = defaultCase(theEObject);
					return result;
				}
				case EcorePackageImpl.ETYPEDELEMENT: {
					var etypedelement = (ETypedElement) theEObject;
					var result = caseETypedElement(etypedelement);
					
					if (result == null) result = caseEModelElement(etypedelement);
					if (result == null) result = caseENamedElement(etypedelement);
					
					if (result == null) result = defaultCase(theEObject);
					return result;
				}
				case EcorePackageImpl.ESTRINGTOSTRINGMAPENTRY: {
					var estringtostringmapentry = (EStringToStringMapEntry) theEObject;
					var result = caseEStringToStringMapEntry(estringtostringmapentry);
					
					
					if (result == null) result = defaultCase(theEObject);
					return result;
				}
				case EcorePackageImpl.EGENERICTYPE: {
					var egenerictype = (EGenericType) theEObject;
					var result = caseEGenericType(egenerictype);
					
					
					if (result == null) result = defaultCase(theEObject);
					return result;
				}
				case EcorePackageImpl.ETYPEPARAMETER: {
					var etypeparameter = (ETypeParameter) theEObject;
					var result = caseETypeParameter(etypeparameter);
					
					if (result == null) result = caseEModelElement(etypeparameter);
					if (result == null) result = caseENamedElement(etypeparameter);
					
					if (result == null) result = defaultCase(theEObject);
					return result;
				}
				default: return defaultCase(theEObject);
			}
		}
		
		
		public virtual T caseEAttribute(EAttribute theEObject) {
			return default(T);
		}
		public virtual T caseEAnnotation(EAnnotation theEObject) {
			return default(T);
		}
		public virtual T caseEClass(EClass theEObject) {
			return default(T);
		}
		public virtual T caseEClassifier(EClassifier theEObject) {
			return default(T);
		}
		public virtual T caseEDataType(EDataType theEObject) {
			return default(T);
		}
		public virtual T caseEEnum(EEnum theEObject) {
			return default(T);
		}
		public virtual T caseEEnumLiteral(EEnumLiteral theEObject) {
			return default(T);
		}
		public virtual T caseEFactory(EFactory theEObject) {
			return default(T);
		}
		public virtual T caseEModelElement(EModelElement theEObject) {
			return default(T);
		}
		public virtual T caseENamedElement(ENamedElement theEObject) {
			return default(T);
		}
		public virtual T caseEObject(EObject theEObject) {
			return default(T);
		}
		public virtual T caseEOperation(EOperation theEObject) {
			return default(T);
		}
		public virtual T caseEPackage(EPackage theEObject) {
			return default(T);
		}
		public virtual T caseEParameter(EParameter theEObject) {
			return default(T);
		}
		public virtual T caseEReference(EReference theEObject) {
			return default(T);
		}
		public virtual T caseEStructuralFeature(EStructuralFeature theEObject) {
			return default(T);
		}
		public virtual T caseETypedElement(ETypedElement theEObject) {
			return default(T);
		}
		public virtual T caseEStringToStringMapEntry(EStringToStringMapEntry theEObject) {
			return default(T);
		}
		public virtual T caseEGenericType(EGenericType theEObject) {
			return default(T);
		}
		public virtual T caseETypeParameter(ETypeParameter theEObject) {
			return default(T);
		}
		
	}
}
