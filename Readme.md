This solution is built by using MVP - Model-View-Presenter pattern

1. Model - CubeModel
 We use this model mainly as a shared object between the two presenters (SideBarViewModel, SceneViewModel) by using Property Injection 
 but first registering it the CollorInstaller.
 It holds an instance of ReactiveProperty type for color chosen from sidebar buttons
 
2. View - Two views: Canvas and 3D Cube
- The sidebar is basically Canvas object along with the buttons that are used to trigger color change

3. Presenter - Two presenters SideBarViewModel and SceneViewModel
- SidebarViewModel - in this presenter we defined the 'onSelectColor' method that is triggered on button click when any sidebar button is clicked.
The thing that is missing here is that this method should accept parameter of type Material so this material can be easily assigned to the 3D cube

- SceneViewModel - we use this presenter mainly to subscribe on CubeModel color changed so we can change the 3D cube background color
