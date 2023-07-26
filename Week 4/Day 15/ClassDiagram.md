```
classDiagram
    %%Game runner 
    DominoGame "1" *-- "2..4" Player
    DominoGame "1" *-- "14..28" Tile
    DominoGame "1"*--"1" Board
    DominoGame "1"..|>"1" Message : uses
    DominoGame "1" ..|>"1" GameMode : uses
    DominoGame "1"*--"1" Boneyard
    DominoGame "1"o--"1" Moveset

    %%Player
    IPlayer <|.. Player : implements

    %%Board
    IBoard <|.. Board : implements

    %%Tile
    ITile <|.. Tile : implements
    Tile <|-- TilePosition
    Tile ..|> TileOrientation : uses
    Tile ..|> TilePoint : uses

    class DominoGame{
        %%-List ~Tile~ tileList
        -IPlayer currentPlayerTurn
        -Dictionary ~IPlayer.List~Tile~~ : playerResources
        -Board board
        -GameMode gameMode
        -Boneyard boneyard
        -Leaderboard leaderboard
        +AddPlayer(IPlayer player) : bool
        +GetPlayerList() : List ~Player~
        +GenerateTile(IPlayer player) : Tile
        +CountDoubleTile(IPlayer player) : int
        +CountPlayerTile(IPlayer player) : int
        +SetGameMode(GameMode gameMode) : bool
        +GetGameMode() : GameMode
        +GetGameMessage() : Message
        +NextPlayerTurn(IPlayer) : bool
        +GetPlayerTurn() : IPlayer
        +PlayerOnTurn(IPlayer player) : bool
        +TileValueMatched() : bool
        +CheckTilePoint() : Tile
        +SetTilePoint(Tile tile) : bool
        +CheckBoneyardAvailibility() : bool
        +IsEnded() : bool
        +GetLeaderboardInfo() : List ~Player~ 
    }
    class Player{
        -string _name
        -int _id
        +SetName(string) : bool
        +SetID(int) : bool
        +GetName() : string
        +GetID() : int
    }
    class IPlayer{
        <<interface>>
        +SetName(string) : bool
        +SetID(string) : bool
        +GetName() : string
        +GetID() : int
    }
    class Tile{
        -TileOrientation orientation
        -TilePoint point
        -int _value[2]
        +SetTileValue(int sideA, int sideB) : bool
        +GetPosition() : TilePosition
        +SetOrientation(TileOrientation orientation) : bool
        +GetOrientation() : TileOrientation
    }
    class TilePosition{
        -int _positionX
        -int _positionY
        +SetPosition(int positionX, int positionY) : bool
    }
    class ITile{
        <<interface>>
        +SetTileValue(int sideA, int sideB)
    }
    class Boneyard{
        +ShuffleTile() : void
        +OpenTile() : Tile
        -List ~int[2]~ tileOnBoneyard
    }
    class Board{
        -int _sizeX
        -int _sizeY
        -List ~Tile~ tileOnBoard
        +SetBoundaries(int posX, int posY) : bool
        +GetBoundaries() : int
        +GetTileOnBoard() : List ~Tile~
    }
    class IBoard{
        +SetBoundaries(int posX, int posY) : bool
        +GetBoundaries() : int
    }
    class Moveset{
        +PlaceTile() : bool
        +PassTurn() : bool
    }
    class Message{
        <<Enumeration>>
        WinTheGame
        LostTheGame
    }
    class GameMode{
        <<Enumeration>>
        DrawMode
        BlockMode
    }
    class TileOrientation{
        <<Enumeration>>
        Vertical
        Horizontal
    }
    class TilePoint{
        <<Enumeration>>
        BottomSide
        Middle
        TopSide
    }
```