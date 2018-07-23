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



    public class EClassImpl
    : EClassBase
    {
        //implement your generated class here	

        public override OrderedSet<EAttribute> eAttributes
        {
            get
            {
                return eStructuralFeatures.collect(s => s as EAttribute);
            }
        }

        public override OrderedSet<EReference> eReferences
        {
            get
            {
                var x = eStructuralFeatures.collect(s => s as EReference);
                return eStructuralFeatures.collect(s => s as EReference);
            }

        }

        public override OrderedSet<EClass> eAllSuperTypes
        {
            get
            {
                

                var result = new OrderedSet<EClass>();
                var queue = new Queue<EClass>();

                queue.Enqueue(this);
                
                while (queue.Count>0)
                {
                    var current = queue.Dequeue();
                    result.Add(current);
                    foreach (EClass supertype in current.eSuperTypes)
                    {
                        queue.Enqueue(supertype);
                    }
                }

                return result;
                //TODO use ocl closure
                //return eSuperTypes.closure(s => s.eSuperTypes);
            }
        }

        public override OrderedSet<EReference> eAllReferences
        {
            get
            {
                var x = eAllSuperTypes.collect<EReference>(t => t.eReferences); 
                return eAllSuperTypes.collect<EReference>(t => t.eReferences);
            }

        }

 

        public override OrderedSet<EReference> eAllContainments
        {
            get
            {
                var x = eAllReferences.select(i => i.containment);
                return eAllReferences.select(i => i.containment);
            }

        }

        public override OrderedSet<EStructuralFeature> eAllStructuralFeatures
        {
            get
            {
                return eAllSuperTypes.collect<EStructuralFeature>(e => e.eStructuralFeatures);
            }

        }

        public override EStructuralFeature getEStructuralFeature(string featureName)
        {
            foreach (EStructuralFeature feature in eAllStructuralFeatures)
            {
                if (feature.name == featureName)
                {
                    return feature;
                }
            }

            return null;
        }



    }

}
