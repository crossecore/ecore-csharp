/* CrossEcore is a cross-platform modeling framework that generates C#, TypeScript, 
 * JavaScript, Swift code from Ecore models with embedded OCL (http://www.crossecore.org/).
 * The original Eclipse Modeling Framework is available at https://www.eclipse.org/modeling/emf/.
 * 
 * contributor: Simon Schwichtenberg
 */
using System.Collections.Generic;
using Ecore;
using System.Linq;
using System;

namespace oclstdlib
{
    public class Sequence<T>:AbstractCollection<T>
    {


        public Sequence() : base()
        {
        }

        public Sequence(IEnumerable<T> enumerable) : base(enumerable)
        {


        }

        public Sequence(InternalEObject owner, int featureId):base(owner, featureId, NO_FEATURE)
        {

        }

        public Sequence(InternalEObject owner, int featureId, int oppositeFeatureId): base(owner, featureId, oppositeFeatureId)
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


        public Sequence<T> union(Collection<T> other)
        {

            var result = new Sequence<T>(this);
            result.Union(other);
            return result;
        }

        public Sequence<T2> collect<T2>(Func<T, Collection<T2>> lambda)
        {
            var result = new Sequence<T2>();

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


        public Sequence<T2> collect<T2>(Func<T, T2> lambda)
        {

            var result = new Sequence<T2>();

            foreach (T element in this)
            {

                result.Add(lambda(element));

            }

            return result;

        }

        public Sequence<T> subSequence(int begin, int end)
        {
            var result = this.GetRange(begin, end);
            return new Sequence<T>(result);
        }

        public Sequence<T> insertAt(int index, T item)
        {
            var result = new Sequence<T>(this);
            result.Insert(index, item);

            return result;
        }


        public Sequence<T2> selectByType<T2>()
        {
            var thisCollection = this;
            var result = new Sequence<T2>();

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

        public Sequence<T2> flatten<T2>()
        {

            var result = new Sequence<T2>();

            foreach (object element in this)
            {
                if (element is Sequence<T2>)
                {

                    var subcollection = (Sequence<T2>)element;
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

        public Sequence<T2> selectByKind<T2>()
        {
            var thisCollection = this;
            var result = new Sequence<T2>();

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

        /// <summary>
        /// http://download.eclipse.org/ocl/doc/6.0.0/ocl.pdf
        /// The Sequence containing all elements of self and objects.
        /// </summary>
        public Sequence<T> includingAll(Collection<T> collection)
        {

            var result = new Sequence<T>(this);

            foreach (T item in collection)
            {
                result.Add(item);
            }

            return result;
        }

        /// <summary>
        /// http://download.eclipse.org/ocl/doc/6.0.0/ocl.pdf
        /// The Sequence containing all elements of self apart from all occurrences of all objects.
        /// </summary>
        public Sequence<T> excludingAll(Collection<T> collection)
        {
            var result = new Sequence<T>();

            foreach (T item in this)
            {
                if (!collection.Contains(item))
                {
                    result.Add(item);
                }
            }

            return result;
        }


        /// <summary>
        /// http://download.eclipse.org/ocl/doc/6.0.0/ocl.pdf
        /// The Sequence of elements, consisting of all elements of self, followed by objects
        /// </summary>
        public Sequence<T> appendAll(Collection<T> collection)
        {
            var result = new Sequence<T>(this);

            foreach (T item in collection)
            {

                result.Add(item);

            }

            return result;
        }

        /// <summary>
        /// http://download.eclipse.org/ocl/doc/6.0.0/ocl.pdf
        /// The Sequence consisting of objects, followed by all elements in self.
        /// </summary>
        public Sequence<T> prependAll(Collection<T> collection)
        {
            var result = new Sequence<T>(collection);
            
            foreach (T item in this)
            {

                result.Add(item);

            }

            return result;
        }


        protected override bool isUnique()
        {
            return false;
        }

        public Sequence<T> including(T element)
        {
            var copy = new Sequence<T>(this);
            copy.Add(element);
            return copy;
        }

        public Sequence<T> excluding(T element)
        {
            var copy = new Sequence<T>(this);
            copy.remove(element);
            return copy;
        }

        public Sequence<T> select(Func<T, bool> lambda)
        {
            var filter = this.Where(lambda);
            var result = new Sequence<T>();

            foreach (T element in filter)
            {

                result.Add(element);

            }
            return result;
        }

        public virtual Sequence<T> append(T item)
        {
            var copy = new Sequence<T>(this);
            copy.Add(item);
            return copy;

        }

        public virtual T at(int index)
        {
            return this.ElementAt(index);
        }

        public virtual T first()
        {
            return this.ElementAt(0);
        }

        public virtual T last()
        {
            return this.ElementAt(this.size()-1);
        }

        public virtual int indexOf(T item)
        {
            return this.IndexOf(item);
        }

        public virtual Sequence<T> prepend(T item)
        {
            var result = new Sequence<T>();
            result.Add(item);
            foreach (T i in this)
            {
                result.Add(i);
            }

            return result;
        }
    }
}
