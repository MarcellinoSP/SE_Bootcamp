```
classDiagram
    %%Game runner 
    DominoGame "1" *-- "1..4" IPlayer
    DominoGame "1" *-- "28" Tile
    DominoGame "1"*--"1" Board
    DominoGame "1"..|>"1" Message : uses
    DominoGame "1"o--"1" Boneyard
    DominoGame "1"o--"1" Move

    %%Player
    IPlayer <|-- Player : implements

    %%Board
    IBoard <|-- Board : implements

    %%Tile
    Tile <-- Position
    Tile <-- Orientation

    %%Movement
    Move ..|> Moveset : uses
    Move ..|> GameMode : uses

    class DominoGame{
        %%-List ~Tile~ tileList
        -Dictionary ~IPlayer.List~Tile~~ playerResources
        %%+IPlayer playerTurn > is this necessary?
        +Board board
        +Move playerMove
        +Message gameMessage
        +GameMode gameMode
        +Boneyard boneyard
        +AddPlayer(IPlayer)
        +GenerateTile()
        +DrawTile(tileList)
        +CountDoubleTile(playerResources) : int
        +CountPlayerTile(playerResources) : int
        +SetGameMode() : int gameMode
        +SetGameMessage() : string gameMessage
        +StartGame()
        +SetPlayerTurn() : int currentPlayerID
        +PlayerOnTurn(int currentPlayerID, int gameMode)
        +TileValueMatched(tileOnBoard, playerResources) : bool
        %%+SetTileOrientation()
        +CheckBoneyardAvailibility(tileOnBoneyard)
        +GameEnded()
    }
    class Player{
        +string name
        +int id
        +GetName()
        +GetID() 
    }
    class IPlayer{
        <<interface>>
        +GetName()
        +GetID()
    }
    class Tile{
        Position tilePosition
        Orientation tileOrientation
        +int value[2]
        +GetTileValue(int sideA, int sideB)
    }
    class Position{
        +int positionX
        +int positionY
        +GetPosition()
    }
    class Orientation{
        +string orientation
        +SetOrientation()
    }
    class Boneyard{
        +ShuffleTile()
        +List ~Tile~ tileOnBoneyard
    }
    class Board{
        +int sizeX
        +int sizeY
        +List ~Tile~ tileOnBoard
        +SetBoundaries()
    }
    class IBoard{
        +SetBoundaries()
    }
    class Move{
        Dictionary ~GameMode.List~Moveset~~ availableMove
    }
    class Moveset{
        +DrawTile()
        +PlaceTile()
        +PassTurn()
    }
    class Message{
        <<Enumeration>>
        DrawTile
        EmptyBoneyard
        WinTheGame
        LostTheGame
    }
    class GameMode{
        <<Enumeration>>
        DrawMode
        BlockMode
    }
```