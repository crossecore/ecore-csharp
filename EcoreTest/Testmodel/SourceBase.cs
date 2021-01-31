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
	public class SourceBase 
	:BasicEObjectImpl, Source
	{
		private Target _zero_one_no_yes;
		public virtual Target zero_one_no_yes
		{
			get {
			
				return _zero_one_no_yes;
			}
			set {
				if (value != _zero_one_no_yes) {
					NotificationChain msgs = null;
					if (_zero_one_no_yes != null){
						msgs = ((InternalEObject)_zero_one_no_yes).eInverseRemove(this, EOPPOSITE_FEATURE_BASE - TestmodelPackageImpl.SOURCE_ZERO_ONE_NO_YES, null, msgs);
					}
					if (value != null){
						msgs = ((InternalEObject)value).eInverseAdd(this, EOPPOSITE_FEATURE_BASE - TestmodelPackageImpl.SOURCE_ZERO_ONE_NO_YES, null, msgs);
					}
					msgs = basicSetZero_one_no_yes(value, msgs);
					if (msgs != null) {
						msgs.dispatch();
					}
				}
				else if (eNotificationRequired()){
					eNotify(new ENotificationImpl(this, NotificationImpl.SET,TestmodelPackageImpl.SOURCE_ZERO_ONE_NO_YES , value, value));
				}
				}
		}
		private Set<Target> _many_many_no_no;
		
		public virtual Set<Target> many_many_no_no
		{
			get {
				if(_many_many_no_no==null){
					_many_many_no_no = new Set<Target>(this, TestmodelPackageImpl.SOURCE_MANY_MANY_NO_NO, TestmodelPackageImpl.TARGET_MANY_MANY_NO_NO);
				}
				return _many_many_no_no;
			}
		
		}
		private Set<Target> _zero_many_no_no;
		
		public virtual Set<Target> zero_many_no_no
		{
			get {
				if(_zero_many_no_no==null){
					_zero_many_no_no = new Set<Target>(this, TestmodelPackageImpl.SOURCE_ZERO_MANY_NO_NO, EOPPOSITE_FEATURE_BASE - TestmodelPackageImpl.SOURCE_ZERO_MANY_NO_NO);
				}
				return _zero_many_no_no;
			}
		
		}
		private Target _one_one_no_yes;
		public virtual Target one_one_no_yes
		{
			get {
			
				return _one_one_no_yes;
			}
			set {
				if (value != _one_one_no_yes) {
					NotificationChain msgs = null;
					if (_one_one_no_yes != null){
						msgs = ((InternalEObject)_one_one_no_yes).eInverseRemove(this, TestmodelPackageImpl.TARGET_ONE_ONE_NO_YES, typeof(Source), msgs);
					}
					if (value != null){
						msgs = ((InternalEObject)value).eInverseAdd(this, TestmodelPackageImpl.TARGET_ONE_ONE_NO_YES, typeof(Source), msgs);
					}
					msgs = basicSetOne_one_no_yes(value, msgs);
					if (msgs != null) {
						msgs.dispatch();
					}
				}
				else if (eNotificationRequired()){
					eNotify(new ENotificationImpl(this, NotificationImpl.SET,TestmodelPackageImpl.SOURCE_ONE_ONE_NO_YES , value, value));
				}
				}
		}
		private Set<Target> _one_many_no_no;
		
		public virtual Set<Target> one_many_no_no
		{
			get {
				if(_one_many_no_no==null){
					_one_many_no_no = new Set<Target>(this, TestmodelPackageImpl.SOURCE_ONE_MANY_NO_NO, TestmodelPackageImpl.TARGET_ONE_MANY_NO_NO);
				}
				return _one_many_no_no;
			}
		
		}
		private Set<Target> _one_many_no_yes;
		
		public virtual Set<Target> one_many_no_yes
		{
			get {
				if(_one_many_no_yes==null){
					_one_many_no_yes = new Set<Target>(this, TestmodelPackageImpl.SOURCE_ONE_MANY_NO_YES, TestmodelPackageImpl.TARGET_ONE_MANY_NO_YES);
				}
				return _one_many_no_yes;
			}
		
		}
		private Target _one_one_no_no;
		public virtual Target one_one_no_no
		{
			get {
			
				return _one_one_no_no;
			}
			set {
				if (value != _one_one_no_no) {
					NotificationChain msgs = null;
					if (_one_one_no_no != null){
						msgs = ((InternalEObject)_one_one_no_no).eInverseRemove(this, TestmodelPackageImpl.TARGET_ONE_ONE_NO_NO, typeof(Source), msgs);
					}
					if (value != null){
						msgs = ((InternalEObject)value).eInverseAdd(this, TestmodelPackageImpl.TARGET_ONE_ONE_NO_NO, typeof(Source), msgs);
					}
					msgs = basicSetOne_one_no_no(value, msgs);
					if (msgs != null) {
						msgs.dispatch();
					}
				}
				else if (eNotificationRequired()){
					eNotify(new ENotificationImpl(this, NotificationImpl.SET,TestmodelPackageImpl.SOURCE_ONE_ONE_NO_NO , value, value));
				}
				}
		}
		private Set<Target> _zero_many_no_yes;
		
		public virtual Set<Target> zero_many_no_yes
		{
			get {
				if(_zero_many_no_yes==null){
					_zero_many_no_yes = new Set<Target>(this, TestmodelPackageImpl.SOURCE_ZERO_MANY_NO_YES, EOPPOSITE_FEATURE_BASE - TestmodelPackageImpl.SOURCE_ZERO_MANY_NO_YES);
				}
				return _zero_many_no_yes;
			}
		
		}
		private Target _zero_one_no_no;
		public virtual Target zero_one_no_no
		{
			get {
			
				return _zero_one_no_no;
			}
			set {
				var oldvalue = _zero_one_no_no;
				_zero_one_no_no = value;
				if (eNotificationRequired()){
					eNotify(new ENotificationImpl(this, NotificationImpl.SET,TestmodelPackageImpl.SOURCE_ZERO_ONE_NO_NO , oldvalue, value));
				}
				}
		}
	
		/*
		public static Set<Source> allInstances(){
			throw new NotImplementedException();
		}
		*/
		
		protected override EClass eStaticClass() {
			return TestmodelPackageImpl.Literals.SOURCE;
		}
		
		public override NotificationChain eInverseAdd(InternalEObject otherEnd, int featureID, NotificationChain msgs) {
			switch (featureID) {
				case TestmodelPackageImpl.SOURCE_MANY_MANY_NO_NO:
					return many_many_no_no.basicAdd((Target)otherEnd, msgs);
				case TestmodelPackageImpl.SOURCE_ONE_ONE_NO_YES:
					if (_one_one_no_yes != null){
						msgs = ((InternalEObject)_one_one_no_yes).eInverseRemove(this, TestmodelPackageImpl.SOURCE_ONE_ONE_NO_YES, typeof(Target), msgs);
					}
					return basicSetOne_one_no_yes((Target)otherEnd, msgs);
				case TestmodelPackageImpl.SOURCE_ONE_MANY_NO_NO:
					return one_many_no_no.basicAdd((Target)otherEnd, msgs);
				case TestmodelPackageImpl.SOURCE_ONE_MANY_NO_YES:
					return one_many_no_yes.basicAdd((Target)otherEnd, msgs);
				case TestmodelPackageImpl.SOURCE_ONE_ONE_NO_NO:
					if (_one_one_no_no != null){
						msgs = ((InternalEObject)_one_one_no_no).eInverseRemove(this, TestmodelPackageImpl.SOURCE_ONE_ONE_NO_NO, typeof(Target), msgs);
					}
					return basicSetOne_one_no_no((Target)otherEnd, msgs);
			}
			return base.eInverseAdd(otherEnd, featureID, msgs);
		}
		
		public override NotificationChain eInverseRemove(InternalEObject otherEnd, int featureID, NotificationChain msgs) {
			switch (featureID) {
				case TestmodelPackageImpl.SOURCE_MANY_MANY_NO_NO:
					return many_many_no_no.basicRemove((Target)otherEnd, msgs);
				case TestmodelPackageImpl.SOURCE_ONE_ONE_NO_YES:
					return basicSetOne_one_no_yes(null, msgs);
				case TestmodelPackageImpl.SOURCE_ONE_MANY_NO_NO:
					return one_many_no_no.basicRemove((Target)otherEnd, msgs);
				case TestmodelPackageImpl.SOURCE_ONE_MANY_NO_YES:
					return one_many_no_yes.basicRemove((Target)otherEnd, msgs);
				case TestmodelPackageImpl.SOURCE_ONE_ONE_NO_NO:
					return basicSetOne_one_no_no(null, msgs);
			}
			return base.eInverseRemove(otherEnd, featureID, msgs);
		}
		
		public NotificationChain basicSetZero_one_no_yes(Target newobj, NotificationChain msgs) {
			var oldobj = _zero_one_no_yes;
			_zero_one_no_yes = newobj;
			if (eNotificationRequired()) {
				var notification = new ENotificationImpl(this, NotificationImpl.SET, TestmodelPackageImpl.SOURCE_ZERO_ONE_NO_YES, oldobj, newobj);
				if (msgs == null){
					msgs = notification;
				}
				else{
					msgs.add(notification);
				}
			}
			return msgs;
		}
		public NotificationChain basicSetOne_one_no_yes(Target newobj, NotificationChain msgs) {
			var oldobj = _one_one_no_yes;
			_one_one_no_yes = newobj;
			if (eNotificationRequired()) {
				var notification = new ENotificationImpl(this, NotificationImpl.SET, TestmodelPackageImpl.SOURCE_ONE_ONE_NO_YES, oldobj, newobj);
				if (msgs == null){
					msgs = notification;
				}
				else{
					msgs.add(notification);
				}
			}
			return msgs;
		}
		public NotificationChain basicSetOne_one_no_no(Target newobj, NotificationChain msgs) {
			var oldobj = _one_one_no_no;
			_one_one_no_no = newobj;
			if (eNotificationRequired()) {
				var notification = new ENotificationImpl(this, NotificationImpl.SET, TestmodelPackageImpl.SOURCE_ONE_ONE_NO_NO, oldobj, newobj);
				if (msgs == null){
					msgs = notification;
				}
				else{
					msgs.add(notification);
				}
			}
			return msgs;
		}
		public NotificationChain basicSetZero_one_no_no(Target newobj, NotificationChain msgs) {
			var oldobj = _zero_one_no_no;
			_zero_one_no_no = newobj;
			if (eNotificationRequired()) {
				var notification = new ENotificationImpl(this, NotificationImpl.SET, TestmodelPackageImpl.SOURCE_ZERO_ONE_NO_NO, oldobj, newobj);
				if (msgs == null){
					msgs = notification;
				}
				else{
					msgs.add(notification);
				}
			}
			return msgs;
		}
		
		public override Object eGet(int featureID, bool resolve, bool coreType) {
			switch (featureID) {
				case TestmodelPackageImpl.SOURCE_ZERO_ONE_NO_NO:
					return zero_one_no_no;
				case TestmodelPackageImpl.SOURCE_ZERO_MANY_NO_NO:
					return zero_many_no_no;
				case TestmodelPackageImpl.SOURCE_ZERO_ONE_NO_YES:
					return zero_one_no_yes;
				case TestmodelPackageImpl.SOURCE_ZERO_MANY_NO_YES:
					return zero_many_no_yes;
				case TestmodelPackageImpl.SOURCE_ONE_ONE_NO_NO:
					return one_one_no_no;
				case TestmodelPackageImpl.SOURCE_ONE_MANY_NO_NO:
					return one_many_no_no;
				case TestmodelPackageImpl.SOURCE_MANY_MANY_NO_NO:
					return many_many_no_no;
				case TestmodelPackageImpl.SOURCE_ONE_MANY_NO_YES:
					return one_many_no_yes;
				case TestmodelPackageImpl.SOURCE_ONE_ONE_NO_YES:
					return one_one_no_yes;
			}
			return base.eGet(featureID, resolve, coreType);
		}
		
	}
}
