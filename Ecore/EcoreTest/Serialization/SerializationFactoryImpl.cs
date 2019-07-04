/* CrossEcore is a cross-platform modeling framework that generates C#, TypeScript, 
 * JavaScript, Swift code from Ecore models with embedded OCL (http://www.crossecore.org/).
 * The original Eclipse Modeling Framework is available at https://www.eclipse.org/modeling/emf/.
 * 
 * contributor: Simon Schwichtenberg
 */
 
using Ecore;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;	 	
namespace Serialization{
	public class SerializationFactoryImpl : EFactoryImpl, SerializationFactory {
		
		public static SerializationFactory eINSTANCE = SerializationFactoryImpl.init();

        public static SerializationFactory init()
        {
            return new SerializationFactoryImpl();
        }
		
		public MyClass createMyClass(){
			var theMyClass = new MyClassImpl();
			MyClassImpl.allInstances_.Add(theMyClass);
			
			return theMyClass;
		}
		public OtherClass createOtherClass(){
			var theOtherClass = new OtherClassImpl();
			OtherClassImpl.allInstances_.Add(theOtherClass);
			
			return theOtherClass;
		}
		public YetAnotherClass createYetAnotherClass(){
			var theYetAnotherClass = new YetAnotherClassImpl();
			YetAnotherClassImpl.allInstances_.Add(theYetAnotherClass);
			
			return theYetAnotherClass;
		}
		
		public override EObject create(EClass eClass) {
			switch (eClass.getClassifierID()) {
				case SerializationPackageImpl.MYCLASS: return createMyClass();
				case SerializationPackageImpl.OTHERCLASS: return createOtherClass();
				case SerializationPackageImpl.YETANOTHERCLASS: return createYetAnotherClass();
				default:
					throw new ArgumentException("The class '" + eClass.name + "' is not a valid classifier");
			}
		}
		
		
		
		
		
		
		/*
		public SerializationPackage getSerialization() {
			return (SerializationPackage) getEPackage();
		}
		*/

	
	}
}
