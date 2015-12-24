#load "Types.fs"
#load "Commands.fs"
#load "Connection.fs"
#load "Minecraft.fs"

open FsMinecraftPi.Types

Minecraft.Chat "Merry Christmas from F#"

Minecraft.Block Block.Grass {X = 200.; Y = 100.; Z = 2.}

Minecraft.Blocks Block.Grass {X = 200.; Y = 100.; Z = 1.} {X = 200.; Y = 100.; Z = 1.}

Minecraft.MovePlayer {X = 20.; Y = 10.; Z = 1.}

let pos = Minecraft.PlayerPosition()
{ pos with X = pos.X + 1.} |> Minecraft.ColourBlock Block.Wool BlockColour.Purple

Minecraft.PlayerPosition() |> Minecraft.GetBlock