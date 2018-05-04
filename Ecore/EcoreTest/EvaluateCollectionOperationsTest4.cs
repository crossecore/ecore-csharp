/* CrossEcore is a cross-platform modeling framework that generates C#, TypeScript, 
 * JavaScript, Swift code from Ecore models with embedded OCL (http://www.crossecore.org/).
 * The original Eclipse Modeling Framework is available at https://www.eclipse.org/modeling/emf/.
 * 
 * contributor: Simon Schwichtenberg
 */
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using oclstdlib;
namespace EcoreTest {
	
	[TestClass]
	public class EvaluateCollectionOperationsTest4 {
		
		private TestOCL ocl = new TestOCL();
		
		[TestMethod]			
		public void testCollectionUnionNullValue1(){			
		// Arrangement
		    var expected = new Bag<string>{"a", null, "b", null};
		// Action
		    var actual = new Sequence<string>{"a", null}.union(new Sequence<string>{"b", null});
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionUnionNullValue2(){			
		// Arrangement
		    var expected = new Bag<string>{"a", null, "b", null};
		// Action
		    var actual = new Bag<string>{"a", null}.union(new Set<string>{"b", null});
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionUnionNullValue3(){			
		// Arrangement
		    var expected = new Bag<string>{"a", null, "b", null};
		// Action
		    var actual = new Bag<string>{"a", null}.union(new Bag<string>{"b", null});
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionUnionNullValue4(){			
		// Arrangement
		    var expected = new Bag<string>{"a", null, "b", null};
		// Action
		    var actual = new Set<string>{"a", null}.union(new Bag<string>{"b", null});
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionUnionNullValue5(){			
		// Arrangement
		    var expected = new Set<string>{"a", null, "b"};
		// Action
		    var actual = new Set<string>{"a", null}.union(new Set<string>{"b", null});
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionUnionNoDuplicates1(){			
		// Arrangement
		    var expected = new Bag<string>{"a", "b", "c", "d"};
		// Action
		    var actual = new Sequence<string>{"a", "b"}.union(new Sequence<string>{"c", "d"});
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionUnionNoDuplicates2(){			
		// Arrangement
		    var expected = new Bag<string>{"a", "b", "c", "d"};
		// Action
		    var actual = new Bag<string>{"a", "b"}.union(new Set<string>{"c", "d"});
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionUnionNoDuplicates3(){			
		// Arrangement
		    var expected = new Bag<string>{"a", "b", "c", "d"};
		// Action
		    var actual = new Bag<string>{"a", "b"}.union(new Bag<string>{"c", "d"});
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionUnionNoDuplicates4(){			
		// Arrangement
		    var expected = new Bag<string>{"a", "b", "c", "d"};
		// Action
		    var actual = new Set<string>{"a", "b"}.union(new Bag<string>{"c", "d"});
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionUnionNoDuplicates5(){			
		// Arrangement
		    var expected = new Set<string>{"a", "b", "c", "d"};
		// Action
		    var actual = new Set<string>{"a", "b"}.union(new Set<string>{"c", "d"});
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionUnionEmptyCollection1(){			
		// Arrangement
		    var expected = new Bag<int>{3, 4};
		// Action
		    var actual = new Sequence<int>{}.union(new Sequence<int>{3, 4});
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionUnionEmptyCollection2(){			
		// Arrangement
		    var expected = new Bag<int>{3, 4};
		// Action
		    var actual = new Bag<int>{}.union(new Set<int>{3, 4});
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionUnionEmptyCollection3(){			
		// Arrangement
		    var expected = new Bag<int>{3, 4};
		// Action
		    var actual = new Bag<int>{}.union(new Bag<int>{3, 4});
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionUnionEmptyCollection4(){			
		// Arrangement
		    var expected = new Bag<int>{3, 4};
		// Action
		    var actual = new Set<int>{}.union(new Bag<int>{3, 4});
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionUnionEmptyCollection5(){			
		// Arrangement
		    var expected = new Set<int>{3, 4};
		// Action
		    var actual = new Set<int>{}.union(new Set<int>{3, 4});
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionUnionEmptyCollection6(){			
		// Arrangement
		    var expected = new Bag<int>{3, 4};
		// Action
		    var actual = new Sequence<int>{3, 4}.union(new Sequence<int>{});
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionUnionEmptyCollection7(){			
		// Arrangement
		    var expected = new Bag<int>{3, 4};
		// Action
		    var actual = new Bag<int>{3, 4}.union(new Set<int>{});
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionUnionEmptyCollection8(){			
		// Arrangement
		    var expected = new Bag<int>{3, 4};
		// Action
		    var actual = new Bag<int>{3, 4}.union(new Bag<int>{});
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionUnionEmptyCollection9(){			
		// Arrangement
		    var expected = new Bag<int>{3, 4};
		// Action
		    var actual = new Set<int>{3, 4}.union(new Bag<int>{});
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionUnionEmptyCollection10(){			
		// Arrangement
		    var expected = new Set<int>{3, 4};
		// Action
		    var actual = new Set<int>{3, 4}.union(new Set<int>{});
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionUnionEmptyCollection11(){			
		// Arrangement
		    var expected = new Set<int>{3, 4};
		// Action
		    var actual = new Set<int>{}.union(new Set<int>{3, 4});
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionUnionDuplicates1(){			
		// Arrangement
		    var expected = new Bag<string>{"a", "b", "a", "b", "c"};
		// Action
		    var actual = new Sequence<string>{"a", "b", "a"}.union(new Sequence<string>{"b", "c"});
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionUnionDuplicates2(){			
		// Arrangement
		    var expected = new Bag<string>{"a", "b", "a", "b", "c"};
		// Action
		    var actual = new Bag<string>{"a", "b", "a"}.union(new Set<string>{"b", "c"});
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionUnionDuplicates3(){			
		// Arrangement
		    var expected = new Bag<string>{"a", "b", "a", "b", "c"};
		// Action
		    var actual = new Bag<string>{"a", "b", "a"}.union(new Bag<string>{"b", "c"});
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionUnionDuplicates4(){			
		// Arrangement
		    var expected = new Bag<string>{"a", "b", "b", "c"};
		// Action
		    var actual = new Set<string>{"a", "b", "a"}.union(new Bag<string>{"b", "c"});
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionUnionDuplicates5(){			
		// Arrangement
		    var expected = new Set<string>{"a", "b", "c"};
		// Action
		    var actual = new Set<string>{"a", "b", "a"}.union(new Set<string>{"b", "c"});
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionSymmetricDifference1(){			
		// Arrangement
		    var expected = new Set<string>{"a", null, "c"};
		// Action
		    var actual = new Set<string>{"a", null, "b"}.symmetricDifference(new Set<string>{"b", "c"});
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionSymmetricDifference2(){			
		// Arrangement
		    var expected = new Set<string>{"a", "c"};
		// Action
		    var actual = new Set<string>{"a", "b"}.symmetricDifference(new Set<string>{"b", "c"});
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionSubSequence1(){			
		// Arrangement
		    var expected = new Sequence<string>{"d"};
		// Action
		    var actual = new Sequence<string>{"a", "b", "c", "d"}.subSequence(4,4);
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionSubSequence2(){			
		// Arrangement
		    var expected = new Sequence<string>{"b", "c"};
		// Action
		    var actual = new Sequence<string>{"a", "b", "c", "d"}.subSequence(2,3);
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionSubSequence3(){			
		// Arrangement
		    var expected = new Sequence<string>{"a"};
		// Action
		    var actual = new Sequence<string>{"a", "b", "c", "d"}.subSequence(1,1);
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionSubOrderedSet1(){			
		// Arrangement
		    var expected = new OrderedSet<string>{"d"};
		// Action
		    var actual = new OrderedSet<string>{"a", "b", "c", "d"}.subOrderedSet(4,4);
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionSubOrderedSet2(){			
		// Arrangement
		    var expected = new OrderedSet<string>{"b", "c"};
		// Action
		    var actual = new OrderedSet<string>{"a", "b", "c", "d"}.subOrderedSet(2,3);
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionSubOrderedSet3(){			
		// Arrangement
		    var expected = new OrderedSet<string>{"a"};
		// Action
		    var actual = new OrderedSet<string>{"a", "b", "c", "d"}.subOrderedSet(1,1);
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionSelectByType1(){			
		// Arrangement
		    var expected = new Sequence<string>{"TEST"};
		// Action
		    var actual = new Sequence<object>{4, 4, 5.0, "test"}.selectByType<string>().collect(temp1 => temp1.ToUpper());
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionSelectByType2(){			
		// Arrangement
		    var expected = new Set<UnlimitedNatural> { UnlimitedNatural.UNLIMITED, UnlimitedNatural.UNLIMITED };
		// Action
		    var actual = new Set<object>{4, 4, UnlimitedNatural.UNLIMITED, 5.0, "test", UnlimitedNatural.UNLIMITED }.selectByType<UnlimitedNatural>();
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionSelectByType3(){			
		// Arrangement
		    var expected = new Sequence<UnlimitedNatural> { UnlimitedNatural.UNLIMITED, UnlimitedNatural.UNLIMITED };
            // Action
            var actual = new Sequence<object>{4, 4, UnlimitedNatural.UNLIMITED, 5.0, "test", UnlimitedNatural.UNLIMITED }.selectByType<UnlimitedNatural>();
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionSelectByType4(){			
		// Arrangement
		    var expected = new OrderedSet<UnlimitedNatural> { UnlimitedNatural.UNLIMITED, UnlimitedNatural.UNLIMITED };
            // Action
            var actual = new OrderedSet<object>{4, 4, UnlimitedNatural.UNLIMITED, 5.0, "test", UnlimitedNatural.UNLIMITED }.selectByType<UnlimitedNatural>();
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionSelectByType5(){			
		// Arrangement
		    var expected = new Bag<UnlimitedNatural> { UnlimitedNatural.UNLIMITED, UnlimitedNatural.UNLIMITED };
            // Action
            var actual = new Bag<object>{4, 4, UnlimitedNatural.UNLIMITED, 5.0, "test", UnlimitedNatural.UNLIMITED }.selectByType<UnlimitedNatural>();
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionSelectByType6(){			
		// Arrangement
		    var expected = new Set<OclVoid> {};
		// Action
		    var actual = new Set<OclVoid> {null}.selectByType<OclVoid>();
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionSelectByType7(){			
		// Arrangement
		    var expected = new Sequence<OclVoid> {};
		// Action
		    var actual = new Sequence<OclVoid> {null}.selectByType<OclVoid>();
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionSelectByType8(){			
		// Arrangement
		    var expected = new OrderedSet<OclVoid> {};
		// Action
		    var actual = new OrderedSet<OclVoid> {null}.selectByType<OclVoid>();
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionSelectByType9(){			
		// Arrangement
		    var expected = new Bag<OclVoid> {};
		// Action
		    var actual = new Bag<OclVoid> {null}.selectByType<OclVoid>();
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionSelectByType10(){			
		// Arrangement
		    var expected = new Set<OclVoid> {null};
		// Action
		    var actual = new Set<OclVoid> {null}.selectByType<OclVoid>();
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionSelectByType11(){			
		// Arrangement
		    var expected = new Sequence<OclVoid> {null};
		// Action
		    var actual = new Sequence<OclVoid> {null}.selectByType<OclVoid>();
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionSelectByType12(){			
		// Arrangement
		    var expected = new OrderedSet<OclVoid> {null};
		// Action
		    var actual = new OrderedSet<OclVoid> {null}.selectByType<OclVoid>();
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionSelectByType13(){			
		// Arrangement
		    var expected = new Bag<OclVoid> {null};
		// Action
		    var actual = new Bag<OclVoid> {null}.selectByType<OclVoid>();
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionSelectByType14(){			
		// Arrangement
		    var expected = new Set<OclVoid> {};
		// Action
		    var actual = new Set<OclVoid> {null}.selectByType<OclVoid>();
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionSelectByType15(){			
		// Arrangement
		    var expected = new Sequence<OclVoid> {};
		// Action
		    var actual = new Sequence<OclVoid> {null}.selectByType<OclVoid>();
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionSelectByType16(){			
		// Arrangement
		    var expected = new OrderedSet<OclVoid> {};
		// Action
		    var actual = new OrderedSet<OclVoid> {null}.selectByType<OclVoid>();
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionSelectByType17(){			
		// Arrangement
		    var expected = new Bag<OclVoid> {};
		// Action
		    var actual = new Bag<OclVoid> {null}.selectByType<OclVoid>();
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionSelectByType18(){			
		// Arrangement
		    var expected = new Set<OclVoid> {};
		// Action
		    var actual = new Set<OclVoid> {}.selectByType<OclVoid>();
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionSelectByType19(){			
		// Arrangement
		    var expected = new Sequence<OclVoid> {};
		// Action
		    var actual = new Sequence<OclVoid> {}.selectByType<OclVoid>();
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionSelectByType20(){			
		// Arrangement
		    var expected = new OrderedSet<object> {};
		// Action
		    var actual = new OrderedSet<object> {}.selectByType<object>();
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionSelectByType21(){			
		// Arrangement
		    var expected = new Bag<object>{};
		// Action
		    var actual = new Bag<object>{}.selectByType<object>();
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionSelectByType22(){			
		// Arrangement
		    var expected = new Set<int>{4};
		// Action
		    var actual = new Set<object>{4, 4, 5.0, "test", null}.selectByType<int>();
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
        [TestMethod]
        public void testCollectionSelectByType23()
        {
            // Arrangement
            var expected = new Sequence<int> { 4, 4 };
            // Action 
            var actual = new Sequence<object> { 4, 4, 5.0, "test", null }.selectByType<int>();
            // Assertion 
            ocl.assertQueryResults(expected, actual);
        }
        [TestMethod]			
		public void testCollectionSelectByType24(){			
		// Arrangement
		    var expected = new OrderedSet<int>{4};
		// Action
		    var actual = new OrderedSet<object>{4, 4, 5.0, "test", null}.selectByType<int>();
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionSelectByType25(){			
		// Arrangement
		    var expected = new Bag<int>{4, 4};
		// Action
		    var actual = new Bag<object>{4, 4, 5.0, "test", null}.selectByType<int>();
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionSelectByKind1(){			
		// Arrangement
		    var expected = new Sequence<string>{"TEST"};
		// Action
		    var actual = new Sequence<object>{4, 4, 5.0, "test"}.selectByKind<string>().collect(temp1 => temp1.ToUpper());
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionSelectByKind2(){			
		// Arrangement
		    var expected = new Set<UnlimitedNatural> { UnlimitedNatural.UNLIMITED };
		// Action
		    var actual = new Set<object> {4, 4, UnlimitedNatural.UNLIMITED , 5.0, "test", UnlimitedNatural.UNLIMITED }.selectByKind<UnlimitedNatural>();
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionSelectByKind3(){			
		// Arrangement
		    var expected = new Sequence<UnlimitedNatural> { UnlimitedNatural.UNLIMITED, UnlimitedNatural.UNLIMITED };
		// Action
		    var actual = new Sequence<object>{4, 4, UnlimitedNatural.UNLIMITED, 5.0, "test", UnlimitedNatural.UNLIMITED }.selectByKind<UnlimitedNatural>();
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionSelectByKind4(){			
		// Arrangement
		    var expected = new OrderedSet<UnlimitedNatural> { UnlimitedNatural.UNLIMITED};
		// Action
		    var actual = new OrderedSet<object>{4, 4, UnlimitedNatural.UNLIMITED, 5.0, "test", UnlimitedNatural.UNLIMITED }.selectByKind<UnlimitedNatural>();
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionSelectByKind5(){			
		// Arrangement
		    var expected = new Bag<UnlimitedNatural> { UnlimitedNatural.UNLIMITED, UnlimitedNatural.UNLIMITED };
		// Action
		    var actual = new Bag<object>{4, 4, UnlimitedNatural.UNLIMITED, 5.0, "test", UnlimitedNatural.UNLIMITED }.selectByKind<UnlimitedNatural>();
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionSelectByKind6(){			
		// Arrangement
		    var expected = new Set<OclInvalid> {};
		// Action
		    var actual = new Set<object>{null}.selectByKind<OclInvalid>();
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionSelectByKind7(){			
		// Arrangement
		    var expected = new Sequence<OclInvalid> {};
		// Action
		    var actual = new Sequence<object>{null}.selectByKind<OclInvalid>();
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionSelectByKind8(){			
		// Arrangement
		    var expected = new OrderedSet<OclInvalid> {};
		// Action
		    var actual = new OrderedSet<object>{null}.selectByKind<OclInvalid>();
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionSelectByKind9(){			
		// Arrangement
		    var expected = new Bag<OclInvalid> {};
		// Action
		    var actual = new Bag<object>{null}.selectByKind<OclInvalid>();
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionSelectByKind10(){			
		// Arrangement
		    var expected = new Set<OclVoid> {};
		// Action
		    var actual = new Set<object>{null}.selectByKind<OclVoid>();
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionSelectByKind11(){			
		// Arrangement
		    var expected = new Sequence<OclVoid> {};
		// Action
		    var actual = new Sequence<object>{null}.selectByKind<OclVoid>();
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionSelectByKind12(){			
		// Arrangement
		    var expected = new OrderedSet<OclVoid> {};
		// Action
		    var actual = new OrderedSet<object>{null}.selectByKind<OclVoid>();
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionSelectByKind13(){			
		// Arrangement
		    var expected = new Bag<OclVoid> {};
		// Action
		    var actual = new Bag<object>{null}.selectByKind<OclVoid>();
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionSelectByKind14(){			
		// Arrangement
		    var expected = new Set<int>{};
		// Action
		    var actual = new Set<object>{null}.selectByKind<int>();
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionSelectByKind15(){			
		// Arrangement
		    var expected = new Sequence<int>{};
		// Action
		    var actual = new Sequence<object>{null}.selectByKind<int>();
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionSelectByKind16(){			
		// Arrangement
		    var expected = new OrderedSet<int>{};
		// Action
		    var actual = new OrderedSet<object>{null}.selectByKind<int>();
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionSelectByKind17(){			
		// Arrangement
		    var expected = new Bag<int>{};
		// Action
		    var actual = new Bag<object>{null}.selectByKind<int>();
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionSelectByKind18(){			
		// Arrangement
		    var expected = new Set<int>{};
		// Action
		    var actual = new Set<object>{}.selectByKind<int>();
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionSelectByKind19(){			
		// Arrangement
		    var expected = new Sequence<int>{};
		// Action
		    var actual = new Sequence<object>{}.selectByKind<int>();
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionSelectByKind20(){			
		// Arrangement
		    var expected = new OrderedSet<int>{};
		// Action
		    var actual = new OrderedSet<object>{}.selectByKind<int>();
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionSelectByKind21(){			
		// Arrangement
		    var expected = new Bag<int> {};
		// Action
		    var actual = new Bag<OclVoid>{null}.selectByKind<int>();
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionSelectByKind22(){			
		// Arrangement
		    var expected = new Set<int>{4};
		// Action
		    var actual = new Set<object>{4, 4, 5.0, "test", null}.selectByKind<int>();
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionSelectByKind23(){			
		// Arrangement
		    var expected = new Sequence<int>{4, 4};
		// Action
		    var actual = new Sequence<object>{4, 4, 5.0, "test", null}.selectByKind<int>();
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionSelectByKind24(){			
		// Arrangement
		    var expected = new OrderedSet<int>{4};
		// Action
		    var actual = new OrderedSet<object>{4, 4, 5.0, "test", null}.selectByKind<int>();
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionSelectByKind25(){			
		// Arrangement
		    var expected = new Bag<int>{4, 4};
		// Action
		    var actual = new Bag<object>{4, 4, 5.0, "test", null}.selectByKind<int>();
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionProductNullValue1(){			
		// Arrangement
		    var expected = ((Func<Set<Tuple<double?, int>>>)(() => { var n = null as double?; return new Set<Tuple<double?, int>>{new Tuple<double?, int>(n,3), new Tuple<double?, int>(4.0, 3) }; }))();
		    ;
		// Action
		    var actual = new OrderedSet<double?>{null, 4.0}.product(new Sequence<int>{3});
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionProductNullValue2(){
            // Arrangement
            var expected = ((Func<Set<Tuple<double?, int>>>)(() => { var n = null as double?; return new Set<Tuple<double?, int>> { new Tuple<double?, int>(n, 3), new Tuple<double?, int>(4.0, 3) }; }))();
            ;
            // Action
            var actual = new OrderedSet<double?> { null, 4.0 }.product(new Set<int> { 3 });
            // Assertion 
            ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionProductNullValue3(){
            // Arrangement
            var expected = ((Func<Set<Tuple<double?, int>>>)(() => { var n = null as double?; return new Set<Tuple<double?, int>> { new Tuple<double?, int>(n, 3), new Tuple<double?, int>(4.0, 3) }; }))();
            ;
            // Action
            var actual = new OrderedSet<double?> { null, 4.0 }.product(new Bag<int> { 3 });
            // Assertion 
            ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionProductNullValue4(){
            // Arrangement
            var expected = ((Func<Set<Tuple<double?, int>>>)(() => { var n = null as double?; return new Set<Tuple<double?, int>> { new Tuple<double?, int>(n, 3), new Tuple<double?, int>(4.0, 3) }; }))();
            ;
            // Action
            var actual = new OrderedSet<double?> { null, 4.0 }.product(new Sequence<int> { 3 });
            // Assertion 
            ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionProductNullValue5(){
            // Arrangement
            var expected = ((Func<Set<Tuple<int?, int>>>)(() => { var nu = null as int?; return new Set<Tuple<int?, int>> { new Tuple<int?, int>(nu, 3), new Tuple<int?, int>(4, 3) }; }))();
            ;
		// Action
		    var actual = new OrderedSet<int?>{null, 4}.product(new Sequence<int>{3});
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionProductNullValue6(){
            // Arrangement
            var expected = ((Func<Set<Tuple<int?, int>>>)(() => { var nu = null as int?; return new Set<Tuple<int?, int>> { new Tuple<int?, int>(nu, 3), new Tuple<int?, int>(4, 3) }; }))();
            ;
            // Action
            var actual = new Set<int?> { null, 4 }.product(new Bag<int> { 3 });
            // Assertion 
            ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionProductNullValue7(){
            // Arrangement
            var expected = ((Func<Set<Tuple<int?, int>>>)(() => { var nu = null as int?; return new Set<Tuple<int?, int>> { new Tuple<int?, int>(nu, 3), new Tuple<int?, int>(4, 3) }; }))();
            ;
            // Action
            var actual = new Bag<int?> { null, 4 }.product(new Set<int> { 3 });
            // Assertion 
            ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionProductNullValue8(){
            // Arrangement
            var expected = ((Func<Set<Tuple<int?, int>>>)(() => { var nu = null as int?; return new Set<Tuple<int?, int>> { new Tuple<int?, int>(nu, 3), new Tuple<int?, int>(4, 3) }; }))();
            ;
		// Action
		    var actual = new Sequence<int?>{null, 4}.product(new Sequence<int>{3});
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionProductNullValue9(){			
		// Arrangement
		    var expected = new Set<Tuple<int?, int>>{ new Tuple<int?, int>(null, 3), new Tuple<int?, int>(null, 4) };
		// Action
		    var actual = new OrderedSet<int?>{null}.product(new Sequence<int>{3, 4});
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionProductNullValue10(){
            // Arrangement
            var expected = new Set<Tuple<int?, int>> { new Tuple<int?, int>(null, 3), new Tuple<int?, int>(null, 4) };
            // Action
            var actual = new Set<int?>{null}.product(new Bag<int>{3, 4});
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionProductNullValue11(){
            // Arrangement
            var expected = new Set<Tuple<int?, int>> { new Tuple<int?, int>(null, 3), new Tuple<int?, int>(null, 4) };
            // Action
            var actual = new Bag<int?> { null }.product(new Set<int> { 3, 4 });
            // Assertion 
            ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionProductNullValue12(){
            // Arrangement
            var expected = new Set<Tuple<int?, int>> { new Tuple<int?, int>(null, 3), new Tuple<int?, int>(null, 4) };
            // Action
            var actual = new Sequence<int?>{null}.product(new OrderedSet<int>{3, 4});
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionProductNullValue13(){
            // Arrangement
            var expected = new Set<Tuple<int, int?>> { new Tuple<int, int?>(3, null), new Tuple<int, int?>(4, null) };
            // Action
            var actual = new OrderedSet<int>{3, 4}.product(new Sequence<int?>{null});
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionProductNullValue14(){
            // Arrangement
            var expected = new Set<Tuple<int, int?>> { new Tuple<int, int?>(3, null), new Tuple<int, int?>(4, null) };
            // Action
            var actual = new Set<int>{3, 4}.product(new Bag<int?>{null});
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionProductNullValue15(){
            // Arrangement
            var expected = new Set<Tuple<int, int?>> { new Tuple<int, int?>(3, null), new Tuple<int, int?>(4, null) };
            // Action
            var actual = new Bag<int>{3, 4}.product(new Set<int?>{null});
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionProductNullValue16(){
            // Arrangement
            var expected = new Set<Tuple<int, int?>> { new Tuple<int, int?>(3, null), new Tuple<int, int?>(4, null) };
            // Action
            var actual = new Sequence<int>{3, 4}.product(new OrderedSet<object>{null});
		// Assertion 
		    //ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionProduct1(){			
		// Arrangement
		    var expected = new Set<Tuple<int, double>>{new Tuple<int, double>(3,3.0), new Tuple<int, double>(3, 4.0), new Tuple<int, double>(4, 3.0), new Tuple<int, double>(4, 4.0) };
		// Action
		    var actual = new Sequence<int> {3, 4}.product(new Sequence<double> {3.0, 4});
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionProduct2(){			
		}
		[TestMethod]			
		public void testCollectionProduct3(){			
		}
		[TestMethod]			
		public void testCollectionProduct4(){			
		}
		[TestMethod]			
		public void testCollectionProduct5(){			
		}
		[TestMethod]			
		public void testCollectionProduct6(){			
		}
		[TestMethod]			
		public void testCollectionProduct7(){			
		}
		[TestMethod]			
		public void testCollectionProduct8(){			
		}
		[TestMethod]			
		public void testCollectionProduct9(){			
		}
		[TestMethod]			
		public void testCollectionProduct10(){			
		}
		[TestMethod]			
		public void testCollectionProduct11(){			
		}
		[TestMethod]			
		public void testCollectionProduct12(){			
		}
		[TestMethod]			
		public void testCollectionProduct13(){			
		}
		[TestMethod]			
		public void testCollectionProduct14(){			
		}
		[TestMethod]			
		public void testCollectionProduct15(){			
		}
		[TestMethod]			
		public void testCollectionProduct16(){			
		}
		[TestMethod]			
		public void testCollectionProduct17(){			
		}
		[TestMethod]			
		public void testCollectionPrepend1(){			
		// Arrangement
		    var expected = new OrderedSet<string>{null, "a", "b"};
		// Action
		    var actual = new OrderedSet<string>{"a", null, "b"}.prepend(null);
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionPrepend2(){			
		// Arrangement
		    var expected = new Sequence<string>{null, "a", null, "b"};
		// Action
		    var actual = new Sequence<string>{"a", null, "b"}.prepend(null);
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionPrepend3(){			
		// Arrangement
		    var expected = new OrderedSet<string>{"c", "a", "b"};
		// Action
		    var actual = new OrderedSet<string>{"a", "b"}.prepend("c");
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionPrepend4(){			
		// Arrangement
		    var expected = new Sequence<string>{"c", "a", "b"};
		// Action
		    var actual = new Sequence<string>{"a", "b"}.prepend("c");
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionMinus1(){			
		// Arrangement
		    var expected = new Set<object>{null};
		// Action
		    var actual = new Set<object>{"a", null}.minus(new Set<object>{"c", "a"});
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionMinus2(){			
		// Arrangement
		    var expected = new Set<string>{"a"};
		// Action
		    var actual = new Set<string>{"a", null}.minus(new Set<string>{"c", null});
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionMinus3(){			
		// Arrangement
		    var expected = new OrderedSet<string>{"b"};
		// Action
		    var actual = new OrderedSet<string>{"a", "b", "c"}.minus(new Set<string>{"c", "a"});
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionMinus4(){			
		// Arrangement
		    var expected = new Set<string>{"b"};
		// Action
		    var actual = new Set<string> {"a", "b", "c"}.minus(new Set<string> {"c", "a"});
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionIsEmpty1(){			
		// Arrangement
		    var expected = new Set<string>{"test"};
            // Action
            var actual = new Set<string> { "test" }; //'test'.oclAsSet();
        // Assertion 
            ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionIntersectionReturnType1(){			
		// Arrangement
		    var expected = new Set<string>{"c"};
		// Action
		    var actual = ((Func<Set<string>>)(() => { var domainVars = new Set<string>{"a"}; var whenVars = new Set<string>{"b"};var tev = "c"; return domainVars.intersection(whenVars).including(tev);}))();
		    ;
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionIntersectionReturnType2(){			
		// Arrangement
		    var expected = new Set<string>{"c"};
		// Action
		    var actual = new Set<string>{"a"}.intersection(new Set<string>{"b"}).including("c");
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionIntersection1(){			
		// Arrangement
		    var expected = new Bag<int?>{null, null};
		// Action
		    var actual = new Bag<int?>{3, 4, null, null}.intersection(new Bag<int?>{null, 2, null});
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionIntersection2(){			
		// Arrangement
		    var expected = new Set<int?>{2, null};
		// Action
		    var actual = new Bag<int?>{2, 3, null}.intersection(new Set<int?>{2, 4, null});
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionIntersection3(){			
		// Arrangement
		    var expected = new Set<int?>{2, null};
		// Action
		    var actual = new Set<int?>{2, 3, null}.intersection(new Bag<int?>{2, 4, null});
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionIntersection4(){			
		// Arrangement
		    var expected = new Set<int?>{2, null};
		// Action
		    var actual = new Set<int?>{2, 3, null}.intersection(new Set<int?>{2, 4, null});
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionIntersection5(){			
		// Arrangement
		    var expected = new Bag<string>{"a"};
		// Action
		    var actual = new Bag<string>{"a", "a", "a", "a"}.intersection(new Bag<string>{"a", "b", "b"});
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionIntersection6(){			
		// Arrangement
		    var expected = new Bag<string>{"a", "b"};
		// Action
		    var actual = new Bag<string>{"a", "b", "a"}.intersection(new Bag<string>{"a", "b", "c"});
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionIntersection7(){			
		// Arrangement
		    var expected = new Bag<string>{"a", "b", "b"};
		// Action
		    var actual = new Bag<string>{"a", "b", "a", "b"}.intersection(new Bag<string>{"a", "b", "b"});
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionIntersection8(){			
		// Arrangement
		    var expected = new Bag<string>{"a", "b"};
		// Action
		    var actual = new Bag<string>{"a", "b"}.intersection(new Bag<string>{"a", "b", "a"});
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionIntersection9(){			
		// Arrangement
		    var expected = new Bag<string>{"a", "b"};
		// Action
		    var actual = new Bag<string>{"a", "b", "a"}.intersection(new Bag<string>{"a", "b"});
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionIntersection10(){			
		// Arrangement
		    var expected = new Set<string>{"a", "b"};
		// Action
		    var actual = new Bag<string>{"a", "b", "a"}.intersection(new Set<string>{"a", "b", "c"});
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionIntersection11(){			
		// Arrangement
		    var expected = new Set<string>{"a", "b"};
		// Action
		    var actual = new Set<string>{"a", "b", "a"}.intersection(new Bag<string>{"a", "b", "c"});
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionIntersection12(){			
		// Arrangement
		    var expected = new Set<string>{"a", "b"};
		// Action
		    var actual = new Set<string>{"a", "b", "a"}.intersection(new Set<string>{"a", "b", "c"});
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionInsertAt1(){			
		// Arrangement
		    var expected = new OrderedSet<string>{"a", "c", "b"};
		// Action
		    var actual = new OrderedSet<string>{"a", "b", "c"}.insertAt(2,"b");
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionInsertAt2(){			
		// Arrangement
		    var expected = new OrderedSet<string>{"a", "b", "c"};
		// Action
		    var actual = new OrderedSet<string>{"a", "b", "c"}.insertAt(1,"b");
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionInsertAt3(){			
		// Arrangement
		    var expected = new OrderedSet<string>{"b", "a", "c"};
		// Action
		    var actual = new OrderedSet<string>{"a", "b", "c"}.insertAt(0,"b");
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionInsertAt4(){			
		// Arrangement
		    var expected = new Sequence<string>{"a", "b", "c", "b"};
		// Action
		    var actual = new Sequence<string>{"a", "b", "c"}.insertAt(3,"b");
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionInsertAt5(){			
		// Arrangement
		    var expected = new Sequence<string>{"b", "a", "b", "c"};
		// Action
		    var actual = new Sequence<string>{"a", "b", "c"}.insertAt(0,"b");
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionInsertAt6(){			
		// Arrangement
		    var expected = new OrderedSet<object>{null};
		// Action
		    var actual = new OrderedSet<object>{null}.insertAt(0,null);
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionInsertAt7(){			
		// Arrangement
		    var expected = new OrderedSet<string>{"a", null};
		// Action
		    var actual = new OrderedSet<string>{"a"}.insertAt(1,null);
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionInsertAt8(){			
		// Arrangement
		    var expected = new Sequence<object>{null, null};
		// Action
		    var actual = new Sequence<object>{null}.insertAt(0,null);
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionInsertAt9(){			
		// Arrangement
		    var expected = new Sequence<string>{null, "a"};
		// Action
		    var actual = new Sequence<string>{"a"}.insertAt(0,null);
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionInsertAt10(){			
		// Arrangement
		    var expected = new OrderedSet<string>{"a", "b", "c"};
		// Action
		    var actual = new OrderedSet<string>{"a", "b"}.insertAt(2,"c");
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionInsertAt11(){			
		// Arrangement
		    var expected = new Sequence<string>{"a", "b", "c"};
		// Action
		    var actual = new Sequence<string>{"a", "b"}.insertAt(2,"c");
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionInsertAt12(){			
		// Arrangement
		    var expected = new OrderedSet<string>{"a", "c", "b"};
		// Action
		    var actual = new OrderedSet<string>{"a", "b"}.insertAt(1,"c");
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionInsertAt13(){			
		// Arrangement
		    var expected = new Sequence<string>{"c", "a", "b"};
		// Action
		    var actual = new Sequence<string>{"a", "b"}.insertAt(0,"c");
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionIncluding1(){			
		// Arrangement
		    var expected = new OrderedSet<string>{"a", null, "b"};
		// Action
		    var actual = new OrderedSet<string>{"a", null, "b"}.including(null);
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionIncluding2(){			
		// Arrangement
		    var expected = new Set<string>{"a", null, "b"};
		// Action
		    var actual = new Set<string>{"a", null, "b"}.including(null);
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionIncluding3(){			
		// Arrangement
		    var expected = new Bag<string>{null, "b", null, "a"};
		// Action
		    var actual = new Bag<string>{"a", null, "b"}.including(null);
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionIncluding4(){			
		// Arrangement
		    var expected = new Sequence<string>{"a", null, "b", null};
		// Action
		    var actual = new Sequence<string>{"a", null, "b"}.including(null);
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionIncluding5(){			
		// Arrangement
		    var expected = new OrderedSet<string>{"a", "b", null};
		// Action
		    var actual = new OrderedSet<string>{"a", "b"}.including(null);
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionIncluding6(){			
		// Arrangement
		    var expected = new Set<string>{"a", null, "b"};
		// Action
		    var actual = new Set<string>{"a", "b"}.including(null);
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionIncluding7(){			
		// Arrangement
		    var expected = new Bag<string>{null, "b", "a"};
		// Action
		    var actual = new Bag<string>{"a", "b"}.including(null);
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionIncluding8(){			
		// Arrangement
		    var expected = new Sequence<string>{"a", "b", null};
		// Action
		    var actual = new Sequence<string>{"a", "b"}.including(null);
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionIncluding9(){			
		// Arrangement
		    var expected = new OrderedSet<string>{"a", "b", "c"};
		// Action
		    var actual = new OrderedSet<string>{"a", "b"}.including("c");
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionIncluding10(){			
		// Arrangement
		    var expected = new Set<string>{"a", "c", "b"};
		// Action
		    var actual = new Set<string>{"a", "b"}.including("c");
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionIncluding11(){			
		// Arrangement
		    var expected = new Bag<string>{"c", "b", "a"};
		// Action
		    var actual = new Bag<string>{"a", "b"}.including("c");
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionIncluding12(){			
		// Arrangement
		    var expected = new Sequence<string>{"a", "b", "c"};
		// Action
		    var actual = new Sequence<string>{"a", "b"}.including("c");
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionFlatten1(){			
		// Arrangement
		    var expected = new Set<int>{1};
		// Action
		    var actual = ((Func<Set<int>>)(() => { var o = null as Set<int>; return o.flatten<int>(); }))();
		    ;
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionFlatten2(){			
		// Arrangement
		    var expected = new Set<int>{1};
		// Action
		    var actual = ((Func<Set<int>>)(() => { var s = null as Set<int>; return new Set<int>{1}.flatten<int>(); }))();
		    ;
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionFlatten3(){			
		// Arrangement
		    var expected = new Set<int>{1};
		// Action
		    var actual = ((Func<Set<int>>)(() => { var b = null as Set<int>; return new Set<int>{1}.flatten<int>(); }))();
		    ;
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionFlatten4(){			
		// Arrangement
		    var expected = new Set<int>{1};
		// Action
		    var actual = ((Func<Set<int>>)(() => { var s = null as object; return new Set<int>{1}.flatten<int>(); }))();
		    ;
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionFlatten5(){			
		// Arrangement
		    var expected = new Set<int>{1};
		// Action
		    var actual = new Set<int>{1}.flatten<int>();
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionFlatten6(){			
		}
		[TestMethod]			
		public void testCollectionExcluding1(){			
		// Arrangement
		    var expected = new OrderedSet<string>{"a", "b"};
		// Action
		    var actual = new OrderedSet<string>{"a", null, "b"}.excluding(null);
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionExcluding2(){			
		// Arrangement
		    var expected = new Set<string>{"b", "a"};
		// Action
		    var actual = new Set<string>{"a", null, "b"}.excluding(null);
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionExcluding3(){			
		// Arrangement
		    var expected = new Bag<string>{"b", "a"};
		// Action
		    var actual = new Bag<string>{null, "a", null, "b"}.excluding(null);
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionExcluding4(){			
		// Arrangement
		    var expected = new Sequence<string>{"a", "b"};
		// Action
		    var actual = new Sequence<string>{null, "a", null, "b"}.excluding(null);
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionExcluding5(){			
		// Arrangement
		    var expected = new OrderedSet<string>{"a", "c"};
		// Action
		    var actual = new OrderedSet<string>{"a", "b", "c"}.excluding("b");
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionExcluding6(){			
		// Arrangement
		    var expected = new Set<string>{"c", "a"};
		// Action
		    var actual = new Set<string>{"a", "b", "c"}.excluding("b");
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionExcluding7(){			
		// Arrangement
		    var expected = new Bag<string>{"c", "a"};
		// Action
		    var actual = new Bag<string>{"b", "a", "b", "c"}.excluding("b");
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionExcluding8(){			
		// Arrangement
		    var expected = new Sequence<string>{"a", "c"};
		// Action
		    var actual = new Sequence<string>{"b", "a", "b", "c"}.excluding("b");
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionAsSet1(){			
		// Arrangement
		    var expected = new Set<string>{"a", "b", "c"};
		// Action
		    var actual = new OrderedSet<string>{"a", "b", "c", "b"}.asSet();
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionAsSet2(){			
		// Arrangement
		    var expected = new Set<string>{"a", "b", "c"};
		// Action
		    var actual = new Set<string>{"a", "b", "c", "b"}.asSet();
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionAsSet3(){			
		// Arrangement
		    var expected = new Set<string>{"a", "b", "c"};
		// Action
		    var actual = new Bag<string>{"a", "b", "c", "b"}.asSet();
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionAsSet4(){			
		// Arrangement
		    var expected = new Set<string>{"a", "b", "c"};
		// Action
		    var actual = new Sequence<string>{"a", "b", "c", "b"}.asSet();
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionAsSet5(){			
		// Arrangement
		    var expected = new Set<object>{1, 2.0, "3"};
		// Action
		    var actual = new OrderedSet<object>{1, 2.0, "3"}.asSet();
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionAsSet6(){			
		// Arrangement
		    var expected = new Set<object>{1, 2.0, "3"};
		// Action
		    var actual = new Sequence<object>{1, 2.0, "3"}.asSet();
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionAsSequence1(){			
		// Arrangement
		    var expected = new Sequence<object>{1, 2.0, "3"};
		// Action
		    var actual = new OrderedSet<object>{1, 2.0, "3"}.asSequence();
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionAsSequence2(){			
		// Arrangement
		    var expected = new Sequence<object>{1, 2.0, "3"};
		// Action
		    var actual = new Sequence<object>{1, 2.0, "3"}.asSequence();
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionAsOrderedSet1(){			
		// Arrangement
		    var expected = new OrderedSet<string>{"a", "b", "c"};
		// Action
		    var actual = new OrderedSet<string>{"a", "b", "c", "b"}.asOrderedSet();
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionAsOrderedSet2(){			
		// Arrangement
		    var expected = new OrderedSet<string>{"a", "b", "c"};
		// Action
		    var actual = new Sequence<string>{"a", "b", "c", "b"}.asOrderedSet();
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionAsOrderedSet3(){			
		// Arrangement
		    var expected = new OrderedSet<object>{1, 2.0, "3"};
		// Action
		    var actual = new OrderedSet<object>{1, 2.0, "3"}.asOrderedSet();
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionAsOrderedSet4(){			
		// Arrangement
		    var expected = new OrderedSet<object>{1, 2.0, "3"};
		// Action
		    var actual = new Sequence<object>{1, 2.0, "3"}.asOrderedSet();
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionAsBag1(){			
		// Arrangement
		    var expected = new Bag<object>{1, 2.0, "3"};
		// Action
		    var actual = new OrderedSet<object>{1, 2.0, "3"}.asBag();
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionAsBag2(){			
		// Arrangement
		    var expected = new Bag<object>{1, 2.0, "3"};
		// Action
		    var actual = new Set<object>{1, 2.0, "3"}.asBag();
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionAsBag3(){			
		// Arrangement
		    var expected = new Bag<object>{1, 2.0, "3"};
		// Action
		    var actual = new Bag<object>{1, 2.0, "3"}.asBag();
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionAsBag4(){			
		// Arrangement
		    var expected = new Bag<object>{1, 2.0, "3"};
		// Action
		    var actual = new Sequence<object>{1, 2.0, "3"}.asBag();
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionAppend1(){			
		// Arrangement
		    var expected = new OrderedSet<string>{"a", "b", null};
		// Action
		    var actual = new OrderedSet<string>{"a", null, "b"}.append(null);
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionAppend2(){			
		// Arrangement
		    var expected = new Sequence<string>{"a", null, "b", null};
		// Action
		    var actual = new Sequence<string>{"a", null, "b"}.append(null);
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionAppend3(){			
		// Arrangement
		    var expected = new OrderedSet<string>{"a", "b", null};
		// Action
		    var actual = new OrderedSet<string>{"a", "b"}.append(null);
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionAppend4(){			
		// Arrangement
		    var expected = new Sequence<string>{"a", "b", null};
		// Action
		    var actual = new Sequence<string>{"a", "b"}.append(null);
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionAppend5(){			
		// Arrangement
		    var expected = new OrderedSet<string>{"a", "b", "c"};
		// Action
		    var actual = new OrderedSet<string>{"a", "b"}.append("c");
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
		[TestMethod]			
		public void testCollectionAppend6(){			
		// Arrangement
		    var expected = new Sequence<string>{"a", "b", "c"};
		// Action
		    var actual = new Sequence<string>{"a", "b"}.append("c");
		// Assertion 
		    ocl.assertQueryResults(expected, actual);
		}
	    
	}
}
