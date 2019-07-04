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
	public class MyClassBase 
	:BasicEObjectImpl, MyClass
	{
		private string _attribute_string = "";
		public virtual string attribute_string
		{
		get { 
			return _attribute_string;
		}
		set { _attribute_string = value; }
		}
		private OrderedSet<OtherClass> _otherclass;
		
		public virtual OrderedSet<OtherClass> otherclass
		{
			get {
				if(_otherclass==null){
					_otherclass = new OrderedSet<OtherClass>(this, SerializationPackageImpl.MY_CLASS__OTHERCLASS, EOPPOSITE_FEATURE_BASE - SerializationPackageImpl.MY_CLASS__OTHERCLASS);
				}
				return _otherclass;
			}
		
		}
		private OtherClass _selection;
		public virtual OtherClass selection
		{
			get {
			
				return _selection;
			}
			set {
				var oldvalue = _selection;
				_selection = value;
				if (eNotificationRequired()){
					eNotify(new ENotificationImpl(this, NotificationImpl.SET, SerializationPackageImpl.MY_CLASS__SELECTION, oldvalue, value));
				}
				}
		}
		private OrderedSet<YetAnotherClass> _yetanotherclass;
		
		public virtual OrderedSet<YetAnotherClass> yetanotherclass
		{
			get {
				if(_yetanotherclass==null){
					_yetanotherclass = new OrderedSet<YetAnotherClass>(this, SerializationPackageImpl.MY_CLASS__YETANOTHERCLASS, EOPPOSITE_FEATURE_BASE - SerializationPackageImpl.MY_CLASS__YETANOTHERCLASS);
				}
				return _yetanotherclass;
			}
		
		}
		private YetAnotherClass _selection2;
		public virtual YetAnotherClass selection2
		{
			get {
			
				return _selection2;
			}
			set {
				var oldvalue = _selection2;
				_selection2 = value;
				if (eNotificationRequired()){
					eNotify(new ENotificationImpl(this, NotificationImpl.SET, SerializationPackageImpl.MY_CLASS__SELECTION2, oldvalue, value));
				}
				}
		}
		
		protected override EClass eStaticClass() {
			return SerializationPackageImpl.Literals.MYCLASS;
		}
		
		
		public NotificationChain basicSetSelection(OtherClass newobj, NotificationChain msgs) {
			var oldobj = _selection;
			_selection = newobj;
			if (eNotificationRequired()) {
				var notification = new ENotificationImpl(this, NotificationImpl.SET, SerializationPackageImpl.MY_CLASS__SELECTION, oldobj, newobj);
				if (msgs == null){
					msgs = notification;
				}
				else{
					msgs.add(notification);
				}
			}
			return msgs;
		}
		public NotificationChain basicSetSelection2(YetAnotherClass newobj, NotificationChain msgs) {
			var oldobj = _selection2;
			_selection2 = newobj;
			if (eNotificationRequired()) {
				var notification = new ENotificationImpl(this, NotificationImpl.SET, SerializationPackageImpl.MY_CLASS__SELECTION2, oldobj, newobj);
				if (msgs == null){
					msgs = notification;
				}
				else{
					msgs.add(notification);
				}
			}
			return msgs;
		}
		
		
		public override object eGet(int featureID, bool resolve, bool coreType) {
			switch (featureID) {
				case SerializationPackageImpl.MY_CLASS__ATTRIBUTE_STRING:
					return attribute_string;
				case SerializationPackageImpl.MY_CLASS__OTHERCLASS:
					return otherclass;
				case SerializationPackageImpl.MY_CLASS__SELECTION:
					return selection;
				case SerializationPackageImpl.MY_CLASS__YETANOTHERCLASS:
					return yetanotherclass;
				case SerializationPackageImpl.MY_CLASS__SELECTION2:
					return selection2;
			}
			return base.eGet(featureID, resolve, coreType);
		}
		
		
		public override void eSet(int featureID, object newValue) {
			switch (featureID) {
				case SerializationPackageImpl.MY_CLASS__ATTRIBUTE_STRING:
					attribute_string = (string) newValue;
					return;
				case SerializationPackageImpl.MY_CLASS__OTHERCLASS:
					otherclass.Clear();
					otherclass.AddRange(((List<EObject>)newValue)?.Cast<OtherClass>());
					return;
				case SerializationPackageImpl.MY_CLASS__SELECTION:
					selection = (OtherClass) newValue;
					return;
				case SerializationPackageImpl.MY_CLASS__YETANOTHERCLASS:
					yetanotherclass.Clear();
					yetanotherclass.AddRange(((List<EObject>)newValue)?.Cast<YetAnotherClass>());
					return;
				case SerializationPackageImpl.MY_CLASS__SELECTION2:
					selection2 = (YetAnotherClass) newValue;
					return;
			}
			base.eSet(featureID, newValue);
		}
		
		/*
		public override bool eIsSet(int featureID) {
			switch (featureID) {
				case SerializationPackageImpl.MY_CLASS__ATTRIBUTE_STRING:
					return ATTRIBUTE_STRING_EDEFAULT == null ? _attribute_string != null : !ATTRIBUTE_STRING_EDEFAULT.equals(_attribute_string);
				case SerializationPackageImpl.MY_CLASS__OTHERCLASS:
					return _otherclass != null && !_otherclass.isEmpty();
				case SerializationPackageImpl.MY_CLASS__SELECTION:
					return getSelection() != null; //single, volatile
				case SerializationPackageImpl.MY_CLASS__YETANOTHERCLASS:
					return _yetanotherclass != null && !_yetanotherclass.isEmpty();
				case SerializationPackageImpl.MY_CLASS__SELECTION2:
					return getSelection2() != null; //single, volatile
			}
			return base.eIsSet(featureID);
		}
		*/
		
		
		
	}
}
