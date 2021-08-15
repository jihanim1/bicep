// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Bicep.Core.RegistryClient.Models
{
    /// <summary> The ArtifactTagOrderBy. </summary>
    public enum ArtifactTagOrderBy
    {
        /// <summary> Do not provide an orderby value in the request. </summary>
        None,
        /// <summary> Order tags by LastUpdatedOn field, from most recently updated to least recently updated. </summary>
        LastUpdatedOnDescending,
        /// <summary> Order tags by LastUpdatedOn field, from least recently updated to most recently updated. </summary>
        LastUpdatedOnAscending
    }
}