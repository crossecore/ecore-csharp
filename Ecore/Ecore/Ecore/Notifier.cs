/* CrossEcore is a cross-platform modeling framework that generates C#, TypeScript, 
 * JavaScript, Swift code from Ecore models with embedded OCL (http://www.crossecore.org/).
 * The original Eclipse Modeling Framework is available at https://www.eclipse.org/modeling/emf/.
 * 
 * contributor: Simon Schwichtenberg
 */
using System.Collections.Generic;


namespace Ecore
{
    public interface Notifier
    {



        //EList<Adapter> eAdapters();
        ICollection<Adapter> eAdapters();

        //EList<Adapter> eAdapters();

        //boolean eDeliver();

        //void eSetDeliver(boolean deliver);

        void eNotify(Notification notification);
        
    }
}
