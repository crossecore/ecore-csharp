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
    public class OrderedSet<T> : AbstractCollection<T>
    {


        public OrderedSet() : base()
        {
        }

        public OrderedSet(IEnumerable<T> enumerable) : base(enumerable)
        {


        }

        public OrderedSet(InternalEObject owner, int featureId) : base(owner, featureId, NO_FEATURE)
        {

        }

        public OrderedSet(InternalEObject owner, int featureId, int oppositeFeatureId) : base(owner, featureId, oppositeFeatureId)
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

        public OrderedSet<T2> selectByType<T2>()
        {
            var thisCollection = this;
            var result = new OrderedSet<T2>();

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

        public OrderedSet<T2> selectByKind<T2>()
        {
            var thisCollection = this;
            var result = new OrderedSet<T2>();

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

        public OrderedSet<T2> flatten<T2>()
        {

            var result = new OrderedSet<T2>();

            foreach (object element in this)
            {
                if (element is OrderedSet<T2>)
                {

                    var subcollection = (OrderedSet<T2>)element;
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

    
        public OrderedSet<T2> collect<T2>(Func<T, Collection<T2>> lambda)
        {
            var result = new OrderedSet<T2>();

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


        public OrderedSet<T2> collect<T2>(Func<T, T2> lambda)
        {

            var result = new OrderedSet<T2>();

            foreach (T element in this)
            {
                var item = lambda(element);
                if (item!=null)
                {
                    result.Add(item);
                }
                
                
                

            }

            return result;

        }


        public OrderedSet<T> union(Collection<T> other)
        {

            var result = new OrderedSet<T>(this);
            result.Union(other);
            return result;
        }

        public OrderedSet<T> subOrderedSet(int begin, int end)
        {
            var result = this.GetRange(begin, end);
            return new OrderedSet<T>(result);
        }

        public OrderedSet<T> reverse()
        {
            var result = new OrderedSet<T>(this);
            result.Reverse();
            return result;
        }

        public OrderedSet<T> insertAt(int index, T item)
        {
            var result = new OrderedSet<T>(this);
            result.Insert(index, item);

            return result;
        }

        public T at(int i)
        {
           
            return this.ElementAt(i);
        }

        public OrderedSet<T> union(OrderedSet<T> other)
        {
            var union = new OrderedSet<T>();

            foreach (T element in this)
            {
                union.Add(element);
            }

            foreach (T element in other)
            {
                union.Add(element);
            }


            return union;
             
        }

        public OrderedSet<T> minus(OrderedSet<T> other)
        {
            var result = new OrderedSet<T>(this);

            foreach (T element in other)
            {
                result.remove(element);
            }


            return result;

        }

        public OrderedSet<T> minus(Set<T> other)
        {
            var result = new OrderedSet<T>(this);

            foreach (T element in other)
            {
                result.remove(element);
            }
            return result;

        }

        protected override bool isUnique()
        {
            return true;
        }

        

        public OrderedSet<T> including(T element)
        {
            var copy = new OrderedSet<T>(this);
            copy.Add(element);
            return copy;
        }

        public OrderedSet<T> excluding(T element)
        {
            var copy = new OrderedSet<T>(this);
            copy.remove(element);
            return copy;
        }

        //http://download.eclipse.org/ocl/doc/6.0.0/ocl.pdf
        public OrderedSet<T> excludingAll(Collection<T> collection)
        {
            var result = new OrderedSet<T>();
            
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
        /// The OrderedSet containing all elements of self and objects.
        /// </summary>
        public OrderedSet<T> includingAll(Collection<T> collection)
        {

            var result = new OrderedSet<T>(this);

            foreach (T item in collection)
            {
                result.Add(item);
            }

            return result;
        }

        /// <summary>
        /// http://download.eclipse.org/ocl/doc/6.0.0/ocl.pdf
        /// The OrderedSet of elements, consisting of all elements of self, followed by objects.
        /// </summary>
        public OrderedSet<T> appendAll(Collection<T> collection)
        {
            var result = new OrderedSet<T>(this);

            foreach (T item in collection)
            {

                result.Add(item);

            }

            return result;
        }

        /// <summary>
        /// http://download.eclipse.org/ocl/doc/6.0.0/ocl.pdf
        /// The OrderedSet consisting of objects, followed by all elements in self.
        /// 
        /// OrderedSet{1,2,3}->prependAll(OrderedSet{2,3}) Results 2, 3, 1
        /// </summary>
        public OrderedSet<T> prependAll(Collection<T> collection)
        {
            var result = new OrderedSet<T>(collection);

            foreach (T item in this)
            {

                result.Add(item);

            }

            return result;
        }


        public OrderedSet<T> select(Func<T, bool> lambda)
        {
            var filter = this.Where(lambda);
            var result = new OrderedSet<T>();

            foreach (T element in filter)
            {

                result.Add(element);

            }
            return result;
        }

        public OrderedSet<T> reject(Func<T, bool> lambda)
        {
            var remove = this.Where(lambda);


            var result = new OrderedSet<T>();

            foreach (T element in this)
            {

                if (!remove.Contains(element))
                {
                    result.Add(element);
                }

            }

            return result;


        }

        public virtual OrderedSet<T> append(T item)
        {

            var copy = new OrderedSet<T>(this);
            if (this.Contains(item))
            {
                copy.remove(item);
            }
                        
            copy.Add(item);
            return copy;

        }

        public virtual OrderedSet<T> prepend(T item)
        {
            var result = new OrderedSet<T>();
            result.Add(item);
            foreach (T i in this)
            {
                result.Add(i);
            }

            return result;
        }


        public virtual T first()
        {
            return this.ElementAt(0);
        }

        public virtual T last()
        {
            return this.ElementAt(this.size() - 1);
        }

        public virtual int indexOf(T item)
        {
            return this.IndexOf(item);
        }



        public virtual OrderedSet<T> intersection(Set<T> other)
        {
            var result = new OrderedSet<T>();
            

            foreach (T item in this)
            {
                if (other.Contains(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }



    }
}
