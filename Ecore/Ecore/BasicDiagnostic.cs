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
    public class BasicDiagnostic:Diagnostic, DiagnosticChain
    {

        public const int OK = 0x0;

        public const int INFO = 0x1;

        public const int WARNING = 0x2;

        public const int ERROR = 0x4;

        public const int CANCEL = 0x8;

        protected int severity;
        protected string message;
        protected List<Diagnostic> children;
        protected List<object> data;
        protected String source;
        protected int code;

        public BasicDiagnostic():base()
        {
            
        }

        public BasicDiagnostic(string source, int code, string message, object[] data)
        {
            this.source = source;
            this.code = code;
            this.message = message;
            this.data = data.ToList();
        }

        public BasicDiagnostic(int severity, string source, int code, string message, object[] data)
            :this(source, code, message, data)
        {
            this.severity = severity;
        }

        public int getSeverity()
        {
            return severity;
        }

        public string getMessage()
        {
            return message;
        }

        public string getSource()
        {
            return source;
        }

        public int getCode()
        {
            return code;
        }

        public List<Diagnostic> getChildren()
        {
            return children;
        }

        public void add(Diagnostic diagnostic)
        {
            throw new NotImplementedException();
        }

        public void addAll(Diagnostic diagnostic)
        {
            throw new NotImplementedException();
        }

        public void merge(Diagnostic diagnostic)
        {
            throw new NotImplementedException();
        }
    }
}
