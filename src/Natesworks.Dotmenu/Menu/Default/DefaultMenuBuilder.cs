﻿using Natesworks.Dotmenu.Graphics;

namespace Natesworks.Dotmenu;

/// <summary>
/// Represents the default implementation of a menu builder.
/// </summary>
internal sealed class DefaultMenuBuilder
    : MenuBuilder
{
    /// <inheritdoc />
    protected override IMenuRenderer CreateRenderer(
        string selector,
        string? prefix,
        ITheme theme) =>
        new DefaultMenuRenderer(selector, prefix, theme);
}