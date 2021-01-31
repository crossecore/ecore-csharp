/* CrossEcore is a cross-platform modeling framework that generates C#, TypeScript, 
 * JavaScript, Swift code from Ecore models with embedded OCL (http://www.crossecore.org/).
 * The original Eclipse Modeling Framework is available at https://www.eclipse.org/modeling/emf/.
 * 
 * contributor: Simon Schwichtenberg
 */
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using oclstdlib;
delegate int Integer(int i);
namespace EcoreTest
{
    [TestClass]
    public class OrderedSetTest
    {
        /**
         * 1.5.1 any ( expr : OclExpression ) : T
1.5.2 asBag () : Bag(T)
1.5.3 asOrderedSet () : OrderedSet(T)
1.5.4 asSequence () : Boolean
1.5.5 asSet () : Set(T)

1.5.7 collectNested ( expr : OclExpression ) : Collection(T2)

1.5.10 excludesAll ( c2 : Collection(T) ) : Boolean

1.5.13 flatten () : Collection(T2)

1.5.16 includesAll ( c2 : Collection(T) ) : Boolean



1.5.22 product ( c2 : Collection(T2) ) : Set(Tuple(first : T, second : T2))


1.5.26 sortedBy ( expr : OclExpression ) : Sequence(T)

    */

        [TestMethod]
        public void SelectByKind()
        {
            var actual = new Sequence<object>{
                    4,
                    5.0,
                    "test"
                }
            .selectByKind<int>();

            Assert.IsTrue(actual.Count == 1);

        }


        [TestMethod]
        public void sum()
        {
            var orderedset = new OrderedSet<int>();
            
            Assert.AreEqual(orderedset.sum(), 0);
            orderedset.add(1);
            Assert.AreEqual(orderedset.sum(), 1);
            orderedset.add(2);
            Assert.AreEqual(orderedset.sum(), 3);
        }

        [TestMethod]
        public void size()
        {
            var orderedset = new OrderedSet<int>();

            Assert.AreEqual(orderedset.size(), 0);
            orderedset.add(1);
            Assert.AreEqual(orderedset.size(), 1);
            orderedset.add(2);
            Assert.AreEqual(orderedset.size(), 2);
        }

        [TestMethod]
        public void notEmpty()
        {
            var orderedset = new OrderedSet<int>();

            Assert.AreEqual(orderedset.notEmpty(), false);
            orderedset.add(1);
            Assert.AreEqual(orderedset.notEmpty(), true);
        }

        [TestMethod]
        public void isEmpty()
        {
            var orderedset = new OrderedSet<int>();

            Assert.AreEqual(orderedset.isEmpty(), true);
            orderedset.add(1);
            Assert.AreEqual(orderedset.isEmpty(), false);
        }

        [TestMethod]
        public void count()
        {
            var orderedset = new OrderedSet<int>();

            Assert.AreEqual(orderedset.count(1), 0);
            orderedset.add(1);
            Assert.AreEqual(orderedset.count(1), 1);
            orderedset.add(1);//not added, because OrderedSet isUnique=true
            Assert.AreEqual(orderedset.count(1), 1);
        }

        [TestMethod]
        public void includes()
        {
            var orderedset = new OrderedSet<int>();

            Assert.AreEqual(orderedset.includes(1), false);
            orderedset.add(1);
            Assert.AreEqual(orderedset.includes(1), true);
        }

        [TestMethod]
        public void excludes()
        {
            var orderedset = new OrderedSet<int>();

            Assert.AreEqual(orderedset.excludes(1), true);
            orderedset.add(1);
            Assert.AreEqual(orderedset.excludes(1), false);
            Assert.AreEqual(orderedset.excludes(2), true);
        }

        [TestMethod]
        public void exists()
        {
            var orderedset = new OrderedSet<int>();

            Assert.AreEqual(orderedset.exists(i=>i>5), false);
            orderedset.add(1);
            Assert.AreEqual(orderedset.exists(i => i > 5), false);
            orderedset.add(6);
            Assert.AreEqual(orderedset.exists(i => i > 5), true);
        }

        [TestMethod]
        public void collect()
        {
            var orderedset = new OrderedSet<int>();

            var collection = orderedset.collect(i => i * i).asOrderedSet();
            Assert.AreEqual(collection.size(), 0);
            orderedset.add(1);
            collection = orderedset.collect(i => i * i).asOrderedSet();
            Assert.AreEqual(collection.at(0), 1);
            orderedset.add(6);
            collection = orderedset.collect(i => i * i).asOrderedSet();
            Assert.AreEqual(collection.at(1), 36);
        }

        [TestMethod]
        public void select()
        {
            var orderedset = new OrderedSet<int>();

            var collection = orderedset.select(i => i > 5).asOrderedSet();
            Assert.AreEqual(collection.size(), 0);
            orderedset.add(1);
            collection = orderedset.select(i => i > 5).asOrderedSet();
            Assert.AreEqual(collection.size(), 0);
            orderedset.add(6);
            collection = orderedset.select(i => i > 5).asOrderedSet();
            Assert.AreEqual(collection.size(), 1);
            Assert.AreEqual(collection.at(0), 6);
        }

        [TestMethod]
        public void any()
        {
            var orderedset = new OrderedSet<int>();


            Assert.AreEqual(orderedset.any(i=>i>5), default(int));

            orderedset.add(1);
            Assert.AreEqual(orderedset.any(i => i > 5), default(int));

            orderedset.add(6);
            Assert.AreEqual(orderedset.any(i => i >5), 6);

        }

        [TestMethod]
        public void one()
        {
            var orderedset = new OrderedSet<int>();


            Assert.AreEqual(orderedset.one(i => i > 5), false);

            orderedset.add(1);
            Assert.AreEqual(orderedset.one(i => i > 5), false);

            orderedset.add(6);
            Assert.AreEqual(orderedset.one(i => i > 5), true);

            orderedset.add(6);
            Assert.AreEqual(orderedset.one(i => i > 5), true);

            orderedset.add(7);
            Assert.AreEqual(orderedset.one(i => i > 5), false);

        }

        [TestMethod]
        public void forAll()
        {
            var orderedset = new OrderedSet<int>();


            Assert.AreEqual(orderedset.forAll(i => i > 5), true);
            orderedset.add(1);

            Assert.AreEqual(orderedset.forAll(i => i > 5), false);
            orderedset.remove(1);
            orderedset.add(6);

            Assert.AreEqual(orderedset.forAll(i => i > 5), true);
            orderedset.add(7);

            Assert.AreEqual(orderedset.forAll(i => i > 5), true);

        }

        [TestMethod]
        public void reject()
        {
            var orderedset = new OrderedSet<int>();

            var collection = orderedset.reject(i => i > 5);
            Assert.AreEqual(collection.size(), 0);

            orderedset.add(1);
            collection = orderedset.reject(i => i > 5);
            Assert.AreEqual(collection.size(), 1);

            orderedset.add(6);
            collection = orderedset.reject(i => i > 5);
            Assert.AreEqual(collection.size(), 1);

            orderedset.add(2);
            collection = orderedset.reject(i => i > 5);
            Assert.AreEqual(collection.size(), 2);

        }

        [TestMethod]
        public void minus()
        {
            var orderedset1 = new OrderedSet<int>();
            var orderedset2 = new OrderedSet<int>();

            var diff = orderedset1.minus(orderedset2);
            Assert.AreEqual(diff.size(), 0);

            orderedset1.add(1);
            orderedset1.add(2);

            orderedset2.add(1);
            orderedset2.add(3);

            diff = orderedset1.minus(orderedset2);

            Assert.AreEqual(diff.at(0), 2);

        }

        [TestMethod]
        public void including()
        {
            var orderedset = new OrderedSet<int>();

            Assert.AreEqual(orderedset.size(),0);
            var orderedset2 = orderedset.including(1) as OrderedSet<int>;

            Assert.AreEqual(orderedset.size(),0);
            Assert.AreEqual(orderedset2.at(0), 1);

            orderedset2 = orderedset2.including(2) as OrderedSet<int>;

            Assert.AreEqual(orderedset.size(), 0);
            Assert.AreEqual(orderedset2.size(), 2);
            Assert.AreEqual(orderedset2.at(0), 1);
            Assert.AreEqual(orderedset2.at(1), 2);
        }

        [TestMethod]
        public void excluding()
        {
            var orderedset = new OrderedSet<int>();

            
            var orderedset2 = orderedset.excluding(1) as OrderedSet<int>;
            Assert.AreEqual(orderedset.size(), 0);
            Assert.AreEqual(orderedset2.size(), 0);

            orderedset.add(1);
            orderedset.add(2);

            orderedset2 = orderedset.excluding(1) as OrderedSet<int>;

            Assert.AreEqual(orderedset.size(), 2);
            Assert.AreEqual(orderedset2.at(0), 2);
            
        }

        [TestMethod]
        public void isUnique()
        {
            var orderedset = new OrderedSet<int>();
            orderedset.add(1);
            orderedset.add(2);
            orderedset.add(3);

            Assert.AreEqual(orderedset.isUnique(i=>i), true);

            Assert.AreEqual(orderedset.isUnique(i => i>1), false);

            var x = new Sequence<object>() { new Set<int> { 1, 2, 3 }, new Sequence<double> { 2.2, 3.0 }, new Bag<string> { "test" } }.flatten<object>();

            var y = new Sequence<Sequence<int>>() { new Sequence<int> { 1, 2 }, new Sequence<int> { 4, 6 } }.flatten<int>();

            var z = 3;

        }

        [TestMethod]
        public void flatten()
        {
            var orderedset = new OrderedSet<OrderedSet<int>>();
            var result = orderedset.flatten<int>();

            Assert.AreEqual(result.size(), 0);

            orderedset.add(new OrderedSet<int> { 1, 2});
            result = orderedset.flatten<int>();
            Assert.AreEqual(orderedset.size(), 1);
            Assert.AreEqual(result.size(), 2);

            orderedset.add(new OrderedSet<int> { 3, 4 });
            result = orderedset.flatten<int>();
            Assert.AreEqual(orderedset.size(), 2);
            Assert.AreEqual(result.size(), 4);

            //orderedset.add(new OrderedSet<int> { 1, 2 });
            //Assert.AreEqual(orderedset.size(), 2);//addUnique should not add {1,2}, because it is already there
            //Assert.AreEqual(result.size(), 4);



        }
    }
}
