# SIT305

Student name : Ali Alotaibi  
Student ID: 213520643

........................

Student name : Ahmed Aljohani
Student ID: 212084899

# Henry comments 13/April
- You're still missing SIDs in this file.
- Put changelog into a single file changelog.md (or .txt), not a directory.
- Your licenses file should end in ".txt"
- Not enough commits + changelog items to pass at this frequency.
- I couldn't find your text-based data. Create a root folder "data/" and put all your JSON files in there.


# Developer Reply 
JSON files are in this root directory "\Assets\Resources\GameJSONData" as per Unity Project structure

# Henry comments 27/April
- This project seems to have stopped work? I haven't seen any update in days.
- This file still needs compile instructions, and directory explanation so I know where to find stuff.
- Your changelog needs a lot of work
- Your data hasn't progressed enough. You need to get to this very quickly, as you can't start building your game until you can at least load the levels/world of your game. So work on getting loading working (from data files) asap.

# Developer reply : 27/April
This project seems to have stopped work? I haven't seen any update in days.
# Reply
-Yesterday, we worked on our end but not commited to git, as we are in between the development phase of a task. 

This file still needs compile instructions, and directory explanation so I know where to find stuff.
# Reply
- Unity3d Root Directory : Assets/....
All game files, assets, graphics are in subfolder of it.
- Assets/3D Models
     It consists of 3d models of different props with textures and materials:
     Environment, Trees, Grass
     Detective 3d fbx model with imported animations into it.
     Butler 3d fbx model
     Knife
     Mail Letters
- Assets/CameraSettings
    Consists of 3D Camera follow script and the animated intruction to click on Bell to proceed.
- Assets/Editor
    It consists of Editor Script, where developer can load / save json file into Unity3d Editor to modify or create new Json Files
- Assets/NPC
    It consists of primitive gameobject of NPC (coloured cubes in game scene)
- Assets/Resources/GameJSONData
    It consists of different created JSON Files
    	scene_1.json : Roger and Daniel Conversation
   	scene_2.json  : Daniel & Ronald conversation
	scene_3.json  : Daniel & Mark conversation
	scene_4.json  : Daniel & Michael conversation
	scene_5.json  : Daniel & Julie conversation
	scene_6.json  : Daniel & Steve conversation
- Assets/Scene_1
    All sprites and animation used in scene_1.unity
- Assets/Scene_2
    All sprites and animation used in scene_2.unity
- Assets/Scene_Splash
   All sprites and animation used in scene_splash.unity
- Assets/Scenes_All
   Consists of all scene used in build settings
- Assets/Scripts
   Consists of all scripts used in game
   Player movement
   Joystick control
   NPC interacting
   Dialogue speech management



Your changelog needs a lot of work
# Reply
We are regularly commiting and updating the change log files as task accomplish.Please let us know if we are missing something.


Your data hasn't progressed enough. You need to get to this very quickly, as you can't start building your game until you can at least load the levels/world of your game. So work on getting loading working (from data files) asap. 
# Reply
Accomplished Tasks :
	We created Splash Scene (Project name with developed by memebers)
  	Scene_1 showing the phone ringing and speech between Detective and Police
 	Scene_2 showing the crime scene with zoom animation
  	Scene_2_1 showing the 3d house where crime happened and all NPC

	All scene are loading progressively as events fires
	
	Dialogue mangement (Created editor  script to mange json files)

	Gamemanger.cs & Scene2_1Manager.cs : to load and manage scenes and dialogues between Player and NPC(Ronald, Butler, Gardener , Cook)

Tasks still to do :-
	List of suspected persons (NPC)	
	Conversation between Detective and Maid , Julie
	Interaction with Knife and mail letters as an evidence interactiable item
   	Creating UI for showling all suspected persons as well partiall suspected accordingto view of Detective
	Correct chose of Killer



