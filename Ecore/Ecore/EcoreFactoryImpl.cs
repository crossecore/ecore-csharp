/* CrossEcore is a cross-platform modeling framework that generates C#, TypeScript, 
 * JavaScript, Swift code from Ecore models with embedded OCL (http://www.crossecore.org/).
 * The original Eclipse Modeling Framework is available at https://www.eclipse.org/modeling/emf/.
 * 
 * contributor: Simon Schwichtenberg
 */
 
	 	using System;
namespace Ecore{
	public class EcoreFactoryImpl : EFactoryImpl, EcoreFactory {
		
		public static EcoreFactory eINSTANCE = EcoreFactoryImpl.init();

        public static EcoreFactory init()
        {
            return new EcoreFactoryImpl();
        }
		
		public EAttribute createEAttribute(){
			var theEAttribute = new EAttributeImpl();
			return theEAttribute;
		}
		public EAnnotation createEAnnotation(){
			var theEAnnotation = new EAnnotationImpl();
			return theEAnnotation;
		}
		public EClass createEClass(){
			var theEClass = new EClassImpl();
			return theEClass;
		}
		public EClassifier createEClassifier(){
			var theEClassifier = new EClassifierImpl();
			return theEClassifier;
		}
		public EDataType createEDataType(){
			var theEDataType = new EDataTypeImpl();
			return theEDataType;
		}
		public EEnum createEEnum(){
			var theEEnum = new EEnumImpl();
			return theEEnum;
		}
		public EEnumLiteral createEEnumLiteral(){
			var theEEnumLiteral = new EEnumLiteralImpl();
			return theEEnumLiteral;
		}
		public EFactory createEFactory(){
			var theEFactory = new EFactoryImpl();
			return theEFactory;
		}
		public EModelElement createEModelElement(){
			var theEModelElement = new EModelElementImpl();
			return theEModelElement;
		}
		public ENamedElement createENamedElement(){
			var theENamedElement = new ENamedElementImpl();
			return theENamedElement;
		}
		public EObject createEObject(){
			var theEObject = new EObjectImpl();
			return theEObject;
		}
		public EOperation createEOperation(){
			var theEOperation = new EOperationImpl();
			return theEOperation;
		}
		public EPackage createEPackage(){
			var theEPackage = new EPackageImpl();
			return theEPackage;
		}
		public EParameter createEParameter(){
			var theEParameter = new EParameterImpl();
			return theEParameter;
		}
		public EReference createEReference(){
			var theEReference = new EReferenceImpl();
			return theEReference;
		}
		public EStructuralFeature createEStructuralFeature(){
			var theEStructuralFeature = new EStructuralFeatureImpl();
			return theEStructuralFeature;
		}
		public ETypedElement createETypedElement(){
			var theETypedElement = new ETypedElementImpl();
			return theETypedElement;
		}
		public EStringToStringMapEntry createEStringToStringMapEntry(){
			var theEStringToStringMapEntry = new EStringToStringMapEntryImpl();
			return theEStringToStringMapEntry;
		}
		public EGenericType createEGenericType(){
			var theEGenericType = new EGenericTypeImpl();
			return theEGenericType;
		}
		public ETypeParameter createETypeParameter(){
			var theETypeParameter = new ETypeParameterImpl();
			return theETypeParameter;
		}
		
		public override EObject create(EClass eClass) {
			switch (eClass.getClassifierID()) {
				case EcorePackageImpl.EATTRIBUTE: return createEAttribute();
				case EcorePackageImpl.EANNOTATION: return createEAnnotation();
				case EcorePackageImpl.ECLASS: return createEClass();
				case EcorePackageImpl.EDATATYPE: return createEDataType();
				case EcorePackageImpl.EENUM: return createEEnum();
				case EcorePackageImpl.EENUMLITERAL: return createEEnumLiteral();
				case EcorePackageImpl.EFACTORY: return createEFactory();
				case EcorePackageImpl.EOBJECT: return createEObject();
				case EcorePackageImpl.EOPERATION: return createEOperation();
				case EcorePackageImpl.EPACKAGE: return createEPackage();
				case EcorePackageImpl.EPARAMETER: return createEParameter();
				case EcorePackageImpl.EREFERENCE: return createEReference();
				case EcorePackageImpl.ESTRINGTOSTRINGMAPENTRY: return createEStringToStringMapEntry();
				case EcorePackageImpl.EGENERICTYPE: return createEGenericType();
				case EcorePackageImpl.ETYPEPARAMETER: return createETypeParameter();
				default:
					throw new ArgumentException("The class '" + eClass.name + "' is not a valid classifier");
			}
		}
		
		/*
		public override object createFromString(EDataType eDataType, string initialValue) {
			switch (eDataType.getClassifierID()) {
			case EcorePackageImpl.EBIGDECIMAL:
				return createEBigDecimalFromString(eDataType, initialValue);
			case EcorePackageImpl.EBIGINTEGER:
				return createEBigIntegerFromString(eDataType, initialValue);
			case EcorePackageImpl.EBOOLEAN:
				return createEBooleanFromString(eDataType, initialValue);
			case EcorePackageImpl.EBOOLEANOBJECT:
				return createEBooleanObjectFromString(eDataType, initialValue);
			case EcorePackageImpl.EBYTE:
				return createEByteFromString(eDataType, initialValue);
			case EcorePackageImpl.EBYTEARRAY:
				return createEByteArrayFromString(eDataType, initialValue);
			case EcorePackageImpl.EBYTEOBJECT:
				return createEByteObjectFromString(eDataType, initialValue);
			case EcorePackageImpl.ECHAR:
				return createECharFromString(eDataType, initialValue);
			case EcorePackageImpl.ECHARACTEROBJECT:
				return createECharacterObjectFromString(eDataType, initialValue);
			case EcorePackageImpl.EDATE:
				return createEDateFromString(eDataType, initialValue);
			case EcorePackageImpl.EDIAGNOSTICCHAIN:
				return createEDiagnosticChainFromString(eDataType, initialValue);
			case EcorePackageImpl.EDOUBLE:
				return createEDoubleFromString(eDataType, initialValue);
			case EcorePackageImpl.EDOUBLEOBJECT:
				return createEDoubleObjectFromString(eDataType, initialValue);
			case EcorePackageImpl.EELIST:
				return createEEListFromString(eDataType, initialValue);
			case EcorePackageImpl.EENUMERATOR:
				return createEEnumeratorFromString(eDataType, initialValue);
			case EcorePackageImpl.EFEATUREMAP:
				return createEFeatureMapFromString(eDataType, initialValue);
			case EcorePackageImpl.EFEATUREMAPENTRY:
				return createEFeatureMapEntryFromString(eDataType, initialValue);
			case EcorePackageImpl.EFLOAT:
				return createEFloatFromString(eDataType, initialValue);
			case EcorePackageImpl.EFLOATOBJECT:
				return createEFloatObjectFromString(eDataType, initialValue);
			case EcorePackageImpl.EINT:
				return createEIntFromString(eDataType, initialValue);
			case EcorePackageImpl.EINTEGEROBJECT:
				return createEIntegerObjectFromString(eDataType, initialValue);
			case EcorePackageImpl.EJAVACLASS:
				return createEJavaClassFromString(eDataType, initialValue);
			case EcorePackageImpl.EJAVAOBJECT:
				return createEJavaObjectFromString(eDataType, initialValue);
			case EcorePackageImpl.ELONG:
				return createELongFromString(eDataType, initialValue);
			case EcorePackageImpl.ELONGOBJECT:
				return createELongObjectFromString(eDataType, initialValue);
			case EcorePackageImpl.EMAP:
				return createEMapFromString(eDataType, initialValue);
			case EcorePackageImpl.ERESOURCE:
				return createEResourceFromString(eDataType, initialValue);
			case EcorePackageImpl.ERESOURCESET:
				return createEResourceSetFromString(eDataType, initialValue);
			case EcorePackageImpl.ESHORT:
				return createEShortFromString(eDataType, initialValue);
			case EcorePackageImpl.ESHORTOBJECT:
				return createEShortObjectFromString(eDataType, initialValue);
			case EcorePackageImpl.ESTRING:
				return createEStringFromString(eDataType, initialValue);
			case EcorePackageImpl.ETREEITERATOR:
				return createETreeIteratorFromString(eDataType, initialValue);
			case EcorePackageImpl.EINVOCATIONTARGETEXCEPTION:
				return createEInvocationTargetExceptionFromString(eDataType, initialValue);
			default:
				throw new ArgumentException("The datatype '" + eDataType.name + "' is not a valid classifier");
			}
		}
		*/
		
		public override String convertToString(EDataType eDataType, object instanceValue) {
			switch (eDataType.getClassifierID()) {
			case EcorePackageImpl.EBIGDECIMAL:
				return convertEBigDecimalToString(eDataType, instanceValue);
			case EcorePackageImpl.EBIGINTEGER:
				return convertEBigIntegerToString(eDataType, instanceValue);
			case EcorePackageImpl.EBOOLEAN:
				return convertEBooleanToString(eDataType, instanceValue);
			case EcorePackageImpl.EBOOLEANOBJECT:
				return convertEBooleanObjectToString(eDataType, instanceValue);
			case EcorePackageImpl.EBYTE:
				return convertEByteToString(eDataType, instanceValue);
			case EcorePackageImpl.EBYTEARRAY:
				return convertEByteArrayToString(eDataType, instanceValue);
			case EcorePackageImpl.EBYTEOBJECT:
				return convertEByteObjectToString(eDataType, instanceValue);
			case EcorePackageImpl.ECHAR:
				return convertECharToString(eDataType, instanceValue);
			case EcorePackageImpl.ECHARACTEROBJECT:
				return convertECharacterObjectToString(eDataType, instanceValue);
			case EcorePackageImpl.EDATE:
				return convertEDateToString(eDataType, instanceValue);
			case EcorePackageImpl.EDIAGNOSTICCHAIN:
				return convertEDiagnosticChainToString(eDataType, instanceValue);
			case EcorePackageImpl.EDOUBLE:
				return convertEDoubleToString(eDataType, instanceValue);
			case EcorePackageImpl.EDOUBLEOBJECT:
				return convertEDoubleObjectToString(eDataType, instanceValue);
			case EcorePackageImpl.EELIST:
				return convertEEListToString(eDataType, instanceValue);
			case EcorePackageImpl.EENUMERATOR:
				return convertEEnumeratorToString(eDataType, instanceValue);
			case EcorePackageImpl.EFEATUREMAP:
				return convertEFeatureMapToString(eDataType, instanceValue);
			case EcorePackageImpl.EFEATUREMAPENTRY:
				return convertEFeatureMapEntryToString(eDataType, instanceValue);
			case EcorePackageImpl.EFLOAT:
				return convertEFloatToString(eDataType, instanceValue);
			case EcorePackageImpl.EFLOATOBJECT:
				return convertEFloatObjectToString(eDataType, instanceValue);
			case EcorePackageImpl.EINT:
				return convertEIntToString(eDataType, instanceValue);
			case EcorePackageImpl.EINTEGEROBJECT:
				return convertEIntegerObjectToString(eDataType, instanceValue);
			case EcorePackageImpl.EJAVACLASS:
				return convertEJavaClassToString(eDataType, instanceValue);
			case EcorePackageImpl.EJAVAOBJECT:
				return convertEJavaObjectToString(eDataType, instanceValue);
			case EcorePackageImpl.ELONG:
				return convertELongToString(eDataType, instanceValue);
			case EcorePackageImpl.ELONGOBJECT:
				return convertELongObjectToString(eDataType, instanceValue);
			case EcorePackageImpl.EMAP:
				return convertEMapToString(eDataType, instanceValue);
			case EcorePackageImpl.ERESOURCE:
				return convertEResourceToString(eDataType, instanceValue);
			case EcorePackageImpl.ERESOURCESET:
				return convertEResourceSetToString(eDataType, instanceValue);
			case EcorePackageImpl.ESHORT:
				return convertEShortToString(eDataType, instanceValue);
			case EcorePackageImpl.ESHORTOBJECT:
				return convertEShortObjectToString(eDataType, instanceValue);
			case EcorePackageImpl.ESTRING:
				return convertEStringToString(eDataType, instanceValue);
			case EcorePackageImpl.ETREEITERATOR:
				return convertETreeIteratorToString(eDataType, instanceValue);
			case EcorePackageImpl.EINVOCATIONTARGETEXCEPTION:
				return convertEInvocationTargetExceptionToString(eDataType, instanceValue);
			default:
				throw new ArgumentException("The datatype '" + eDataType.name + "' is not a valid classifier");
			}
		}
		
		
		/*
		public EBigDecimal createEBigDecimalFromString(EDataType eDataType, String initialValue) {
			EBigDecimal result = EBigDecimal.get(initialValue);
			if (result == null)
				throw new IllegalArgumentException(
						"The value '" + initialValue + "' is not a valid enumerator of '" + eDataType.getName() + "'");
			return result;
		}
		*/
		
		public String convertEBigDecimalToString(EDataType eDataType, object instanceValue) {
			return instanceValue == null ? null : instanceValue.ToString();
		}
		/*
		public EBigInteger createEBigIntegerFromString(EDataType eDataType, String initialValue) {
			EBigInteger result = EBigInteger.get(initialValue);
			if (result == null)
				throw new IllegalArgumentException(
						"The value '" + initialValue + "' is not a valid enumerator of '" + eDataType.getName() + "'");
			return result;
		}
		*/
		
		public String convertEBigIntegerToString(EDataType eDataType, object instanceValue) {
			return instanceValue == null ? null : instanceValue.ToString();
		}
		/*
		public EBoolean createEBooleanFromString(EDataType eDataType, String initialValue) {
			EBoolean result = EBoolean.get(initialValue);
			if (result == null)
				throw new IllegalArgumentException(
						"The value '" + initialValue + "' is not a valid enumerator of '" + eDataType.getName() + "'");
			return result;
		}
		*/
		
		public String convertEBooleanToString(EDataType eDataType, object instanceValue) {
			return instanceValue == null ? null : instanceValue.ToString();
		}
		/*
		public EBooleanObject createEBooleanObjectFromString(EDataType eDataType, String initialValue) {
			EBooleanObject result = EBooleanObject.get(initialValue);
			if (result == null)
				throw new IllegalArgumentException(
						"The value '" + initialValue + "' is not a valid enumerator of '" + eDataType.getName() + "'");
			return result;
		}
		*/
		
		public String convertEBooleanObjectToString(EDataType eDataType, object instanceValue) {
			return instanceValue == null ? null : instanceValue.ToString();
		}
		/*
		public EByte createEByteFromString(EDataType eDataType, String initialValue) {
			EByte result = EByte.get(initialValue);
			if (result == null)
				throw new IllegalArgumentException(
						"The value '" + initialValue + "' is not a valid enumerator of '" + eDataType.getName() + "'");
			return result;
		}
		*/
		
		public String convertEByteToString(EDataType eDataType, object instanceValue) {
			return instanceValue == null ? null : instanceValue.ToString();
		}
		/*
		public EByteArray createEByteArrayFromString(EDataType eDataType, String initialValue) {
			EByteArray result = EByteArray.get(initialValue);
			if (result == null)
				throw new IllegalArgumentException(
						"The value '" + initialValue + "' is not a valid enumerator of '" + eDataType.getName() + "'");
			return result;
		}
		*/
		
		public String convertEByteArrayToString(EDataType eDataType, object instanceValue) {
			return instanceValue == null ? null : instanceValue.ToString();
		}
		/*
		public EByteObject createEByteObjectFromString(EDataType eDataType, String initialValue) {
			EByteObject result = EByteObject.get(initialValue);
			if (result == null)
				throw new IllegalArgumentException(
						"The value '" + initialValue + "' is not a valid enumerator of '" + eDataType.getName() + "'");
			return result;
		}
		*/
		
		public String convertEByteObjectToString(EDataType eDataType, object instanceValue) {
			return instanceValue == null ? null : instanceValue.ToString();
		}
		/*
		public EChar createECharFromString(EDataType eDataType, String initialValue) {
			EChar result = EChar.get(initialValue);
			if (result == null)
				throw new IllegalArgumentException(
						"The value '" + initialValue + "' is not a valid enumerator of '" + eDataType.getName() + "'");
			return result;
		}
		*/
		
		public String convertECharToString(EDataType eDataType, object instanceValue) {
			return instanceValue == null ? null : instanceValue.ToString();
		}
		/*
		public ECharacterObject createECharacterObjectFromString(EDataType eDataType, String initialValue) {
			ECharacterObject result = ECharacterObject.get(initialValue);
			if (result == null)
				throw new IllegalArgumentException(
						"The value '" + initialValue + "' is not a valid enumerator of '" + eDataType.getName() + "'");
			return result;
		}
		*/
		
		public String convertECharacterObjectToString(EDataType eDataType, object instanceValue) {
			return instanceValue == null ? null : instanceValue.ToString();
		}
		/*
		public EDate createEDateFromString(EDataType eDataType, String initialValue) {
			EDate result = EDate.get(initialValue);
			if (result == null)
				throw new IllegalArgumentException(
						"The value '" + initialValue + "' is not a valid enumerator of '" + eDataType.getName() + "'");
			return result;
		}
		*/
		
		public String convertEDateToString(EDataType eDataType, object instanceValue) {
			return instanceValue == null ? null : instanceValue.ToString();
		}
		/*
		public EDiagnosticChain createEDiagnosticChainFromString(EDataType eDataType, String initialValue) {
			EDiagnosticChain result = EDiagnosticChain.get(initialValue);
			if (result == null)
				throw new IllegalArgumentException(
						"The value '" + initialValue + "' is not a valid enumerator of '" + eDataType.getName() + "'");
			return result;
		}
		*/
		
		public String convertEDiagnosticChainToString(EDataType eDataType, object instanceValue) {
			return instanceValue == null ? null : instanceValue.ToString();
		}
		/*
		public EDouble createEDoubleFromString(EDataType eDataType, String initialValue) {
			EDouble result = EDouble.get(initialValue);
			if (result == null)
				throw new IllegalArgumentException(
						"The value '" + initialValue + "' is not a valid enumerator of '" + eDataType.getName() + "'");
			return result;
		}
		*/
		
		public String convertEDoubleToString(EDataType eDataType, object instanceValue) {
			return instanceValue == null ? null : instanceValue.ToString();
		}
		/*
		public EDoubleObject createEDoubleObjectFromString(EDataType eDataType, String initialValue) {
			EDoubleObject result = EDoubleObject.get(initialValue);
			if (result == null)
				throw new IllegalArgumentException(
						"The value '" + initialValue + "' is not a valid enumerator of '" + eDataType.getName() + "'");
			return result;
		}
		*/
		
		public String convertEDoubleObjectToString(EDataType eDataType, object instanceValue) {
			return instanceValue == null ? null : instanceValue.ToString();
		}
		/*
		public EEList createEEListFromString(EDataType eDataType, String initialValue) {
			EEList result = EEList.get(initialValue);
			if (result == null)
				throw new IllegalArgumentException(
						"The value '" + initialValue + "' is not a valid enumerator of '" + eDataType.getName() + "'");
			return result;
		}
		*/
		
		public String convertEEListToString(EDataType eDataType, object instanceValue) {
			return instanceValue == null ? null : instanceValue.ToString();
		}
		/*
		public EEnumerator createEEnumeratorFromString(EDataType eDataType, String initialValue) {
			EEnumerator result = EEnumerator.get(initialValue);
			if (result == null)
				throw new IllegalArgumentException(
						"The value '" + initialValue + "' is not a valid enumerator of '" + eDataType.getName() + "'");
			return result;
		}
		*/
		
		public String convertEEnumeratorToString(EDataType eDataType, object instanceValue) {
			return instanceValue == null ? null : instanceValue.ToString();
		}
		/*
		public EFeatureMap createEFeatureMapFromString(EDataType eDataType, String initialValue) {
			EFeatureMap result = EFeatureMap.get(initialValue);
			if (result == null)
				throw new IllegalArgumentException(
						"The value '" + initialValue + "' is not a valid enumerator of '" + eDataType.getName() + "'");
			return result;
		}
		*/
		
		public String convertEFeatureMapToString(EDataType eDataType, object instanceValue) {
			return instanceValue == null ? null : instanceValue.ToString();
		}
		/*
		public EFeatureMapEntry createEFeatureMapEntryFromString(EDataType eDataType, String initialValue) {
			EFeatureMapEntry result = EFeatureMapEntry.get(initialValue);
			if (result == null)
				throw new IllegalArgumentException(
						"The value '" + initialValue + "' is not a valid enumerator of '" + eDataType.getName() + "'");
			return result;
		}
		*/
		
		public String convertEFeatureMapEntryToString(EDataType eDataType, object instanceValue) {
			return instanceValue == null ? null : instanceValue.ToString();
		}
		/*
		public EFloat createEFloatFromString(EDataType eDataType, String initialValue) {
			EFloat result = EFloat.get(initialValue);
			if (result == null)
				throw new IllegalArgumentException(
						"The value '" + initialValue + "' is not a valid enumerator of '" + eDataType.getName() + "'");
			return result;
		}
		*/
		
		public String convertEFloatToString(EDataType eDataType, object instanceValue) {
			return instanceValue == null ? null : instanceValue.ToString();
		}
		/*
		public EFloatObject createEFloatObjectFromString(EDataType eDataType, String initialValue) {
			EFloatObject result = EFloatObject.get(initialValue);
			if (result == null)
				throw new IllegalArgumentException(
						"The value '" + initialValue + "' is not a valid enumerator of '" + eDataType.getName() + "'");
			return result;
		}
		*/
		
		public String convertEFloatObjectToString(EDataType eDataType, object instanceValue) {
			return instanceValue == null ? null : instanceValue.ToString();
		}
		/*
		public EInt createEIntFromString(EDataType eDataType, String initialValue) {
			EInt result = EInt.get(initialValue);
			if (result == null)
				throw new IllegalArgumentException(
						"The value '" + initialValue + "' is not a valid enumerator of '" + eDataType.getName() + "'");
			return result;
		}
		*/
		
		public String convertEIntToString(EDataType eDataType, object instanceValue) {
			return instanceValue == null ? null : instanceValue.ToString();
		}
		/*
		public EIntegerObject createEIntegerObjectFromString(EDataType eDataType, String initialValue) {
			EIntegerObject result = EIntegerObject.get(initialValue);
			if (result == null)
				throw new IllegalArgumentException(
						"The value '" + initialValue + "' is not a valid enumerator of '" + eDataType.getName() + "'");
			return result;
		}
		*/
		
		public String convertEIntegerObjectToString(EDataType eDataType, object instanceValue) {
			return instanceValue == null ? null : instanceValue.ToString();
		}
		/*
		public EJavaClass createEJavaClassFromString(EDataType eDataType, String initialValue) {
			EJavaClass result = EJavaClass.get(initialValue);
			if (result == null)
				throw new IllegalArgumentException(
						"The value '" + initialValue + "' is not a valid enumerator of '" + eDataType.getName() + "'");
			return result;
		}
		*/
		
		public String convertEJavaClassToString(EDataType eDataType, object instanceValue) {
			return instanceValue == null ? null : instanceValue.ToString();
		}
		/*
		public EJavaObject createEJavaObjectFromString(EDataType eDataType, String initialValue) {
			EJavaObject result = EJavaObject.get(initialValue);
			if (result == null)
				throw new IllegalArgumentException(
						"The value '" + initialValue + "' is not a valid enumerator of '" + eDataType.getName() + "'");
			return result;
		}
		*/
		
		public String convertEJavaObjectToString(EDataType eDataType, object instanceValue) {
			return instanceValue == null ? null : instanceValue.ToString();
		}
		/*
		public ELong createELongFromString(EDataType eDataType, String initialValue) {
			ELong result = ELong.get(initialValue);
			if (result == null)
				throw new IllegalArgumentException(
						"The value '" + initialValue + "' is not a valid enumerator of '" + eDataType.getName() + "'");
			return result;
		}
		*/
		
		public String convertELongToString(EDataType eDataType, object instanceValue) {
			return instanceValue == null ? null : instanceValue.ToString();
		}
		/*
		public ELongObject createELongObjectFromString(EDataType eDataType, String initialValue) {
			ELongObject result = ELongObject.get(initialValue);
			if (result == null)
				throw new IllegalArgumentException(
						"The value '" + initialValue + "' is not a valid enumerator of '" + eDataType.getName() + "'");
			return result;
		}
		*/
		
		public String convertELongObjectToString(EDataType eDataType, object instanceValue) {
			return instanceValue == null ? null : instanceValue.ToString();
		}
		/*
		public EMap createEMapFromString(EDataType eDataType, String initialValue) {
			EMap result = EMap.get(initialValue);
			if (result == null)
				throw new IllegalArgumentException(
						"The value '" + initialValue + "' is not a valid enumerator of '" + eDataType.getName() + "'");
			return result;
		}
		*/
		
		public String convertEMapToString(EDataType eDataType, object instanceValue) {
			return instanceValue == null ? null : instanceValue.ToString();
		}
		/*
		public EResource createEResourceFromString(EDataType eDataType, String initialValue) {
			EResource result = EResource.get(initialValue);
			if (result == null)
				throw new IllegalArgumentException(
						"The value '" + initialValue + "' is not a valid enumerator of '" + eDataType.getName() + "'");
			return result;
		}
		*/
		
		public String convertEResourceToString(EDataType eDataType, object instanceValue) {
			return instanceValue == null ? null : instanceValue.ToString();
		}
		/*
		public EResourceSet createEResourceSetFromString(EDataType eDataType, String initialValue) {
			EResourceSet result = EResourceSet.get(initialValue);
			if (result == null)
				throw new IllegalArgumentException(
						"The value '" + initialValue + "' is not a valid enumerator of '" + eDataType.getName() + "'");
			return result;
		}
		*/
		
		public String convertEResourceSetToString(EDataType eDataType, object instanceValue) {
			return instanceValue == null ? null : instanceValue.ToString();
		}
		/*
		public EShort createEShortFromString(EDataType eDataType, String initialValue) {
			EShort result = EShort.get(initialValue);
			if (result == null)
				throw new IllegalArgumentException(
						"The value '" + initialValue + "' is not a valid enumerator of '" + eDataType.getName() + "'");
			return result;
		}
		*/
		
		public String convertEShortToString(EDataType eDataType, object instanceValue) {
			return instanceValue == null ? null : instanceValue.ToString();
		}
		/*
		public EShortObject createEShortObjectFromString(EDataType eDataType, String initialValue) {
			EShortObject result = EShortObject.get(initialValue);
			if (result == null)
				throw new IllegalArgumentException(
						"The value '" + initialValue + "' is not a valid enumerator of '" + eDataType.getName() + "'");
			return result;
		}
		*/
		
		public String convertEShortObjectToString(EDataType eDataType, object instanceValue) {
			return instanceValue == null ? null : instanceValue.ToString();
		}
		/*
		public EString createEStringFromString(EDataType eDataType, String initialValue) {
			EString result = EString.get(initialValue);
			if (result == null)
				throw new IllegalArgumentException(
						"The value '" + initialValue + "' is not a valid enumerator of '" + eDataType.getName() + "'");
			return result;
		}
		*/
		
		public String convertEStringToString(EDataType eDataType, object instanceValue) {
			return instanceValue == null ? null : instanceValue.ToString();
		}
		/*
		public ETreeIterator createETreeIteratorFromString(EDataType eDataType, String initialValue) {
			ETreeIterator result = ETreeIterator.get(initialValue);
			if (result == null)
				throw new IllegalArgumentException(
						"The value '" + initialValue + "' is not a valid enumerator of '" + eDataType.getName() + "'");
			return result;
		}
		*/
		
		public String convertETreeIteratorToString(EDataType eDataType, object instanceValue) {
			return instanceValue == null ? null : instanceValue.ToString();
		}
		/*
		public EInvocationTargetException createEInvocationTargetExceptionFromString(EDataType eDataType, String initialValue) {
			EInvocationTargetException result = EInvocationTargetException.get(initialValue);
			if (result == null)
				throw new IllegalArgumentException(
						"The value '" + initialValue + "' is not a valid enumerator of '" + eDataType.getName() + "'");
			return result;
		}
		*/
		
		public String convertEInvocationTargetExceptionToString(EDataType eDataType, object instanceValue) {
			return instanceValue == null ? null : instanceValue.ToString();
		}
		
		
		/*
		public EcorePackage getEcore() {
			return (EcorePackage) getEPackage();
		}
		*/

	
	}
}
