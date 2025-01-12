// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;
using System.Globalization;

namespace Azure.ResourceManager.AnalysisServices.Models
{
    /// <summary> The managed mode of the server (0 = not managed, 1 = managed). </summary>
    public readonly partial struct ManagedMode : IEquatable<ManagedMode>
    {
        private readonly int _value;

        /// <summary> Initializes a new instance of <see cref="ManagedMode"/>. </summary>
        public ManagedMode(int value)
        {
            _value = value;
        }

        private const int ZeroValue = 0;
        private const int OneValue = 1;

        /// <summary> 0. </summary>
        public static ManagedMode Zero { get; } = new ManagedMode(ZeroValue);
        /// <summary> 1. </summary>
        public static ManagedMode One { get; } = new ManagedMode(OneValue);
        /// <summary> Determines if two <see cref="ManagedMode"/> values are the same. </summary>
        public static bool operator ==(ManagedMode left, ManagedMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ManagedMode"/> values are not the same. </summary>
        public static bool operator !=(ManagedMode left, ManagedMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ManagedMode"/>. </summary>
        public static implicit operator ManagedMode(int value) => new ManagedMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ManagedMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ManagedMode other) => Equals(_value, other._value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value.GetHashCode();
        /// <inheritdoc />
        public override string ToString() => _value.ToString(CultureInfo.InvariantCulture);
    }
}
