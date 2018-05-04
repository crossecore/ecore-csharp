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
namespace Testmodel{
	
	public interface Source 
	: EObject
	{
		
		Target zero_one_no_no
		{
			get;
			set;
		}
		Set<Target> zero_many_no_no
		{
			get;
		
		}
		
		Target zero_one_no_yes
		{
			get;
			set;
		}
		Set<Target> zero_many_no_yes
		{
			get;
		
		}
		
		Target one_one_no_no
		{
			get;
			set;
		}
		Set<Target> one_many_no_no
		{
			get;
		
		}
		Set<Target> many_many_no_no
		{
			get;
		
		}
		Set<Target> one_many_no_yes
		{
			get;
		
		}
		
		Target one_one_no_yes
		{
			get;
			set;
		}
	}
}
