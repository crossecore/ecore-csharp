	 	using Ecore;
namespace Ocltestmodel{
	public class OcltestmodelFactoryImpl : EFactoryImpl, OcltestmodelFactory {
		
		public static OcltestmodelFactory eINSTANCE = OcltestmodelFactoryImpl.init();

        public static OcltestmodelFactory init()
        {
            return new OcltestmodelFactoryImpl();
        }
		
		public MyClass createMyClass(){
			var theMyClass = new MyClassImpl();
			return theMyClass;
		}
	}
}
