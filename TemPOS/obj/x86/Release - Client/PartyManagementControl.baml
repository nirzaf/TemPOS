   M S B A M L   `   `   `  ���� T  PPointOfSale, Version=1.0.178.0, Culture=neutral, PublicKeyToken=8f4f40908dadd8ed)clr-namespace:PointOfSalePointOfSale  R NPosControls, Version=1.0.0.0, Culture=neutral, PublicKeyToken=8f4f40908dadd8ed>.clr-namespace:PosControls;assembly=PosControlsPosControls (    "PointOfSale.PartyManagementControl   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     (myclr-namespace:PointOfSale     ?ctrl.clr-namespace:PosControls;assembly=PosControls     .��]� -   $��mainPane����. .+�&    PointOfSale.ConfigurationManager  -      Name$  Configuration���  � ColumnDefinitions �� $
��240* ��� $
��310* ��� $
��200* �����  �� ElementName$ Configuration�� �� Path$( "BindableApplicationBackgroundBrush� � RowDefinitions �� $��35 ��� $
��473* ��� $	��88* �.+��� $��1q� �� CornerRadius$ 4��$��1������ $ Configuration��$( "BindableApplicationForegroundBrush��� $��1q�$ 4��$��1��$��1������ $ Configuration��$( "BindableApplicationForegroundBrush��� $��1q�$ 4��$��2��$��1������ $ Configuration��$( "BindableApplicationForegroundBrush��� $��5,0,5,0q�$��16(�$��Current Ticket������ $ Configuration��$( "BindableApplicationForegroundBrush��� $��5,0,5,0q�$��16(�$��Ticket Items��$��1������ $ Configuration��$( "BindableApplicationForegroundBrush��� $��5,0,5,0q�$��16(�$��Change Ticket��$��2������ $ Configuration��$( "BindableApplicationForegroundBrush�#  PosControls.DragScrollListBox  -     Name$ listboxSourceTicket��$��0q�$��5,5,5,5q�
������ $��1��  -   $ receiptTape��$��0q�$��5,5,5,5q�$��1��$��1��   SelectionMode$ Multiple=�  -   $ listBoxDestinationTicket��$��0q�$��5,5,5,5q�
������ $��2��$��1���� $��2�� �� Orientation$ 
Horizontal=�$��Center=�$��Center=�.+�  PosControls.PushButton  -   	  Name$	 buttonAddTicket��$��	ExtraBold"�$��5,5,5,5q�$��70��$��64��

 � Tag$
 1��$��Century Schoolbook)�$��14(�   Text$ 
Add Ticket��  -   $	 buttonRemoveTicket��$��	ExtraBold"�$��5,5,5,5q�$��70��$��64��$
 6��$��Century Schoolbook)�$��14(�$ Remove Ticket��{�.    -   $	 buttonChangeSeating��$��	ExtraBold"�$��5,5,5,5q�$��70��$��64��$
 7��$��Century Schoolbook)�$��14(�$ Change Seating��{�.  $y�	Collapsed=�]� $��2��$��1��.+�  -	   $	 buttonEditParty��$��Center=�$
��Left=�$��2��$��1��$��	ExtraBold"�$��5,5,5,5q�$��70��$��64��$
 7��$��Century Schoolbook)�$��14(�$ Edit Party Info���� $ 
Horizontal=�$��Center=�$��Right=�.+�  -
   $	 buttonSelectAll��$��2��$��1��$��	ExtraBold"�$��5,5,5,5q�$��70��$��64��$
 7��$��Century Schoolbook)�$��14(�$ Select All Items��{�.    -   $	 buttonUnselect��$��2��$��1��$��	ExtraBold"�$��5,5,5,5q�$��70��$��64��$
 7��$��Century Schoolbook)�$��14(�$ Unselect All Selected��{�.  �� $��2��$��2��$ 
Horizontal=�$��Center=�$��Center=�.+�  -   $	 buttonSingleTicket��$��	ExtraBold"�$��5,5,5,5q�$��70��$��64��$
 8��$��Century Schoolbook)�$��14(�$ Single Ticket��