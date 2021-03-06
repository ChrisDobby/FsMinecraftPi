﻿namespace FsMinecraftPi.Types

type PositionInWorld = {
    X : float
    Y : float
    Z : float
}

type Block =
    | Air = 0
    | Stone = 1
    | Grass = 2
    | Dirt = 3
    | Cobblestone = 4
    | WoodenPlank = 5
    | Sapling = 6
    | Bedrock = 7
    | FlowingWater = 8
    | StillWater = 9
    | FlowingLava = 10
    | StillLava = 11
    | Sand = 12
    | Gravel = 13
    | GoldOre = 14
    | IronCore = 15
    | CoalOre = 16
    | Wood = 17
    | Leaves = 18
    | Sponge = 19
    | Glass = 20
    | LapisLazuliOre = 21
    | LapisLazuli = 22
    | Sandstone = 24
    | Note = 25
    | Bed = 26
    | PoweredRail = 27
    | DetectorRail = 28
    | Cobweb = 30
    | TallGrass = 31
    | DeadBush = 32
    | Wool = 35
    | Dandelion = 37
    | Flower = 38
    | BrownMushroom = 39
    | RedMushroom = 40
    | GoldBlock = 41
    | IronBlock = 42
    | DoubleStoneSlab = 43
    | StoneSlab = 44
    | Bricks = 45
    | TNT = 46
    | Bookshelf = 47
    | MossStone = 48
    | Obsidian = 49
    | Torch = 50
    | Fire = 51
    | MonsterSpawner = 52
    | OakWoodStairs = 53
    | Chest = 54
    | RedstoneWire = 55
    | DiamondOre = 56
    | BlockOfDiamond = 57
    | CraftingTable = 58
    | Seeds = 59
    | Farmland = 60
    | Furnace = 61
    | BurningFurnace = 62
    | Sign = 63
    | WoodenDoor = 64
    | Ladder = 65
    | Rail = 66
    | CobblestoneStairs = 67
    | WallSign = 68
    | Lever = 69
    | StonePressurePlate = 70
    | IronDoor = 71
    | WoodenPressurePlate = 72
    | RedstoneOre = 73
    | RedstoneTorch = 75
    | StoneButton = 77
    | SnowLayer = 78
    | Ice = 79
    | Snow = 80
    | Cactus = 81
    | ClayBlock = 82
    | SugarCane = 83
    | Fence = 85
    | Pumpkin = 86
    | Netherrack = 87
    | SoulSand = 88
    | Glowstone = 89
    | Portal = 90
    | JackOLantern = 91
    | Cake = 92
    | InvisibleBedrock = 95
    | Trapdoor = 96
    | MonsterEgg = 97
    | StoneBrick = 98
    | IronBars = 101
    | GlassPane = 102
    | Melon = 103
    | PumpkinStem = 104
    | MelonStem = 105
    | Vines = 106
    | FenceGate = 107
    | BrickStairs = 108
    | StoneBrickStairs = 109
    | Mycelium = 110
    | LilyPad = 111
    | NetherBrick = 112
    | NetherBrickFence = 113
    | NetherBrickStairs = 114
    | NetherWart = 115
    | EnchantmentTable = 116
    | BrewingStand = 117
    | EndPortalFrame = 120
    | EndStone = 121
    | RedstoneLamp = 122
    | ActivatorRail = 126
    | Cocoa = 127
    | SandstoneStairs = 128
    | EmeraldOre = 129
    | TripwireHook = 131
    | Tripwire = 132
    | BlockOfEmerald = 133
    | SpruceWoodStairs = 134
    | BirchWoodStairs = 135
    | JungleWoodStairs = 136
    | CobblestoneWall = 139
    | FlowerPot = 140
    | Carrots = 141
    | Potato = 142
    | WoodenButton = 143
    | MobHead = 144
    | Anvil = 145
    | TrappedChest = 146
    | LightWeightedPressurePlate = 147
    | HeavyWeightedPressurePlate = 148
    | DaylightSensor = 151
    | BlockOfRedstone = 152
    | NetherQuartzOre = 153
    | BlockOfQuartz = 155
    | QuartzStairs = 156
    | WoodenDoubleSLab = 157
    | WoodenSlab = 158
    | StainedClay = 159
    | AcaciaLeaves = 161
    | AcaciaWood = 162
    | AcaciaWoodStairs = 163
    | DarkOakWoodStairs = 164
    | IronTrapdoor = 167
    | HayBale = 170
    | Carpet = 171
    | HardenedClay = 172
    | BlockOfCoal = 173
    | PackedIce = 174
    | Sunflower = 175
    | InvertedDaylightSensor = 178
    | GrassPath = 198
    | Podzol = 243
    | Beetroot = 244
    | Stonecutter = 245
    | GrowingObsidian = 246
    | NetherReactorCore = 247

type BlockColour =
    | White = 0
    | Orange = 1
    | Magenta = 2
    | LightBlue = 3
    | Yellow = 4
    | Lime = 5
    | Pink = 6
    | Grey = 7
    | LightGrey = 8
    | Cyan = 9
    | Purple = 10
    | Blue = 11
    | Brown = 12
    | Green = 13
    | Red = 14
    | Black = 15

type BlockDescription =
    | SimpleBlock of Block
    | BlockOfColour of Block * BlockColour
    | BlockWithData of Block * int
