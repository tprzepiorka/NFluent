﻿// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="IFluentAssert.cs" company="">
// //   Copyright 2013 Thomas PIERRAIN
// //   Licensed under the Apache License, Version 2.0 (the "License");
// //   you may not use this file except in compliance with the License.
// //   You may obtain a copy of the License at
// //       http://www.apache.org/licenses/LICENSE-2.0
// //   Unless required by applicable law or agreed to in writing, software
// //   distributed under the License is distributed on an "AS IS" BASIS,
// //   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// //   See the License for the specific language governing permissions and
// //   limitations under the License.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------
namespace NFluent
{
    using System;

    /// <summary>
    /// Provides core assertion methods to be executed on the System Under Test (SUT) instance.
    /// </summary>
    public interface IFluentAssert
    {
        /// <summary>
        /// Checks that the actual instance is an instance of the given expected type.
        /// </summary>
        /// <param name="expectedType">The expected type.</param>
        /// <exception cref="FluentAssertionException">The actual instance is not of the expected type.</exception>
        void IsInstanceOf(Type expectedType);

        /// <summary>
        /// Checks that the actual instance is an instance of the given expected type.
        /// </summary>
        /// <typeparam name="T">The expected Type of the instance.</typeparam>
        /// <exception cref="FluentAssertionException">The actual instance is not of the expected type.</exception>
        //I IsInstanceOf<T>();

        /// <summary>
        /// Checks that the actual instance is not an instance of the given expected type.
        /// </summary>
        /// <param name="typeNotExpected">The type not expected for this instance.</param>
        /// <exception cref="FluentAssertionException">The actual instance is of the expected type.</exception>
        void IsNotInstanceOf(Type typeNotExpected);

        /// <summary>
        /// Checks that the actual instance is not an instance of the given expected type.
        /// </summary>
        /// <typeparam name="T">The type not expected for this instance.</typeparam>
        /// <exception cref="FluentAssertionException">The actual instance is not of the expected type.</exception>
        void IsNotInstanceOf<T>();
    }
}