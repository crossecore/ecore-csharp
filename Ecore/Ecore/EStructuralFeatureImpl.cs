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



    public class EStructuralFeatureImpl
    : EStructuralFeatureBase
    {
        protected int featureID = -1;
        public void setFeatureID(int id)
        {
            featureID = id;
        }

        public override int getFeatureID()
        {
            return featureID;
        }

        private Type containerClass_;
        public Type containerClass
        {
            get { return containerClass_; }
            set { containerClass_ = value; }
        }

        public override Type getContainerClass()
        {
            return containerClass_;
        }

    }

}
