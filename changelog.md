
commit eb9fc7cbf2e9f9c0fcbd8093c219748ae3e9a10c (HEAD -> ksa_1409_8dev2, origin/ksa_1409_8dev2)
Author: ksa_1409_8 <ksa_1409_8@hotmail.com>
Date:   Wed May 2 18:05:09 2018 +0530

    -Implement the UI panel for showing suspected persons in game scene
    -Add the sprite of 5 suspected Actor (Husband,Maid,Butler,Cook,Gardener).
    -Adding the click event listener over these actor.

commit 0ce2ca6bc8ed57816afe39792af16a9ba94c0094
Author: ksa_1409_8 <ksa_1409_8@hotmail.com>
Date:   Tue May 1 18:35:57 2018 +0530

    Create new gameobject Suspected Item panel.
    Attached script, Panel_SuspectedItem.cs to it.
    Pass the intectable item (Knife/Mail) name to the panel game object to user.
    Set the title and description.

commit 95b9f67252516cdec5b80c78bbc47a30238d71fc
Merge: 19204965 777a1ba6
Author: Ahmed044 <30297218+Ahmed044@users.noreply.github.com>
Date:   Tue May 1 17:47:31 2018 +0530

    Merge pull request #40 from aalotaibi97/development

    Development

commit 777a1ba6aac74b052cc8ff3356b8a3ea2988eb42 (origin/development)
Merge: fe4ae966 a5f9ca39
Author: Ahmed044 <30297218+Ahmed044@users.noreply.github.com>
Date:   Tue May 1 17:46:04 2018 +0530

    Merge pull request #39 from aalotaibi97/aalotaibi97dev1

    Aalotaibi97dev1


commit 7424f40a662afa5ff1ec81e0df2dd50c9be17c9c (HEAD -> aalotaibi97dev1, origin/aalotaibi97dev1)
Author: aalotaibi97 <aalotaibi97@gmail.com>
Date:   Mon Apr 30 15:20:35 2018 +0530

    -Implement conversation between Julie(maid) & Detective
    -After converation completion showing Suspect panel.
    -Add mail as an interactable item
    -Getting Mouse and touch event
    -Using mouse/touch event getting the click over mail-letters object.



commit 746677a69d9ae5863bcf249949836ac7bde796c0 (HEAD -> aalotaibi97dev1, origin/aalotaibi97dev1)
Author: aalotaibi97 <aalotaibi97@gmail.com>
Date:   Fri Apr 27 19:07:52 2018 +0530

    Implemented the dialogue chat panel between
    - Detective and Gardener
    - Detective and Cook

    Showing suspect panel to confirm. Is he commited crime.
    Working on interaction with knife when player reaches nearby to it.
    Continued working on Light system of game scene for optimize.


commit 192049650be55d93d06ad55b839f2e47007ec1b3 (origin/ksa_1409_8dev2)
Author: ksa_1409_8 <ksa_1409_8@hotmail.com>
Date:   Fri Apr 27 16:06:49 2018 +0530

    update

commit 1fc7d63303d0dc01c2a14306a194da299880eaff (HEAD -> ksa_1409_8dev2, origin/ksa_1409_8dev2)
Author: ksa_1409_8 <ksa_1409_8@hotmail.com>
Date:   Wed Apr 25 14:21:28 2018 +0530

    -Add interactable item - Knife and mail letters
    -After dialogue conversation showing the panel to Detective
    -Is interrogated person to kept in suspect or not.

commit 3c5826fb5b29980a611692b58521a65dee547bcf (origin/aalotaibi97dev1)
Author: aalotaibi97 <aalotaibi97@gmail.com>
Date:   Mon Apr 23 19:26:50 2018 +0530

    Add 3d model of Butler NPC
    Implemented code for Butler Speech text
    Modify the character(RPG) animation while interatig with Bell.

commit 1f89849ba9f59f39546b82904b8120796df19c18
Author: aalotaibi97 <aalotaibi97@gmail.com>
Date:   Fri Apr 20 14:15:10 2018 +0530

    Added sprite to each NPC
    Showing sprite to dialogue panel.

commit be40b03863face9eede9d24476c648bbe1b56915
Author: aalotaibi97 <aalotaibi97@gmail.com>
Date:   Thu Apr 19 11:03:57 2018 +0530

    updates

commit 528889bb04372062512aff356441bf97a1351632
Author: ksa_1409_8 <ksa_1409_8@hotmail.com>
Date:   Wed Apr 18 19:00:34 2018 +0530

    change log updation

commit de395490436ecdd15f638c3024b59f8dc44c47ee (HEAD -> ksa_1409_8dev2, origin/ksa_1409_8dev2)
Author: ksa_1409_8 <ksa_1409_8@hotmail.com>
Date:   Wed Apr 18 16:05:46 2018 +0530

    -Event get for interacting with NPC : Ronald
    -Create dialogue sppech panel to show conversation between them
    -Parsed JSON string to Dialogue class, to show dialogues on continued button.

commit 275e12efb0793ee69f92303882e9787907877130
Author: ksa_1409_8 <ksa_1409_8@hotmail.com>
Date:   Tue Apr 17 18:36:03 2018 +0530

    Detective character movement animation : idle and walk

commit 4b0561db2a5b707be87cee5e557bd3fa60470d86 (origin/aalotaibi97dev1)
Author: aalotaibi97 <aalotaibi97@gmail.com>
Date:   Mon Apr 16 19:21:51 2018 +0530

    change log updated




Author: aalotaibi97 <aalotaibi97@gmail.com>
Date:   Mon Apr 16 19:19:09 2018 +0530

    Readme file update
    - SID added
    - JSON path defined

commit b16d7c635170ca64865e2cee404ccfddf4ca999c
Author: aalotaibi97 <aalotaibi97@gmail.com>
Date:   Mon Apr 16 18:53:07 2018 +0530

    Loading the JSON file from ...\Assets\Resources\GameJSONData folder as TextA                                                                                                                                                                                               sset
    Read string from TextAsset and parse JSON
    Creating List of dialogues

commit 47ad3be25375bcfcf35b2c26827e25bf0689fef6 (origin/master)
Author: HenryDeakin <henry.larkin@deakin.edu.au>
Date:   Fri Apr 13 09:26:35 2018 +1000

    Update README.md


Author: ksa_1409_8 <ksa_1409_8@hotmail.com>
Date:   Thu Apr 12 16:43:25 2018 +0530

    Worked on Dialogue editor,
    Creating and managing the dialogue conversation between NPC and Player
    Json file will create for each conversation scene .

    Modifying the Character control

commit 0aff40c8741ced9ceff25a8f963bd8dcc0ae58b9
Author: ksa_1409_8 <ksa_1409_8@hotmail.com>
Date:   Tue Apr 10 18:34:41 2018 +0530

    library files updates

commit 5686cbefb2bda777f47d703efd71bc7ea0973aa9 (origin/aalotaibi97dev1)
Author: aalotaibi97 <aalotaibi97@gmail.com>
Date:   Tue Apr 10 18:23:40 2018 +0530

    add change log

commit 6e81feef8fca1719e3336e9a61bab573e48ec474
Author: aalotaibi97 <aalotaibi97@gmail.com>
Date:   Tue Apr 10 17:51:43 2018 +0530

    -Character Control Class
    -Joystick control
    -Interaction with door bell (As player in trigger area)
    -Creating NPC Characters and collision base class with player

commit da0308fbebffb423128c2b4c037bb13749093600
Author: aalotaibi97 <30438919+aalotaibi97@users.noreply.github.com>
Date:   Tue Apr 10 12:35:30 2018 +0530

    Create LICENSE



commit e1c6be28ae00232b97460c8da3e59a41dc1709b2 (origin/ksa_1409_8dev2)
Author: ksa_1409_8 <ksa_1409_8@hotmail.com>
Date:   Fri Apr 6 19:13:13 2018 +0530

    Camera and Player Control
    View setup

commit 25435df6db0f7809eb5a666c1c24dff12a2f523f
Author: aalotaibi97 <aalotaibi97@gmail.com>
Date:   Wed Apr 4 12:34:34 2018 +0530

    Scene_2 Setup : Showing the Ronald's mansion
    Effect of transition to the 3d isometric environment

    Define NPC and Interactable base class

commit 7f640bb8643035666d203d6a4e96f939024567ab
Author: aalotaibi97 <aalotaibi97@gmail.com>
Date:   Wed Apr 4 12:33:47 2018 +0530

    Scene_2 Setup : Showing the Ronald's mansion
    Effect of transition to the 3d isometric environment

    Define NPC and Interactable base class

commit 7440f7fd2cb4d7f4e49d77e9d49f002bb0376217
Author: aalotaibi97 <aalotaibi97@gmail.com>
Date:   Wed Apr 4 12:33:23 2018 +0530

    Scene_2 Setup : Showing the Ronald's mansion
    Effect of transition to the 3d isometric environment

    Define NPC and Interactable base class



# SIT305
commit 6f45a5497b830f119945aa464f411146f9472ce8
Author: ksa_1409_8 <ksa_1409_8@hotmail.com>
Date:   Fri Mar 30 15:17:29 2018 +0530

    Home Scene Steup
    Effect transition
    Dialogue speech between Cop and Detective

commit 186713ec42cac4f5fd54526370b150561b0740fe
Author: ksa_1409_8 <ksa_1409_8@hotmail.com>
Date:   Fri Mar 30 15:10:33 2018 +0530

    updates

commit 344da7622aed5d11bc49fc804bb6f547444f819a
Author: aalotaibi97 <aalotaibi97@gmail.com>
Date:   Fri Mar 30 11:51:40 2018 +0530

    Project structure design and plan
    game manager
    creating splash scene

commit 748428114e84e4cd503cdd7e84808ebe19b9e4eb
Author: aalotaibi97 <aalotaibi97@gmail.com>
Date:   Fri Mar 30 11:44:54 2018 +0530

    first commit

commit 61dd1a30b59b44fb8a593aaf55d96d6ae7acd160 (origin/stage, origin/aalotaibi97_first, origin/aalotaibi97_dev1, master, aalotaibi97_first)
Author: aalotaibi97 <aalotaibi97@gmail.com>
Date:   Fri Mar 30 11:30:29 2018 +0530

    first commit
