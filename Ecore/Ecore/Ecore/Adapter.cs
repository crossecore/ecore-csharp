/* CrossEcore is a cross-platform modeling framework that generates C#, TypeScript, 
 * JavaScript, Swift code from Ecore models with embedded OCL (http://www.crossecore.org/).
 * The original Eclipse Modeling Framework is available at https://www.eclipse.org/modeling/emf/.
 * 
 * contributor: Simon Schwichtenberg
 */

using System;

namespace Ecore
{
    public interface Adapter
    {
        void notifyChanged(Notification notification);
        //Notifier getTarget();
        //void setTarget(Notifier newTarget);
        //bool isAdapterForType(object type);
    }
}
