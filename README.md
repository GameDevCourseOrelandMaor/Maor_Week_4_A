# Maor_Week_4_A
**Make sure in the unity editor to open the scene: Assets/Scenes/4-levels/level-1**<br/>

Itch.io link:
[Play here](https://maor55.itch.io/week-4-question-a)

I have modified the scene to have the ship with three healthpoints, meaning it wont destroy on the first hit, but on three (which is also changeable).<br/>
A second change I made, was to make the velocity vectors of the enemy spaceships have a random value on the xAxis, meaning they won't be spawning and moving only downwards, but also randomly left and right. <br/><br/>
The scripts that I have added are in the Assets/Scripts/MAOR_TASK_SCRIPTS directory, which is containing two scripts: <br/><br/>
HeatlhField - works like the score field, update the TextMeshPro object with showing the health on screen. <br/>
HealthManager - At start, disables the original scripts for a destroy-when-hit situation. Whenever a hit is applied, health is reduced and a respawn proccess is provoked. While respawning, the spaceship cannot get hit. If the health was reduced to 0, then enable the destroy-when-hit original scripts from the lecture, so next collision will result in a game over situation. <br/>
Additionaly, I have modified the script TimedSpawnerRandom, so that the xAxis would have the velocity of yAxis, times XIntensity, which I have tuned to 2 (changeable).
