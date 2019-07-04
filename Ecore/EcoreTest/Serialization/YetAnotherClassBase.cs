/* CrossEcore is a cross-platform modeling framework that generates C#, TypeScript, 
 * JavaScript, Swift code from Ecore models with embedded OCL (http://www.crossecore.org/).
 * The original Eclipse Modeling Framework is available at https://www.eclipse.org/modeling/emf/.
 * 
 * contributor: Simon Schwichtenberg
 */
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using oclstdlib;
using Ecore;
namespace Serialization{
	public class YetAnotherClassBase 
	:BasicEObjectImpl, YetAnotherClass
	{
		private int _no_id = 0;
		public virtual int no_id
		{
		get { 
			return _no_id;
		}
		set { _no_id = value; }
		}
		
		protected override EClass eStaticClass() {
			return SerializationPackageImpl.Literals.YETANOTHERCLASS;
		}
		
		
		
		
		public override object eGet(int featureID, bool resolve, bool coreType) {
			switch (featureID) {
				case SerializationPackageImpl.YET_ANOTHER_CLASS__NO_ID:
					return no_id;
			}
			return base.eGet(featureID, resolve, coreType);
		}
		
		
		public override void eSet(int featureID, object newValue) {
			switch (featureID) {
				case SerializationPackageImpl.YET_ANOTHER_CLASS__NO_ID:
					no_id = (int) newValue;
					return;
			}
			base.eSet(featureID, newValue);
		}
		
		/*
		public override bool eIsSet(int featureID) {
			switch (featureID) {
				case SerializationPackageImpl.YET_ANOTHER_CLASS__NO_ID:
					return _no_id != NO_ID_EDEFAULT;
			}
			return base.eIsSet(featureID);
		}
		*/
		
		
		
	}
}
