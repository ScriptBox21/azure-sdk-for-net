// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> Filters limit rule actions to a subset of blobs within the storage account. If multiple filters are defined, a logical AND is performed on all filters. </summary>
    public partial class ManagementPolicyFilter
    {
        /// <summary> Initializes a new instance of ManagementPolicyFilter. </summary>
        /// <param name="blobTypes"> An array of predefined enum values. Only blockBlob is supported. </param>
        public ManagementPolicyFilter(IEnumerable<string> blobTypes)
        {
            if (blobTypes == null)
            {
                throw new ArgumentNullException(nameof(blobTypes));
            }

            BlobTypes = blobTypes.ToList();
        }

        /// <summary> Initializes a new instance of ManagementPolicyFilter. </summary>
        /// <param name="prefixMatch"> An array of strings for prefixes to be match. </param>
        /// <param name="blobTypes"> An array of predefined enum values. Only blockBlob is supported. </param>
        /// <param name="blobIndexMatch"> An array of blob index tag based filters, there can be at most 10 tag filters. </param>
        internal ManagementPolicyFilter(IList<string> prefixMatch, IList<string> blobTypes, IList<TagFilter> blobIndexMatch)
        {
            PrefixMatch = prefixMatch;
            BlobTypes = blobTypes ?? new List<string>();
            BlobIndexMatch = blobIndexMatch;
        }

        /// <summary> An array of strings for prefixes to be match. </summary>
        public IList<string> PrefixMatch { get; set; }
        /// <summary> An array of predefined enum values. Only blockBlob is supported. </summary>
        public IList<string> BlobTypes { get; }
        /// <summary> An array of blob index tag based filters, there can be at most 10 tag filters. </summary>
        public IList<TagFilter> BlobIndexMatch { get; set; }
    }
}