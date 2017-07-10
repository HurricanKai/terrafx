// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System.Collections.Generic;

namespace TerraFX.Graphics
{
    /// <summary>Provides a means of managing the graphics subsystem.</summary>
    public interface IGraphicsManager
    {
        #region Properties
        /// <summary>Gets the <see cref="IGraphicsAdapter" /> instances currently available.</summary>
        IEnumerable<IGraphicsAdapter> GraphicsAdapters { get; }
        #endregion
    }
}
