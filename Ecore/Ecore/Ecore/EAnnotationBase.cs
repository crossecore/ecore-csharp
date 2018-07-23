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
	public class EAnnotationBase 
	:EModelElementImpl, EAnnotation
	{
		private string _source = "";
		public virtual string source
		{
		get { 
			return _source;
		}
		set { _source = value; }
		}
		private OrderedSet<EObject> _contents;
		
		public virtual OrderedSet<EObject> contents
		{
			get {
				if(_contents==null){
					_contents = new OrderedSet<EObject>(this, EcorePackageImpl.EANNOTATION_CONTENTS, EOPPOSITE_FEATURE_BASE - EcorePackageImpl.EANNOTATION_CONTENTS);
				}
				return _contents;
			}
		
		}
		private EMap<string, string> _details;
		
		public virtual EMap<string, string> details
		{
			get {
				if (_details == null)
				{
					_details = new EcoreEMap<string, string>(EcorePackageImpl.Literals.ESTRINGTOSTRINGMAPENTRY, typeof(EStringToStringMapEntry), this, -1);
				}
				return _details;
			}
		
		}
		public virtual EModelElement eModelElement
		{
			get {
			
				if (eContainerFeatureID() != EcorePackageImpl.EANNOTATION_EMODELELEMENT) return default(EModelElement);
				return (EModelElement)eInternalContainer();
			}
			set {
				if (value != eInternalContainer()) {
					NotificationChain msgs = null;
					if (eInternalContainer() != null){
						msgs = ((InternalEObject)eInternalContainer()).eInverseRemove(this, EcorePackageImpl.EMODELELEMENT_EANNOTATIONS, typeof(EAnnotation), msgs);
					}
					if (value != null){
						msgs = ((InternalEObject)value).eInverseAdd(this, EcorePackageImpl.EMODELELEMENT_EANNOTATIONS, typeof(EAnnotation), msgs);
					}
					msgs = basicSetEModelElement(value, msgs);
					if (msgs != null) {
						msgs.dispatch();
					}
				}
				else if (eNotificationRequired()){
					eNotify(new ENotificationImpl(this, NotificationImpl.SET,EcorePackageImpl.EANNOTATION_EMODELELEMENT , value, value));
				}
				}
		}
		private OrderedSet<EObject> _references;
		
		public virtual OrderedSet<EObject> references
		{
			get {
				if(_references==null){
					_references = new OrderedSet<EObject>(this, EcorePackageImpl.EANNOTATION_REFERENCES, EOPPOSITE_FEATURE_BASE - EcorePackageImpl.EANNOTATION_REFERENCES);
				}
				return _references;
			}
		
		}
		
		protected override EClass eStaticClass() {
			return EcorePackageImpl.Literals.EANNOTATION;
		}
		
		public override NotificationChain eInverseAdd(InternalEObject otherEnd, int featureID, NotificationChain msgs) {
			switch (featureID) {
				case EcorePackageImpl.EANNOTATION_EMODELELEMENT:
					if (eInternalContainer() != null) {
						msgs = eBasicRemoveFromContainer(msgs);
					}
					return basicSetEModelElement((EModelElement)otherEnd, msgs);
			}
			return base.eInverseAdd(otherEnd, featureID, msgs);
		}
		
		public override NotificationChain eInverseRemove(InternalEObject otherEnd, int featureID, NotificationChain msgs) {
			switch (featureID) {
				case EcorePackageImpl.EANNOTATION_EMODELELEMENT:
					return basicSetEModelElement(null, msgs);
			}
			return base.eInverseRemove(otherEnd, featureID, msgs);
		}
		
		public NotificationChain basicSetEModelElement(EModelElement newobj, NotificationChain msgs) {
				msgs = eBasicSetContainer((InternalEObject)newobj, EcorePackageImpl.EANNOTATION_EMODELELEMENT, msgs);
				return msgs;
		}
		
		public override Object eGet(int featureID, bool resolve, bool coreType) {
			switch (featureID) {
				case EcorePackageImpl.EANNOTATION_EANNOTATIONS:
					return eAnnotations;
				case EcorePackageImpl.EANNOTATION_SOURCE:
					return source;
				case EcorePackageImpl.EANNOTATION_DETAILS:
					if (coreType) return details;
					else return details.map();							
				case EcorePackageImpl.EANNOTATION_EMODELELEMENT:
					return eModelElement;
				case EcorePackageImpl.EANNOTATION_CONTENTS:
					return contents;
				case EcorePackageImpl.EANNOTATION_REFERENCES:
					return references;
			}
			return base.eGet(featureID, resolve, coreType);
		}
		
		
		public override void eSet(int featureID, object newValue) {
			switch (featureID) {
				case EcorePackageImpl.EANNOTATION_EANNOTATIONS:
					eAnnotations.Clear();
					eAnnotations.AddRange(((List<EObject>)newValue)?.Cast<EAnnotation>());
					return;
				case EcorePackageImpl.EANNOTATION_SOURCE:
					source = (string) newValue;
					return;
				case EcorePackageImpl.EANNOTATION_DETAILS:
					((EcoreEMap<string, string>)details).set(newValue);
					return;
				case EcorePackageImpl.EANNOTATION_EMODELELEMENT:
					eModelElement = (EModelElement) newValue;
					return;
				case EcorePackageImpl.EANNOTATION_CONTENTS:
					contents.Clear();
					contents.AddRange(((List<EObject>)newValue)?.Cast<EObject>());
					return;
				case EcorePackageImpl.EANNOTATION_REFERENCES:
					references.Clear();
					references.AddRange(((List<EObject>)newValue)?.Cast<EObject>());
					return;
			}
			base.eSet(featureID, newValue);
		}
		
		
	}
}
