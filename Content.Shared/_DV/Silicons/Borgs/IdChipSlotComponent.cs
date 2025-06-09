// SPDX-FileCopyrightText: 2025 ReserveBot <211949879+ReserveBot@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 deltanedas <39013340+deltanedas@users.noreply.github.com>
//
// SPDX-License-Identifier: AGPL-3.0-or-later

using Content.Shared.Whitelist;
using Robust.Shared.Containers;
using Robust.Shared.GameStates;
using Robust.Shared.Serialization;

namespace Content.Shared._DV.Silicons.Borgs;

/// <summary>
/// Adds an id chip slot for a borg which will control its access.
/// Enables an id chip's access when inserted to an id chip slot.
/// </summary>
[RegisterComponent, NetworkedComponent, Access(typeof(IdChipSlotSystem))]
public sealed partial class IdChipSlotComponent : Component
{
    /// <summary>
    /// The container ID to use for the slot.
    /// </summary>
    [DataField]
    public string ContainerId = "borg_id_chip";

    /// <summary>
    /// The container that can hold an id chip.
    /// </summary>
    [ViewVariables]
    public ContainerSlot Container = default!;

    /// <summary>
    /// The id chip installed, if any.
    /// </summary>
    [ViewVariables]
    public EntityUid? Chip => Container.ContainedEntity;

    /// <summary>
    /// The whitelist an id chip must match to be inserted.
    /// </summary>
    [DataField(required: true)]
    public EntityWhitelist Whitelist = new();
}

/// <summary>
/// BUI message to eject a borg's id chip.
/// </summary>
[Serializable, NetSerializable]
public sealed class BorgEjectIdChipMessage : BoundUserInterfaceMessage;
