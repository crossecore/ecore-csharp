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



    public class ETypedElementImpl
    : ETypedElementBase
    {
        //implement your generated class here	
        public override bool many
        {
            get
            {
                return upperBound == -1 || upperBound > 1;
            }
        }

    }

}
