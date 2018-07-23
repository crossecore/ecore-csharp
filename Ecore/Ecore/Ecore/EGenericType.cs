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
namespace Ecore{
	
	public interface EGenericType 
	: EObject
	{
		EGenericType eUpperBound
		{
			get;
			set;
		}
		OrderedSet<EGenericType> eTypeArguments
		{
			get;
		
		}
		EClassifier eRawType
		{
			get;
		}
		EGenericType eLowerBound
		{
			get;
			set;
		}
		ETypeParameter eTypeParameter
		{
			get;
			set;
		}
		EClassifier eClassifier
		{
			get;
			set;
		}
		bool isInstance(object object_);
	}
}
