// SPDX-FileCopyrightText: 2024 Nemanja <98561806+EmoGarbage404@users.noreply.github.com>
// SPDX-FileCopyrightText: 2024 Pieter-Jan Briers <pieterjan.briers+git@gmail.com>
// SPDX-FileCopyrightText: 2024 Piras314 <p1r4s@proton.me>
// SPDX-FileCopyrightText: 2025 Aiden <28298836+Aidenkrz@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 Avalon <jfbentley1@gmail.com>
// SPDX-FileCopyrightText: 2025 ReserveBot <211949879+ReserveBot@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 Svarshik <96281939+lexaSvarshik@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 gus <august.eymann@gmail.com>
// SPDX-FileCopyrightText: 2025 nazrin <tikufaev@outlook.com>
//
// SPDX-License-Identifier: AGPL-3.0-or-later

using Content.Shared.Chemistry.Reagent;
using Content.Shared.Tools.Systems;
using Robust.Shared.Audio;
using Robust.Shared.GameStates;
using Robust.Shared.Prototypes;

namespace Content.Shared.Tools.Components;

[RegisterComponent, NetworkedComponent, AutoGenerateComponentState(true), Access(typeof(SharedToolSystem))]
public sealed partial class SolutionRefuelComponent : Component
{
    [DataField, AutoNetworkedField]
    public bool Enabled;

    [DataField]
    public float WelderTimer;

    /// <summary>
    ///     Name of <see cref="FuelSolution"/>.
    /// </summary>
    [DataField]
    public string FuelSolutionName = "Welder";

    /// <summary>
    ///     Reagent that will be used as fuel for welding.
    /// </summary>
    [DataField]
    public ProtoId<ReagentPrototype> FuelReagent = "WeldingFuel";

    /// <summary>
    ///     Sound played when refilling the welder.
    /// </summary>
    [DataField]
    public SoundSpecifier WelderRefill = new SoundPathSpecifier("/Audio/Effects/refill.ogg");

    /// <summary>
    ///     Whether the item is safe to refill while lit without exploding the tank.
    /// </summary>
    [DataField]
    public bool TankSafe;

    [DataField]
    public float WelderUpdateTimer = 1f;
}
