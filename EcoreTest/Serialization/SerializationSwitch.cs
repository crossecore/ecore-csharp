/* CrossEcore is a cross-platform modeling framework that generates C#, TypeScript, 
 * JavaScript, Swift code from Ecore models with embedded OCL (http://www.crossecore.org/).
 * The original Eclipse Modeling Framework is available at https://www.eclipse.org/modeling/emf/.
 * 
 * contributor: Simon Schwichtenberg
 */
 
	 	using Ecore;
namespace Serialization{
	public class SerializationSwitch<T> : Switch<T> {
	
		protected static SerializationPackage modelPackage;
		
		protected override bool isSwitchFor(EPackage ePackage)
		{
			return ePackage == modelPackage;
		}

		public SerializationSwitch()
		{
			if (modelPackage == null)
			{
				modelPackage = SerializationPackageImpl.eINSTANCE;
			}
		}
		
		protected override T doSwitch(int classifierID, EObject theEObject) {
			switch (classifierID) {
				case SerializationPackageImpl.MYCLASS: {
					var theMyClass = (MyClass) theEObject;
					var result = caseMyClass(theMyClass);
					
					
					if (result == null) result = defaultCase(theEObject);
					return result;
				}
				case SerializationPackageImpl.OTHERCLASS: {
					var theOtherClass = (OtherClass) theEObject;
					var result = caseOtherClass(theOtherClass);
					
					
					if (result == null) result = defaultCase(theEObject);
					return result;
				}
				case SerializationPackageImpl.YETANOTHERCLASS: {
					var theYetAnotherClass = (YetAnotherClass) theEObject;
					var result = caseYetAnotherClass(theYetAnotherClass);
					
					
					if (result == null) result = defaultCase(theEObject);
					return result;
				}
				default: return defaultCase(theEObject);
			}
		}
		
		
		public virtual T caseMyClass(MyClass theEObject) {
			return default(T);
		}
		public virtual T caseOtherClass(OtherClass theEObject) {
			return default(T);
		}
		public virtual T caseYetAnotherClass(YetAnotherClass theEObject) {
			return default(T);
		}
		
	}
}
