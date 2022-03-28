// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support
{

    public partial struct ScanLevelType :
        System.IEquatable<ScanLevelType>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.ScanLevelType Full = @"Full";

        public static Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.ScanLevelType Incremental = @"Incremental";

        /// <summary>the value for an instance of the <see cref="ScanLevelType" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to ScanLevelType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ScanLevelType" />.</param>
        internal static object CreateFrom(object value)
        {
            return new ScanLevelType(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type ScanLevelType</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.ScanLevelType e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type ScanLevelType (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is ScanLevelType && Equals((ScanLevelType)obj);
        }

        /// <summary>Returns hashCode for enum ScanLevelType</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="ScanLevelType" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private ScanLevelType(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for ScanLevelType</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to ScanLevelType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ScanLevelType" />.</param>

        public static implicit operator ScanLevelType(string value)
        {
            return new ScanLevelType(value);
        }

        /// <summary>Implicit operator to convert ScanLevelType to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="ScanLevelType" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.ScanLevelType e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum ScanLevelType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.ScanLevelType e1, Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.ScanLevelType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum ScanLevelType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.ScanLevelType e1, Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.ScanLevelType e2)
        {
            return e2.Equals(e1);
        }
    }
}