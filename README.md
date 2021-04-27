# TankWarsStarterPack
## Starter Pack with Tank Templates to help get started in creating your own TankWars Tank.
Players will create a tank that inherits from PlayerTank to compete in the arena and dominate against other tanks. 
## Objective

#### Be the last tank standing! 

Winners are determined by the amount of points a tank accumulates by the end of a match. Even if a tank is not the last onen standing, they could potentially not get first
place (very, very, VERY unlikely!)

This is how points are determined at the end of the match:

* 15 points if you are the only tank left in the arena
* 10 points for every life you have left
* 5 points for every kill you get
* 2.5 points for every almost Kill you get (your shot was within 2 spaces from the opponent tank, but they dodged it)
* 10 \* bullet accuracy (which is determined by ((Kills + AlmostKills) / Total shots)
* 1 point if you are a super tank by the end of the match. 

## What can YOU do?

You must create your own PlayerTank that will have the best logic to beat the other tanks. 

Every tick, your tank will run its tankAction method where it will decide what to do. You change what it does by changing the return value of this method.  

### Here are the things that you can choose to do:

| ActionTypes                       |What it does               |
|-----------------------------------|---------------------------|
| ActionType.RotateRight            | Rotates to the right 90°  |
| ActionType.RotateLeft             | Rotates to the left 90°   |
| ActionType.MoveUp<sup>2           | Moves Up one square       |
| ActionType.MoveDown<sup>2         | Moves Down one square     |
| ActionType.MoveRight<sup>2        | Moves Right one square    |
| ActionType.MoveLeft<sup>2         | Moves Left one square     |
| ActionType.Fire                   | Fires a bullet            |
| ActionType.SetBomb                | Sets a bomb<sup>1</sup>   |
| ActionType.DoNothing              | Does Nothing              |

###### 1. Setting a bomb will take one life away, but any tank that gets caught in its explosion (3x3 square) will love 2 lives

###### 2. You cannot move where another tank is, or off the screen. If you do try to do this, you will simply do nothing for that tick. (You might want to check where you are moving before you move there)

## What will help me determine my logic?

#### You have various readonly variables that you can use to help you with your AI decisions


| Variable               | What it does                                |
|------------------------|---------------------------------------------|
| variables.GetNumCols() | Returns the number of columns in the arena  |
| variables.GetNumRows() | Returns the number or rows in the arena     |
| variables.GetTanks()   | Returns an IEnumerable<Tank> that you can loop through to get all of the tanks in the arena<br><i>See Below for properties of tanks |
| variables.GetBullets() | Returns an IEnumerable<ReadOnlyBullet> that you can loop through to get all of the bullets in the arena<br><i>See Below for properties of bullets |
| variables.GetBombs()   | Returns an IEnumerable<ReadOnlyBomb> that you can loop through to get all of the bombs in the arena<br><i>See Below for properties of bombs |
| variables.GetHearts()  | Returns an IEnumerable<ReadOnlyHeart> that you can loop through to get all of the active hearts in the arena<br><i>See below for properties of hearts|
| variables.GetLightnings() | Returns an IEnumerable<ReadOnlyLightnign> that you can loop through to get all of the active lightnings in the arena<br><i>See below for properties of lightnings|
  
## Tank Properties<sup>1</sup>

There are various properties that each tank has that you can use to determine what you do

| Property Name         | What it means                               |
|-----------------------|---------------------------------------------|
| Id                    | Returns the Tank Id that can be used to compare tanks |
| Direction             | Returns a Direction Enum of the direction the tank is facing<sup>2<sup> |
| X                     | Returns the X coordinate of the tank |
| Y                     | Returns the Y coordinate of the tank |
| Image                 | Not sure why you need the image, but you got it lol |
| IsAlive               | Returns true if the tank is still alive, otherwise false |
| IsSuper               | Returns true if the tank is a super tank (has gotten a lightning), otherwise false|
| Lives                 | Returns how many lives the tank has left |
| Name                  | Returns the name of the tank |


  
###### 1. All tanks, including your own tank (me) have these properties. (e.i. `me.IsAlive`, `me.Lives`, `me.X`, `me.Y`)
###### 2. Direction Enum has 4 possible values. Direction.UP, Direction.DOWN, Direction.LEFT, and Direction.RIGHT. Each directional value is respective to its name. 


## Bullet Properties<sup>1</sup>
| Property Name         | What it means                               |
|-----------------------|---------------------------------------------|
| Id                    | Returns the bullet Id that can be used to compare bullets |
| Direction             | Returns a Direction Enum of the direction the bullet is facing<sup>1<sup> |
| X                     | Returns the X coordinate of the bullet |
| Y                     | Returns the Y coordinate of the bullet |
| BulletOwner           | Returns the Tank <i>(see Tank properties)</i> that shot the bullet | 
| Image                 | Not sure why you need the image, but you got it lol |
| IsAlive               | Returns true if the Bullet is still alive, otherwise false |

###### 1. Direction Enum has 4 possible values. Direction.UP, Direction.DOWN, Direction.LEFT, and Direction.RIGHT. Each directional value is respective to its name. 
  
## Heart and Lightning Properites
| Property Name         | What it means                               |
|-----------------------|---------------------------------------------|
| Id                    | Returns the powerups Id that can be used to compare powerups |
| TimeLeft              | Returns how much time is left before the powerup despawns |
| X                     | Returns the X coordinate of the powerup |
| Y                     | Returns the Y coordinate of the powerup | 
| Image                 | Not sure why you need the image, but you got it lol |
| IsAlive               | Returns true if the powerup is still alive, otherwise false |

## Bomb Properties
| Property Name         | What it means                               |
|-----------------------|---------------------------------------------|
| Id                    | Returns the Bomb Id that can be used to compare bombs |
| TimeLeft              | Returns how much time is left before the bomb explodes<sup>1</sup> |
| X                     | Returns the X coordinate of the bomb |
| Y                     | Returns the Y coordinate of the bomb | 
| Image                 | Not sure why you need the image, but you got it lol |
| IsAlive               | Returns true if the tank is still alive, otherwise false |

###### 1. Note that if a bullet hits a bomb, then the bomb will immediately explode!

## Getting Started
#### See powerpoint presentation for full tutorial on getting started :)

### Creating your first Tank

1. Create a new class in the PlayerTanks Project and name it whatever you would like.
2. Derive your class from the PlayerTank base class
3. Generate overrides (or create them manually)<br>
    &emsp;&emsp;a) Image Override<br>
    &emsp;&emsp;b) Name Override<br>
    &emsp;&emsp;c) TankAction Override
    
    <i>(See TemplateTank.cs for help)</i>
4. Add your own Tank logic to create the best tank in the arena! You can choose what your tank does each tick by changing the return value in it's TankAction method.
