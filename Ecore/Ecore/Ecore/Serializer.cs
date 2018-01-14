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
using oclstdlib;


namespace Ecore
{

    public class Serializer { 
        private String value(EObject eobject, EAttribute attribute)
        {

            var classifier = attribute.eType;

            if (classifier.Equals(EcorePackageImpl.Literals.EBOOLEAN))
            {
                return $"{eobject.eGet(attribute)}";
            }
            else if (classifier.Equals(EcorePackageImpl.Literals.EINT))
            {
                return $"{eobject.eGet(attribute)}";
            }
            else if (classifier.Equals(EcorePackageImpl.Literals.EDOUBLE))
            {
                return $"{eobject.eGet(attribute)}";
            }
            else if (classifier.Equals(EcorePackageImpl.Literals.EFLOAT))
            {
                return $"{eobject.eGet(attribute)}";
            }
            else if (classifier.Equals(EcorePackageImpl.Literals.ESTRING))
            {
                return $"\"{eobject.eGet(attribute)}\"";
            }
            else if (classifier.Equals(EcorePackageImpl.Literals.ECHAR))
            {
                return $"\"{eobject.eGet(attribute)}\"";
            }
            else
            {
                throw new ArgumentException();
            }

        }

        private Collection<EReference> validEAllReferences(EObject eobject, Collection<EReference> features)
        {


            var result = new Set<EReference>();

            foreach (EReference feature in features)
            {

                if (!feature.transient)
                {
                    if (eobject.eGet(feature) != null)
                    {

                        if (feature.many && !(eobject.eGet(feature) as Collection<Object>).isEmpty())
                        {
                            result.add(feature);
                        }
                        else if (!feature.many)
                        {
                            result.add(feature);
                        }
                    }
                }
            }
            return result;

        }

        private Collection<EAttribute> validEAllAttributes(EObject eobject, Collection<EAttribute> features)
        {


            var result = new Set<EAttribute>();

            foreach (EAttribute feature in features)
            {

                if (!feature.transient)
                {
                    if (eobject.eGet(feature) != null)
                    {

                        if (feature.many && !(eobject.eGet(feature) as Collection<Object>).isEmpty())
                        {
                            result.add(feature);
                        }
                        else if (!feature.many)
                        {
                            result.add(feature);
                        }
                    }
                }
            }
            return result;

        }

        public String serialize(EObject eobject)
        {

            var eClass = eobject.eClass();
                        
            var references = validEAllReferences(eobject, eClass.eAllReferences);
            var attributes = validEAllAttributes(eobject, eClass.eAllAttributes);

            var sb = new StringBuilder();

            sb.Append("{");
            { 
                sb.Append($"\"{eClass.name}\":");
                sb.Append("{");
                {
                    var i3 = 0;
                    foreach (EReference ereference in references)
                    {
                        if (ereference.containment)
                        {
                            if (ereference.many)
                            {
                                sb.Append($"\"{ereference.name}\":");
                                var items = eobject.eGet(ereference) as Collection<EObject>;

                                sb.Append("[");
                                { 
                                    var i = 0;
                                    foreach (EObject item in items)
                                    {

                                        sb.Append(serialize(item));

                                        if (i<items.size()-1)
                                        {
                                            sb.Append(", ");
                                        }

                                        i++;
                                    }
                                }
                                sb.Append("]");


                            }
                            else
                            {
                                sb.Append($"\"{ereference.name}\": {serialize(eobject.eGet(ereference) as EObject)}");
                            }
                        }
                        else
                        {
                            if (ereference.many)
                            {
                                var items = eobject.eGet(ereference) as Collection<EObject>;
                                sb.Append("[");
                                {
                                    var i = 0;
                                    foreach (EObject item in items)
                                    {

                                        sb.Append(item.GetHashCode());

                                        if (i < items.size() - 1)
                                        {
                                            sb.Append(", ");
                                        }

                                        i++;
                                    }
                                }
                                sb.Append("]");
                            }
                            else
                            {
                                sb.Append($"\"{ereference.name}\": \"{eobject.eGet(ereference).GetHashCode()}\"");
                            }
                        }

                        if (i3 < attributes.size() - 1)
                        {
                            sb.Append(", ");
                        }

                        i3++;

                    }
                    if (!references.isEmpty() && !attributes.isEmpty())
                    {
                        sb.Append(", ");
                    }

                    var i2 = 0;
                    foreach (var attribute in attributes)
                    {
                        sb.Append($"\"{attribute.name}\": \"{eobject.eGet(attribute).ToString()}\"");


                        if (i2 < attributes.size() - 1)
                        {
                            sb.Append(", ");
                        }

                        i2++;
                    }

                    
                }
                sb.Append("}");
            }
            sb.Append("}");

            return sb.ToString();
	    }
    }
}
