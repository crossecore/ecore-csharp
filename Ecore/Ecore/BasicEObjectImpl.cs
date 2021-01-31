/* CrossEcore is a cross-platform modeling framework that generates C#, TypeScript, 
 * JavaScript, Swift code from Ecore models with embedded OCL (http://www.crossecore.org/).
 * The original Eclipse Modeling Framework is available at https://www.eclipse.org/modeling/emf/.
 * 
 * contributor: Simon Schwichtenberg
 */

using oclstdlib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecore
{
    public class BasicEObjectImpl : BasicNotifierImpl, EObject, InternalEObject
    {


        public const int EOPPOSITE_FEATURE_BASE = -1;




        // Subclasses MUST override this function
        protected virtual EClass eStaticClass()
        {
            return EcorePackageImpl.eINSTANCE.getEObject();
        }

        public EClass eClass()
        {
            return eStaticClass();
        }

        public bool eIsProxy()
        {
            throw new NotImplementedException();
        }

        public Resource eResource()
        {
            throw new NotImplementedException();
        }

        public InternalEObject eInternalContainer()
        {

            return _eContainer;
        }

        protected void eBasicSetContainer(InternalEObject newContainer, int newContainerFeatureID)
        {

            _eContainer = newContainer;
            _eContainerFeatureID = newContainerFeatureID;
        }

        protected InternalEObject _eContainer = null;
        protected int _eContainerFeatureID = -1;

        public EObject eContainer()
        {

            InternalEObject result = eInternalContainer();
            /*
            if (result != null)
            {
                if (result.eIsProxy())
                {
                    EObject resolved = eResolveProxy(result);
                    if (resolved != result)
                    {
                        int eContainerFeatureID = eContainerFeatureID();
                        NotificationChain notificationChain = eBasicRemoveFromContainer(null);
                        eBasicSetContainer((InternalEObject)resolved, eContainerFeatureID);
                        if (notificationChain != null)
                        {
                            notificationChain.dispatch();
                        }
                        if (eNotificationRequired() && eContainerFeatureID > EOPPOSITE_FEATURE_BASE)
                        {
                            eNotify(new ENotificationImpl(this, Notification.RESOLVE, eContainerFeatureID, result, resolved));
                        }
                        return resolved;
                    }
                }
            }
            */

            return result;


            //return this._eContainer;
        }

        public EStructuralFeature eContainingFeature()
        {
            throw new NotImplementedException();
        }

        public EReference eContainmentFeature()
        {
            throw new NotImplementedException();
        }

        public List<EObject> eContents()
        {

            var result = new List<EObject>();

            var eclass = eClass();
            var x = eclass.eAllContainments;

            foreach (EReference f in eClass().eAllContainments)
            {
                if (f.many)
                {

                    var d = this.eGet(f) as IEnumerable;
                    var list = d.OfType<EObject>();

                    //TODO remove oclstdblib dependency!

                    foreach (EObject e in list)
                    {
                        result.Add(e);
                    }

                }
                else
                {
                    var value = this.eGet(f) as EObject;
                    result.Add(value);
                }

                
                
            }

            return result;
        }

        public TreeIterator<EObject> eAllContents()
        {
            throw new NotImplementedException();
        }

        public List<EObject> eCrossReferences()
        {
            throw new NotImplementedException();
        }

        public object eGet(EStructuralFeature feature)
        {
            return eGet(feature, true);
        }

        public object eGet(EStructuralFeature feature, bool resolve)
        {

            return eGet(feature, resolve, true);
        }

        public virtual object eGet(EStructuralFeature feature, bool resolve, bool coreType)
        {

            int featureID = eDerivedStructuralFeatureID(feature);

            /*
            if (featureID >= 0)
            {
            */
            return eGet(featureID, resolve, coreType);
            /*
            }
            else
            {
                return eOpenGet(eFeature, resolve);
            }
            */
        }

        public virtual object eGet(int featureID, bool resolve, bool coreType)
        {
            EStructuralFeature eFeature = eClass().getEStructuralFeature(featureID);
            return eFeature;
        }

        public virtual void eSet(EStructuralFeature eFeature, object newValue)
        {
            int featureID = eDerivedStructuralFeatureID(eFeature);
            /*
            if (featureID >= 0)
            {
            */
                eSet(featureID, newValue);

            /*}
            else
            {
                eOpenSet(eFeature, newValue);
            }
            */
        }

        public virtual bool eIsSet(EStructuralFeature feature)
        {
            throw new NotImplementedException();
        }

        public virtual void eUnset(EStructuralFeature feature)
        {
            throw new NotImplementedException();
        }

        public object eInvoke(EOperation operation, List<object> arguments)
        {
            throw new NotImplementedException();
        }

        public virtual int eDerivedStructuralFeatureID(int baseFeatureID, Type baseClass)
        {
            return baseFeatureID;
        }

        public int eDerivedStructuralFeatureID(EStructuralFeature eStructuralFeature)
        {

            Type containerClass = eStructuralFeature.getContainerClass();
            /*
            Class <?> containerClass = eStructuralFeature.getContainerClass();
            if (containerClass == null)
            {
                return eClass().getFeatureID(eStructuralFeature);
            }
            else
            {
                assert eClass().getEAllStructuralFeatures().contains(eStructuralFeature) : "The feature '" + eStructuralFeature.getName() + "' is not a valid feature";
                */
            return eDerivedStructuralFeatureID(eStructuralFeature.getFeatureID(), containerClass);
            /*}*/
        }


        //NEU ANFANG



        public T asType<T>()
        {

            object clone = this.MemberwiseClone();

            //Convert.ChangeType(clone, T);

            return (T)clone;
        }

        public virtual NotificationChain eInverseAdd(InternalEObject otherEnd, int featureID, Type baseClass, NotificationChain msgs)
        {


            if (featureID >= 0)
            {
                //return eInverseAdd(otherEnd, eDerivedStructuralFeatureID(featureID, baseClass), msgs);
                return eInverseAdd(otherEnd, featureID, msgs);
            }
            else
            {
                if (eInternalContainer() != null)
                {
                    msgs = eBasicRemoveFromContainer(msgs);
                }
                return eBasicSetContainer(otherEnd, featureID, msgs);
            }


            //return this.eInverseAdd(otherEnd, featureID, msgs);


        }

        public virtual NotificationChain eInverseAdd(InternalEObject otherEnd, int featureID, NotificationChain msgs)
        {

            //return eDynamicInverseAdd(otherEnd, featureID, msgs);

            //call generated function
            return msgs;
        }

        public virtual NotificationChain eInverseRemove(InternalEObject otherEnd, int featureID, Type baseClass, NotificationChain msgs)
        {

            if (featureID >= 0)
            {
                //return eInverseRemove(otherEnd, eDerivedStructuralFeatureID(featureID, baseClass), msgs);
                return this.eInverseRemove(otherEnd, featureID, msgs);
            }
            else
            {
                return eBasicSetContainer(null, featureID, msgs);
            }

        }

        public virtual NotificationChain eInverseRemove(InternalEObject otherEnd, int featureID, NotificationChain msgs)
        {

            //return eDynamicInverseRemove(otherEnd, featureID, msgs);
            return msgs;
        }

        //NEU ENDE



        public string eURIFragmentSegment(EStructuralFeature eFeature, EObject eObject)
        {
            throw new NotImplementedException();
        }

        public EObject eObjectForURIFragmentSegment(string uriFragmentSegment)
        {
            throw new NotImplementedException();
        }

        public void eSetClass(EClass eClass)
        {
            throw new NotImplementedException();
        }

        public virtual int eBaseStructuralFeatureID(int derivedFeatureID, Type baseClass)
        {
            throw new NotImplementedException();
        }

        public int eContainerFeatureID()
        {
            return _eContainerFeatureID;
        }

        public int eDerivedOperationID(int baseOperationID, Type baseClass)
        {
            throw new NotImplementedException();
        }



        public NotificationChain eBasicSetContainer(InternalEObject newContainer, int newContainerFeatureID, NotificationChain notifications)
        {



            /*
            InternalEObject oldContainer = eInternalContainer();
            Resource.Internal oldResource = this.eDirectResource();
            Resource.Internal newResource = null;
            if (oldResource != null)
            {
                if (newContainer != null && !eContainmentFeature(this, newContainer, newContainerFeatureID).isResolveProxies())
                {
                    msgs = ((InternalEList <?>)oldResource.getContents()).basicRemove(this, msgs);
                    eSetDirectResource(null);
                    newResource = newContainer.eInternalResource();
                }
                else
                {
                    oldResource = null;
                }
            }
            else
            {
                if (oldContainer != null)
                {
                    oldResource = oldContainer.eInternalResource();
                }
                if (newContainer != null)
                {
                    newResource = newContainer.eInternalResource();
                }
            }

            if (oldResource != newResource && oldResource != null)
            {
                oldResource.detached(this);
            }
            

            int oldContainerFeatureID = eContainerFeatureID();
            */

            eBasicSetContainer(newContainer, newContainerFeatureID);

            /*
            if (oldResource != newResource && newResource != null)
            {
                newResource.attached(this);
            }

            if (eNotificationRequired())
            {
                if (oldContainer != null && oldContainerFeatureID >= 0 && oldContainerFeatureID != newContainerFeatureID)
                {
                    ENotificationImpl notification =
                      new ENotificationImpl
                       (this,
                        Notification.SET,
                        oldContainerFeatureID,
                        oldContainer,
                        null);
                    if (msgs == null)
                    {
                        msgs = notification;
                    }
                    else
                    {
                        msgs.add(notification);
                    }
                }
                if (newContainerFeatureID >= 0)
                {
                    ENotificationImpl notification =
                      new ENotificationImpl
                       (this,
                        Notification.SET,
                        newContainerFeatureID,
                        oldContainerFeatureID == newContainerFeatureID ? oldContainer : null,
                        newContainer);
                    if (msgs == null)
                    {
                        msgs = notification;
                    }
                    else
                    {
                        msgs.add(notification);
                    }
                }
            }
            return msgs;
            */

            return notifications;
        }

        public NotificationChain eBasicRemoveFromContainer(NotificationChain notifications)
        {
            //TODO implement me:
            return notifications;
        }

        public EObject eResolveProxy(InternalEObject proxy)
        {
            throw new NotImplementedException();
        }

        public virtual void eSet(int featureID, object newValue)
        {
            throw new NotImplementedException();
        }

        public virtual void eUnset(int featureID)
        {
            throw new NotImplementedException();
        }

        public virtual bool eIsSet(int featureID)
        {
            throw new NotImplementedException();
        }


        public virtual bool oclIsTypeOf(Type classifier)
        {
            return GetType() == classifier;
        }

        public virtual bool oclIsKindOf(Type classifier)
        {
            return GetType().IsInstanceOfType(classifier);
        }

        public virtual T oclAsType<T>() where T:class
        {
            
            return this as T;
        }

        public virtual Type oclType()
        {
            return this.GetType();
        }

        public virtual Set<T> oclAsSet<T>() where T:BasicEObjectImpl
        {
            var result = new Set<T>();
            result.Add(oclAsType<T>());

            return result;
        }



    }
}
