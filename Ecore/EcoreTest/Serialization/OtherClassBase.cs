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
	public class OtherClassBase 
	:BasicEObjectImpl, OtherClass
	{
		private string _id = "";
		public virtual string id
		{
		get { 
			return _id;
		}
		set { _id = value; }
		}
		
		protected override EClass eStaticClass() {
			return SerializationPackageImpl.Literals.OTHERCLASS;
		}
		
		
		
		
		public override object eGet(int featureID, bool resolve, bool coreType) {
			switch (featureID) {
				case SerializationPackageImpl.OTHER_CLASS__ID:
					return id;
			}
			return base.eGet(featureID, resolve, coreType);
		}
		
		
		public override void eSet(int featureID, object newValue) {
			switch (featureID) {
				case SerializationPackageImpl.OTHER_CLASS__ID:
					id = (string) newValue;
					return;
			}
			base.eSet(featureID, newValue);
		}
		
		/*
		public override bool eIsSet(int featureID) {
			switch (featureID) {
				case SerializationPackageImpl.OTHER_CLASS__ID:
					return ID_EDEFAULT == null ? _id != null : !ID_EDEFAULT.equals(_id);
			}
			return base.eIsSet(featureID);
		}
		*/
		
		
		
	}
}
