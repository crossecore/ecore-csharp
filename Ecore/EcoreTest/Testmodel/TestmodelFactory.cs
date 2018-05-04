using Ecore;
namespace Testmodel{
	public interface TestmodelFactory : EFactory{
		
		SuperAbstractClass createSuperAbstractClass();
		SuperClass createSuperClass();
		SubAbstractClass1 createSubAbstractClass1();
		SubAbstractClass2 createSubAbstractClass2();
		SubAbstractClass3 createSubAbstractClass3();
		SubClass1 createSubClass1();
		SubClass2 createSubClass2();
		SubClass3 createSubClass3();
		SubAbstractClass4 createSubAbstractClass4();
		SubAbstractClass5 createSubAbstractClass5();
		SubAbstractClass6 createSubAbstractClass6();
		SubAbstractClass7 createSubAbstractClass7();
		SubClass4 createSubClass4();
		SubClass5 createSubClass5();
		SubClass6 createSubClass6();
		SubClass7 createSubClass7();
		A createA();
		B createB();
		C createC();
		Source createSource();
		Target createTarget();
	}
}
