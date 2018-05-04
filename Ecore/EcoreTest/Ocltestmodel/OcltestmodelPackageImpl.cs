	 	using Ecore;
namespace Ocltestmodel{
	public class OcltestmodelPackageImpl : EPackageImpl, OcltestmodelPackage{
			public const string eNAME = "ocltestmodel";
			
			public const string eNS_URI = "http://www.example.org/OclTestmodel";
			
			public const string eNS_PREFIX = "ocltestmodel";
			
			public static OcltestmodelPackage eINSTANCE = init();
			
			private OcltestmodelPackageImpl():base(eNS_URI, OcltestmodelFactoryImpl.eINSTANCE)
			{
				
			}
			
            public static OcltestmodelPackage init()
            {
                // Obtain or create and register package
                var theOcltestmodelPackage = new OcltestmodelPackageImpl();

                // Create package meta-data objects
                theOcltestmodelPackage.createPackageContents();

                // Initialize created meta-data
                theOcltestmodelPackage.initializePackageContents();

		        return theOcltestmodelPackage;
	        }
	        
	        private bool isCreated = false;
            public void createPackageContents()
            {
                if (isCreated) return;
                isCreated = true;
				MyClassEClass = createEClass(MYCLASS);
				createEAttribute(MyClassEClass, MYCLASS_STATIC_SEQUENCE);
				createEAttribute(MyClassEClass, MYCLASS_COLLECTION_LITERALS);
				createEAttribute(MyClassEClass, MYCLASS_BOOLEAN_UNEQUAL);
				createEAttribute(MyClassEClass, MYCLASS_BOOLEAN_EQUAL);
				createEAttribute(MyClassEClass, MYCLASS_BOOLEAN_AND);
				createEAttribute(MyClassEClass, MYCLASS_BOOLEAN_IMPLIES);
				createEAttribute(MyClassEClass, MYCLASS_BOOLEAN_NOT);
				createEAttribute(MyClassEClass, MYCLASS_BOOLEAN_OR);
				createEAttribute(MyClassEClass, MYCLASS_BOOLEAN_XOR);
				createEAttribute(MyClassEClass, MYCLASS_BOOLEAN_TOSTRING);
				createEAttribute(MyClassEClass, MYCLASS_INTEGER_MULTIPLICATION);
				createEAttribute(MyClassEClass, MYCLASS_INTEGER_ADDITION);
				createEAttribute(MyClassEClass, MYCLASS_INTEGER_SUBTRACTION);
				createEAttribute(MyClassEClass, MYCLASS_INTEGER_LESSTHAN);
				createEAttribute(MyClassEClass, MYCLASS_INTEGER_GREATERTHAN);
				createEAttribute(MyClassEClass, MYCLASS_INTEGER_GREATEREQUALS);
				createEAttribute(MyClassEClass, MYCLASS_INTEGER_LESSEQUALS);
				createEAttribute(MyClassEClass, MYCLASS_INTEGER_DIVISION);
				createEAttribute(MyClassEClass, MYCLASS_INTEGER_ABSOLUTE);
				createEAttribute(MyClassEClass, MYCLASS_INTEGER_MAXIMUM);
				createEAttribute(MyClassEClass, MYCLASS_INTEGER_MINIMUM);
				createEAttribute(MyClassEClass, MYCLASS_INTEGER_MODULO);
				createEAttribute(MyClassEClass, MYCLASS_INTEGER_TOSTRING);
				createEAttribute(MyClassEClass, MYCLASS_REAL_MULTIPLICATION);
				createEAttribute(MyClassEClass, MYCLASS_REAL_ADDITION);
				createEAttribute(MyClassEClass, MYCLASS_REAL_SUBTRACTION);
				createEAttribute(MyClassEClass, MYCLASS_REAL_LESSTHAN);
				createEAttribute(MyClassEClass, MYCLASS_REAL_GREATERTHAN);
				createEAttribute(MyClassEClass, MYCLASS_REAL_GREATEREQUALS);
				createEAttribute(MyClassEClass, MYCLASS_REAL_LESSEQUALS);
				createEAttribute(MyClassEClass, MYCLASS_REAL_DIVISION);
				createEAttribute(MyClassEClass, MYCLASS_REAL_ABSOLUTE);
				createEAttribute(MyClassEClass, MYCLASS_REAL_MAXIMUM);
				createEAttribute(MyClassEClass, MYCLASS_REAL_MINIMUM);
				createEAttribute(MyClassEClass, MYCLASS_REAL_FLOOR);
				createEAttribute(MyClassEClass, MYCLASS_REAL_TOSTRING);
				createEAttribute(MyClassEClass, MYCLASS_STRING_ADDITION);
				createEAttribute(MyClassEClass, MYCLASS_STRING_LESSTHAN);
				createEAttribute(MyClassEClass, MYCLASS_STRING_LESSEQUALS);
				createEAttribute(MyClassEClass, MYCLASS_STRING_UNEQUAL);
				createEAttribute(MyClassEClass, MYCLASS_STRING_EQUAL);
				createEAttribute(MyClassEClass, MYCLASS_STRING_GREATERTHAN);
				createEAttribute(MyClassEClass, MYCLASS_STRING_GREATEREQUALS);
				createEAttribute(MyClassEClass, MYCLASS_STRING_AT);
				createEAttribute(MyClassEClass, MYCLASS_STRING_COMPARETO);
				createEAttribute(MyClassEClass, MYCLASS_STRING_CONCAT);
				createEAttribute(MyClassEClass, MYCLASS_STRING_EQUALSIGNORECASE);
				createEAttribute(MyClassEClass, MYCLASS_STRING_INDEXOF);
				createEAttribute(MyClassEClass, MYCLASS_STRING_LASTINDEXOF);
				createEAttribute(MyClassEClass, MYCLASS_STRING_REPLACEALL);
				createEAttribute(MyClassEClass, MYCLASS_STRING_SIZE);
				createEAttribute(MyClassEClass, MYCLASS_LET2);
				createEAttribute(MyClassEClass, MYCLASS_LET3);
				createEAttribute(MyClassEClass, MYCLASS_UNEMPLOYED);
				createEAttribute(MyClassEClass, MYCLASS_LET);
				createEReference(MyClassEClass, MYCLASS_ORDEREDSET);
				createEReference(MyClassEClass, MYCLASS_SET);
				createEReference(MyClassEClass, MYCLASS_SEQUENCE);
				createEAttribute(MyClassEClass, MYCLASS_INTEGER_SEQUENCE);
				createEReference(MyClassEClass, MYCLASS_BAG);
				createEAttribute(MyClassEClass, MYCLASS_SEQUENCE_SELECTBYKIND);
				createEAttribute(MyClassEClass, MYCLASS_SEQUENCE_SELECTBYTYPE);
				createEAttribute(MyClassEClass, MYCLASS_TUPLE_LITERAL);
				createEReference(MyClassEClass, MYCLASS_ORDEREDSET_SELECT);
				createEAttribute(MyClassEClass, MYCLASS_ORDEREDSET_SIZE);
				createEAttribute(MyClassEClass, MYCLASS_SEQUENCE_COUNT);
				createEReference(MyClassEClass, MYCLASS_ORDEREDSET_AT);
				createEReference(MyClassEClass, MYCLASS__SELFEXP);
				createEAttribute(MyClassEClass, MYCLASS__INTEGERLITERALEXP);
				createEAttribute(MyClassEClass, MYCLASS__INFIXEXP_NOT_PASSING_DUE_TO_BUG_IN_OCLHELPER);
				createEAttribute(MyClassEClass, MYCLASS__STRINGLITERALEXP);
				createEAttribute(MyClassEClass, MYCLASS__BOOLEANLITERALEXP);
				createEAttribute(MyClassEClass, MYCLASS__REALLITERALEXP);
				createEAttribute(MyClassEClass, MYCLASS__NUMBERLITERALEXP);
				createEReference(MyClassEClass, MYCLASS__NULLEXP);
				createEAttribute(MyClassEClass, MYCLASS__IFEXP);
				
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
				
				initEAttribute(getMyClass_Static_sequence(), 
					ecorePackage.getEBigInteger(), 
					"static_sequence", 
					null, 
					0, 
					-1, 
					typeof(EAttribute), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					!IS_UNSETTABLE, 
					!IS_ID, 
					!IS_UNIQUE, 
					IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getMyClass_Collection_literals(), 
					ecorePackage.getEBigInteger(), 
					"collection_literals", 
					null, 
					0, 
					-1, 
					typeof(EAttribute), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					!IS_UNSETTABLE, 
					!IS_ID, 
					!IS_UNIQUE, 
					IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getMyClass_Boolean_unequal(), 
					ecorePackage.getEBoolean(), 
					"boolean_unequal", 
					"false", 
					0, 
					1, 
					typeof(EAttribute), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					!IS_UNSETTABLE, 
					!IS_ID, 
					IS_UNIQUE, 
					IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getMyClass_Boolean_equal(), 
					ecorePackage.getEBoolean(), 
					"boolean_equal", 
					"false", 
					0, 
					1, 
					typeof(EAttribute), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					!IS_UNSETTABLE, 
					!IS_ID, 
					IS_UNIQUE, 
					IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getMyClass_Boolean_and(), 
					ecorePackage.getEBoolean(), 
					"boolean_and", 
					"false", 
					0, 
					1, 
					typeof(EAttribute), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					!IS_UNSETTABLE, 
					!IS_ID, 
					IS_UNIQUE, 
					IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getMyClass_Boolean_implies(), 
					ecorePackage.getEBoolean(), 
					"boolean_implies", 
					"false", 
					0, 
					1, 
					typeof(EAttribute), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					!IS_UNSETTABLE, 
					!IS_ID, 
					IS_UNIQUE, 
					IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getMyClass_Boolean_not(), 
					ecorePackage.getEBoolean(), 
					"boolean_not", 
					"false", 
					0, 
					1, 
					typeof(EAttribute), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					!IS_UNSETTABLE, 
					!IS_ID, 
					IS_UNIQUE, 
					IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getMyClass_Boolean_or(), 
					ecorePackage.getEBoolean(), 
					"boolean_or", 
					"false", 
					0, 
					1, 
					typeof(EAttribute), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					!IS_UNSETTABLE, 
					!IS_ID, 
					IS_UNIQUE, 
					IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getMyClass_Boolean_xor(), 
					ecorePackage.getEBoolean(), 
					"boolean_xor", 
					"false", 
					0, 
					1, 
					typeof(EAttribute), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					!IS_UNSETTABLE, 
					!IS_ID, 
					IS_UNIQUE, 
					IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getMyClass_Boolean_toString(), 
					ecorePackage.getEString(), 
					"boolean_toString", 
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
					IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getMyClass_Integer_multiplication(), 
					ecorePackage.getEInt(), 
					"integer_multiplication", 
					"0", 
					0, 
					1, 
					typeof(EAttribute), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					!IS_UNSETTABLE, 
					!IS_ID, 
					IS_UNIQUE, 
					IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getMyClass_Integer_addition(), 
					ecorePackage.getEInt(), 
					"integer_addition", 
					"0", 
					0, 
					1, 
					typeof(EAttribute), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					!IS_UNSETTABLE, 
					!IS_ID, 
					IS_UNIQUE, 
					IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getMyClass_Integer_subtraction(), 
					ecorePackage.getEInt(), 
					"integer_subtraction", 
					"0", 
					0, 
					1, 
					typeof(EAttribute), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					!IS_UNSETTABLE, 
					!IS_ID, 
					IS_UNIQUE, 
					IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getMyClass_Integer_lessthan(), 
					ecorePackage.getEBoolean(), 
					"integer_lessthan", 
					"false", 
					0, 
					1, 
					typeof(EAttribute), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					!IS_UNSETTABLE, 
					!IS_ID, 
					IS_UNIQUE, 
					IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getMyClass_Integer_greaterthan(), 
					ecorePackage.getEBoolean(), 
					"integer_greaterthan", 
					"false", 
					0, 
					1, 
					typeof(EAttribute), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					!IS_UNSETTABLE, 
					!IS_ID, 
					IS_UNIQUE, 
					IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getMyClass_Integer_greaterequals(), 
					ecorePackage.getEBoolean(), 
					"integer_greaterequals", 
					"false", 
					0, 
					1, 
					typeof(EAttribute), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					!IS_UNSETTABLE, 
					!IS_ID, 
					IS_UNIQUE, 
					IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getMyClass_Integer_lessequals(), 
					ecorePackage.getEBoolean(), 
					"integer_lessequals", 
					"false", 
					0, 
					1, 
					typeof(EAttribute), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					!IS_UNSETTABLE, 
					!IS_ID, 
					IS_UNIQUE, 
					IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getMyClass_Integer_division(), 
					ecorePackage.getEDouble(), 
					"integer_division", 
					"0.0", 
					0, 
					1, 
					typeof(EAttribute), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					!IS_UNSETTABLE, 
					!IS_ID, 
					IS_UNIQUE, 
					IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getMyClass_Integer_absolute(), 
					ecorePackage.getEInt(), 
					"integer_absolute", 
					"0", 
					0, 
					1, 
					typeof(EAttribute), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					!IS_UNSETTABLE, 
					!IS_ID, 
					IS_UNIQUE, 
					IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getMyClass_Integer_maximum(), 
					ecorePackage.getEInt(), 
					"integer_maximum", 
					"0", 
					0, 
					1, 
					typeof(EAttribute), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					!IS_UNSETTABLE, 
					!IS_ID, 
					IS_UNIQUE, 
					IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getMyClass_Integer_minimum(), 
					ecorePackage.getEInt(), 
					"integer_minimum", 
					"0", 
					0, 
					1, 
					typeof(EAttribute), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					!IS_UNSETTABLE, 
					!IS_ID, 
					IS_UNIQUE, 
					IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getMyClass_Integer_modulo(), 
					ecorePackage.getEInt(), 
					"integer_modulo", 
					"0", 
					0, 
					1, 
					typeof(EAttribute), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					!IS_UNSETTABLE, 
					!IS_ID, 
					IS_UNIQUE, 
					IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getMyClass_Integer_toString(), 
					ecorePackage.getEString(), 
					"integer_toString", 
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
					IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getMyClass_Real_multiplication(), 
					ecorePackage.getEBigDecimal(), 
					"real_multiplication", 
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
					IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getMyClass_Real_addition(), 
					ecorePackage.getEBigDecimal(), 
					"real_addition", 
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
					IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getMyClass_Real_subtraction(), 
					ecorePackage.getEBigDecimal(), 
					"real_subtraction", 
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
					IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getMyClass_Real_lessthan(), 
					ecorePackage.getEBoolean(), 
					"real_lessthan", 
					"false", 
					0, 
					1, 
					typeof(EAttribute), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					!IS_UNSETTABLE, 
					!IS_ID, 
					IS_UNIQUE, 
					IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getMyClass_Real_greaterthan(), 
					ecorePackage.getEBoolean(), 
					"real_greaterthan", 
					"false", 
					0, 
					1, 
					typeof(EAttribute), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					!IS_UNSETTABLE, 
					!IS_ID, 
					IS_UNIQUE, 
					IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getMyClass_Real_greaterequals(), 
					ecorePackage.getEBoolean(), 
					"real_greaterequals", 
					"false", 
					0, 
					1, 
					typeof(EAttribute), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					!IS_UNSETTABLE, 
					!IS_ID, 
					IS_UNIQUE, 
					IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getMyClass_Real_lessequals(), 
					ecorePackage.getEBoolean(), 
					"real_lessequals", 
					"false", 
					0, 
					1, 
					typeof(EAttribute), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					!IS_UNSETTABLE, 
					!IS_ID, 
					IS_UNIQUE, 
					IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getMyClass_Real_division(), 
					ecorePackage.getEBigDecimal(), 
					"real_division", 
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
					IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getMyClass_Real_absolute(), 
					ecorePackage.getEBigDecimal(), 
					"real_absolute", 
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
					IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getMyClass_Real_maximum(), 
					ecorePackage.getEBigDecimal(), 
					"real_maximum", 
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
					IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getMyClass_Real_minimum(), 
					ecorePackage.getEBigDecimal(), 
					"real_minimum", 
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
					IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getMyClass_Real_floor(), 
					ecorePackage.getEBigDecimal(), 
					"real_floor", 
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
					IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getMyClass_Real_toString(), 
					ecorePackage.getEString(), 
					"real_toString", 
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
					IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getMyClass_String_addition(), 
					ecorePackage.getEString(), 
					"string_addition", 
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
					IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getMyClass_String_lessthan(), 
					ecorePackage.getEBoolean(), 
					"string_lessthan", 
					"false", 
					0, 
					1, 
					typeof(EAttribute), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					!IS_UNSETTABLE, 
					!IS_ID, 
					IS_UNIQUE, 
					IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getMyClass_String_lessequals(), 
					ecorePackage.getEBoolean(), 
					"string_lessequals", 
					"false", 
					0, 
					1, 
					typeof(EAttribute), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					!IS_UNSETTABLE, 
					!IS_ID, 
					IS_UNIQUE, 
					IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getMyClass_String_unequal(), 
					ecorePackage.getEBoolean(), 
					"string_unequal", 
					"false", 
					0, 
					1, 
					typeof(EAttribute), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					!IS_UNSETTABLE, 
					!IS_ID, 
					IS_UNIQUE, 
					IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getMyClass_String_equal(), 
					ecorePackage.getEBoolean(), 
					"string_equal", 
					"false", 
					0, 
					1, 
					typeof(EAttribute), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					!IS_UNSETTABLE, 
					!IS_ID, 
					IS_UNIQUE, 
					IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getMyClass_String_greaterthan(), 
					ecorePackage.getEBoolean(), 
					"string_greaterthan", 
					"false", 
					0, 
					1, 
					typeof(EAttribute), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					!IS_UNSETTABLE, 
					!IS_ID, 
					IS_UNIQUE, 
					IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getMyClass_String_greaterequals(), 
					ecorePackage.getEBoolean(), 
					"string_greaterequals", 
					"false", 
					0, 
					1, 
					typeof(EAttribute), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					!IS_UNSETTABLE, 
					!IS_ID, 
					IS_UNIQUE, 
					IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getMyClass_String_at(), 
					ecorePackage.getEString(), 
					"string_at", 
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
					IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getMyClass_String_compareTo(), 
					ecorePackage.getEBigInteger(), 
					"string_compareTo", 
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
					IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getMyClass_String_concat(), 
					ecorePackage.getEString(), 
					"string_concat", 
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
					IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getMyClass_String_equalsIgnoreCase(), 
					ecorePackage.getEBoolean(), 
					"string_equalsIgnoreCase", 
					"false", 
					0, 
					1, 
					typeof(EAttribute), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					!IS_UNSETTABLE, 
					!IS_ID, 
					IS_UNIQUE, 
					IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getMyClass_String_indexOf(), 
					ecorePackage.getEBigInteger(), 
					"string_indexOf", 
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
					IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getMyClass_String_lastIndexOf(), 
					ecorePackage.getEBigInteger(), 
					"string_lastIndexOf", 
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
					IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getMyClass_String_replaceAll(), 
					ecorePackage.getEString(), 
					"string_replaceAll", 
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
					IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getMyClass_String_size(), 
					ecorePackage.getEBigInteger(), 
					"string_size", 
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
					IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getMyClass_Let2(), 
					ecorePackage.getEBoolean(), 
					"let2", 
					"false", 
					0, 
					1, 
					typeof(EAttribute), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					!IS_UNSETTABLE, 
					!IS_ID, 
					IS_UNIQUE, 
					IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getMyClass_Let3(), 
					ecorePackage.getEInt(), 
					"let3", 
					"0", 
					0, 
					1, 
					typeof(EAttribute), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					!IS_UNSETTABLE, 
					!IS_ID, 
					IS_UNIQUE, 
					IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getMyClass_UnEmployed(), 
					ecorePackage.getEBoolean(), 
					"unEmployed", 
					"false", 
					1, 
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
				initEAttribute(getMyClass_Let(), 
					ecorePackage.getEBoolean(), 
					"let", 
					"false", 
					0, 
					1, 
					typeof(EAttribute), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					!IS_UNSETTABLE, 
					!IS_ID, 
					IS_UNIQUE, 
					IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getMyClass_Integer_sequence(), 
					ecorePackage.getEInt(), 
					"integer_sequence", 
					null, 
					0, 
					-1, 
					typeof(EAttribute), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					!IS_UNSETTABLE, 
					!IS_ID, 
					!IS_UNIQUE, 
					!IS_DERIVED, 
					!IS_ORDERED);
				initEAttribute(getMyClass_Sequence_selectByKind(), 
					ecorePackage.getEBigInteger(), 
					"sequence_selectByKind", 
					null, 
					0, 
					-1, 
					typeof(EAttribute), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					!IS_UNSETTABLE, 
					!IS_ID, 
					!IS_UNIQUE, 
					IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getMyClass_Sequence_selectByType(), 
					ecorePackage.getEBigInteger(), 
					"sequence_selectByType", 
					null, 
					0, 
					-1, 
					typeof(EAttribute), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					!IS_UNSETTABLE, 
					!IS_ID, 
					!IS_UNIQUE, 
					IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getMyClass_Tuple_literal(), 
					ecorePackage.getEBoolean(), 
					"tuple_literal", 
					"false", 
					0, 
					1, 
					typeof(EAttribute), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					!IS_UNSETTABLE, 
					!IS_ID, 
					IS_UNIQUE, 
					IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getMyClass_Orderedset_size(), 
					ecorePackage.getEBigInteger(), 
					"orderedset_size", 
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
					IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getMyClass_Sequence_count(), 
					ecorePackage.getEBigInteger(), 
					"sequence_count", 
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
					IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getMyClass__IntegerLiteralExp(), 
					ecorePackage.getEBigInteger(), 
					"_IntegerLiteralExp", 
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
					IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getMyClass__InfixExp_NOT_PASSING_DUE_TO_BUG_IN_OCLHELPER(), 
					ecorePackage.getEBigInteger(), 
					"_InfixExp_NOT_PASSING_DUE_TO_BUG_IN_OCLHELPER", 
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
					IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getMyClass__StringLiteralExp(), 
					ecorePackage.getEString(), 
					"_StringLiteralExp", 
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
					IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getMyClass__BooleanLiteralExp(), 
					ecorePackage.getEBoolean(), 
					"_BooleanLiteralExp", 
					"false", 
					0, 
					1, 
					typeof(EAttribute), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					!IS_UNSETTABLE, 
					!IS_ID, 
					IS_UNIQUE, 
					IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getMyClass__RealLiteralExp(), 
					ecorePackage.getEBigDecimal(), 
					"_RealLiteralExp", 
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
					IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getMyClass__NumberLiteralExp(), 
					ecorePackage.getEBigDecimal(), 
					"_NumberLiteralExp", 
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
					IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getMyClass__IfExp(), 
					ecorePackage.getEBigInteger(), 
					"_IfExp", 
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
					IS_DERIVED, 
					IS_ORDERED);
				
				initEReference(
					getMyClass_Orderedset(), 
					this.getMyClass(), 
					null, 
					"orderedset", 
					null, 
					0, 
					-1, 
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
					getMyClass_Set(), 
					this.getMyClass(), 
					null, 
					"set", 
					null, 
					0, 
					-1, 
					typeof(MyClass), 
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
					getMyClass_Sequence(), 
					this.getMyClass(), 
					null, 
					"sequence", 
					null, 
					0, 
					-1, 
					typeof(MyClass), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					!IS_COMPOSITE, 
					IS_RESOLVE_PROXIES, 
					!IS_UNSETTABLE, 
					!IS_UNIQUE, 
					!IS_DERIVED, 
					IS_ORDERED);
				initEReference(
					getMyClass_Bag(), 
					this.getMyClass(), 
					null, 
					"bag", 
					null, 
					0, 
					-1, 
					typeof(MyClass), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					!IS_COMPOSITE, 
					IS_RESOLVE_PROXIES, 
					!IS_UNSETTABLE, 
					!IS_UNIQUE, 
					!IS_DERIVED, 
					!IS_ORDERED);
				initEReference(
					getMyClass_Orderedset_select(), 
					this.getMyClass(), 
					null, 
					"orderedset_select", 
					null, 
					0, 
					-1, 
					typeof(MyClass), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					!IS_COMPOSITE, 
					IS_RESOLVE_PROXIES, 
					!IS_UNSETTABLE, 
					IS_UNIQUE, 
					IS_DERIVED, 
					IS_ORDERED);
				initEReference(
					getMyClass_Orderedset_at(), 
					this.getMyClass(), 
					null, 
					"orderedset_at", 
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
					IS_DERIVED, 
					IS_ORDERED);
				initEReference(
					getMyClass__SelfExp(), 
					this.getMyClass(), 
					null, 
					"_SelfExp", 
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
					IS_DERIVED, 
					IS_ORDERED);
				initEReference(
					getMyClass__NullExp(), 
					this.getMyClass(), 
					null, 
					"_NullExp", 
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
					IS_DERIVED, 
					IS_ORDERED);
				
	        }
	        
			
			private EClass MyClassEClass = null;
			
			
			
			
			
			public const int MYCLASS = 0;
			public const int MYCLASS_FEATURE_COUNT = 76;
			public const int MYCLASS_OPERATION_COUNT = 0;
			
			public const int MYCLASS_STATIC_SEQUENCE = 0;
			public const int MYCLASS_COLLECTION_LITERALS = 1;
			public const int MYCLASS_BOOLEAN_UNEQUAL = 2;
			public const int MYCLASS_BOOLEAN_EQUAL = 3;
			public const int MYCLASS_BOOLEAN_AND = 4;
			public const int MYCLASS_BOOLEAN_IMPLIES = 5;
			public const int MYCLASS_BOOLEAN_NOT = 6;
			public const int MYCLASS_BOOLEAN_OR = 7;
			public const int MYCLASS_BOOLEAN_XOR = 8;
			public const int MYCLASS_BOOLEAN_TOSTRING = 9;
			public const int MYCLASS_INTEGER_MULTIPLICATION = 10;
			public const int MYCLASS_INTEGER_ADDITION = 11;
			public const int MYCLASS_INTEGER_SUBTRACTION = 12;
			public const int MYCLASS_INTEGER_LESSTHAN = 13;
			public const int MYCLASS_INTEGER_GREATERTHAN = 14;
			public const int MYCLASS_INTEGER_GREATEREQUALS = 15;
			public const int MYCLASS_INTEGER_LESSEQUALS = 16;
			public const int MYCLASS_INTEGER_DIVISION = 17;
			public const int MYCLASS_INTEGER_ABSOLUTE = 18;
			public const int MYCLASS_INTEGER_MAXIMUM = 19;
			public const int MYCLASS_INTEGER_MINIMUM = 20;
			public const int MYCLASS_INTEGER_MODULO = 21;
			public const int MYCLASS_INTEGER_TOSTRING = 22;
			public const int MYCLASS_REAL_MULTIPLICATION = 23;
			public const int MYCLASS_REAL_ADDITION = 24;
			public const int MYCLASS_REAL_SUBTRACTION = 25;
			public const int MYCLASS_REAL_LESSTHAN = 26;
			public const int MYCLASS_REAL_GREATERTHAN = 27;
			public const int MYCLASS_REAL_GREATEREQUALS = 28;
			public const int MYCLASS_REAL_LESSEQUALS = 29;
			public const int MYCLASS_REAL_DIVISION = 30;
			public const int MYCLASS_REAL_ABSOLUTE = 31;
			public const int MYCLASS_REAL_MAXIMUM = 32;
			public const int MYCLASS_REAL_MINIMUM = 33;
			public const int MYCLASS_REAL_FLOOR = 34;
			public const int MYCLASS_REAL_TOSTRING = 35;
			public const int MYCLASS_STRING_ADDITION = 36;
			public const int MYCLASS_STRING_LESSTHAN = 37;
			public const int MYCLASS_STRING_LESSEQUALS = 38;
			public const int MYCLASS_STRING_UNEQUAL = 39;
			public const int MYCLASS_STRING_EQUAL = 40;
			public const int MYCLASS_STRING_GREATERTHAN = 41;
			public const int MYCLASS_STRING_GREATEREQUALS = 42;
			public const int MYCLASS_STRING_AT = 43;
			public const int MYCLASS_STRING_COMPARETO = 44;
			public const int MYCLASS_STRING_CONCAT = 45;
			public const int MYCLASS_STRING_EQUALSIGNORECASE = 46;
			public const int MYCLASS_STRING_INDEXOF = 47;
			public const int MYCLASS_STRING_LASTINDEXOF = 48;
			public const int MYCLASS_STRING_REPLACEALL = 49;
			public const int MYCLASS_STRING_SIZE = 50;
			public const int MYCLASS_LET2 = 51;
			public const int MYCLASS_LET3 = 52;
			public const int MYCLASS_UNEMPLOYED = 53;
			public const int MYCLASS_LET = 54;
			public const int MYCLASS_ORDEREDSET = 55;
			public const int MYCLASS_SET = 56;
			public const int MYCLASS_SEQUENCE = 57;
			public const int MYCLASS_INTEGER_SEQUENCE = 58;
			public const int MYCLASS_BAG = 59;
			public const int MYCLASS_SEQUENCE_SELECTBYKIND = 60;
			public const int MYCLASS_SEQUENCE_SELECTBYTYPE = 61;
			public const int MYCLASS_TUPLE_LITERAL = 62;
			public const int MYCLASS_ORDEREDSET_SELECT = 63;
			public const int MYCLASS_ORDEREDSET_SIZE = 64;
			public const int MYCLASS_SEQUENCE_COUNT = 65;
			public const int MYCLASS_ORDEREDSET_AT = 66;
			public const int MYCLASS__SELFEXP = 67;
			public const int MYCLASS__INTEGERLITERALEXP = 68;
			public const int MYCLASS__INFIXEXP_NOT_PASSING_DUE_TO_BUG_IN_OCLHELPER = 69;
			public const int MYCLASS__STRINGLITERALEXP = 70;
			public const int MYCLASS__BOOLEANLITERALEXP = 71;
			public const int MYCLASS__REALLITERALEXP = 72;
			public const int MYCLASS__NUMBERLITERALEXP = 73;
			public const int MYCLASS__NULLEXP = 74;
			public const int MYCLASS__IFEXP = 75;
			
			
			
			public EClass getMyClass(){return MyClassEClass;}
			
			public EAttribute getMyClass_Static_sequence(){return (EAttribute)MyClassEClass.eStructuralFeatures.at(0);}
			public EAttribute getMyClass_Collection_literals(){return (EAttribute)MyClassEClass.eStructuralFeatures.at(1);}
			public EAttribute getMyClass_Boolean_unequal(){return (EAttribute)MyClassEClass.eStructuralFeatures.at(2);}
			public EAttribute getMyClass_Boolean_equal(){return (EAttribute)MyClassEClass.eStructuralFeatures.at(3);}
			public EAttribute getMyClass_Boolean_and(){return (EAttribute)MyClassEClass.eStructuralFeatures.at(4);}
			public EAttribute getMyClass_Boolean_implies(){return (EAttribute)MyClassEClass.eStructuralFeatures.at(5);}
			public EAttribute getMyClass_Boolean_not(){return (EAttribute)MyClassEClass.eStructuralFeatures.at(6);}
			public EAttribute getMyClass_Boolean_or(){return (EAttribute)MyClassEClass.eStructuralFeatures.at(7);}
			public EAttribute getMyClass_Boolean_xor(){return (EAttribute)MyClassEClass.eStructuralFeatures.at(8);}
			public EAttribute getMyClass_Boolean_toString(){return (EAttribute)MyClassEClass.eStructuralFeatures.at(9);}
			public EAttribute getMyClass_Integer_multiplication(){return (EAttribute)MyClassEClass.eStructuralFeatures.at(10);}
			public EAttribute getMyClass_Integer_addition(){return (EAttribute)MyClassEClass.eStructuralFeatures.at(11);}
			public EAttribute getMyClass_Integer_subtraction(){return (EAttribute)MyClassEClass.eStructuralFeatures.at(12);}
			public EAttribute getMyClass_Integer_lessthan(){return (EAttribute)MyClassEClass.eStructuralFeatures.at(13);}
			public EAttribute getMyClass_Integer_greaterthan(){return (EAttribute)MyClassEClass.eStructuralFeatures.at(14);}
			public EAttribute getMyClass_Integer_greaterequals(){return (EAttribute)MyClassEClass.eStructuralFeatures.at(15);}
			public EAttribute getMyClass_Integer_lessequals(){return (EAttribute)MyClassEClass.eStructuralFeatures.at(16);}
			public EAttribute getMyClass_Integer_division(){return (EAttribute)MyClassEClass.eStructuralFeatures.at(17);}
			public EAttribute getMyClass_Integer_absolute(){return (EAttribute)MyClassEClass.eStructuralFeatures.at(18);}
			public EAttribute getMyClass_Integer_maximum(){return (EAttribute)MyClassEClass.eStructuralFeatures.at(19);}
			public EAttribute getMyClass_Integer_minimum(){return (EAttribute)MyClassEClass.eStructuralFeatures.at(20);}
			public EAttribute getMyClass_Integer_modulo(){return (EAttribute)MyClassEClass.eStructuralFeatures.at(21);}
			public EAttribute getMyClass_Integer_toString(){return (EAttribute)MyClassEClass.eStructuralFeatures.at(22);}
			public EAttribute getMyClass_Real_multiplication(){return (EAttribute)MyClassEClass.eStructuralFeatures.at(23);}
			public EAttribute getMyClass_Real_addition(){return (EAttribute)MyClassEClass.eStructuralFeatures.at(24);}
			public EAttribute getMyClass_Real_subtraction(){return (EAttribute)MyClassEClass.eStructuralFeatures.at(25);}
			public EAttribute getMyClass_Real_lessthan(){return (EAttribute)MyClassEClass.eStructuralFeatures.at(26);}
			public EAttribute getMyClass_Real_greaterthan(){return (EAttribute)MyClassEClass.eStructuralFeatures.at(27);}
			public EAttribute getMyClass_Real_greaterequals(){return (EAttribute)MyClassEClass.eStructuralFeatures.at(28);}
			public EAttribute getMyClass_Real_lessequals(){return (EAttribute)MyClassEClass.eStructuralFeatures.at(29);}
			public EAttribute getMyClass_Real_division(){return (EAttribute)MyClassEClass.eStructuralFeatures.at(30);}
			public EAttribute getMyClass_Real_absolute(){return (EAttribute)MyClassEClass.eStructuralFeatures.at(31);}
			public EAttribute getMyClass_Real_maximum(){return (EAttribute)MyClassEClass.eStructuralFeatures.at(32);}
			public EAttribute getMyClass_Real_minimum(){return (EAttribute)MyClassEClass.eStructuralFeatures.at(33);}
			public EAttribute getMyClass_Real_floor(){return (EAttribute)MyClassEClass.eStructuralFeatures.at(34);}
			public EAttribute getMyClass_Real_toString(){return (EAttribute)MyClassEClass.eStructuralFeatures.at(35);}
			public EAttribute getMyClass_String_addition(){return (EAttribute)MyClassEClass.eStructuralFeatures.at(36);}
			public EAttribute getMyClass_String_lessthan(){return (EAttribute)MyClassEClass.eStructuralFeatures.at(37);}
			public EAttribute getMyClass_String_lessequals(){return (EAttribute)MyClassEClass.eStructuralFeatures.at(38);}
			public EAttribute getMyClass_String_unequal(){return (EAttribute)MyClassEClass.eStructuralFeatures.at(39);}
			public EAttribute getMyClass_String_equal(){return (EAttribute)MyClassEClass.eStructuralFeatures.at(40);}
			public EAttribute getMyClass_String_greaterthan(){return (EAttribute)MyClassEClass.eStructuralFeatures.at(41);}
			public EAttribute getMyClass_String_greaterequals(){return (EAttribute)MyClassEClass.eStructuralFeatures.at(42);}
			public EAttribute getMyClass_String_at(){return (EAttribute)MyClassEClass.eStructuralFeatures.at(43);}
			public EAttribute getMyClass_String_compareTo(){return (EAttribute)MyClassEClass.eStructuralFeatures.at(44);}
			public EAttribute getMyClass_String_concat(){return (EAttribute)MyClassEClass.eStructuralFeatures.at(45);}
			public EAttribute getMyClass_String_equalsIgnoreCase(){return (EAttribute)MyClassEClass.eStructuralFeatures.at(46);}
			public EAttribute getMyClass_String_indexOf(){return (EAttribute)MyClassEClass.eStructuralFeatures.at(47);}
			public EAttribute getMyClass_String_lastIndexOf(){return (EAttribute)MyClassEClass.eStructuralFeatures.at(48);}
			public EAttribute getMyClass_String_replaceAll(){return (EAttribute)MyClassEClass.eStructuralFeatures.at(49);}
			public EAttribute getMyClass_String_size(){return (EAttribute)MyClassEClass.eStructuralFeatures.at(50);}
			public EAttribute getMyClass_Let2(){return (EAttribute)MyClassEClass.eStructuralFeatures.at(51);}
			public EAttribute getMyClass_Let3(){return (EAttribute)MyClassEClass.eStructuralFeatures.at(52);}
			public EAttribute getMyClass_UnEmployed(){return (EAttribute)MyClassEClass.eStructuralFeatures.at(53);}
			public EAttribute getMyClass_Let(){return (EAttribute)MyClassEClass.eStructuralFeatures.at(54);}
			public EReference getMyClass_Orderedset(){return (EReference)MyClassEClass.eStructuralFeatures.at(55);}
			public EReference getMyClass_Set(){return (EReference)MyClassEClass.eStructuralFeatures.at(56);}
			public EReference getMyClass_Sequence(){return (EReference)MyClassEClass.eStructuralFeatures.at(57);}
			public EAttribute getMyClass_Integer_sequence(){return (EAttribute)MyClassEClass.eStructuralFeatures.at(58);}
			public EReference getMyClass_Bag(){return (EReference)MyClassEClass.eStructuralFeatures.at(59);}
			public EAttribute getMyClass_Sequence_selectByKind(){return (EAttribute)MyClassEClass.eStructuralFeatures.at(60);}
			public EAttribute getMyClass_Sequence_selectByType(){return (EAttribute)MyClassEClass.eStructuralFeatures.at(61);}
			public EAttribute getMyClass_Tuple_literal(){return (EAttribute)MyClassEClass.eStructuralFeatures.at(62);}
			public EReference getMyClass_Orderedset_select(){return (EReference)MyClassEClass.eStructuralFeatures.at(63);}
			public EAttribute getMyClass_Orderedset_size(){return (EAttribute)MyClassEClass.eStructuralFeatures.at(64);}
			public EAttribute getMyClass_Sequence_count(){return (EAttribute)MyClassEClass.eStructuralFeatures.at(65);}
			public EReference getMyClass_Orderedset_at(){return (EReference)MyClassEClass.eStructuralFeatures.at(66);}
			public EReference getMyClass__SelfExp(){return (EReference)MyClassEClass.eStructuralFeatures.at(67);}
			public EAttribute getMyClass__IntegerLiteralExp(){return (EAttribute)MyClassEClass.eStructuralFeatures.at(68);}
			public EAttribute getMyClass__InfixExp_NOT_PASSING_DUE_TO_BUG_IN_OCLHELPER(){return (EAttribute)MyClassEClass.eStructuralFeatures.at(69);}
			public EAttribute getMyClass__StringLiteralExp(){return (EAttribute)MyClassEClass.eStructuralFeatures.at(70);}
			public EAttribute getMyClass__BooleanLiteralExp(){return (EAttribute)MyClassEClass.eStructuralFeatures.at(71);}
			public EAttribute getMyClass__RealLiteralExp(){return (EAttribute)MyClassEClass.eStructuralFeatures.at(72);}
			public EAttribute getMyClass__NumberLiteralExp(){return (EAttribute)MyClassEClass.eStructuralFeatures.at(73);}
			public EReference getMyClass__NullExp(){return (EReference)MyClassEClass.eStructuralFeatures.at(74);}
			public EAttribute getMyClass__IfExp(){return (EAttribute)MyClassEClass.eStructuralFeatures.at(75);}
			
			public class Literals{
				public static EClass MYCLASS = OcltestmodelPackageImpl.eINSTANCE.getMyClass();
				
				public static EReference MYCLASS_ORDEREDSET = OcltestmodelPackageImpl.eINSTANCE.getMyClass_Orderedset();
				public static EReference MYCLASS_SET = OcltestmodelPackageImpl.eINSTANCE.getMyClass_Set();
				public static EReference MYCLASS_SEQUENCE = OcltestmodelPackageImpl.eINSTANCE.getMyClass_Sequence();
				public static EReference MYCLASS_BAG = OcltestmodelPackageImpl.eINSTANCE.getMyClass_Bag();
				public static EReference MYCLASS_ORDEREDSET_SELECT = OcltestmodelPackageImpl.eINSTANCE.getMyClass_Orderedset_select();
				public static EReference MYCLASS_ORDEREDSET_AT = OcltestmodelPackageImpl.eINSTANCE.getMyClass_Orderedset_at();
				public static EReference MYCLASS__SELFEXP = OcltestmodelPackageImpl.eINSTANCE.getMyClass__SelfExp();
				public static EReference MYCLASS__NULLEXP = OcltestmodelPackageImpl.eINSTANCE.getMyClass__NullExp();
				
				public static EAttribute MYCLASS_STATIC_SEQUENCE = OcltestmodelPackageImpl.eINSTANCE.getMyClass_Static_sequence();
				public static EAttribute MYCLASS_COLLECTION_LITERALS = OcltestmodelPackageImpl.eINSTANCE.getMyClass_Collection_literals();
				public static EAttribute MYCLASS_BOOLEAN_UNEQUAL = OcltestmodelPackageImpl.eINSTANCE.getMyClass_Boolean_unequal();
				public static EAttribute MYCLASS_BOOLEAN_EQUAL = OcltestmodelPackageImpl.eINSTANCE.getMyClass_Boolean_equal();
				public static EAttribute MYCLASS_BOOLEAN_AND = OcltestmodelPackageImpl.eINSTANCE.getMyClass_Boolean_and();
				public static EAttribute MYCLASS_BOOLEAN_IMPLIES = OcltestmodelPackageImpl.eINSTANCE.getMyClass_Boolean_implies();
				public static EAttribute MYCLASS_BOOLEAN_NOT = OcltestmodelPackageImpl.eINSTANCE.getMyClass_Boolean_not();
				public static EAttribute MYCLASS_BOOLEAN_OR = OcltestmodelPackageImpl.eINSTANCE.getMyClass_Boolean_or();
				public static EAttribute MYCLASS_BOOLEAN_XOR = OcltestmodelPackageImpl.eINSTANCE.getMyClass_Boolean_xor();
				public static EAttribute MYCLASS_BOOLEAN_TOSTRING = OcltestmodelPackageImpl.eINSTANCE.getMyClass_Boolean_toString();
				public static EAttribute MYCLASS_INTEGER_MULTIPLICATION = OcltestmodelPackageImpl.eINSTANCE.getMyClass_Integer_multiplication();
				public static EAttribute MYCLASS_INTEGER_ADDITION = OcltestmodelPackageImpl.eINSTANCE.getMyClass_Integer_addition();
				public static EAttribute MYCLASS_INTEGER_SUBTRACTION = OcltestmodelPackageImpl.eINSTANCE.getMyClass_Integer_subtraction();
				public static EAttribute MYCLASS_INTEGER_LESSTHAN = OcltestmodelPackageImpl.eINSTANCE.getMyClass_Integer_lessthan();
				public static EAttribute MYCLASS_INTEGER_GREATERTHAN = OcltestmodelPackageImpl.eINSTANCE.getMyClass_Integer_greaterthan();
				public static EAttribute MYCLASS_INTEGER_GREATEREQUALS = OcltestmodelPackageImpl.eINSTANCE.getMyClass_Integer_greaterequals();
				public static EAttribute MYCLASS_INTEGER_LESSEQUALS = OcltestmodelPackageImpl.eINSTANCE.getMyClass_Integer_lessequals();
				public static EAttribute MYCLASS_INTEGER_DIVISION = OcltestmodelPackageImpl.eINSTANCE.getMyClass_Integer_division();
				public static EAttribute MYCLASS_INTEGER_ABSOLUTE = OcltestmodelPackageImpl.eINSTANCE.getMyClass_Integer_absolute();
				public static EAttribute MYCLASS_INTEGER_MAXIMUM = OcltestmodelPackageImpl.eINSTANCE.getMyClass_Integer_maximum();
				public static EAttribute MYCLASS_INTEGER_MINIMUM = OcltestmodelPackageImpl.eINSTANCE.getMyClass_Integer_minimum();
				public static EAttribute MYCLASS_INTEGER_MODULO = OcltestmodelPackageImpl.eINSTANCE.getMyClass_Integer_modulo();
				public static EAttribute MYCLASS_INTEGER_TOSTRING = OcltestmodelPackageImpl.eINSTANCE.getMyClass_Integer_toString();
				public static EAttribute MYCLASS_REAL_MULTIPLICATION = OcltestmodelPackageImpl.eINSTANCE.getMyClass_Real_multiplication();
				public static EAttribute MYCLASS_REAL_ADDITION = OcltestmodelPackageImpl.eINSTANCE.getMyClass_Real_addition();
				public static EAttribute MYCLASS_REAL_SUBTRACTION = OcltestmodelPackageImpl.eINSTANCE.getMyClass_Real_subtraction();
				public static EAttribute MYCLASS_REAL_LESSTHAN = OcltestmodelPackageImpl.eINSTANCE.getMyClass_Real_lessthan();
				public static EAttribute MYCLASS_REAL_GREATERTHAN = OcltestmodelPackageImpl.eINSTANCE.getMyClass_Real_greaterthan();
				public static EAttribute MYCLASS_REAL_GREATEREQUALS = OcltestmodelPackageImpl.eINSTANCE.getMyClass_Real_greaterequals();
				public static EAttribute MYCLASS_REAL_LESSEQUALS = OcltestmodelPackageImpl.eINSTANCE.getMyClass_Real_lessequals();
				public static EAttribute MYCLASS_REAL_DIVISION = OcltestmodelPackageImpl.eINSTANCE.getMyClass_Real_division();
				public static EAttribute MYCLASS_REAL_ABSOLUTE = OcltestmodelPackageImpl.eINSTANCE.getMyClass_Real_absolute();
				public static EAttribute MYCLASS_REAL_MAXIMUM = OcltestmodelPackageImpl.eINSTANCE.getMyClass_Real_maximum();
				public static EAttribute MYCLASS_REAL_MINIMUM = OcltestmodelPackageImpl.eINSTANCE.getMyClass_Real_minimum();
				public static EAttribute MYCLASS_REAL_FLOOR = OcltestmodelPackageImpl.eINSTANCE.getMyClass_Real_floor();
				public static EAttribute MYCLASS_REAL_TOSTRING = OcltestmodelPackageImpl.eINSTANCE.getMyClass_Real_toString();
				public static EAttribute MYCLASS_STRING_ADDITION = OcltestmodelPackageImpl.eINSTANCE.getMyClass_String_addition();
				public static EAttribute MYCLASS_STRING_LESSTHAN = OcltestmodelPackageImpl.eINSTANCE.getMyClass_String_lessthan();
				public static EAttribute MYCLASS_STRING_LESSEQUALS = OcltestmodelPackageImpl.eINSTANCE.getMyClass_String_lessequals();
				public static EAttribute MYCLASS_STRING_UNEQUAL = OcltestmodelPackageImpl.eINSTANCE.getMyClass_String_unequal();
				public static EAttribute MYCLASS_STRING_EQUAL = OcltestmodelPackageImpl.eINSTANCE.getMyClass_String_equal();
				public static EAttribute MYCLASS_STRING_GREATERTHAN = OcltestmodelPackageImpl.eINSTANCE.getMyClass_String_greaterthan();
				public static EAttribute MYCLASS_STRING_GREATEREQUALS = OcltestmodelPackageImpl.eINSTANCE.getMyClass_String_greaterequals();
				public static EAttribute MYCLASS_STRING_AT = OcltestmodelPackageImpl.eINSTANCE.getMyClass_String_at();
				public static EAttribute MYCLASS_STRING_COMPARETO = OcltestmodelPackageImpl.eINSTANCE.getMyClass_String_compareTo();
				public static EAttribute MYCLASS_STRING_CONCAT = OcltestmodelPackageImpl.eINSTANCE.getMyClass_String_concat();
				public static EAttribute MYCLASS_STRING_EQUALSIGNORECASE = OcltestmodelPackageImpl.eINSTANCE.getMyClass_String_equalsIgnoreCase();
				public static EAttribute MYCLASS_STRING_INDEXOF = OcltestmodelPackageImpl.eINSTANCE.getMyClass_String_indexOf();
				public static EAttribute MYCLASS_STRING_LASTINDEXOF = OcltestmodelPackageImpl.eINSTANCE.getMyClass_String_lastIndexOf();
				public static EAttribute MYCLASS_STRING_REPLACEALL = OcltestmodelPackageImpl.eINSTANCE.getMyClass_String_replaceAll();
				public static EAttribute MYCLASS_STRING_SIZE = OcltestmodelPackageImpl.eINSTANCE.getMyClass_String_size();
				public static EAttribute MYCLASS_LET2 = OcltestmodelPackageImpl.eINSTANCE.getMyClass_Let2();
				public static EAttribute MYCLASS_LET3 = OcltestmodelPackageImpl.eINSTANCE.getMyClass_Let3();
				public static EAttribute MYCLASS_UNEMPLOYED = OcltestmodelPackageImpl.eINSTANCE.getMyClass_UnEmployed();
				public static EAttribute MYCLASS_LET = OcltestmodelPackageImpl.eINSTANCE.getMyClass_Let();
				public static EAttribute MYCLASS_INTEGER_SEQUENCE = OcltestmodelPackageImpl.eINSTANCE.getMyClass_Integer_sequence();
				public static EAttribute MYCLASS_SEQUENCE_SELECTBYKIND = OcltestmodelPackageImpl.eINSTANCE.getMyClass_Sequence_selectByKind();
				public static EAttribute MYCLASS_SEQUENCE_SELECTBYTYPE = OcltestmodelPackageImpl.eINSTANCE.getMyClass_Sequence_selectByType();
				public static EAttribute MYCLASS_TUPLE_LITERAL = OcltestmodelPackageImpl.eINSTANCE.getMyClass_Tuple_literal();
				public static EAttribute MYCLASS_ORDEREDSET_SIZE = OcltestmodelPackageImpl.eINSTANCE.getMyClass_Orderedset_size();
				public static EAttribute MYCLASS_SEQUENCE_COUNT = OcltestmodelPackageImpl.eINSTANCE.getMyClass_Sequence_count();
				public static EAttribute MYCLASS__INTEGERLITERALEXP = OcltestmodelPackageImpl.eINSTANCE.getMyClass__IntegerLiteralExp();
				public static EAttribute MYCLASS__INFIXEXP_NOT_PASSING_DUE_TO_BUG_IN_OCLHELPER = OcltestmodelPackageImpl.eINSTANCE.getMyClass__InfixExp_NOT_PASSING_DUE_TO_BUG_IN_OCLHELPER();
				public static EAttribute MYCLASS__STRINGLITERALEXP = OcltestmodelPackageImpl.eINSTANCE.getMyClass__StringLiteralExp();
				public static EAttribute MYCLASS__BOOLEANLITERALEXP = OcltestmodelPackageImpl.eINSTANCE.getMyClass__BooleanLiteralExp();
				public static EAttribute MYCLASS__REALLITERALEXP = OcltestmodelPackageImpl.eINSTANCE.getMyClass__RealLiteralExp();
				public static EAttribute MYCLASS__NUMBERLITERALEXP = OcltestmodelPackageImpl.eINSTANCE.getMyClass__NumberLiteralExp();
				public static EAttribute MYCLASS__IFEXP = OcltestmodelPackageImpl.eINSTANCE.getMyClass__IfExp();
			}
	 
	}
}
