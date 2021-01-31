/* CrossEcore is a cross-platform modeling framework that generates C#, TypeScript, 
 * JavaScript, Swift code from Ecore models with embedded OCL (http://www.crossecore.org/).
 * The original Eclipse Modeling Framework is available at https://www.eclipse.org/modeling/emf/.
 * 
 * contributor: Simon Schwichtenberg
 */


using System;
using System.Collections.Generic;

namespace Ecore
{

    public class BasicNotifierImpl : Notifier
    {

        private ICollection<Adapter> _eAdapters;
        //public EList<Adapter> eAdapters()
        public virtual ICollection<Adapter> eAdapters()
        {

            if (_eAdapters == default(ICollection<Adapter>))
            {
                _eAdapters = new HashSet<Adapter>();
            }
            return _eAdapters;
        }

        //protected BasicEList<Adapter> eBasicAdapters()
        protected virtual ICollection<Adapter> eBasicAdapters()
        {
            return null;
        }

        public virtual void eNotify(Notification notification)
        {
            foreach (Adapter adapter in eAdapters())
            {
                adapter.notifyChanged(notification);
            }
        }

        public bool eNotificationRequired()
        {
            return eAdapters().Count > 0;
        }
    }
}
