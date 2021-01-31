/* CrossEcore is a cross-platform modeling framework that generates C#, TypeScript, 
 * JavaScript, Swift code from Ecore models with embedded OCL (http://www.crossecore.org/).
 * The original Eclipse Modeling Framework is available at https://www.eclipse.org/modeling/emf/.
 * 
 * contributor: Simon Schwichtenberg
 */
 
using Ecore;
	 	using System.Collections.Generic;
namespace Serialization{
	public class SerializationValidator : EObjectValidator {
	
        protected override bool validate(int classifierID, object value, DiagnosticChain diagnostics, Dictionary<object, object> context)
        {
            switch (classifierID)
            {
				case SerializationPackageImpl.MYCLASS:
					return validateMyClass((MyClass)value, diagnostics, context);	
				case SerializationPackageImpl.OTHERCLASS:
					return validateOtherClass((OtherClass)value, diagnostics, context);	
				case SerializationPackageImpl.YETANOTHERCLASS:
					return validateYetAnotherClass((YetAnotherClass)value, diagnostics, context);	
                

                default:
                    return true;
            }
        }
		
		public bool validateMyClass(MyClass obj, DiagnosticChain diagnostics, Dictionary<object, object> context)
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
		
		
		public bool validateOtherClass(OtherClass obj, DiagnosticChain diagnostics, Dictionary<object, object> context)
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
		
		
		public bool validateYetAnotherClass(YetAnotherClass obj, DiagnosticChain diagnostics, Dictionary<object, object> context)
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
