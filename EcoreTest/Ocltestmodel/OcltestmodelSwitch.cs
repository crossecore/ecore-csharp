	 	using Ecore;
namespace Ocltestmodel{
	public class OcltestmodelSwitch<T> : Switch<T> {
	
		protected static OcltestmodelPackage modelPackage;
		
		protected override bool isSwitchFor(EPackage ePackage)
		{
			return ePackage == modelPackage;
		}

		public OcltestmodelSwitch()
		{
			if (modelPackage == null)
			{
				modelPackage = OcltestmodelPackageImpl.eINSTANCE;
			}
		}
		
		protected override T doSwitch(int classifierID, EObject theEObject) {
			switch (classifierID) {
				case OcltestmodelPackageImpl.MYCLASS: {
					var myclass = (MyClass) theEObject;
					var result = caseMyClass(myclass);
					
					
					if (result == null) result = defaultCase(theEObject);
					return result;
				}
				default: return defaultCase(theEObject);
			}
		}
		
		
		public virtual T caseMyClass(MyClass theEObject) {
			return default(T);
		}
		
	}
}
