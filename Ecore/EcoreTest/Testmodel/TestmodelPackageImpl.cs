	 	using Ecore;
namespace Testmodel{
	public class TestmodelPackageImpl : EPackageImpl, TestmodelPackage{
			public const string eNAME = "testmodel";
			
			public const string eNS_URI = "http://www.example.org/Testmodel";
			
			public const string eNS_PREFIX = "testmodel";
			
			public static TestmodelPackage eINSTANCE = init();
			
			private TestmodelPackageImpl():base(eNS_URI, TestmodelFactoryImpl.eINSTANCE)
			{
				
			}
			
            public static TestmodelPackage init()
            {
                // Obtain or create and register package
                var theTestmodelPackage = new TestmodelPackageImpl();

                // Create package meta-data objects
                theTestmodelPackage.createPackageContents();

                // Initialize created meta-data
                theTestmodelPackage.initializePackageContents();

		        return theTestmodelPackage;
	        }
	        
	        private bool isCreated = false;
            public void createPackageContents()
            {
                if (isCreated) return;
                isCreated = true;
				SuperInterfaceEClass = createEClass(SUPERINTERFACE);
				SuperAbstractClassEClass = createEClass(SUPERABSTRACTCLASS);
				SuperClassEClass = createEClass(SUPERCLASS);
				SubInterface1EClass = createEClass(SUBINTERFACE1);
				SubInterface2EClass = createEClass(SUBINTERFACE2);
				SubInterface3EClass = createEClass(SUBINTERFACE3);
				SubAbstractClass1EClass = createEClass(SUBABSTRACTCLASS1);
				SubAbstractClass2EClass = createEClass(SUBABSTRACTCLASS2);
				SubAbstractClass3EClass = createEClass(SUBABSTRACTCLASS3);
				SubClass1EClass = createEClass(SUBCLASS1);
				SubClass2EClass = createEClass(SUBCLASS2);
				SubClass3EClass = createEClass(SUBCLASS3);
				SubInterface4EClass = createEClass(SUBINTERFACE4);
				SubInterface5EClass = createEClass(SUBINTERFACE5);
				SubInterface6EClass = createEClass(SUBINTERFACE6);
				SubInterface7EClass = createEClass(SUBINTERFACE7);
				SubAbstractClass4EClass = createEClass(SUBABSTRACTCLASS4);
				SubAbstractClass5EClass = createEClass(SUBABSTRACTCLASS5);
				SubAbstractClass6EClass = createEClass(SUBABSTRACTCLASS6);
				SubAbstractClass7EClass = createEClass(SUBABSTRACTCLASS7);
				SubClass4EClass = createEClass(SUBCLASS4);
				SubClass5EClass = createEClass(SUBCLASS5);
				SubClass6EClass = createEClass(SUBCLASS6);
				SubClass7EClass = createEClass(SUBCLASS7);
				AEClass = createEClass(A);
				createEAttribute(AEClass, A_A);
				BEClass = createEClass(B);
				createEAttribute(BEClass, B_B);
				CEClass = createEClass(C);
				createEAttribute(CEClass, C_C);
				SourceEClass = createEClass(SOURCE);
				createEReference(SourceEClass, SOURCE_ZERO_ONE_NO_NO);
				createEReference(SourceEClass, SOURCE_ZERO_MANY_NO_NO);
				createEReference(SourceEClass, SOURCE_ZERO_ONE_NO_YES);
				createEReference(SourceEClass, SOURCE_ZERO_MANY_NO_YES);
				createEReference(SourceEClass, SOURCE_ONE_ONE_NO_NO);
				createEReference(SourceEClass, SOURCE_ONE_MANY_NO_NO);
				createEReference(SourceEClass, SOURCE_MANY_MANY_NO_NO);
				createEReference(SourceEClass, SOURCE_ONE_MANY_NO_YES);
				createEReference(SourceEClass, SOURCE_ONE_ONE_NO_YES);
				TargetEClass = createEClass(TARGET);
				createEReference(TargetEClass, TARGET_ONE_ONE_NO_NO);
				createEReference(TargetEClass, TARGET_ONE_MANY_NO_NO);
				createEReference(TargetEClass, TARGET_MANY_MANY_NO_NO);
				createEReference(TargetEClass, TARGET_ONE_MANY_NO_YES);
				createEReference(TargetEClass, TARGET_ONE_ONE_NO_YES);
				
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
	
				
				
				
				
				SubInterface1EClass.eSuperTypes.add(getSuperInterface());
											
				
				SubInterface2EClass.eSuperTypes.add(getSuperAbstractClass());
											
				
				SubInterface3EClass.eSuperTypes.add(getSuperClass());
											
				
				SubAbstractClass1EClass.eSuperTypes.add(getSuperInterface());
											
				
				SubAbstractClass2EClass.eSuperTypes.add(getSuperAbstractClass());
											
				
				SubAbstractClass3EClass.eSuperTypes.add(getSuperClass());
											
				
				SubClass1EClass.eSuperTypes.add(getSuperInterface());
											
				
				SubClass2EClass.eSuperTypes.add(getSuperAbstractClass());
											
				
				SubClass3EClass.eSuperTypes.add(getSuperClass());
											
				
				SubInterface4EClass.eSuperTypes.add(getSubInterface1());
											
				SubInterface4EClass.eSuperTypes.add(getSubInterface2());
											
				
				SubInterface5EClass.eSuperTypes.add(getSubInterface1());
											
				SubInterface5EClass.eSuperTypes.add(getSubAbstractClass1());
											
				
				SubInterface6EClass.eSuperTypes.add(getSubInterface1());
											
				SubInterface6EClass.eSuperTypes.add(getSubClass1());
											
				
				SubInterface7EClass.eSuperTypes.add(getSubAbstractClass1());
											
				SubInterface7EClass.eSuperTypes.add(getSubClass1());
											
				
				SubAbstractClass4EClass.eSuperTypes.add(getSubInterface1());
											
				SubAbstractClass4EClass.eSuperTypes.add(getSubInterface2());
											
				
				SubAbstractClass5EClass.eSuperTypes.add(getSubInterface1());
											
				SubAbstractClass5EClass.eSuperTypes.add(getSubAbstractClass1());
											
				
				SubAbstractClass6EClass.eSuperTypes.add(getSubInterface1());
											
				SubAbstractClass6EClass.eSuperTypes.add(getSubClass1());
											
				
				SubAbstractClass7EClass.eSuperTypes.add(getSubAbstractClass1());
											
				SubAbstractClass7EClass.eSuperTypes.add(getSubClass1());
											
				
				SubClass4EClass.eSuperTypes.add(getSubInterface1());
											
				SubClass4EClass.eSuperTypes.add(getSubInterface2());
											
				
				SubClass5EClass.eSuperTypes.add(getSubInterface1());
											
				SubClass5EClass.eSuperTypes.add(getSubAbstractClass1());
											
				
				SubClass6EClass.eSuperTypes.add(getSubInterface1());
											
				SubClass6EClass.eSuperTypes.add(getSubClass1());
											
				
				SubClass7EClass.eSuperTypes.add(getSubAbstractClass1());
											
				SubClass7EClass.eSuperTypes.add(getSubClass1());
											
				
				
				BEClass.eSuperTypes.add(getA());
											
				
				CEClass.eSuperTypes.add(getB());
											
				
				
				
				initEClass(SuperInterfaceEClass, typeof(SuperInterface), "SuperInterface", IS_ABSTRACT, IS_INTERFACE, IS_GENERATED_INSTANCE_CLASS);						
				
				
				
				initEClass(SuperAbstractClassEClass, typeof(SuperAbstractClass), "SuperAbstractClass", IS_ABSTRACT, !IS_INTERFACE, IS_GENERATED_INSTANCE_CLASS);						
				
				
				
				initEClass(SuperClassEClass, typeof(SuperClass), "SuperClass", !IS_ABSTRACT, !IS_INTERFACE, IS_GENERATED_INSTANCE_CLASS);						
				
				
				
				initEClass(SubInterface1EClass, typeof(SubInterface1), "SubInterface1", IS_ABSTRACT, IS_INTERFACE, IS_GENERATED_INSTANCE_CLASS);						
				
				
				
				initEClass(SubInterface2EClass, typeof(SubInterface2), "SubInterface2", IS_ABSTRACT, IS_INTERFACE, IS_GENERATED_INSTANCE_CLASS);						
				
				
				
				initEClass(SubInterface3EClass, typeof(SubInterface3), "SubInterface3", IS_ABSTRACT, IS_INTERFACE, IS_GENERATED_INSTANCE_CLASS);						
				
				
				
				initEClass(SubAbstractClass1EClass, typeof(SubAbstractClass1), "SubAbstractClass1", IS_ABSTRACT, !IS_INTERFACE, IS_GENERATED_INSTANCE_CLASS);						
				
				
				
				initEClass(SubAbstractClass2EClass, typeof(SubAbstractClass2), "SubAbstractClass2", IS_ABSTRACT, !IS_INTERFACE, IS_GENERATED_INSTANCE_CLASS);						
				
				
				
				initEClass(SubAbstractClass3EClass, typeof(SubAbstractClass3), "SubAbstractClass3", IS_ABSTRACT, !IS_INTERFACE, IS_GENERATED_INSTANCE_CLASS);						
				
				
				
				initEClass(SubClass1EClass, typeof(SubClass1), "SubClass1", !IS_ABSTRACT, !IS_INTERFACE, IS_GENERATED_INSTANCE_CLASS);						
				
				
				
				initEClass(SubClass2EClass, typeof(SubClass2), "SubClass2", !IS_ABSTRACT, !IS_INTERFACE, IS_GENERATED_INSTANCE_CLASS);						
				
				
				
				initEClass(SubClass3EClass, typeof(SubClass3), "SubClass3", !IS_ABSTRACT, !IS_INTERFACE, IS_GENERATED_INSTANCE_CLASS);						
				
				
				
				initEClass(SubInterface4EClass, typeof(SubInterface4), "SubInterface4", IS_ABSTRACT, IS_INTERFACE, IS_GENERATED_INSTANCE_CLASS);						
				
				
				
				initEClass(SubInterface5EClass, typeof(SubInterface5), "SubInterface5", IS_ABSTRACT, IS_INTERFACE, IS_GENERATED_INSTANCE_CLASS);						
				
				
				
				initEClass(SubInterface6EClass, typeof(SubInterface6), "SubInterface6", IS_ABSTRACT, IS_INTERFACE, IS_GENERATED_INSTANCE_CLASS);						
				
				
				
				initEClass(SubInterface7EClass, typeof(SubInterface7), "SubInterface7", IS_ABSTRACT, IS_INTERFACE, IS_GENERATED_INSTANCE_CLASS);						
				
				
				
				initEClass(SubAbstractClass4EClass, typeof(SubAbstractClass4), "SubAbstractClass4", IS_ABSTRACT, !IS_INTERFACE, IS_GENERATED_INSTANCE_CLASS);						
				
				
				
				initEClass(SubAbstractClass5EClass, typeof(SubAbstractClass5), "SubAbstractClass5", IS_ABSTRACT, !IS_INTERFACE, IS_GENERATED_INSTANCE_CLASS);						
				
				
				
				initEClass(SubAbstractClass6EClass, typeof(SubAbstractClass6), "SubAbstractClass6", IS_ABSTRACT, !IS_INTERFACE, IS_GENERATED_INSTANCE_CLASS);						
				
				
				
				initEClass(SubAbstractClass7EClass, typeof(SubAbstractClass7), "SubAbstractClass7", IS_ABSTRACT, !IS_INTERFACE, IS_GENERATED_INSTANCE_CLASS);						
				
				
				
				initEClass(SubClass4EClass, typeof(SubClass4), "SubClass4", !IS_ABSTRACT, !IS_INTERFACE, IS_GENERATED_INSTANCE_CLASS);						
				
				
				
				initEClass(SubClass5EClass, typeof(SubClass5), "SubClass5", !IS_ABSTRACT, !IS_INTERFACE, IS_GENERATED_INSTANCE_CLASS);						
				
				
				
				initEClass(SubClass6EClass, typeof(SubClass6), "SubClass6", !IS_ABSTRACT, !IS_INTERFACE, IS_GENERATED_INSTANCE_CLASS);						
				
				
				
				initEClass(SubClass7EClass, typeof(SubClass7), "SubClass7", !IS_ABSTRACT, !IS_INTERFACE, IS_GENERATED_INSTANCE_CLASS);						
				
				
				
				initEClass(AEClass, typeof(A), "A", !IS_ABSTRACT, !IS_INTERFACE, IS_GENERATED_INSTANCE_CLASS);						
				
				initEAttribute(getA_A(), 
					ecorePackage.getEString(), 
					"a", 
					null, 
					0, 
					1, 
					typeof(EAttribute), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					!IS_UNSETTABLE, 
					!IS_ID, 
					IS_UNIQUE, 
					!IS_DERIVED, 
					IS_ORDERED);
				
				
				initEClass(BEClass, typeof(B), "B", !IS_ABSTRACT, !IS_INTERFACE, IS_GENERATED_INSTANCE_CLASS);						
				
				initEAttribute(getB_B(), 
					ecorePackage.getEString(), 
					"b", 
					null, 
					0, 
					1, 
					typeof(EAttribute), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					!IS_UNSETTABLE, 
					!IS_ID, 
					IS_UNIQUE, 
					!IS_DERIVED, 
					IS_ORDERED);
				
				
				initEClass(CEClass, typeof(C), "C", !IS_ABSTRACT, !IS_INTERFACE, IS_GENERATED_INSTANCE_CLASS);						
				
				initEAttribute(getC_C(), 
					ecorePackage.getEString(), 
					"c", 
					null, 
					0, 
					1, 
					typeof(EAttribute), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					!IS_UNSETTABLE, 
					!IS_ID, 
					IS_UNIQUE, 
					!IS_DERIVED, 
					IS_ORDERED);
				
				
				initEClass(SourceEClass, typeof(Source), "Source", !IS_ABSTRACT, !IS_INTERFACE, IS_GENERATED_INSTANCE_CLASS);						
				
				
				initEReference(
					getSource_Zero_one_no_no(), 
					this.getTarget(), 
					null, 
					"zero_one_no_no", 
					null, 
					0, 
					1, 
					typeof(Source), 
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
					getSource_Zero_many_no_no(), 
					this.getTarget(), 
					null, 
					"zero_many_no_no", 
					null, 
					0, 
					-1, 
					typeof(Source), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					!IS_COMPOSITE, 
					IS_RESOLVE_PROXIES, 
					!IS_UNSETTABLE, 
					IS_UNIQUE, 
					!IS_DERIVED, 
					!IS_ORDERED);
				initEReference(
					getSource_Zero_one_no_yes(), 
					this.getTarget(), 
					null, 
					"zero_one_no_yes", 
					null, 
					0, 
					1, 
					typeof(Source), 
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
					getSource_Zero_many_no_yes(), 
					this.getTarget(), 
					null, 
					"zero_many_no_yes", 
					null, 
					0, 
					-1, 
					typeof(Source), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					IS_COMPOSITE, 
					IS_RESOLVE_PROXIES, 
					!IS_UNSETTABLE, 
					IS_UNIQUE, 
					!IS_DERIVED, 
					!IS_ORDERED);
				initEReference(
					getSource_One_one_no_no(), 
					this.getTarget(), 
					getTarget_One_one_no_no(), 
					"one_one_no_no", 
					null, 
					0, 
					1, 
					typeof(Source), 
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
					getSource_One_many_no_no(), 
					this.getTarget(), 
					getTarget_One_many_no_no(), 
					"one_many_no_no", 
					null, 
					0, 
					-1, 
					typeof(Source), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					!IS_COMPOSITE, 
					IS_RESOLVE_PROXIES, 
					!IS_UNSETTABLE, 
					IS_UNIQUE, 
					!IS_DERIVED, 
					!IS_ORDERED);
				initEReference(
					getSource_Many_many_no_no(), 
					this.getTarget(), 
					getTarget_Many_many_no_no(), 
					"many_many_no_no", 
					null, 
					0, 
					-1, 
					typeof(Source), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					!IS_COMPOSITE, 
					IS_RESOLVE_PROXIES, 
					!IS_UNSETTABLE, 
					IS_UNIQUE, 
					!IS_DERIVED, 
					!IS_ORDERED);
				initEReference(
					getSource_One_many_no_yes(), 
					this.getTarget(), 
					getTarget_One_many_no_yes(), 
					"one_many_no_yes", 
					null, 
					0, 
					-1, 
					typeof(Source), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					IS_COMPOSITE, 
					IS_RESOLVE_PROXIES, 
					!IS_UNSETTABLE, 
					IS_UNIQUE, 
					!IS_DERIVED, 
					!IS_ORDERED);
				initEReference(
					getSource_One_one_no_yes(), 
					this.getTarget(), 
					getTarget_One_one_no_yes(), 
					"one_one_no_yes", 
					null, 
					0, 
					1, 
					typeof(Source), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					IS_COMPOSITE, 
					IS_RESOLVE_PROXIES, 
					!IS_UNSETTABLE, 
					IS_UNIQUE, 
					!IS_DERIVED, 
					IS_ORDERED);
				
				initEClass(TargetEClass, typeof(Target), "Target", !IS_ABSTRACT, !IS_INTERFACE, IS_GENERATED_INSTANCE_CLASS);						
				
				
				initEReference(
					getTarget_One_one_no_no(), 
					this.getSource(), 
					getSource_One_one_no_no(), 
					"one_one_no_no", 
					null, 
					0, 
					1, 
					typeof(Target), 
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
					getTarget_One_many_no_no(), 
					this.getSource(), 
					getSource_One_many_no_no(), 
					"one_many_no_no", 
					null, 
					0, 
					1, 
					typeof(Target), 
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
					getTarget_Many_many_no_no(), 
					this.getSource(), 
					getSource_Many_many_no_no(), 
					"many_many_no_no", 
					null, 
					0, 
					-1, 
					typeof(Target), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					!IS_COMPOSITE, 
					IS_RESOLVE_PROXIES, 
					!IS_UNSETTABLE, 
					IS_UNIQUE, 
					!IS_DERIVED, 
					!IS_ORDERED);
				initEReference(
					getTarget_One_many_no_yes(), 
					this.getSource(), 
					getSource_One_many_no_yes(), 
					"one_many_no_yes", 
					null, 
					0, 
					1, 
					typeof(Target), 
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
					getTarget_One_one_no_yes(), 
					this.getSource(), 
					getSource_One_one_no_yes(), 
					"one_one_no_yes", 
					null, 
					0, 
					1, 
					typeof(Target), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					!IS_COMPOSITE, 
					IS_RESOLVE_PROXIES, 
					!IS_UNSETTABLE, 
					IS_UNIQUE, 
					!IS_DERIVED, 
					IS_ORDERED);
				
	        }
	        
			
			private EClass SuperInterfaceEClass = null;
			private EClass SuperAbstractClassEClass = null;
			private EClass SuperClassEClass = null;
			private EClass SubInterface1EClass = null;
			private EClass SubInterface2EClass = null;
			private EClass SubInterface3EClass = null;
			private EClass SubAbstractClass1EClass = null;
			private EClass SubAbstractClass2EClass = null;
			private EClass SubAbstractClass3EClass = null;
			private EClass SubClass1EClass = null;
			private EClass SubClass2EClass = null;
			private EClass SubClass3EClass = null;
			private EClass SubInterface4EClass = null;
			private EClass SubInterface5EClass = null;
			private EClass SubInterface6EClass = null;
			private EClass SubInterface7EClass = null;
			private EClass SubAbstractClass4EClass = null;
			private EClass SubAbstractClass5EClass = null;
			private EClass SubAbstractClass6EClass = null;
			private EClass SubAbstractClass7EClass = null;
			private EClass SubClass4EClass = null;
			private EClass SubClass5EClass = null;
			private EClass SubClass6EClass = null;
			private EClass SubClass7EClass = null;
			private EClass AEClass = null;
			private EClass BEClass = null;
			private EClass CEClass = null;
			private EClass SourceEClass = null;
			private EClass TargetEClass = null;
			
			
			
			
			
			public const int SUPERINTERFACE = 0;
			public const int SUPERINTERFACE_FEATURE_COUNT = 0;
			public const int SUPERINTERFACE_OPERATION_COUNT = 0;
			
			
			public const int SUPERABSTRACTCLASS = 1;
			public const int SUPERABSTRACTCLASS_FEATURE_COUNT = 0;
			public const int SUPERABSTRACTCLASS_OPERATION_COUNT = 0;
			
			
			public const int SUPERCLASS = 2;
			public const int SUPERCLASS_FEATURE_COUNT = 0;
			public const int SUPERCLASS_OPERATION_COUNT = 0;
			
			
			public const int A = 24;
			public const int A_FEATURE_COUNT = 1;
			public const int A_OPERATION_COUNT = 1;
			
			public const int A_A = 0;
			
			public const int SOURCE = 27;
			public const int SOURCE_FEATURE_COUNT = 9;
			public const int SOURCE_OPERATION_COUNT = 0;
			
			public const int SOURCE_ZERO_ONE_NO_NO = 0;
			public const int SOURCE_ZERO_MANY_NO_NO = 1;
			public const int SOURCE_ZERO_ONE_NO_YES = 2;
			public const int SOURCE_ZERO_MANY_NO_YES = 3;
			public const int SOURCE_ONE_ONE_NO_NO = 4;
			public const int SOURCE_ONE_MANY_NO_NO = 5;
			public const int SOURCE_MANY_MANY_NO_NO = 6;
			public const int SOURCE_ONE_MANY_NO_YES = 7;
			public const int SOURCE_ONE_ONE_NO_YES = 8;
			
			public const int TARGET = 28;
			public const int TARGET_FEATURE_COUNT = 5;
			public const int TARGET_OPERATION_COUNT = 0;
			
			public const int TARGET_ONE_ONE_NO_NO = 0;
			public const int TARGET_ONE_MANY_NO_NO = 1;
			public const int TARGET_MANY_MANY_NO_NO = 2;
			public const int TARGET_ONE_MANY_NO_YES = 3;
			public const int TARGET_ONE_ONE_NO_YES = 4;
			
			public const int SUBINTERFACE1 = 3;
			public const int SUBINTERFACE1_FEATURE_COUNT = SUPERINTERFACE_FEATURE_COUNT + 0;
			public const int SUBINTERFACE1_OPERATION_COUNT = SUPERINTERFACE_OPERATION_COUNT + 0;
			
			
			public const int SUBABSTRACTCLASS1 = 6;
			public const int SUBABSTRACTCLASS1_FEATURE_COUNT = SUPERINTERFACE_FEATURE_COUNT + 0;
			public const int SUBABSTRACTCLASS1_OPERATION_COUNT = SUPERINTERFACE_OPERATION_COUNT + 0;
			
			
			public const int SUBCLASS1 = 9;
			public const int SUBCLASS1_FEATURE_COUNT = SUPERINTERFACE_FEATURE_COUNT + 0;
			public const int SUBCLASS1_OPERATION_COUNT = SUPERINTERFACE_OPERATION_COUNT + 0;
			
			
			public const int SUBINTERFACE2 = 4;
			public const int SUBINTERFACE2_FEATURE_COUNT = SUPERABSTRACTCLASS_FEATURE_COUNT + 0;
			public const int SUBINTERFACE2_OPERATION_COUNT = SUPERABSTRACTCLASS_OPERATION_COUNT + 0;
			
			
			public const int SUBABSTRACTCLASS2 = 7;
			public const int SUBABSTRACTCLASS2_FEATURE_COUNT = SUPERABSTRACTCLASS_FEATURE_COUNT + 0;
			public const int SUBABSTRACTCLASS2_OPERATION_COUNT = SUPERABSTRACTCLASS_OPERATION_COUNT + 0;
			
			
			public const int SUBCLASS2 = 10;
			public const int SUBCLASS2_FEATURE_COUNT = SUPERABSTRACTCLASS_FEATURE_COUNT + 0;
			public const int SUBCLASS2_OPERATION_COUNT = SUPERABSTRACTCLASS_OPERATION_COUNT + 0;
			
			
			public const int SUBINTERFACE3 = 5;
			public const int SUBINTERFACE3_FEATURE_COUNT = SUPERCLASS_FEATURE_COUNT + 0;
			public const int SUBINTERFACE3_OPERATION_COUNT = SUPERCLASS_OPERATION_COUNT + 0;
			
			
			public const int SUBABSTRACTCLASS3 = 8;
			public const int SUBABSTRACTCLASS3_FEATURE_COUNT = SUPERCLASS_FEATURE_COUNT + 0;
			public const int SUBABSTRACTCLASS3_OPERATION_COUNT = SUPERCLASS_OPERATION_COUNT + 0;
			
			
			public const int SUBCLASS3 = 11;
			public const int SUBCLASS3_FEATURE_COUNT = SUPERCLASS_FEATURE_COUNT + 0;
			public const int SUBCLASS3_OPERATION_COUNT = SUPERCLASS_OPERATION_COUNT + 0;
			
			
			public const int B = 25;
			public const int B_FEATURE_COUNT = A_FEATURE_COUNT + 1;
			public const int B_OPERATION_COUNT = A_OPERATION_COUNT + 1;
			
			public const int B_A = 0;
			public const int B_B = 1;
			
			public const int SUBINTERFACE4 = 12;
			public const int SUBINTERFACE4_FEATURE_COUNT = SUBINTERFACE1_FEATURE_COUNT + SUBINTERFACE2_FEATURE_COUNT + 0;
			public const int SUBINTERFACE4_OPERATION_COUNT = SUBINTERFACE1_OPERATION_COUNT + SUBINTERFACE2_OPERATION_COUNT + 0;
			
			
			public const int SUBINTERFACE5 = 13;
			public const int SUBINTERFACE5_FEATURE_COUNT = SUBINTERFACE1_FEATURE_COUNT + SUBABSTRACTCLASS1_FEATURE_COUNT + 0;
			public const int SUBINTERFACE5_OPERATION_COUNT = SUBINTERFACE1_OPERATION_COUNT + SUBABSTRACTCLASS1_OPERATION_COUNT + 0;
			
			
			public const int SUBINTERFACE6 = 14;
			public const int SUBINTERFACE6_FEATURE_COUNT = SUBINTERFACE1_FEATURE_COUNT + SUBCLASS1_FEATURE_COUNT + 0;
			public const int SUBINTERFACE6_OPERATION_COUNT = SUBINTERFACE1_OPERATION_COUNT + SUBCLASS1_OPERATION_COUNT + 0;
			
			
			public const int SUBABSTRACTCLASS4 = 16;
			public const int SUBABSTRACTCLASS4_FEATURE_COUNT = SUBINTERFACE1_FEATURE_COUNT + SUBINTERFACE2_FEATURE_COUNT + 0;
			public const int SUBABSTRACTCLASS4_OPERATION_COUNT = SUBINTERFACE1_OPERATION_COUNT + SUBINTERFACE2_OPERATION_COUNT + 0;
			
			
			public const int SUBABSTRACTCLASS5 = 17;
			public const int SUBABSTRACTCLASS5_FEATURE_COUNT = SUBINTERFACE1_FEATURE_COUNT + SUBABSTRACTCLASS1_FEATURE_COUNT + 0;
			public const int SUBABSTRACTCLASS5_OPERATION_COUNT = SUBINTERFACE1_OPERATION_COUNT + SUBABSTRACTCLASS1_OPERATION_COUNT + 0;
			
			
			public const int SUBABSTRACTCLASS6 = 18;
			public const int SUBABSTRACTCLASS6_FEATURE_COUNT = SUBINTERFACE1_FEATURE_COUNT + SUBCLASS1_FEATURE_COUNT + 0;
			public const int SUBABSTRACTCLASS6_OPERATION_COUNT = SUBINTERFACE1_OPERATION_COUNT + SUBCLASS1_OPERATION_COUNT + 0;
			
			
			public const int SUBCLASS4 = 20;
			public const int SUBCLASS4_FEATURE_COUNT = SUBINTERFACE1_FEATURE_COUNT + SUBINTERFACE2_FEATURE_COUNT + 0;
			public const int SUBCLASS4_OPERATION_COUNT = SUBINTERFACE1_OPERATION_COUNT + SUBINTERFACE2_OPERATION_COUNT + 0;
			
			
			public const int SUBCLASS5 = 21;
			public const int SUBCLASS5_FEATURE_COUNT = SUBINTERFACE1_FEATURE_COUNT + SUBABSTRACTCLASS1_FEATURE_COUNT + 0;
			public const int SUBCLASS5_OPERATION_COUNT = SUBINTERFACE1_OPERATION_COUNT + SUBABSTRACTCLASS1_OPERATION_COUNT + 0;
			
			
			public const int SUBCLASS6 = 22;
			public const int SUBCLASS6_FEATURE_COUNT = SUBINTERFACE1_FEATURE_COUNT + SUBCLASS1_FEATURE_COUNT + 0;
			public const int SUBCLASS6_OPERATION_COUNT = SUBINTERFACE1_OPERATION_COUNT + SUBCLASS1_OPERATION_COUNT + 0;
			
			
			public const int SUBINTERFACE7 = 15;
			public const int SUBINTERFACE7_FEATURE_COUNT = SUBABSTRACTCLASS1_FEATURE_COUNT + SUBCLASS1_FEATURE_COUNT + 0;
			public const int SUBINTERFACE7_OPERATION_COUNT = SUBABSTRACTCLASS1_OPERATION_COUNT + SUBCLASS1_OPERATION_COUNT + 0;
			
			
			public const int SUBABSTRACTCLASS7 = 19;
			public const int SUBABSTRACTCLASS7_FEATURE_COUNT = SUBABSTRACTCLASS1_FEATURE_COUNT + SUBCLASS1_FEATURE_COUNT + 0;
			public const int SUBABSTRACTCLASS7_OPERATION_COUNT = SUBABSTRACTCLASS1_OPERATION_COUNT + SUBCLASS1_OPERATION_COUNT + 0;
			
			
			public const int SUBCLASS7 = 23;
			public const int SUBCLASS7_FEATURE_COUNT = SUBABSTRACTCLASS1_FEATURE_COUNT + SUBCLASS1_FEATURE_COUNT + 0;
			public const int SUBCLASS7_OPERATION_COUNT = SUBABSTRACTCLASS1_OPERATION_COUNT + SUBCLASS1_OPERATION_COUNT + 0;
			
			
			public const int C = 26;
			public const int C_FEATURE_COUNT = B_FEATURE_COUNT + 1;
			public const int C_OPERATION_COUNT = B_OPERATION_COUNT + 2;
			
			public const int C_A = 0;
			public const int C_B = 1;
			public const int C_C = 2;
			
			
			
			public EClass getSuperInterface(){return SuperInterfaceEClass;}
			
			public EClass getSuperAbstractClass(){return SuperAbstractClassEClass;}
			
			public EClass getSuperClass(){return SuperClassEClass;}
			
			public EClass getA(){return AEClass;}
			
			public EAttribute getA_A(){return (EAttribute)AEClass.eStructuralFeatures.at(0);}
			public EClass getSource(){return SourceEClass;}
			
			public EReference getSource_Zero_one_no_no(){return (EReference)SourceEClass.eStructuralFeatures.at(0);}
			public EReference getSource_Zero_many_no_no(){return (EReference)SourceEClass.eStructuralFeatures.at(1);}
			public EReference getSource_Zero_one_no_yes(){return (EReference)SourceEClass.eStructuralFeatures.at(2);}
			public EReference getSource_Zero_many_no_yes(){return (EReference)SourceEClass.eStructuralFeatures.at(3);}
			public EReference getSource_One_one_no_no(){return (EReference)SourceEClass.eStructuralFeatures.at(4);}
			public EReference getSource_One_many_no_no(){return (EReference)SourceEClass.eStructuralFeatures.at(5);}
			public EReference getSource_Many_many_no_no(){return (EReference)SourceEClass.eStructuralFeatures.at(6);}
			public EReference getSource_One_many_no_yes(){return (EReference)SourceEClass.eStructuralFeatures.at(7);}
			public EReference getSource_One_one_no_yes(){return (EReference)SourceEClass.eStructuralFeatures.at(8);}
			public EClass getTarget(){return TargetEClass;}
			
			public EReference getTarget_One_one_no_no(){return (EReference)TargetEClass.eStructuralFeatures.at(0);}
			public EReference getTarget_One_many_no_no(){return (EReference)TargetEClass.eStructuralFeatures.at(1);}
			public EReference getTarget_Many_many_no_no(){return (EReference)TargetEClass.eStructuralFeatures.at(2);}
			public EReference getTarget_One_many_no_yes(){return (EReference)TargetEClass.eStructuralFeatures.at(3);}
			public EReference getTarget_One_one_no_yes(){return (EReference)TargetEClass.eStructuralFeatures.at(4);}
			public EClass getSubInterface1(){return SubInterface1EClass;}
			
			public EClass getSubAbstractClass1(){return SubAbstractClass1EClass;}
			
			public EClass getSubClass1(){return SubClass1EClass;}
			
			public EClass getSubInterface2(){return SubInterface2EClass;}
			
			public EClass getSubAbstractClass2(){return SubAbstractClass2EClass;}
			
			public EClass getSubClass2(){return SubClass2EClass;}
			
			public EClass getSubInterface3(){return SubInterface3EClass;}
			
			public EClass getSubAbstractClass3(){return SubAbstractClass3EClass;}
			
			public EClass getSubClass3(){return SubClass3EClass;}
			
			public EClass getB(){return BEClass;}
			
			public EAttribute getB_B(){return (EAttribute)BEClass.eStructuralFeatures.at(0);}
			public EClass getSubInterface4(){return SubInterface4EClass;}
			
			public EClass getSubInterface5(){return SubInterface5EClass;}
			
			public EClass getSubInterface6(){return SubInterface6EClass;}
			
			public EClass getSubAbstractClass4(){return SubAbstractClass4EClass;}
			
			public EClass getSubAbstractClass5(){return SubAbstractClass5EClass;}
			
			public EClass getSubAbstractClass6(){return SubAbstractClass6EClass;}
			
			public EClass getSubClass4(){return SubClass4EClass;}
			
			public EClass getSubClass5(){return SubClass5EClass;}
			
			public EClass getSubClass6(){return SubClass6EClass;}
			
			public EClass getSubInterface7(){return SubInterface7EClass;}
			
			public EClass getSubAbstractClass7(){return SubAbstractClass7EClass;}
			
			public EClass getSubClass7(){return SubClass7EClass;}
			
			public EClass getC(){return CEClass;}
			
			public EAttribute getC_C(){return (EAttribute)CEClass.eStructuralFeatures.at(0);}
			
			public class Literals{
				public static EClass SUPERINTERFACE = TestmodelPackageImpl.eINSTANCE.getSuperInterface();
				
				
				public static EClass SUPERABSTRACTCLASS = TestmodelPackageImpl.eINSTANCE.getSuperAbstractClass();
				
				
				public static EClass SUPERCLASS = TestmodelPackageImpl.eINSTANCE.getSuperClass();
				
				
				public static EClass A = TestmodelPackageImpl.eINSTANCE.getA();
				
				
				public static EAttribute A_A = TestmodelPackageImpl.eINSTANCE.getA_A();
				public static EClass SOURCE = TestmodelPackageImpl.eINSTANCE.getSource();
				
				public static EReference SOURCE_ZERO_ONE_NO_NO = TestmodelPackageImpl.eINSTANCE.getSource_Zero_one_no_no();
				public static EReference SOURCE_ZERO_MANY_NO_NO = TestmodelPackageImpl.eINSTANCE.getSource_Zero_many_no_no();
				public static EReference SOURCE_ZERO_ONE_NO_YES = TestmodelPackageImpl.eINSTANCE.getSource_Zero_one_no_yes();
				public static EReference SOURCE_ZERO_MANY_NO_YES = TestmodelPackageImpl.eINSTANCE.getSource_Zero_many_no_yes();
				public static EReference SOURCE_ONE_ONE_NO_NO = TestmodelPackageImpl.eINSTANCE.getSource_One_one_no_no();
				public static EReference SOURCE_ONE_MANY_NO_NO = TestmodelPackageImpl.eINSTANCE.getSource_One_many_no_no();
				public static EReference SOURCE_MANY_MANY_NO_NO = TestmodelPackageImpl.eINSTANCE.getSource_Many_many_no_no();
				public static EReference SOURCE_ONE_MANY_NO_YES = TestmodelPackageImpl.eINSTANCE.getSource_One_many_no_yes();
				public static EReference SOURCE_ONE_ONE_NO_YES = TestmodelPackageImpl.eINSTANCE.getSource_One_one_no_yes();
				
				public static EClass TARGET = TestmodelPackageImpl.eINSTANCE.getTarget();
				
				public static EReference TARGET_ONE_ONE_NO_NO = TestmodelPackageImpl.eINSTANCE.getTarget_One_one_no_no();
				public static EReference TARGET_ONE_MANY_NO_NO = TestmodelPackageImpl.eINSTANCE.getTarget_One_many_no_no();
				public static EReference TARGET_MANY_MANY_NO_NO = TestmodelPackageImpl.eINSTANCE.getTarget_Many_many_no_no();
				public static EReference TARGET_ONE_MANY_NO_YES = TestmodelPackageImpl.eINSTANCE.getTarget_One_many_no_yes();
				public static EReference TARGET_ONE_ONE_NO_YES = TestmodelPackageImpl.eINSTANCE.getTarget_One_one_no_yes();
				
				public static EClass SUBINTERFACE1 = TestmodelPackageImpl.eINSTANCE.getSubInterface1();
				
				
				public static EClass SUBABSTRACTCLASS1 = TestmodelPackageImpl.eINSTANCE.getSubAbstractClass1();
				
				
				public static EClass SUBCLASS1 = TestmodelPackageImpl.eINSTANCE.getSubClass1();
				
				
				public static EClass SUBINTERFACE2 = TestmodelPackageImpl.eINSTANCE.getSubInterface2();
				
				
				public static EClass SUBABSTRACTCLASS2 = TestmodelPackageImpl.eINSTANCE.getSubAbstractClass2();
				
				
				public static EClass SUBCLASS2 = TestmodelPackageImpl.eINSTANCE.getSubClass2();
				
				
				public static EClass SUBINTERFACE3 = TestmodelPackageImpl.eINSTANCE.getSubInterface3();
				
				
				public static EClass SUBABSTRACTCLASS3 = TestmodelPackageImpl.eINSTANCE.getSubAbstractClass3();
				
				
				public static EClass SUBCLASS3 = TestmodelPackageImpl.eINSTANCE.getSubClass3();
				
				
				public static EClass B = TestmodelPackageImpl.eINSTANCE.getB();
				
				
				public static EAttribute B_B = TestmodelPackageImpl.eINSTANCE.getB_B();
				public static EClass SUBINTERFACE4 = TestmodelPackageImpl.eINSTANCE.getSubInterface4();
				
				
				public static EClass SUBINTERFACE5 = TestmodelPackageImpl.eINSTANCE.getSubInterface5();
				
				
				public static EClass SUBINTERFACE6 = TestmodelPackageImpl.eINSTANCE.getSubInterface6();
				
				
				public static EClass SUBABSTRACTCLASS4 = TestmodelPackageImpl.eINSTANCE.getSubAbstractClass4();
				
				
				public static EClass SUBABSTRACTCLASS5 = TestmodelPackageImpl.eINSTANCE.getSubAbstractClass5();
				
				
				public static EClass SUBABSTRACTCLASS6 = TestmodelPackageImpl.eINSTANCE.getSubAbstractClass6();
				
				
				public static EClass SUBCLASS4 = TestmodelPackageImpl.eINSTANCE.getSubClass4();
				
				
				public static EClass SUBCLASS5 = TestmodelPackageImpl.eINSTANCE.getSubClass5();
				
				
				public static EClass SUBCLASS6 = TestmodelPackageImpl.eINSTANCE.getSubClass6();
				
				
				public static EClass SUBINTERFACE7 = TestmodelPackageImpl.eINSTANCE.getSubInterface7();
				
				
				public static EClass SUBABSTRACTCLASS7 = TestmodelPackageImpl.eINSTANCE.getSubAbstractClass7();
				
				
				public static EClass SUBCLASS7 = TestmodelPackageImpl.eINSTANCE.getSubClass7();
				
				
				public static EClass C = TestmodelPackageImpl.eINSTANCE.getC();
				
				
				public static EAttribute C_C = TestmodelPackageImpl.eINSTANCE.getC_C();
			}
	 
	}
}
