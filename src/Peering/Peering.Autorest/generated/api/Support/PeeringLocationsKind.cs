// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Peering.Support
{

    public partial struct PeeringLocationsKind :
        System.IEquatable<PeeringLocationsKind>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Peering.Support.PeeringLocationsKind Direct = @"Direct";

        public static Microsoft.Azure.PowerShell.Cmdlets.Peering.Support.PeeringLocationsKind Exchange = @"Exchange";

        /// <summary>the value for an instance of the <see cref="PeeringLocationsKind" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to PeeringLocationsKind</summary>
        /// <param name="value">the value to convert to an instance of <see cref="PeeringLocationsKind" />.</param>
        internal static object CreateFrom(object value)
        {
            return new PeeringLocationsKind(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type PeeringLocationsKind</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Peering.Support.PeeringLocationsKind e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type PeeringLocationsKind (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is PeeringLocationsKind && Equals((PeeringLocationsKind)obj);
        }

        /// <summary>Returns hashCode for enum PeeringLocationsKind</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="PeeringLocationsKind"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private PeeringLocationsKind(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for PeeringLocationsKind</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to PeeringLocationsKind</summary>
        /// <param name="value">the value to convert to an instance of <see cref="PeeringLocationsKind" />.</param>

        public static implicit operator PeeringLocationsKind(string value)
        {
            return new PeeringLocationsKind(value);
        }

        /// <summary>Implicit operator to convert PeeringLocationsKind to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="PeeringLocationsKind" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Peering.Support.PeeringLocationsKind e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum PeeringLocationsKind</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Peering.Support.PeeringLocationsKind e1, Microsoft.Azure.PowerShell.Cmdlets.Peering.Support.PeeringLocationsKind e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum PeeringLocationsKind</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Peering.Support.PeeringLocationsKind e1, Microsoft.Azure.PowerShell.Cmdlets.Peering.Support.PeeringLocationsKind e2)
        {
            return e2.Equals(e1);
        }
    }
}