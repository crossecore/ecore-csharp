/* CrossEcore is a cross-platform modeling framework that generates C#, TypeScript, 
 * JavaScript, Swift code from Ecore models with embedded OCL (http://www.crossecore.org/).
 * The original Eclipse Modeling Framework is available at https://www.eclipse.org/modeling/emf/.
 * 
 * contributor: Simon Schwichtenberg
 */

using oclstdlib;
using System;
using System.Collections;
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

        private EFactory factory = EcoreFactoryImpl.eINSTANCE;//TODO make dynamic registry

        private EPackage epackage = EcorePackageImpl.eINSTANCE;//TODO make dynamic registry

        private EObject root;

        private List<Tuple<EObject, EStructuralFeature, String>> resolveJobs = new List<Tuple<EObject, EStructuralFeature, String>>();


        public XmiResource()
        {
            factory = EcoreFactoryImpl.eINSTANCE;
            epackage = EcorePackageImpl.eINSTANCE;
        }

        public XmiResource(EPackage epackage, EFactory factory)
        {
            this.epackage = epackage;
            this.factory = factory;
        }

        public void Save(string path)
        {
            saveRecurr(root, null);
        }

        private string getFragment(EObject eobject)
        {

            EAttribute idfeature = eobject.eClass().eIDAttribute;

            return $"#//{eobject.eGet(idfeature)}";
        }


        private void saveRecurr(EObject eobject, EReference relation)
        {
            if (eobject == null)
            {
                return;
            }

            var xmlAttributes = new Dictionary<string, string>();

            //xsi:type="ecore:EAttribute"

            var eclass = eobject.eClass();
            var epackag = eclass.ePackage;

            if (epackag == null)
            {
                return;
            }
            var prefix = epackag.nsPrefix;

            xmlAttributes["xsi:type"] = eobject.eClass().ePackage.nsPrefix + ":" + eobject.eClass().name;

            foreach (EStructuralFeature feature in eobject.eClass().eAllStructuralFeatures)
            {

                if (feature is EReference)
                {

                    var erference = feature as EReference;

                    if (erference.many)
                    {
                        //TODO
                    }
                    else
                    {
                        var value = eobject.eGet(erference) as EObject;
                        if (value != null)
                        {
                            xmlAttributes[erference.name] = getFragment(value);
                        }

                    }

                    if (erference.containment)
                    {
                        var child = eobject.eGet(erference);

                        if (child != null)
                        {
                            if (erference.many)
                            {
                                var list = (IList)child;

                                var list2 = list.Cast<EObject>();
                                foreach (EObject c in list)
                                {
                                    saveRecurr(c, erference);
                                }
                            }
                            else
                            {

                                saveRecurr(child as EObject, erference);//TODO is casting safe here?

                            }
                        }

                    }

                }
                else if (feature is EAttribute)
                {
                    var eattribute = feature as EAttribute;

                    if (!eattribute.transient && !eattribute.derived && eattribute.defaultValue != eobject.eGet(eattribute))
                    {
                        //TODO many

                        xmlAttributes[eattribute.name] = eobject.eGet(eattribute).ToString();
                    }

                }
            }

            if (relation != null)
            {
                var sb = new StringBuilder();
                sb.Append($"<{relation.name}");
                foreach (String key in xmlAttributes.Keys)
                {
                    sb.Append($"{key}=\"{xmlAttributes[key]}\"");
                }
                sb.Append($">");
                //TODO childs
                sb.Append($"</{relation.name}>");
                Console.WriteLine(sb.ToString());
            }


        }


        public EObject Load(string path)
        {
            var doc = new XmlDocument();
            doc.Load(path);

            rootnode(doc.DocumentElement);

            lateResolve();

            return epackage;
        }


        public void lateResolve()
        {
            foreach (Tuple<EObject, EStructuralFeature, String> job in resolveJobs)
            {


                var eobject = job.Item1;
                var feature = job.Item2;
                var path = job.Item3;


                if (!feature.many)
                {
                    eobject.eSet(feature, resolveEObject(path));
                }
                else if (feature.many)
                {
                    eobject.eSet(feature, resolveEList(path));
                }


            }
        }



        private void addEStructuralFeatures(EObject eobject, XmlNode node)
        {

            foreach (XmlAttribute attribute in node.Attributes)
            {
                var name = attribute.Name;
                var estructuralfeature = eobject.eClass().getEStructuralFeature(name);

                if (estructuralfeature is EAttribute)
                {
                    if (!estructuralfeature.many)
                    {
                        var etype = estructuralfeature.eType;
                        var value = attribute.InnerText;

                        if (etype?.ePackage?.nsURI == "http://www.eclipse.org/emf/2002/Ecore")
                        {

                            if (etype.name == "EBigDecimal")
                            {
                                throw new NotImplementedException();
                            }
                            else if (etype.name == "EBigInteger")
                            {
                                throw new NotImplementedException();
                            }
                            else if (etype.name == "EBoolean")
                            {
                                eobject.eSet(estructuralfeature, value == "true" ? true : false);
                            }
                            else if (etype.name == "EBooleanObject")
                            {
                                throw new NotImplementedException();
                            }
                            else if (etype.name == "EByteArray")
                            {
                                throw new NotImplementedException();
                            }
                            else if (etype.name == "EByteObject")
                            {
                                throw new NotImplementedException();
                            }
                            else if (etype.name == "EChar")
                            {
                                eobject.eSet(estructuralfeature, value[0]);
                            }
                            else if (etype.name == "ECharacterObject")
                            {
                                throw new NotImplementedException();
                            }
                            else if (etype.name == "EDateEDiagnosticChain")
                            {
                                throw new NotImplementedException();
                            }
                            else if (etype.name == "EDiagnosticChain")
                            {
                                throw new NotImplementedException();
                            }
                            else if (etype.name == "EDouble")
                            {
                                eobject.eSet(estructuralfeature, Double.Parse(value));
                            }
                            else if (etype.name == "EDoubleObject")
                            {
                                throw new NotImplementedException();
                            }
                            //EEList
                            //EEnumerator
                            //EFeatureMap
                            //EFeatureMapEntry
                            else if (etype.name == "EFloat")
                            {
                                eobject.eSet(estructuralfeature, Single.Parse(value));
                            }
                            else if (etype.name == "EFloatObject")
                            {
                                throw new NotImplementedException();
                            }
                            else if (etype.name == "EInt")
                            {
                                eobject.eSet(estructuralfeature, Int32.Parse(value));
                            }
                            else if (etype.name == "EIntegerObject")
                            {
                                throw new NotImplementedException();
                            }
                            //EJavaClass
                            //EJavaObject
                            else if (etype.name == "ELong")
                            {
                                eobject.eSet(estructuralfeature, Int64.Parse(value));
                            }
                            else if (etype.name == "ELongObject")
                            {
                                throw new NotImplementedException();
                            }
                            //EMap
                            //EResource
                            //EResourceSet
                            else if (etype.name == "EShort")
                            {
                                eobject.eSet(estructuralfeature, Int16.Parse(value));
                            }
                            else if (etype.name == "EShortObject")
                            {
                                throw new NotImplementedException();
                            }
                            else if (etype.name == "EString")
                            {
                                eobject.eSet(estructuralfeature, value);
                            }
                            //ETreeIterator
                            //EInvocationTargetException

                        }
                        else
                        {
                            //custom package

                            if (etype is EEnum)
                            {
                                //TODO set literals
                                //var literal = VisibilityKind.getByName(value);

                                //eobject.eSet(estructuralfeature, literal);
                                
                            }
                        }

                    }
                    else if (estructuralfeature.many)
                    {
                        var y = 3;
                    }
                    else
                    {
                        var x = 2;
                    }
                }
                else if (estructuralfeature is EReference)
                {
                    resolveJobs.Add(new Tuple<EObject, EStructuralFeature, String>(eobject, estructuralfeature, attribute.InnerText));

                }

            }


            foreach (XmlNode child in node.ChildNodes)
            {
                var containment_name = child.Name;
                var containment = eobject.eClass().getEStructuralFeature(containment_name);

                if (containment is EReference)
                {

                    var containment_er = containment as EReference;
                    if (containment_er.containment)
                    {

                        var classifierId2 = containment.eType.name;

                        if (child.Attributes["xsi:type"] != null)
                        {
                            //use xsi:type to declare a more specific type that is declared in EType of the EReference
                            classifierId2 = child.Attributes["xsi:type"]?.InnerText?.Split(':')[1];//TODO there might be more elegant ways
                        }

                        var eclassifier2 = epackage.getEClassifier(classifierId2);

                        if (eclassifier2 is EClass)
                        {

                            if (containment_er.eType.name == "EStringToStringMapEntry")
                            {
                                //new EcoreEMap<string, string> x = new EcoreEMap<string, string>(containment_er.eType as EClass, containment_er.eType.instanceClass, eobject as InternalEObject, containment_er.getFeatureID());



                                var key = child.Attributes["key"].InnerText;
                                var value = child.Attributes["value"].InnerText;

                                dynamic bla = eobject;

                                //FIXME why is eGet(containment_er) not working?

                                dynamic map = bla.eGet(containment_er);
                                //var map = bla.eGet(containment_er.getFeatureID(), false, false);
                                //var ecoremap = map as EcoreEMap<string, string>;



                                //https://stackoverflow.com/questions/19283349/c-sharp-generics-wildcards
                                map.put(key, value);
                            }
                            else
                            {
                                var eclass2 = eclassifier2 as EClass;
                                var eobject2 = factory.create(eclass2);

                                if (containment_er.many)
                                {
                                    addEStructuralFeatures(eobject2, child);

                                    var list = new List<EObject>();
                                    list.Add(eobject2);
                                    eobject.eSet(containment_er, list);
                                }
                                else
                                {
                                    addEStructuralFeatures(eobject2, child);

                                    eobject.eSet(containment_er, eobject2);
                                }

                            }

                        }

                    }
                    else
                    {
                        //TODO error
                    }

                }
                else
                {
                    //TODO error
                }

            }
        }

        public EObject rootnode(XmlNode node)
        {


            //TODO split ns prefix
            var classifierId = node.Name.Split(':')[1];//localname?


            //var classifierId = node.Attributes["xsi:type"].InnerText;// == "ecore:EClass";

            var eclassifier = epackage.getEClassifier(classifierId);


            if (eclassifier is EClass)
            {
                var eclass = eclassifier as EClass;
                root = factory.create(eclass);

                addEStructuralFeatures(root, node);


            }



            return root;

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


        private EObject resolveRecurr(Queue<String> path, EObject current)
        {

            if (path.Count == 0)
            {
                return current;
            }

            String segment = path.Dequeue();

            foreach (EObject content in current.eContents())
            {
                if (content is ENamedElement)
                {

                    if ((content as ENamedElement).name == segment)
                    {
                        return resolveRecurr(path, content);
                    }
                }
            }

            return null;
        }

        protected EObject resolveEObject(string specification)
        {


            if (specification == null)
            {
                return null;
            }
            else if (specification.StartsWith("#//"))
            {
                var name = specification.Replace("#//", "");

                var segments = name.Split('/');


                var stack = new Queue<String>(name.Split('/'));

                return resolveRecurr(stack, root);


            }
            else
            {
                Debug.WriteLine("Error " + specification);
            }

            return null;
        }




        protected bool getBoolean(string innertext, bool default_)
        {
            if (innertext != null)
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


    }
}