﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LinearVisualEncoding.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("LinearVisualEncoding.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///var hrefStates = {}
        ///
        ///$(document).ready(function(){
        ///	$( &quot;g[type=&apos;transfer&apos;]&quot; ).on( &quot;click&quot;, clickTransfer);
        ///	
        ///	$( &quot;g[type=&apos;transfer&apos;]&quot; ).each( function(){
        ///		hrefStates[$(this).attr(&quot;href&quot;)] = { &quot;read&quot; : false, &quot;animating&quot;: false };
        ///	});
        ///	
        ///	
        ///	$( &quot;.single-comment&quot; ).on( &quot;click&quot;, function(){
        ///		// try and get it from the animation
        ///		var href = $(this).attr(&quot;id&quot;);
        ///		
        ///		var visRep = $( &quot;g[id=&apos;down&apos;] &gt; g[href=&apos;&quot;+href+&quot;&apos;]&quot; )
        ///		
        ///		if( visRep.size() == 0 ){
        ///			visRep = $( &quot;g[id=&apos;base&apos;] &gt; g[href=&apos;&quot;+h [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string comment_logic {
            get {
                return ResourceManager.GetString("comment_logic", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .visual_index{
        ///	float: left;
        ///}
        ///
        ///.keys{
        ///	float: left;
        ///}
        ///.meta{
        ///	font-size: small;
        ///}
        ///.comments{
        ///	float: left;
        ///	width: 400px;
        ///	height: 400px;
        ///	overflow:scroll;
        ///	padding-right: 15px;
        ///}
        ///
        ///li {
        ///	margin-left: 0px;
        ///	padding-left: 0px;
        ///}
        ///
        ///ul { 
        ///	margin-left: 0px;
        ///	padding-left: 15px;
        ///}
        ///
        ///* {
        ///	font-family: Gotham, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif;
        ///	text-align: justify;
        ///}
        ///
        ///g[type=&apos;transfer&apos;] {
        ///	cursor: pointer;
        ///}
        ///
        ///.single-comment {
        ///	cursor: pointer;
        ///}
        ///
        ///.single-comme [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string comment_style {
            get {
                return ResourceManager.GetString("comment_style", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///var hrefStates = {}
        ///
        ///function reset(){
        ///	var min_price = Number.MAX_VALUE;
        ///	var max_price = 0;
        ///	
        ///	var min_time = Number.MAX_VALUE;
        ///	var max_time = 0;
        ///	
        ///	//reset
        ///	$(&quot;#base &gt; g[type=&apos;transfer&apos;]&quot;).each( function(){
        ///		var price = parseFloat($(this).attr(&quot;price&quot;));
        ///		
        ///		min_price = Math.min(price, min_price);
        ///		max_price = Math.max(price, max_price);
        ///		
        ///		var timeStart = parseInt($(this).attr(&quot;start&quot;));
        ///		var timeFinish = parseInt($(this).attr(&quot;finish&quot;));
        ///		
        ///		min_time = Math.min(timeStart, m [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string flight_logic {
            get {
                return ResourceManager.GetString("flight_logic", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .visual_index{
        ///	float: left;
        ///}
        ///
        ///.keys{
        ///	float: left;
        ///}
        ///.meta{
        ///	font-size: small;
        ///}
        ///.comments{
        ///	float: left;
        ///	width: 400px;
        ///	height: 400px;
        ///	overflow:scroll;
        ///	padding-right: 15px;
        ///}
        ///
        ///.tooltip {
        ///	position:absolute;
        ///	background:#F0F0FA;
        ///	padding:20px;
        ///	
        ///	-webkit-box-shadow: 5px 5px 10px 0px rgba(0,0,0,0.50);
        ///	box-shadow: 5px 5px 10px 0px rgba(0,0,0,0.50);
        ///
        ///	-moz-border-radius: 10px;
        ///	-webkit-border-radius: 10px;
        ///	border-radius: 10px; /* future proofing */
        ///	-khtml-border-radius: 10p [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string flight_style {
            get {
                return ResourceManager.GetString("flight_style", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /*!
        /// * jQuery JavaScript Library v1.11.3
        /// * http://jquery.com/
        /// *
        /// * Includes Sizzle.js
        /// * http://sizzlejs.com/
        /// *
        /// * Copyright 2005, 2014 jQuery Foundation, Inc. and other contributors
        /// * Released under the MIT license
        /// * http://jquery.org/license
        /// *
        /// * Date: 2015-04-28T16:19Z
        /// */
        ///
        ///(function( global, factory ) {
        ///
        ///	if ( typeof module === &quot;object&quot; &amp;&amp; typeof module.exports === &quot;object&quot; ) {
        ///		// For CommonJS and CommonJS-like environments where a proper window is present,
        ///		// execute the factory and get jQuer [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string jquery_1_11_3 {
            get {
                return ResourceManager.GetString("jquery_1_11_3", resourceCulture);
            }
        }
    }
}