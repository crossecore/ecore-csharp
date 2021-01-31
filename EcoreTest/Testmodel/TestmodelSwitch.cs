	 	using Ecore;
namespace Testmodel{
	public class TestmodelSwitch<T> : Switch<T> {
	
		protected static TestmodelPackage modelPackage;
		
		protected override bool isSwitchFor(EPackage ePackage)
		{
			return ePackage == modelPackage;
		}

		public TestmodelSwitch()
		{
			if (modelPackage == null)
			{
				modelPackage = TestmodelPackageImpl.eINSTANCE;
			}
		}
		
		protected override T doSwitch(int classifierID, EObject theEObject) {
			switch (classifierID) {
				case TestmodelPackageImpl.SUPERINTERFACE: {
					var superinterface = (SuperInterface) theEObject;
					var result = caseSuperInterface(superinterface);
					
					
					if (result == null) result = defaultCase(theEObject);
					return result;
				}
				case TestmodelPackageImpl.SUPERABSTRACTCLASS: {
					var superabstractclass = (SuperAbstractClass) theEObject;
					var result = caseSuperAbstractClass(superabstractclass);
					
					
					if (result == null) result = defaultCase(theEObject);
					return result;
				}
				case TestmodelPackageImpl.SUPERCLASS: {
					var superclass = (SuperClass) theEObject;
					var result = caseSuperClass(superclass);
					
					
					if (result == null) result = defaultCase(theEObject);
					return result;
				}
				case TestmodelPackageImpl.SUBINTERFACE1: {
					var subinterface1 = (SubInterface1) theEObject;
					var result = caseSubInterface1(subinterface1);
					
					if (result == null) result = caseSuperInterface(subinterface1);
					
					if (result == null) result = defaultCase(theEObject);
					return result;
				}
				case TestmodelPackageImpl.SUBINTERFACE2: {
					var subinterface2 = (SubInterface2) theEObject;
					var result = caseSubInterface2(subinterface2);
					
					if (result == null) result = caseSuperAbstractClass(subinterface2);
					
					if (result == null) result = defaultCase(theEObject);
					return result;
				}
				case TestmodelPackageImpl.SUBINTERFACE3: {
					var subinterface3 = (SubInterface3) theEObject;
					var result = caseSubInterface3(subinterface3);
					
					if (result == null) result = caseSuperClass(subinterface3);
					
					if (result == null) result = defaultCase(theEObject);
					return result;
				}
				case TestmodelPackageImpl.SUBABSTRACTCLASS1: {
					var subabstractclass1 = (SubAbstractClass1) theEObject;
					var result = caseSubAbstractClass1(subabstractclass1);
					
					if (result == null) result = caseSuperInterface(subabstractclass1);
					
					if (result == null) result = defaultCase(theEObject);
					return result;
				}
				case TestmodelPackageImpl.SUBABSTRACTCLASS2: {
					var subabstractclass2 = (SubAbstractClass2) theEObject;
					var result = caseSubAbstractClass2(subabstractclass2);
					
					if (result == null) result = caseSuperAbstractClass(subabstractclass2);
					
					if (result == null) result = defaultCase(theEObject);
					return result;
				}
				case TestmodelPackageImpl.SUBABSTRACTCLASS3: {
					var subabstractclass3 = (SubAbstractClass3) theEObject;
					var result = caseSubAbstractClass3(subabstractclass3);
					
					if (result == null) result = caseSuperClass(subabstractclass3);
					
					if (result == null) result = defaultCase(theEObject);
					return result;
				}
				case TestmodelPackageImpl.SUBCLASS1: {
					var subclass1 = (SubClass1) theEObject;
					var result = caseSubClass1(subclass1);
					
					if (result == null) result = caseSuperInterface(subclass1);
					
					if (result == null) result = defaultCase(theEObject);
					return result;
				}
				case TestmodelPackageImpl.SUBCLASS2: {
					var subclass2 = (SubClass2) theEObject;
					var result = caseSubClass2(subclass2);
					
					if (result == null) result = caseSuperAbstractClass(subclass2);
					
					if (result == null) result = defaultCase(theEObject);
					return result;
				}
				case TestmodelPackageImpl.SUBCLASS3: {
					var subclass3 = (SubClass3) theEObject;
					var result = caseSubClass3(subclass3);
					
					if (result == null) result = caseSuperClass(subclass3);
					
					if (result == null) result = defaultCase(theEObject);
					return result;
				}
				case TestmodelPackageImpl.SUBINTERFACE4: {
					var subinterface4 = (SubInterface4) theEObject;
					var result = caseSubInterface4(subinterface4);
					
					
					if (result == null) result = defaultCase(theEObject);
					return result;
				}
				case TestmodelPackageImpl.SUBINTERFACE5: {
					var subinterface5 = (SubInterface5) theEObject;
					var result = caseSubInterface5(subinterface5);
					
					
					if (result == null) result = defaultCase(theEObject);
					return result;
				}
				case TestmodelPackageImpl.SUBINTERFACE6: {
					var subinterface6 = (SubInterface6) theEObject;
					var result = caseSubInterface6(subinterface6);
					
					
					if (result == null) result = defaultCase(theEObject);
					return result;
				}
				case TestmodelPackageImpl.SUBINTERFACE7: {
					var subinterface7 = (SubInterface7) theEObject;
					var result = caseSubInterface7(subinterface7);
					
					
					if (result == null) result = defaultCase(theEObject);
					return result;
				}
				case TestmodelPackageImpl.SUBABSTRACTCLASS4: {
					var subabstractclass4 = (SubAbstractClass4) theEObject;
					var result = caseSubAbstractClass4(subabstractclass4);
					
					
					if (result == null) result = defaultCase(theEObject);
					return result;
				}
				case TestmodelPackageImpl.SUBABSTRACTCLASS5: {
					var subabstractclass5 = (SubAbstractClass5) theEObject;
					var result = caseSubAbstractClass5(subabstractclass5);
					
					
					if (result == null) result = defaultCase(theEObject);
					return result;
				}
				case TestmodelPackageImpl.SUBABSTRACTCLASS6: {
					var subabstractclass6 = (SubAbstractClass6) theEObject;
					var result = caseSubAbstractClass6(subabstractclass6);
					
					
					if (result == null) result = defaultCase(theEObject);
					return result;
				}
				case TestmodelPackageImpl.SUBABSTRACTCLASS7: {
					var subabstractclass7 = (SubAbstractClass7) theEObject;
					var result = caseSubAbstractClass7(subabstractclass7);
					
					
					if (result == null) result = defaultCase(theEObject);
					return result;
				}
				case TestmodelPackageImpl.SUBCLASS4: {
					var subclass4 = (SubClass4) theEObject;
					var result = caseSubClass4(subclass4);
					
					
					if (result == null) result = defaultCase(theEObject);
					return result;
				}
				case TestmodelPackageImpl.SUBCLASS5: {
					var subclass5 = (SubClass5) theEObject;
					var result = caseSubClass5(subclass5);
					
					
					if (result == null) result = defaultCase(theEObject);
					return result;
				}
				case TestmodelPackageImpl.SUBCLASS6: {
					var subclass6 = (SubClass6) theEObject;
					var result = caseSubClass6(subclass6);
					
					
					if (result == null) result = defaultCase(theEObject);
					return result;
				}
				case TestmodelPackageImpl.SUBCLASS7: {
					var subclass7 = (SubClass7) theEObject;
					var result = caseSubClass7(subclass7);
					
					
					if (result == null) result = defaultCase(theEObject);
					return result;
				}
				case TestmodelPackageImpl.A: {
					var a = (A) theEObject;
					var result = caseA(a);
					
					
					if (result == null) result = defaultCase(theEObject);
					return result;
				}
				case TestmodelPackageImpl.B: {
					var b = (B) theEObject;
					var result = caseB(b);
					
					if (result == null) result = caseA(b);
					
					if (result == null) result = defaultCase(theEObject);
					return result;
				}
				case TestmodelPackageImpl.C: {
					var c = (C) theEObject;
					var result = caseC(c);
					
					
					if (result == null) result = defaultCase(theEObject);
					return result;
				}
				case TestmodelPackageImpl.SOURCE: {
					var source = (Source) theEObject;
					var result = caseSource(source);
					
					
					if (result == null) result = defaultCase(theEObject);
					return result;
				}
				case TestmodelPackageImpl.TARGET: {
					var target = (Target) theEObject;
					var result = caseTarget(target);
					
					
					if (result == null) result = defaultCase(theEObject);
					return result;
				}
				default: return defaultCase(theEObject);
			}
		}
		
		
		public virtual T caseSuperInterface(SuperInterface theEObject) {
			return default(T);
		}
		public virtual T caseSuperAbstractClass(SuperAbstractClass theEObject) {
			return default(T);
		}
		public virtual T caseSuperClass(SuperClass theEObject) {
			return default(T);
		}
		public virtual T caseSubInterface1(SubInterface1 theEObject) {
			return default(T);
		}
		public virtual T caseSubInterface2(SubInterface2 theEObject) {
			return default(T);
		}
		public virtual T caseSubInterface3(SubInterface3 theEObject) {
			return default(T);
		}
		public virtual T caseSubAbstractClass1(SubAbstractClass1 theEObject) {
			return default(T);
		}
		public virtual T caseSubAbstractClass2(SubAbstractClass2 theEObject) {
			return default(T);
		}
		public virtual T caseSubAbstractClass3(SubAbstractClass3 theEObject) {
			return default(T);
		}
		public virtual T caseSubClass1(SubClass1 theEObject) {
			return default(T);
		}
		public virtual T caseSubClass2(SubClass2 theEObject) {
			return default(T);
		}
		public virtual T caseSubClass3(SubClass3 theEObject) {
			return default(T);
		}
		public virtual T caseSubInterface4(SubInterface4 theEObject) {
			return default(T);
		}
		public virtual T caseSubInterface5(SubInterface5 theEObject) {
			return default(T);
		}
		public virtual T caseSubInterface6(SubInterface6 theEObject) {
			return default(T);
		}
		public virtual T caseSubInterface7(SubInterface7 theEObject) {
			return default(T);
		}
		public virtual T caseSubAbstractClass4(SubAbstractClass4 theEObject) {
			return default(T);
		}
		public virtual T caseSubAbstractClass5(SubAbstractClass5 theEObject) {
			return default(T);
		}
		public virtual T caseSubAbstractClass6(SubAbstractClass6 theEObject) {
			return default(T);
		}
		public virtual T caseSubAbstractClass7(SubAbstractClass7 theEObject) {
			return default(T);
		}
		public virtual T caseSubClass4(SubClass4 theEObject) {
			return default(T);
		}
		public virtual T caseSubClass5(SubClass5 theEObject) {
			return default(T);
		}
		public virtual T caseSubClass6(SubClass6 theEObject) {
			return default(T);
		}
		public virtual T caseSubClass7(SubClass7 theEObject) {
			return default(T);
		}
		public virtual T caseA(A theEObject) {
			return default(T);
		}
		public virtual T caseB(B theEObject) {
			return default(T);
		}
		public virtual T caseC(C theEObject) {
			return default(T);
		}
		public virtual T caseSource(Source theEObject) {
			return default(T);
		}
		public virtual T caseTarget(Target theEObject) {
			return default(T);
		}
		
	}
}
