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
using oclstdlib;
///<summary>This class was generated.</summary>
namespace Ecore
{



    public class EClassifierImpl
    : EClassifierBase
    {
        protected int metaObjectID = -1;
        public void setClassifierID(int id)
        {
            metaObjectID = id;
        }

        protected string generatedInstanceClassName;
        public void setGeneratedInstanceClass(bool isGenerated)
        {
            if (isGenerated)
            {
                if (generatedInstanceClassName == null)
                {
                    generatedInstanceClassName = instanceClassName;
                    instanceClassName = null;
                }
            }
            else if (generatedInstanceClassName != null)
            {
                instanceClassName = generatedInstanceClassName;
                generatedInstanceClassName = null;
            }
        }

        //TODO implement
        public void setInstanceClass(Type value)
        {
            /*
            if (value == null)
            {
                setInstanceClassNameGen(null);
                basicSetInstanceTypeName(null);
            }
            else if (value.isArray())
            {
                String indices = "[]";
                for (Class <?> component = value.getComponentType(); ; component = component.getComponentType())
                {
                    if (!component.isArray())
                    {
                        String name = (component.getName() + indices).intern();
                        setInstanceClassNameGen(name);
                        basicSetInstanceTypeName(name);
                        break;
                    }
                    indices += "[]";
                }
            }
            else
            {
                String name = value.getName().intern();
                setInstanceClassNameGen(name);
                basicSetInstanceTypeName(name);
            }

            setInstanceClassGen(value);
            */
        }

        public void basicSetInstanceTypeName(String newInstanceTypeName)
        {
            String oldInstanceTypeName = instanceTypeName;
            instanceTypeName = newInstanceTypeName;

            /*
            if (eNotificationRequired())
            {
                eNotify
                  (new ENotificationImpl(this, Notification.SET, EcorePackage.ECLASSIFIER__INSTANCE_TYPE_NAME, oldInstanceTypeName, newInstanceTypeName));
            }
            */
        }

        public override int getClassifierID()
        {
            if (metaObjectID == -1)
            {
                metaObjectID = computeClassifierID();
            }
            return metaObjectID;
        }

        private int computeClassifierID()
        {
            return

              ePackage != null ?
                ePackage.eClassifiers.indexOf(this) :
                -1;
        }

    }

}
