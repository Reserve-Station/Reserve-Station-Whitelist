// SPDX-FileCopyrightText: 2025 Stevensegege <jmishenko777@gmail.com>
//
// SPDX-License-Identifier: AGPL-3.0-or-later

namespace Content.Server._Reserve.Cargo.Components;

/// <summary>
///     This is used for modifying the sell price of an entity.
/// </summary>
[RegisterComponent]
public sealed partial class PriceModifierComponent : Component
{
    /// <summary>
    ///     The price modifier.
    /// </summary>
    [DataField]
    public float Modifier;
}
