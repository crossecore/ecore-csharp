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
	
	public interface EClass 
	: EClassifier
	{
		bool abstract_
		{
			get;
		set;
		}
		bool interface_
		{
			get;
		set;
		}
		OrderedSet<EClass> eSuperTypes
		{
			get;
		
		}
		OrderedSet<EOperation> eOperations
		{
			get;
		
		}
		OrderedSet<EAttribute> eAllAttributes
		{
			get;
		
		}
		OrderedSet<EReference> eAllReferences
		{
			get;
		
		}
		OrderedSet<EReference> eReferences
		{
			get;
		
		}
		OrderedSet<EAttribute> eAttributes
		{
			get;
		
		}
		OrderedSet<EReference> eAllContainments
		{
			get;
		
		}
		OrderedSet<EOperation> eAllOperations
		{
			get;
		
		}
		OrderedSet<EStructuralFeature> eAllStructuralFeatures
		{
			get;
		
		}
		OrderedSet<EClass> eAllSuperTypes
		{
			get;
		
		}
		EAttribute eIDAttribute
		{
			get;
		}
		OrderedSet<EStructuralFeature> eStructuralFeatures
		{
			get;
		
		}
		OrderedSet<EGenericType> eGenericSuperTypes
		{
			get;
		
		}
		OrderedSet<EGenericType> eAllGenericSuperTypes
		{
			get;
		
		}
		bool isSuperTypeOf(EClass someClass);
		int getFeatureCount();
		EStructuralFeature getEStructuralFeature(int featureID);
		int getFeatureID(EStructuralFeature feature);
		EStructuralFeature getEStructuralFeature(string featureName);
		int getOperationCount();
		EOperation getEOperation(int operationID);
		int getOperationID(EOperation operation);
		EOperation getOverride(EOperation operation);
		EGenericType getFeatureType(EStructuralFeature feature);
	}
}
