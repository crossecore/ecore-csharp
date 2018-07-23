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
	public class EEnumLiteralBase 
	:ENamedElementImpl, EEnumLiteral
	{
		private string _literal = "";
		public virtual string literal
		{
		get { 
			return _literal;
		}
		set { _literal = value; }
		}
		private EEnumerator _instance = null;
		public virtual EEnumerator instance
		{
		get { 
			return _instance;
		}
		set { _instance = value; }
		}
		private int _value = 0;
		public virtual int value
		{
		get { 
			return _value;
		}
		set { _value = value; }
		}
		public virtual EEnum eEnum
		{
			get {
			
				if (eContainerFeatureID() != EcorePackageImpl.EENUMLITERAL_EENUM) return default(EEnum);
				return (EEnum)eInternalContainer();
			}
		}
		
		protected override EClass eStaticClass() {
			return EcorePackageImpl.Literals.EENUMLITERAL;
		}
		
		public override NotificationChain eInverseAdd(InternalEObject otherEnd, int featureID, NotificationChain msgs) {
			switch (featureID) {
				case EcorePackageImpl.EENUMLITERAL_EENUM:
					if (eInternalContainer() != null) {
						msgs = eBasicRemoveFromContainer(msgs);
					}
					return basicSetEEnum((EEnum)otherEnd, msgs);
			}
			return base.eInverseAdd(otherEnd, featureID, msgs);
		}
		
		public override NotificationChain eInverseRemove(InternalEObject otherEnd, int featureID, NotificationChain msgs) {
			switch (featureID) {
				case EcorePackageImpl.EENUMLITERAL_EENUM:
					return basicSetEEnum(null, msgs);
			}
			return base.eInverseRemove(otherEnd, featureID, msgs);
		}
		
		public NotificationChain basicSetEEnum(EEnum newobj, NotificationChain msgs) {
				msgs = eBasicSetContainer((InternalEObject)newobj, EcorePackageImpl.EENUMLITERAL_EENUM, msgs);
				return msgs;
		}
		
		public override Object eGet(int featureID, bool resolve, bool coreType) {
			switch (featureID) {
				case EcorePackageImpl.EENUMLITERAL_EANNOTATIONS:
					return eAnnotations;
				case EcorePackageImpl.EENUMLITERAL_NAME:
					return name;
				case EcorePackageImpl.EENUMLITERAL_VALUE:
					return value;
				case EcorePackageImpl.EENUMLITERAL_INSTANCE:
					return instance;
				case EcorePackageImpl.EENUMLITERAL_LITERAL:
					return literal;
				case EcorePackageImpl.EENUMLITERAL_EENUM:
					return eEnum;
			}
			return base.eGet(featureID, resolve, coreType);
		}
		
		
		public override void eSet(int featureID, object newValue) {
			switch (featureID) {
				case EcorePackageImpl.EENUMLITERAL_EANNOTATIONS:
					eAnnotations.Clear();
					eAnnotations.AddRange(((List<EObject>)newValue)?.Cast<EAnnotation>());
					return;
				case EcorePackageImpl.EENUMLITERAL_NAME:
					name = (string) newValue;
					return;
				case EcorePackageImpl.EENUMLITERAL_VALUE:
					value = (int) newValue;
					return;
				case EcorePackageImpl.EENUMLITERAL_INSTANCE:
					instance = (EEnumerator) newValue;
					return;
				case EcorePackageImpl.EENUMLITERAL_LITERAL:
					literal = (string) newValue;
					return;
			}
			base.eSet(featureID, newValue);
		}
		
		
	}
}
