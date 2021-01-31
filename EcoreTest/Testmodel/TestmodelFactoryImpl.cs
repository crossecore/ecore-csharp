	 	using Ecore;
namespace Testmodel{
	public class TestmodelFactoryImpl : EFactoryImpl, TestmodelFactory {
		
		public static TestmodelFactory eINSTANCE = TestmodelFactoryImpl.init();

        public static TestmodelFactory init()
        {
            /*
            try
            {
                Phoenix2Factory thePhoenix2Factory = (Phoenix2Factory)EPackage.Registry.INSTANCE.getEFactory(Phoenix2Package.eNS_URI);
                if (thePhoenix2Factory != null)
                {
                    return thePhoenix2Factory;
                }
            }
            catch (Exception exception)
            {
                EcorePlugin.INSTANCE.log(exception);
            }
            */
            return new TestmodelFactoryImpl();
        }
		
		public SuperAbstractClass createSuperAbstractClass(){
			var theSuperAbstractClass = new SuperAbstractClassImpl();
			return theSuperAbstractClass;
		}
		public SuperClass createSuperClass(){
			var theSuperClass = new SuperClassImpl();
			return theSuperClass;
		}
		public SubAbstractClass1 createSubAbstractClass1(){
			var theSubAbstractClass1 = new SubAbstractClass1Impl();
			return theSubAbstractClass1;
		}
		public SubAbstractClass2 createSubAbstractClass2(){
			var theSubAbstractClass2 = new SubAbstractClass2Impl();
			return theSubAbstractClass2;
		}
		public SubAbstractClass3 createSubAbstractClass3(){
			var theSubAbstractClass3 = new SubAbstractClass3Impl();
			return theSubAbstractClass3;
		}
		public SubClass1 createSubClass1(){
			var theSubClass1 = new SubClass1Impl();
			return theSubClass1;
		}
		public SubClass2 createSubClass2(){
			var theSubClass2 = new SubClass2Impl();
			return theSubClass2;
		}
		public SubClass3 createSubClass3(){
			var theSubClass3 = new SubClass3Impl();
			return theSubClass3;
		}
		public SubAbstractClass4 createSubAbstractClass4(){
			var theSubAbstractClass4 = new SubAbstractClass4Impl();
			return theSubAbstractClass4;
		}
		public SubAbstractClass5 createSubAbstractClass5(){
			var theSubAbstractClass5 = new SubAbstractClass5Impl();
			return theSubAbstractClass5;
		}
		public SubAbstractClass6 createSubAbstractClass6(){
			var theSubAbstractClass6 = new SubAbstractClass6Impl();
			return theSubAbstractClass6;
		}
		public SubAbstractClass7 createSubAbstractClass7(){
			var theSubAbstractClass7 = new SubAbstractClass7Impl();
			return theSubAbstractClass7;
		}
		public SubClass4 createSubClass4(){
			var theSubClass4 = new SubClass4Impl();
			return theSubClass4;
		}
		public SubClass5 createSubClass5(){
			var theSubClass5 = new SubClass5Impl();
			return theSubClass5;
		}
		public SubClass6 createSubClass6(){
			var theSubClass6 = new SubClass6Impl();
			return theSubClass6;
		}
		public SubClass7 createSubClass7(){
			var theSubClass7 = new SubClass7Impl();
			return theSubClass7;
		}
		public A createA(){
			var theA = new AImpl();
			return theA;
		}
		public B createB(){
			var theB = new BImpl();
			return theB;
		}
		public C createC(){
			var theC = new CImpl();
			return theC;
		}
		public Source createSource(){
			var theSource = new SourceImpl();
			return theSource;
		}
		public Target createTarget(){
			var theTarget = new TargetImpl();
			return theTarget;
		}
	}
}
