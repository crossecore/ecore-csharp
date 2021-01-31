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
///<summary>This class was generated.</summary>
namespace Ecore
{

    public class EPackageImpl
    : EPackageBase
    {
        protected EcoreFactory ecoreFactory;
        protected EcorePackage ecorePackage;

        public EPackageImpl()
        {
            ecoreFactory = EcoreFactoryImpl.eINSTANCE;
            ecorePackage = EcorePackageImpl.eINSTANCE;

        }
        public EPackageImpl(String packageURI, EFactory factory) : base()
        {
            //TODO registry

            if (factory == EcoreFactoryImpl.eINSTANCE)
            {
                ecorePackage = (EcorePackage)this;
                ecoreFactory = (EcoreFactory)factory;
            }
            else
            {
                ecorePackage = EcorePackageImpl.eINSTANCE;
                ecoreFactory = EcoreFactoryImpl.eINSTANCE;
            }
        }

        public override EClassifier getEClassifier(string name)
        {


            foreach (EClassifier eclassifier in eClassifiers)
            {

                if (eclassifier.name==name)
                {
                    return eclassifier;
                }
            }

            return null;
        }


        protected EClass createEClass(int id)
        {
            EClassImpl c = (EClassImpl)ecoreFactory.createEClass();
            c.setClassifierID(id);
            eClassifiers.add(c);
            return c;
        }

        protected EEnum createEEnum(int id)
        {
            EEnumImpl e = (EEnumImpl)ecoreFactory.createEEnum();
            e.setClassifierID(id);
            eClassifiers.add(e);
            return e;
        }

        protected EDataType createEDataType(int id)
        {
            EDataTypeImpl d = (EDataTypeImpl)ecoreFactory.createEDataType();
            d.setClassifierID(id);
            eClassifiers.add(d);
            return d;
        }

        protected void createEAttribute(EClass owner, int id)
        {
            EAttributeImpl a = (EAttributeImpl)ecoreFactory.createEAttribute();
            a.setFeatureID(id);
            owner.eStructuralFeatures.add(a);
        }

        protected void createEReference(EClass owner, int id)
        {
            EReferenceImpl r = (EReferenceImpl)ecoreFactory.createEReference();
            r.setFeatureID(id);
            owner.eStructuralFeatures.add(r);
        }

        protected void createEOperation(EClass owner, int id)
        {
            EOperationImpl o = (EOperationImpl)ecoreFactory.createEOperation();
            o.setOperationID(id);
            owner.eOperations.add(o);
        }



        public const bool IS_ABSTRACT = true;
        public const bool IS_INTERFACE = true;
        public const bool IS_GENERATED_INSTANCE_CLASS = true;

        protected EClass initEClass(EClass c, Type instanceClass, string name, bool isAbstract, bool isInterface, bool isGenerated)
        {
            initEClassifier(c, ecorePackage.getEClass(), instanceClass, name, isGenerated);
            c.abstract_ = isAbstract;
            c.interface_ = isInterface;
            return c;
        }



        protected EClass initEClass
          (EClass c, Type instanceClass, string name, bool isAbstract, bool isInterface, bool isGenerated, string instanceTypeName)
        {
            initEClass(c, instanceClass, name, isAbstract, isInterface, isGenerated);
            if (instanceTypeName != null)
            {
                setInstanceTypeName(c, instanceTypeName);
            }
            return c;
        }

        protected EEnum initEEnum(EEnum e, Type instanceClass, string name)
        {
            initEClassifier(e, ecorePackage.getEEnum(), instanceClass, name, true);
            return e;
        }

        public const bool IS_SERIALIZABLE = true;

        protected EDataType initEDataType(EDataType d, Type instanceClass, string name, bool isSerializable)
        {
            initEClassifier(d, ecorePackage.getEDataType(), instanceClass, name, false);
            d.serializable = isSerializable;
            return d;
        }

        protected EDataType initEDataType(EDataType d, Type instanceClass, string name, bool isSerializable, bool isGenerated)
        {
            initEClassifier(d, ecorePackage.getEDataType(), instanceClass, name, isGenerated);
            d.serializable = isSerializable;
            return d;
        }

        protected EDataType initEDataType
          (EDataType d, Type instanceClass, string name, bool isSerializable, bool isGenerated, string instanceTypeName)
        {
            initEDataType(d, instanceClass, name, isSerializable, isGenerated);
            if (instanceTypeName != null)
            {
                setInstanceTypeName(d, instanceTypeName);
            }
            return d;
        }

        private void initEClassifier(EClassifier o, EClass metaObject, Type instanceClass, string name)
        {
            o.name = name;
            if (instanceClass != null)
            {
                //hack: Originally setInstanceClass was defined manually in the EClassifier interface. Manual changes to the interface are not allowed anymore.
                (o as EClassifierImpl).setInstanceClass(instanceClass);
            }
        }

        private void initEClassifier(EClassifier o, EClass metaObject, Type instanceClass, string name, bool isGenerated)
        {
            o.name = name;
            if (instanceClass != null)
            {
                //hack: Originally setInstanceClass was defined manually in the EClassifier interface. Manual changes to the interface are not allowed anymore.
                (o as EClassifierImpl).setInstanceClass(instanceClass);
            }
            if (isGenerated)
            {
                setGeneratedClassName(o);
            }
        }

        public void setInstanceClass(Type value)
        {
            /*
            if (value == null)
            {
                setInstanceClassNameGen(null);
                basicSetInstanceTypeName(null);
            }
            else if (value.isArray())
            {
                String indices = "[]";
                for (Class <?> component = value.getComponentType(); ; component = component.getComponentType())
                {
                    if (!component.isArray())
                    {
                        String name = (component.getName() + indices).intern();
                        setInstanceClassNameGen(name);
                        basicSetInstanceTypeName(name);
                        break;
                    }
                    indices += "[]";
                }
            }
            else
            {
                String name = value.getName().intern();
                setInstanceClassNameGen(name);
                basicSetInstanceTypeName(name);
            }

            setInstanceClassGen(value);
            */
        }

        protected void setGeneratedClassName(EClassifier eClassifier)
        {
            ((EClassifierImpl)eClassifier).setGeneratedInstanceClass(true);
        }

        protected void setInstanceTypeName(EClassifier eClassifier, string instanceTypeName)
        {
            ((EClassifierImpl)eClassifier).basicSetInstanceTypeName(instanceTypeName);
        }



        public const bool IS_DERIVED = true;
        public const bool IS_TRANSIENT = true;
        public const bool IS_VOLATILE = true;
        public const bool IS_CHANGEABLE = true;
        public const bool IS_UNSETTABLE = true;
        public const bool IS_UNIQUE = true;
        public const bool IS_ID = true;
        public const bool IS_ORDERED = true;

        protected EAttribute initEAttribute
  (EAttribute a,
   EClassifier type,
   String name,
   String defaultValue,
   int lowerBound,
   int upperBound,
   bool isTransient,
   bool isVolatile,
   bool isChangeable,
   bool isUnsettable,
   bool isID,
   bool isUnique,
   bool isDerived)
        {
            return
              initEAttribute
                (a,
                 type,
                 name,
                 defaultValue,
                 lowerBound,
                 upperBound,
                 isTransient,
                 isVolatile,
                 isChangeable,
                 isUnsettable,
                 isID,
                 isUnique,
                 isDerived,
                 true);
        }

        protected EAttribute initEAttribute
          (EAttribute a,
           EClassifier type,
           String name,
           String defaultValue,
           int lowerBound,
           int upperBound,
           bool isTransient,
           bool isVolatile,
           bool isChangeable,
           bool isUnsettable,
           bool isID,
           bool isUnique,
           bool isDerived,
           bool isOrdered)
        {
            initEAttribute
              (a,
               type,
               name,
               defaultValue,
               lowerBound,
               upperBound,
               ((EClassifier)a.eContainer()).instanceClass,
               isTransient,
               isVolatile,
               isChangeable,
               isUnsettable,
               isID,
               isUnique,
               isDerived,
               isOrdered);
            return a;
        }

        protected EAttribute initEAttribute
          (EAttribute a,
           EClassifier type,
           String name,
           String defaultValue,
           int lowerBound,
           int upperBound,
           Type containerClass,
           bool isTransient,
           bool isVolatile,
           bool isChangeable,
           bool isUnsettable,
           bool isID,
           bool isUnique,
           bool isDerived,
           bool isOrdered)
        {
            initEStructuralFeature
              (a,
               type,
               name,
               defaultValue,
               lowerBound,
               upperBound,
               containerClass,
               isTransient,
               isVolatile,
               isChangeable,
               isUnsettable,
               isUnique,
               isDerived,
               isOrdered);
            a.iD = isID;
            return a;
        }

        protected EAttribute initEAttribute
          (EAttribute a,
           EGenericType type,
           String name,
           String defaultValue,
           int lowerBound,
           int upperBound,
           Type containerClass,
           bool isTransient,
           bool isVolatile,
           bool isChangeable,
           bool isUnsettable,
           bool isID,
           bool isUnique,
           bool isDerived,
           bool isOrdered)
        {
            initEStructuralFeature
              (a,
               type,
               name,
               defaultValue,
               lowerBound,
               upperBound,
               containerClass,
               isTransient,
               isVolatile,
               isChangeable,
               isUnsettable,
               isUnique,
               isDerived,
               isOrdered);
            a.iD = isID;
            return a;
        }


        private void initEStructuralFeature
  (EStructuralFeature s,
   EClassifier type,
   String name,
   String defaultValue,
   int lowerBound,
   int upperBound,
   Type containerClass,
   bool isTransient,
   bool isVolatile,
   bool isChangeable,
   bool isUnsettable,
   bool isUnique,
   bool isDerived,
   bool isOrdered)
        {
            s.name = name;
            ((EStructuralFeatureImpl)s).containerClass = containerClass;
            s.transient = isTransient;
            s.volatile_ = isVolatile;
            s.changeable = isChangeable;
            s.unsettable = isUnsettable;
            s.unique = isUnique;
            s.derived = isDerived;
            s.ordered = isOrdered;
            s.lowerBound = lowerBound;
            s.upperBound = upperBound;
            s.eType = type;
            if (defaultValue != null)
            {
                s.defaultValueLiteral = defaultValue;
            }
        }

        private void initEStructuralFeature
          (EStructuralFeature s,
           EGenericType type,
           String name,
           String defaultValue,
           int lowerBound,
           int upperBound,
           Type containerClass,
           bool isTransient,
           bool isVolatile,
           bool isChangeable,
           bool isUnsettable,
           bool isUnique,
           bool isDerived,
           bool isOrdered)
        {
            s.name = name;
            ((EStructuralFeatureImpl)s).containerClass = containerClass;
            s.transient = isTransient;
            s.volatile_ = isVolatile;
            s.changeable = isChangeable;
            s.unsettable = isUnsettable;
            s.unique = isUnique;
            s.derived = isDerived;
            s.ordered = isOrdered;
            s.lowerBound = lowerBound;
            s.upperBound = upperBound;
            s.eGenericType = type;
            if (defaultValue != null)
            {
                s.defaultValueLiteral = defaultValue;
            }
        }


        public const bool IS_COMPOSITE = true;
        public const bool IS_RESOLVE_PROXIES = true;
        public const bool IS_RESOLVABLE = true;

        protected EReference initEReference
    (EReference r,
     EClassifier type,
     EReference otherEnd,
     String name,
     String defaultValue,
     int lowerBound,
     int upperBound,
     Type containerClass,
     bool isTransient,
     bool isVolatile,
     bool isChangeable,
     bool isContainment,
     bool isResolveProxies,
     bool isUnsettable,
     bool isUnique,
     bool isDerived,
     bool isOrdered)
        {
            initEStructuralFeature
              (r,
               type,
               name,
               defaultValue,
               lowerBound,
               upperBound,
               containerClass,
               isTransient,
               isVolatile,
               isChangeable,
               isUnsettable,
               isUnique,
               isDerived,
               isOrdered);
            r.containment = isContainment;
            if (otherEnd != null)
            {
                r.eOpposite = otherEnd;
            }
            r.resolveProxies = isResolveProxies;
            return r;
        }

        protected EReference initEReference
          (EReference r,
           EGenericType type,
           EReference otherEnd,
           String name,
           String defaultValue,
           int lowerBound,
           int upperBound,
           Type containerClass,
           bool isTransient,
           bool isVolatile,
           bool isChangeable,
           bool isContainment,
           bool isResolveProxies,
           bool isUnsettable,
           bool isUnique,
           bool isDerived,
           bool isOrdered)
        {
            initEStructuralFeature
              (r,
               type,
               name,
               defaultValue,
               lowerBound,
               upperBound,
               containerClass,
               isTransient,
               isVolatile,
               isChangeable,
               isUnsettable,
               isUnique,
               isDerived,
               isOrdered);
            r.containment = isContainment;
            if (otherEnd != null)
            {
                r.eOpposite = otherEnd;
            }
            r.resolveProxies = isResolveProxies;
            return r;
        }

    }

}
