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
    public class ENotificationImpl : NotificationImpl
    {

        protected InternalEObject notifier;
        protected int featureID = NO_FEATURE_ID;
        protected EStructuralFeature feature;

        public ENotificationImpl(InternalEObject notifier, int eventType, int featureID, Object oldValue, Object newValue) : this(notifier, eventType, featureID, oldValue, newValue, NO_INDEX)
        {

        }

        public ENotificationImpl(InternalEObject notifier, int eventType, int featureID, Object oldValue, Object newValue, int position) : base(eventType, oldValue, newValue, position)
        {

            this.notifier = notifier;
            this.featureID = featureID;
        }

        public Object getFeature()
        {
            if (feature == null && featureID != NO_FEATURE_ID)
            {
                EClass eClass = notifier.eClass();
                feature = eClass.getEStructuralFeature(featureID);
            }
            return feature;
        }
    }



}
