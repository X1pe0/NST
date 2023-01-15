![](https://nabyte.com/imgs/093a4853c1b19fea3374e8c923a670f6c0575593UntitledS.png)

## Non Shitty Teams

Non Shitty Teams or (NST) is a CefSharp Chromium application 
meant to take place of the default install of Microsoft Teams. 
The app itself has no telemetry phoning home to Microsoft’s servers 
(other than the standard telemetry when signing in/default chat usage) 
and uses a lightweight library with minimal RAM usage. This application 
comes with a WTFPL license which can be seen below.

## What’s the Point?
Microsoft Team’s on its own is rather bulky, both in size and resources without an official (in my opinion) reasoning and or point. With NST, the total size of the application is less then 50MB (excluding cache generated) with minimal RAM resources. Another reasoning behind the creation of this app was multiple CVE’s and exploitation avenues and or routes were possible up to including RCE methods within Microsoft Teams. There was and or is no possible way to script an update for Microsoft Teams other then running a self-update via the hamburger menu and or re-installation via an RMM toolset. Yes, I agree the name itself isn’t professional, but this isn’t the point of NST. A true well established web application such as Microsoft Teams fails to meet basic standards regarding security and simplicity when dealing with millions of users and client data. You may ask how is NST any better and or secure? And a blunt response from me would be: it isn’t. The aspect of this app was meant to be a lightweight version of Microsoft Teams with ZERO telemetry and an easy self-updating method which in point, this app has accomplished. 


## The Deets and Info's
NST by default saves Team’s attachments within the users documents folder. This will be changed within the near future to allow some style of customization. All cache and CefSharp content is saved within the users AppData folder within the directory NS_T for debugging. 

##### FYI's
###### Ensure you have .NET Framework 4.8 to run. 



### Main Menu
![](https://nabyte.com/imgs/8ac7a446c6ababa34ba813b2f6fed5f9b17a566f1.png)

### System Tray Options
![](https://nabyte.com/imgs/50bbb20ce0ea0415b75fa42051678cf867b455572.png)

### To Do

- [X] Downloading Files
- [X] Opening Downloaded File Once Completed
- [X] Shitty Loading/Splash Screen
- [X] Dark Theme Context Menu
- [X] Disable multiple sessions. 
- [ ] Settings Tab
- [ ] Custom Themes
- [ ] Custom Download Locations
- [ ] Notifications
- [ ] Dynamic System Tray Icon 
- [ ] Adding Azure

### License
```
            DO WHAT THE FUCK YOU WANT TO PUBLIC LICENSE
                    Version 2, December 2004

 Copyright (C) 2004 Sam Hocevar <sam@hocevar.net>

 Everyone is permitted to copy and distribute verbatim or modified
 copies of this license document, and changing it is allowed as long
 as the name is changed.

            DO WHAT THE FUCK YOU WANT TO PUBLIC LICENSE
   TERMS AND CONDITIONS FOR COPYING, DISTRIBUTION AND MODIFICATION

  0. You just DO WHAT THE FUCK YOU WANT TO.
```
