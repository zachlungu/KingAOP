﻿// Copyright (c) 2013 Antya Dev
//
// Permission is hereby granted, free of charge, to any person obtaining a copy of this
// software and associated documentation files (the "Software"), to deal in the Software
// without restriction, including without limitation the rights to use, copy, modify, merge,
// publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons
// to whom the Software is furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all copies or
// substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
// INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR
// PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE
// FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR
// OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
// DEALINGS IN THE SOFTWARE.

using System;
using System.Reflection;

namespace KingAOP.Aspects
{
    /// <summary>
    /// Arguments of aspect which in executing for a method.
    /// </summary>
    public sealed class MethodExecutionArgs
    {
        public MethodExecutionArgs(object instance, MethodInfo method, Arguments arguments)
        {
            Instance = instance;
            Method = method;
            Arguments = arguments;
        }

        /// <summary>
        ///  Gets the object instance on which the method is being executed.
        /// </summary>
        public object Instance { get; private set; }

        /// <summary>
        /// Gets the method being executed.
        /// </summary>
        public MethodInfo Method { get; private set; }

        /// <summary>
        /// Determines the control flow of the target method once the advice is exited.
        /// </summary>
        public FlowBehavior FlowBehavior { get; set; }

        /// <summary>
        /// Gets the arguments with which the method has been invoked.
        /// </summary>
        public Arguments Arguments { get; set; }

        /// <summary>
        /// Gets or sets the method return value.
        /// </summary>
        public object ReturnValue { get; set; }

        /// <summary>
        /// Gets the exception currently flying.
        /// </summary>
        public Exception Exception { get; set; }
    }
}