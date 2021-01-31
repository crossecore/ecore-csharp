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
	public class EModelElementBase 
	:BasicEObjectImpl, EModelElement
	{
		private OrderedSet<EAnnotation> _eAnnotations;
		
		public virtual OrderedSet<EAnnotation> eAnnotations
		{
			get {
				if(_eAnnotations==null){
					_eAnnotations = new OrderedSet<EAnnotation>(this, EcorePackageImpl.EMODELELEMENT_EANNOTATIONS, EcorePackageImpl.EANNOTATION_EMODELELEMENT);
				}
				return _eAnnotations;
			}
		
		}
		public virtual EAnnotation getEAnnotation(string source
		)
		{
		    throw new NotImplementedException();
		}
		
		protected override EClass eStaticClass() {
			return EcorePackageImpl.Literals.EMODELELEMENT;
		}
		
		public override NotificationChain eInverseAdd(InternalEObject otherEnd, int featureID, NotificationChain msgs) {
			switch (featureID) {
				case EcorePackageImpl.EMODELELEMENT_EANNOTATIONS:
					return eAnnotations.basicAdd((EAnnotation)otherEnd, msgs);
			}
			return base.eInverseAdd(otherEnd, featureID, msgs);
		}
		
		public override NotificationChain eInverseRemove(InternalEObject otherEnd, int featureID, NotificationChain msgs) {
			switch (featureID) {
				case EcorePackageImpl.EMODELELEMENT_EANNOTATIONS:
					return eAnnotations.basicRemove((EAnnotation)otherEnd, msgs);
			}
			return base.eInverseRemove(otherEnd, featureID, msgs);
		}
		
		
		public override Object eGet(int featureID, bool resolve, bool coreType) {
			switch (featureID) {
				case EcorePackageImpl.EMODELELEMENT_EANNOTATIONS:
					return eAnnotations;
			}
			return base.eGet(featureID, resolve, coreType);
		}
		
		
		public override void eSet(int featureID, object newValue) {
			switch (featureID) {
				case EcorePackageImpl.EMODELELEMENT_EANNOTATIONS:
					eAnnotations.Clear();
					eAnnotations.AddRange(((List<EObject>)newValue)?.Cast<EAnnotation>());
					return;
			}
			base.eSet(featureID, newValue);
		}
		
		
	}
}
