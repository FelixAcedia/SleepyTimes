using Unity.Collections;
using Unity.Entities;

namespace SleepyTimes.Models;

public struct PlayerData(FixedString64Bytes characterName, ulong steamID, bool isOnline, Entity userEntity, Entity charEntity){
    public FixedString64Bytes CharacterName { get; set; } = characterName;
    public ulong SteamId { get; set; } = steamID;
    public bool IsOnline { get; set; } = isOnline;
    public Entity UserEntity { get; set; } = userEntity;
    public Entity CharEntity { get; set; } = charEntity;
}