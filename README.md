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



## Unity week 2: Formal elements

A project with step-by-step scenes illustrating some of the formal elements of game development in Unity, including: 

* Prefabs for instantiating new objects;
* Colliders for triggering outcomes of actions;
* Coroutines for setting time-based rules.

Text explanations are available 
[here](https://github.com/gamedev-at-ariel/gamedev-5782) in folder 04.

## Cloning
To clone the project, you may need to install git lfs first (if it is not already installed):

    git lfs install 

To clone faster, you can limit the depth to 1 like this:

    git clone --depth=1 https://github.com/<repository-name>.git

When you first open this project, you may not see the text in the score field.
This is because `TextMeshPro` is not in the project.
The Unity Editor should hopefully prompt you to import TextMeshPro;
once you do this, re-open the scenes, and you should be able to see the texts.



## Credits

Programming:
* Maoz Grossman
* Erel Segal-Halevi

Online courses:
* [The Ultimate Guide to Game Development with Unity 2019](https://www.udemy.com/the-ultimate-guide-to-game-development-with-unity/), by Jonathan Weinberger

Graphics:
* [Matt Whitehead](https://ccsearch.creativecommons.org/photos/7fd4a37b-8d1a-4d4c-80a2-4ca4a3839941)
* [Kenney's space kit](https://kenney.nl/assets/space-kit)
* [Ductman's 2D Animated Spacehips](https://assetstore.unity.com/packages/2d/characters/2d-animated-spaceships-96852)
* [Franc from the Noun Project](https://commons.wikimedia.org/w/index.php?curid=64661575)
* [Greek-arrow-animated.gif by Andrikkos is licensed under CC BY-SA 3.0](https://search.creativecommons.org/photos/2db102af-80d0-4ec8-9171-1ac77d2565ce)
