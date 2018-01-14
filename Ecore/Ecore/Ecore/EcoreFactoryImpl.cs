/* CrossEcore is a cross-platform modeling framework that generates C#, TypeScript, 
 * JavaScript, Swift code from Ecore models with embedded OCL (http://www.crossecore.org/).
 * The original Eclipse Modeling Framework is available at https://www.eclipse.org/modeling/emf/.
 * 
 * contributor: Simon Schwichtenberg
 */

namespace Ecore
{
	public class EcoreFactoryImpl : EFactoryImpl, EcoreFactory {
		
		public static EcoreFactory eINSTANCE = EcoreFactoryImpl.init();

        public static EcoreFactory init()
        {
            return new EcoreFactoryImpl();
        }
		
		public EAttribute createEAttribute(){
			var theEAttribute = new EAttributeImpl();
			return theEAttribute;
		}
		public EAnnotation createEAnnotation(){
			var theEAnnotation = new EAnnotationImpl();
			return theEAnnotation;
		}
		public EClass createEClass(){
			var theEClass = new EClassImpl();
			return theEClass;
		}
		public EClassifier createEClassifier(){
			var theEClassifier = new EClassifierImpl();
			return theEClassifier;
		}
		public EDataType createEDataType(){
			var theEDataType = new EDataTypeImpl();
			return theEDataType;
		}
		public EEnum createEEnum(){
			var theEEnum = new EEnumImpl();
			return theEEnum;
		}
		public EEnumLiteral createEEnumLiteral(){
			var theEEnumLiteral = new EEnumLiteralImpl();
			return theEEnumLiteral;
		}
		public EFactory createEFactory(){
			var theEFactory = new EFactoryImpl();
			return theEFactory;
		}
		public EModelElement createEModelElement(){
			var theEModelElement = new EModelElementImpl();
			return theEModelElement;
		}
		public ENamedElement createENamedElement(){
			var theENamedElement = new ENamedElementImpl();
			return theENamedElement;
		}
		public EObject createEObject(){
			var theEObject = new EObjectImpl();
			return theEObject;
		}
		public EOperation createEOperation(){
			var theEOperation = new EOperationImpl();
			return theEOperation;
		}
		public EPackage createEPackage(){
			var theEPackage = new EPackageImpl();
			return theEPackage;
		}
		public EParameter createEParameter(){
			var theEParameter = new EParameterImpl();
			return theEParameter;
		}
		public EReference createEReference(){
			var theEReference = new EReferenceImpl();
			return theEReference;
		}
		public EStructuralFeature createEStructuralFeature(){
			var theEStructuralFeature = new EStructuralFeatureImpl();
			return theEStructuralFeature;
		}
		public ETypedElement createETypedElement(){
			var theETypedElement = new ETypedElementImpl();
			return theETypedElement;
		}
		public EStringToStringMapEntry createEStringToStringMapEntry(){
			var theEStringToStringMapEntry = new EStringToStringMapEntryImpl();
			return theEStringToStringMapEntry;
		}
		public EGenericType createEGenericType(){
			var theEGenericType = new EGenericTypeImpl();
			return theEGenericType;
		}
		public ETypeParameter createETypeParameter(){
			var theETypeParameter = new ETypeParameterImpl();
			return theETypeParameter;
		}
	}
}
