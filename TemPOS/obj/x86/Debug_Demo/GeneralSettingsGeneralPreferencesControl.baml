   M S B A M L   `   `   `  ���� C  ?TemPOS, Version=1.1.0.651, Culture=neutral, PublicKeyToken=nullclr-namespace:TemPOSTemPOS  +clr-namespace:TemPOS.TypesTemPOS.Types  H DPosControls, Version=1.0.651.0, Culture=neutral, PublicKeyToken=null>.clr-namespace:PosControls;assembly=PosControlsPosControls 5    /TemPOS.GeneralSettingsGeneralPreferencesControl   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     #myclr-namespace:TemPOS     (tclr-namespace:TemPOS.Types     ?ctrl.clr-namespace:PosControls;assembly=PosControls     .��]� -   $��mainPane����. .+�&   PosControls.ConfigurationManager  -      Name$  Configuration��� $	��550������  �� ElementName$ Configuration�� �� Path$$ BindableControlBackgroundBrush� � ColumnDefinitions �� $
��300* ��� $
��300* � � RowDefinitions �� $
��300* ��� $
��300* �.+��� $��2��.+��� -   $��groupBoxBroadcastServer��   TemPOS.Types.Strings+   $SettingsClientMessageBroadcastServer#��Z $��5,0,5,10q�$��16(�.���  �� $
��300* ��� $
��300* ��� $
��300* ��� $
��300* ��� $
��300* ��� $
��300* ��� $
��300* ��� $
��300* ��� $
��300* ��� $
��300* ��� $
��300* ��� $
��300* ��� $
��300* ��� $
��300* � �� $
��300* ��� $
��300* �.+���    Enabled#��Z $��20,0,0,0q�$��1��$��Center=�$��16(���    Port#��Z $��20,0,0,0q�$��2��$��Center=�$��16(��� $��1��$��5,5,5,5q� �� Orientation$ 
Horizontal=�$��Center=�$��1��.+�!  PosControls.PushRadioButton  -   	  Name$	 radioButtonIsEnabled��$��16(�

   Yes   Text# Z
   -   $	 radioButtonIsNotEnabled��$��25,0,0,0q�$��16(�	   No# Z   PosControls.CustomTextBox  -     Name$ textBoxPort��$��5,5,10,5q�   UseContextMenuEditing .    
PromptType$ IntegerNumeric=�$��16(�$��1��   TouchOpenDelay$ 0��$��2��!  PosControls.TextBlockButton  -     Name$ 
buttonTest��$��5q�   SettingsTest   Text# Z $��40��$	��100��$��1��$��3����    SettingsGeneralOptions#��Z $��5,0,5,10q�$��16(�.���  �� $
��300* ��� $
��300* ��� $
��300* ��� $
��300* ��� $
��300* ��� $
��300* ��� $
��300* ��� $
��300* ��� $
��300* ��� $
��300* ��� $
��300* ��� $
��300* ��� $
��300* ��� $
��300* ��� $
��300* � �� $
��300* ��� $
��300* �.+���    SettingsUseSeating#��Z $��Center=�$��16(�$��5����    SettingsForceWasteOnVoid#��Z $��Center=�$��16(�$��6����    SettingsRestrictKeyboard#��Z $��Center=�$��16(�$��7���� !   SettingsLogoutOnPlaceOrder#��Z $��Center=�$��16(�$��8����    BlockTaskManagerAccess#��Z $��Center=�$��16(�$��9���� $��5,5,5,5q�$ 
Horizontal=�$��Center=�$��1��$��5��.+�  -   $	 radioButtonIsUsingSeating��$��16(�# Z
   -	   $"	 radioButtonIsNotUsingSeating��$��25,0,0,0q�$��16(�# Z �� $��5,5,5,5q�$ 
Horizontal=�$��Center=�$��1��$��6��.+�  -
   $!	 radioButtonIsForceVoidWaste��$��16(�# Z
   -   $$	 radioButtonIsNotForceVoidWaste��$��25,0,0,0q�$��16(�# Z �� $��5,5,5,5q�$ 
Horizontal=�$��Center=�$��1��$��7��.+�  -   $%	 radioButtonIsKeyboardRestricted��$��16(�# Z
   -   $(	 "radioButtonIsNotKeyboardRestricted��$��25,0,0,0q�$��16(�# Z �� $��5,5,5,5q�$ 
Horizontal=�$��Center=�$��1��$��8��.+�  -   $%	 radioButtonIsLogoutOnPlaceOrder��$��16(�# Z
   -   $(	 "radioButtonIsNotLogoutOnPlaceOrder��$��25,0,0,0q�$��16(�# Z �� $��5,5,5,5q�$ 
Horizontal=�$��Center=�$��1��$��9��.+�  -   $#	 radioButtonIsBlockTaskManager��$��16(�# Z
   -   $&	  radioButtonIsNotBlockTaskManager��$��25,0,0,0q�$��16(�# Z ��     SettingsWeatherConditions#��Z $��5,0,5,10q�$��16(�.���  �� $
��300* ��� $
��300* ��� $
��300* ��� $
��300* ��� $
��300* ��� $
��300* ��� $
��300* ��� $
��300* ��� $
��300* ��� $
��300* ��� $
��300* ��� $
��300* ��� $
��300* ��� $
��300* � �� $
��300* ��� $
��300* �.+��� #��Z $��20,0,0,0q�$��1��$��Center=�$��16(��� -   $��labelWeatherPostal��   SettingsPostalCode#��Z $��20,0,0,0q�$��2��$��Center=�$��16(��� $��1��$��5,5,5,5q�$ 
Horizontal=�$��Center=�$��1��.+�  -   $!	 radioButtonWeatherIsEnabled��$��16(�# Z
   -   $$	 radioButtonWeatherIsNotEnabled��$��25,0,0,0q�$��16(�# Z   -   $ textBoxWeatherZipCode��$��5,5,10,5q�   	MaxLength$ 5�� . $ IntegerNumeric=�$��16(�$��1��$ 0��$��2���� $ Vertical=�$��1��$��2��.+���     SettingsAutoLogoutOptions#��Z $��5,0,5,10q�$��16(�.���  �� $
��300* ��� $
��300* ��� $
��300* ��� $
��300* ��� $
��300* ��� $
��300* � �� $
��100* ��� $	��95* �.+��� #��Z $��Center=�$��16(��� -   $��labelAutoLogoutTimeOut��    SettingsAutoLogoutTimeout#��Z $��Center=�$��16(�$��1���� -   $��labelAutoLogoutDisable��    SettingsAutoLogoutDisable#��Z $��Center=�$��16(�$��2���� -   $!��labelAutoLogoutDisableOrder��$��25,0,0,0q�*    #SettingsAutoLogoutDisableOrderEntry#��Z  $��Center=�$��16(�$��3���� -   $"��labelAutoLogoutDisableDialog��$��25,0,0,0q�'!    SettingsAutoLogoutDisableDialogs#��Z! $��Center=�$��16(�$��4���� -   $$��labelAutoLogoutDisablePassword��$��25,0,0,0q�."   'SettingsAutoLogoutDisablePasswordChange#��Z" $��Center=�$��16(�$��5���� $��5,5,5,5q�$ 
Horizontal=�$��Center=�$��1��.+�  -   $%	 radioButtonYesAutoLogoutEnabled��$��16(�# Z
   -   $$	 radioButtonNoAutoLogoutEnabled��$��25,0,0,0q�$��16(�# Z   -   $ textBoxAutoLogoutTimeout��$��1��$��1��$��5,5,15,5q� . $ IntegerNumeric=�$ 4���� $��5,5,5,5q�$ 
Horizontal=�$��Center=�$��1��$��3��.+�  -   $1	 +radioButtonYesDisableAutoLogoutInOrderEntry��$��16(�# Z
   -   $0	 *radioButtonNoDisableAutoLogoutInOrderEntry��$��25,0,0,0q�$��16(�# Z �� $��5,5,5,5q�$ 
Horizontal=�$��Center=�$��1��$��4��.+�  -    $5	 /radioButtonYesDisableAutoLogoutForDialogWindows��$��16(�# Z
   -!   $4	 .radioButtonNoDisableAutoLogoutForDialogWindows��$��25,0,0,0q�$��16(�# Z �� $��5,5,5,5q�$ 
Horizontal=�$��Center=�$��1��$��5��.+�  -"   $7	 1radioButtonYesDisableAutoLogoutForPasswordChanges��$��16(�# Z
   -#   $6	 0radioButtonNoDisableAutoLogoutForPasswordChanges��$��25,0,0,0q�$��16(�# Z �� #   SettingsLocalSettings#��Z# $��5,0,5,10q�$��16(�.���  �� $
��300* ��� $
��300* � �� $
��100* ��� $	��95* �.+��� $   SettingsKioskMode#��Z$ $��Center=�$��16(�$��0,1,0,-1q��� $��5,5,5,5q�$ 
Horizontal=�$��Center=�$��1��.+�  -$   $!	 radioButtonIsUsingKioskMode��$��16(�# Z
   -%   $$	 radioButtonIsNotUsingKioskMode��$��25,0,0,0q�$��16(�# Z �� $
��Wrap=�%   SettingsKioskModeWarning#��Z% $��Center=�$��Center=�$��12(�$��0,1,0,-1q�$��1��$��2��