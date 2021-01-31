/* CrossEcore is a cross-platform modeling framework that generates C#, TypeScript, 
 * JavaScript, Swift code from Ecore models with embedded OCL (http://www.crossecore.org/).
 * The original Eclipse Modeling Framework is available at https://www.eclipse.org/modeling/emf/.
 * 
 * contributor: Simon Schwichtenberg
 */
 
namespace Ecore{
	public interface EcoreFactory : EFactory{
		
		EAttribute createEAttribute();
		EAnnotation createEAnnotation();
		EClass createEClass();
		EClassifier createEClassifier();
		EDataType createEDataType();
		EEnum createEEnum();
		EEnumLiteral createEEnumLiteral();
		EFactory createEFactory();
		EModelElement createEModelElement();
		ENamedElement createENamedElement();
		EObject createEObject();
		EOperation createEOperation();
		EPackage createEPackage();
		EParameter createEParameter();
		EReference createEReference();
		EStructuralFeature createEStructuralFeature();
		ETypedElement createETypedElement();
		EStringToStringMapEntry createEStringToStringMapEntry();
		EGenericType createEGenericType();
		ETypeParameter createETypeParameter();
	}
}
