/**
 * Copyright (c) 2002-2004 IBM Corporation and others.
 * All rights reserved.   This program and the accompanying materials
 * are made available under the terms of the Eclipse Public License v1.0
 * which accompanies this distribution, and is available at
 * http://www.eclipse.org/legal/epl-v10.html
 * 
 * Contributors: 
 *   IBM - Initial API and implementation
 * 	 Paderborn University, s-lab, Software Quality Lab
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using oclstdlib;
///<summary>This class was generated.</summary>
using Ecore;
namespace Ocltestmodel{
	public class MyClassBase 
	:BasicEObjectImpl, MyClass
	{
		public virtual bool integer_greaterthan
		{
		get { 
			/*2>3*/
			return 2 > 3;
		}
		}
		public virtual double real_minimum
		{
		get { 
			/*2.1.min(2.2)*/
			return Math.Min(2.1, 2.2);
		}
		}
		
		public virtual Sequence<int> collection_literals
		{
			get {
				/*OCL: Sequence{1,2,3,10..20}*/
				return new Sequence<int>{
				1, 
					
				2, 
					
				3, 
					
					10,11,12,13,14,15,16,17,18,19,20
					
				}
				;
			}
		}
		
		public virtual Sequence<int> sequence_selectByKind
		{
			get {
				/*OCL: Sequence{4, 4, 5.0, 'test'}->selectByKind(Integer)*/
				return new Sequence<object>{
				4, 
					
				4, 
					
				5.0, 
					
				"test"
					
				}
				.selectByKind<int>();
			}
		}
		public virtual bool tuple_literal
		{
		get { 
			/*Tuple{first = 3, second = 4} = Tuple{first = 3, second = 4}*/
			return new Tuple<int, int>(3, 4) == new Tuple<int, int>(3, 4);
		}
		}
		private bool _unEmployed = false;
		public virtual bool unEmployed
		{
		get { 
			return _unEmployed;
		}
		set { _unEmployed = value; }
		}
		public virtual int integer_addition
		{
		get { 
			/*2+3*/
			return 2 + 3;
		}
		}
		public virtual bool let2
		{
		get { 
			/* let income : Integer = 13 * 24 in
			
							if self.unEmployed then
							income < 100
							else
							income >= 100
							endif*/
			return ((Func<bool>)(() => { var income = 13 * 24; return this.unEmployed ? income < 100 : income >= 100; }))();
			;
		}
		}
		public virtual bool boolean_unequal
		{
		get { 
			/*true <> false*/
			return true != false;
		}
		}
		public virtual int integer_modulo
		{
		get { 
			/*2.mod(2)*/
			return 2 % 2;
		}
		}
		
		public virtual Sequence<int> static_sequence
		{
			get {
				/*OCL: Sequence{1,2,3}*/
				return new Sequence<int>{
				1, 
					
				2, 
					
				3
					
				}
				;
			}
		}
		public virtual int string_indexOf
		{
		get { 
			/*'hello '.indexOf('l')*/
			return "hello ".IndexOf("l");
		}
		}
		public virtual double _NumberLiteralExp
		{
		get { 
			/*1.2*/
			return 1.2;
		}
		}
		public virtual bool boolean_xor
		{
		get { 
			/*true xor false*/
			return true ^ false;
		}
		}
		public virtual int integer_maximum
		{
		get { 
			/*2.max(2)*/
			return Math.Max(2, 2);
		}
		}
		public virtual double real_absolute
		{
		get { 
			/*2.0.abs()*/
			return Math.Abs(2.0);
		}
		}
		public virtual double real_maximum
		{
		get { 
			/*2.0.max(3.0)*/
			return Math.Max(2.0, 3.0);
		}
		}
		public virtual double _RealLiteralExp
		{
		get { 
			/*1.2*/
			return 1.2;
		}
		}
		public virtual int let3
		{
		get { 
			/* let income : ecore::EInt = 13 * 24 in
							income*10*/
			return ((Func<int>)(() => { var income = 13 * 24; return income * 10; }))();
			;
		}
		}
		public virtual int orderedset_size
		{
		get { 
			/*orderedset->size()*/
			return this.orderedset.size();
		}
		}
		public virtual string string_replaceAll
		{
		get { 
			/*'hello '.replaceAll('h','b')*/
			return "hello ".Replace("h", "b");
		}
		}
		public virtual double integer_division
		{
		get { 
			/*2/3*/
			return 2 / 3;
		}
		}
		public virtual bool integer_greaterequals
		{
		get { 
			/*2>=3*/
			return 2 >= 3;
		}
		}
		public virtual bool integer_lessthan
		{
		get { 
			/*2<3*/
			return 2 < 3;
		}
		}
		public virtual string string_addition
		{
		get { 
			/*'hello '+'world'*/
			return "hello " + "world";
		}
		}
		public virtual string string_concat
		{
		get { 
			/*'hello '.concat('world')*/
			return "hello " + "world";
		}
		}
		public virtual double real_floor
		{
		get { 
			/*2.0.floor()*/
			return Math.Floor(2.0);
		}
		}
		public virtual bool real_lessequals
		{
		get { 
			/*(2.0)<=(3.0)*/
			return 2.0 <= 3.0;
		}
		}
		public virtual string boolean_toString
		{
		get { 
			/*true.toString()*/
			return true.ToString();
		}
		}
		public virtual string string_at
		{
		get { 
			/*'a'.at(0)*/
			return "a"[0]+"";
		}
		}
		public virtual double real_addition
		{
		get { 
			/*(2.0)+(3.0)*/
			return 2.0 + 3.0;
		}
		}
		public virtual bool real_lessthan
		{
		get { 
			/*(2.0)<(3.0)*/
			return 2.0 < 3.0;
		}
		}
		public virtual bool boolean_not
		{
		get { 
			/*not true*/
			return ! true;
		}
		}
		public virtual bool string_lessthan
		{
		get { 
			/*'a' < 'b'*/
			return "a".CompareTo("b") < 0;
		}
		}
		public virtual bool string_greaterequals
		{
		get { 
			/*'a' >= 'b'*/
			return "a".CompareTo("b") >= 0;
		}
		}
		public virtual int integer_minimum
		{
		get { 
			/*2.min(2)*/
			return Math.Min(2, 2);
		}
		}
		public virtual bool integer_lessequals
		{
		get { 
			/*2<=3*/
			return 2 <= 3;
		}
		}
		public virtual bool string_unequal
		{
		get { 
			/*'a' <> 'b'*/
			return "a" != "b";
		}
		}
		public virtual int _InfixExp_NOT_PASSING_DUE_TO_BUG_IN_OCLHELPER
		{
		get { 
			/*1+(2)*/
			return 1 + 2;
		}
		}
		public virtual bool _BooleanLiteralExp
		{
		get { 
			/*true*/
			return true;
		}
		}
		private Bag<int> _integer_sequence;
		
		public virtual Bag<int> integer_sequence
		{
			get {
				if(_integer_sequence==null){
					_integer_sequence = new Bag<int>();
				}
				return _integer_sequence;
			}
			set { _integer_sequence = value; }
		}
		public virtual bool boolean_and
		{
		get { 
			/*true and true*/
			return true && true;
		}
		}
		public virtual bool real_greaterequals
		{
		get { 
			/*(2.0)>=(3.0)*/
			return 2.0 >= 3.0;
		}
		}
		public virtual int sequence_count
		{
		get { 
			/*integer_sequence->count(3)*/
			return this.integer_sequence.count(3);
		}
		}
		
		public virtual Sequence<int> sequence_selectByType
		{
			get {
				/*OCL: Sequence{4, 4, 5.0, 'test'}->selectByType(Integer)*/
				return new Sequence<object>{
				4, 
					
				4, 
					
				5.0, 
					
				"test"
					
				}
				.selectByType<int>();
			}
		}
		public virtual int integer_absolute
		{
		get { 
			/*2.abs()*/
			return Math.Abs(2);
		}
		}
		public virtual int string_compareTo
		{
		get { 
			/*0*/
			return 0;
		}
		}
		public virtual double real_division
		{
		get { 
			/*(2.0)/(3.0)*/
			return 2.0 / 3.0;
		}
		}
		public virtual string real_toString
		{
		get { 
			/*2.1.toString()*/
			return 2.1.ToString();
		}
		}
		public virtual bool boolean_implies
		{
		get { 
			/*true implies true*/
			return ! true || true;
		}
		}
		public virtual bool string_greaterthan
		{
		get { 
			/*'a' > 'b'*/
			return "a".CompareTo("b") > 0;
		}
		}
		public virtual int string_lastIndexOf
		{
		get { 
			/*'hello '.indexOf('l')*/
			return "hello ".IndexOf("l");
		}
		}
		public virtual bool boolean_equal
		{
		get { 
			/*true = false*/
			return true == false;
		}
		}
		public virtual double real_multiplication
		{
		get { 
			/*(2.0)*(3.0)*/
			return 2.0 * 3.0;
		}
		}
		public virtual double real_subtraction
		{
		get { 
			/*(2.0)-(3.0)*/
			return 2.0 - 3.0;
		}
		}
		public virtual int _IfExp
		{
		get { 
			/*if true then 1 else 0 endif*/
			return true ? 1 : 0;
		}
		}
		public virtual string _StringLiteralExp
		{
		get { 
			/*'string'*/
			return "string";
		}
		}
		public virtual bool string_equalsIgnoreCase
		{
		get { 
			/*'hello '.equalsIgnoreCase('HELLO')*/
			return String.Equals("hello ", "HELLO", StringComparison.OrdinalIgnoreCase);
		}
		}
		public virtual bool real_greaterthan
		{
		get { 
			/*(2.0) > (3.0)*/
			return 2.0 > 3.0;
		}
		}
		public virtual string integer_toString
		{
		get { 
			/*2.toString()*/
			return 2.ToString();
		}
		}
		public virtual int string_size
		{
		get { 
			/*'hello'.size()*/
			return "hello".Count();
		}
		}
		public virtual int integer_subtraction
		{
		get { 
			/*2-3*/
			return 2 - 3;
		}
		}
		public virtual bool boolean_or
		{
		get { 
			/*true or false*/
			return true || false;
		}
		}
		public virtual int integer_multiplication
		{
		get { 
			/*2*3*/
			return 2 * 3;
		}
		}
		public virtual int _IntegerLiteralExp
		{
		get { 
			/*1*/
			return 1;
		}
		}
		public virtual bool let
		{
		get { 
			/*let a : String = 'a', b: String = 'b' in a<> b*/
			return ((Func<bool>)(() => { var a = "a"; var b = "b"; return a != b;}))();
			;
		}
		}
		public virtual bool string_lessequals
		{
		get { 
			/*'a' <= 'b'*/
			return "a".CompareTo("b") <= 0;
		}
		}
		public virtual bool string_equal
		{
		get { 
			/*'a' = 'b'*/
			return "a" == "b";
		}
		}
		private Sequence<MyClass> _sequence;
		
		public virtual Sequence<MyClass> sequence
		{
			get {
				if(_sequence==null){
					_sequence = new Sequence<MyClass>(this, OcltestmodelPackageImpl.MYCLASS_SEQUENCE, EOPPOSITE_FEATURE_BASE - OcltestmodelPackageImpl.MYCLASS_SEQUENCE);
				}
				return _sequence;
			}
		
		}
		private OrderedSet<MyClass> _orderedset;
		
		public virtual OrderedSet<MyClass> orderedset
		{
			get {
				if(_orderedset==null){
					_orderedset = new OrderedSet<MyClass>(this, OcltestmodelPackageImpl.MYCLASS_ORDEREDSET, EOPPOSITE_FEATURE_BASE - OcltestmodelPackageImpl.MYCLASS_ORDEREDSET);
				}
				return _orderedset;
			}
		
		}
		private Bag<MyClass> _bag;
		
		public virtual Bag<MyClass> bag
		{
			get {
				if(_bag==null){
					_bag = new Bag<MyClass>(this, OcltestmodelPackageImpl.MYCLASS_BAG, EOPPOSITE_FEATURE_BASE - OcltestmodelPackageImpl.MYCLASS_BAG);
				}
				return _bag;
			}
		
		}
		public virtual MyClass _NullExp
		{
			get {
			
				/*OCL: null*/
				return null;
			}
		}
		public virtual MyClass orderedset_at
		{
			get {
			
				/*OCL: orderedset->at(1)*/
				return this.orderedset.at(1);
			}
		}
		private Set<MyClass> _set;
		
		public virtual Set<MyClass> set
		{
			get {
				if(_set==null){
					_set = new Set<MyClass>(this, OcltestmodelPackageImpl.MYCLASS_SET, EOPPOSITE_FEATURE_BASE - OcltestmodelPackageImpl.MYCLASS_SET);
				}
				return _set;
			}
		
		}
		
		public virtual OrderedSet<MyClass> orderedset_select
		{
			get {
				/*OCL: orderedset->select(true)*/
				return this.orderedset.select(temp1 => true);
			}
		
		}
		public virtual MyClass _SelfExp
		{
			get {
			
				/*OCL: self*/
				return this;
			}
		}
	
		/*
		public static Set<MyClass> allInstances(){
			throw new NotImplementedException();
		}
		*/
		
		protected override EClass eStaticClass() {
			return OcltestmodelPackageImpl.Literals.MYCLASS;
		}
		
		
		
		public override Object eGet(int featureID, bool resolve, bool coreType) {
			switch (featureID) {
				case OcltestmodelPackageImpl.MYCLASS_STATIC_SEQUENCE:
					return static_sequence;
				case OcltestmodelPackageImpl.MYCLASS_COLLECTION_LITERALS:
					return collection_literals;
				case OcltestmodelPackageImpl.MYCLASS_BOOLEAN_UNEQUAL:
					return boolean_unequal;
				case OcltestmodelPackageImpl.MYCLASS_BOOLEAN_EQUAL:
					return boolean_equal;
				case OcltestmodelPackageImpl.MYCLASS_BOOLEAN_AND:
					return boolean_and;
				case OcltestmodelPackageImpl.MYCLASS_BOOLEAN_IMPLIES:
					return boolean_implies;
				case OcltestmodelPackageImpl.MYCLASS_BOOLEAN_NOT:
					return boolean_not;
				case OcltestmodelPackageImpl.MYCLASS_BOOLEAN_OR:
					return boolean_or;
				case OcltestmodelPackageImpl.MYCLASS_BOOLEAN_XOR:
					return boolean_xor;
				case OcltestmodelPackageImpl.MYCLASS_BOOLEAN_TOSTRING:
					return boolean_toString;
				case OcltestmodelPackageImpl.MYCLASS_INTEGER_MULTIPLICATION:
					return integer_multiplication;
				case OcltestmodelPackageImpl.MYCLASS_INTEGER_ADDITION:
					return integer_addition;
				case OcltestmodelPackageImpl.MYCLASS_INTEGER_SUBTRACTION:
					return integer_subtraction;
				case OcltestmodelPackageImpl.MYCLASS_INTEGER_LESSTHAN:
					return integer_lessthan;
				case OcltestmodelPackageImpl.MYCLASS_INTEGER_GREATERTHAN:
					return integer_greaterthan;
				case OcltestmodelPackageImpl.MYCLASS_INTEGER_GREATEREQUALS:
					return integer_greaterequals;
				case OcltestmodelPackageImpl.MYCLASS_INTEGER_LESSEQUALS:
					return integer_lessequals;
				case OcltestmodelPackageImpl.MYCLASS_INTEGER_DIVISION:
					return integer_division;
				case OcltestmodelPackageImpl.MYCLASS_INTEGER_ABSOLUTE:
					return integer_absolute;
				case OcltestmodelPackageImpl.MYCLASS_INTEGER_MAXIMUM:
					return integer_maximum;
				case OcltestmodelPackageImpl.MYCLASS_INTEGER_MINIMUM:
					return integer_minimum;
				case OcltestmodelPackageImpl.MYCLASS_INTEGER_MODULO:
					return integer_modulo;
				case OcltestmodelPackageImpl.MYCLASS_INTEGER_TOSTRING:
					return integer_toString;
				case OcltestmodelPackageImpl.MYCLASS_REAL_MULTIPLICATION:
					return real_multiplication;
				case OcltestmodelPackageImpl.MYCLASS_REAL_ADDITION:
					return real_addition;
				case OcltestmodelPackageImpl.MYCLASS_REAL_SUBTRACTION:
					return real_subtraction;
				case OcltestmodelPackageImpl.MYCLASS_REAL_LESSTHAN:
					return real_lessthan;
				case OcltestmodelPackageImpl.MYCLASS_REAL_GREATERTHAN:
					return real_greaterthan;
				case OcltestmodelPackageImpl.MYCLASS_REAL_GREATEREQUALS:
					return real_greaterequals;
				case OcltestmodelPackageImpl.MYCLASS_REAL_LESSEQUALS:
					return real_lessequals;
				case OcltestmodelPackageImpl.MYCLASS_REAL_DIVISION:
					return real_division;
				case OcltestmodelPackageImpl.MYCLASS_REAL_ABSOLUTE:
					return real_absolute;
				case OcltestmodelPackageImpl.MYCLASS_REAL_MAXIMUM:
					return real_maximum;
				case OcltestmodelPackageImpl.MYCLASS_REAL_MINIMUM:
					return real_minimum;
				case OcltestmodelPackageImpl.MYCLASS_REAL_FLOOR:
					return real_floor;
				case OcltestmodelPackageImpl.MYCLASS_REAL_TOSTRING:
					return real_toString;
				case OcltestmodelPackageImpl.MYCLASS_STRING_ADDITION:
					return string_addition;
				case OcltestmodelPackageImpl.MYCLASS_STRING_LESSTHAN:
					return string_lessthan;
				case OcltestmodelPackageImpl.MYCLASS_STRING_LESSEQUALS:
					return string_lessequals;
				case OcltestmodelPackageImpl.MYCLASS_STRING_UNEQUAL:
					return string_unequal;
				case OcltestmodelPackageImpl.MYCLASS_STRING_EQUAL:
					return string_equal;
				case OcltestmodelPackageImpl.MYCLASS_STRING_GREATERTHAN:
					return string_greaterthan;
				case OcltestmodelPackageImpl.MYCLASS_STRING_GREATEREQUALS:
					return string_greaterequals;
				case OcltestmodelPackageImpl.MYCLASS_STRING_AT:
					return string_at;
				case OcltestmodelPackageImpl.MYCLASS_STRING_COMPARETO:
					return string_compareTo;
				case OcltestmodelPackageImpl.MYCLASS_STRING_CONCAT:
					return string_concat;
				case OcltestmodelPackageImpl.MYCLASS_STRING_EQUALSIGNORECASE:
					return string_equalsIgnoreCase;
				case OcltestmodelPackageImpl.MYCLASS_STRING_INDEXOF:
					return string_indexOf;
				case OcltestmodelPackageImpl.MYCLASS_STRING_LASTINDEXOF:
					return string_lastIndexOf;
				case OcltestmodelPackageImpl.MYCLASS_STRING_REPLACEALL:
					return string_replaceAll;
				case OcltestmodelPackageImpl.MYCLASS_STRING_SIZE:
					return string_size;
				case OcltestmodelPackageImpl.MYCLASS_LET2:
					return let2;
				case OcltestmodelPackageImpl.MYCLASS_LET3:
					return let3;
				case OcltestmodelPackageImpl.MYCLASS_UNEMPLOYED:
					return unEmployed;
				case OcltestmodelPackageImpl.MYCLASS_LET:
					return let;
				case OcltestmodelPackageImpl.MYCLASS_ORDEREDSET:
					return orderedset;
				case OcltestmodelPackageImpl.MYCLASS_SET:
					return set;
				case OcltestmodelPackageImpl.MYCLASS_SEQUENCE:
					return sequence;
				case OcltestmodelPackageImpl.MYCLASS_INTEGER_SEQUENCE:
					return integer_sequence;
				case OcltestmodelPackageImpl.MYCLASS_BAG:
					return bag;
				case OcltestmodelPackageImpl.MYCLASS_SEQUENCE_SELECTBYKIND:
					return sequence_selectByKind;
				case OcltestmodelPackageImpl.MYCLASS_SEQUENCE_SELECTBYTYPE:
					return sequence_selectByType;
				case OcltestmodelPackageImpl.MYCLASS_TUPLE_LITERAL:
					return tuple_literal;
				case OcltestmodelPackageImpl.MYCLASS_ORDEREDSET_SELECT:
					return orderedset_select;
				case OcltestmodelPackageImpl.MYCLASS_ORDEREDSET_SIZE:
					return orderedset_size;
				case OcltestmodelPackageImpl.MYCLASS_SEQUENCE_COUNT:
					return sequence_count;
				case OcltestmodelPackageImpl.MYCLASS_ORDEREDSET_AT:
					return orderedset_at;
				case OcltestmodelPackageImpl.MYCLASS__SELFEXP:
					return _SelfExp;
				case OcltestmodelPackageImpl.MYCLASS__INTEGERLITERALEXP:
					return _IntegerLiteralExp;
				case OcltestmodelPackageImpl.MYCLASS__INFIXEXP_NOT_PASSING_DUE_TO_BUG_IN_OCLHELPER:
					return _InfixExp_NOT_PASSING_DUE_TO_BUG_IN_OCLHELPER;
				case OcltestmodelPackageImpl.MYCLASS__STRINGLITERALEXP:
					return _StringLiteralExp;
				case OcltestmodelPackageImpl.MYCLASS__BOOLEANLITERALEXP:
					return _BooleanLiteralExp;
				case OcltestmodelPackageImpl.MYCLASS__REALLITERALEXP:
					return _RealLiteralExp;
				case OcltestmodelPackageImpl.MYCLASS__NUMBERLITERALEXP:
					return _NumberLiteralExp;
				case OcltestmodelPackageImpl.MYCLASS__NULLEXP:
					return _NullExp;
				case OcltestmodelPackageImpl.MYCLASS__IFEXP:
					return _IfExp;
			}
			return base.eGet(featureID, resolve, coreType);
		}
		
		
		public override void eSet(int featureID, object newValue) {
			switch (featureID) {
				case OcltestmodelPackageImpl.MYCLASS_UNEMPLOYED:
					unEmployed = (bool) newValue;
					return;
				case OcltestmodelPackageImpl.MYCLASS_ORDEREDSET:
					orderedset.Clear();
					orderedset.AddRange((IEnumerable<MyClass>)newValue);
					return;
				case OcltestmodelPackageImpl.MYCLASS_SET:
					set.Clear();
					set.AddRange((IEnumerable<MyClass>)newValue);
					return;
				case OcltestmodelPackageImpl.MYCLASS_SEQUENCE:
					sequence.Clear();
					sequence.AddRange((IEnumerable<MyClass>)newValue);
					return;
				case OcltestmodelPackageImpl.MYCLASS_INTEGER_SEQUENCE:
					integer_sequence.Clear();
					integer_sequence.AddRange((IEnumerable<int>)newValue);
					return;
				case OcltestmodelPackageImpl.MYCLASS_BAG:
					bag.Clear();
					bag.AddRange((IEnumerable<MyClass>)newValue);
					return;
			}
			base.eSet(featureID, newValue);
		}
		
	}
}
