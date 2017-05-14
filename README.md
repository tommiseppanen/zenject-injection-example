# Zenject injection example
Dependency injection allows developers to build software from loosely coupled components that are easy to re-use, maintain and test.

This simple example demonstrates how to use dependecy injection with Zenject in Unity games/applications.

If you don't have previous knowledge of dependency injection, you can read for example [this short introduction](https://codeaddiction.net/articles/10/dependency-injection-in-c---a-simple-introduction) about it.


Basic steps:
1. Get Zenject either from their [GitHub repository](https://github.com/modesttree/Zenject) or from [Unity Asset Store](https://www.assetstore.unity3d.com/en/#!/content/17758)
2. Add Zenject SceneContext: right click inside the Hierarchy tab and select Zenject -> Scene Context
3. Define dependencies/injections. Example: [Cube.cs](https://github.com/tommiseppanen/zenject-injection-example/blob/1bd7bd22ef9abd7ba21644857aaa9916bb8bd53e/Assets/Scripts/Models/Cube.cs#L17-L20)
4. Create an installer with bindings, for example [Installer.cs](https://github.com/tommiseppanen/zenject-injection-example/blob/1bd7bd22ef9abd7ba21644857aaa9916bb8bd53e/Assets/Scripts/Installer.cs#L12-L16), by right clicking in a folder within the Project tab and choose Create -> Zenject -> MonoInstaller
5. Add your installer script to the scene as its own GameObject or on the same GameObject as the SceneContex. 
6. Add a reference to your installer to the properties of the SceneContext by adding a new row in the inspector of the "Installers" property (press the + button) and then dragging the TestInstaller GameObject to it
7. You can use factory or object pool for creating objects dynamically. Example: [defining factory](https://github.com/tommiseppanen/zenject-injection-example/blob/1bd7bd22ef9abd7ba21644857aaa9916bb8bd53e/Assets/Scripts/Models/CubeFactory.cs#L5) & [creating object](https://github.com/tommiseppanen/zenject-injection-example/blob/1bd7bd22ef9abd7ba21644857aaa9916bb8bd53e/Assets/Scripts/AddCubeButton.cs#L18)

Notes:
* Zenject recommends using inject methods to inject dependencies for MonoBehaviours since MonoBehaviours cannot have constructors
