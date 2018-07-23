/* CrossEcore is a cross-platform modeling framework that generates C#, TypeScript, 
* JavaScript, Swift code from Ecore models with embedded OCL (http://www.crossecore.org/).
* The original Eclipse Modeling Framework is available at https://www.eclipse.org/modeling/emf/.
* 
* contributor: Simon Schwichtenberg
*/
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ecore.Xmi;
using Ecore;
using System.Diagnostics;


namespace EcoreTest
{
    [TestClass]
    public class XmiTest
    {


        [TestMethod]
        public void Load()
        {
            EcorePackageImpl.init();

            //TODO: https://msdn.microsoft.com/de-de/library/ms182475.aspx
            var resource = new XmiResource();

            

            var epackage = resource.Load("C:/Users/Simon/Data/git2/crossecore/model/Ecore.ecore") as EPackage;

            

            foreach (EClassifier c in epackage.eClassifiers)
            {
                Debug.WriteLine(c.name);
            }

            resource.Save("");

            Assert.IsNotNull(epackage);

        }
    }
}
