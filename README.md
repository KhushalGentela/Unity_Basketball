# Unity_Basketball

This is the Unity game built as part of my time as a VR Intern on the ATLAS VR Team

Set up your oculus using this [link](https://developer.oculus.com/documentation/unity/unity-env-device-setup/)

Try doing a hello world project using [this](https://developer.oculus.com/documentation/unity/unity-tutorial-hello-vr/) after your finish the setup. 

Note : You don't have to use the Meta Horizon mobile app at any point during the setup or development. You can run your game on the oculus quest device using [Meta Quest Link PC](https://www.meta.com/help/quest/pcvr/?srsltid=AfmBOoqz76maC5161LP-FkNlAajnj3RBWfHigYP8hD5T2N-cvrddpzxL)

## Packages

The main package to download is the XR Interaction Toolkit which can be downloaded from the Asset Store. The other assets used in the game should be available in the repo. 

Download Gregor Quendell celebration audios from the [Unity Asset Store](https://assetstore.unity.com/packages/audio/sound-fx/free-crowd-cheering-sounds-225494?srsltid=AfmBOopRoRWQSGi7ih51FpN4MqiqDc974XvXxG2ZiBq4l3UIqF54rFcB)
## Features Developed
  - User can catch and shoot the basketball
  - Whenever the basket is scored, the score increases by 1 and a difficulty mode is enables
  - Whenever the user misses the basket, the difficulty modes reset and a letter from ILLINI is shown (sequentially)
  - Whenever the user misses 6 baskets in total (or spells out ILLINI), the game is completed (confetti, audio and game over screen are enabled)

## Work in Progress
  - The basket detection is very fickle (since a square box collider is used to detect baskets). Need to change this to a spherical collider or use a alternative way
  - Add more difficulty modes to the game
  - Currently, there are 2 difficulty modes and the game alternates between them. Once more modes are added, the game should randomly choose between the difficulty modes




