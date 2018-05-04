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
	
	public interface MyClass 
	: EObject
	{
		Sequence<int> static_sequence
		{
			get;
		}
		Sequence<int> collection_literals
		{
			get;
		}
		bool boolean_unequal
		{
			get;
		}
		bool boolean_equal
		{
			get;
		}
		bool boolean_and
		{
			get;
		}
		bool boolean_implies
		{
			get;
		}
		bool boolean_not
		{
			get;
		}
		bool boolean_or
		{
			get;
		}
		bool boolean_xor
		{
			get;
		}
		string boolean_toString
		{
			get;
		}
		int integer_multiplication
		{
			get;
		}
		int integer_addition
		{
			get;
		}
		int integer_subtraction
		{
			get;
		}
		bool integer_lessthan
		{
			get;
		}
		bool integer_greaterthan
		{
			get;
		}
		bool integer_greaterequals
		{
			get;
		}
		bool integer_lessequals
		{
			get;
		}
		double integer_division
		{
			get;
		}
		int integer_absolute
		{
			get;
		}
		int integer_maximum
		{
			get;
		}
		int integer_minimum
		{
			get;
		}
		int integer_modulo
		{
			get;
		}
		string integer_toString
		{
			get;
		}
		double real_multiplication
		{
			get;
		}
		double real_addition
		{
			get;
		}
		double real_subtraction
		{
			get;
		}
		bool real_lessthan
		{
			get;
		}
		bool real_greaterthan
		{
			get;
		}
		bool real_greaterequals
		{
			get;
		}
		bool real_lessequals
		{
			get;
		}
		double real_division
		{
			get;
		}
		double real_absolute
		{
			get;
		}
		double real_maximum
		{
			get;
		}
		double real_minimum
		{
			get;
		}
		double real_floor
		{
			get;
		}
		string real_toString
		{
			get;
		}
		string string_addition
		{
			get;
		}
		bool string_lessthan
		{
			get;
		}
		bool string_lessequals
		{
			get;
		}
		bool string_unequal
		{
			get;
		}
		bool string_equal
		{
			get;
		}
		bool string_greaterthan
		{
			get;
		}
		bool string_greaterequals
		{
			get;
		}
		string string_at
		{
			get;
		}
		int string_compareTo
		{
			get;
		}
		string string_concat
		{
			get;
		}
		bool string_equalsIgnoreCase
		{
			get;
		}
		int string_indexOf
		{
			get;
		}
		int string_lastIndexOf
		{
			get;
		}
		string string_replaceAll
		{
			get;
		}
		int string_size
		{
			get;
		}
		bool let2
		{
			get;
		}
		int let3
		{
			get;
		}
		bool unEmployed
		{
			get;
		set;
		}
		bool let
		{
			get;
		}
		OrderedSet<MyClass> orderedset
		{
			get;
		
		}
		Set<MyClass> set
		{
			get;
		
		}
		Sequence<MyClass> sequence
		{
			get;
		
		}
		Bag<int> integer_sequence
		{
			get;
			set;
		}
		Bag<MyClass> bag
		{
			get;
		
		}
		Sequence<int> sequence_selectByKind
		{
			get;
		}
		Sequence<int> sequence_selectByType
		{
			get;
		}
		bool tuple_literal
		{
			get;
		}
		OrderedSet<MyClass> orderedset_select
		{
			get;
		
		}
		int orderedset_size
		{
			get;
		}
		int sequence_count
		{
			get;
		}
		
		MyClass orderedset_at
		{
			get;
		}
		
		MyClass _SelfExp
		{
			get;
		}
		int _IntegerLiteralExp
		{
			get;
		}
		int _InfixExp_NOT_PASSING_DUE_TO_BUG_IN_OCLHELPER
		{
			get;
		}
		string _StringLiteralExp
		{
			get;
		}
		bool _BooleanLiteralExp
		{
			get;
		}
		double _RealLiteralExp
		{
			get;
		}
		double _NumberLiteralExp
		{
			get;
		}
		
		MyClass _NullExp
		{
			get;
		}
		int _IfExp
		{
			get;
		}
	}
}
