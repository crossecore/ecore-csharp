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
namespace Ecore{
	public class EStringToStringMapEntryBase 
	:BasicEObjectImpl, EStringToStringMapEntry
	{
		private string _value = "";
		public virtual string value
		{
		get { 
			return _value;
		}
		set { _value = value; }
		}
		private string _key = "";
		public virtual string key
		{
		get { 
			return _key;
		}
		set { _key = value; }
		}
		
		protected override EClass eStaticClass() {
			return EcorePackageImpl.Literals.ESTRINGTOSTRINGMAPENTRY;
		}
		
		
		
		public override Object eGet(int featureID, bool resolve, bool coreType) {
			switch (featureID) {
				case EcorePackageImpl.ESTRINGTOSTRINGMAPENTRY_KEY:
					return key;
				case EcorePackageImpl.ESTRINGTOSTRINGMAPENTRY_VALUE:
					return value;
			}
			return base.eGet(featureID, resolve, coreType);
		}
		
		
		public override void eSet(int featureID, object newValue) {
			switch (featureID) {
				case EcorePackageImpl.ESTRINGTOSTRINGMAPENTRY_KEY:
					key = (string) newValue;
					return;
				case EcorePackageImpl.ESTRINGTOSTRINGMAPENTRY_VALUE:
					value = (string) newValue;
					return;
			}
			base.eSet(featureID, newValue);
		}
		
		
	}
}
