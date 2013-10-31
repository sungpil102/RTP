#Rise to Power

##Game Description

Our game, “Rise to Power”, is an action strategy game that allows the player to build power through victories. The detailed plan of the project mainly has three parts: battle logic, collision, and formation of the soldiers. We decided to implement the features by priority for the game. The timeline schedule is set after considering our personal schedules, and we will have a weekly meeting and any additional meetings as needed so that we can help each other.

Before the alpha demo, game logic and basic collision implementations to be completed. The game logic will include unit set up, enemies detecting the player near them and deciding whether to attack or not. The collision will have a time variable to count how long they are colliding each other, and three states based on the number of units that one is colliding with. After the alpha demo, we will be working on the further game logic (formation) and precise collision. The formation is to ensure that the player has some sense of control over the battle, and reduce luck as a major factor in winning a battle. Then, we will also add some polish effects such as attacking animation and impactful effects so the target experience can be improved for the player. Finally, focus on balancing out the formation so that no formation is “win-it-all” formation. We may intentionally add vulnerabilities to each formation so that the player will have to constantly switch formation to effectively win battles.

##Features
###Feature1 Mechanics: Battle logic and collision (Low target)
1. Basic game rule:
The player wins when he conquers all the enemy base camps.
The player loses if the king is killed by an enemy.

2. Battle logic for the player:
The soldiers will attack the enemy only when the player commands. Once the player toggles the mode to “attack,” the soldiers will recklessly charge toward the nearest enemy troop.
The soldiers will maintain their formation when they attack.
If the player loses all the soldiers, 3 random “neutral” soldiers will be generated in random locations. The player needs to find the soldiers to have them follow.

3. Battle logic for the enemy:
Each enemy unit will continuously detect if the player is in his range of activity.
If a enemy unit detects the player near him, it will count the number of the player’s soldiers, and the enemy troop will attack the player if the player’s army is weaker or equally matched, the enemy troops will attack. If they are completely outmatched, they will attempt to escape.
There will be a large number of units in the enemy base camps. The units in the camps will only try to defend and not chase after the player outside the camps.

4. Collision:
The time variable will be set as a unit collides with any of other units in the opposing force, then it will count the number of units that the unit is colliding with when the time exceed two seconds. This logic applies the both the player’s and the enemy’s units.
There will be three states for the collision; 1 unit against 1, 2 units against 1, and 3 or more units against 1. They will push each other if one unit meets another single unit. A unit will be killed/destroyed if the unit meets two other units in the opposing force. A unit will surrender and joins to the opposing force if the unit meets more than three other units.

###Feature2 Command: Attack/defend mode (Medium target)
1. Attack Mode:
The player can choose aggressively by toggling “attack mode.” While in this mode, the soldiers will all charge in the direction that the player is facing and initiate and attack.
If no enemy is found in that direction, the units will run a certain distance and return back to the king.

2. Defend Mode:
The units will simply crowd around the king to ensure that no enemy can attack the king.
Defensive mode is a last resort move to ensure that the king can escape an enemy swarm. The player should only be able to win in this mode when the player greatly outnumbers the enemy.

###Feature3 Formation (High target)
1. The player can choose the formations of the his army.  There are several formations that can help the player win this game.

    * There are around 4~5 formations that player can use. By default, the soldiers follow the king from behind which is the basic formation.

    * Starting with the basic formation, the player can unlock more formations as the number grows. In a sense, the number of soldiers work as a leveling system for the player to unlock more formations.

    * The player can use these formations for various purposes. For example, the player can use these formations when he is in the attack mode so that the player has greater chance of survival in an outnumbered battle, or capture more units in a favorable battle.