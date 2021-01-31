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
    public class DiagnosticImpl
    {

        public const int OK = 0x0;
        public const int INFO = 0x1;
        public const int WARNING = 0x2;
        public const int ERROR = 0x4;
        public const int CANCEL = 0x8;


    }
}
