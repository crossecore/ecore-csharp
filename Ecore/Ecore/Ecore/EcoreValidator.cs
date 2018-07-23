/* CrossEcore is a cross-platform modeling framework that generates C#, TypeScript, 
 * JavaScript, Swift code from Ecore models with embedded OCL (http://www.crossecore.org/).
 * The original Eclipse Modeling Framework is available at https://www.eclipse.org/modeling/emf/.
 * 
 * contributor: Simon Schwichtenberg
 */
 
	 	using System.Collections.Generic;
namespace Ecore{
	public class EcoreValidator : EObjectValidator {
	
        protected override bool validate(int classifierID, object value, DiagnosticChain diagnostics, Dictionary<object, object> context)
        {
            switch (classifierID)
            {
				case EcorePackageImpl.EATTRIBUTE:
					return validateEAttribute((EAttribute)value, diagnostics, context);	
				case EcorePackageImpl.EANNOTATION:
					return validateEAnnotation((EAnnotation)value, diagnostics, context);	
				case EcorePackageImpl.ECLASS:
					return validateEClass((EClass)value, diagnostics, context);	
				case EcorePackageImpl.ECLASSIFIER:
					return validateEClassifier((EClassifier)value, diagnostics, context);	
				case EcorePackageImpl.EDATATYPE:
					return validateEDataType((EDataType)value, diagnostics, context);	
				case EcorePackageImpl.EENUM:
					return validateEEnum((EEnum)value, diagnostics, context);	
				case EcorePackageImpl.EENUMLITERAL:
					return validateEEnumLiteral((EEnumLiteral)value, diagnostics, context);	
				case EcorePackageImpl.EFACTORY:
					return validateEFactory((EFactory)value, diagnostics, context);	
				case EcorePackageImpl.EMODELELEMENT:
					return validateEModelElement((EModelElement)value, diagnostics, context);	
				case EcorePackageImpl.ENAMEDELEMENT:
					return validateENamedElement((ENamedElement)value, diagnostics, context);	
				case EcorePackageImpl.EOBJECT:
					return validateEObject((EObject)value, diagnostics, context);	
				case EcorePackageImpl.EOPERATION:
					return validateEOperation((EOperation)value, diagnostics, context);	
				case EcorePackageImpl.EPACKAGE:
					return validateEPackage((EPackage)value, diagnostics, context);	
				case EcorePackageImpl.EPARAMETER:
					return validateEParameter((EParameter)value, diagnostics, context);	
				case EcorePackageImpl.EREFERENCE:
					return validateEReference((EReference)value, diagnostics, context);	
				case EcorePackageImpl.ESTRUCTURALFEATURE:
					return validateEStructuralFeature((EStructuralFeature)value, diagnostics, context);	
				case EcorePackageImpl.ETYPEDELEMENT:
					return validateETypedElement((ETypedElement)value, diagnostics, context);	
				case EcorePackageImpl.ESTRINGTOSTRINGMAPENTRY:
					return validateEStringToStringMapEntry((EStringToStringMapEntry)value, diagnostics, context);	
				case EcorePackageImpl.EGENERICTYPE:
					return validateEGenericType((EGenericType)value, diagnostics, context);	
				case EcorePackageImpl.ETYPEPARAMETER:
					return validateETypeParameter((ETypeParameter)value, diagnostics, context);	
                

                default:
                    return true;
            }
        }
		
		public bool validateEAttribute(EAttribute obj, DiagnosticChain diagnostics, Dictionary<object, object> context)
			        {
			            if (!validate_NoCircularContainment(obj, diagnostics, context)) return false;
			            bool result = validate_EveryMultiplicityConforms(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryDataValueConforms(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryReferenceIsContained(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryBidirectionalReferenceIsPaired(obj, diagnostics, context);
			            //if (result || diagnostics != null) result &= validate_EveryProxyResolves(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_UniqueID(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryKeyUnique(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryMapEntryUnique(obj, diagnostics, context);
			            
			            return result;
			            
			        }
		
		
		public bool validateEAnnotation(EAnnotation obj, DiagnosticChain diagnostics, Dictionary<object, object> context)
			        {
			            if (!validate_NoCircularContainment(obj, diagnostics, context)) return false;
			            bool result = validate_EveryMultiplicityConforms(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryDataValueConforms(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryReferenceIsContained(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryBidirectionalReferenceIsPaired(obj, diagnostics, context);
			            //if (result || diagnostics != null) result &= validate_EveryProxyResolves(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_UniqueID(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryKeyUnique(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryMapEntryUnique(obj, diagnostics, context);
			            
			            return result;
			            
			        }
		
		
		public bool validateEClass(EClass obj, DiagnosticChain diagnostics, Dictionary<object, object> context)
			        {
			            if (!validate_NoCircularContainment(obj, diagnostics, context)) return false;
			            bool result = validate_EveryMultiplicityConforms(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryDataValueConforms(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryReferenceIsContained(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryBidirectionalReferenceIsPaired(obj, diagnostics, context);
			            //if (result || diagnostics != null) result &= validate_EveryProxyResolves(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_UniqueID(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryKeyUnique(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryMapEntryUnique(obj, diagnostics, context);
			            
			            return result;
			            
			        }
		
		
		public bool validateEClassifier(EClassifier obj, DiagnosticChain diagnostics, Dictionary<object, object> context)
			        {
			            if (!validate_NoCircularContainment(obj, diagnostics, context)) return false;
			            bool result = validate_EveryMultiplicityConforms(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryDataValueConforms(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryReferenceIsContained(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryBidirectionalReferenceIsPaired(obj, diagnostics, context);
			            //if (result || diagnostics != null) result &= validate_EveryProxyResolves(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_UniqueID(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryKeyUnique(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryMapEntryUnique(obj, diagnostics, context);
			            
			            return result;
			            
			        }
		
		
		public bool validateEDataType(EDataType obj, DiagnosticChain diagnostics, Dictionary<object, object> context)
			        {
			            if (!validate_NoCircularContainment(obj, diagnostics, context)) return false;
			            bool result = validate_EveryMultiplicityConforms(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryDataValueConforms(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryReferenceIsContained(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryBidirectionalReferenceIsPaired(obj, diagnostics, context);
			            //if (result || diagnostics != null) result &= validate_EveryProxyResolves(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_UniqueID(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryKeyUnique(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryMapEntryUnique(obj, diagnostics, context);
			            
			            return result;
			            
			        }
		
		
		public bool validateEEnum(EEnum obj, DiagnosticChain diagnostics, Dictionary<object, object> context)
			        {
			            if (!validate_NoCircularContainment(obj, diagnostics, context)) return false;
			            bool result = validate_EveryMultiplicityConforms(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryDataValueConforms(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryReferenceIsContained(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryBidirectionalReferenceIsPaired(obj, diagnostics, context);
			            //if (result || diagnostics != null) result &= validate_EveryProxyResolves(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_UniqueID(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryKeyUnique(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryMapEntryUnique(obj, diagnostics, context);
			            
			            return result;
			            
			        }
		
		
		public bool validateEEnumLiteral(EEnumLiteral obj, DiagnosticChain diagnostics, Dictionary<object, object> context)
			        {
			            if (!validate_NoCircularContainment(obj, diagnostics, context)) return false;
			            bool result = validate_EveryMultiplicityConforms(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryDataValueConforms(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryReferenceIsContained(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryBidirectionalReferenceIsPaired(obj, diagnostics, context);
			            //if (result || diagnostics != null) result &= validate_EveryProxyResolves(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_UniqueID(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryKeyUnique(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryMapEntryUnique(obj, diagnostics, context);
			            
			            return result;
			            
			        }
		
		
		public bool validateEFactory(EFactory obj, DiagnosticChain diagnostics, Dictionary<object, object> context)
			        {
			            if (!validate_NoCircularContainment(obj, diagnostics, context)) return false;
			            bool result = validate_EveryMultiplicityConforms(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryDataValueConforms(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryReferenceIsContained(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryBidirectionalReferenceIsPaired(obj, diagnostics, context);
			            //if (result || diagnostics != null) result &= validate_EveryProxyResolves(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_UniqueID(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryKeyUnique(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryMapEntryUnique(obj, diagnostics, context);
			            
			            return result;
			            
			        }
		
		
		public bool validateEModelElement(EModelElement obj, DiagnosticChain diagnostics, Dictionary<object, object> context)
			        {
			            if (!validate_NoCircularContainment(obj, diagnostics, context)) return false;
			            bool result = validate_EveryMultiplicityConforms(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryDataValueConforms(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryReferenceIsContained(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryBidirectionalReferenceIsPaired(obj, diagnostics, context);
			            //if (result || diagnostics != null) result &= validate_EveryProxyResolves(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_UniqueID(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryKeyUnique(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryMapEntryUnique(obj, diagnostics, context);
			            
			            return result;
			            
			        }
		
		
		public bool validateENamedElement(ENamedElement obj, DiagnosticChain diagnostics, Dictionary<object, object> context)
			        {
			            if (!validate_NoCircularContainment(obj, diagnostics, context)) return false;
			            bool result = validate_EveryMultiplicityConforms(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryDataValueConforms(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryReferenceIsContained(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryBidirectionalReferenceIsPaired(obj, diagnostics, context);
			            //if (result || diagnostics != null) result &= validate_EveryProxyResolves(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_UniqueID(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryKeyUnique(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryMapEntryUnique(obj, diagnostics, context);
			            
			            return result;
			            
			        }
		
		
		public bool validateEObject(EObject obj, DiagnosticChain diagnostics, Dictionary<object, object> context)
			        {
			            if (!validate_NoCircularContainment(obj, diagnostics, context)) return false;
			            bool result = validate_EveryMultiplicityConforms(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryDataValueConforms(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryReferenceIsContained(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryBidirectionalReferenceIsPaired(obj, diagnostics, context);
			            //if (result || diagnostics != null) result &= validate_EveryProxyResolves(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_UniqueID(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryKeyUnique(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryMapEntryUnique(obj, diagnostics, context);
			            
			            return result;
			            
			        }
		
		
		public bool validateEOperation(EOperation obj, DiagnosticChain diagnostics, Dictionary<object, object> context)
			        {
			            if (!validate_NoCircularContainment(obj, diagnostics, context)) return false;
			            bool result = validate_EveryMultiplicityConforms(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryDataValueConforms(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryReferenceIsContained(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryBidirectionalReferenceIsPaired(obj, diagnostics, context);
			            //if (result || diagnostics != null) result &= validate_EveryProxyResolves(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_UniqueID(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryKeyUnique(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryMapEntryUnique(obj, diagnostics, context);
			            
			            return result;
			            
			        }
		
		
		public bool validateEPackage(EPackage obj, DiagnosticChain diagnostics, Dictionary<object, object> context)
			        {
			            if (!validate_NoCircularContainment(obj, diagnostics, context)) return false;
			            bool result = validate_EveryMultiplicityConforms(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryDataValueConforms(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryReferenceIsContained(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryBidirectionalReferenceIsPaired(obj, diagnostics, context);
			            //if (result || diagnostics != null) result &= validate_EveryProxyResolves(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_UniqueID(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryKeyUnique(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryMapEntryUnique(obj, diagnostics, context);
			            
			            return result;
			            
			        }
		
		
		public bool validateEParameter(EParameter obj, DiagnosticChain diagnostics, Dictionary<object, object> context)
			        {
			            if (!validate_NoCircularContainment(obj, diagnostics, context)) return false;
			            bool result = validate_EveryMultiplicityConforms(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryDataValueConforms(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryReferenceIsContained(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryBidirectionalReferenceIsPaired(obj, diagnostics, context);
			            //if (result || diagnostics != null) result &= validate_EveryProxyResolves(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_UniqueID(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryKeyUnique(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryMapEntryUnique(obj, diagnostics, context);
			            
			            return result;
			            
			        }
		
		
		public bool validateEReference(EReference obj, DiagnosticChain diagnostics, Dictionary<object, object> context)
			        {
			            if (!validate_NoCircularContainment(obj, diagnostics, context)) return false;
			            bool result = validate_EveryMultiplicityConforms(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryDataValueConforms(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryReferenceIsContained(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryBidirectionalReferenceIsPaired(obj, diagnostics, context);
			            //if (result || diagnostics != null) result &= validate_EveryProxyResolves(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_UniqueID(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryKeyUnique(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryMapEntryUnique(obj, diagnostics, context);
			            
			            return result;
			            
			        }
		
		
		public bool validateEStructuralFeature(EStructuralFeature obj, DiagnosticChain diagnostics, Dictionary<object, object> context)
			        {
			            if (!validate_NoCircularContainment(obj, diagnostics, context)) return false;
			            bool result = validate_EveryMultiplicityConforms(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryDataValueConforms(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryReferenceIsContained(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryBidirectionalReferenceIsPaired(obj, diagnostics, context);
			            //if (result || diagnostics != null) result &= validate_EveryProxyResolves(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_UniqueID(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryKeyUnique(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryMapEntryUnique(obj, diagnostics, context);
			            
			            return result;
			            
			        }
		
		
		public bool validateETypedElement(ETypedElement obj, DiagnosticChain diagnostics, Dictionary<object, object> context)
			        {
			            if (!validate_NoCircularContainment(obj, diagnostics, context)) return false;
			            bool result = validate_EveryMultiplicityConforms(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryDataValueConforms(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryReferenceIsContained(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryBidirectionalReferenceIsPaired(obj, diagnostics, context);
			            //if (result || diagnostics != null) result &= validate_EveryProxyResolves(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_UniqueID(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryKeyUnique(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryMapEntryUnique(obj, diagnostics, context);
			            
			            return result;
			            
			        }
		
		
		public bool validateEStringToStringMapEntry(EStringToStringMapEntry obj, DiagnosticChain diagnostics, Dictionary<object, object> context)
			        {
			            if (!validate_NoCircularContainment(obj, diagnostics, context)) return false;
			            bool result = validate_EveryMultiplicityConforms(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryDataValueConforms(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryReferenceIsContained(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryBidirectionalReferenceIsPaired(obj, diagnostics, context);
			            //if (result || diagnostics != null) result &= validate_EveryProxyResolves(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_UniqueID(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryKeyUnique(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryMapEntryUnique(obj, diagnostics, context);
			            
			            return result;
			            
			        }
		
		
		public bool validateEGenericType(EGenericType obj, DiagnosticChain diagnostics, Dictionary<object, object> context)
			        {
			            if (!validate_NoCircularContainment(obj, diagnostics, context)) return false;
			            bool result = validate_EveryMultiplicityConforms(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryDataValueConforms(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryReferenceIsContained(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryBidirectionalReferenceIsPaired(obj, diagnostics, context);
			            //if (result || diagnostics != null) result &= validate_EveryProxyResolves(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_UniqueID(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryKeyUnique(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryMapEntryUnique(obj, diagnostics, context);
			            
			            return result;
			            
			        }
		
		
		public bool validateETypeParameter(ETypeParameter obj, DiagnosticChain diagnostics, Dictionary<object, object> context)
			        {
			            if (!validate_NoCircularContainment(obj, diagnostics, context)) return false;
			            bool result = validate_EveryMultiplicityConforms(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryDataValueConforms(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryReferenceIsContained(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryBidirectionalReferenceIsPaired(obj, diagnostics, context);
			            //if (result || diagnostics != null) result &= validate_EveryProxyResolves(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_UniqueID(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryKeyUnique(obj, diagnostics, context);
			            if (result || diagnostics != null) result &= validate_EveryMapEntryUnique(obj, diagnostics, context);
			            
			            return result;
			            
			        }
		
		
	}
}
