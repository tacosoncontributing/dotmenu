﻿using Natesworks.Dotmenu.Extensions;
using Natesworks.Dotmenu.Graphics;

namespace Natesworks.Dotmenu;

/// <summary>
/// Represents a default menu renderer.
/// </summary>
internal sealed class DefaultMenuRenderer
    : ConsoleRenderer
{
    /// <inheritdoc />
    public DefaultMenuRenderer(
        string? selector,
        string? prefix,
        ITheme? theme)
        : base(selector, prefix, theme)
    {
    }

    /// <inheritdoc />
    protected override void RenderOption(IMenuOption option)
    {
        var color = Theme?.GetAnsiColor(option);
        var text = option.Selected
            ? $"{Selector} {option.Text}"
            : $"{Prefix} {option.Text}";

        AnsiConsole.WriteLine(text, color);
    }
}