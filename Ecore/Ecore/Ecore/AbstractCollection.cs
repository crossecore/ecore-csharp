/* CrossEcore is a cross-platform modeling framework that generates C#, TypeScript, 
 * JavaScript, Swift code from Ecore models with embedded OCL (http://www.crossecore.org/).
 * The original Eclipse Modeling Framework is available at https://www.eclipse.org/modeling/emf/.
 * 
 * contributor: Simon Schwichtenberg
 */

using Ecore;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Collections;

namespace oclstdlib
{
    public abstract class AbstractCollection<T>: List<T>, EcoreEList<T>, Collection<T>
    {
        
        protected const int NO_FEATURE = Int32.MinValue;

        private InternalEObject owner;
        private int featureId = NO_FEATURE;
        private int oppositeFeatureId = NO_FEATURE;

        //protected ICollection<T> internalCollection;


        public AbstractCollection(IEnumerable<T> enumerable) : base(enumerable)
        {

        }

        public AbstractCollection() : this(null, NO_FEATURE)
        {
            
        }

        public AbstractCollection(InternalEObject owner, int featureId):this(owner, featureId, NO_FEATURE)
        {

            

        }

        public AbstractCollection(InternalEObject owner, int featureId, int oppositeFeatureId)
        {
            
            this.owner = owner;
            this.featureId = featureId;
            this.oppositeFeatureId = oppositeFeatureId;

        }

        /// <summary>
        /// Not to confuse with OCL's isUnique<T2>(Func<T, T2> lambda) Function.
        /// </summary>
        /// <returns></returns>
        protected abstract bool isUnique();


        //Base functions START
        /*
        public new void Add(T element)
        {
            add(element);
        }
        */
        public virtual bool add(T element)
        {

            if (isUnique() && this.Contains(element))
            {
                return false;
            }
            else
            {
                addUnique(element);
                return true;
            }
                        
            
        }

        public bool remove(T item)
        {
            
            if (this.Contains(item))
            {
                remove_(item);
                return true;
            }
            else
            {
                return false;
            }
        }

        public T remove_(T element)
        {
            if (isNotificationRequired())
            {
                NotificationChain notifications = null;
                //bool oldIsSet = isSet();
                bool oldIsSet = this.Count != 0;
                /*
                if (hasShadow())
                {
                    notifications = shadowRemove(basicGet(index), null);
                }
                */
                this.Remove(element);
                T oldObject = element;
                //TODO determine index if possible
                var index = 1000;
                //NotificationImpl notification = createNotification(NotificationImpl.REMOVE, oldObject, null, index, oldIsSet);
                NotificationImpl notification = new NotificationImpl(NotificationImpl.REMOVE, oldObject, null, index, oldIsSet);
                if (hasInverse() && oldObject != null)
                {
                    notifications = inverseRemove(oldObject, notifications);
                    if (notifications == null)
                    {
                        dispatchNotification(notification);
                    }
                    else
                    {
                        notifications.add(notification);
                        notifications.dispatch();
                    }
                }
                else
                {
                    if (notifications == null)
                    {
                        dispatchNotification(notification);
                    }
                    else
                    {
                        notifications.add(notification);
                        notifications.dispatch();
                    }
                }
                return oldObject;
            }
            else
            {
                this.Remove(element);
                T oldObject = element;
                if (hasInverse() && oldObject != null)
                {
                    NotificationChain notifications = inverseRemove(oldObject, null);
                    if (notifications != null) notifications.dispatch();
                }
                return oldObject;
            }
        }
        //Base functions END

        //EcoreEList START

        public bool isNotificationRequired()
        {
            if (owner!=null)
            {
                return owner.eNotificationRequired();
            }
            return false;
            
        }


        /*
        public NotificationChain basicAdd(T element, NotificationChain msgs)
        {
            this.Add(element);

            if (element is InternalEObject && owner != null)
            {
                var oclelement = element as InternalEObject;
                oclelement.eBasicSetContainer(owner, -1, null);
            }

            return msgs;
        }
        */

        public NotificationChain basicAdd(T element, NotificationChain notifications)
        {
            if (isNotificationRequired())
            {
                int index = Count;
                bool oldIsSet = this.notEmpty();
                //doAddUnique(index, object);
                this.Add(element);
                NotificationImpl notification = new NotificationImpl(NotificationImpl.ADD, null, element, index, oldIsSet); //createNotification(Notification.ADD, null, object, index, oldIsSet);
                if (notifications == null)
                {
                    notifications = notification;
                }
                else
                {
                    notifications.add(notification);
                }
            }
            else
            {
                //doAddUnique(size, object);
                this.Add(element);

            }
            return notifications;
        }

        public NotificationChain basicRemove(T element, NotificationChain notifications)
        {
            //int index = indexOf(object);
            //if (index != -1)
            if(this.Contains(element))
            {
                if (isNotificationRequired())
                {
                    //bool oldIsSet = isSet();
                    bool oldIsSet = this.Count != 0;
                    //Object oldObject = doRemove(index);
                    var oldObject = element;
                    //TODO fix me:
                    var index = 1000;
                    this.Remove(element);
                    //NotificationImpl notification = createNotification(Notification.REMOVE, oldObject, null, index, oldIsSet);
                    NotificationImpl notification = new NotificationImpl(NotificationImpl.REMOVE, oldObject, null, index, oldIsSet);
                    if (notifications == null)
                    {
                        notifications = notification;
                    }
                    else
                    {
                        notifications.add(notification);
                    }
                }
                else
                {
                    //doRemove(index);
                    this.Remove(element);
                }
            }
            return notifications;
        }

        public NotificationChain inverseAdd(T element, NotificationChain notifications)
        {
            InternalEObject internalEObject = (InternalEObject)element;
            if (hasNavigableInverse())
            {
                if (!hasInstanceClass())
                {
                    return
                      internalEObject.eInverseAdd
                        (owner,
                         internalEObject.eClass().getFeatureID(getInverseEReference()),
                         null,
                         notifications);
                }
                else
                {
                    return
                      internalEObject.eInverseAdd
                        (owner,
                         this.oppositeFeatureId,
                         getInverseFeatureClass(),
                         notifications);
                }
            }
            else
            {
                return
                  internalEObject.eInverseAdd
                    (owner,
                     BasicEObjectImpl.EOPPOSITE_FEATURE_BASE - featureId,
                     null,
                     notifications);
            }

        }



        public NotificationChain inverseRemove(T element, NotificationChain notifications)
        {
            InternalEObject internalEObject = (InternalEObject)element;
            if (hasNavigableInverse())
            {
                if (!hasInstanceClass())
                {
                    return
                      internalEObject.eInverseRemove
                        (owner,
                         internalEObject.eClass().getFeatureID(getInverseEReference()),
                         null,
                         notifications);
                }
                else
                {
                    return
                      internalEObject.eInverseRemove
                        (owner,
                         this.oppositeFeatureId,
                         getInverseFeatureClass(),
                         notifications);
                }
            }
            else
            {
                return
                  internalEObject.eInverseRemove
                    (owner,
                     BasicEObjectImpl.EOPPOSITE_FEATURE_BASE - featureId,
                     null,
                     notifications);
            }
        }

        public bool hasNavigableInverse()
        {
            return oppositeFeatureId >= 0;
        }

        public bool hasInstanceClass()
        {
            //from EcoreEList, needed for generics
            return true;
        }

        public bool hasInverse()
        {

            return oppositeFeatureId != NO_FEATURE;




            /*
            try
            {
                //non-navigable inverse is the containment feature
                var eclass = _owner.eClass();
                var estructuralfeatures = eclass.eStructuralFeatures;

                var ereference = _owner.eClass().getEStructuralFeature(_featureId) as EReference;
                
                return ereference.eOpposite.containment;
            }
            catch (NullReferenceException e)
            {
                return false;
            }
            */


        }

        public EStructuralFeature getEStructuralFeature()
        {
            //from EcoreEList
            //return owner.eClass().getEStructuralFeature(getFeatureID());
            return owner.eClass().getEStructuralFeature(featureId);
        }

        public EReference getInverseEReference()
        {
            //from EcoreEList
            //return ((EReference)getEStructuralFeature()).getEOpposite();
            return ((EReference)getEStructuralFeature()).eOpposite;
        }

        public Type getInverseFeatureClass()
        {
            //from EcoreEList
            //return ((EClass)getEStructuralFeature().getEType()).getInstanceClass();

            //TODO fix
            //return ((EClass)getEStructuralFeature().eType).instanceClass;
            return null;
        }

        public void dispatchNotification(Notification notification)
        {
            //from EcoreElist
            owner.eNotify(notification);
        }

        public void addUnique(T element)
        {
            if (isNotificationRequired())
            {
                //int index = size;
                int index = size()-1;

                //boolean oldIsSet = isSet();
                bool oldIsSet = this.notEmpty();

                //doAddUnique(object);
                this.Add(element);
                //NotificationImpl notification = createNotification(NotificationImpl.ADD, null, element, index, oldIsSet);

                NotificationImpl notification = new NotificationImpl(NotificationImpl.ADD, null, element, index, oldIsSet);

                if (hasInverse())
                {
                    NotificationChain notifications = inverseAdd(element, null);
                    /*
                    if (hasShadow())
                    {
                        notifications = shadowAdd(object, notifications);
                    }
                    */

                    if (notifications == null)
                    {
                        dispatchNotification(notification);
                    }
                    else
                    {
                        notifications.add(notification);
                        notifications.dispatch();
                    }
                }
                else
                {
                    dispatchNotification(notification);
                }
            }
            else
            {
                //doAddUnique(object);
                this.Add(element);

                if (hasInverse())
                {
                    NotificationChain notifications = inverseAdd(element, null);
                    if (notifications != null)
                    {
                        notifications.dispatch();
                    }
                }
            }
        }

        //EcoreEList END


        //OCL START
        public Collection<T> sortedBy<T2>(Func<T, T2> lambda)
        {
            throw new NotImplementedException();
        }



        
        public bool equals(Collection<T> c)
        {
            return this.Equals(c);
        }
        public bool notEquals(Collection<T> c)
        {
            return !this.Equals(c);
        }
        public int size()
        {
            return this.Count;
        }
        public bool includes(T element
        )
        {
            return this.Contains(element);
        }
        public bool excludes(T element
        )
        {
            return !this.Contains(element);
        }
        public int count(T element
        )
        {
            return this.Contains(element) ? 1 : 0;

        }
        public bool includesAll(Collection<T> c2)
        {
            //this._hashset.Intersect(c2).Equals(this._hashset);

            foreach (T element in c2)
            {
                if (!this.Contains(element))
                {
                    return false;
                }
            }

            return true;
        }

        public bool excludesAll(Collection<T> c2)
        {
            foreach (T element in c2)
            {
                if (this.Contains(element))
                {
                    return false;
                }
            }

            return true;
        }
        public bool isEmpty()
        {
            return this.Count == 0;
        }
        public bool notEmpty()
        {
            return this.Count > 0;
        }
        public T max()
        {
            throw new NotImplementedException();
        }
        public T min()
        {
            throw new NotImplementedException();
        }
        public double sum()
        {
            var result = 0d;
            foreach (T element in this)
            {

                var d = Convert.ToDouble(element);
                result = result + d;

            }

            return result;
        }
        public virtual Set<T> asSet()
        {
            var set = new Set<T>();

            foreach (T element in this)
            {
                set.add(element);
            }
            return set;
        }
        public virtual OrderedSet<T> asOrderedSet()
        {
            var set = new OrderedSet<T>();

            foreach (T element in this)
            {
                set.add(element);
            }
            return set;
        }
        public virtual Sequence<T> asSequence()
        {
            var set = new Sequence<T>();

            foreach (T element in this)
            {
                set.add(element);
            }
            return set;
        }
        public virtual Bag<T> asBag()
        {
            var set = new Bag<T>();

            foreach (T element in this)
            {
                set.add(element);
            }
            return set;
        }


        public T any(Func<T, Boolean> lambda
        )
        {

            //return this._hashset.Any(s=>true);

            foreach (T element in this)
            {
                if (lambda(element))
                {
                    return element;
                }
            }
            //TODO return Invalid
            return default(T);


        }

        public Collection<T2> closure<T2>(Func<T, T2> lambda)
        {
            throw new NotImplementedException();
        }



        

        public bool exists(Func<T, bool> lambda)
        {
            foreach (T element in this)
            {
                if (lambda(element))
                {
                    return true;
                }
            }
            return false;
        }

        public bool forAll(Func<T, bool> lambda)
        {
            return this.All(lambda);
        }

        public bool isUnique<T2>(Func<T, T2> lambda)
        {
            return this.size() == new Set<T>(this).collect(lambda).size();
        }


        public bool one(Func<T, bool> lambda)
        {
            return this.Where(lambda).Count() == 1;
        }

 

    }
}
