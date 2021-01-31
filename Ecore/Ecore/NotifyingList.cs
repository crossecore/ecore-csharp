/* CrossEcore is a cross-platform modeling framework that generates C#, TypeScript, 
 * JavaScript, Swift code from Ecore models with embedded OCL (http://www.crossecore.org/).
 * The original Eclipse Modeling Framework is available at https://www.eclipse.org/modeling/emf/.
 * 
 * contributor: Simon Schwichtenberg
 */


namespace Ecore
{
    public interface NotifyingList<T>
    {
        bool isNotificationRequired();
        bool hasInverse();
        void dispatchNotification(Notification notification);
        NotificationChain basicAdd(T item, NotificationChain notifications);
        NotificationChain basicRemove(T item, NotificationChain notifications);
        NotificationChain inverseAdd(T item, NotificationChain notifications);
        NotificationChain inverseRemove(T item, NotificationChain notifications);

    }
}
