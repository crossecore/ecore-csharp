/* CrossEcore is a cross-platform modeling framework that generates C#, TypeScript, 
 * JavaScript, Swift code from Ecore models with embedded OCL (http://www.crossecore.org/).
 * The original Eclipse Modeling Framework is available at https://www.eclipse.org/modeling/emf/.
 * 
 * contributor: Simon Schwichtenberg
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Ecore.Xmi
{
    public class XmiResource
    {

        private EPackage epackage;

        private Dictionary<EObject, EStructuralFeature> resolveFeature = new Dictionary<EObject, EStructuralFeature>();
        private Dictionary<EObject, string> resolvePath = new Dictionary<EObject, string>();
        //private Dictionary<string, EObject> resolvedEObject = new Dictionary<string, EObject>();

        private Dictionary<System.Tuple<EObject, EStructuralFeature>, string> resolve = new Dictionary<System.Tuple<EObject, EStructuralFeature>, string>();

        public EObject Load(string path) {
            var doc = new XmlDocument();
            doc.Load(path);

            handleEPackage(doc.DocumentElement);


            return epackage;
        }

        public EAnnotation handleEAnnotation(XmlNode node)
        {
            var eannotation = EcoreFactoryImpl.eINSTANCE.createEAnnotation();
            eannotation.source = node.Attributes["source"]?.InnerText;

            foreach (XmlNode child in node.ChildNodes)
            {

                if (child.LocalName == "details")
                {
                    var eStringToStringMapEntry = handleEStringToStringMapEntry(child);
                    eannotation.details.add(eStringToStringMapEntry);

                }

            }
            return eannotation;
        }

        public EStringToStringMapEntry handleEStringToStringMapEntry(XmlNode node) {

            var estringtostringmapentry = EcoreFactoryImpl.eINSTANCE.createEStringToStringMapEntry();
            estringtostringmapentry.key = node.Attributes["key"]?.InnerText;
            estringtostringmapentry.value = node.Attributes["value"]?.InnerText;
            return estringtostringmapentry;
        }

        public EPackage handleEPackage(XmlNode node)
        {
            epackage = EcoreFactoryImpl.eINSTANCE.createEPackage();
            epackage.name = node.Attributes["name"]?.InnerText;
            epackage.nsPrefix = node.Attributes["name"]?.InnerText;
            epackage.nsURI = node.Attributes["nsURI"]?.InnerText;


            EClassifier eclassifier = null;

            foreach (XmlNode child in node.ChildNodes)
            {
                if (child.LocalName == "eClassifiers" && child.Attributes["xsi:type"].InnerText == "ecore:EClass")
                {
                    eclassifier = handleEClass(child);
                    epackage.eClassifiers.add(eclassifier);


                }
                else if (child.LocalName == "eClassifiers" && child.Attributes["xsi:type"].InnerText == "ecore:EDataType")
                {
                    eclassifier = handleEDataType(child);
                    epackage.eClassifiers.add(eclassifier);

                }
                else if (child.LocalName == "eClassifiers" && child.Attributes["xsi:type"].InnerText == "ecore:EEnum")
                {
                    eclassifier = handleEEnum(child);
                    epackage.eClassifiers.add(eclassifier);

                }
                else if (child.LocalName == "eAnnotations")
                {
                    var eannotation = handleEAnnotation(child);
                    epackage.eAnnotations.add(eannotation);

                }

            }


            foreach (System.Tuple<EObject, EStructuralFeature> pair in resolve.Keys)
            {
                var eobject = pair.Item1;
                var estructuralfeature = pair.Item2;
                var path = resolve[pair];

                

                if (estructuralfeature.many)
                {
                    var target = resolveEList(path);
                    eobject.eSet(estructuralfeature, target);
                }
                else
                {
                    var target = resolveEObject(path);
                    eobject.eSet(estructuralfeature, target);
                }

                
            }

            return epackage;
        }

        public string caseEPackage(EPackage epackage)
        {
            return $"<ecore:EPackage xmi:version=\"2.0\" xmlns:xmi=\"http://www.omg.org/XMI\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns: ecore = \"http://www.eclipse.org/emf/2002/Ecore\" name = \"{epackage.name}\" nsURI = \"{epackage.nsURI}\" nsPrefix = \"{epackage.nsPrefix}\" >";
        }


        public EDataType handleEDataType(XmlNode node)
        {

            var edatatype = EcoreFactoryImpl.eINSTANCE.createEDataType();


            edatatype.name = node.Attributes["name"]?.InnerText;

            edatatype.serializable = getBoolean(node.Attributes["serializable"]?.InnerText, edatatype.serializable);
            edatatype.instanceTypeName = node.Attributes["instanceTypeName"]?.InnerText;

            foreach (XmlNode child in node.ChildNodes)
            {
                if (child.LocalName == "eTypeParameters")
                {
                    var etypeparameter = handleETypeParameter(child);
                    edatatype.eTypeParameters.add(etypeparameter);
                }
                else if (child.LocalName == "eAnnotations")
                {

                    var eannotation = handleEAnnotation(child);
                    epackage.eAnnotations.add(eannotation);

                }

            }

            return edatatype;
        }
    


        private void register(EObject eobject, EStructuralFeature estructuralfeature, string path)
        {
            var pair = new System.Tuple<EObject, EStructuralFeature>(eobject, estructuralfeature);

            resolve.Add(pair, path);


        }


        public EClass handleEClass(XmlNode node)
        {

            var eclass = EcoreFactoryImpl.eINSTANCE.createEClass();
            
            eclass.name = node.Attributes["name"]?.InnerText;
            eclass.abstract_ = getBoolean(node.Attributes["abstract"]?.InnerText, eclass.abstract_);
            eclass.interface_ = getBoolean(node.Attributes["interface"]?.InnerText, eclass.interface_);

            register(eclass, EcorePackageImpl.Literals.ECLASS_ESUPERTYPES, node.Attributes["eSuperTypes"]?.InnerText);

            foreach (XmlNode child in node.ChildNodes)
            {
                if (child.LocalName == "eStructuralFeatures" && child.Attributes["xsi:type"]?.InnerText == "ecore:EReference")
                {
                    var estructuralfeature = handleEReference(child);
                    eclass.eStructuralFeatures.add(estructuralfeature);
                }
                else if (child.LocalName == "eStructuralFeatures" && child.Attributes["xsi:type"]?.InnerText == "ecore:EAttribute")
                {
                    var estructuralfeature = handleEAttribute(child);
                    eclass.eStructuralFeatures.add(estructuralfeature);
                }
                else if (child.LocalName == "eTypeParameters")
                {
                    var etypeparameter = handleETypeParameter(child);
                    eclass.eTypeParameters.add(etypeparameter);
                }
                else if (child.LocalName == "eOperations")
                {
                    var eoperation = handleEOperation(child);
                    eclass.eOperations.add(eoperation);
                }
                else if (child.LocalName == "eAnnotations")
                {
                    var eannotation = handleEAnnotation(child);
                    eclass.eAnnotations.add(eannotation);

                }
            }

            return eclass;
        }



        public string caseEClass(EClass eclass)
        {
            return $"<eClassifiers xsi:type=\"ecore:EClass\" name=\"{eclass.name}\" abstract=\"{eclass.abstract_}\" interface=\"{eclass.interface_}\"/>";
        }

        protected IList<EObject> resolveEList(string specification)
        {


            var result = new List<EObject>();
            var supertypes = specification?.Split(' ');

            if (supertypes != null)
            {
                foreach (string s in supertypes)
                {
                    var supertype = resolveEObject(s) as EClass;
                    //TODO assure it is eclass
                    result.Add(supertype);
                }
            }
            return result;
        }

        protected EObject resolveEObject(string specification)
        {


            if (specification==null)
            {
                return null;
            }
            else if (specification.StartsWith("ecore:EDataType"))
            {
                if (specification.EndsWith("http://www.eclipse.org/emf/2002/Ecore#//EBigDecimal"))
                {
                    return EcorePackageImpl.Literals.EBIGDECIMAL;
                }
                else if (specification.EndsWith("http://www.eclipse.org/emf/2002/Ecore#//EBigInteger"))
                {
                    return EcorePackageImpl.Literals.EBIGINTEGER;
                }
                else if (specification.EndsWith("http://www.eclipse.org/emf/2002/Ecore#//EBoolean"))
                {
                    return EcorePackageImpl.Literals.EBOOLEAN;
                }
                else if (specification.EndsWith("http://www.eclipse.org/emf/2002/Ecore#//EBooleanObject"))
                {
                    return EcorePackageImpl.Literals.EBOOLEANOBJECT;
                }
                else if (specification.EndsWith("http://www.eclipse.org/emf/2002/Ecore#//EByte"))
                {
                    return EcorePackageImpl.Literals.EBYTE;
                }
                else if (specification.EndsWith("http://www.eclipse.org/emf/2002/Ecore#//EByteArray"))
                {
                    return EcorePackageImpl.Literals.EBYTEARRAY;
                }
                else if (specification.EndsWith("http://www.eclipse.org/emf/2002/Ecore#//EByteObject"))
                {
                    return EcorePackageImpl.Literals.EBYTEOBJECT;
                }
                else if (specification.EndsWith("http://www.eclipse.org/emf/2002/Ecore#//EChar"))
                {
                    return EcorePackageImpl.Literals.ECHAR;
                }
                else if (specification.EndsWith("http://www.eclipse.org/emf/2002/Ecore#//ECharacterObject"))
                {
                    return EcorePackageImpl.Literals.ECHARACTEROBJECT;
                }
                else if (specification.EndsWith("http://www.eclipse.org/emf/2002/Ecore#//EDate"))
                {
                    return EcorePackageImpl.Literals.EDATE;
                }
                else if (specification.EndsWith("http://www.eclipse.org/emf/2002/Ecore#//EDiagnosticChain"))
                {
                    return EcorePackageImpl.Literals.EDIAGNOSTICCHAIN;
                }
                else if (specification.EndsWith("http://www.eclipse.org/emf/2002/Ecore#//EDouble"))
                {
                    return EcorePackageImpl.Literals.EDOUBLE;
                }
                else if (specification.EndsWith("http://www.eclipse.org/emf/2002/Ecore#//EDoubleObject"))
                {
                    return EcorePackageImpl.Literals.EDOUBLEOBJECT;
                }
                else if (specification.EndsWith("http://www.eclipse.org/emf/2002/Ecore#//EEList"))
                {
                    return EcorePackageImpl.Literals.EELIST;
                }
                else if (specification.EndsWith("http://www.eclipse.org/emf/2002/Ecore#//EEnumerator"))
                {
                    return EcorePackageImpl.Literals.EENUMERATOR;
                }
                else if (specification.EndsWith("http://www.eclipse.org/emf/2002/Ecore#//EFeatureMap"))
                {
                    return EcorePackageImpl.Literals.EFEATUREMAP;
                }
                else if (specification.EndsWith("http://www.eclipse.org/emf/2002/Ecore#//EFeatureMapEntry"))
                {
                    return EcorePackageImpl.Literals.EFEATUREMAPENTRY;
                }
                else if (specification.EndsWith("http://www.eclipse.org/emf/2002/Ecore#//EFloat"))
                {
                    return EcorePackageImpl.Literals.EFLOAT;
                }
                else if (specification.EndsWith("http://www.eclipse.org/emf/2002/Ecore#//EFloatObject"))
                {
                    return EcorePackageImpl.Literals.EFLOATOBJECT;
                }
                else if (specification.EndsWith("http://www.eclipse.org/emf/2002/Ecore#//EInt"))
                {
                    return EcorePackageImpl.Literals.EINT;
                }
                else if (specification.EndsWith("http://www.eclipse.org/emf/2002/Ecore#//EIntegerObject"))
                {
                    return EcorePackageImpl.Literals.EINTEGEROBJECT;
                }
                else if (specification.EndsWith("http://www.eclipse.org/emf/2002/Ecore#//EJavaClass"))
                {
                    return EcorePackageImpl.Literals.EJAVACLASS;
                }
                else if (specification.EndsWith("http://www.eclipse.org/emf/2002/Ecore#//EJavaObject"))
                {
                    return EcorePackageImpl.Literals.EJAVAOBJECT;
                }
                else if (specification.EndsWith("http://www.eclipse.org/emf/2002/Ecore#//ELong"))
                {
                    return EcorePackageImpl.Literals.ELONG;
                }
                else if (specification.EndsWith("http://www.eclipse.org/emf/2002/Ecore#//EMap"))
                {
                    return EcorePackageImpl.Literals.EMAP;
                }
                else if (specification.EndsWith("http://www.eclipse.org/emf/2002/Ecore#//EResource"))
                {
                    return EcorePackageImpl.Literals.ERESOURCE;
                }
                else if (specification.EndsWith("http://www.eclipse.org/emf/2002/Ecore#//EResourceSet"))
                {
                    return EcorePackageImpl.Literals.ERESOURCESET;
                }
                else if (specification.EndsWith("http://www.eclipse.org/emf/2002/Ecore#//EShort"))
                {
                    return EcorePackageImpl.Literals.ESHORT;
                }
                else if (specification.EndsWith("http://www.eclipse.org/emf/2002/Ecore#//EShortObject"))
                {
                    return EcorePackageImpl.Literals.ESHORTOBJECT;
                }
                else if (specification.EndsWith("http://www.eclipse.org/emf/2002/Ecore#//EString"))
                {
                    return EcorePackageImpl.Literals.ESTRING;
                }
                else if (specification.EndsWith("http://www.eclipse.org/emf/2002/Ecore#//EStringToStringMapEntry"))
                {
                    return EcorePackageImpl.Literals.ESTRINGTOSTRINGMAPENTRY;
                }
                else if (specification.EndsWith("http://www.eclipse.org/emf/2002/Ecore#//ETreeIterator"))
                {
                    return EcorePackageImpl.Literals.ETREEITERATOR;
                }

            }
            else if (specification.StartsWith("#//"))
            {
                var name = specification.Replace("#//","");

                var segments = name.Split('/');
                var stack = new Stack<string>();
                var parent = epackage as EObject;




                foreach (string segment in segments)
                {
                    var contents = parent.eContents();
                    
                    parent = contents.Where(e => (e as ENamedElement).name == segment).First();
                    
                }
                                
                return parent;
            }
            else
            {
                Debug.WriteLine("Error "+specification);
            }

            return null;
        }

        protected bool getBoolean(string innertext, bool default_)
        {
            if (innertext!=null)
            {
                return innertext == "true" ? true : false;
            }

            return default_;
        }


        protected int getInteger(string innertext, int default_)
        {
            if (innertext != null)
            {
                try
                {
                    return Int32.Parse(innertext);
                }
                catch (FormatException e)
                {
                    Debug.WriteLine(e.Message);
                }
                catch (OverflowException e)
                {
                    Debug.WriteLine(e.Message);
                }

                return default_;
                
            }

            return default_;
        }



        public EAttribute handleEAttribute(XmlNode node)
        {
            var eattribute = EcoreFactoryImpl.eINSTANCE.createEAttribute();
            eattribute.name = node.Attributes["name"]?.InnerText;
            eattribute.lowerBound = getInteger(node.Attributes["lowerBound"]?.InnerText, eattribute.lowerBound);
            eattribute.upperBound = getInteger(node.Attributes["upperBound"]?.InnerText, eattribute.upperBound);
            eattribute.unique = getBoolean(node.Attributes["unique"]?.InnerText, eattribute.unique);
            eattribute.changeable = getBoolean(node.Attributes["changeable"]?.InnerText, eattribute.changeable);
            eattribute.volatile_ = getBoolean(node.Attributes["volatile"]?.InnerText, eattribute.volatile_);
            eattribute.transient = getBoolean(node.Attributes["transient"]?.InnerText, eattribute.transient);
            eattribute.derived = getBoolean(node.Attributes["derived"]?.InnerText, eattribute.derived);
            eattribute.defaultValueLiteral = node.Attributes["defaultValueLiteral"]?.InnerText;
            
            eattribute.iD = getBoolean(node.Attributes["iD"]?.InnerText, eattribute.iD);
            eattribute.ordered = getBoolean(node.Attributes["ordered"]?.InnerText, eattribute.ordered);
            eattribute.unsettable = getBoolean(node.Attributes["unsettable"]?.InnerText, eattribute.unsettable);

            register(eattribute, EcorePackageImpl.Literals.ETYPEDELEMENT_ETYPE, node.Attributes["eType"]?.InnerText);

            foreach (XmlNode child in node.ChildNodes)
            {
                if (child.LocalName == "eAnnotations")
                {
                    var eannotation = handleEAnnotation(child);
                    eattribute.eAnnotations.add(eannotation);

                }
                else if (child.LocalName == "eGenericType")
                {
                    var egenerictype = handleEGenericType(child);
                    eattribute.eGenericType = egenerictype;

                }
            }
            
            return eattribute;
        }




        public string caseEAttribute(EAttribute eattribute)
        {
            var nsURI = eattribute.eType.ePackage.nsURI;
            var uri = nsURI + "#//" + eattribute.eType.name;//TODO there is so much that can go wrong

            return $"<eStructuralFeatures xsi:type=\"ecore:EAttribute\" name=\"{eattribute.name}\" eType=\"ecore:EDataType {uri}\"/>";
        }

        public EReference handleEReference(XmlNode node)
        {
            var ereference = EcoreFactoryImpl.eINSTANCE.createEReference();
            ereference.name = node.Attributes["name"]?.InnerText;
            ereference.lowerBound = getInteger(node.Attributes["lowerBound"]?.InnerText, ereference.lowerBound);
            ereference.upperBound = getInteger(node.Attributes["upperBound"]?.InnerText, ereference.upperBound);
            ereference.unique = getBoolean(node.Attributes["unique"]?.InnerText, ereference.unique);
            ereference.changeable = getBoolean(node.Attributes["changeable"]?.InnerText, ereference.changeable);
            ereference.volatile_ = getBoolean(node.Attributes["volatile"]?.InnerText, ereference.volatile_);
            ereference.transient = getBoolean(node.Attributes["transient"]?.InnerText, ereference.transient);
            ereference.derived = getBoolean(node.Attributes["derived"]?.InnerText, ereference.derived);
            ereference.ordered = getBoolean(node.Attributes["ordered"]?.InnerText, ereference.ordered);
            ereference.unsettable = getBoolean(node.Attributes["unsettable"]?.InnerText, ereference.unsettable);
            ereference.containment = getBoolean(node.Attributes["containment"]?.InnerText, ereference.containment);

            register(ereference, EcorePackageImpl.Literals.ETYPEDELEMENT_ETYPE, node.Attributes["eType"]?.InnerText);
            ereference.resolveProxies = getBoolean(node.Attributes["resolveProxies"]?.InnerText, ereference.resolveProxies);
            
            register(ereference, EcorePackageImpl.Literals.EREFERENCE_EOPPOSITE, node.Attributes["eOpposite"]?.InnerText);

            foreach (XmlNode child in node.ChildNodes)
            {
                if (child.LocalName == "eAnnotations")
                {
                    var eannotation = handleEAnnotation(child);
                    ereference.eAnnotations.add(eannotation);

                }
                else if (child.LocalName == "eGenericType")
                {
                    var egenerictype = handleEGenericType(child);
                    ereference.eGenericType = egenerictype;

                }
            }

            return ereference;

        }

        
        public EOperation handleEOperation(XmlNode node)
        {
            var eoperation = EcoreFactoryImpl.eINSTANCE.createEOperation();
            eoperation.name = node.Attributes["name"]?.InnerText;
            
            register(eoperation, EcorePackageImpl.Literals.ETYPEDELEMENT_ETYPE, node.Attributes["eType"]?.InnerText);
            eoperation.ordered = getBoolean(node.Attributes["ordered"]?.InnerText, eoperation.ordered);
            eoperation.unique = getBoolean(node.Attributes["unique"]?.InnerText, eoperation.unique);
            eoperation.lowerBound = getInteger(node.Attributes["lowerBound"]?.InnerText, eoperation.lowerBound);
            eoperation.upperBound = getInteger(node.Attributes["upperBound"]?.InnerText, eoperation.upperBound);
            

            register(eoperation, EcorePackageImpl.Literals.EOPERATION_EEXCEPTIONS, node.Attributes["eExceptions"]?.InnerText);

            foreach (XmlNode child in node.ChildNodes)
            {

                if (child.LocalName== "eTypeParameters")
                {
                    var etypeparameter = handleETypeParameter(child);
                    eoperation.eTypeParameters.add(etypeparameter);
                }
                else if (child.LocalName== "eParameters")
                {
                    var eparameter = handleEParameter(child);
                    eoperation.eParameters.add(eparameter);
                }
                else if (child.LocalName == "eGenericType")
                {
                    var egenerictype = handleEGenericType(child);
                    eoperation.eGenericType = egenerictype;
                }
                else if (child.LocalName == "eAnnotations")
                {
                    var eannotation = handleEAnnotation(child);
                    eoperation.eAnnotations.add(eannotation);

                }
            }

            return eoperation;
        }

        public EParameter handleEParameter(XmlNode node)
        {
            //<eParameters name="feature" eType="#//EStructuralFeature"/>
            var eparameter = EcoreFactoryImpl.eINSTANCE.createEParameter();
            eparameter.name = node.Attributes["name"]?.InnerText;
            
            register(eparameter, EcorePackageImpl.Literals.ETYPEDELEMENT_ETYPE, node.Attributes["eType"]?.InnerText);

            return eparameter;
        }

        public EEnum handleEEnum(XmlNode node)
        {
            //var eenum = epackage.eClassifiers.select(e => e.name == node.Attributes["name"].InnerText).first() as EEnum;

            var eenum = EcoreFactoryImpl.eINSTANCE.createEEnum();
            eenum.name = node.Attributes["name"]?.InnerText;

            foreach (XmlNode child in node.ChildNodes)
            {
                if (child.LocalName == "eLiterals")
                {
                    var eenumliteral = handleEEnumLiteral(child);
                    eenum.eLiterals.add(eenumliteral);
                }
                else if (child.LocalName == "eAnnotations")
                {
                    var eannotation = handleEAnnotation(child);
                    eenum.eAnnotations.add(eannotation);

                }

            }

            return eenum;
        }

        public EEnumLiteral handleEEnumLiteral(XmlNode node)
        {
            var eenumliteral = EcoreFactoryImpl.eINSTANCE.createEEnumLiteral();
            eenumliteral.name = node.Attributes["name"]?.InnerText;

            foreach (XmlNode child in node.ChildNodes)
            {
                if (child.LocalName == "eAnnotations")
                {
                    var eannotation = handleEAnnotation(child);
                    eenumliteral.eAnnotations.add(eannotation);

                }

            }

            return eenumliteral;
        }

        public ETypeParameter handleETypeParameter(XmlNode node)
        {
            var etypeparameter = EcoreFactoryImpl.eINSTANCE.createETypeParameter();
            etypeparameter.name = node.Attributes["name"]?.InnerText;

            foreach (XmlNode child in node.ChildNodes)
            {
                if (child.LocalName== "eBounds")
                {
                    var egenerictype = handleEGenericType(child);
                    etypeparameter.eBounds.add(egenerictype);
                }
                else if (child.LocalName == "eAnnotations")
                {
                    var eannotation = handleEAnnotation(child);
                    etypeparameter.eAnnotations.add(eannotation);

                }


            }

            return etypeparameter;
        }

        public EGenericType handleEGenericType(XmlNode node)
        {
            var egenerictype = EcoreFactoryImpl.eINSTANCE.createEGenericType();        

            register(egenerictype, EcorePackageImpl.Literals.EGENERICTYPE_ECLASSIFIER, node.Attributes["eClassifier"]?.InnerText);
            //TODO egenerictype.eTypeParameter = getEType(node.Attributes["eTypeParameter"]?.InnerText); 

            foreach (XmlNode child in node.ChildNodes)
            {
                if (child.LocalName == "eTypeArguments")
                {
                    var etypeargument = handleEGenericType(child);
                    egenerictype.eTypeArguments.add(etypeargument);
                }

            }

            return egenerictype;
        }


    }
}
