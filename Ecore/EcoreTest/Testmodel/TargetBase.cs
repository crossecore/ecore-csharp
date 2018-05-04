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
	public class TargetBase 
	:BasicEObjectImpl, Target
	{
		private Source _one_many_no_no;
		public virtual Source one_many_no_no
		{
			get {
			
				return _one_many_no_no;
			}
			set {
				if (value != _one_many_no_no) {
					NotificationChain msgs = null;
					if (_one_many_no_no != null){
						msgs = ((InternalEObject)_one_many_no_no).eInverseRemove(this, TestmodelPackageImpl.SOURCE_ONE_MANY_NO_NO, typeof(Target), msgs);
					}
					if (value != null){
						msgs = ((InternalEObject)value).eInverseAdd(this, TestmodelPackageImpl.SOURCE_ONE_MANY_NO_NO, typeof(Target), msgs);
					}
					msgs = basicSetOne_many_no_no(value, msgs);
					if (msgs != null) {
						msgs.dispatch();
					}
				}
				else if (eNotificationRequired()){
					eNotify(new ENotificationImpl(this, NotificationImpl.SET,TestmodelPackageImpl.TARGET_ONE_MANY_NO_NO , value, value));
				}
				}
		}
		public virtual Source one_many_no_yes
		{
			get {
			
				if (eContainerFeatureID() != TestmodelPackageImpl.TARGET_ONE_MANY_NO_YES) return default(Source);
				return (Source)eInternalContainer();
			}
			set {
				if (value != eInternalContainer()) {
					NotificationChain msgs = null;
					if (eInternalContainer() != null){
						msgs = ((InternalEObject)eInternalContainer()).eInverseRemove(this, TestmodelPackageImpl.SOURCE_ONE_MANY_NO_YES, typeof(Target), msgs);
					}
					if (value != null){
						msgs = ((InternalEObject)value).eInverseAdd(this, TestmodelPackageImpl.SOURCE_ONE_MANY_NO_YES, typeof(Target), msgs);
					}
					msgs = basicSetOne_many_no_yes(value, msgs);
					if (msgs != null) {
						msgs.dispatch();
					}
				}
				else if (eNotificationRequired()){
					eNotify(new ENotificationImpl(this, NotificationImpl.SET,TestmodelPackageImpl.TARGET_ONE_MANY_NO_YES , value, value));
				}
				}
		}
		private Source _one_one_no_no;
		public virtual Source one_one_no_no
		{
			get {
			
				return _one_one_no_no;
			}
			set {
				if (value != _one_one_no_no) {
					NotificationChain msgs = null;
					if (_one_one_no_no != null){
						msgs = ((InternalEObject)_one_one_no_no).eInverseRemove(this, TestmodelPackageImpl.SOURCE_ONE_ONE_NO_NO, typeof(Target), msgs);
					}
					if (value != null){
						msgs = ((InternalEObject)value).eInverseAdd(this, TestmodelPackageImpl.SOURCE_ONE_ONE_NO_NO, typeof(Target), msgs);
					}
					msgs = basicSetOne_one_no_no(value, msgs);
					if (msgs != null) {
						msgs.dispatch();
					}
				}
				else if (eNotificationRequired()){
					eNotify(new ENotificationImpl(this, NotificationImpl.SET,TestmodelPackageImpl.TARGET_ONE_ONE_NO_NO , value, value));
				}
				}
		}
		public virtual Source one_one_no_yes
		{
			get {
			
				if (eContainerFeatureID() != TestmodelPackageImpl.TARGET_ONE_ONE_NO_YES) return default(Source);
				return (Source)eInternalContainer();
			}
			set {
				if (value != eInternalContainer()) {
					NotificationChain msgs = null;
					if (eInternalContainer() != null){
						msgs = ((InternalEObject)eInternalContainer()).eInverseRemove(this, TestmodelPackageImpl.SOURCE_ONE_ONE_NO_YES, typeof(Target), msgs);
					}
					if (value != null){
						msgs = ((InternalEObject)value).eInverseAdd(this, TestmodelPackageImpl.SOURCE_ONE_ONE_NO_YES, typeof(Target), msgs);
					}
					msgs = basicSetOne_one_no_yes(value, msgs);
					if (msgs != null) {
						msgs.dispatch();
					}
				}
				else if (eNotificationRequired()){
					eNotify(new ENotificationImpl(this, NotificationImpl.SET,TestmodelPackageImpl.TARGET_ONE_ONE_NO_YES , value, value));
				}
				}
		}
		private Set<Source> _many_many_no_no;
		
		public virtual Set<Source> many_many_no_no
		{
			get {
				if(_many_many_no_no==null){
					_many_many_no_no = new Set<Source>(this, TestmodelPackageImpl.TARGET_MANY_MANY_NO_NO, TestmodelPackageImpl.SOURCE_MANY_MANY_NO_NO);
				}
				return _many_many_no_no;
			}
		
		}
	
		/*
		public static Set<Target> allInstances(){
			throw new NotImplementedException();
		}
		*/
		
		protected override EClass eStaticClass() {
			return TestmodelPackageImpl.Literals.TARGET;
		}
		
		public override NotificationChain eInverseAdd(InternalEObject otherEnd, int featureID, NotificationChain msgs) {
			switch (featureID) {
				case TestmodelPackageImpl.TARGET_ONE_MANY_NO_NO:
					if (_one_many_no_no != null){
						msgs = ((InternalEObject)_one_many_no_no).eInverseRemove(this, TestmodelPackageImpl.TARGET_ONE_MANY_NO_NO, typeof(Source), msgs);
					}
					return basicSetOne_many_no_no((Source)otherEnd, msgs);
				case TestmodelPackageImpl.TARGET_ONE_MANY_NO_YES:
					if (eInternalContainer() != null) {
						msgs = eBasicRemoveFromContainer(msgs);
					}
					return basicSetOne_many_no_yes((Source)otherEnd, msgs);
				case TestmodelPackageImpl.TARGET_ONE_ONE_NO_NO:
					if (_one_one_no_no != null){
						msgs = ((InternalEObject)_one_one_no_no).eInverseRemove(this, TestmodelPackageImpl.TARGET_ONE_ONE_NO_NO, typeof(Source), msgs);
					}
					return basicSetOne_one_no_no((Source)otherEnd, msgs);
				case TestmodelPackageImpl.TARGET_ONE_ONE_NO_YES:
					if (eInternalContainer() != null) {
						msgs = eBasicRemoveFromContainer(msgs);
					}
					return basicSetOne_one_no_yes((Source)otherEnd, msgs);
				case TestmodelPackageImpl.TARGET_MANY_MANY_NO_NO:
					return many_many_no_no.basicAdd((Source)otherEnd, msgs);
			}
			return base.eInverseAdd(otherEnd, featureID, msgs);
		}
		
		public override NotificationChain eInverseRemove(InternalEObject otherEnd, int featureID, NotificationChain msgs) {
			switch (featureID) {
				case TestmodelPackageImpl.TARGET_ONE_MANY_NO_NO:
					return basicSetOne_many_no_no(null, msgs);
				case TestmodelPackageImpl.TARGET_ONE_MANY_NO_YES:
					return basicSetOne_many_no_yes(null, msgs);
				case TestmodelPackageImpl.TARGET_ONE_ONE_NO_NO:
					return basicSetOne_one_no_no(null, msgs);
				case TestmodelPackageImpl.TARGET_ONE_ONE_NO_YES:
					return basicSetOne_one_no_yes(null, msgs);
				case TestmodelPackageImpl.TARGET_MANY_MANY_NO_NO:
					return many_many_no_no.basicRemove((Source)otherEnd, msgs);
			}
			return base.eInverseRemove(otherEnd, featureID, msgs);
		}
		
		public NotificationChain basicSetOne_many_no_no(Source newobj, NotificationChain msgs) {
			var oldobj = _one_many_no_no;
			_one_many_no_no = newobj;
			if (eNotificationRequired()) {
				var notification = new ENotificationImpl(this, NotificationImpl.SET, TestmodelPackageImpl.TARGET_ONE_MANY_NO_NO, oldobj, newobj);
				if (msgs == null){
					msgs = notification;
				}
				else{
					msgs.add(notification);
				}
			}
			return msgs;
		}
		public NotificationChain basicSetOne_many_no_yes(Source newobj, NotificationChain msgs) {
				msgs = eBasicSetContainer((InternalEObject)newobj, TestmodelPackageImpl.TARGET_ONE_MANY_NO_YES, msgs);
				return msgs;
		}
		public NotificationChain basicSetOne_one_no_no(Source newobj, NotificationChain msgs) {
			var oldobj = _one_one_no_no;
			_one_one_no_no = newobj;
			if (eNotificationRequired()) {
				var notification = new ENotificationImpl(this, NotificationImpl.SET, TestmodelPackageImpl.TARGET_ONE_ONE_NO_NO, oldobj, newobj);
				if (msgs == null){
					msgs = notification;
				}
				else{
					msgs.add(notification);
				}
			}
			return msgs;
		}
		public NotificationChain basicSetOne_one_no_yes(Source newobj, NotificationChain msgs) {
				msgs = eBasicSetContainer((InternalEObject)newobj, TestmodelPackageImpl.TARGET_ONE_ONE_NO_YES, msgs);
				return msgs;
		}
		
		public override Object eGet(int featureID, bool resolve, bool coreType) {
			switch (featureID) {
				case TestmodelPackageImpl.TARGET_ONE_ONE_NO_NO:
					return one_one_no_no;
				case TestmodelPackageImpl.TARGET_ONE_MANY_NO_NO:
					return one_many_no_no;
				case TestmodelPackageImpl.TARGET_MANY_MANY_NO_NO:
					return many_many_no_no;
				case TestmodelPackageImpl.TARGET_ONE_MANY_NO_YES:
					return one_many_no_yes;
				case TestmodelPackageImpl.TARGET_ONE_ONE_NO_YES:
					return one_one_no_yes;
			}
			return base.eGet(featureID, resolve, coreType);
		}
		
	}
}
