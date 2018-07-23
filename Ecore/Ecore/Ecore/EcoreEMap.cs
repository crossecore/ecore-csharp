using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecore
{
    public class EcoreEMap<K, V>:Dictionary<K,V>, EMap<K,V>
    {

        protected EClass entryEClass;
        protected Type entryClass;
        public EcoreEMap(EClass entryEClass, Type entryClass, InternalEObject owner, int featureId)
        {
            this.entryClass = entryClass;
            this.entryEClass = entryEClass;
        }

        public V get(object key)
        {
            if (key is K)
            {
                return this[(K) key];
            }
            return default(V);
            
        }

        public V put(K key, V value)
        {
            V oldValue = default(V);//FIXME allow null!
            if (this.ContainsKey(key))
            {
                oldValue = this[key];
            }
            this[key] = value;
            return oldValue;
        }

        

        public void set(object value)
        {
            if (value is Dictionary<K, V>)
            {

                Dictionary<K, V> mapValue = value as Dictionary<K, V>;
                this.putAll(mapValue);
            }
        }

        public Dictionary<K, V> map()
        {
            return this;
        }

        public void putAll(Dictionary<K, V> map)
        {
            foreach (K key in map.Keys)
            {
                this.put(key, map[key]);
            }
        }

        public bool isEmpty()
        {
            return this.Values.Count == 0;
        }

    }
}
