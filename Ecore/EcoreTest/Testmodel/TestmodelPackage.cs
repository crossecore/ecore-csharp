	 	using Ecore;
namespace Testmodel{
	public interface TestmodelPackage : EPackage {
			
		EClass getSuperInterface();
		
		EClass getSuperAbstractClass();
		
		EClass getSuperClass();
		
		EClass getA();
		
		EAttribute getA_A();
		EClass getSource();
		EReference getSource_Zero_one_no_no();
		EReference getSource_Zero_many_no_no();
		EReference getSource_Zero_one_no_yes();
		EReference getSource_Zero_many_no_yes();
		EReference getSource_One_one_no_no();
		EReference getSource_One_many_no_no();
		EReference getSource_Many_many_no_no();
		EReference getSource_One_many_no_yes();
		EReference getSource_One_one_no_yes();
		
		EClass getTarget();
		EReference getTarget_One_one_no_no();
		EReference getTarget_One_many_no_no();
		EReference getTarget_Many_many_no_no();
		EReference getTarget_One_many_no_yes();
		EReference getTarget_One_one_no_yes();
		
		EClass getSubInterface1();
		
		EClass getSubAbstractClass1();
		
		EClass getSubClass1();
		
		EClass getSubInterface2();
		
		EClass getSubAbstractClass2();
		
		EClass getSubClass2();
		
		EClass getSubInterface3();
		
		EClass getSubAbstractClass3();
		
		EClass getSubClass3();
		
		EClass getB();
		
		EAttribute getB_B();
		EClass getSubInterface4();
		
		EClass getSubInterface5();
		
		EClass getSubInterface6();
		
		EClass getSubAbstractClass4();
		
		EClass getSubAbstractClass5();
		
		EClass getSubAbstractClass6();
		
		EClass getSubClass4();
		
		EClass getSubClass5();
		
		EClass getSubClass6();
		
		EClass getSubInterface7();
		
		EClass getSubAbstractClass7();
		
		EClass getSubClass7();
		
		EClass getC();
		
		EAttribute getC_C();
			
	 
	}
}
