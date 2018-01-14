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
    public interface InternalEObject : EObject
    {


        bool eNotificationRequired();


        String eURIFragmentSegment(EStructuralFeature eFeature, EObject eObject);

        EObject eObjectForURIFragmentSegment(String uriFragmentSegment);


        void eSetClass(EClass eClass);


        //EStructuralFeature.Setting eSetting(EStructuralFeature feature);


        int eBaseStructuralFeatureID(int derivedFeatureID, Type baseClass);


        int eContainerFeatureID();


        int eDerivedStructuralFeatureID(int baseFeatureID, Type baseClass);


        int eDerivedOperationID(int baseOperationID, Type baseClass);


        //NotificationChain eSetResource(Resource.Internal resource, NotificationChain notifications);


        //NotificationChain eInverseAdd(InternalEObject otherEnd, int featureID, Class<?> baseClass, NotificationChain notifications);
        NotificationChain eInverseAdd(InternalEObject otherEnd, int featureID, Type baseClass, NotificationChain notifications);

        NotificationChain eInverseRemove(InternalEObject otherEnd, int featureID, Type baseClass, NotificationChain notifications);

        NotificationChain eBasicSetContainer(InternalEObject newContainer, int newContainerFeatureID, NotificationChain notifications);

        NotificationChain eBasicRemoveFromContainer(NotificationChain notifications);

        //URI eProxyURI();


        //void eSetProxyURI(URI uri);

        EObject eResolveProxy(InternalEObject proxy);

        InternalEObject eInternalContainer();

        //Resource.Internal eInternalResource();

        //Resource.Internal eDirectResource();

        //EStore eStore();

        //void eSetStore(EStore store);

        Object eGet(EStructuralFeature eFeature, bool resolve, bool coreType);

        Object eGet(int featureID, bool resolve, bool coreType);

        void eSet(int featureID, Object newValue);

        void eUnset(int featureID);

        bool eIsSet(int featureID);

        //Object eInvoke(int operationID, EList<?> arguments) throws InvocationTargetException;
    }
}
