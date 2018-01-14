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
using System.Threading.Tasks;

namespace Ecore
{
    public class EObjectValidator : EValidator
    {

        public const string DIAGNOSTIC_SOURCE = "org.eclipse.emf.ecore";
        public const int EOBJECT__EVERY_MULTIPCITY_CONFORMS = 1;
        public const int EOBJECT__EVERY_DATA_VALUE_CONFORMS = 2;
        public const int EOBJECT__EVERY_REFERENCE_IS_CONTAINED = 3;
        public const int EOBJECT__EVERY_PROXY_RESOLVES = 4;
        public const int DATA_VALUE__VALUE_IN_RANGE = 5;
        public const int DATA_VALUE__LENGTH_IN_RANGE = 6;
        public const int DATA_VALUE__TYPE_CORRECT = 7;
        public const int DATA_VALUE__VALUE_IN_ENUMERATION = 8;
        public const int DATA_VALUE__MATCHES_PATTERN = 9;
        public const int DATA_VALUE__TOTAL_DIGITS_IN_RANGE = 10;
        public const int DATA_VALUE__FRACTION_DIGITS_IN_RANGE = 11;
        public const int EOBJECT__UNIQUE_ID = 12;
        public const int EOBJECT__EVERY_KEY_UNIQUE = 13;
        public const int EOBJECT__EVERY_MAP_ENTRY_UNIQUE = 14;
        public const int EOBJECT__NO_CIRCULAR_CONTAINMENT = 15;
        public const int EOBJECT__EVERY_BIDIRECTIONAL_REFERENCE_IS_PAIRED = 16;

        public const string ROOT_OBJECT = "org.eclipse.emf.ecore.EObject_NoCircularContainment";

        public bool validate_EveryDataValueConforms(EObject eObject, DiagnosticChain diagnostics, Dictionary<object, object> context)
        {
            bool result = true;
            foreach (EAttribute eAttribute in eObject.eClass().eAllAttributes)
            {
                result &= validate_DataValueConforms(eObject, eAttribute, diagnostics, context);
                if (!result && diagnostics == null)
                {
                    return false;
                }
            }
            return result;
        }



        protected EValidator getRootEValidator(Dictionary<object, object> context)
        {

            if (context != null && context.ContainsKey(typeof(EValidator)))
            {
               
                EValidator result = (EValidator)context[typeof(EValidator)];
                if (result != null)
                {
                    return result;
                }
            }

            return Diagnostician.INSTANCE;
        }

        protected DiagnosticChain createBadDataValueDiagnostic
  (EObject eObject, EAttribute eAttribute, DiagnosticChain diagnostics, Dictionary<object, object> context)
        {
            BasicDiagnostic diagnostic =
              createDiagnostic
                (BasicDiagnostic.ERROR,
                 DIAGNOSTIC_SOURCE,
                 EOBJECT__EVERY_DATA_VALUE_CONFORMS,
                 "_UI_BadDataValue_diagnostic",
                 new Object[]
                 {
           getFeatureLabel(eAttribute, context),
           getObjectLabel(eObject, context)
                 },
                 new Object[] { eObject, eAttribute },
                 context);
            diagnostics.add(diagnostic);
            return diagnostic;
        }

        protected BasicDiagnostic createDiagnostic
    (int severity, string source, int code, string messageKey, object[] messageSubstitutions, object[] data, Dictionary<object, object> context)
        {
            string message =
              DIAGNOSTIC_SOURCE.Equals(source) ?
                getEcoreString(messageKey, messageSubstitutions) :
                getString(messageKey, messageSubstitutions);
            return new BasicDiagnostic(severity, source, code, message, data);
        }

        protected string getString(string key, object[] substitutions)
        {
            return getString(isEcoreString(key) ? getEcoreResourceLocator() : getResourceLocator(), key, substitutions);
        }

        protected string getEcoreString(String key, Object[] substitutions)
        {
            return getString(getEcoreResourceLocator(), key, substitutions);
        }

        
        
        protected ResourceLocator getResourceLocator()
        {
            return getEcoreResourceLocator();
        }

        protected ResourceLocator getEcoreResourceLocator()
        {
            return ResourceLocator.INSTANCE;// EcorePlugin.INSTANCE;
        }

        private string getString(ResourceLocator resourceLocator, String key, Object[] substitutions)
        {
            return substitutions == null ? resourceLocator.getString(key) : resourceLocator.getString(key, substitutions);
        }

        /**
         * @since 2.6
         */
        protected bool isEcoreString(string key)
        {
            return "_UI_GenericConstraint_diagnostic".Equals(key) || "_UI_GenericInvariant_diagnostic".Equals(key)
              || "_UI_ConstraintDelegateException_diagnostic".Equals(key) || "_UI_InvariantDelegateException_diagnostic".Equals(key)
              || "_UI_ConstraintDelegateNotFound_diagnostic".Equals(key) || "_UI_InvariantDelegateNotFound_diagnostic".Equals(key);
        }


        /**
         * @since 2.1.0
         */
        public static string getObjectLabel(EObject eObject, Dictionary<object, object> context)
        {
            /*
            if (context != null)
            {
                SubstitutionLabelProvider substitutionlabelProvider = (SubstitutionLabelProvider)context[typeof(SubstitutionLabelProvider)];
                if (substitutionlabelProvider != null)
                {
                return substitutionlabelProvider.getObjectLabel(eObject);
                }
            }
            */
            return EcoreUtil.getIdentification(eObject);
        }

        protected EPackage getEPackage()
        {
            return EcorePackageImpl.eINSTANCE;
        }


        /**
         * @since 2.1.0
         */
        public static string getFeatureLabel(EStructuralFeature eStructuralFeature, Dictionary<object, object> context)
        {
            /*
            if (context != null)
            {
                //TODO check containskey
                SubstitutionLabelProvider substitutionlabelProvider = (SubstitutionLabelProvider)context[typeof(SubstitutionLabelProvider)];
                if (substitutionlabelProvider != null)
                {
                    return substitutionlabelProvider.getFeatureLabel(eStructuralFeature);
                }
            }
            */
            return eStructuralFeature.name;
        }

        /*
        protected string getEcoreString(string key, object[] substitutions)
        {
            return getString(getEcoreResourceLocator(), key, substitutions);
        }
        */

        /*
        private string getString(ResourceLocator resourceLocator, string key, object[] substitutions)
        {
            return substitutions == null ? resourceLocator.getString(key) : resourceLocator.getString(key, substitutions);
        }
        */

        protected virtual bool validate(int classifierID, object obj, DiagnosticChain diagnostics, Dictionary<object, object> context)
        {
            return classifierID != EcorePackageImpl.EOBJECT || validate_EveryDefaultConstraint((EObject)obj, diagnostics, context);
        }

        public bool validate_NoCircularContainment(EObject eObject, DiagnosticChain diagnostics, Dictionary<object, object> context)
        {
            if (context != null)
            {
                Object root = context[ROOT_OBJECT];
                if (root == null)
                {
                    context.Add(ROOT_OBJECT, eObject);
                }
                else if (root == eObject)
                {
                    if (diagnostics != null)
                    {
                        diagnostics.add
                          (createDiagnostic
                            (BasicDiagnostic.ERROR,
                             DIAGNOSTIC_SOURCE,
                             EOBJECT__NO_CIRCULAR_CONTAINMENT,
                             "_UI_CircularContainment_diagnostic",
                              new Object[]
                              {
                  getObjectLabel(eObject, context),
                              },
                             new Object[] { eObject },
                             context));
                    }
                    return false;
                }
            }
            return true;
        }

        public bool validate_EveryMultiplicityConforms(EObject eObject, DiagnosticChain diagnostics, Dictionary<object, object> context)
        {
            bool result = true;
            EClass eClass = eObject.eClass();
            for (int i = 0, size = eClass.getFeatureCount(); i < size; ++i)
            {
                result &= validate_MultiplicityConforms(eObject, eClass.getEStructuralFeature(i), diagnostics, context);
                if (!result && diagnostics == null)
                {
                    return false;
                }
            }
            return result;
        }

        protected bool validate_MultiplicityConforms
          (EObject eObject, EStructuralFeature eStructuralFeature, DiagnosticChain diagnostics, Dictionary<object, object> context)
        {
            bool result = true;
            if (eStructuralFeature.many)
            {
                if (false) {
                    /*
                    if (FeatureMapUtil.isFeatureMap(eStructuralFeature) && ExtendedMetaData.INSTANCE.isDocumentRoot(eObject.eClass()))
                    {
                        FeatureMap featureMap = (FeatureMap)eObject.eGet(eStructuralFeature);
                        int count = 0;
                        for (int i = 0, size = featureMap.size(); i < size; ++i)
                        {
                            EStructuralFeature feature = featureMap.getEStructuralFeature(i);
                            int kind = ExtendedMetaData.INSTANCE.getFeatureKind(feature);
                            if (kind == ExtendedMetaData.ELEMENT_FEATURE &&
                                  feature != XMLTypePackage.Literals.XML_TYPE_DOCUMENT_ROOT__CDATA &&
                                  feature != XMLTypePackage.Literals.XML_TYPE_DOCUMENT_ROOT__COMMENT &&
                                  feature != XMLTypePackage.Literals.XML_TYPE_DOCUMENT_ROOT__TEXT &&
                                  feature != XMLTypePackage.Literals.XML_TYPE_DOCUMENT_ROOT__PROCESSING_INSTRUCTION &&
                                  ++count > 1)
                            {
                                result = false;
                                break;
                            }
                        }
                        if (count != 1)
                        {
                            result = false;
                            if (diagnostics != null)
                            {
                                diagnostics.add
                                  (createDiagnostic
                                    (Diagnostic.ERROR,
                                     DIAGNOSTIC_SOURCE,
                                     EOBJECT__EVERY_MULTIPCITY_CONFORMS,
                                     "_UI_DocumentRootMustHaveOneElement_diagnostic",
                                      new Object[]
                                      {
                        getFeatureLabel(eStructuralFeature, context),
                        getObjectLabel(eObject, context),
                        count
                                      },
                                     new Object[] { eObject, eStructuralFeature },
                                     context));
                            }
                        }
                    */
                }
                else
                {
                    int lowerBound = eStructuralFeature.lowerBound;
                    if (lowerBound > 0)
                    {
                        int size = ((List<object>)eObject.eGet(eStructuralFeature)).Count;
                        if (size < lowerBound)
                        {
                            result = false;
                            if (diagnostics != null)
                            {
                                diagnostics.add
                                  (createDiagnostic
                                    (BasicDiagnostic.ERROR,
                                     DIAGNOSTIC_SOURCE,
                                     EOBJECT__EVERY_MULTIPCITY_CONFORMS,
                                     "_UI_FeatureHasTooFewValues_diagnostic",
                                      new Object[]
                                      {
                      getFeatureLabel(eStructuralFeature, context),
                      getObjectLabel(eObject, context),
                      size,
                      lowerBound
                                      },
                                     new Object[] { eObject, eStructuralFeature },
                                     context));
                            }
                        }
                        int upperBound = eStructuralFeature.upperBound;
                        if (upperBound > 0 && size > upperBound)
                        {
                            result = false;
                            if (diagnostics != null)
                            {
                                diagnostics.add
                                  (createDiagnostic
                                    (BasicDiagnostic.ERROR,
                                     DIAGNOSTIC_SOURCE,
                                     EOBJECT__EVERY_MULTIPCITY_CONFORMS,
                                     "_UI_FeatureHasTooManyValues_diagnostic",
                                     new Object[]
                                     {
                     getFeatureLabel(eStructuralFeature, context),
                     getObjectLabel(eObject, context),
                     size,
                     upperBound
                                     },
                                     new Object[] { eObject, eStructuralFeature },
                                     context));
                            }
                        }
                    }
                    else
                    {
                        int upperBound = eStructuralFeature.upperBound;
                        if (upperBound > 0)
                        {
                            int size = ((List<object>)eObject.eGet(eStructuralFeature)).Count;
                            if (size > upperBound)
                            {
                                result = false;
                                if (diagnostics != null)
                                {
                                    diagnostics.add
                                      (createDiagnostic
                                        (BasicDiagnostic.ERROR,
                                         DIAGNOSTIC_SOURCE,
                                         EOBJECT__EVERY_MULTIPCITY_CONFORMS,
                                         "_UI_FeatureHasTooManyValues_diagnostic",
                                         new Object[]
                                         {
                       getFeatureLabel(eStructuralFeature, context),
                       getObjectLabel(eObject, context),
                       size,
                       upperBound
                                         },
                                         new Object[] { eObject, eStructuralFeature },
                                         context));
                                }
                            }
                        }
                    }
                }
            }
            else if (eStructuralFeature.required)
            {
                if (eStructuralFeature.unsettable ? !eObject.eIsSet(eStructuralFeature) : eObject.eGet(eStructuralFeature, false) == null)
                {
                    result = false;
                    if (diagnostics != null)
                    {
                        diagnostics.add
                          (createDiagnostic
                            (BasicDiagnostic.ERROR,
                             DIAGNOSTIC_SOURCE,
                             EOBJECT__EVERY_MULTIPCITY_CONFORMS,
                             "_UI_RequiredFeatureMustBeSet_diagnostic",
                             new Object[] { getFeatureLabel(eStructuralFeature, context), getObjectLabel(eObject, context) },
                             new Object[] { eObject, eStructuralFeature },
                             context));
                    }
                }
            }

            return result;
        }

        public bool validate_EveryBidirectionalReferenceIsPaired(EObject eObject, DiagnosticChain diagnostics, Dictionary<object, object> context)
        {
            bool result = true;
            foreach (EReference eReference in eObject.eClass().eAllReferences)
            {
                if (eReference.resolveProxies)
                {
                    EReference eOpposite = eReference.eOpposite;
                    if (eOpposite != null)
                    {
                        result &= validate_BidirectionalReferenceIsPaired(eObject, eReference, eOpposite, diagnostics, context);
                        if (!result && diagnostics == null)
                        {
                            return false;
                        }
                    }
                }
            }
            return result;
        }

        public bool validate_BidirectionalReferenceIsPaired(EObject eObject, EReference eReference, EReference eOpposite, DiagnosticChain diagnostics, Dictionary<object, object> context)
        {
            bool result = true;
            Object value = eObject.eGet(eReference);
            if (eReference.many)
            {

              List<EObject> values = (List<EObject>)value;
                if (eOpposite.many)
                {
                    foreach (EObject oppositeEObject in values)
                    {

                      List<EObject> oppositeValues = (List<EObject>)oppositeEObject.eGet(eOpposite);
                        if (!oppositeValues.Contains(eObject))
                        {
                            result = false;
                            if (diagnostics != null)
                            {
                                // TODO
                                diagnostics.add
                                  (createDiagnostic
                                    (BasicDiagnostic.ERROR,
                                     DIAGNOSTIC_SOURCE,
                                     EOBJECT__EVERY_BIDIRECTIONAL_REFERENCE_IS_PAIRED,
                                     "_UI_UnpairedBidirectionalReference_diagnostic",
                                      new Object[]
                                      {
                      getFeatureLabel(eReference, context),
                      getObjectLabel(eObject, context),
                      getFeatureLabel(eOpposite, context),
                      getObjectLabel(oppositeEObject, context),
                                      },
                                     new Object[] { eObject, eReference, oppositeEObject, eOpposite },
                                     context));
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }
                else
                {
                    foreach (EObject oppositeEObject in values)
                    {
                        if (oppositeEObject.eGet(eOpposite) != eObject)
                        {
                            result = false;
                            if (diagnostics != null)
                            {
                                // TODO
                                diagnostics.add
                                  (createDiagnostic
                                    (BasicDiagnostic.ERROR,
                                     DIAGNOSTIC_SOURCE,
                                     EOBJECT__EVERY_BIDIRECTIONAL_REFERENCE_IS_PAIRED,
                                     "_UI_UnpairedBidirectionalReference_diagnostic",
                                      new Object[]
                                      {
                      getFeatureLabel(eReference, context),
                      getObjectLabel(eObject, context),
                      getFeatureLabel(eOpposite, context),
                      getObjectLabel(oppositeEObject, context),
                                      },
                                     new Object[] { eObject, eReference, oppositeEObject, eOpposite },
                                     context));
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }
            }
            else
            {
                EObject oppositeEObject = (EObject)value;
                if (oppositeEObject != null)
                {
                    if (eOpposite.many)
                    {

                      List<EObject> oppositeValues = (List<EObject>)oppositeEObject.eGet(eOpposite);
                        if (!oppositeValues.Contains(eObject))
                        {
                            result = false;
                            if (diagnostics != null)
                            {
                                // TODO
                                diagnostics.add
                                  (createDiagnostic
                                    (BasicDiagnostic.ERROR,
                                     DIAGNOSTIC_SOURCE,
                                     EOBJECT__EVERY_BIDIRECTIONAL_REFERENCE_IS_PAIRED,
                                     "_UI_UnpairedBidirectionalReference_diagnostic",
                                      new Object[]
                                      {
                      getFeatureLabel(eReference, context),
                      getObjectLabel(eObject, context),
                      getFeatureLabel(eOpposite, context),
                      getObjectLabel(oppositeEObject, context),
                                      },
                                     new Object[] { eObject, eReference, oppositeEObject, eOpposite },
                                     context));
                            }
                        }
                    }
                    else
                    {
                        if (oppositeEObject.eGet(eOpposite) != eObject)
                        {
                            result = false;
                            if (diagnostics != null)
                            {
                                diagnostics.add
                                  (createDiagnostic
                                    (BasicDiagnostic.ERROR,
                                     DIAGNOSTIC_SOURCE,
                                     EOBJECT__EVERY_BIDIRECTIONAL_REFERENCE_IS_PAIRED,
                                     "_UI_UnpairedBidirectionalReference_diagnostic",
                                      new Object[]
                                      {
                      getFeatureLabel(eReference, context),
                      getObjectLabel(eObject, context),
                      getFeatureLabel(eOpposite, context),
                      getObjectLabel(oppositeEObject, context),
                                      },
                                     new Object[] { eObject, eReference, oppositeEObject, eOpposite },
                                     context));
                            }
                        }
                    }
                }
            }
            return result;
        }

        public bool validate_EveryProxyResolves(EObject eObject, DiagnosticChain diagnostics, Dictionary<object, object> context)
        {
            bool result = true;

            foreach (EReference reference in eObject.eClass().eAllReferences)
            {

                if (eObject.eIsSet(reference))
                {

                    EObject eCrossReferenceObject = eObject.eGet(reference) as EObject;


                    if (eCrossReferenceObject.eIsProxy())
                    {
                        result = false;
                        if (diagnostics != null)
                        {
                            diagnostics.add
                              (createDiagnostic
                                (BasicDiagnostic.ERROR,
                                 DIAGNOSTIC_SOURCE,
                                 EOBJECT__EVERY_PROXY_RESOLVES,
                                 "_UI_UnresolvedProxy_diagnostic",
                                 new Object[]
                                 {
                 getFeatureLabel(reference, context),
                 getObjectLabel(eObject, context),
                 getObjectLabel(eCrossReferenceObject, context)
                                 },
                                 new Object[] { eObject, reference, eCrossReferenceObject },
                                 context));
                        }
                        else
                        {
                            break;
                        }
                    }

                }

                
            }


            //for (EContentsEList.FeatureIterator<EObject> i = (EContentsEList.FeatureIterator<EObject>)eObject.eCrossReferences().iterator(); i.hasNext();)
            /*
            foreach (EObject eCrossReferenceObject in eObject.eCrossReferences())
            {
                //EObject eCrossReferenceObject = i.next();
                if (eCrossReferenceObject.eIsProxy())
                {
                    result = false;
                    if (diagnostics != null)
                    {
                        diagnostics.add
                          (createDiagnostic
                            (BasicDiagnostic.ERROR,
                             DIAGNOSTIC_SOURCE,
                             EOBJECT__EVERY_PROXY_RESOLVES,
                             "_UI_UnresolvedProxy_diagnostic",
                             new Object[]
                             {
                 getFeatureLabel(i.feature(), context),
                 getObjectLabel(eObject, context),
                 getObjectLabel(eCrossReferenceObject, context)
                             },
                             new Object[] { eObject, i.feature(), eCrossReferenceObject },
                             context));
                    }
                    else
                    {
                        break;
                    }
                }
            }
            */
            return result;
        }

        public bool validate_EveryDefaultConstraint(EObject obj, DiagnosticChain theDiagnostics, Dictionary<object, object> context)
        {
            if (!validate_NoCircularContainment(obj, theDiagnostics, context))
            {
                return false;
            }
            bool result = validate_EveryMultiplicityConforms(obj, theDiagnostics, context);
            if (result || theDiagnostics != null)
            {
                result &= validate_EveryProxyResolves(obj, theDiagnostics, context);
            }
            if (result || theDiagnostics != null)
            {
                result &= validate_EveryReferenceIsContained(obj, theDiagnostics, context);
            }
            if (result || theDiagnostics != null)
            {
                result &= validate_EveryBidirectionalReferenceIsPaired(obj, theDiagnostics, context);
            }
            if (result || theDiagnostics != null)
            {
                result &= validate_EveryDataValueConforms(obj, theDiagnostics, context);
            }
            if (result || theDiagnostics != null)
            {
                result &= validate_UniqueID(obj, theDiagnostics, context);
            }
            if (result || theDiagnostics != null)
            {
                result &= validate_EveryKeyUnique(obj, theDiagnostics, context);
            }
            if (result || theDiagnostics != null)
            {
                result &= validate_EveryMapEntryUnique(obj, theDiagnostics, context);
            }
            return result;
        }

        public bool validate_EveryMapEntryUnique(EObject eObject, DiagnosticChain diagnostics, Dictionary<object, object> context)
        {
            bool result = true;
            /*
            EClass eClass = eObject.eClass();
            for (int i = 0, size = eClass.getFeatureCount(); i < size; ++i)
            {
                EStructuralFeature eStructuralFeature = eClass.getEStructuralFeature(i);
                if (eStructuralFeature.getEType().getInstanceClassName() == "java.util.Map$Entry" && eStructuralFeature instanceof EReference)
                  {
                            EReference eReference = (EReference)eStructuralFeature;
                            result &= validate_MapEntryUnique(eObject, eReference, diagnostics, context);
                            if (!result && diagnostics == null)
                            {
                                return false;
                            }
                        }
                    }
            */
           return result;
  }

    public bool validate_EveryKeyUnique(EObject eObject, DiagnosticChain diagnostics, Dictionary<object, object> context)
        {
            bool result = true;
            EClass eClass = eObject.eClass();
            for (int i = 0, size = eClass.getFeatureCount(); i < size; ++i)
            {
                EStructuralFeature eStructuralFeature = eClass.getEStructuralFeature(i);
                if (eStructuralFeature is EReference)
      {
                EReference eReference = (EReference)eStructuralFeature;
                if (eReference.many && !eReference.eKeys.isEmpty())
                {
                    result &= validate_KeyUnique(eObject, eReference, diagnostics, context);
                    if (!result && diagnostics == null)
                    {
                        return false;
                    }
                }
            }
        }
    return result;
  }
        protected bool validate_KeyUnique
          (EObject eObject, EReference eReference, DiagnosticChain diagnostics, Dictionary<object, object> context)
        {
            bool result = true;
            Dictionary<List<Object>, EObject> keys = new Dictionary<List<Object>, EObject>();
            List<EAttribute> eAttributes = eReference.eKeys;// (EAttribute[])((BasicEList <?>)eReference.getEKeys()).data();

          List<EObject> values = (List<EObject>)eObject.eGet(eReference);
            foreach (EObject value in values)
            {
                List<Object> key = new List<Object>();
                for (int i = 0, size = eAttributes.Count; i < size; ++i)
                {
                    EAttribute eAttribute = eAttributes[i];
                    if (eAttribute == null)
                    {
                        break;
                    }
                    else
                    {
                        key.Add(value.eGet(eAttribute));
                    }
                }
                EObject otherValue = null;
                if (keys.ContainsKey(key))
                {
                    otherValue = keys[key];
                }

                keys.Add(key, value);
                
                if (otherValue != null)
                {
                    result = false;
                    if (diagnostics == null)
                    {
                        break;
                    }
                    else
                    {
                        String uriFragmentSegment = ((InternalEObject)eObject).eURIFragmentSegment(eReference, value);
                        int index = uriFragmentSegment.IndexOf('[', 0);
                        if (index != -1)
                        {
                            uriFragmentSegment = uriFragmentSegment.Substring(index);
                        }
                        diagnostics.add
                          (createDiagnostic
                            (BasicDiagnostic.ERROR,
                             DIAGNOSTIC_SOURCE,
                             EOBJECT__EVERY_KEY_UNIQUE,
                             "_UI_DuplicateKey_diagnostic",
                             new Object[]
                             {
                 getFeatureLabel(eReference, context),
                 uriFragmentSegment,
                 getObjectLabel(value, context),
                 getObjectLabel(otherValue, context)
                             },
                             new Object[] { eObject, eReference, value, otherValue },
                             context));
                    }
                }
            }

            return result;
        }

        public bool validate_EveryReferenceIsContained(EObject eObject, DiagnosticChain diagnostics, Dictionary<object, object> context)
        {
            bool result = true;
            if (eObject.eResource() != null)
            {

                foreach (EReference reference in eObject.eClass().eAllReferences)
                {
                    if (eObject.eIsSet(reference))
                    {
                        EObject eCrossReferenceObject = eObject.eGet(reference) as EObject;

                        if (eCrossReferenceObject.eResource() == null && !eCrossReferenceObject.eIsProxy() && !reference.transient)
                        {
                            result = false;
                            if (diagnostics != null)
                            {
                                diagnostics.add
                                  (createDiagnostic
                                    (BasicDiagnostic.ERROR,
                                     DIAGNOSTIC_SOURCE,
                                     EOBJECT__EVERY_REFERENCE_IS_CONTAINED,
                                     "_UI_DanglingReference_diagnostic",
                                     new Object[]
                                     {
                   getFeatureLabel(reference, context),
                   getObjectLabel(eObject, context),
                   getObjectLabel(eCrossReferenceObject, context)
                                     },
                                     new Object[] { eObject, reference, eCrossReferenceObject },
                                     context));
                            }
                            else
                            {
                                break;
                            }
                        }
                    }    
                }

                /*
                for (EContentsEList.FeatureIterator<EObject> i = (EContentsEList.FeatureIterator<EObject>)eObject.eCrossReferences().iterator(); i.hasNext();)
                {
                    EObject eCrossReferenceObject = i.next();
                    if (eCrossReferenceObject.eResource() == null && !eCrossReferenceObject.eIsProxy() && !i.feature().isTransient())
                    {
                        result = false;
                        if (diagnostics != null)
                        {
                            diagnostics.add
                              (createDiagnostic
                                (BasicDiagnostic.ERROR,
                                 DIAGNOSTIC_SOURCE,
                                 EOBJECT__EVERY_REFERENCE_IS_CONTAINED,
                                 "_UI_DanglingReference_diagnostic",
                                 new Object[]
                                 {
                   getFeatureLabel(i.feature(), context),
                   getObjectLabel(eObject, context),
                   getObjectLabel(eCrossReferenceObject, context)
                                 },
                                 new Object[] { eObject, i.feature(), eCrossReferenceObject },
                                 context));
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                */
            }
            return result;
        }

        public bool validate_UniqueID(EObject eObject, DiagnosticChain diagnostics, Dictionary<object, object> context)
        {
            bool result = true;
            String id = EcoreUtil.getID(eObject);
            if (id != null)
            {
                Resource resource = eObject.eResource();
                if (resource != null)
                {
                    EObject otherEObject = resource.getEObject(id);
                    if (eObject != otherEObject && otherEObject != null)
                    {
                        result = false;
                        if (diagnostics != null)
                        {
                            diagnostics.add
                              (createDiagnostic
                                (BasicDiagnostic.ERROR,
                                 DIAGNOSTIC_SOURCE,
                                 EOBJECT__UNIQUE_ID,
                                 "_UI_DuplicateID_diagnostic",
                                 new Object[]
                                 {
                   id,
                   getObjectLabel(eObject, context),
                   getObjectLabel(otherEObject, context)
                                 },
                                 new Object[] { eObject, otherEObject, id },
                                 context));
                        }
                    }
                }
            }
            return result;
        }

        public virtual bool validate(EDataType eDataType, object value, DiagnosticChain diagnostics, Dictionary<object, object> context)
        {
            if (!eDataType.isInstance(value))
            {
                if (value == null)
                {
                    return true;
                }
                else
                {
                    if (diagnostics != null) reportDataValueTypeViolation(eDataType, value, diagnostics, context);
                    return false;
                }
            }

            if (eDataType.eContainer() == getEPackage())
            {
                return validate(eDataType.getClassifierID(), value, diagnostics, context);
            }
            else
            {
                return true;
                /*TODO
                return
                  new DynamicEDataTypeValidator(eDataType)
                  {
            // Ensure that the class loader for this class will be used downstream.
            //
        }.validate(eDataType, value, diagnostics, context);
        */
            }
        }

        protected void reportDataValueTypeViolation
  (EDataType eDataType, object value, DiagnosticChain diagnostics, Dictionary<object, object> context)
        {
            diagnostics.add
              (createDiagnostic
                (BasicDiagnostic.ERROR,
                 DIAGNOSTIC_SOURCE,
                 DATA_VALUE__TYPE_CORRECT,
                 "_UI_BadDataValueType_diagnostic",
                 new Object[]
                 {
           getValueLabel(eDataType, value, context),
           value == null ? "<null>" : value.GetType().Name,
           eDataType.instanceClassName
                 },
                 new Object[] { value, eDataType },
                 context));
        }

         /**
         * @since 2.1.0
         */
        public static string getValueLabel(EDataType eDataType, object value, Dictionary<object, object> context)
        {
            /*
            if (context != null)
            {
                SubstitutionLabelProvider substitutionlabelProvider = (SubstitutionLabelProvider)context.get(SubstitutionLabelProvider.class);
              if (substitutionlabelProvider != null)
              {
                return substitutionlabelProvider.getValueLabel(eDataType, value);
              }
        }
*/
            return EcoreUtil.convertToString(eDataType, value);
        }


        protected bool validate_DataValueConforms(EObject eObject, EAttribute eAttribute, DiagnosticChain diagnostics, Dictionary<object, object> context)
        {
            if (!eObject.eIsSet(eAttribute))
            {
                return true;
            }
            bool result = true;
            EDataType eDataType = eAttribute.eAttributeType;

            EValidator rootValidator = getRootEValidator(context);
            object value = eObject.eGet(eAttribute);

            /*
            if (FeatureMapUtil.isFeatureMap(eAttribute))
            {
                Collection<FeatureMap.Entry> featureMap = (Collection<FeatureMap.Entry>)value;
                EClass eClass = eObject.eClass();
                Dictionary<EStructuralFeature, DiagnosticChain> entryFeatureToDiagnosticChainMap = null;
                for (Iterator<FeatureMap.Entry> i = featureMap.iterator(); i.hasNext() && (result || diagnostics != null);)
                {
                    FeatureMap.Entry entry = i.next();
                    EStructuralFeature entryFeature = entry.getEStructuralFeature();
                    if (entryFeature instanceof EAttribute &&
                          ExtendedMetaData.INSTANCE.getAffiliation(eClass, entryFeature) == eAttribute)
                    {
                        EDataType entryType = (EDataType)entryFeature.getEType();
                        Object entryValue = entry.getValue();
                        bool entryIsValid = rootValidator.validate(entryType, entryValue, null, context);
                        if (!entryIsValid)
                        {
                            result = false;
                            if (diagnostics != null)
                            {
                                if (entryFeatureToDiagnosticChainMap == null)
                                {
                                    entryFeatureToDiagnosticChainMap = new HashMap<EStructuralFeature, DiagnosticChain>();
                                }
                                DiagnosticChain entryFeatureDiagnostic = entryFeatureToDiagnosticChainMap.get(entryFeature);
                                if (entryFeatureDiagnostic == null)
                                {
                                    entryFeatureDiagnostic = createBadDataValueDiagnostic(eObject, (EAttribute)entryFeature, diagnostics, context);
                                    entryFeatureToDiagnosticChainMap.put(entryFeature, entryFeatureDiagnostic);
                                }
                                rootValidator.validate(entryType, entryValue, entryFeatureDiagnostic, context);
                            }
                        }
                    }
                }
            }
            else*/
            if (eAttribute.many)
            {

                foreach (object item in value as IList<object>)
                {
                    result &= rootValidator.validate(eDataType, item, null, context);
                }


                if (!result && diagnostics != null)
                {
                    DiagnosticChain diagnostic = createBadDataValueDiagnostic(eObject, eAttribute, diagnostics, context);

                    foreach (object item in value as IList<object>)
                    {
                        rootValidator.validate(eDataType, item, diagnostic, context);
                    }
                }
            }
            else if (value != null)
            {
                result = rootValidator.validate(eDataType, value, null, context);
                if (!result && diagnostics != null)
                {
                    DiagnosticChain diagnostic = createBadDataValueDiagnostic(eObject, eAttribute, diagnostics, context);
                    rootValidator.validate(eDataType, value, diagnostic, context);
                }
            }

            return result;
        }

        /*
        public bool validate(EClass eClass, EObject eObject, DiagnosticChain diagnostics, Dictionary<object, object> context, string validationDelegate, string constraint, string expression, int severity, string source, int code)
        {
            ValidationDelegate delegate = getValidationDelegateRegistry(context).getValidationDelegate(validationDelegate);
            if (delegate != null)
            {
                try
                {
                    if (!delegate.validate(eClass, eObject, context, constraint, expression))
                    {
                        if (diagnostics != null)
                            reportConstraintDelegateViolation(eClass, eObject, diagnostics, context, constraint, severity, source, code);
                        return false;
                    }
                }
                catch (Throwable throwable)
                {
                    if (diagnostics != null)
                        reportConstraintDelegateException(eClass, eObject, diagnostics, context, constraint, severity, source, code, throwable);
                }
            }
            else
            {
                if (diagnostics != null)
                    reportConstraintDelegateNotFound(eClass, eObject, diagnostics, context, constraint, severity, source, code, validationDelegate);
            }
            return true;
        }
        */

        public bool validate(EClass eClass, EObject eObject, DiagnosticChain diagnostics, Dictionary<object, object> context, string validationDelegate, string constraint, bool expression, int severity, string source, int code)
        {

            if (!expression)
            {
                reportConstraintDelegateViolation(eClass, eObject, diagnostics, context, constraint, severity, source, code);
                return false;
            }
            else
            {
                return true;
            }
            
        }

        public virtual bool validate(EObject eObject, DiagnosticChain diagnostics, Dictionary<object, object> context)
        {
            return validate(eObject.eClass(), eObject, diagnostics, context);
        }

        public virtual bool validate(EClass eClass, EObject eObject, DiagnosticChain diagnostics, Dictionary<object, object> context)
        {
            if (eObject.eIsProxy())
            {
                if (context != null && context.ContainsKey(ROOT_OBJECT) && context[ROOT_OBJECT] != null)
                {
                    if (diagnostics != null)
                    {
                        diagnostics.add
                          (createDiagnostic
                            (BasicDiagnostic.ERROR,
                             DIAGNOSTIC_SOURCE,
                             EOBJECT__EVERY_PROXY_RESOLVES,
                             "_UI_UnresolvedProxy_diagnostic",
                             new Object[]
                             {
                 getFeatureLabel(eObject.eContainmentFeature(), context),
                 getObjectLabel(eObject.eContainer(), context),
                 getObjectLabel(eObject, context)
                             },
                             new Object[] { eObject.eContainer(), eObject.eContainmentFeature(), eObject },
                             context));
                    }
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else if (eClass.eContainer() == getEPackage())
            {
                return validate(eClass.getClassifierID(), eObject, diagnostics, context);
            }
            else
            {

                return true;
                /*
                return
                  new DynamicEClassValidator()
                  {
            // Ensure that the class loader for this class will be used downstream.
            //
        }.validate(eClass, eObject, diagnostics, context);
        */
            }
        }

        protected void reportConstraintDelegateViolation(EClass eClass, EObject eObject, DiagnosticChain diagnostics, Dictionary<object, object> context, string constraint, int severity, string source, int code)
        {
            diagnostics.add
              (new BasicDiagnostic
                (severity,
                 source,
                 code,
                 getString("_UI_GenericConstraint_diagnostic", new Object[] { constraint, getObjectLabel(eObject, context) }),
                 new Object[] { eObject }));
        }



    }
}
