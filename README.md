# AudioTest

## Initial Setup

0. Decide which version of Unity you will use.
    - The project is currently set to version 2019.2.12
    - Please discuss with Gene if you want to use a different version
    - Note: I found that TiltBrush model colors become less saturated when you upgrade to version 2019.3.x or higher.
	- I need to investigate why.

2. Clone the AudioTest project repository on GitHub to your local disk
	- Either
		- Browse to project https://github.com/genemiller/AudioTest
		- Click the green Code button
		- Select Download ZIP from the pulldown menu
		- Unzip the zip file
	- Or
		- Sign up for a GitHub account at https://github.com/		- Tell me your GitHub User ID			- I will grant you read/write permission to this project.		- Install GitHub Desktop from here: https://desktop.github.com/			- will sync the project files on your local drive with the ones in the cloud		- Open the GitHub Desktop and enter your GitHub credentials		- Browse to project https://github.com/genemiller/AudioTest		- Click the green Code button		- Select Open with GitHub Desktop from the pulldown menu			- Specify where to save
3. Download Library.zip from https://drive.google.com/drive/folders/1ceBL0IerwLaevvzjRg9h7Vw9V8x2UVyy?usp=sharing
     - Note: I found this Library is necessary to preserve saturation of TiltBrush model colors.

4. Unzip Library.zip

4. Move the 'Library' folder to the AudioTest project folder

5. Add the AudioTest project to UnityHub

6. Open the AudioTest project 
	-Version set to the value decided by you and Gene)

7. Verify the colors of the TL08_5 TiltBrush model are fully saturated
	- I will send you screen shot to compare

## AudioTest Project folder contents
- .git*			Files used by Git
- Assets			Tracked in GitHub: All images, audio files, material definitions, etc.- Library		Downloaded from Google Drive: Automatically updated by Unity- Logs			Automatically created when you open the project in Unity- Packages		Tracked in GitHub: No need to alter this- ProjectSettings	Tracked in GitHub: No need to alter this- Temp			Automatically created and updated in Unity
- README.md		This ReadMe file ## Asset folder contents - Altspace		AltspaceVR Uploader- BRCvr Assets		Ground Textures from Burning Man BRCvr 2020- Chase Audio Collage 1 	Audio files- FIreworks 1.jpg	360 Image from Burning Man 2017
- FPC			First Person Controller scripts for Player Camera- Materials		Miscellaneous materials- Plugins		GitHub Plugin AltspaceVR Uploader Plugin - Resources		AltspaceVR Uploader Plugin - Scenes			Scene definition and baked scene lighting- TB-Exports		Darcy’s seven TiltBrush models (All models except TL08_5 should be left inactive for now).- ThirdParty		Materials and textures for TiltBrush models- TiltBrush		Materials and textures for TiltBrush models ## AudioTest+FPC Scene Hierarchy - for previewing audio
- Environment	- Moons			lighting for the TiltBrush models	- MidCylinder		Floor	- TL-Import		Darcy’s seven TiltBrush models (All models except TL08_5 left inactive for now).	- TL-Import/TL08_5	TL08_5 TiltBrush model	- TL-Import/TL08_5/AC1	AC1 Audio positioned in TL08_5	- Tabletop		Placeholder for Kiosk in center of scene- Player				Navigable Player camera 
## AudioTest Scene Hierarchy - for uploading to AltspaceVR without scripts
- Environment	- Moons			lighting for the TiltBrush models	- MidCylinder		Floor	- TL-Import		Darcy’s seven TiltBrush models (All models except TL08_5 left inactive for now).	- TL-Import/TL08_5	TL08_5 TiltBrush model	- TL-Import/TL08_5/AC1	AC1 Audio positioned in TL08_5	- Tabletop		Placeholder for Kiosk in center of scene## Fetching, Committing, and Pushing AudioTest changes via GitHub Desktop- Click Fetch Origin to make sure you have recent changes that were pushed to GitHub cloud.- Click the History Tab to see all changes committed by you or me.- Click the Changes Tab to see all your local changes that you have  not yet committed.- When you are ready to commit, enter a Summary at the bottom of Changes and press Commit to Main.	- This might be when you’ve added a significant feature.- Then click Push to Origin to push your commit to the cloud.
## To Preview Audio in Unity
- Load AudioTest+FPC scene in Hierarchy
	- Note: FPC = First Person Controller, i.e., Navigable Player Camera in Play mode
	- This scene has scripts that cannot be uploaded to AltspaceVR
- Unload AudioTest scene in Hierarchy
- Either
	- Enable the Speaker icon at top of the Scene window
	- Move the scene camera through TL08_5
- Or
	- Enable Play at the top of the Game window
	- Navigate the player camera with arrow keys.
		- Left/Right arrow: turn left/right
		- Up/Down arrow: walk forward/backward
		- Hold Left Shift with Up/Down arrow: sprint forward/backward 
		- Left mouse or trackpad: look up/down
		- Note: elevation îs fixed at 2 meters, and there is no flying in this mode
## To Upload scene without FPC to AltspaceVR
- Load AudioTest scene in Hierarchy (without scripts as required by AltspaceVR)
- Assuming changes were made in the AudioTest+FPC scene, then copy these changes to AudioTest scene
- Unload AudioTest+FPC scene in Hierarchy
- I’ll show you how to upload to AltspaceVR when you are ready to test there.
