// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support
{

    /// <summary>
    /// Devbox disk encryption enable or disable status. Indicates if Devbox disks encryption is enabled or not.
    /// </summary>
    public partial struct DevboxDisksEncryptionEnableStatus :
        System.IEquatable<DevboxDisksEncryptionEnableStatus>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.DevboxDisksEncryptionEnableStatus Disabled = @"Disabled";

        public static Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.DevboxDisksEncryptionEnableStatus Enabled = @"Enabled";

        /// <summary>
        /// the value for an instance of the <see cref="DevboxDisksEncryptionEnableStatus" /> Enum.
        /// </summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to DevboxDisksEncryptionEnableStatus</summary>
        /// <param name="value">the value to convert to an instance of <see cref="DevboxDisksEncryptionEnableStatus" />.</param>
        internal static object CreateFrom(object value)
        {
            return new DevboxDisksEncryptionEnableStatus(global::System.Convert.ToString(value));
        }

        /// <summary>
        /// Creates an instance of the <see cref="DevboxDisksEncryptionEnableStatus"/> Enum class.
        /// </summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private DevboxDisksEncryptionEnableStatus(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Compares values of enum type DevboxDisksEncryptionEnableStatus</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.DevboxDisksEncryptionEnableStatus e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>
        /// Compares values of enum type DevboxDisksEncryptionEnableStatus (override for Object)
        /// </summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is DevboxDisksEncryptionEnableStatus && Equals((DevboxDisksEncryptionEnableStatus)obj);
        }

        /// <summary>Returns hashCode for enum DevboxDisksEncryptionEnableStatus</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for DevboxDisksEncryptionEnableStatus</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to DevboxDisksEncryptionEnableStatus</summary>
        /// <param name="value">the value to convert to an instance of <see cref="DevboxDisksEncryptionEnableStatus" />.</param>

        public static implicit operator DevboxDisksEncryptionEnableStatus(string value)
        {
            return new DevboxDisksEncryptionEnableStatus(value);
        }

        /// <summary>Implicit operator to convert DevboxDisksEncryptionEnableStatus to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="DevboxDisksEncryptionEnableStatus" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.DevboxDisksEncryptionEnableStatus e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum DevboxDisksEncryptionEnableStatus</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.DevboxDisksEncryptionEnableStatus e1, Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.DevboxDisksEncryptionEnableStatus e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum DevboxDisksEncryptionEnableStatus</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.DevboxDisksEncryptionEnableStatus e1, Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.DevboxDisksEncryptionEnableStatus e2)
        {
            return e2.Equals(e1);
        }
    }
}