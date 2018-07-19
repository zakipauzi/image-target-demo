# HoloLens Image Target Demo

This demo has been developed for Microsoft HoloLens exploring the functionality of image target with Vuforia. Image target is the spawning of a holographic model upon detection of an image, enabling users to experience mixed reality based on objects in the real world.

![Screenshot](https://raw.githubusercontent.com/zakipauzi/image-target-demo/master/Assets/Screenshot/screenshot2.png)


## Getting Started

### Prerequisites

* Unity 2017.3.1p4
* Microsoft Visual Studio 2017


## Building the Project

- Clone this repository into your local machine.
- Open Unity, and load files as new project
- Open the Scene "Main"
- Go to File > Build settings
- Add Open Scenes into the Windows
- Select Universal Windows Platform on the left and click "Switch Platform"
- Ensure "Unity C# Projects" is ticked
- Click on 'Build'
- In the root folder, create a folder called "App" and build the solution there


## Deployment

Deployment should be done from its solution file in App folder.

* After the build, open the solution in the App folder in Visual Studio
* Open the "hologram-101.sln in Visual Studio 2017
* Select "Release" and "x86" from the top bar

### Using HoloLens Emulator

Install the HoloLens Emulator before deploying the app. When installed, the emulator can
be executed from the drop-down list (default: Local Machine).

### Using HoloLens Device

* Using Wi-Fi network

Ensure HoloLens is connected to the same network as the machine that you are deploying from.
Under the debug settings for Remote Machine, key in the IP address of the HoloLens, which can
be found in the Settings of the HoloLens, under "Network & Internet > Advanced Settings".

* Using USB connection

Ensure HoloLens is connected to computer through USB connection.
Under the debug settings, select Device.


If app has been deployed before, you can automatically launch the app from the HoloLens.


## Built With

* [Unity 2018.2.0f2](https://unity3d.com/)
* [Vuforia](https://www.vuforia.com/)


## Authors

* **Zaki Pauzi** - *Initial work* - [zakipauzi](https://github.com/zakipauzi)


## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details
