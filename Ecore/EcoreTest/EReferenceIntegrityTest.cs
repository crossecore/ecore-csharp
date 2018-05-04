/* CrossEcore is a cross-platform modeling framework that generates C#, TypeScript, 
 * JavaScript, Swift code from Ecore models with embedded OCL (http://www.crossecore.org/).
 * The original Eclipse Modeling Framework is available at https://www.eclipse.org/modeling/emf/.
 * 
 * contributor: Simon Schwichtenberg
 */

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Testmodel;
using Ecore;

namespace EcoreTest
{
    [TestClass]
    public class EReferenceIntegrityTest
    {

        
        [TestMethod]
        public void Test_zero_One_No_no()
        {
            var source = TestmodelFactoryImpl.eINSTANCE.createSource();
            var target = TestmodelFactoryImpl.eINSTANCE.createTarget();

            source.zero_one_no_no = target;

            Assert.IsNotNull(source.zero_one_no_no);
            Assert.AreEqual(source.zero_one_no_no, target);
        }

        [TestMethod]
        public void Test_zero_Many_No_no()
        {
            var source = TestmodelFactoryImpl.eINSTANCE.createSource();
            var target = TestmodelFactoryImpl.eINSTANCE.createTarget();

            source.zero_many_no_no.add(target);

            Assert.IsNotNull(source.zero_many_no_no);
            Assert.IsTrue(source.zero_many_no_no.size()==1);
            Assert.AreEqual(source.zero_many_no_no.any((x)=>true), target);
        }

        [TestMethod]
        public void Test_zero_one_no_yes()
        {
            var source = TestmodelFactoryImpl.eINSTANCE.createSource();
            var target = TestmodelFactoryImpl.eINSTANCE.createTarget();

            source.zero_one_no_yes = target;


            Assert.IsNotNull(source.zero_one_no_yes);
            Assert.IsNotNull(target.eContainer());
            Assert.AreEqual(source.zero_one_no_yes, target);
            Assert.AreEqual(source, target.eContainer());
        }

        [TestMethod]
        public void Test_zero_many_no_yes()
        {
            var source = TestmodelFactoryImpl.eINSTANCE.createSource();
            var target = TestmodelFactoryImpl.eINSTANCE.createTarget();

            source.zero_many_no_yes.add(target);

            Assert.IsNotNull(source.zero_many_no_yes, "Reference list could not be created.");
            Assert.IsTrue(source.zero_many_no_yes.size()==1 , "Element could not be added to reference list.");
            Assert.IsNotNull(target.eContainer(), "EContainer could not be set at added element.");

            Assert.AreEqual(source.zero_many_no_yes.any((a)=>true), target);
            Assert.AreEqual(source, target.eContainer());
        }

        [TestMethod]
        public void Test_one_one_no_no_forth()
        {
            var source = TestmodelFactoryImpl.eINSTANCE.createSource();
            var target = TestmodelFactoryImpl.eINSTANCE.createTarget();

            source.one_one_no_no = target;
            
            Assert.IsNotNull(source.one_one_no_no);
            Assert.IsNotNull(target.one_one_no_no);
            
        }
        [TestMethod]
        public void Test_one_many_no_no_forth()
        {
            var source = TestmodelFactoryImpl.eINSTANCE.createSource();
            var target = TestmodelFactoryImpl.eINSTANCE.createTarget();

            source.one_many_no_no.add(target);

            Assert.IsNotNull(source.one_many_no_no);
            Assert.IsNotNull(target.one_many_no_no);
            Assert.IsTrue(source.one_many_no_no.size()==1);

        }



        [TestMethod]
        public void Test_one_many_no_no_back()
        {
            var source = TestmodelFactoryImpl.eINSTANCE.createSource();
            var target = TestmodelFactoryImpl.eINSTANCE.createTarget();

            target.one_many_no_no = source;

            Assert.IsNotNull(source.one_many_no_no);
            Assert.IsNotNull(target.one_many_no_no);
            Assert.IsTrue(source.one_many_no_no.size() == 1);

        }

        [TestMethod]
        public void Test_many_many_no_no_forth()
        {
            var source = TestmodelFactoryImpl.eINSTANCE.createSource();
            var target = TestmodelFactoryImpl.eINSTANCE.createTarget();

            source.many_many_no_no.add(target);

            Assert.IsNotNull(source.many_many_no_no);
            Assert.IsNotNull(target.many_many_no_no);
            Assert.IsTrue(source.many_many_no_no.size() == 1);
            Assert.IsTrue(target.many_many_no_no.size() == 1);

        }

        [TestMethod]
        public void Test_many_many_no_no_back()
        {
            var source = TestmodelFactoryImpl.eINSTANCE.createSource();
            var target = TestmodelFactoryImpl.eINSTANCE.createTarget();

            target.many_many_no_no.add(source);

            Assert.IsNotNull(source.many_many_no_no);
            Assert.IsNotNull(target.many_many_no_no);
            Assert.IsTrue(source.many_many_no_no.size() == 1);
            Assert.IsTrue(target.many_many_no_no.size() == 1);

        }

        [TestMethod]
        public void Test_one_many_no_yes_forth()
        {
            var source = TestmodelFactoryImpl.eINSTANCE.createSource();
            var target = TestmodelFactoryImpl.eINSTANCE.createTarget();

            source.one_many_no_yes.add(target);

            Assert.IsNotNull(source.one_many_no_yes);
            Assert.IsNotNull(target.one_many_no_yes);
            Assert.IsTrue(source.one_many_no_yes.size() == 1);
            Assert.IsNotNull(target.eContainer());


        }


        [TestMethod]
        public void Test_one_many_no_yes_back()
        {
            var source = TestmodelFactoryImpl.eINSTANCE.createSource();
            var target = TestmodelFactoryImpl.eINSTANCE.createTarget();

            target.one_many_no_yes = source;

            Assert.IsNotNull(source.one_many_no_yes);
            Assert.IsNotNull(target.one_many_no_yes);
            Assert.IsTrue(source.one_many_no_yes.size() == 1);
            Assert.IsNotNull(target.eContainer());


        }

        [TestMethod]
        public void Test_one_one_no_yes_forth()
        {
            var source = TestmodelFactoryImpl.eINSTANCE.createSource();
            var target = TestmodelFactoryImpl.eINSTANCE.createTarget();

            source.one_one_no_yes = target;

            Assert.IsNotNull(source.one_one_no_yes);
            Assert.IsNotNull(target.one_one_no_yes);
            Assert.IsNotNull(target.eContainer());


        }

        [TestMethod]
        public void Test_one_one_no_yes_back()
        {
            var source = TestmodelFactoryImpl.eINSTANCE.createSource();
            var target = TestmodelFactoryImpl.eINSTANCE.createTarget();

            target.one_one_no_yes = source;

            Assert.IsNotNull(source.one_one_no_yes);
            Assert.IsNotNull(target.one_one_no_yes);
            Assert.IsNotNull(target.eContainer());
        }


        [TestMethod]
        public void Test_remove_zero_One_No_no()
        {
            var source = TestmodelFactoryImpl.eINSTANCE.createSource();
            var target = TestmodelFactoryImpl.eINSTANCE.createTarget();

            source.zero_one_no_no = target;
            source.zero_one_no_no = null;
            
            Assert.IsNull(source.zero_one_no_no);
        }

        [TestMethod]
        public void Test_remove_zero_Many_No_no()
        {
            var source = TestmodelFactoryImpl.eINSTANCE.createSource();
            var target = TestmodelFactoryImpl.eINSTANCE.createTarget();

            source.zero_many_no_no.add(target);

            source.zero_many_no_no.remove(target);


            
            Assert.IsTrue(source.zero_many_no_no.size() == 0);
        }

        [TestMethod]
        public void Test_remove_zero_one_no_yes()
        {
            var source = TestmodelFactoryImpl.eINSTANCE.createSource();
            var target = TestmodelFactoryImpl.eINSTANCE.createTarget();

            source.zero_one_no_yes = target;
            source.zero_one_no_yes = null;


            Assert.IsNull(source.zero_one_no_yes);
            Assert.IsNull(target.eContainer());
        }

        [TestMethod]
        public void Test_remove_zero_many_no_yes()
        {
            var source = TestmodelFactoryImpl.eINSTANCE.createSource();
            var target = TestmodelFactoryImpl.eINSTANCE.createTarget();

            source.zero_many_no_yes.add(target);
            source.zero_many_no_yes.remove(target);

            
            Assert.IsTrue(source.zero_many_no_yes.size() == 0);
            Assert.IsNull(target.eContainer());
        }

        [TestMethod]
        public void Test_remove_one_one_no_no_forth()
        {
            var source = TestmodelFactoryImpl.eINSTANCE.createSource();
            var target = TestmodelFactoryImpl.eINSTANCE.createTarget();

            source.one_one_no_no = target;
            source.one_one_no_no = null;

            Assert.IsNull(source.one_one_no_no);
            Assert.IsNull(target.one_one_no_no);

        }
        [TestMethod]
        public void Test_remove_one_many_no_no_forth()
        {
            var source = TestmodelFactoryImpl.eINSTANCE.createSource();
            var target = TestmodelFactoryImpl.eINSTANCE.createTarget();

            source.one_many_no_no.add(target);
            source.one_many_no_no.remove(target);

            
            Assert.IsNull(target.one_many_no_no);
            Assert.IsTrue(source.one_many_no_no.size() == 0);

        }



        [TestMethod]
        public void Test_remove_one_many_no_no_back()
        {
            var source = TestmodelFactoryImpl.eINSTANCE.createSource();
            var target = TestmodelFactoryImpl.eINSTANCE.createTarget();

            target.one_many_no_no = source;
            target.one_many_no_no = null;

            
            Assert.IsNull(target.one_many_no_no);
            Assert.IsTrue(source.one_many_no_no.size() == 0);

        }

        [TestMethod]
        public void Test_remove_many_many_no_no_forth()
        {
            var source = TestmodelFactoryImpl.eINSTANCE.createSource();
            var target = TestmodelFactoryImpl.eINSTANCE.createTarget();

            source.many_many_no_no.add(target);

            source.many_many_no_no.remove(target);

            
            Assert.IsTrue(source.many_many_no_no.size() == 0);
            Assert.IsTrue(target.many_many_no_no.size() == 0);

        }

        [TestMethod]
        public void Test_remove_many_many_no_no_back()
        {
            var source = TestmodelFactoryImpl.eINSTANCE.createSource();
            var target = TestmodelFactoryImpl.eINSTANCE.createTarget();

            target.many_many_no_no.add(source);
            target.many_many_no_no.remove(source);

            
            Assert.IsTrue(source.many_many_no_no.size() == 0);
            Assert.IsTrue(target.many_many_no_no.size() == 0);

        }

        [TestMethod]
        public void Test_remove_one_many_no_yes_forth()
        {
            var source = TestmodelFactoryImpl.eINSTANCE.createSource();
            var target = TestmodelFactoryImpl.eINSTANCE.createTarget();

            source.one_many_no_yes.add(target);

            source.one_many_no_yes.remove(target);

            
            Assert.IsNull(target.one_many_no_yes);
            Assert.IsTrue(source.one_many_no_yes.size() == 0);
            Assert.IsNull(target.eContainer());


        }


        [TestMethod]
        public void Test_remove_one_many_no_yes_back()
        {
            var source = TestmodelFactoryImpl.eINSTANCE.createSource();
            var target = TestmodelFactoryImpl.eINSTANCE.createTarget();

            target.one_many_no_yes = source;
            target.one_many_no_yes = null;

            
            Assert.IsNull(target.one_many_no_yes);
            //Assert.IsTrue(source.one_many_no_yes.size() == 0);
            //Assert.IsNull(target.eContainer());


        }

        [TestMethod]
        public void Test_remove_one_one_no_yes_forth()
        {
            var source = TestmodelFactoryImpl.eINSTANCE.createSource();
            var target = TestmodelFactoryImpl.eINSTANCE.createTarget();

            source.one_one_no_yes = target;
            source.one_one_no_yes = null;

            Assert.IsNull(source.one_one_no_yes);
            Assert.IsNull(target.one_one_no_yes);
            Assert.IsNull(target.eContainer());


        }

        [TestMethod]
        public void Test_remove_one_one_no_yes_back()
        {
            var source = TestmodelFactoryImpl.eINSTANCE.createSource();
            var target = TestmodelFactoryImpl.eINSTANCE.createTarget();

            target.one_one_no_yes = source;
            target.one_one_no_yes = null;

            Assert.IsNull(source.one_one_no_yes);
            Assert.IsNull(target.one_one_no_yes);
            Assert.IsNull(target.eContainer());
        }




    }
}
