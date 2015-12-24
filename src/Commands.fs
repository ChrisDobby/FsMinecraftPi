namespace FsMinecraftPi

open FsMinecraftPi.Types

type internal Command =
    | Say of string
    | SetBlock of BlockDescription * PositionInWorld
    | SetBlocks of BlockDescription * PositionInWorld * PositionInWorld
    | GetBlock of PositionInWorld
    | MovePlayer of PositionInWorld
    | GetPlayerPos

module Commands =
    let private worldPositionParameters position =
        sprintf "%d, %d, %d" (int position.X) (int position.Y) (int position.Z)
    let private playerPositionParameters position =
        sprintf "%f, %f, %f" position.X position.Y position.Z

    let private blockParameters =
        function
            | SimpleBlock(block ) -> sprintf "%d" (int block)
            | BlockOfColour(block, colour) -> sprintf "%d,%d" (int block) (int colour)
            | BlockWithData(block, data) -> sprintf "%d,%d" (int block) data

    let internal commandString =
        function 
            | Say(message) -> 
                sprintf "chat.post(%s)" message
            | SetBlock(block, position)  -> 
                sprintf "world.setBlock(%s,%s)" 
                    (worldPositionParameters position) 
                    (blockParameters block)
            | SetBlocks(block, fromPosition, toPosition) ->
                sprintf "world.setBlocks(%s, %s, %s)"
                    (worldPositionParameters fromPosition) 
                    (worldPositionParameters toPosition) 
                    (blockParameters block)
            | GetBlock(position) ->
                sprintf "world.getBlock(%s)" 
                    (worldPositionParameters position)
            | MovePlayer(position) ->
                sprintf "player.setPos(%s)" 
                    (playerPositionParameters position)
            | GetPlayerPos -> "player.getPos()"
