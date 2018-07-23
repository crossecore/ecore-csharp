using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecore
{
    public interface EMap<K, V>
    {
        V get(object key);
        V put(K key, V value);

        Dictionary<K, V> map();

        void putAll(Dictionary<K, V> map);
        //TODO other methods

        bool isEmpty();//from org.eclipse.emf.common.util.EList(java.util.List)
    }
}
