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
	public class MyClassImpl 
	: MyClassBase
	{
		
		public static oclstdlib.Set<MyClassImpl> allInstances_ = new oclstdlib.Set<MyClassImpl>();
		
	    public static oclstdlib.Set<MyClass> allInstances()
		{
	
			var result = new oclstdlib.Set<MyClass>();
		    result.AddRange(MyClassImpl.allInstances_);
		
		    return result;
	    }
		
		//implement your generated class here	
	}
}
