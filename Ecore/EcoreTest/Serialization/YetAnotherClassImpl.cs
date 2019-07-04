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
	public class YetAnotherClassImpl 
	: YetAnotherClassBase
	{
		
		public static oclstdlib.Set<YetAnotherClassImpl> allInstances_ = new oclstdlib.Set<YetAnotherClassImpl>();
		
	    public static oclstdlib.Set<YetAnotherClass> allInstances()
		{
	
			var result = new oclstdlib.Set<YetAnotherClass>();
		    result.AddRange(YetAnotherClassImpl.allInstances_);
		
		    return result;
	    }
		
		//implement your generated class here	
	}
}
