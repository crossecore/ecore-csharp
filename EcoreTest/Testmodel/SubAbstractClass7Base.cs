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
	public class SubAbstractClass7Base 
	:SubAbstractClass1Impl, SubAbstractClass7
	{
	
		/*
		public static Set<SubAbstractClass7> allInstances(){
			throw new NotImplementedException();
		}
		*/
		
		protected override EClass eStaticClass() {
			return TestmodelPackageImpl.Literals.SUBABSTRACTCLASS7;
		}
		
		
		
		public override Object eGet(int featureID, bool resolve, bool coreType) {
			switch (featureID) {
			}
			return base.eGet(featureID, resolve, coreType);
		}
		
	}
}
