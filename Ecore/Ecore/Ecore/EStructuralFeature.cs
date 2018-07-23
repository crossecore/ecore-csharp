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
	
	public interface EStructuralFeature 
	: ETypedElement
	{
		bool changeable
		{
			get;
		set;
		}
		bool volatile_
		{
			get;
		set;
		}
		bool transient
		{
			get;
		set;
		}
		string defaultValueLiteral
		{
			get;
		set;
		}
		object defaultValue
		{
			get;
		}
		bool unsettable
		{
			get;
		set;
		}
		bool derived
		{
			get;
		set;
		}
		EClass eContainingClass
		{
			get;
		}
		int getFeatureID();
		Type getContainerClass();
	}
}
