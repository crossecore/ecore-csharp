/* CrossEcore is a cross-platform modeling framework that generates C#, TypeScript, 
 * JavaScript, Swift code from Ecore models with embedded OCL (http://www.crossecore.org/).
 * The original Eclipse Modeling Framework is available at https://www.eclipse.org/modeling/emf/.
 * 
 * contributor: Simon Schwichtenberg
 */

using System;

namespace Ecore
{
    public class NotificationImpl:NotificationChain, Notification
    {

        public const int SET = 1;
        public const int UNSET = 2;
        public const int ADD = 2;
        public const int REMOVE = 3;

        public const int ADD_MANY = 5;
        public const int REMOVE_MANY = 6;
        public const int MOVE = 7;

        public const int NO_INDEX = -1;
        public const int IS_SET_CHANGE_INDEX = NO_INDEX - 1;

        public const int NO_FEATURE_ID = -1;

        public const int PRIMITIVE_TYPE_OBJECT = -1;

        protected NotificationChain next;

        protected int eventType;
        protected object oldValue;
        protected object newValue;
        protected int position;
        protected int primitiveType;

        /*
        public NotificationImpl(int eventType, object oldValue, object newValue): this(eventType, oldValue, newValue, NO_INDEX)
        {
            
        }

        public NotificationImpl(int eventType, object oldValue, object newValue, bool isSetChange): this(eventType, oldValue, newValue, isSetChange ? IS_SET_CHANGE_INDEX : NO_INDEX)
        {
            
        }
        */

        public NotificationImpl(int eventType, object oldValue, object newValue, int position, bool wasSet)
        {
            this.eventType = eventType;
            this.oldValue = oldValue;
            this.newValue = newValue;
            this.position = position;
            this.primitiveType = PRIMITIVE_TYPE_OBJECT;
            if (!wasSet)
            {
                this.position = IS_SET_CHANGE_INDEX - position - 1;
            }
        }

        public NotificationImpl(int eventType, object oldValue, object newValue, int position)
        {
            
            this.eventType = eventType;
            this.oldValue = oldValue;
            this.newValue = newValue;
            this.position = position;
            this.primitiveType = PRIMITIVE_TYPE_OBJECT;
            
        }

        public virtual bool add(Notification notification)
        {
            return next.add(notification);
        }

        public virtual void dispatch()
        {
            
            object notifier = getNotifier();
            if (notifier != null && getEventType() != -1)
            {
                ((Notifier)notifier).eNotify(this);
            }

            if (next != null)
            {
                next.dispatch();
            }

            
        }

        public virtual object getNotifier()
        {
            return null;

        }

        
        public virtual int getEventType()
        {
            return eventType;
        }

        public virtual object getNewValue()
        {
            return newValue;
        }
    }
}
