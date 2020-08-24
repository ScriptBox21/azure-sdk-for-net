// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A list of managed instance keys. </summary>
    public partial class ManagedInstanceKeyListResult
    {
        /// <summary> Initializes a new instance of ManagedInstanceKeyListResult. </summary>
        internal ManagedInstanceKeyListResult()
        {
            Value = new ChangeTrackingList<ManagedInstanceKey>();
        }

        /// <summary> Initializes a new instance of ManagedInstanceKeyListResult. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal ManagedInstanceKeyListResult(IReadOnlyList<ManagedInstanceKey> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<ManagedInstanceKey> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}