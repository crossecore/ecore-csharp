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
using Ecore;
namespace Serialization{
	public class OtherClassImpl 
	: OtherClassBase
	{
		
		public static oclstdlib.Set<OtherClassImpl> allInstances_ = new oclstdlib.Set<OtherClassImpl>();
		
	    public static oclstdlib.Set<OtherClass> allInstances()
		{
	
			var result = new oclstdlib.Set<OtherClass>();
		    result.AddRange(OtherClassImpl.allInstances_);
		
		    return result;
	    }
		
		//implement your generated class here	
	}
}
