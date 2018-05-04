using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ecore;
using oclstdlib;


namespace EcoreTest
{
    class TestOCL {

        public TestOCL() { }

        public static String oclInvalidValue = "invalid";

        /*------------- assertQueryResults ----------------*/
        /**
	     * Creates a query given the expression that is to be evaluated, then
	     * asserts its result is equal to the evaluation of the given
	     * <code>expectedResultExpression</code>.
	     * <p>
	     * If either the expected result or the expression result is a double, we'll
	     * compare the two with a margin of 0.001.
	     * </p>
	     *
	     * @param expectedResult
	     *            Object with which the query's result is to be compared.
	     * @param expression
	     *            Expression that is to be evaluated. Note that we'll use
	     *            {@link EClass} as this expression's context.
	    */
        /*
        public Object assertQueryResults(Object context, @NonNull String expectedResultExpression, @NonNull String expression){
            try
            {
                Object expectedResultQuery = evaluateLocal(context, expectedResultExpression);
                Object result = assertQueryEquals(context, expectedResultQuery, expression);
                PivotTestSuite.appendLog(testName, context, expression, null, expectedResultExpression, null);
                return result;
            }
            catch (Exception e)
            {
                PivotTestSuite.failOn(expectedResultExpression, e);
                return null;
            }
        }
        */
        /*
       public void assertQueryResults<T>(Collection<object> expectedResult, Collection<object> actualResult)
       {
           CollectionAssert.AreEqual(expectedResult as ICollection, actualResult as ICollection);
       }

        public void assertQueryResults<T>(Bag<T> expectedResult, Sequence<T> actualResult)
        {
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }*/


        /*
        public void assertQueryResults<T>(Bag<T> expectedResult, Bag<T> actualResult){
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        public void assertQueryResults<T>(Bag<T> expectedResult, Sequence<T> actualResult)
        {
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        public void assertQueryResults<T>(Set<T> expectedResult, Set<T> actualResult){
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        public void assertQueryResults<T>(Sequence<T> expectedResult, Sequence<T> actualResult){
            CollectionAssert.AreEquivalent(expectedResult, actualResult);        
        }

        public void assertQueryResults<T>(OrderedSet<T> expectedResult, OrderedSet<T> actualResult){
            CollectionAssert.AreEquivalent(expectedResult, actualResult);
        }
        */

        public void assertQueryResults<T>(AbstractCollection<T> expectedResult, AbstractCollection<T> actualResult)
        {
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }


        /*------------- assertQueryEquals(Object, Object, String) ----------------*/
        /**
        * Assert that the result of evaluating an expression as a query is equal to expected.
        * @return the evaluation result
        */
        /*
        public @Nullable Object assertQueryEquals(@Nullable Object context, @Nullable Object expected, @NonNull String expression){
             try {
                Object expectedValue = expected instanceof Value ? expected : getIdResolver().boxedValueOf(expected);
                Object value = evaluate(null, context, expression);
                assertOCLEquals(expression, expectedValue, value);
                PivotTestSuite.appendLog(testName, context, expression, null, expectedValue != null ? expectedValue.toString() : null, null);
                return value;
            } catch (Exception e) {
                PivotTestSuite.failOn(expression, e);
                return null;
            }
        }
        */

        public void assertQueryEquals(Object expected, Object actual)
        {
            Assert.AreEqual(expected, actual);
        }

        public void assertQueryEquals<T>(AbstractCollection<T> expected, AbstractCollection<T> actual)
        {
            CollectionAssert.AreEqual(expected, actual);
        }


        /*------------- assertQueryInvalid(Object, String, String) ----------------*/
        /**
          * Assert that the result of evaluating an expression as a query is invalid.
          * @return the evaluation result
        */
        /*
        public Object Value assertQueryInvalid(Object context, @NonNull String expression){        
            try
            {
                Object value = evaluateWithoutValidation(null, context, expression);
                TestCase.fail(expression + " expected: invalid but was: " + value);
            }
            catch (InvalidValueException e)
            {   
                // OCL invalid is always an InvalidValueException
                PivotTestSuite.appendLog(testName, context, expression, null, "invalid", null);
            }
            catch (Exception e)
            {   
                // Something else is nasty
                PivotTestSuite.failOn(expression, e);
            }
            return null;        
        }
        */
        public void assertQueryInvalid(Object actualValue){
            if(actualValue.ToString() != oclInvalidValue)
                Assert.Fail("Expected: 'invalid' but was: " + actualValue.ToString());

        }
        /*------------- assertQueryInvalid(Object, String, String, Class<?>) ----------------*/
        /**
        public Object assertQueryInvalid(Object context, @NonNull String expression, String reason, Class<?> exceptionClass)
        {   
            try
            {
                Object value = evaluateWithoutValidation(null, context, expression);                
                TestCase.fail(expression + " expected: invalid but was: " + value);               
            }
            catch (InvalidValueException e)
            {
                Throwable ex = e;
                Throwable cause = e.getCause();
                String message = e.getMessage();
                if (cause != null)
                {
                    ex = cause;
                    if (!(cause instanceof NumberFormatException)) {
                        String m = ex.getMessage();
                        if (m != null)
                        {
                            message = m;
                        }
                    }
                }
                if (reason != null)
                {
                    TestCase.assertEquals("Invalid Value Reason", reason, message);
                }
                if (exceptionClass != null)
                {
                    TestCase.assertEquals("Invalid Value Throwable", exceptionClass, ex.getClass());
                }
            }
            catch (Exception e)
            {
                if ((exceptionClass != null) && (exceptionClass != e.getClass()))
                {
                    TestCase.assertEquals("Invalid Value Throwable", exceptionClass, e.getClass() + " : " + e.getMessage());
                }
                if (reason != null)
                {
                    TestCase.assertEquals("Invalid Value Reason", reason, e.getMessage());
                }
            }
            return null; 
        }
        */
        public void assertQueryInvalid<T>(Object actualValue, String reason, T exceptionClass){
            if (actualValue.ToString() != oclInvalidValue)
                Assert.Fail("Expected: 'invalid' but was: " + actualValue.ToString());
        }
                    

        /*------------- assertResultContainsAll ----------------*/
        /**
        * Creates a query given the expression that is to be evaluated, then
        * asserts its result contains all elements included in
        * <code>expectedResult</code>.
        *
        * @param expectedResultExpression
        *            Expression which is to be evaluated to determine the expected
        *            result.
        * @param expression
        *            Expression that is to be evaluated. Note that we'll use
        *            {@link EClass} as this expression's context.
        */
        /*
        public Object assertResultContainsAll(Object context, @NonNull String expectedResultExpression, @NonNull String expression){
            try {
                Object expectedResultQuery = evaluateLocal(null, expectedResultExpression);
                TestCase.assertTrue(expectedResultQuery instanceof CollectionValue);
                @SuppressWarnings("null")
                Object result = assertResultContainsAll(context, (CollectionValue) expectedResultQuery, expression);
                return result;
            } catch (Exception e) {
                PivotTestSuite.failOn(expectedResultExpression, e);
                return null;
            }
        }
        */

        public void assertResultContainsAll<T>(AbstractCollection<T> expected, AbstractCollection<T> actual){
            CollectionAssert.AreEqual(expected, actual);            
        }


        /*------------- assertQueryNull ----------------*/
        /**
        * Assert that the result of evaluating an expression as a query is OCL null.
        * @return the evaluation result
        */
        /*
        public Object assertQueryNull(Object context, @NonNull String expression)
        {
            try {
                Object value = evaluate(null, context, expression);
                TestCase.assertEquals(expression, null, value);
                PivotTestSuite.appendLog(testName, context, expression, null, "null", null);
                return value;
            } catch (Exception e) {
                PivotTestSuite.failOn(expression, e);
                return null;
            }
        }
        */

        public void assertQueryNull(Object expression){
            Assert.IsNull(expression);
        }


        /*------------- assertQueryFalse ----------------*/
        /**
        * Assert that the result of evaluating an expression as a query is false.
        * @return the evaluation result
        */
        /*
         * public Object assertQueryFalse(Object context, @NonNull String expression)
        {
            try {
                Object value = evaluate(null, context, expression);
                TestCase.assertEquals(expression, Boolean.FALSE, value);
                PivotTestSuite.appendLog(testName, context, expression, null, "false", null);
                return value;
            } catch (Exception e) {
                PivotTestSuite.failOn(expression, e);
                return null;
            }
        }
        */
        public void assertQueryFalse(Boolean expression){
            Assert.IsFalse(expression);
        }


        /*------------- assertQueryTrue ----------------*/
        /**
        * Assert that the result of evaluating an expression as a query is true.
        * @return the evaluation result
        */
        /*
        public Object assertQueryTrue(Object context, @NonNull String expression)
        {
            try {
                Object value = evaluate(null, context, expression);
                TestCase.assertEquals(expression, Boolean.TRUE, value);
                PivotTestSuite.appendLog(testName, context, expression, null, "true", null);
                return value;
            } catch (Exception e) {
                PivotTestSuite.failOn(expression, e);
                return null;
            }
        }
        */

        public void assertQueryTrue(Boolean expression){
            Assert.IsTrue(expression);
        }


        /*------------- assertSemanticErrorQuery ----------------*/
        /*public void assertSemanticErrorQuery(org.eclipse.ocl.pivot.@Nullable Class Object contextType, @NonNull String expression, String messageTemplate, Object bindings) 
        {
		    //assertBadQuery(SemanticException.class, Diagnostic.ERROR, contextType, expression, messageTemplate, bindings);
	    }*/

        public void assertSemanticErrorQuery(Object expression, String messageTemplate, Object bindings){
            //assertBadQuery(SemanticException.class, Diagnostic.ERROR, contextType, expression, messageTemplate, bindings);
            throw new NotImplementedException();
        }


        /*------------- assertBadQuery ----------------*/
        /**
	     * Assert that an expression cannot be used as a query, because an exception is thrown
	     * with a diagnostic of severity containing a message that is the result of messageTemplate
	     * resolved by bindings.
	     * @throws IOException
	     */
        /**
        public void assertBadQuery(@NonNull Class<?> exception, int severity, org.eclipse.ocl.pivot.@Nullable Class contextType, @NonNull String expression, @NonNull/ String messageTemplate, Object...bindings){
            BaseCSResource csResource = null;
            try
            {
                ParserContext classContext = new ClassContext(getEnvironmentFactory(), null, contextType, null);
                csResource = (BaseCSResource)classContext.createBaseResource(expression);
                PivotUtil.checkResourceErrors(StringUtil.bind(PivotMessagesInternal.ErrorsInResource, expression), csResource);
                Resource asResource = csResource.getASResource();
                PivotTestSuite.assertNoValidationErrors("Validating", asResource);
                TestCase.fail("Should not have parsed \"" + expression + "\"");
            }
            catch (ParserException e)
            {
                TestCase.assertEquals("Exception for \"" + expression + "\"", exception, e.getClass());
                Resource.Diagnostic diagnostic = getDiagnostic(csResource);
                String expectedMessage = StringUtil.bind(messageTemplate, bindings);
                TestCase.assertEquals("Message for \"" + expression + "\"", expectedMessage, diagnostic.getMessage());
                PivotTestSuite.appendLog(testName, contextType, expression, expectedMessage, null, null);
            }
            catch (IOException e)
            {
                TestCase.fail(e.getMessage());
            }
            finally
            {
                if (csResource != null)
                {
                    EnvironmentFactoryAdapter.disposeAll(csResource);
                }
            }
        }*/

        public void assertBadQuery(Exception exception, int severity, Object expression, String messageTemplate, Object bindings){
            throw new NotImplementedException();
            //throw new NotImplementedException(System.Reflection.MethodBase.GetCurrentMethod().Name);
        }        
    }


    public class AssertFunctionNotImplementedException : Exception
    {
        public AssertFunctionNotImplementedException()
        {
        }

        public AssertFunctionNotImplementedException(string message)
            : base(message)
        {
        }

        public AssertFunctionNotImplementedException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }


}