Kopernicus Pre-Alpha
==============================
March 23rd, 2015

Copyright (C) 2015 Bryce C Schroeder (bryce.schroeder@gmail.com)
                   Nathaniel R. Lewis (linux.robotdude@gmail.com) 

About
-----
Kopernicus is a KSP add-on that allows for modification of stock planets and the creation of new planets via modification of the system prefab.  Why is this advantageous you might ask?  Previous planet adder mods, such as Planet Factory, modified the live planetary system and had to keep multiple hacks actively running to provide these worlds.  We strive to provide the least hacky solution by introducing planets into the game in the exact same manner Squad would.  

Kopernicus is a one step process.  It is started before the planetary system is created and rewrites a property called PSystemManager.Instance.systemPrefab.  The game itself then creates *our* planetary system as if it were blessed by Squad themselves.  Our very own Brood Parasite!  The mod’s function ends here, and it terminates.  Kopernicus introduced worlds require zero maintenance by third party code, all support is driven entirely by built in functionality.  This yields an incredibly stable and incredibly flexible environment for planetary creation.

One caveat exists that prevents absolute control over a planetary system.  Due to the way Squad defines how launch control and ship recovery work, a planet called Kerbin must exist and must have a reference body id of 1.  While it is easy to provide this scenario, as a star to orbit and a single planet satisfies this, any would be universe architect needs to be aware so they don’t get mystery errors.  

Each celestial body in KSP has a property called “flightGlobalsIndex.”  This number does not directly correspond to the reference id, but is related.  Once all of the celestial bodies have been spawned, references to them are written into the localBodies list.  This list is then sorted in increasing order of the flight globals index.  The index the body is located at after the sort becomes the reference body id.

We have yet to see if removing or rearranging the other bodies causes any sort of errors in the science or contracts system.


Instructions
------------

1) Copy the contents of the GameData/ folder to KSP’s GameData/ folder

2) Launch KSP and enjoy!

3) Please report any bugs you may find to either or both of the email addresses above.


Information
-----------
Coming Soon

Debugging Features
------------------

After the Kopernicus.Injector behavior rewrites the system prefab and terminates, a behavior called Kopernicus.RuntimeUtility is started to provide debugging functions.

PQS Inspector (Control-P): Pressing Control-P will explode your console with information about the PQS controller of the body currently being orbited

PQS Quad Visualizer (Control-S, Control-C): Pressing Control-S will draw green lines on the normal vectors to the surface of the planet at the PQ nodes.  This lets the LOD structure be visualized.  Used for testing LOD levels and whether your temperamental ocean just wants to be invisible or is decidedly non present.  Pressing Control-C will remove the lines (and save your framerate).

