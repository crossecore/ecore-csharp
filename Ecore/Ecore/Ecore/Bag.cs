/* CrossEcore is a cross-platform modeling framework that generates C#, TypeScript, 
 * JavaScript, Swift code from Ecore models with embedded OCL (http://www.crossecore.org/).
 * The original Eclipse Modeling Framework is available at https://www.eclipse.org/modeling/emf/.
 * 
 * contributor: Simon Schwichtenberg
 */

using System;
using System.Linq;
using System.Collections.Generic;
using Ecore;

namespace oclstdlib
{
    public class Bag<T>:AbstractCollection<T>
    {


        public Bag() : base()
        {
        }

        public Bag(IEnumerable<T> enumerable) : base(enumerable)
        {


        }

        public Bag(InternalEObject owner, int featureId):base(owner, featureId, NO_FEATURE)
        {

        }

        public Bag(InternalEObject owner, int featureId, int oppositeFeatureId): base(owner, featureId, oppositeFeatureId)
        {
            

        }
        public Set<Tuple<T, T2>> product<T2>(Collection<T2> collection)
        {

            var result = new Set<Tuple<T, T2>>();
            foreach (T first in this)
            {
                foreach (T2 second in collection)
                {
                    var tuple = new Tuple<T, T2>(first, second);

                }

            }
            return result;
        }

        public Bag<T2> selectByType<T2>()
        {
            var thisCollection = this;
            var result = new Bag<T2>();

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

        public Bag<T2> selectByKind<T2>()
        {
            var thisCollection = this;
            var result = new Bag<T2>();

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

        public Bag<T2> collect<T2>(Func<T, Collection<T2>> lambda)
        {
            var result = new Bag<T2>();

            foreach (T element in this)
            {

                var e = lambda(element);


                foreach (T2 ee in e)
                {
                    result.add(ee);
                }

            }

            return result;
        }

        /// <summary>
        /// http://download.eclipse.org/ocl/doc/6.0.0/ocl.pdf
        /// The bag containing all elements of self and objects.
        /// </summary>
        public Bag<T> includingAll(Collection<T> collection)
        {

            var result = new Bag<T>(this);

            foreach (T item in collection)
            {
                result.add(item);
            }

            return result;
        }

        /// <summary>
        /// http://download.eclipse.org/ocl/doc/6.0.0/ocl.pdf
        /// The bag containing all elements of self apart from all occurrences of all objects.
        /// </summary>
        public Bag<T> excludingAll(Collection<T> collection)
        {
            var result = new Bag<T>();

            foreach (T item in this)
            {
                if (!collection.Contains(item))
                {
                    result.add(item);
                }
            }

            return result;
        }


        public Bag<T2> collect<T2>(Func<T, T2> lambda)
        {

            var result = new Bag<T2>();

            foreach (T element in this)
            {

                result.add(lambda(element));

            }

            return result;

        }


        public Bag<T> union(Bag<T> other)
        {

            var result = new Bag<T>(this);
            result.Union(other);
            return result;
        }

        public Bag<T> union(Set<T> other)
        {

            var result = new Bag<T>(this);
            result.Union(other);
            return result;
        }

        public virtual Bag<T> intersection(Bag<T> other)
        {

            return new Bag<T>(this.Intersect(other));
        }

        public virtual Set<T> intersection(Set<T> other)
        {

            return new Set<T>(this.Intersect(other));
        }


        public Bag<T> including(T element)
        {
            var copy = new Bag<T>(this);
            copy.add(element);
            return copy;
        }

        public Bag<T> excluding(T element)
        {
            var copy = new Bag<T>(this);
            copy.remove(element);
            return copy;
        }

        public Bag<T2> flatten<T2>()
        {

            var result = new Bag<T2>();

            foreach (object element in this)
            {
                if (element is Bag<T2>)
                {

                    var subcollection = (Bag<T2>)element;
                    foreach (T2 e in subcollection.flatten<T2>().asSet())
                    {
                        result.add(e);
                    }

                }
                else if (element is T2)
                {
                    var e = (T2)element;
                    result.add(e);

                }
            }

            return result;

        }


        public Bag<T> select(Func<T, bool> lambda)
        {
            var filter = this.Where(lambda);
            var result = new Bag<T>();

            foreach (T element in filter)
            {

                result.add(element);

            }
            return result;
        }

        public Bag<T> reject(Func<T, bool> lambda)
        {
            var remove = this.Where(lambda);


            var result = new Bag<T>();

            foreach (T element in this)
            {

                if (!remove.Contains(element))
                {
                    result.add(element);
                }

            }

            return result;


        }

        protected override bool isUnique()
        {
            return false;
        }
    }
}
