/* CrossEcore is a cross-platform modeling framework that generates C#, TypeScript, 
 * JavaScript, Swift code from Ecore models with embedded OCL (http://www.crossecore.org/).
 * The original Eclipse Modeling Framework is available at https://www.eclipse.org/modeling/emf/.
 * 
 * contributor: Simon Schwichtenberg
 */
 
namespace Ecore{
	public interface EcorePackage : EPackage {
			
		EClass getEModelElement();
		EReference getEModelElement_EAnnotations();
		
		EClass getENamedElement();
		
		EAttribute getENamedElement_Name();
		EClass getETypedElement();
		EReference getETypedElement_EType();
		EReference getETypedElement_EGenericType();
		
		EAttribute getETypedElement_Ordered();
		EAttribute getETypedElement_Unique();
		EAttribute getETypedElement_LowerBound();
		EAttribute getETypedElement_UpperBound();
		EAttribute getETypedElement_Many();
		EAttribute getETypedElement_Required();
		EClass getEStructuralFeature();
		EReference getEStructuralFeature_EContainingClass();
		
		EAttribute getEStructuralFeature_Changeable();
		EAttribute getEStructuralFeature_Volatile();
		EAttribute getEStructuralFeature_Transient();
		EAttribute getEStructuralFeature_DefaultValueLiteral();
		EAttribute getEStructuralFeature_DefaultValue();
		EAttribute getEStructuralFeature_Unsettable();
		EAttribute getEStructuralFeature_Derived();
		EClass getEAttribute();
		EReference getEAttribute_EAttributeType();
		
		EAttribute getEAttribute_ID();
		EClass getEAnnotation();
		EReference getEAnnotation_Details();
		EReference getEAnnotation_EModelElement();
		EReference getEAnnotation_Contents();
		EReference getEAnnotation_References();
		
		EAttribute getEAnnotation_Source();
		EClass getEClassifier();
		EReference getEClassifier_EPackage();
		EReference getEClassifier_ETypeParameters();
		
		EAttribute getEClassifier_InstanceClassName();
		EAttribute getEClassifier_InstanceClass();
		EAttribute getEClassifier_DefaultValue();
		EAttribute getEClassifier_InstanceTypeName();
		EClass getEClass();
		EReference getEClass_ESuperTypes();
		EReference getEClass_EOperations();
		EReference getEClass_EAllAttributes();
		EReference getEClass_EAllReferences();
		EReference getEClass_EReferences();
		EReference getEClass_EAttributes();
		EReference getEClass_EAllContainments();
		EReference getEClass_EAllOperations();
		EReference getEClass_EAllStructuralFeatures();
		EReference getEClass_EAllSuperTypes();
		EReference getEClass_EIDAttribute();
		EReference getEClass_EStructuralFeatures();
		EReference getEClass_EGenericSuperTypes();
		EReference getEClass_EAllGenericSuperTypes();
		
		EAttribute getEClass_Abstract();
		EAttribute getEClass_Interface();
		EClass getEDataType();
		
		EAttribute getEDataType_Serializable();
		EClass getEEnum();
		EReference getEEnum_ELiterals();
		
		EClass getEEnumLiteral();
		EReference getEEnumLiteral_EEnum();
		
		EAttribute getEEnumLiteral_Value();
		EAttribute getEEnumLiteral_Instance();
		EAttribute getEEnumLiteral_Literal();
		EClass getEFactory();
		EReference getEFactory_EPackage();
		
		EClass getEObject();
		
		EClass getEOperation();
		EReference getEOperation_EContainingClass();
		EReference getEOperation_ETypeParameters();
		EReference getEOperation_EParameters();
		EReference getEOperation_EExceptions();
		EReference getEOperation_EGenericExceptions();
		
		EClass getEPackage();
		EReference getEPackage_EFactoryInstance();
		EReference getEPackage_EClassifiers();
		EReference getEPackage_ESubpackages();
		EReference getEPackage_ESuperPackage();
		
		EAttribute getEPackage_NsURI();
		EAttribute getEPackage_NsPrefix();
		EClass getEParameter();
		EReference getEParameter_EOperation();
		
		EClass getEReference();
		EReference getEReference_EOpposite();
		EReference getEReference_EReferenceType();
		EReference getEReference_EKeys();
		
		EAttribute getEReference_Containment();
		EAttribute getEReference_Container();
		EAttribute getEReference_ResolveProxies();
		EClass getEStringToStringMapEntry();
		
		EAttribute getEStringToStringMapEntry_Key();
		EAttribute getEStringToStringMapEntry_Value();
		EClass getEGenericType();
		EReference getEGenericType_EUpperBound();
		EReference getEGenericType_ETypeArguments();
		EReference getEGenericType_ERawType();
		EReference getEGenericType_ELowerBound();
		EReference getEGenericType_ETypeParameter();
		EReference getEGenericType_EClassifier();
		
		EClass getETypeParameter();
		EReference getETypeParameter_EBounds();
		
		EDataType getEBigDecimal();
		EDataType getEBigInteger();
		EDataType getEBoolean();
		EDataType getEBooleanObject();
		EDataType getEByte();
		EDataType getEByteArray();
		EDataType getEByteObject();
		EDataType getEChar();
		EDataType getECharacterObject();
		EDataType getEDate();
		EDataType getEDiagnosticChain();
		EDataType getEDouble();
		EDataType getEDoubleObject();
		EDataType getEEList();
		EDataType getEEnumerator();
		EDataType getEFeatureMap();
		EDataType getEFeatureMapEntry();
		EDataType getEFloat();
		EDataType getEFloatObject();
		EDataType getEInt();
		EDataType getEIntegerObject();
		EDataType getEJavaClass();
		EDataType getEJavaObject();
		EDataType getELong();
		EDataType getELongObject();
		EDataType getEMap();
		EDataType getEResource();
		EDataType getEResourceSet();
		EDataType getEShort();
		EDataType getEShortObject();
		EDataType getEString();
		EDataType getETreeIterator();
		EDataType getEInvocationTargetException();
			
	 
	}
}
