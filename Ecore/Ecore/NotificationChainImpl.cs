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
using System.Threading.Tasks;

namespace Ecore
{
    public class NotificationChainImpl : List<Notification>, NotificationChain
    {
        public bool add(Notification notification)
        {
            Add(notification);

            return Contains(notification);
        }

        public void dispatch()
        {

            foreach (Notification notification in this)
            {
                dispatch(notification);
            }



        }

        protected void dispatch(Notification notification)
        {
            object notifier = notification.getNotifier();
            if (notifier != null && notification.getEventType() != -1)
            {
                ((Notifier)notifier).eNotify(notification);
            }
        }
    }
}
