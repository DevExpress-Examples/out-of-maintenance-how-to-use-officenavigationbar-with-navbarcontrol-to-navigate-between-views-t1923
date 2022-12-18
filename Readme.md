<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128655011/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T192348)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainViewModel.cs](./CS/DXSample/MainViewModel.cs) (VB: [MainViewModel.vb](./VB/DXSample/MainViewModel.vb))
* [MainWindow.xaml](./CS/DXSample/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/DXSample/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/DXSample/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/DXSample/MainWindow.xaml.vb))
* [ViewModels.cs](./CS/DXSample/ViewModel/ViewModels.cs) (VB: [ViewModels.vb](./VB/DXSample/ViewModel/ViewModels.vb))
* [HomeView.xaml](./CS/DXSample/Views/HomeView.xaml) (VB: [HomeView.xaml](./VB/DXSample/Views/HomeView.xaml))
* [HomeView.xaml.cs](./CS/DXSample/Views/HomeView.xaml.cs) (VB: [HomeView.xaml.vb](./VB/DXSample/Views/HomeView.xaml.vb))
* [UserControl1.xaml](./CS/DXSample/Views/UserControl1.xaml) (VB: [UserControl1.xaml](./VB/DXSample/Views/UserControl1.xaml))
* [UserControl1.xaml.cs](./CS/DXSample/Views/UserControl1.xaml.cs) (VB: [UserControl1.xaml.vb](./VB/DXSample/Views/UserControl1.xaml.vb))
* [UserControl2.xaml](./CS/DXSample/Views/UserControl2.xaml) (VB: [UserControl2.xaml](./VB/DXSample/Views/UserControl2.xaml))
* [UserControl2.xaml.cs](./CS/DXSample/Views/UserControl2.xaml.cs) (VB: [UserControl2.xaml.vb](./VB/DXSample/Views/UserControl2.xaml.vb))
* [UserControl3.xaml](./CS/DXSample/Views/UserControl3.xaml) (VB: [UserControl3.xaml](./VB/DXSample/Views/UserControl3.xaml))
* [UserControl3.xaml.cs](./CS/DXSample/Views/UserControl3.xaml.cs) (VB: [UserControl3.xaml.vb](./VB/DXSample/Views/UserControl3.xaml.vb))
<!-- default file list end -->
# How to: Use OfficeNavigationBar with NavBarControl to Navigate Between Views


<p>This example demonstrates how to populate OfficeNavigationBar from NavBarControl and navigate between different views when items in OfficeNavigationBar are selected. To bind OfficeNavigationBar to NavBarControl, set the NavigationClient property to an instance of NavBarControl. OfficeNavigationBar will be automatically populated with groups in NavBarControl. When an item in OfficeNavigationBar is clicked, a corresponding group from NavBarControl will be selected.<br />To navigate between views, the NavigationFrame control is used. This control is bound to FrameNavigationService which can be accessed from the view model to perform navigation.</p>

<br/>


