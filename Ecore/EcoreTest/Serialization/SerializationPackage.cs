/* CrossEcore is a cross-platform modeling framework that generates C#, TypeScript, 
 * JavaScript, Swift code from Ecore models with embedded OCL (http://www.crossecore.org/).
 * The original Eclipse Modeling Framework is available at https://www.eclipse.org/modeling/emf/.
 * 
 * contributor: Simon Schwichtenberg
 */
 
	 	using Ecore;
namespace Serialization{
	public interface SerializationPackage : EPackage {
			
		EClass getMyClass();
		EReference getMyClass_Otherclass();
		EReference getMyClass_Selection();
		EReference getMyClass_Yetanotherclass();
		EReference getMyClass_Selection2();
		
		EAttribute getMyClass_Attribute_string();
		EClass getOtherClass();
		
		EAttribute getOtherClass_Id();
		EClass getYetAnotherClass();
		
		EAttribute getYetAnotherClass_No_id();
			
	 
	}
}
