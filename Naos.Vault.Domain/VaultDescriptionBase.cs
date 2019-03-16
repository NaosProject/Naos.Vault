// --------------------------------------------------------------------------------------------------------------------
// <copyright file="VaultDescriptionBase.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.Vault.Domain
{
    /// <summary>
    /// Description information for vaults.
    /// </summary>
    public abstract class VaultDescriptionBase
    {
    }

    /// <summary>
    /// File system implementation of <see cref="VaultDescriptionBase" />.
    /// </summary>
    public class FileSystemVaultDescription : VaultDescriptionBase
    {
    }
}
