/* CrossEcore is a cross-platform modeling framework that generates C#, TypeScript, 
 * JavaScript, Swift code from Ecore models with embedded OCL (http://www.crossecore.org/).
 * The original Eclipse Modeling Framework is available at https://www.eclipse.org/modeling/emf/.
 * 
 * contributor: Simon Schwichtenberg
 */
 
namespace Ecore{
	public class EcorePackageImpl : EPackageImpl, EcorePackage{
			public const string eNAME = "ecore";
			
			public const string eNS_URI = "http://www.eclipse.org/emf/2002/Ecore";
			
			public const string eNS_PREFIX = "ecore";
			
			public static EcorePackage eINSTANCE = init();
			
			private EcorePackageImpl():base(eNS_URI, EcoreFactoryImpl.eINSTANCE)
			{
				
			}
			
            public static EcorePackage init()
            {
                // Obtain or create and register package
                var theEcorePackage = new EcorePackageImpl();

                // Create package meta-data objects
                theEcorePackage.createPackageContents();

                // Initialize created meta-data
                theEcorePackage.initializePackageContents();

		        return theEcorePackage;
	        }
	        
	        private bool isCreated = false;
            public void createPackageContents()
            {
                if (isCreated) return;
                isCreated = true;
				EAttributeEClass = createEClass(EATTRIBUTE);
				createEAttribute(EAttributeEClass, EATTRIBUTE_ID);
				createEReference(EAttributeEClass, EATTRIBUTE_EATTRIBUTETYPE);
				EAnnotationEClass = createEClass(EANNOTATION);
				createEAttribute(EAnnotationEClass, EANNOTATION_SOURCE);
				createEReference(EAnnotationEClass, EANNOTATION_DETAILS);
				createEReference(EAnnotationEClass, EANNOTATION_EMODELELEMENT);
				createEReference(EAnnotationEClass, EANNOTATION_CONTENTS);
				createEReference(EAnnotationEClass, EANNOTATION_REFERENCES);
				EClassEClass = createEClass(ECLASS);
				createEAttribute(EClassEClass, ECLASS_ABSTRACT);
				createEAttribute(EClassEClass, ECLASS_INTERFACE);
				createEReference(EClassEClass, ECLASS_ESUPERTYPES);
				createEReference(EClassEClass, ECLASS_EOPERATIONS);
				createEReference(EClassEClass, ECLASS_EALLATTRIBUTES);
				createEReference(EClassEClass, ECLASS_EALLREFERENCES);
				createEReference(EClassEClass, ECLASS_EREFERENCES);
				createEReference(EClassEClass, ECLASS_EATTRIBUTES);
				createEReference(EClassEClass, ECLASS_EALLCONTAINMENTS);
				createEReference(EClassEClass, ECLASS_EALLOPERATIONS);
				createEReference(EClassEClass, ECLASS_EALLSTRUCTURALFEATURES);
				createEReference(EClassEClass, ECLASS_EALLSUPERTYPES);
				createEReference(EClassEClass, ECLASS_EIDATTRIBUTE);
				createEReference(EClassEClass, ECLASS_ESTRUCTURALFEATURES);
				createEReference(EClassEClass, ECLASS_EGENERICSUPERTYPES);
				createEReference(EClassEClass, ECLASS_EALLGENERICSUPERTYPES);
				EClassifierEClass = createEClass(ECLASSIFIER);
				createEAttribute(EClassifierEClass, ECLASSIFIER_INSTANCECLASSNAME);
				createEAttribute(EClassifierEClass, ECLASSIFIER_INSTANCECLASS);
				createEAttribute(EClassifierEClass, ECLASSIFIER_DEFAULTVALUE);
				createEAttribute(EClassifierEClass, ECLASSIFIER_INSTANCETYPENAME);
				createEReference(EClassifierEClass, ECLASSIFIER_EPACKAGE);
				createEReference(EClassifierEClass, ECLASSIFIER_ETYPEPARAMETERS);
				EDataTypeEClass = createEClass(EDATATYPE);
				createEAttribute(EDataTypeEClass, EDATATYPE_SERIALIZABLE);
				EEnumEClass = createEClass(EENUM);
				createEReference(EEnumEClass, EENUM_ELITERALS);
				EEnumLiteralEClass = createEClass(EENUMLITERAL);
				createEAttribute(EEnumLiteralEClass, EENUMLITERAL_VALUE);
				createEAttribute(EEnumLiteralEClass, EENUMLITERAL_INSTANCE);
				createEAttribute(EEnumLiteralEClass, EENUMLITERAL_LITERAL);
				createEReference(EEnumLiteralEClass, EENUMLITERAL_EENUM);
				EFactoryEClass = createEClass(EFACTORY);
				createEReference(EFactoryEClass, EFACTORY_EPACKAGE);
				EModelElementEClass = createEClass(EMODELELEMENT);
				createEReference(EModelElementEClass, EMODELELEMENT_EANNOTATIONS);
				ENamedElementEClass = createEClass(ENAMEDELEMENT);
				createEAttribute(ENamedElementEClass, ENAMEDELEMENT_NAME);
				EObjectEClass = createEClass(EOBJECT);
				EOperationEClass = createEClass(EOPERATION);
				createEReference(EOperationEClass, EOPERATION_ECONTAININGCLASS);
				createEReference(EOperationEClass, EOPERATION_ETYPEPARAMETERS);
				createEReference(EOperationEClass, EOPERATION_EPARAMETERS);
				createEReference(EOperationEClass, EOPERATION_EEXCEPTIONS);
				createEReference(EOperationEClass, EOPERATION_EGENERICEXCEPTIONS);
				EPackageEClass = createEClass(EPACKAGE);
				createEAttribute(EPackageEClass, EPACKAGE_NSURI);
				createEAttribute(EPackageEClass, EPACKAGE_NSPREFIX);
				createEReference(EPackageEClass, EPACKAGE_EFACTORYINSTANCE);
				createEReference(EPackageEClass, EPACKAGE_ECLASSIFIERS);
				createEReference(EPackageEClass, EPACKAGE_ESUBPACKAGES);
				createEReference(EPackageEClass, EPACKAGE_ESUPERPACKAGE);
				EParameterEClass = createEClass(EPARAMETER);
				createEReference(EParameterEClass, EPARAMETER_EOPERATION);
				EReferenceEClass = createEClass(EREFERENCE);
				createEAttribute(EReferenceEClass, EREFERENCE_CONTAINMENT);
				createEAttribute(EReferenceEClass, EREFERENCE_CONTAINER);
				createEAttribute(EReferenceEClass, EREFERENCE_RESOLVEPROXIES);
				createEReference(EReferenceEClass, EREFERENCE_EOPPOSITE);
				createEReference(EReferenceEClass, EREFERENCE_EREFERENCETYPE);
				createEReference(EReferenceEClass, EREFERENCE_EKEYS);
				EStructuralFeatureEClass = createEClass(ESTRUCTURALFEATURE);
				createEAttribute(EStructuralFeatureEClass, ESTRUCTURALFEATURE_CHANGEABLE);
				createEAttribute(EStructuralFeatureEClass, ESTRUCTURALFEATURE_VOLATILE);
				createEAttribute(EStructuralFeatureEClass, ESTRUCTURALFEATURE_TRANSIENT);
				createEAttribute(EStructuralFeatureEClass, ESTRUCTURALFEATURE_DEFAULTVALUELITERAL);
				createEAttribute(EStructuralFeatureEClass, ESTRUCTURALFEATURE_DEFAULTVALUE);
				createEAttribute(EStructuralFeatureEClass, ESTRUCTURALFEATURE_UNSETTABLE);
				createEAttribute(EStructuralFeatureEClass, ESTRUCTURALFEATURE_DERIVED);
				createEReference(EStructuralFeatureEClass, ESTRUCTURALFEATURE_ECONTAININGCLASS);
				ETypedElementEClass = createEClass(ETYPEDELEMENT);
				createEAttribute(ETypedElementEClass, ETYPEDELEMENT_ORDERED);
				createEAttribute(ETypedElementEClass, ETYPEDELEMENT_UNIQUE);
				createEAttribute(ETypedElementEClass, ETYPEDELEMENT_LOWERBOUND);
				createEAttribute(ETypedElementEClass, ETYPEDELEMENT_UPPERBOUND);
				createEAttribute(ETypedElementEClass, ETYPEDELEMENT_MANY);
				createEAttribute(ETypedElementEClass, ETYPEDELEMENT_REQUIRED);
				createEReference(ETypedElementEClass, ETYPEDELEMENT_ETYPE);
				createEReference(ETypedElementEClass, ETYPEDELEMENT_EGENERICTYPE);
				EStringToStringMapEntryEClass = createEClass(ESTRINGTOSTRINGMAPENTRY);
				createEAttribute(EStringToStringMapEntryEClass, ESTRINGTOSTRINGMAPENTRY_KEY);
				createEAttribute(EStringToStringMapEntryEClass, ESTRINGTOSTRINGMAPENTRY_VALUE);
				EGenericTypeEClass = createEClass(EGENERICTYPE);
				createEReference(EGenericTypeEClass, EGENERICTYPE_EUPPERBOUND);
				createEReference(EGenericTypeEClass, EGENERICTYPE_ETYPEARGUMENTS);
				createEReference(EGenericTypeEClass, EGENERICTYPE_ERAWTYPE);
				createEReference(EGenericTypeEClass, EGENERICTYPE_ELOWERBOUND);
				createEReference(EGenericTypeEClass, EGENERICTYPE_ETYPEPARAMETER);
				createEReference(EGenericTypeEClass, EGENERICTYPE_ECLASSIFIER);
				ETypeParameterEClass = createEClass(ETYPEPARAMETER);
				createEReference(ETypeParameterEClass, ETYPEPARAMETER_EBOUNDS);
				
				
				EBigDecimalEDataType = createEDataType(EBIGDECIMAL);
				EBigIntegerEDataType = createEDataType(EBIGINTEGER);
				EBooleanEDataType = createEDataType(EBOOLEAN);
				EBooleanObjectEDataType = createEDataType(EBOOLEANOBJECT);
				EByteEDataType = createEDataType(EBYTE);
				EByteArrayEDataType = createEDataType(EBYTEARRAY);
				EByteObjectEDataType = createEDataType(EBYTEOBJECT);
				ECharEDataType = createEDataType(ECHAR);
				ECharacterObjectEDataType = createEDataType(ECHARACTEROBJECT);
				EDateEDataType = createEDataType(EDATE);
				EDiagnosticChainEDataType = createEDataType(EDIAGNOSTICCHAIN);
				EDoubleEDataType = createEDataType(EDOUBLE);
				EDoubleObjectEDataType = createEDataType(EDOUBLEOBJECT);
				EEListEDataType = createEDataType(EELIST);
				EEnumeratorEDataType = createEDataType(EENUMERATOR);
				EFeatureMapEDataType = createEDataType(EFEATUREMAP);
				EFeatureMapEntryEDataType = createEDataType(EFEATUREMAPENTRY);
				EFloatEDataType = createEDataType(EFLOAT);
				EFloatObjectEDataType = createEDataType(EFLOATOBJECT);
				EIntEDataType = createEDataType(EINT);
				EIntegerObjectEDataType = createEDataType(EINTEGEROBJECT);
				EJavaClassEDataType = createEDataType(EJAVACLASS);
				EJavaObjectEDataType = createEDataType(EJAVAOBJECT);
				ELongEDataType = createEDataType(ELONG);
				ELongObjectEDataType = createEDataType(ELONGOBJECT);
				EMapEDataType = createEDataType(EMAP);
				EResourceEDataType = createEDataType(ERESOURCE);
				EResourceSetEDataType = createEDataType(ERESOURCESET);
				EShortEDataType = createEDataType(ESHORT);
				EShortObjectEDataType = createEDataType(ESHORTOBJECT);
				EStringEDataType = createEDataType(ESTRING);
				ETreeIteratorEDataType = createEDataType(ETREEITERATOR);
				EInvocationTargetExceptionEDataType = createEDataType(EINVOCATIONTARGETEXCEPTION);
				
				EStringEDataType = createEDataType(ESTRING);
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
	
				
				EAttributeEClass.eSuperTypes.add(getEStructuralFeature());
											
				
				EAnnotationEClass.eSuperTypes.add(getEModelElement());
											
				
				EClassEClass.eSuperTypes.add(getEClassifier());
											
				
				EClassifierEClass.eSuperTypes.add(getENamedElement());
											
				
				EDataTypeEClass.eSuperTypes.add(getEClassifier());
											
				
				EEnumEClass.eSuperTypes.add(getEDataType());
											
				
				EEnumLiteralEClass.eSuperTypes.add(getENamedElement());
											
				
				EFactoryEClass.eSuperTypes.add(getEModelElement());
											
				
				
				ENamedElementEClass.eSuperTypes.add(getEModelElement());
											
				
				
				EOperationEClass.eSuperTypes.add(getETypedElement());
											
				
				EPackageEClass.eSuperTypes.add(getENamedElement());
											
				
				EParameterEClass.eSuperTypes.add(getETypedElement());
											
				
				EReferenceEClass.eSuperTypes.add(getEStructuralFeature());
											
				
				EStructuralFeatureEClass.eSuperTypes.add(getETypedElement());
											
				
				ETypedElementEClass.eSuperTypes.add(getENamedElement());
											
				
				
				
				ETypeParameterEClass.eSuperTypes.add(getENamedElement());
											
				
				initEClass(EAttributeEClass, typeof(EAttribute), "EAttribute", !IS_ABSTRACT, !IS_INTERFACE, IS_GENERATED_INSTANCE_CLASS);						
				
				initEAttribute(getEAttribute_ID(), 
					ecorePackage.getEBoolean(), 
					"iD", 
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
					!IS_DERIVED, 
					IS_ORDERED);
				
				initEReference(
					getEAttribute_EAttributeType(), 
					ecorePackage.getEDataType(), 
					null, 
					"eAttributeType", 
					null, 
					1, 
					1, 
					typeof(EAttribute), 
					IS_TRANSIENT, 
					IS_VOLATILE, 
					!IS_CHANGEABLE, 
					!IS_COMPOSITE, 
					IS_RESOLVE_PROXIES, 
					!IS_UNSETTABLE, 
					IS_UNIQUE, 
					IS_DERIVED, 
					IS_ORDERED);
				initEClass(EAnnotationEClass, typeof(EAnnotation), "EAnnotation", !IS_ABSTRACT, !IS_INTERFACE, IS_GENERATED_INSTANCE_CLASS);						
				
				initEAttribute(getEAnnotation_Source(), 
					ecorePackage.getEString(), 
					"source", 
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
				
				initEReference(
					getEAnnotation_Details(), 
					ecorePackage.getEStringToStringMapEntry(), 
					null, 
					"details", 
					null, 
					0, 
					-1, 
					typeof(EAnnotation), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					IS_COMPOSITE, 
					!IS_RESOLVE_PROXIES, 
					!IS_UNSETTABLE, 
					IS_UNIQUE, 
					!IS_DERIVED, 
					IS_ORDERED);
				initEReference(
					getEAnnotation_EModelElement(), 
					ecorePackage.getEModelElement(), 
					getEModelElement_EAnnotations(), 
					"eModelElement", 
					null, 
					0, 
					1, 
					typeof(EAnnotation), 
					IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					!IS_COMPOSITE, 
					!IS_RESOLVE_PROXIES, 
					!IS_UNSETTABLE, 
					IS_UNIQUE, 
					!IS_DERIVED, 
					IS_ORDERED);
				initEReference(
					getEAnnotation_Contents(), 
					ecorePackage.getEObject(), 
					null, 
					"contents", 
					null, 
					0, 
					-1, 
					typeof(EAnnotation), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					IS_COMPOSITE, 
					!IS_RESOLVE_PROXIES, 
					!IS_UNSETTABLE, 
					IS_UNIQUE, 
					!IS_DERIVED, 
					IS_ORDERED);
				initEReference(
					getEAnnotation_References(), 
					ecorePackage.getEObject(), 
					null, 
					"references", 
					null, 
					0, 
					-1, 
					typeof(EAnnotation), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					!IS_COMPOSITE, 
					IS_RESOLVE_PROXIES, 
					!IS_UNSETTABLE, 
					IS_UNIQUE, 
					!IS_DERIVED, 
					IS_ORDERED);
				initEClass(EClassEClass, typeof(EClass), "EClass", !IS_ABSTRACT, !IS_INTERFACE, IS_GENERATED_INSTANCE_CLASS);						
				
				initEAttribute(getEClass_Abstract(), 
					ecorePackage.getEBoolean(), 
					"abstract_", 
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
					!IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getEClass_Interface(), 
					ecorePackage.getEBoolean(), 
					"interface_", 
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
					!IS_DERIVED, 
					IS_ORDERED);
				
				initEReference(
					getEClass_ESuperTypes(), 
					ecorePackage.getEClass(), 
					null, 
					"eSuperTypes", 
					null, 
					0, 
					-1, 
					typeof(EClass), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					!IS_COMPOSITE, 
					IS_RESOLVE_PROXIES, 
					IS_UNSETTABLE, 
					IS_UNIQUE, 
					!IS_DERIVED, 
					IS_ORDERED);
				initEReference(
					getEClass_EOperations(), 
					ecorePackage.getEOperation(), 
					getEOperation_EContainingClass(), 
					"eOperations", 
					null, 
					0, 
					-1, 
					typeof(EClass), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					IS_COMPOSITE, 
					!IS_RESOLVE_PROXIES, 
					!IS_UNSETTABLE, 
					IS_UNIQUE, 
					!IS_DERIVED, 
					IS_ORDERED);
				initEReference(
					getEClass_EAllAttributes(), 
					ecorePackage.getEAttribute(), 
					null, 
					"eAllAttributes", 
					null, 
					0, 
					-1, 
					typeof(EClass), 
					IS_TRANSIENT, 
					IS_VOLATILE, 
					!IS_CHANGEABLE, 
					!IS_COMPOSITE, 
					IS_RESOLVE_PROXIES, 
					!IS_UNSETTABLE, 
					IS_UNIQUE, 
					IS_DERIVED, 
					IS_ORDERED);
				initEReference(
					getEClass_EAllReferences(), 
					ecorePackage.getEReference(), 
					null, 
					"eAllReferences", 
					null, 
					0, 
					-1, 
					typeof(EClass), 
					IS_TRANSIENT, 
					IS_VOLATILE, 
					!IS_CHANGEABLE, 
					!IS_COMPOSITE, 
					IS_RESOLVE_PROXIES, 
					!IS_UNSETTABLE, 
					IS_UNIQUE, 
					IS_DERIVED, 
					IS_ORDERED);
				initEReference(
					getEClass_EReferences(), 
					ecorePackage.getEReference(), 
					null, 
					"eReferences", 
					null, 
					0, 
					-1, 
					typeof(EClass), 
					IS_TRANSIENT, 
					IS_VOLATILE, 
					!IS_CHANGEABLE, 
					!IS_COMPOSITE, 
					IS_RESOLVE_PROXIES, 
					!IS_UNSETTABLE, 
					IS_UNIQUE, 
					IS_DERIVED, 
					IS_ORDERED);
				initEReference(
					getEClass_EAttributes(), 
					ecorePackage.getEAttribute(), 
					null, 
					"eAttributes", 
					null, 
					0, 
					-1, 
					typeof(EClass), 
					IS_TRANSIENT, 
					IS_VOLATILE, 
					!IS_CHANGEABLE, 
					!IS_COMPOSITE, 
					IS_RESOLVE_PROXIES, 
					!IS_UNSETTABLE, 
					IS_UNIQUE, 
					IS_DERIVED, 
					IS_ORDERED);
				initEReference(
					getEClass_EAllContainments(), 
					ecorePackage.getEReference(), 
					null, 
					"eAllContainments", 
					null, 
					0, 
					-1, 
					typeof(EClass), 
					IS_TRANSIENT, 
					IS_VOLATILE, 
					!IS_CHANGEABLE, 
					!IS_COMPOSITE, 
					IS_RESOLVE_PROXIES, 
					!IS_UNSETTABLE, 
					IS_UNIQUE, 
					IS_DERIVED, 
					IS_ORDERED);
				initEReference(
					getEClass_EAllOperations(), 
					ecorePackage.getEOperation(), 
					null, 
					"eAllOperations", 
					null, 
					0, 
					-1, 
					typeof(EClass), 
					IS_TRANSIENT, 
					IS_VOLATILE, 
					!IS_CHANGEABLE, 
					!IS_COMPOSITE, 
					IS_RESOLVE_PROXIES, 
					!IS_UNSETTABLE, 
					IS_UNIQUE, 
					IS_DERIVED, 
					IS_ORDERED);
				initEReference(
					getEClass_EAllStructuralFeatures(), 
					ecorePackage.getEStructuralFeature(), 
					null, 
					"eAllStructuralFeatures", 
					null, 
					0, 
					-1, 
					typeof(EClass), 
					IS_TRANSIENT, 
					IS_VOLATILE, 
					!IS_CHANGEABLE, 
					!IS_COMPOSITE, 
					IS_RESOLVE_PROXIES, 
					!IS_UNSETTABLE, 
					IS_UNIQUE, 
					IS_DERIVED, 
					IS_ORDERED);
				initEReference(
					getEClass_EAllSuperTypes(), 
					ecorePackage.getEClass(), 
					null, 
					"eAllSuperTypes", 
					null, 
					0, 
					-1, 
					typeof(EClass), 
					IS_TRANSIENT, 
					IS_VOLATILE, 
					!IS_CHANGEABLE, 
					!IS_COMPOSITE, 
					IS_RESOLVE_PROXIES, 
					!IS_UNSETTABLE, 
					IS_UNIQUE, 
					IS_DERIVED, 
					IS_ORDERED);
				initEReference(
					getEClass_EIDAttribute(), 
					ecorePackage.getEAttribute(), 
					null, 
					"eIDAttribute", 
					null, 
					0, 
					1, 
					typeof(EClass), 
					IS_TRANSIENT, 
					IS_VOLATILE, 
					!IS_CHANGEABLE, 
					!IS_COMPOSITE, 
					!IS_RESOLVE_PROXIES, 
					!IS_UNSETTABLE, 
					IS_UNIQUE, 
					IS_DERIVED, 
					IS_ORDERED);
				initEReference(
					getEClass_EStructuralFeatures(), 
					ecorePackage.getEStructuralFeature(), 
					getEStructuralFeature_EContainingClass(), 
					"eStructuralFeatures", 
					null, 
					0, 
					-1, 
					typeof(EClass), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					IS_COMPOSITE, 
					!IS_RESOLVE_PROXIES, 
					!IS_UNSETTABLE, 
					IS_UNIQUE, 
					!IS_DERIVED, 
					IS_ORDERED);
				initEReference(
					getEClass_EGenericSuperTypes(), 
					ecorePackage.getEGenericType(), 
					null, 
					"eGenericSuperTypes", 
					null, 
					0, 
					-1, 
					typeof(EClass), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					IS_COMPOSITE, 
					!IS_RESOLVE_PROXIES, 
					IS_UNSETTABLE, 
					IS_UNIQUE, 
					!IS_DERIVED, 
					IS_ORDERED);
				initEReference(
					getEClass_EAllGenericSuperTypes(), 
					ecorePackage.getEGenericType(), 
					null, 
					"eAllGenericSuperTypes", 
					null, 
					0, 
					-1, 
					typeof(EClass), 
					IS_TRANSIENT, 
					IS_VOLATILE, 
					!IS_CHANGEABLE, 
					!IS_COMPOSITE, 
					IS_RESOLVE_PROXIES, 
					!IS_UNSETTABLE, 
					IS_UNIQUE, 
					IS_DERIVED, 
					IS_ORDERED);
				initEClass(EClassifierEClass, typeof(EClassifier), "EClassifier", IS_ABSTRACT, !IS_INTERFACE, IS_GENERATED_INSTANCE_CLASS);						
				
				initEAttribute(getEClassifier_InstanceClassName(), 
					ecorePackage.getEString(), 
					"instanceClassName", 
					null, 
					0, 
					1, 
					typeof(EAttribute), 
					!IS_TRANSIENT, 
					IS_VOLATILE, 
					IS_CHANGEABLE, 
					IS_UNSETTABLE, 
					!IS_ID, 
					IS_UNIQUE, 
					!IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getEClassifier_InstanceClass(), 
					ecorePackage.getEJavaClass(), 
					"instanceClass", 
					null, 
					0, 
					1, 
					typeof(EAttribute), 
					IS_TRANSIENT, 
					IS_VOLATILE, 
					!IS_CHANGEABLE, 
					!IS_UNSETTABLE, 
					!IS_ID, 
					IS_UNIQUE, 
					IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getEClassifier_DefaultValue(), 
					ecorePackage.getEJavaObject(), 
					"defaultValue", 
					null, 
					0, 
					1, 
					typeof(EAttribute), 
					IS_TRANSIENT, 
					IS_VOLATILE, 
					!IS_CHANGEABLE, 
					!IS_UNSETTABLE, 
					!IS_ID, 
					IS_UNIQUE, 
					IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getEClassifier_InstanceTypeName(), 
					ecorePackage.getEString(), 
					"instanceTypeName", 
					null, 
					0, 
					1, 
					typeof(EAttribute), 
					!IS_TRANSIENT, 
					IS_VOLATILE, 
					IS_CHANGEABLE, 
					IS_UNSETTABLE, 
					!IS_ID, 
					IS_UNIQUE, 
					!IS_DERIVED, 
					IS_ORDERED);
				
				initEReference(
					getEClassifier_EPackage(), 
					ecorePackage.getEPackage(), 
					getEPackage_EClassifiers(), 
					"ePackage", 
					null, 
					0, 
					1, 
					typeof(EClassifier), 
					IS_TRANSIENT, 
					!IS_VOLATILE, 
					!IS_CHANGEABLE, 
					!IS_COMPOSITE, 
					IS_RESOLVE_PROXIES, 
					!IS_UNSETTABLE, 
					IS_UNIQUE, 
					!IS_DERIVED, 
					IS_ORDERED);
				initEReference(
					getEClassifier_ETypeParameters(), 
					ecorePackage.getETypeParameter(), 
					null, 
					"eTypeParameters", 
					null, 
					0, 
					-1, 
					typeof(EClassifier), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					IS_COMPOSITE, 
					IS_RESOLVE_PROXIES, 
					!IS_UNSETTABLE, 
					IS_UNIQUE, 
					!IS_DERIVED, 
					IS_ORDERED);
				initEClass(EDataTypeEClass, typeof(EDataType), "EDataType", !IS_ABSTRACT, !IS_INTERFACE, IS_GENERATED_INSTANCE_CLASS);						
				
				initEAttribute(getEDataType_Serializable(), 
					ecorePackage.getEBoolean(), 
					"serializable", 
					"true", 
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
				
				initEClass(EEnumEClass, typeof(EEnum), "EEnum", !IS_ABSTRACT, !IS_INTERFACE, IS_GENERATED_INSTANCE_CLASS);						
				
				
				initEReference(
					getEEnum_ELiterals(), 
					ecorePackage.getEEnumLiteral(), 
					getEEnumLiteral_EEnum(), 
					"eLiterals", 
					null, 
					0, 
					-1, 
					typeof(EEnum), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					IS_COMPOSITE, 
					!IS_RESOLVE_PROXIES, 
					!IS_UNSETTABLE, 
					IS_UNIQUE, 
					!IS_DERIVED, 
					IS_ORDERED);
				initEClass(EEnumLiteralEClass, typeof(EEnumLiteral), "EEnumLiteral", !IS_ABSTRACT, !IS_INTERFACE, IS_GENERATED_INSTANCE_CLASS);						
				
				initEAttribute(getEEnumLiteral_Value(), 
					ecorePackage.getEInt(), 
					"value", 
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
					!IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getEEnumLiteral_Instance(), 
					ecorePackage.getEEnumerator(), 
					"instance", 
					null, 
					0, 
					1, 
					typeof(EAttribute), 
					IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					!IS_UNSETTABLE, 
					!IS_ID, 
					IS_UNIQUE, 
					!IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getEEnumLiteral_Literal(), 
					ecorePackage.getEString(), 
					"literal", 
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
				
				initEReference(
					getEEnumLiteral_EEnum(), 
					ecorePackage.getEEnum(), 
					getEEnum_ELiterals(), 
					"eEnum", 
					null, 
					0, 
					1, 
					typeof(EEnumLiteral), 
					IS_TRANSIENT, 
					!IS_VOLATILE, 
					!IS_CHANGEABLE, 
					!IS_COMPOSITE, 
					!IS_RESOLVE_PROXIES, 
					!IS_UNSETTABLE, 
					IS_UNIQUE, 
					!IS_DERIVED, 
					IS_ORDERED);
				initEClass(EFactoryEClass, typeof(EFactory), "EFactory", !IS_ABSTRACT, !IS_INTERFACE, IS_GENERATED_INSTANCE_CLASS);						
				
				
				initEReference(
					getEFactory_EPackage(), 
					ecorePackage.getEPackage(), 
					getEPackage_EFactoryInstance(), 
					"ePackage", 
					null, 
					1, 
					1, 
					typeof(EFactory), 
					IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					!IS_COMPOSITE, 
					!IS_RESOLVE_PROXIES, 
					!IS_UNSETTABLE, 
					IS_UNIQUE, 
					!IS_DERIVED, 
					IS_ORDERED);
				initEClass(EModelElementEClass, typeof(EModelElement), "EModelElement", IS_ABSTRACT, !IS_INTERFACE, IS_GENERATED_INSTANCE_CLASS);						
				
				
				initEReference(
					getEModelElement_EAnnotations(), 
					ecorePackage.getEAnnotation(), 
					getEAnnotation_EModelElement(), 
					"eAnnotations", 
					null, 
					0, 
					-1, 
					typeof(EModelElement), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					IS_COMPOSITE, 
					!IS_RESOLVE_PROXIES, 
					!IS_UNSETTABLE, 
					IS_UNIQUE, 
					!IS_DERIVED, 
					IS_ORDERED);
				initEClass(ENamedElementEClass, typeof(ENamedElement), "ENamedElement", IS_ABSTRACT, !IS_INTERFACE, IS_GENERATED_INSTANCE_CLASS);						
				
				initEAttribute(getENamedElement_Name(), 
					ecorePackage.getEString(), 
					"name", 
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
				
				initEClass(EObjectEClass, typeof(EObject), "EObject", !IS_ABSTRACT, !IS_INTERFACE, IS_GENERATED_INSTANCE_CLASS);						
				
				
				initEClass(EOperationEClass, typeof(EOperation), "EOperation", !IS_ABSTRACT, !IS_INTERFACE, IS_GENERATED_INSTANCE_CLASS);						
				
				
				initEReference(
					getEOperation_EContainingClass(), 
					ecorePackage.getEClass(), 
					getEClass_EOperations(), 
					"eContainingClass", 
					null, 
					0, 
					1, 
					typeof(EOperation), 
					IS_TRANSIENT, 
					!IS_VOLATILE, 
					!IS_CHANGEABLE, 
					!IS_COMPOSITE, 
					!IS_RESOLVE_PROXIES, 
					!IS_UNSETTABLE, 
					IS_UNIQUE, 
					!IS_DERIVED, 
					IS_ORDERED);
				initEReference(
					getEOperation_ETypeParameters(), 
					ecorePackage.getETypeParameter(), 
					null, 
					"eTypeParameters", 
					null, 
					0, 
					-1, 
					typeof(EOperation), 
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
					getEOperation_EParameters(), 
					ecorePackage.getEParameter(), 
					getEParameter_EOperation(), 
					"eParameters", 
					null, 
					0, 
					-1, 
					typeof(EOperation), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					IS_COMPOSITE, 
					!IS_RESOLVE_PROXIES, 
					!IS_UNSETTABLE, 
					IS_UNIQUE, 
					!IS_DERIVED, 
					IS_ORDERED);
				initEReference(
					getEOperation_EExceptions(), 
					ecorePackage.getEClassifier(), 
					null, 
					"eExceptions", 
					null, 
					0, 
					-1, 
					typeof(EOperation), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					!IS_COMPOSITE, 
					IS_RESOLVE_PROXIES, 
					IS_UNSETTABLE, 
					IS_UNIQUE, 
					!IS_DERIVED, 
					IS_ORDERED);
				initEReference(
					getEOperation_EGenericExceptions(), 
					ecorePackage.getEGenericType(), 
					null, 
					"eGenericExceptions", 
					null, 
					0, 
					-1, 
					typeof(EOperation), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					IS_COMPOSITE, 
					!IS_RESOLVE_PROXIES, 
					IS_UNSETTABLE, 
					IS_UNIQUE, 
					!IS_DERIVED, 
					IS_ORDERED);
				initEClass(EPackageEClass, typeof(EPackage), "EPackage", !IS_ABSTRACT, !IS_INTERFACE, IS_GENERATED_INSTANCE_CLASS);						
				
				initEAttribute(getEPackage_NsURI(), 
					ecorePackage.getEString(), 
					"nsURI", 
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
				initEAttribute(getEPackage_NsPrefix(), 
					ecorePackage.getEString(), 
					"nsPrefix", 
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
				
				initEReference(
					getEPackage_EFactoryInstance(), 
					ecorePackage.getEFactory(), 
					getEFactory_EPackage(), 
					"eFactoryInstance", 
					null, 
					1, 
					1, 
					typeof(EPackage), 
					IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					!IS_COMPOSITE, 
					!IS_RESOLVE_PROXIES, 
					!IS_UNSETTABLE, 
					IS_UNIQUE, 
					!IS_DERIVED, 
					IS_ORDERED);
				initEReference(
					getEPackage_EClassifiers(), 
					ecorePackage.getEClassifier(), 
					getEClassifier_EPackage(), 
					"eClassifiers", 
					null, 
					0, 
					-1, 
					typeof(EPackage), 
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
					getEPackage_ESubpackages(), 
					ecorePackage.getEPackage(), 
					getEPackage_ESuperPackage(), 
					"eSubpackages", 
					null, 
					0, 
					-1, 
					typeof(EPackage), 
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
					getEPackage_ESuperPackage(), 
					ecorePackage.getEPackage(), 
					getEPackage_ESubpackages(), 
					"eSuperPackage", 
					null, 
					0, 
					1, 
					typeof(EPackage), 
					IS_TRANSIENT, 
					!IS_VOLATILE, 
					!IS_CHANGEABLE, 
					!IS_COMPOSITE, 
					IS_RESOLVE_PROXIES, 
					!IS_UNSETTABLE, 
					IS_UNIQUE, 
					!IS_DERIVED, 
					IS_ORDERED);
				initEClass(EParameterEClass, typeof(EParameter), "EParameter", !IS_ABSTRACT, !IS_INTERFACE, IS_GENERATED_INSTANCE_CLASS);						
				
				
				initEReference(
					getEParameter_EOperation(), 
					ecorePackage.getEOperation(), 
					getEOperation_EParameters(), 
					"eOperation", 
					null, 
					0, 
					1, 
					typeof(EParameter), 
					IS_TRANSIENT, 
					!IS_VOLATILE, 
					!IS_CHANGEABLE, 
					!IS_COMPOSITE, 
					!IS_RESOLVE_PROXIES, 
					!IS_UNSETTABLE, 
					IS_UNIQUE, 
					!IS_DERIVED, 
					IS_ORDERED);
				initEClass(EReferenceEClass, typeof(EReference), "EReference", !IS_ABSTRACT, !IS_INTERFACE, IS_GENERATED_INSTANCE_CLASS);						
				
				initEAttribute(getEReference_Containment(), 
					ecorePackage.getEBoolean(), 
					"containment", 
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
					!IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getEReference_Container(), 
					ecorePackage.getEBoolean(), 
					"container", 
					"false", 
					0, 
					1, 
					typeof(EAttribute), 
					IS_TRANSIENT, 
					IS_VOLATILE, 
					!IS_CHANGEABLE, 
					!IS_UNSETTABLE, 
					!IS_ID, 
					IS_UNIQUE, 
					IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getEReference_ResolveProxies(), 
					ecorePackage.getEBoolean(), 
					"resolveProxies", 
					"true", 
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
				
				initEReference(
					getEReference_EOpposite(), 
					ecorePackage.getEReference(), 
					null, 
					"eOpposite", 
					null, 
					0, 
					1, 
					typeof(EReference), 
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
					getEReference_EReferenceType(), 
					ecorePackage.getEClass(), 
					null, 
					"eReferenceType", 
					null, 
					1, 
					1, 
					typeof(EReference), 
					IS_TRANSIENT, 
					IS_VOLATILE, 
					!IS_CHANGEABLE, 
					!IS_COMPOSITE, 
					IS_RESOLVE_PROXIES, 
					!IS_UNSETTABLE, 
					IS_UNIQUE, 
					IS_DERIVED, 
					IS_ORDERED);
				initEReference(
					getEReference_EKeys(), 
					ecorePackage.getEAttribute(), 
					null, 
					"eKeys", 
					null, 
					0, 
					-1, 
					typeof(EReference), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					!IS_COMPOSITE, 
					IS_RESOLVE_PROXIES, 
					!IS_UNSETTABLE, 
					IS_UNIQUE, 
					!IS_DERIVED, 
					IS_ORDERED);
				initEClass(EStructuralFeatureEClass, typeof(EStructuralFeature), "EStructuralFeature", IS_ABSTRACT, !IS_INTERFACE, IS_GENERATED_INSTANCE_CLASS);						
				
				initEAttribute(getEStructuralFeature_Changeable(), 
					ecorePackage.getEBoolean(), 
					"changeable", 
					"true", 
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
				initEAttribute(getEStructuralFeature_Volatile(), 
					ecorePackage.getEBoolean(), 
					"volatile_", 
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
					!IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getEStructuralFeature_Transient(), 
					ecorePackage.getEBoolean(), 
					"transient", 
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
					!IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getEStructuralFeature_DefaultValueLiteral(), 
					ecorePackage.getEString(), 
					"defaultValueLiteral", 
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
				initEAttribute(getEStructuralFeature_DefaultValue(), 
					ecorePackage.getEJavaObject(), 
					"defaultValue", 
					null, 
					0, 
					1, 
					typeof(EAttribute), 
					IS_TRANSIENT, 
					IS_VOLATILE, 
					!IS_CHANGEABLE, 
					!IS_UNSETTABLE, 
					!IS_ID, 
					IS_UNIQUE, 
					IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getEStructuralFeature_Unsettable(), 
					ecorePackage.getEBoolean(), 
					"unsettable", 
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
					!IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getEStructuralFeature_Derived(), 
					ecorePackage.getEBoolean(), 
					"derived", 
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
					!IS_DERIVED, 
					IS_ORDERED);
				
				initEReference(
					getEStructuralFeature_EContainingClass(), 
					ecorePackage.getEClass(), 
					getEClass_EStructuralFeatures(), 
					"eContainingClass", 
					null, 
					0, 
					1, 
					typeof(EStructuralFeature), 
					IS_TRANSIENT, 
					!IS_VOLATILE, 
					!IS_CHANGEABLE, 
					!IS_COMPOSITE, 
					!IS_RESOLVE_PROXIES, 
					!IS_UNSETTABLE, 
					IS_UNIQUE, 
					!IS_DERIVED, 
					IS_ORDERED);
				initEClass(ETypedElementEClass, typeof(ETypedElement), "ETypedElement", IS_ABSTRACT, !IS_INTERFACE, IS_GENERATED_INSTANCE_CLASS);						
				
				initEAttribute(getETypedElement_Ordered(), 
					ecorePackage.getEBoolean(), 
					"ordered", 
					"true", 
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
				initEAttribute(getETypedElement_Unique(), 
					ecorePackage.getEBoolean(), 
					"unique", 
					"true", 
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
				initEAttribute(getETypedElement_LowerBound(), 
					ecorePackage.getEInt(), 
					"lowerBound", 
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
					!IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getETypedElement_UpperBound(), 
					ecorePackage.getEInt(), 
					"upperBound", 
					"1", 
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
				initEAttribute(getETypedElement_Many(), 
					ecorePackage.getEBoolean(), 
					"many", 
					"false", 
					0, 
					1, 
					typeof(EAttribute), 
					IS_TRANSIENT, 
					IS_VOLATILE, 
					!IS_CHANGEABLE, 
					!IS_UNSETTABLE, 
					!IS_ID, 
					IS_UNIQUE, 
					IS_DERIVED, 
					IS_ORDERED);
				initEAttribute(getETypedElement_Required(), 
					ecorePackage.getEBoolean(), 
					"required", 
					"false", 
					0, 
					1, 
					typeof(EAttribute), 
					IS_TRANSIENT, 
					IS_VOLATILE, 
					!IS_CHANGEABLE, 
					!IS_UNSETTABLE, 
					!IS_ID, 
					IS_UNIQUE, 
					IS_DERIVED, 
					IS_ORDERED);
				
				initEReference(
					getETypedElement_EType(), 
					ecorePackage.getEClassifier(), 
					null, 
					"eType", 
					null, 
					0, 
					1, 
					typeof(ETypedElement), 
					!IS_TRANSIENT, 
					IS_VOLATILE, 
					IS_CHANGEABLE, 
					!IS_COMPOSITE, 
					IS_RESOLVE_PROXIES, 
					IS_UNSETTABLE, 
					IS_UNIQUE, 
					!IS_DERIVED, 
					IS_ORDERED);
				initEReference(
					getETypedElement_EGenericType(), 
					ecorePackage.getEGenericType(), 
					null, 
					"eGenericType", 
					null, 
					0, 
					1, 
					typeof(ETypedElement), 
					!IS_TRANSIENT, 
					IS_VOLATILE, 
					IS_CHANGEABLE, 
					IS_COMPOSITE, 
					!IS_RESOLVE_PROXIES, 
					IS_UNSETTABLE, 
					IS_UNIQUE, 
					!IS_DERIVED, 
					IS_ORDERED);
				initEClass(EStringToStringMapEntryEClass, typeof(EStringToStringMapEntry), "EStringToStringMapEntry", !IS_ABSTRACT, !IS_INTERFACE, IS_GENERATED_INSTANCE_CLASS);						
				
				initEAttribute(getEStringToStringMapEntry_Key(), 
					ecorePackage.getEString(), 
					"key", 
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
				initEAttribute(getEStringToStringMapEntry_Value(), 
					ecorePackage.getEString(), 
					"value", 
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
				
				initEClass(EGenericTypeEClass, typeof(EGenericType), "EGenericType", !IS_ABSTRACT, !IS_INTERFACE, IS_GENERATED_INSTANCE_CLASS);						
				
				
				initEReference(
					getEGenericType_EUpperBound(), 
					ecorePackage.getEGenericType(), 
					null, 
					"eUpperBound", 
					null, 
					0, 
					1, 
					typeof(EGenericType), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					IS_COMPOSITE, 
					!IS_RESOLVE_PROXIES, 
					!IS_UNSETTABLE, 
					IS_UNIQUE, 
					!IS_DERIVED, 
					IS_ORDERED);
				initEReference(
					getEGenericType_ETypeArguments(), 
					ecorePackage.getEGenericType(), 
					null, 
					"eTypeArguments", 
					null, 
					0, 
					-1, 
					typeof(EGenericType), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					IS_COMPOSITE, 
					!IS_RESOLVE_PROXIES, 
					!IS_UNSETTABLE, 
					IS_UNIQUE, 
					!IS_DERIVED, 
					IS_ORDERED);
				initEReference(
					getEGenericType_ERawType(), 
					ecorePackage.getEClassifier(), 
					null, 
					"eRawType", 
					null, 
					1, 
					1, 
					typeof(EGenericType), 
					IS_TRANSIENT, 
					!IS_VOLATILE, 
					!IS_CHANGEABLE, 
					!IS_COMPOSITE, 
					IS_RESOLVE_PROXIES, 
					!IS_UNSETTABLE, 
					IS_UNIQUE, 
					IS_DERIVED, 
					IS_ORDERED);
				initEReference(
					getEGenericType_ELowerBound(), 
					ecorePackage.getEGenericType(), 
					null, 
					"eLowerBound", 
					null, 
					0, 
					1, 
					typeof(EGenericType), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					IS_COMPOSITE, 
					!IS_RESOLVE_PROXIES, 
					!IS_UNSETTABLE, 
					IS_UNIQUE, 
					!IS_DERIVED, 
					IS_ORDERED);
				initEReference(
					getEGenericType_ETypeParameter(), 
					ecorePackage.getETypeParameter(), 
					null, 
					"eTypeParameter", 
					null, 
					0, 
					1, 
					typeof(EGenericType), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					!IS_COMPOSITE, 
					!IS_RESOLVE_PROXIES, 
					!IS_UNSETTABLE, 
					IS_UNIQUE, 
					!IS_DERIVED, 
					IS_ORDERED);
				initEReference(
					getEGenericType_EClassifier(), 
					ecorePackage.getEClassifier(), 
					null, 
					"eClassifier", 
					null, 
					0, 
					1, 
					typeof(EGenericType), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					!IS_COMPOSITE, 
					IS_RESOLVE_PROXIES, 
					!IS_UNSETTABLE, 
					IS_UNIQUE, 
					!IS_DERIVED, 
					IS_ORDERED);
				initEClass(ETypeParameterEClass, typeof(ETypeParameter), "ETypeParameter", !IS_ABSTRACT, !IS_INTERFACE, IS_GENERATED_INSTANCE_CLASS);						
				
				
				initEReference(
					getETypeParameter_EBounds(), 
					ecorePackage.getEGenericType(), 
					null, 
					"eBounds", 
					null, 
					0, 
					-1, 
					typeof(ETypeParameter), 
					!IS_TRANSIENT, 
					!IS_VOLATILE, 
					IS_CHANGEABLE, 
					IS_COMPOSITE, 
					!IS_RESOLVE_PROXIES, 
					!IS_UNSETTABLE, 
					IS_UNIQUE, 
					!IS_DERIVED, 
					IS_ORDERED);
				initEDataType(EBigDecimalEDataType,null, "EBigDecimal", IS_SERIALIZABLE, !IS_GENERATED_INSTANCE_CLASS);
				initEDataType(EBigIntegerEDataType, null, "EBigInteger", IS_SERIALIZABLE, !IS_GENERATED_INSTANCE_CLASS);
				initEDataType(EBooleanEDataType, typeof(bool), "EBoolean", IS_SERIALIZABLE, !IS_GENERATED_INSTANCE_CLASS);
				initEDataType(EBooleanObjectEDataType, typeof(System.Boolean), "EBooleanObject", IS_SERIALIZABLE, !IS_GENERATED_INSTANCE_CLASS);
				initEDataType(EByteEDataType, typeof(byte), "EByte", IS_SERIALIZABLE, !IS_GENERATED_INSTANCE_CLASS);
				initEDataType(EByteArrayEDataType, typeof(byte[]), "EByteArray", IS_SERIALIZABLE, !IS_GENERATED_INSTANCE_CLASS);
				initEDataType(EByteObjectEDataType, typeof(System.Byte), "EByteObject", IS_SERIALIZABLE, !IS_GENERATED_INSTANCE_CLASS);
				initEDataType(ECharEDataType, typeof(char), "EChar", IS_SERIALIZABLE, !IS_GENERATED_INSTANCE_CLASS);
				initEDataType(ECharacterObjectEDataType, typeof(System.Char), "ECharacterObject", IS_SERIALIZABLE, !IS_GENERATED_INSTANCE_CLASS);
				initEDataType(EDateEDataType, typeof(System.DateTime), "EDate", IS_SERIALIZABLE, !IS_GENERATED_INSTANCE_CLASS);
				initEDataType(EDiagnosticChainEDataType, null, "EDiagnosticChain", !IS_SERIALIZABLE, !IS_GENERATED_INSTANCE_CLASS);
				initEDataType(EDoubleEDataType, typeof(double), "EDouble", IS_SERIALIZABLE, !IS_GENERATED_INSTANCE_CLASS);
				initEDataType(EDoubleObjectEDataType, typeof(System.Double), "EDoubleObject", IS_SERIALIZABLE, !IS_GENERATED_INSTANCE_CLASS);
				initEDataType(EEListEDataType, null, "EEList", !IS_SERIALIZABLE, !IS_GENERATED_INSTANCE_CLASS);
				initEDataType(EEnumeratorEDataType, typeof(EEnumerator), "EEnumerator", !IS_SERIALIZABLE, !IS_GENERATED_INSTANCE_CLASS);
				initEDataType(EFeatureMapEDataType, null, "EFeatureMap", !IS_SERIALIZABLE, !IS_GENERATED_INSTANCE_CLASS);
				initEDataType(EFeatureMapEntryEDataType, null, "EFeatureMapEntry", !IS_SERIALIZABLE, !IS_GENERATED_INSTANCE_CLASS);
				initEDataType(EFloatEDataType, typeof(float), "EFloat", IS_SERIALIZABLE, !IS_GENERATED_INSTANCE_CLASS);
				initEDataType(EFloatObjectEDataType, typeof(System.Single), "EFloatObject", IS_SERIALIZABLE, !IS_GENERATED_INSTANCE_CLASS);
				initEDataType(EIntEDataType, typeof(int), "EInt", IS_SERIALIZABLE, !IS_GENERATED_INSTANCE_CLASS);
				initEDataType(EIntegerObjectEDataType, typeof(System.Int32), "EIntegerObject", IS_SERIALIZABLE, !IS_GENERATED_INSTANCE_CLASS);
				initEDataType(EJavaClassEDataType, typeof(System.Type), "EJavaClass", IS_SERIALIZABLE, !IS_GENERATED_INSTANCE_CLASS);
				initEDataType(EJavaObjectEDataType, typeof(object), "EJavaObject", IS_SERIALIZABLE, !IS_GENERATED_INSTANCE_CLASS);
				initEDataType(ELongEDataType, typeof(long), "ELong", IS_SERIALIZABLE, !IS_GENERATED_INSTANCE_CLASS);
				initEDataType(ELongObjectEDataType, typeof(System.Int64), "ELongObject", IS_SERIALIZABLE, !IS_GENERATED_INSTANCE_CLASS);
				initEDataType(EMapEDataType, null, "EMap", !IS_SERIALIZABLE, !IS_GENERATED_INSTANCE_CLASS);
				initEDataType(EResourceEDataType, typeof(Resource), "EResource", !IS_SERIALIZABLE, !IS_GENERATED_INSTANCE_CLASS);
				initEDataType(EResourceSetEDataType, null, "EResourceSet", !IS_SERIALIZABLE, !IS_GENERATED_INSTANCE_CLASS);
				initEDataType(EShortEDataType, typeof(short), "EShort", IS_SERIALIZABLE, !IS_GENERATED_INSTANCE_CLASS);
				initEDataType(EShortObjectEDataType, typeof(System.Single), "EShortObject", IS_SERIALIZABLE, !IS_GENERATED_INSTANCE_CLASS);
				initEDataType(EStringEDataType, typeof(string), "EString", IS_SERIALIZABLE, !IS_GENERATED_INSTANCE_CLASS);
				initEDataType(ETreeIteratorEDataType, null, "ETreeIterator", !IS_SERIALIZABLE, !IS_GENERATED_INSTANCE_CLASS);
				initEDataType(EInvocationTargetExceptionEDataType, null, "EInvocationTargetException", !IS_SERIALIZABLE, !IS_GENERATED_INSTANCE_CLASS);
	        }
	        
			
			private EClass EAttributeEClass = null;
			private EClass EAnnotationEClass = null;
			private EClass EClassEClass = null;
			private EClass EClassifierEClass = null;
			private EClass EDataTypeEClass = null;
			private EClass EEnumEClass = null;
			private EClass EEnumLiteralEClass = null;
			private EClass EFactoryEClass = null;
			private EClass EModelElementEClass = null;
			private EClass ENamedElementEClass = null;
			private EClass EObjectEClass = null;
			private EClass EOperationEClass = null;
			private EClass EPackageEClass = null;
			private EClass EParameterEClass = null;
			private EClass EReferenceEClass = null;
			private EClass EStructuralFeatureEClass = null;
			private EClass ETypedElementEClass = null;
			private EClass EStringToStringMapEntryEClass = null;
			private EClass EGenericTypeEClass = null;
			private EClass ETypeParameterEClass = null;
			
			
			
			private EDataType EBigDecimalEDataType = null;
			private EDataType EBigIntegerEDataType = null;
			private EDataType EBooleanEDataType = null;
			private EDataType EBooleanObjectEDataType = null;
			private EDataType EByteEDataType = null;
			private EDataType EByteArrayEDataType = null;
			private EDataType EByteObjectEDataType = null;
			private EDataType ECharEDataType = null;
			private EDataType ECharacterObjectEDataType = null;
			private EDataType EDateEDataType = null;
			private EDataType EDiagnosticChainEDataType = null;
			private EDataType EDoubleEDataType = null;
			private EDataType EDoubleObjectEDataType = null;
			private EDataType EEListEDataType = null;
			private EDataType EEnumeratorEDataType = null;
			private EDataType EFeatureMapEDataType = null;
			private EDataType EFeatureMapEntryEDataType = null;
			private EDataType EFloatEDataType = null;
			private EDataType EFloatObjectEDataType = null;
			private EDataType EIntEDataType = null;
			private EDataType EIntegerObjectEDataType = null;
			private EDataType EJavaClassEDataType = null;
			private EDataType EJavaObjectEDataType = null;
			private EDataType ELongEDataType = null;
			private EDataType ELongObjectEDataType = null;
			private EDataType EMapEDataType = null;
			private EDataType EResourceEDataType = null;
			private EDataType EResourceSetEDataType = null;
			private EDataType EShortEDataType = null;
			private EDataType EShortObjectEDataType = null;
			private EDataType EStringEDataType = null;
			private EDataType ETreeIteratorEDataType = null;
			private EDataType EInvocationTargetExceptionEDataType = null;
			
			
			public const int EMODELELEMENT = 8;
			public const int EMODELELEMENT_FEATURE_COUNT = 1;
			public const int EMODELELEMENT_OPERATION_COUNT = 1;
			
			public const int EMODELELEMENT_EANNOTATIONS = 0;
			
			public const int ENAMEDELEMENT = 9;
			public const int ENAMEDELEMENT_FEATURE_COUNT = EMODELELEMENT_FEATURE_COUNT + 1;
			public const int ENAMEDELEMENT_OPERATION_COUNT = EMODELELEMENT_OPERATION_COUNT + 0;
			
			public const int ENAMEDELEMENT_EANNOTATIONS = 0;
			public const int ENAMEDELEMENT_NAME = 1;
			
			public const int ETYPEDELEMENT = 16;
			public const int ETYPEDELEMENT_FEATURE_COUNT = ENAMEDELEMENT_FEATURE_COUNT + 8;
			public const int ETYPEDELEMENT_OPERATION_COUNT = ENAMEDELEMENT_OPERATION_COUNT + 0;
			
			public const int ETYPEDELEMENT_EANNOTATIONS = 0;
			public const int ETYPEDELEMENT_NAME = 1;
			public const int ETYPEDELEMENT_ORDERED = 2;
			public const int ETYPEDELEMENT_UNIQUE = 3;
			public const int ETYPEDELEMENT_LOWERBOUND = 4;
			public const int ETYPEDELEMENT_UPPERBOUND = 5;
			public const int ETYPEDELEMENT_MANY = 6;
			public const int ETYPEDELEMENT_REQUIRED = 7;
			public const int ETYPEDELEMENT_ETYPE = 8;
			public const int ETYPEDELEMENT_EGENERICTYPE = 9;
			
			public const int ESTRUCTURALFEATURE = 15;
			public const int ESTRUCTURALFEATURE_FEATURE_COUNT = ETYPEDELEMENT_FEATURE_COUNT + 8;
			public const int ESTRUCTURALFEATURE_OPERATION_COUNT = ETYPEDELEMENT_OPERATION_COUNT + 2;
			
			public const int ESTRUCTURALFEATURE_EANNOTATIONS = 0;
			public const int ESTRUCTURALFEATURE_NAME = 1;
			public const int ESTRUCTURALFEATURE_ORDERED = 2;
			public const int ESTRUCTURALFEATURE_UNIQUE = 3;
			public const int ESTRUCTURALFEATURE_LOWERBOUND = 4;
			public const int ESTRUCTURALFEATURE_UPPERBOUND = 5;
			public const int ESTRUCTURALFEATURE_MANY = 6;
			public const int ESTRUCTURALFEATURE_REQUIRED = 7;
			public const int ESTRUCTURALFEATURE_ETYPE = 8;
			public const int ESTRUCTURALFEATURE_EGENERICTYPE = 9;
			public const int ESTRUCTURALFEATURE_CHANGEABLE = 10;
			public const int ESTRUCTURALFEATURE_VOLATILE = 11;
			public const int ESTRUCTURALFEATURE_TRANSIENT = 12;
			public const int ESTRUCTURALFEATURE_DEFAULTVALUELITERAL = 13;
			public const int ESTRUCTURALFEATURE_DEFAULTVALUE = 14;
			public const int ESTRUCTURALFEATURE_UNSETTABLE = 15;
			public const int ESTRUCTURALFEATURE_DERIVED = 16;
			public const int ESTRUCTURALFEATURE_ECONTAININGCLASS = 17;
			
			public const int EATTRIBUTE = 0;
			public const int EATTRIBUTE_FEATURE_COUNT = ESTRUCTURALFEATURE_FEATURE_COUNT + 2;
			public const int EATTRIBUTE_OPERATION_COUNT = ESTRUCTURALFEATURE_OPERATION_COUNT + 0;
			
			public const int EATTRIBUTE_EANNOTATIONS = 0;
			public const int EATTRIBUTE_NAME = 1;
			public const int EATTRIBUTE_ORDERED = 2;
			public const int EATTRIBUTE_UNIQUE = 3;
			public const int EATTRIBUTE_LOWERBOUND = 4;
			public const int EATTRIBUTE_UPPERBOUND = 5;
			public const int EATTRIBUTE_MANY = 6;
			public const int EATTRIBUTE_REQUIRED = 7;
			public const int EATTRIBUTE_ETYPE = 8;
			public const int EATTRIBUTE_EGENERICTYPE = 9;
			public const int EATTRIBUTE_CHANGEABLE = 10;
			public const int EATTRIBUTE_VOLATILE = 11;
			public const int EATTRIBUTE_TRANSIENT = 12;
			public const int EATTRIBUTE_DEFAULTVALUELITERAL = 13;
			public const int EATTRIBUTE_DEFAULTVALUE = 14;
			public const int EATTRIBUTE_UNSETTABLE = 15;
			public const int EATTRIBUTE_DERIVED = 16;
			public const int EATTRIBUTE_ECONTAININGCLASS = 17;
			public const int EATTRIBUTE_ID = 18;
			public const int EATTRIBUTE_EATTRIBUTETYPE = 19;
			
			public const int EANNOTATION = 1;
			public const int EANNOTATION_FEATURE_COUNT = EMODELELEMENT_FEATURE_COUNT + 5;
			public const int EANNOTATION_OPERATION_COUNT = EMODELELEMENT_OPERATION_COUNT + 0;
			
			public const int EANNOTATION_EANNOTATIONS = 0;
			public const int EANNOTATION_SOURCE = 1;
			public const int EANNOTATION_DETAILS = 2;
			public const int EANNOTATION_EMODELELEMENT = 3;
			public const int EANNOTATION_CONTENTS = 4;
			public const int EANNOTATION_REFERENCES = 5;
			
			public const int ECLASSIFIER = 3;
			public const int ECLASSIFIER_FEATURE_COUNT = ENAMEDELEMENT_FEATURE_COUNT + 6;
			public const int ECLASSIFIER_OPERATION_COUNT = ENAMEDELEMENT_OPERATION_COUNT + 2;
			
			public const int ECLASSIFIER_EANNOTATIONS = 0;
			public const int ECLASSIFIER_NAME = 1;
			public const int ECLASSIFIER_INSTANCECLASSNAME = 2;
			public const int ECLASSIFIER_INSTANCECLASS = 3;
			public const int ECLASSIFIER_DEFAULTVALUE = 4;
			public const int ECLASSIFIER_INSTANCETYPENAME = 5;
			public const int ECLASSIFIER_EPACKAGE = 6;
			public const int ECLASSIFIER_ETYPEPARAMETERS = 7;
			
			public const int ECLASS = 2;
			public const int ECLASS_FEATURE_COUNT = ECLASSIFIER_FEATURE_COUNT + 16;
			public const int ECLASS_OPERATION_COUNT = ECLASSIFIER_OPERATION_COUNT + 10;
			
			public const int ECLASS_EANNOTATIONS = 0;
			public const int ECLASS_NAME = 1;
			public const int ECLASS_INSTANCECLASSNAME = 2;
			public const int ECLASS_INSTANCECLASS = 3;
			public const int ECLASS_DEFAULTVALUE = 4;
			public const int ECLASS_INSTANCETYPENAME = 5;
			public const int ECLASS_EPACKAGE = 6;
			public const int ECLASS_ETYPEPARAMETERS = 7;
			public const int ECLASS_ABSTRACT = 8;
			public const int ECLASS_INTERFACE = 9;
			public const int ECLASS_ESUPERTYPES = 10;
			public const int ECLASS_EOPERATIONS = 11;
			public const int ECLASS_EALLATTRIBUTES = 12;
			public const int ECLASS_EALLREFERENCES = 13;
			public const int ECLASS_EREFERENCES = 14;
			public const int ECLASS_EATTRIBUTES = 15;
			public const int ECLASS_EALLCONTAINMENTS = 16;
			public const int ECLASS_EALLOPERATIONS = 17;
			public const int ECLASS_EALLSTRUCTURALFEATURES = 18;
			public const int ECLASS_EALLSUPERTYPES = 19;
			public const int ECLASS_EIDATTRIBUTE = 20;
			public const int ECLASS_ESTRUCTURALFEATURES = 21;
			public const int ECLASS_EGENERICSUPERTYPES = 22;
			public const int ECLASS_EALLGENERICSUPERTYPES = 23;
			
			public const int EDATATYPE = 4;
			public const int EDATATYPE_FEATURE_COUNT = ECLASSIFIER_FEATURE_COUNT + 1;
			public const int EDATATYPE_OPERATION_COUNT = ECLASSIFIER_OPERATION_COUNT + 0;
			
			public const int EDATATYPE_EANNOTATIONS = 0;
			public const int EDATATYPE_NAME = 1;
			public const int EDATATYPE_INSTANCECLASSNAME = 2;
			public const int EDATATYPE_INSTANCECLASS = 3;
			public const int EDATATYPE_DEFAULTVALUE = 4;
			public const int EDATATYPE_INSTANCETYPENAME = 5;
			public const int EDATATYPE_EPACKAGE = 6;
			public const int EDATATYPE_ETYPEPARAMETERS = 7;
			public const int EDATATYPE_SERIALIZABLE = 8;
			
			public const int EENUM = 5;
			public const int EENUM_FEATURE_COUNT = EDATATYPE_FEATURE_COUNT + 1;
			public const int EENUM_OPERATION_COUNT = EDATATYPE_OPERATION_COUNT + 3;
			
			public const int EENUM_EANNOTATIONS = 0;
			public const int EENUM_NAME = 1;
			public const int EENUM_INSTANCECLASSNAME = 2;
			public const int EENUM_INSTANCECLASS = 3;
			public const int EENUM_DEFAULTVALUE = 4;
			public const int EENUM_INSTANCETYPENAME = 5;
			public const int EENUM_EPACKAGE = 6;
			public const int EENUM_ETYPEPARAMETERS = 7;
			public const int EENUM_SERIALIZABLE = 8;
			public const int EENUM_ELITERALS = 9;
			
			public const int EENUMLITERAL = 6;
			public const int EENUMLITERAL_FEATURE_COUNT = ENAMEDELEMENT_FEATURE_COUNT + 4;
			public const int EENUMLITERAL_OPERATION_COUNT = ENAMEDELEMENT_OPERATION_COUNT + 0;
			
			public const int EENUMLITERAL_EANNOTATIONS = 0;
			public const int EENUMLITERAL_NAME = 1;
			public const int EENUMLITERAL_VALUE = 2;
			public const int EENUMLITERAL_INSTANCE = 3;
			public const int EENUMLITERAL_LITERAL = 4;
			public const int EENUMLITERAL_EENUM = 5;
			
			public const int EFACTORY = 7;
			public const int EFACTORY_FEATURE_COUNT = EMODELELEMENT_FEATURE_COUNT + 1;
			public const int EFACTORY_OPERATION_COUNT = EMODELELEMENT_OPERATION_COUNT + 3;
			
			public const int EFACTORY_EANNOTATIONS = 0;
			public const int EFACTORY_EPACKAGE = 1;
			
			public const int EOBJECT = 10;
			public const int EOBJECT_FEATURE_COUNT = 0;
			public const int EOBJECT_OPERATION_COUNT = 15;
			
			
			public const int EOPERATION = 11;
			public const int EOPERATION_FEATURE_COUNT = ETYPEDELEMENT_FEATURE_COUNT + 5;
			public const int EOPERATION_OPERATION_COUNT = ETYPEDELEMENT_OPERATION_COUNT + 2;
			
			public const int EOPERATION_EANNOTATIONS = 0;
			public const int EOPERATION_NAME = 1;
			public const int EOPERATION_ORDERED = 2;
			public const int EOPERATION_UNIQUE = 3;
			public const int EOPERATION_LOWERBOUND = 4;
			public const int EOPERATION_UPPERBOUND = 5;
			public const int EOPERATION_MANY = 6;
			public const int EOPERATION_REQUIRED = 7;
			public const int EOPERATION_ETYPE = 8;
			public const int EOPERATION_EGENERICTYPE = 9;
			public const int EOPERATION_ECONTAININGCLASS = 10;
			public const int EOPERATION_ETYPEPARAMETERS = 11;
			public const int EOPERATION_EPARAMETERS = 12;
			public const int EOPERATION_EEXCEPTIONS = 13;
			public const int EOPERATION_EGENERICEXCEPTIONS = 14;
			
			public const int EPACKAGE = 12;
			public const int EPACKAGE_FEATURE_COUNT = ENAMEDELEMENT_FEATURE_COUNT + 6;
			public const int EPACKAGE_OPERATION_COUNT = ENAMEDELEMENT_OPERATION_COUNT + 1;
			
			public const int EPACKAGE_EANNOTATIONS = 0;
			public const int EPACKAGE_NAME = 1;
			public const int EPACKAGE_NSURI = 2;
			public const int EPACKAGE_NSPREFIX = 3;
			public const int EPACKAGE_EFACTORYINSTANCE = 4;
			public const int EPACKAGE_ECLASSIFIERS = 5;
			public const int EPACKAGE_ESUBPACKAGES = 6;
			public const int EPACKAGE_ESUPERPACKAGE = 7;
			
			public const int EPARAMETER = 13;
			public const int EPARAMETER_FEATURE_COUNT = ETYPEDELEMENT_FEATURE_COUNT + 1;
			public const int EPARAMETER_OPERATION_COUNT = ETYPEDELEMENT_OPERATION_COUNT + 0;
			
			public const int EPARAMETER_EANNOTATIONS = 0;
			public const int EPARAMETER_NAME = 1;
			public const int EPARAMETER_ORDERED = 2;
			public const int EPARAMETER_UNIQUE = 3;
			public const int EPARAMETER_LOWERBOUND = 4;
			public const int EPARAMETER_UPPERBOUND = 5;
			public const int EPARAMETER_MANY = 6;
			public const int EPARAMETER_REQUIRED = 7;
			public const int EPARAMETER_ETYPE = 8;
			public const int EPARAMETER_EGENERICTYPE = 9;
			public const int EPARAMETER_EOPERATION = 10;
			
			public const int EREFERENCE = 14;
			public const int EREFERENCE_FEATURE_COUNT = ESTRUCTURALFEATURE_FEATURE_COUNT + 6;
			public const int EREFERENCE_OPERATION_COUNT = ESTRUCTURALFEATURE_OPERATION_COUNT + 0;
			
			public const int EREFERENCE_EANNOTATIONS = 0;
			public const int EREFERENCE_NAME = 1;
			public const int EREFERENCE_ORDERED = 2;
			public const int EREFERENCE_UNIQUE = 3;
			public const int EREFERENCE_LOWERBOUND = 4;
			public const int EREFERENCE_UPPERBOUND = 5;
			public const int EREFERENCE_MANY = 6;
			public const int EREFERENCE_REQUIRED = 7;
			public const int EREFERENCE_ETYPE = 8;
			public const int EREFERENCE_EGENERICTYPE = 9;
			public const int EREFERENCE_CHANGEABLE = 10;
			public const int EREFERENCE_VOLATILE = 11;
			public const int EREFERENCE_TRANSIENT = 12;
			public const int EREFERENCE_DEFAULTVALUELITERAL = 13;
			public const int EREFERENCE_DEFAULTVALUE = 14;
			public const int EREFERENCE_UNSETTABLE = 15;
			public const int EREFERENCE_DERIVED = 16;
			public const int EREFERENCE_ECONTAININGCLASS = 17;
			public const int EREFERENCE_CONTAINMENT = 18;
			public const int EREFERENCE_CONTAINER = 19;
			public const int EREFERENCE_RESOLVEPROXIES = 20;
			public const int EREFERENCE_EOPPOSITE = 21;
			public const int EREFERENCE_EREFERENCETYPE = 22;
			public const int EREFERENCE_EKEYS = 23;
			
			public const int ESTRINGTOSTRINGMAPENTRY = 48;
			public const int ESTRINGTOSTRINGMAPENTRY_FEATURE_COUNT = 2;
			public const int ESTRINGTOSTRINGMAPENTRY_OPERATION_COUNT = 0;
			
			public const int ESTRINGTOSTRINGMAPENTRY_KEY = 0;
			public const int ESTRINGTOSTRINGMAPENTRY_VALUE = 1;
			
			public const int EGENERICTYPE = 50;
			public const int EGENERICTYPE_FEATURE_COUNT = 6;
			public const int EGENERICTYPE_OPERATION_COUNT = 1;
			
			public const int EGENERICTYPE_EUPPERBOUND = 0;
			public const int EGENERICTYPE_ETYPEARGUMENTS = 1;
			public const int EGENERICTYPE_ERAWTYPE = 2;
			public const int EGENERICTYPE_ELOWERBOUND = 3;
			public const int EGENERICTYPE_ETYPEPARAMETER = 4;
			public const int EGENERICTYPE_ECLASSIFIER = 5;
			
			public const int ETYPEPARAMETER = 51;
			public const int ETYPEPARAMETER_FEATURE_COUNT = ENAMEDELEMENT_FEATURE_COUNT + 1;
			public const int ETYPEPARAMETER_OPERATION_COUNT = ENAMEDELEMENT_OPERATION_COUNT + 0;
			
			public const int ETYPEPARAMETER_EANNOTATIONS = 0;
			public const int ETYPEPARAMETER_NAME = 1;
			public const int ETYPEPARAMETER_EBOUNDS = 2;
			
			public const int EBIGDECIMAL = 17;
			public const int EBIGINTEGER = 18;
			public const int EBOOLEAN = 19;
			public const int EBOOLEANOBJECT = 20;
			public const int EBYTE = 21;
			public const int EBYTEARRAY = 22;
			public const int EBYTEOBJECT = 23;
			public const int ECHAR = 24;
			public const int ECHARACTEROBJECT = 25;
			public const int EDATE = 26;
			public const int EDIAGNOSTICCHAIN = 27;
			public const int EDOUBLE = 28;
			public const int EDOUBLEOBJECT = 29;
			public const int EELIST = 30;
			public const int EENUMERATOR = 31;
			public const int EFEATUREMAP = 32;
			public const int EFEATUREMAPENTRY = 33;
			public const int EFLOAT = 34;
			public const int EFLOATOBJECT = 35;
			public const int EINT = 36;
			public const int EINTEGEROBJECT = 37;
			public const int EJAVACLASS = 38;
			public const int EJAVAOBJECT = 39;
			public const int ELONG = 40;
			public const int ELONGOBJECT = 41;
			public const int EMAP = 42;
			public const int ERESOURCE = 43;
			public const int ERESOURCESET = 44;
			public const int ESHORT = 45;
			public const int ESHORTOBJECT = 46;
			public const int ESTRING = 47;
			public const int ETREEITERATOR = 49;
			public const int EINVOCATIONTARGETEXCEPTION = 52;
			
			
			public EClass getEModelElement(){return EModelElementEClass;}
			
			public EReference getEModelElement_EAnnotations(){return (EReference)EModelElementEClass.eStructuralFeatures.at(0);}
			public EClass getENamedElement(){return ENamedElementEClass;}
			
			public EAttribute getENamedElement_Name(){return (EAttribute)ENamedElementEClass.eStructuralFeatures.at(0);}
			public EClass getETypedElement(){return ETypedElementEClass;}
			
			public EAttribute getETypedElement_Ordered(){return (EAttribute)ETypedElementEClass.eStructuralFeatures.at(0);}
			public EAttribute getETypedElement_Unique(){return (EAttribute)ETypedElementEClass.eStructuralFeatures.at(1);}
			public EAttribute getETypedElement_LowerBound(){return (EAttribute)ETypedElementEClass.eStructuralFeatures.at(2);}
			public EAttribute getETypedElement_UpperBound(){return (EAttribute)ETypedElementEClass.eStructuralFeatures.at(3);}
			public EAttribute getETypedElement_Many(){return (EAttribute)ETypedElementEClass.eStructuralFeatures.at(4);}
			public EAttribute getETypedElement_Required(){return (EAttribute)ETypedElementEClass.eStructuralFeatures.at(5);}
			public EReference getETypedElement_EType(){return (EReference)ETypedElementEClass.eStructuralFeatures.at(6);}
			public EReference getETypedElement_EGenericType(){return (EReference)ETypedElementEClass.eStructuralFeatures.at(7);}
			public EClass getEStructuralFeature(){return EStructuralFeatureEClass;}
			
			public EAttribute getEStructuralFeature_Changeable(){return (EAttribute)EStructuralFeatureEClass.eStructuralFeatures.at(0);}
			public EAttribute getEStructuralFeature_Volatile(){return (EAttribute)EStructuralFeatureEClass.eStructuralFeatures.at(1);}
			public EAttribute getEStructuralFeature_Transient(){return (EAttribute)EStructuralFeatureEClass.eStructuralFeatures.at(2);}
			public EAttribute getEStructuralFeature_DefaultValueLiteral(){return (EAttribute)EStructuralFeatureEClass.eStructuralFeatures.at(3);}
			public EAttribute getEStructuralFeature_DefaultValue(){return (EAttribute)EStructuralFeatureEClass.eStructuralFeatures.at(4);}
			public EAttribute getEStructuralFeature_Unsettable(){return (EAttribute)EStructuralFeatureEClass.eStructuralFeatures.at(5);}
			public EAttribute getEStructuralFeature_Derived(){return (EAttribute)EStructuralFeatureEClass.eStructuralFeatures.at(6);}
			public EReference getEStructuralFeature_EContainingClass(){return (EReference)EStructuralFeatureEClass.eStructuralFeatures.at(7);}
			public EClass getEAttribute(){return EAttributeEClass;}
			
			public EAttribute getEAttribute_ID(){return (EAttribute)EAttributeEClass.eStructuralFeatures.at(0);}
			public EReference getEAttribute_EAttributeType(){return (EReference)EAttributeEClass.eStructuralFeatures.at(1);}
			public EClass getEAnnotation(){return EAnnotationEClass;}
			
			public EAttribute getEAnnotation_Source(){return (EAttribute)EAnnotationEClass.eStructuralFeatures.at(0);}
			public EReference getEAnnotation_Details(){return (EReference)EAnnotationEClass.eStructuralFeatures.at(1);}
			public EReference getEAnnotation_EModelElement(){return (EReference)EAnnotationEClass.eStructuralFeatures.at(2);}
			public EReference getEAnnotation_Contents(){return (EReference)EAnnotationEClass.eStructuralFeatures.at(3);}
			public EReference getEAnnotation_References(){return (EReference)EAnnotationEClass.eStructuralFeatures.at(4);}
			public EClass getEClassifier(){return EClassifierEClass;}
			
			public EAttribute getEClassifier_InstanceClassName(){return (EAttribute)EClassifierEClass.eStructuralFeatures.at(0);}
			public EAttribute getEClassifier_InstanceClass(){return (EAttribute)EClassifierEClass.eStructuralFeatures.at(1);}
			public EAttribute getEClassifier_DefaultValue(){return (EAttribute)EClassifierEClass.eStructuralFeatures.at(2);}
			public EAttribute getEClassifier_InstanceTypeName(){return (EAttribute)EClassifierEClass.eStructuralFeatures.at(3);}
			public EReference getEClassifier_EPackage(){return (EReference)EClassifierEClass.eStructuralFeatures.at(4);}
			public EReference getEClassifier_ETypeParameters(){return (EReference)EClassifierEClass.eStructuralFeatures.at(5);}
			public EClass getEClass(){return EClassEClass;}
			
			public EAttribute getEClass_Abstract(){return (EAttribute)EClassEClass.eStructuralFeatures.at(0);}
			public EAttribute getEClass_Interface(){return (EAttribute)EClassEClass.eStructuralFeatures.at(1);}
			public EReference getEClass_ESuperTypes(){return (EReference)EClassEClass.eStructuralFeatures.at(2);}
			public EReference getEClass_EOperations(){return (EReference)EClassEClass.eStructuralFeatures.at(3);}
			public EReference getEClass_EAllAttributes(){return (EReference)EClassEClass.eStructuralFeatures.at(4);}
			public EReference getEClass_EAllReferences(){return (EReference)EClassEClass.eStructuralFeatures.at(5);}
			public EReference getEClass_EReferences(){return (EReference)EClassEClass.eStructuralFeatures.at(6);}
			public EReference getEClass_EAttributes(){return (EReference)EClassEClass.eStructuralFeatures.at(7);}
			public EReference getEClass_EAllContainments(){return (EReference)EClassEClass.eStructuralFeatures.at(8);}
			public EReference getEClass_EAllOperations(){return (EReference)EClassEClass.eStructuralFeatures.at(9);}
			public EReference getEClass_EAllStructuralFeatures(){return (EReference)EClassEClass.eStructuralFeatures.at(10);}
			public EReference getEClass_EAllSuperTypes(){return (EReference)EClassEClass.eStructuralFeatures.at(11);}
			public EReference getEClass_EIDAttribute(){return (EReference)EClassEClass.eStructuralFeatures.at(12);}
			public EReference getEClass_EStructuralFeatures(){return (EReference)EClassEClass.eStructuralFeatures.at(13);}
			public EReference getEClass_EGenericSuperTypes(){return (EReference)EClassEClass.eStructuralFeatures.at(14);}
			public EReference getEClass_EAllGenericSuperTypes(){return (EReference)EClassEClass.eStructuralFeatures.at(15);}
			public EClass getEDataType(){return EDataTypeEClass;}
			
			public EAttribute getEDataType_Serializable(){return (EAttribute)EDataTypeEClass.eStructuralFeatures.at(0);}
			public EClass getEEnum(){return EEnumEClass;}
			
			public EReference getEEnum_ELiterals(){return (EReference)EEnumEClass.eStructuralFeatures.at(0);}
			public EClass getEEnumLiteral(){return EEnumLiteralEClass;}
			
			public EAttribute getEEnumLiteral_Value(){return (EAttribute)EEnumLiteralEClass.eStructuralFeatures.at(0);}
			public EAttribute getEEnumLiteral_Instance(){return (EAttribute)EEnumLiteralEClass.eStructuralFeatures.at(1);}
			public EAttribute getEEnumLiteral_Literal(){return (EAttribute)EEnumLiteralEClass.eStructuralFeatures.at(2);}
			public EReference getEEnumLiteral_EEnum(){return (EReference)EEnumLiteralEClass.eStructuralFeatures.at(3);}
			public EClass getEFactory(){return EFactoryEClass;}
			
			public EReference getEFactory_EPackage(){return (EReference)EFactoryEClass.eStructuralFeatures.at(0);}
			public EClass getEObject(){return EObjectEClass;}
			
			public EClass getEOperation(){return EOperationEClass;}
			
			public EReference getEOperation_EContainingClass(){return (EReference)EOperationEClass.eStructuralFeatures.at(0);}
			public EReference getEOperation_ETypeParameters(){return (EReference)EOperationEClass.eStructuralFeatures.at(1);}
			public EReference getEOperation_EParameters(){return (EReference)EOperationEClass.eStructuralFeatures.at(2);}
			public EReference getEOperation_EExceptions(){return (EReference)EOperationEClass.eStructuralFeatures.at(3);}
			public EReference getEOperation_EGenericExceptions(){return (EReference)EOperationEClass.eStructuralFeatures.at(4);}
			public EClass getEPackage(){return EPackageEClass;}
			
			public EAttribute getEPackage_NsURI(){return (EAttribute)EPackageEClass.eStructuralFeatures.at(0);}
			public EAttribute getEPackage_NsPrefix(){return (EAttribute)EPackageEClass.eStructuralFeatures.at(1);}
			public EReference getEPackage_EFactoryInstance(){return (EReference)EPackageEClass.eStructuralFeatures.at(2);}
			public EReference getEPackage_EClassifiers(){return (EReference)EPackageEClass.eStructuralFeatures.at(3);}
			public EReference getEPackage_ESubpackages(){return (EReference)EPackageEClass.eStructuralFeatures.at(4);}
			public EReference getEPackage_ESuperPackage(){return (EReference)EPackageEClass.eStructuralFeatures.at(5);}
			public EClass getEParameter(){return EParameterEClass;}
			
			public EReference getEParameter_EOperation(){return (EReference)EParameterEClass.eStructuralFeatures.at(0);}
			public EClass getEReference(){return EReferenceEClass;}
			
			public EAttribute getEReference_Containment(){return (EAttribute)EReferenceEClass.eStructuralFeatures.at(0);}
			public EAttribute getEReference_Container(){return (EAttribute)EReferenceEClass.eStructuralFeatures.at(1);}
			public EAttribute getEReference_ResolveProxies(){return (EAttribute)EReferenceEClass.eStructuralFeatures.at(2);}
			public EReference getEReference_EOpposite(){return (EReference)EReferenceEClass.eStructuralFeatures.at(3);}
			public EReference getEReference_EReferenceType(){return (EReference)EReferenceEClass.eStructuralFeatures.at(4);}
			public EReference getEReference_EKeys(){return (EReference)EReferenceEClass.eStructuralFeatures.at(5);}
			public EClass getEStringToStringMapEntry(){return EStringToStringMapEntryEClass;}
			
			public EAttribute getEStringToStringMapEntry_Key(){return (EAttribute)EStringToStringMapEntryEClass.eStructuralFeatures.at(0);}
			public EAttribute getEStringToStringMapEntry_Value(){return (EAttribute)EStringToStringMapEntryEClass.eStructuralFeatures.at(1);}
			public EClass getEGenericType(){return EGenericTypeEClass;}
			
			public EReference getEGenericType_EUpperBound(){return (EReference)EGenericTypeEClass.eStructuralFeatures.at(0);}
			public EReference getEGenericType_ETypeArguments(){return (EReference)EGenericTypeEClass.eStructuralFeatures.at(1);}
			public EReference getEGenericType_ERawType(){return (EReference)EGenericTypeEClass.eStructuralFeatures.at(2);}
			public EReference getEGenericType_ELowerBound(){return (EReference)EGenericTypeEClass.eStructuralFeatures.at(3);}
			public EReference getEGenericType_ETypeParameter(){return (EReference)EGenericTypeEClass.eStructuralFeatures.at(4);}
			public EReference getEGenericType_EClassifier(){return (EReference)EGenericTypeEClass.eStructuralFeatures.at(5);}
			public EClass getETypeParameter(){return ETypeParameterEClass;}
			
			public EReference getETypeParameter_EBounds(){return (EReference)ETypeParameterEClass.eStructuralFeatures.at(0);}
			public EDataType getEBigDecimal(){return EBigDecimalEDataType;}
			public EDataType getEBigInteger(){return EBigIntegerEDataType;}
			public EDataType getEBoolean(){return EBooleanEDataType;}
			public EDataType getEBooleanObject(){return EBooleanObjectEDataType;}
			public EDataType getEByte(){return EByteEDataType;}
			public EDataType getEByteArray(){return EByteArrayEDataType;}
			public EDataType getEByteObject(){return EByteObjectEDataType;}
			public EDataType getEChar(){return ECharEDataType;}
			public EDataType getECharacterObject(){return ECharacterObjectEDataType;}
			public EDataType getEDate(){return EDateEDataType;}
			public EDataType getEDiagnosticChain(){return EDiagnosticChainEDataType;}
			public EDataType getEDouble(){return EDoubleEDataType;}
			public EDataType getEDoubleObject(){return EDoubleObjectEDataType;}
			public EDataType getEEList(){return EEListEDataType;}
			public EDataType getEEnumerator(){return EEnumeratorEDataType;}
			public EDataType getEFeatureMap(){return EFeatureMapEDataType;}
			public EDataType getEFeatureMapEntry(){return EFeatureMapEntryEDataType;}
			public EDataType getEFloat(){return EFloatEDataType;}
			public EDataType getEFloatObject(){return EFloatObjectEDataType;}
			public EDataType getEInt(){return EIntEDataType;}
			public EDataType getEIntegerObject(){return EIntegerObjectEDataType;}
			public EDataType getEJavaClass(){return EJavaClassEDataType;}
			public EDataType getEJavaObject(){return EJavaObjectEDataType;}
			public EDataType getELong(){return ELongEDataType;}
			public EDataType getELongObject(){return ELongObjectEDataType;}
			public EDataType getEMap(){return EMapEDataType;}
			public EDataType getEResource(){return EResourceEDataType;}
			public EDataType getEResourceSet(){return EResourceSetEDataType;}
			public EDataType getEShort(){return EShortEDataType;}
			public EDataType getEShortObject(){return EShortObjectEDataType;}
			public EDataType getEString(){return EStringEDataType;}
			public EDataType getETreeIterator(){return ETreeIteratorEDataType;}
			public EDataType getEInvocationTargetException(){return EInvocationTargetExceptionEDataType;}
			
			public class Literals{
				public static EClass EMODELELEMENT = EcorePackageImpl.eINSTANCE.getEModelElement();
				
				public static EReference EMODELELEMENT_EANNOTATIONS = EcorePackageImpl.eINSTANCE.getEModelElement_EAnnotations();
				
				public static EClass ENAMEDELEMENT = EcorePackageImpl.eINSTANCE.getENamedElement();
				
				
				public static EAttribute ENAMEDELEMENT_NAME = EcorePackageImpl.eINSTANCE.getENamedElement_Name();
				public static EClass ETYPEDELEMENT = EcorePackageImpl.eINSTANCE.getETypedElement();
				
				public static EReference ETYPEDELEMENT_ETYPE = EcorePackageImpl.eINSTANCE.getETypedElement_EType();
				public static EReference ETYPEDELEMENT_EGENERICTYPE = EcorePackageImpl.eINSTANCE.getETypedElement_EGenericType();
				
				public static EAttribute ETYPEDELEMENT_ORDERED = EcorePackageImpl.eINSTANCE.getETypedElement_Ordered();
				public static EAttribute ETYPEDELEMENT_UNIQUE = EcorePackageImpl.eINSTANCE.getETypedElement_Unique();
				public static EAttribute ETYPEDELEMENT_LOWERBOUND = EcorePackageImpl.eINSTANCE.getETypedElement_LowerBound();
				public static EAttribute ETYPEDELEMENT_UPPERBOUND = EcorePackageImpl.eINSTANCE.getETypedElement_UpperBound();
				public static EAttribute ETYPEDELEMENT_MANY = EcorePackageImpl.eINSTANCE.getETypedElement_Many();
				public static EAttribute ETYPEDELEMENT_REQUIRED = EcorePackageImpl.eINSTANCE.getETypedElement_Required();
				public static EClass ESTRUCTURALFEATURE = EcorePackageImpl.eINSTANCE.getEStructuralFeature();
				
				public static EReference ESTRUCTURALFEATURE_ECONTAININGCLASS = EcorePackageImpl.eINSTANCE.getEStructuralFeature_EContainingClass();
				
				public static EAttribute ESTRUCTURALFEATURE_CHANGEABLE = EcorePackageImpl.eINSTANCE.getEStructuralFeature_Changeable();
				public static EAttribute ESTRUCTURALFEATURE_VOLATILE = EcorePackageImpl.eINSTANCE.getEStructuralFeature_Volatile();
				public static EAttribute ESTRUCTURALFEATURE_TRANSIENT = EcorePackageImpl.eINSTANCE.getEStructuralFeature_Transient();
				public static EAttribute ESTRUCTURALFEATURE_DEFAULTVALUELITERAL = EcorePackageImpl.eINSTANCE.getEStructuralFeature_DefaultValueLiteral();
				public static EAttribute ESTRUCTURALFEATURE_DEFAULTVALUE = EcorePackageImpl.eINSTANCE.getEStructuralFeature_DefaultValue();
				public static EAttribute ESTRUCTURALFEATURE_UNSETTABLE = EcorePackageImpl.eINSTANCE.getEStructuralFeature_Unsettable();
				public static EAttribute ESTRUCTURALFEATURE_DERIVED = EcorePackageImpl.eINSTANCE.getEStructuralFeature_Derived();
				public static EClass EATTRIBUTE = EcorePackageImpl.eINSTANCE.getEAttribute();
				
				public static EReference EATTRIBUTE_EATTRIBUTETYPE = EcorePackageImpl.eINSTANCE.getEAttribute_EAttributeType();
				
				public static EAttribute EATTRIBUTE_ID = EcorePackageImpl.eINSTANCE.getEAttribute_ID();
				public static EClass EANNOTATION = EcorePackageImpl.eINSTANCE.getEAnnotation();
				
				public static EReference EANNOTATION_DETAILS = EcorePackageImpl.eINSTANCE.getEAnnotation_Details();
				public static EReference EANNOTATION_EMODELELEMENT = EcorePackageImpl.eINSTANCE.getEAnnotation_EModelElement();
				public static EReference EANNOTATION_CONTENTS = EcorePackageImpl.eINSTANCE.getEAnnotation_Contents();
				public static EReference EANNOTATION_REFERENCES = EcorePackageImpl.eINSTANCE.getEAnnotation_References();
				
				public static EAttribute EANNOTATION_SOURCE = EcorePackageImpl.eINSTANCE.getEAnnotation_Source();
				public static EClass ECLASSIFIER = EcorePackageImpl.eINSTANCE.getEClassifier();
				
				public static EReference ECLASSIFIER_EPACKAGE = EcorePackageImpl.eINSTANCE.getEClassifier_EPackage();
				public static EReference ECLASSIFIER_ETYPEPARAMETERS = EcorePackageImpl.eINSTANCE.getEClassifier_ETypeParameters();
				
				public static EAttribute ECLASSIFIER_INSTANCECLASSNAME = EcorePackageImpl.eINSTANCE.getEClassifier_InstanceClassName();
				public static EAttribute ECLASSIFIER_INSTANCECLASS = EcorePackageImpl.eINSTANCE.getEClassifier_InstanceClass();
				public static EAttribute ECLASSIFIER_DEFAULTVALUE = EcorePackageImpl.eINSTANCE.getEClassifier_DefaultValue();
				public static EAttribute ECLASSIFIER_INSTANCETYPENAME = EcorePackageImpl.eINSTANCE.getEClassifier_InstanceTypeName();
				public static EClass ECLASS = EcorePackageImpl.eINSTANCE.getEClass();
				
				public static EReference ECLASS_ESUPERTYPES = EcorePackageImpl.eINSTANCE.getEClass_ESuperTypes();
				public static EReference ECLASS_EOPERATIONS = EcorePackageImpl.eINSTANCE.getEClass_EOperations();
				public static EReference ECLASS_EALLATTRIBUTES = EcorePackageImpl.eINSTANCE.getEClass_EAllAttributes();
				public static EReference ECLASS_EALLREFERENCES = EcorePackageImpl.eINSTANCE.getEClass_EAllReferences();
				public static EReference ECLASS_EREFERENCES = EcorePackageImpl.eINSTANCE.getEClass_EReferences();
				public static EReference ECLASS_EATTRIBUTES = EcorePackageImpl.eINSTANCE.getEClass_EAttributes();
				public static EReference ECLASS_EALLCONTAINMENTS = EcorePackageImpl.eINSTANCE.getEClass_EAllContainments();
				public static EReference ECLASS_EALLOPERATIONS = EcorePackageImpl.eINSTANCE.getEClass_EAllOperations();
				public static EReference ECLASS_EALLSTRUCTURALFEATURES = EcorePackageImpl.eINSTANCE.getEClass_EAllStructuralFeatures();
				public static EReference ECLASS_EALLSUPERTYPES = EcorePackageImpl.eINSTANCE.getEClass_EAllSuperTypes();
				public static EReference ECLASS_EIDATTRIBUTE = EcorePackageImpl.eINSTANCE.getEClass_EIDAttribute();
				public static EReference ECLASS_ESTRUCTURALFEATURES = EcorePackageImpl.eINSTANCE.getEClass_EStructuralFeatures();
				public static EReference ECLASS_EGENERICSUPERTYPES = EcorePackageImpl.eINSTANCE.getEClass_EGenericSuperTypes();
				public static EReference ECLASS_EALLGENERICSUPERTYPES = EcorePackageImpl.eINSTANCE.getEClass_EAllGenericSuperTypes();
				
				public static EAttribute ECLASS_ABSTRACT = EcorePackageImpl.eINSTANCE.getEClass_Abstract();
				public static EAttribute ECLASS_INTERFACE = EcorePackageImpl.eINSTANCE.getEClass_Interface();
				public static EClass EDATATYPE = EcorePackageImpl.eINSTANCE.getEDataType();
				
				
				public static EAttribute EDATATYPE_SERIALIZABLE = EcorePackageImpl.eINSTANCE.getEDataType_Serializable();
				public static EClass EENUM = EcorePackageImpl.eINSTANCE.getEEnum();
				
				public static EReference EENUM_ELITERALS = EcorePackageImpl.eINSTANCE.getEEnum_ELiterals();
				
				public static EClass EENUMLITERAL = EcorePackageImpl.eINSTANCE.getEEnumLiteral();
				
				public static EReference EENUMLITERAL_EENUM = EcorePackageImpl.eINSTANCE.getEEnumLiteral_EEnum();
				
				public static EAttribute EENUMLITERAL_VALUE = EcorePackageImpl.eINSTANCE.getEEnumLiteral_Value();
				public static EAttribute EENUMLITERAL_INSTANCE = EcorePackageImpl.eINSTANCE.getEEnumLiteral_Instance();
				public static EAttribute EENUMLITERAL_LITERAL = EcorePackageImpl.eINSTANCE.getEEnumLiteral_Literal();
				public static EClass EFACTORY = EcorePackageImpl.eINSTANCE.getEFactory();
				
				public static EReference EFACTORY_EPACKAGE = EcorePackageImpl.eINSTANCE.getEFactory_EPackage();
				
				public static EClass EOBJECT = EcorePackageImpl.eINSTANCE.getEObject();
				
				
				public static EClass EOPERATION = EcorePackageImpl.eINSTANCE.getEOperation();
				
				public static EReference EOPERATION_ECONTAININGCLASS = EcorePackageImpl.eINSTANCE.getEOperation_EContainingClass();
				public static EReference EOPERATION_ETYPEPARAMETERS = EcorePackageImpl.eINSTANCE.getEOperation_ETypeParameters();
				public static EReference EOPERATION_EPARAMETERS = EcorePackageImpl.eINSTANCE.getEOperation_EParameters();
				public static EReference EOPERATION_EEXCEPTIONS = EcorePackageImpl.eINSTANCE.getEOperation_EExceptions();
				public static EReference EOPERATION_EGENERICEXCEPTIONS = EcorePackageImpl.eINSTANCE.getEOperation_EGenericExceptions();
				
				public static EClass EPACKAGE = EcorePackageImpl.eINSTANCE.getEPackage();
				
				public static EReference EPACKAGE_EFACTORYINSTANCE = EcorePackageImpl.eINSTANCE.getEPackage_EFactoryInstance();
				public static EReference EPACKAGE_ECLASSIFIERS = EcorePackageImpl.eINSTANCE.getEPackage_EClassifiers();
				public static EReference EPACKAGE_ESUBPACKAGES = EcorePackageImpl.eINSTANCE.getEPackage_ESubpackages();
				public static EReference EPACKAGE_ESUPERPACKAGE = EcorePackageImpl.eINSTANCE.getEPackage_ESuperPackage();
				
				public static EAttribute EPACKAGE_NSURI = EcorePackageImpl.eINSTANCE.getEPackage_NsURI();
				public static EAttribute EPACKAGE_NSPREFIX = EcorePackageImpl.eINSTANCE.getEPackage_NsPrefix();
				public static EClass EPARAMETER = EcorePackageImpl.eINSTANCE.getEParameter();
				
				public static EReference EPARAMETER_EOPERATION = EcorePackageImpl.eINSTANCE.getEParameter_EOperation();
				
				public static EClass EREFERENCE = EcorePackageImpl.eINSTANCE.getEReference();
				
				public static EReference EREFERENCE_EOPPOSITE = EcorePackageImpl.eINSTANCE.getEReference_EOpposite();
				public static EReference EREFERENCE_EREFERENCETYPE = EcorePackageImpl.eINSTANCE.getEReference_EReferenceType();
				public static EReference EREFERENCE_EKEYS = EcorePackageImpl.eINSTANCE.getEReference_EKeys();
				
				public static EAttribute EREFERENCE_CONTAINMENT = EcorePackageImpl.eINSTANCE.getEReference_Containment();
				public static EAttribute EREFERENCE_CONTAINER = EcorePackageImpl.eINSTANCE.getEReference_Container();
				public static EAttribute EREFERENCE_RESOLVEPROXIES = EcorePackageImpl.eINSTANCE.getEReference_ResolveProxies();
				public static EClass ESTRINGTOSTRINGMAPENTRY = EcorePackageImpl.eINSTANCE.getEStringToStringMapEntry();
				
				
				public static EAttribute ESTRINGTOSTRINGMAPENTRY_KEY = EcorePackageImpl.eINSTANCE.getEStringToStringMapEntry_Key();
				public static EAttribute ESTRINGTOSTRINGMAPENTRY_VALUE = EcorePackageImpl.eINSTANCE.getEStringToStringMapEntry_Value();
				public static EClass EGENERICTYPE = EcorePackageImpl.eINSTANCE.getEGenericType();
				
				public static EReference EGENERICTYPE_EUPPERBOUND = EcorePackageImpl.eINSTANCE.getEGenericType_EUpperBound();
				public static EReference EGENERICTYPE_ETYPEARGUMENTS = EcorePackageImpl.eINSTANCE.getEGenericType_ETypeArguments();
				public static EReference EGENERICTYPE_ERAWTYPE = EcorePackageImpl.eINSTANCE.getEGenericType_ERawType();
				public static EReference EGENERICTYPE_ELOWERBOUND = EcorePackageImpl.eINSTANCE.getEGenericType_ELowerBound();
				public static EReference EGENERICTYPE_ETYPEPARAMETER = EcorePackageImpl.eINSTANCE.getEGenericType_ETypeParameter();
				public static EReference EGENERICTYPE_ECLASSIFIER = EcorePackageImpl.eINSTANCE.getEGenericType_EClassifier();
				
				public static EClass ETYPEPARAMETER = EcorePackageImpl.eINSTANCE.getETypeParameter();
				
				public static EReference ETYPEPARAMETER_EBOUNDS = EcorePackageImpl.eINSTANCE.getETypeParameter_EBounds();
				
				public static EDataType EBIGDECIMAL = EcorePackageImpl.eINSTANCE.getEBigDecimal();
				public static EDataType EBIGINTEGER = EcorePackageImpl.eINSTANCE.getEBigInteger();
				public static EDataType EBOOLEAN = EcorePackageImpl.eINSTANCE.getEBoolean();
				public static EDataType EBOOLEANOBJECT = EcorePackageImpl.eINSTANCE.getEBooleanObject();
				public static EDataType EBYTE = EcorePackageImpl.eINSTANCE.getEByte();
				public static EDataType EBYTEARRAY = EcorePackageImpl.eINSTANCE.getEByteArray();
				public static EDataType EBYTEOBJECT = EcorePackageImpl.eINSTANCE.getEByteObject();
				public static EDataType ECHAR = EcorePackageImpl.eINSTANCE.getEChar();
				public static EDataType ECHARACTEROBJECT = EcorePackageImpl.eINSTANCE.getECharacterObject();
				public static EDataType EDATE = EcorePackageImpl.eINSTANCE.getEDate();
				public static EDataType EDIAGNOSTICCHAIN = EcorePackageImpl.eINSTANCE.getEDiagnosticChain();
				public static EDataType EDOUBLE = EcorePackageImpl.eINSTANCE.getEDouble();
				public static EDataType EDOUBLEOBJECT = EcorePackageImpl.eINSTANCE.getEDoubleObject();
				public static EDataType EELIST = EcorePackageImpl.eINSTANCE.getEEList();
				public static EDataType EENUMERATOR = EcorePackageImpl.eINSTANCE.getEEnumerator();
				public static EDataType EFEATUREMAP = EcorePackageImpl.eINSTANCE.getEFeatureMap();
				public static EDataType EFEATUREMAPENTRY = EcorePackageImpl.eINSTANCE.getEFeatureMapEntry();
				public static EDataType EFLOAT = EcorePackageImpl.eINSTANCE.getEFloat();
				public static EDataType EFLOATOBJECT = EcorePackageImpl.eINSTANCE.getEFloatObject();
				public static EDataType EINT = EcorePackageImpl.eINSTANCE.getEInt();
				public static EDataType EINTEGEROBJECT = EcorePackageImpl.eINSTANCE.getEIntegerObject();
				public static EDataType EJAVACLASS = EcorePackageImpl.eINSTANCE.getEJavaClass();
				public static EDataType EJAVAOBJECT = EcorePackageImpl.eINSTANCE.getEJavaObject();
				public static EDataType ELONG = EcorePackageImpl.eINSTANCE.getELong();
				public static EDataType ELONGOBJECT = EcorePackageImpl.eINSTANCE.getELongObject();
				public static EDataType EMAP = EcorePackageImpl.eINSTANCE.getEMap();
				public static EDataType ERESOURCE = EcorePackageImpl.eINSTANCE.getEResource();
				public static EDataType ERESOURCESET = EcorePackageImpl.eINSTANCE.getEResourceSet();
				public static EDataType ESHORT = EcorePackageImpl.eINSTANCE.getEShort();
				public static EDataType ESHORTOBJECT = EcorePackageImpl.eINSTANCE.getEShortObject();
				public static EDataType ESTRING = EcorePackageImpl.eINSTANCE.getEString();
				public static EDataType ETREEITERATOR = EcorePackageImpl.eINSTANCE.getETreeIterator();
				public static EDataType EINVOCATIONTARGETEXCEPTION = EcorePackageImpl.eINSTANCE.getEInvocationTargetException();
			}
	 
	}
}
