// SPDX-FileCopyrightText: 2024 deltanedas <39013340+deltanedas@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 ReserveBot <211949879+ReserveBot@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 Svarshik <96281939+lexaSvarshik@users.noreply.github.com>
//
// SPDX-License-Identifier: AGPL-3.0-or-later

/*
* Delta-V - This file is licensed under AGPLv3
* Copyright (c) 2024 Delta-V Contributors
* See AGPLv3.txt for details.
*/

using Content.Server.StationEvents.Events;
using Robust.Shared.Utility;

namespace Content.Server.StationEvents.Components;

/// <summary>
/// Loads a grid far away from a random station.
/// Requires <see cref="RuleGridsComponent"/>.
/// </summary>
[RegisterComponent, Access(typeof(LoadFarGridRule))]
public sealed partial class LoadFarGridRuleComponent : Component
{
    /// <summary>
    /// Path to the grid to spawn.
    /// </summary>
    [DataField(required: true)]
    public ResPath Path = new();

    /// <summary>
    /// Roughly how many AABBs away
    /// </summary>
    [DataField(required: true)]
    public float DistanceModifier;

    /// <summary>
    /// "Stations of Unusual Size Constant", derived from the AABB.Width of Shoukou.
    /// This Constant is used to check the size of a station relative to the reference point
    /// </summary>
    [DataField]
    public float Sousk = 123.44f;
}
