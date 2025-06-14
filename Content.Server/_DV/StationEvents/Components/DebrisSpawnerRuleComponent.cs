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

namespace Content.Server.StationEvents.Components;

/// <summary>
/// Spawns random debris in space around a loaded grid.
/// Requires <see cref="LoadFarGridRuleComponent"/>.
/// </summary>
[RegisterComponent, Access(typeof(DebrisSpawnerRule))]
public sealed partial class DebrisSpawnerRuleComponent : Component
{
    /// <summary>
    /// How many debris grids to spawn.
    /// </summary>
    [DataField(required: true)]
    public int Count;

    /// <summary>
    /// Modifier for debris distance.
    /// Should be between 3 and 10 generally.
    /// </summary>
    [DataField(required: true)]
    public float DistanceModifier;
}
