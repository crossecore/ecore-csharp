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
	
	public interface ETypedElement 
	: ENamedElement
	{
		bool ordered
		{
			get;
		set;
		}
		bool unique
		{
			get;
		set;
		}
		int lowerBound
		{
			get;
		set;
		}
		int upperBound
		{
			get;
		set;
		}
		bool many
		{
			get;
		}
		bool required
		{
			get;
		}
		EClassifier eType
		{
			get;
			set;
		}
		EGenericType eGenericType
		{
			get;
			set;
		}
	}
}
