   M S B A M L   `   `   `  ����F  BBuildYourPC, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:BuildYourPC.ViewsBuildYourPC.Views  5   	   ?$clr-namespace:BuildYourPC.ViewModelsBuildYourPC.ViewModels  5   	   )clr-namespace:BuildYourPCBuildYourPC  5   	       BuildYourPC.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1viewsclr-namespace:BuildYourPC.Views     5   	   ;
viewmodels$clr-namespace:BuildYourPC.ViewModels     5   	   +localclr-namespace:BuildYourPC     5   	     � Title$  
MainWindow��5
   	   $
��1080��6   $
��1920��6*    � 	Resources 5       �� DataType'   !BuildYourPC.ViewModels.BuildingVM"   BuildYourPC.Views.BuildingUC��%l   (��       5   3   *, +)�� 6
   BuildingPCTemplate��"  63   .R�5        ��6   �� 5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $	��10* �6    � ColumnDefinitions 5   
   �� 5      $
��0.5* �6   �� 5      $��1* �6   �� 5      $��4* �6   �� 5      $��1* �6   �� 5      $
��0.5* �6   .+�5!   
   �� $��3��6   $��0��6!   $��15q�6.   $��Login��6:   $��40(�6J   �� 5$   
   -   5        $��contentControl��5$   :   $��1��6   $��5��6&   ��6P   �� 5%      5'      