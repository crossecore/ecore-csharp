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
	public class ENamedElementBase 
	:EModelElementImpl, ENamedElement
	{
		private string _name = "";
		public virtual string name
		{
		get { 
			return _name;
		}
		set { _name = value; }
		}
		
		protected override EClass eStaticClass() {
			return EcorePackageImpl.Literals.ENAMEDELEMENT;
		}
		
		
		
		public override Object eGet(int featureID, bool resolve, bool coreType) {
			switch (featureID) {
				case EcorePackageImpl.ENAMEDELEMENT_EANNOTATIONS:
					return eAnnotations;
				case EcorePackageImpl.ENAMEDELEMENT_NAME:
					return name;
			}
			return base.eGet(featureID, resolve, coreType);
		}
		
		
		public override void eSet(int featureID, object newValue) {
			switch (featureID) {
				case EcorePackageImpl.ENAMEDELEMENT_EANNOTATIONS:
					eAnnotations.Clear();
					eAnnotations.AddRange(((List<EObject>)newValue)?.Cast<EAnnotation>());
					return;
				case EcorePackageImpl.ENAMEDELEMENT_NAME:
					name = (string) newValue;
					return;
			}
			base.eSet(featureID, newValue);
		}
		
		
	}
}
