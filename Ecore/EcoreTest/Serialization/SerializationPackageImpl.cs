/* CrossEcore is a cross-platform modeling framework that generates C#, TypeScript, 
 * JavaScript, Swift code from Ecore models with embedded OCL (http://www.crossecore.org/).
 * The original Eclipse Modeling Framework is available at https://www.eclipse.org/modeling/emf/.
 * 
 * contributor: Simon Schwichtenberg
 */
 
	 	using Ecore;
namespace Serialization{
	public class SerializationPackageImpl : EPackageImpl, SerializationPackage{
			public const string eNAME = "serialization";
			
			public const string eNS_URI = "serialization";
			
			public const string eNS_PREFIX = "serialization";
			
			public static SerializationPackage eINSTANCE = init();
			
			private SerializationPackageImpl():base(eNS_URI, SerializationFactoryImpl.eINSTANCE)
			{
				
			}
			
            public static SerializationPackage init()
            {
                // Obtain or create and register package
                var theSerializationPackage = new SerializationPackageImpl();

                // Create package meta-data objects
                theSerializationPackage.createPackageContents();

                // Initialize created meta-data
                theSerializationPackage.initializePackageContents();

		        return theSerializationPackage;
	        }
	        
	        private bool isCreated = false;
            public void createPackageContents()
            {
                if (isCreated) return;
                isCreated = true;
				MyClassEClass = createEClass(MYCLASS);
				createEAttribute(MyClassEClass, MY_CLASS__ATTRIBUTE_STRING);
				createEReference(MyClassEClass, MY_CLASS__OTHERCLASS);
				createEReference(MyClassEClass, MY_CLASS__SELECTION);
				createEReference(MyClassEClass, MY_CLASS__YETANOTHERCLASS);
				createEReference(MyClassEClass, MY_CLASS__SELECTION2);
				OtherClassEClass = createEClass(OTHERCLASS);
				createEAttribute(OtherClassEClass, OTHER_CLASS__ID);
				YetAnotherClassEClass = createEClass(YETANOTHERCLASS);
				createEAttribute(YetAnotherClassEClass, YET_ANOTHER_CLASS__NO_ID);
				
				
				
	        }
	        
	        private bool isInitialized = false;
	        public void initializePackageContents()
	        {
                if (isInitialized) return;
                isInitialized = true;
	            // Initialize package
	            name = eNAME;
	            nsPrefix = eNS_PREFIX;
	            nsURI = eNS_URI;
	
				
				
				
				
				initEClass(MyClassEClass, typeof(MyClass), "MyClass", !IS_ABSTRACT, !IS_INTERFACE, IS_GENERATED_INSTANCE_CLASS);						
				
				initEAttribute(getMyClass_Attribute_string(), 
					ecorePackage.getEString(), 
					"attribute_string", 
					"", 
					0, 
					1, 
					typeof(MyClassImpl), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					!IS_UNSETTABLE, 
					!IS_ID, 
					IS_UNIQUE, 
					!IS_DERIVED, 
					IS_ORDERED);
				
				initEReference(
					getMyClass_Otherclass(), 
					this.getOtherClass(), 
					null, 
					"otherclass", 
					null, 
					0, 
					-1, 
					typeof(MyClass), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					IS_COMPOSITE, 
					IS_RESOLVE_PROXIES, 
					!IS_UNSETTABLE, 
					IS_UNIQUE, 
					!IS_DERIVED, 
					IS_ORDERED);
				initEReference(
					getMyClass_Selection(), 
					this.getOtherClass(), 
					null, 
					"selection", 
					null, 
					0, 
					1, 
					typeof(MyClass), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					!IS_COMPOSITE, 
					IS_RESOLVE_PROXIES, 
					!IS_UNSETTABLE, 
					IS_UNIQUE, 
					!IS_DERIVED, 
					IS_ORDERED);
				initEReference(
					getMyClass_Yetanotherclass(), 
					this.getYetAnotherClass(), 
					null, 
					"yetanotherclass", 
					null, 
					0, 
					-1, 
					typeof(MyClass), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					IS_COMPOSITE, 
					IS_RESOLVE_PROXIES, 
					!IS_UNSETTABLE, 
					IS_UNIQUE, 
					!IS_DERIVED, 
					IS_ORDERED);
				initEReference(
					getMyClass_Selection2(), 
					this.getYetAnotherClass(), 
					null, 
					"selection2", 
					null, 
					0, 
					1, 
					typeof(MyClass), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					!IS_COMPOSITE, 
					IS_RESOLVE_PROXIES, 
					!IS_UNSETTABLE, 
					IS_UNIQUE, 
					!IS_DERIVED, 
					IS_ORDERED);
				initEClass(OtherClassEClass, typeof(OtherClass), "OtherClass", !IS_ABSTRACT, !IS_INTERFACE, IS_GENERATED_INSTANCE_CLASS);						
				
				initEAttribute(getOtherClass_Id(), 
					ecorePackage.getEString(), 
					"id", 
					null, 
					0, 
					1, 
					typeof(OtherClassImpl), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					!IS_UNSETTABLE, 
					IS_ID, 
					IS_UNIQUE, 
					!IS_DERIVED, 
					IS_ORDERED);
				
				initEClass(YetAnotherClassEClass, typeof(YetAnotherClass), "YetAnotherClass", !IS_ABSTRACT, !IS_INTERFACE, IS_GENERATED_INSTANCE_CLASS);						
				
				initEAttribute(getYetAnotherClass_No_id(), 
					ecorePackage.getEInt(), 
					"no_id", 
					"0", 
					0, 
					1, 
					typeof(YetAnotherClassImpl), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					!IS_UNSETTABLE, 
					!IS_ID, 
					IS_UNIQUE, 
					!IS_DERIVED, 
					IS_ORDERED);
				
	        }
	        
			
			private EClass MyClassEClass = null;
			private EClass OtherClassEClass = null;
			private EClass YetAnotherClassEClass = null;
			
			
			
			
			
			public const int MYCLASS = 0;
			public const int MYCLASS_FEATURE_COUNT = 5;
			public const int MYCLASS_OPERATION_COUNT = 0;
			
			public const int MY_CLASS__ATTRIBUTE_STRING = 0;
			public const int MY_CLASS__OTHERCLASS = 1;
			public const int MY_CLASS__SELECTION = 2;
			public const int MY_CLASS__YETANOTHERCLASS = 3;
			public const int MY_CLASS__SELECTION2 = 4;
			
			public const int OTHERCLASS = 1;
			public const int OTHERCLASS_FEATURE_COUNT = 1;
			public const int OTHERCLASS_OPERATION_COUNT = 0;
			
			public const int OTHER_CLASS__ID = 0;
			
			public const int YETANOTHERCLASS = 2;
			public const int YETANOTHERCLASS_FEATURE_COUNT = 1;
			public const int YETANOTHERCLASS_OPERATION_COUNT = 0;
			
			public const int YET_ANOTHER_CLASS__NO_ID = 0;
			
			
			
			public EClass getMyClass(){return MyClassEClass;}
			
			public EAttribute getMyClass_Attribute_string(){return (EAttribute)MyClassEClass.eStructuralFeatures.at(0);}
			public EReference getMyClass_Otherclass(){return (EReference)MyClassEClass.eStructuralFeatures.at(1);}
			public EReference getMyClass_Selection(){return (EReference)MyClassEClass.eStructuralFeatures.at(2);}
			public EReference getMyClass_Yetanotherclass(){return (EReference)MyClassEClass.eStructuralFeatures.at(3);}
			public EReference getMyClass_Selection2(){return (EReference)MyClassEClass.eStructuralFeatures.at(4);}
			public EClass getOtherClass(){return OtherClassEClass;}
			
			public EAttribute getOtherClass_Id(){return (EAttribute)OtherClassEClass.eStructuralFeatures.at(0);}
			public EClass getYetAnotherClass(){return YetAnotherClassEClass;}
			
			public EAttribute getYetAnotherClass_No_id(){return (EAttribute)YetAnotherClassEClass.eStructuralFeatures.at(0);}
			
			public class Literals{
				public static EClass MYCLASS = SerializationPackageImpl.eINSTANCE.getMyClass();
				
				public static EReference MY_CLASS__OTHERCLASS = SerializationPackageImpl.eINSTANCE.getMyClass_Otherclass();
				public static EReference MY_CLASS__SELECTION = SerializationPackageImpl.eINSTANCE.getMyClass_Selection();
				public static EReference MY_CLASS__YETANOTHERCLASS = SerializationPackageImpl.eINSTANCE.getMyClass_Yetanotherclass();
				public static EReference MY_CLASS__SELECTION2 = SerializationPackageImpl.eINSTANCE.getMyClass_Selection2();
				
				public static EAttribute MY_CLASS__ATTRIBUTE_STRING = SerializationPackageImpl.eINSTANCE.getMyClass_Attribute_string();
				public static EClass OTHERCLASS = SerializationPackageImpl.eINSTANCE.getOtherClass();
				
				
				public static EAttribute OTHER_CLASS__ID = SerializationPackageImpl.eINSTANCE.getOtherClass_Id();
				public static EClass YETANOTHERCLASS = SerializationPackageImpl.eINSTANCE.getYetAnotherClass();
				
				
				public static EAttribute YET_ANOTHER_CLASS__NO_ID = SerializationPackageImpl.eINSTANCE.getYetAnotherClass_No_id();
			}
	 
	}
}
