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

namespace oclstdlib
{
    public interface Collection<T>: IEnumerable<T>
    {
        bool add(T element);
        bool remove(T element);
        bool equals(Collection<T> c);
        bool notEquals(Collection<T> c);
        int size();
        bool includes(T element);
        bool excludes(T element);
        int count(T element);
        bool includesAll(Collection<T> c2);
        bool excludesAll(Collection<T> c2);
        bool isEmpty();
        bool notEmpty();
        T max();
        T min();
        double sum();
        Set<T> asSet();
        OrderedSet<T> asOrderedSet();
        Sequence<T> asSequence();
        Bag<T> asBag();
        //Collection<T2> flatten<T2>();
        T any(Func<T, bool> lambda);
        //Collection<T2> closure<T2>(Func<T, T2> lambda);

        //Collection<T2> collect<T2>(Func<T, T2> lambda);
        //Collection<T2> collect<T2>(Func<T, Collection<T2>> lambda);

        //Collection<T> including(T element);
        //Collection<T> excluding(T element);
        //Collection<T2> collect<T2>(Func<T, T2> lambda);
        //Collection<T2> collect<T2>(Func<T, Collection<T2>> lambda);
        bool exists(Func<T, bool> lambda);
        bool forAll(Func<T, bool> lambda);
        bool isUnique<T2>(Func<T, T2> lambda);
        bool one(Func<T, bool> lambda);
        //Collection<T> reject(Func<T, bool> lambda);

        //TODO if result set has only one element, this element should be returned directly
        //Collection<T> select(Func<T, bool> lambda);
        //Collection<T> sortedBy<T2>(Func<T, T2> lambda);
    }
}
