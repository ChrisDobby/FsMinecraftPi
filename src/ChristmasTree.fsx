#load "Types.fs"
#load "Commands.fs"
#load "Connection.fs"
#load "Minecraft.fs"

open FsMinecraftPi.Types

let pos = Minecraft.PlayerPosition()
let treePos = {pos with X = pos.X + 10.}

Minecraft.Block Block.Wood treePos

let ys = [1.;2.;3.;4.]
let zs = [3.;2.;1.;0.]

List.zip ys zs
    |> List.iter 
        (fun (yoffset,zoffset) -> 
            Minecraft.Blocks Block.Leaves 
                {treePos with Y = treePos.Y + yoffset;Z = treePos.Z - zoffset}
                {treePos with Y = treePos.Y + yoffset;Z = treePos.Z + zoffset})
