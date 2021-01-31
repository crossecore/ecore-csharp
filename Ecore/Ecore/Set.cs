/* CrossEcore is a cross-platform modeling framework that generates C#, TypeScript, 
 * JavaScript, Swift code from Ecore models with embedded OCL (http://www.crossecore.org/).
 * The original Eclipse Modeling Framework is available at https://www.eclipse.org/modeling/emf/.
 * 
 * contributor: Simon Schwichtenberg
 */
using System;
using System.Collections.Generic;
using System.Linq;
using Ecore;


namespace oclstdlib
{
    public class Set<T>:AbstractCollection<T>
    {

        public Set(IEnumerable<T> enumerable) : base(enumerable)
        {

        }

        public Set() : base()
        {

        }

        public Set(InternalEObject owner, int featureId):base(owner, featureId, NO_FEATURE)
        {

        }

        public Set(InternalEObject owner, int featureId, int oppositeFeatureId): base(owner, featureId, oppositeFeatureId)
        {
            

        }

        protected override bool isUnique()
        {
            return true;
        }




        public Set<Tuple<T,T2>> product<T2>(Collection<T2> collection)
        {

            var result = new Set<Tuple<T, T2>>();
            foreach (T first in this)
            {
                foreach (T2 second in collection)
                {
                    var tuple = new Tuple<T,T2>(first, second);

                }
                
            }
            return result;
        }


        public Set<T> union(Set<T> other)
        {

            var result = new Set<T>(this);
            result.Union(other);
            return result;
        }

        public Bag<T> union(Bag<T> other)
        {

            var result = new Bag<T>(this);
            result.Union(other);
            return result;
        }



        public virtual Set<T> intersection(Set<T> other)
        {
                        
            return new Set<T>(this.Intersect(other));
        }

        public virtual Set<T> intersection(Bag<T> other)
        {

            return new Set<T>(this.Intersect(other));
        }

        public Set<T> minus(Set<T> other)
        {
            var result = new Set<T>(this);

            foreach (T element in other)
            {
                result.remove(element);
            }


            return result;

        }

    
        public Set<T2> collect<T2>(Func<T, Collection<T2>> lambda)
        {
            var result = new Set<T2>();

            foreach (T element in this)
            {

                var e = lambda(element);


                foreach (T2 ee in e)
                {
                    result.Add(ee);
                }

            }

            return result;
        }

        public Set<T2> collect<T2>(Func<T, T2> lambda)
        {

            var result = new Set<T2>();

            foreach (T element in this)
            {

                result.Add(lambda(element));

            }

            return result;

        }


        public Set<T> including(T element)
        {
            var copy = new Set<T>(this);
            copy.Add(element);
            return copy;
        }

        public Set<T> excluding(T element)
        {
            var copy = new Set<T>(this);
            copy.remove(element);
            return copy;
        }

        /// <summary>
        /// http://download.eclipse.org/ocl/doc/6.0.0/ocl.pdf
        /// The Set containing all elements of self and objects.
        /// 
        /// Set{1,2,3}->includingAll(Set{2,3}) Results: 1, 2, 3
        /// </summary>
        public Set<T> includingAll(Collection<T> collection)
        {

            var result = new Set<T>(this);

            foreach (T item in collection)
            {
                result.Add(item);
            }

            return result;
        }

        /// <summary>
        /// http://download.eclipse.org/ocl/doc/6.0.0/ocl.pdf
        /// The Set containing all elements of self apart from all occurrences of all objects.
        /// 
        /// Set{1,2,3}->excludingAll(Set{2,3}) Results: 1
        /// </summary>
        public Set<T> excludingAll(Collection<T> collection)
        {
            var result = new Set<T>();

            foreach (T item in this)
            {
                if (!collection.Contains(item))
                {
                    result.Add(item);
                }
            }

            return result;
        }


        public Set<T> symmetricDifference(Collection<T> other)
        {
            var result = new Set<T>();
            foreach (T item in this)
            {
                if (!other.Contains(item))
                {
                    result.Add(item);
                }
            }
            foreach (T item in other)
            {
                if (this.Contains(item))
                {
                    result.Add(item);
                }
            }

            return result;
        }

        public Set<T2> flatten<T2>()
        {

            var result = new Set<T2>();

            foreach (object element in this)
            {
                if (element is Set<T2>)
                {

                    var subcollection = (Set<T2>)element;
                    foreach (T2 e in subcollection.flatten<T2>().asSet())
                    {
                        result.Add(e);
                    }

                }
                else if (element is T2)
                {
                    var e = (T2)element;
                    result.Add(e);

                }
            }

            return result;

        }

        public Set<T> select(Func<T, bool> lambda)
        {
            var filter = this.Where(lambda);
            var result = new Set<T>();

            foreach (T element in filter)
            {

                result.Add(element);

            }
            return result;
        }

        public Set<T> reject(Func<T, bool> lambda)
        {
            var remove = this.Where(lambda);


            var result = new Set<T>();

            foreach (T element in this)
            {

                if (!remove.Contains(element))
                {
                    result.Add(element);
                }

            }

            return result;


        }


        public Set<T2> selectByType<T2>()
        {
            var thisCollection = this;
            var result = new Set<T2>();

            foreach (T item in thisCollection)
            {
                var itemType = item.GetType();

                if (itemType == typeof(T2))
                {
                    result.Add((T2)Convert.ChangeType(item, typeof(T2)));
                }
            }
            return result;
        }

        public Set<T2> selectByKind<T2>()
        {
            var thisCollection = this;
            var result = new Set<T2>();

            foreach (T item in thisCollection)
            {
                var itemType = item.GetType();


                if (itemType.IsSubclassOf(typeof(T2)) || itemType == typeof(T2))
                {
                    result.Add((T2)Convert.ChangeType(item, typeof(T2)));
                }
            }
            return result;
        }


    }
}
