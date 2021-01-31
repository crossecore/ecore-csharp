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
	public class ETypeParameterBase 
	:ENamedElementImpl, ETypeParameter
	{
		private OrderedSet<EGenericType> _eBounds;
		
		public virtual OrderedSet<EGenericType> eBounds
		{
			get {
				if(_eBounds==null){
					_eBounds = new OrderedSet<EGenericType>(this, EcorePackageImpl.ETYPEPARAMETER_EBOUNDS, EOPPOSITE_FEATURE_BASE - EcorePackageImpl.ETYPEPARAMETER_EBOUNDS);
				}
				return _eBounds;
			}
		
		}
		
		protected override EClass eStaticClass() {
			return EcorePackageImpl.Literals.ETYPEPARAMETER;
		}
		
		
		
		public override Object eGet(int featureID, bool resolve, bool coreType) {
			switch (featureID) {
				case EcorePackageImpl.ETYPEPARAMETER_EANNOTATIONS:
					return eAnnotations;
				case EcorePackageImpl.ETYPEPARAMETER_NAME:
					return name;
				case EcorePackageImpl.ETYPEPARAMETER_EBOUNDS:
					return eBounds;
			}
			return base.eGet(featureID, resolve, coreType);
		}
		
		
		public override void eSet(int featureID, object newValue) {
			switch (featureID) {
				case EcorePackageImpl.ETYPEPARAMETER_EANNOTATIONS:
					eAnnotations.Clear();
					eAnnotations.AddRange(((List<EObject>)newValue)?.Cast<EAnnotation>());
					return;
				case EcorePackageImpl.ETYPEPARAMETER_NAME:
					name = (string) newValue;
					return;
				case EcorePackageImpl.ETYPEPARAMETER_EBOUNDS:
					eBounds.Clear();
					eBounds.AddRange(((List<EObject>)newValue)?.Cast<EGenericType>());
					return;
			}
			base.eSet(featureID, newValue);
		}
		
		
	}
}
