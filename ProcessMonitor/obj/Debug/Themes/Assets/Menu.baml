   M S B A M L   `   `   `  ����	  TS.UI>+clr-namespace:TS.UI.Controls;assembly=TS.UITS.UI.Controls  5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   MainMenuHeaderTemplate  SystemButtonForeground  ��Name J� SnapsToDevicePixels F�Name �� BitmapScalingMode �� StrokeLineJoin �� RelativeSource �� AncestorType �� Mode E� 
StartPoint	 �� Point
 �� Triggers P� Property P� Value �� 
TargetName �� Property �� Value ! SystemButtonPressedColorBrush $  SystemButtonForegroundOnMoseOver N� EnterActions �� TargetProperty �� 
TargetName8   2System.Windows.Media.Animation.EasingPointKeyFrame $� KeyTime $� Value g� 	BeginTime N� ExitActions % !MainMenuParentItemControlTemplate �� 
TargetType ��Name �� HeaderStringFormat �� ContentStringFormat �Name � AllowsTransparency � HorizontalOffset � VerticalOffset J� Effect3  -System.Windows.Media.Effects.DropShadowEffect    Color!   
BlurRadius"   ShadowDepth#   Opacity$ � RowDefinitions  WindowBackgroundBrush% ��Name& �� 
ResourceId' �� TypeInTargetAssembly( �� ClearTypeHint) ��Name* �� ElementName+ ��Name-  'System.Windows.Input.KeyboardNavigation,   DirectionalNavigation- � IsSharedSizeScope.   TabNavigation/ P� 
SourceName ' #MainMenuLanguageItemControlTemplate  AccentColorBrush20 J� Opacity9  3System.Windows.Media.Animation.EasingDoubleKeyFrame1 O� KeyTime2 O� Value  MainMenuItemControlTemplate3 �Name 	 MenuSeparatorStyle4 �� 
TargetType 
 MainMenuItemStyle5 �� AncestorLevel6 �� Triggers  MainMenuStyle�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      8controls+clr-namespace:TS.UI.Controls;assembly=TS.UI  5      ;ed4http://schemas.microsoft.com/expression/2010/drawing  5      %%;  &	        &	 �    &	 !    &	 4+    &		 74    &	
 �5    &	 �9    �� 5      .R�5   
   �� #���  6   #���  6P   ��.  ��5	      �� 5
      .R�5      � .+�5      �� $  border��6!   $��30��61   $��30��6<   $��Center=�6H   $��Center=�6e    . #��z��5   !   #��z��6M   
������ ._�5      � $��Center=�6#   $��Center=�6>   .+�5   "   F� $ btn_path��6'   $��2��6�   $��18��6�   $��18��6�   }�. $ NearestNeighbor=�6�   $ Bevel=�6$  ��69   �� *
Foreground+ �� " ��$ FindAncestor=���5   &   B� 5   *   .��5   .   E� $	 3,3&�69   .��5   2   �� $
	 15,3&�6>   5   /   E� 5   .   $	 3,9&�69   .��5   2   �� $
	 15,9&�6>   5   /   E� 5   .   $
 3,15&�69   .��5   2   �� $	 15,15&�6>   5   /   E� 5   .   $	 0,0&�69   .��5   2   �� $		 0,0&�6>   5   /   E� 5   .   $	 0,0&�69   .��5    2   �� $		 0,0&�6>   5!   /   E� 5"   .   $
 18,0&�69   .��5#   2   �� $
	 18,0&�6>   5$   /   E� 5%   .   $
 0,18&�69   .��5&   2   �� $
	 0,18&�6>   5'   /   5(   +   5*   #   5+      5,      5-      
 5.      P� 5/       �@J�IsMouseOver . . �50      �� $ border��6%    � ��
 ���� 6O   �� 51      $ border��6%   # �  6P    � ���� 52      $ btn_path��6%   # �  6M    � �� 53      �� 54   "   .��55   &   �� .��56   *   *� $C =(Path.Data).(PathGeometry.Figures)[0].(PathFigure.StartPoint)�6G   $ btn_path��6�   .'�57   .      $ 0:0:0.1��6B    5,56T   58   +   *� 59   *   $X R(Path.Data).(PathGeometry.Figures)[0].(PathFigure.Segments)[0].(LineSegment.Point)�6G   $ btn_path��6�   .'�5:   .      $ 0:0:0.1��6B    13,56T   5;   +   *� 5<   *   $C =(Path.Data).(PathGeometry.Figures)[1].(PathFigure.StartPoint)�6G   $ btn_path��6�   .'�5=   .      $ 0:0:0.1��6B    5,96T   5>   +   *� 5?   *   $X R(Path.Data).(PathGeometry.Figures)[1].(PathFigure.Segments)[0].(LineSegment.Point)�6G   $ btn_path��6�   .'�5@   .      $ 0:0:0.1��6B    13,96T   5A   +   *� 5B   *   $C =(Path.Data).(PathGeometry.Figures)[2].(PathFigure.StartPoint)�6G   $ btn_path��6�   .'�5C   .      $ 0:0:0.1��6B    5,136T   5D   +   *� 5E   *   $X R(Path.Data).(PathGeometry.Figures)[2].(PathFigure.Segments)[0].(LineSegment.Point)�6G   $ btn_path��6�   .'�5F   .      $ 0:0:0.1��6B   	 13,136T   5G   +   *� 5H   *   $C =(Path.Data).(PathGeometry.Figures)[3].(PathFigure.StartPoint)�6G   $ btn_path��6�   .'�5I   .      $ 0:0:0.05��6B    0,06U   5J   +   *� 5K   *   $X R(Path.Data).(PathGeometry.Figures)[3].(PathFigure.Segments)[0].(LineSegment.Point)�6G   $ btn_path��6�   .'�5L   .      $ 0:0:0.05��6B    18,06U   5M   +   *� 5N   *   $C =(Path.Data).(PathGeometry.Figures)[4].(PathFigure.StartPoint)�6G   $ btn_path��6�   .'�5O   .      $ 0:0:0.05��6B    0,06U   5P   +   *� 5Q   *   $X R(Path.Data).(PathGeometry.Figures)[4].(PathFigure.Segments)[0].(LineSegment.Point)�6G   $ btn_path��6�   .'�5R   .      $ 0:0:0.05��6B    0,186U   5S   +   *� 5T   *   $C =(Path.Data).(PathGeometry.Figures)[5].(PathFigure.StartPoint)�6G   $ btn_path��6�   $ 0:0:0.05X�6�   .'�5U   .      $ 0:0:0.1��6B    18,06T   5V   +   *� 5W   *   $X R(Path.Data).(PathGeometry.Figures)[5].(PathFigure.Segments)[0].(LineSegment.Point)�6G   $ btn_path��6�   $ 0:0:0.05X�6�   .'�5X   .      $ 0:0:0.1��6B   	 18,186T   5Y   +   *� 5Z   *   $C =(Path.Data).(PathGeometry.Figures)[6].(PathFigure.StartPoint)�6G   $ btn_path��6�   $ 0:0:0.05X�6�   .'�5[   .      $ 0:0:0.1��6B    0,186T   5\   +   *� 5]   *   $X R(Path.Data).(PathGeometry.Figures)[6].(PathFigure.Segments)[0].(LineSegment.Point)�6G   $ btn_path��6�   $ 0:0:0.05X�6�   .'�5^   .      $ 0:0:0.1��6B   	 18,186T   5_   +   5`   '   5a   #    5c      �� 5d   "   .��5e   &   �� .��5f   *   *� $C =(Path.Data).(PathGeometry.Figures)[0].(PathFigure.StartPoint)�6G   $ btn_path��6�   .'�5g   .      $ 0:0:0.1��6B    3,36T   5h   +   *� 5i   *   $X R(Path.Data).(PathGeometry.Figures)[0].(PathFigure.Segments)[0].(LineSegment.Point)�6G   $ btn_path��6�   .'�5j   .      $ 0:0:0.1��6B    15,36T   5k   +   *� 5l   *   $C =(Path.Data).(PathGeometry.Figures)[1].(PathFigure.StartPoint)�6G   $ btn_path��6�   .'�5m   .      $ 0:0:0.1��6B    3,96T   5n   +   *� 5o   *   $X R(Path.Data).(PathGeometry.Figures)[1].(PathFigure.Segments)[0].(LineSegment.Point)�6G   $ btn_path��6�   .'�5p   .      $ 0:0:0.1��6B    15,96T   5q   +   *� 5r   *   $C =(Path.Data).(PathGeometry.Figures)[2].(PathFigure.StartPoint)�6G   $ btn_path��6�   .'�5s   .      $ 0:0:0.1��6B    3,156T   5t   +   *� 5u   *   $X R(Path.Data).(PathGeometry.Figures)[2].(PathFigure.Segments)[0].(LineSegment.Point)�6G   $ btn_path��6�   .'�5v   .      $ 0:0:0.1��6B   	 15,156T   5w   +   *� 5x   *   $C =(Path.Data).(PathGeometry.Figures)[3].(PathFigure.StartPoint)�6G   $ btn_path��6�   $ 0:0:0.05X�6�   .'�5y   .      $ 0:0:0.1��6B    0,06T   5z   +   *� 5{   *   $X R(Path.Data).(PathGeometry.Figures)[3].(PathFigure.Segments)[0].(LineSegment.Point)�6G   $ btn_path��6�   $ 0:0:0.05X�6�   .'�5|   .      $ 0:0:0.1��6B    0,06T   5}   +   *� 5~   *   $C =(Path.Data).(PathGeometry.Figures)[4].(PathFigure.StartPoint)�6G   $ btn_path��6�   $ 0:0:0.05X�6�   .'�5   .      $ 0:0:0.1��6B    0,06T   5�   +   *� 5�   *   $X R(Path.Data).(PathGeometry.Figures)[4].(PathFigure.Segments)[0].(LineSegment.Point)�6G   $ btn_path��6�   $ 0:0:0.05X�6�   .'�5�   .      $ 0:0:0.1��6B    0,06T   5�   +   *� 5�   *   $C =(Path.Data).(PathGeometry.Figures)[5].(PathFigure.StartPoint)�6G   $ btn_path��6�   .'�5�   .      $ 0:0:0.05��6B    18,06U   5�   +   *� 5�   *   $X R(Path.Data).(PathGeometry.Figures)[5].(PathFigure.Segments)[0].(LineSegment.Point)�6G   $ btn_path��6�   .'�5�   .      $ 0:0:0.05��6B    18,06U   5�   +   *� 5�   *   $C =(Path.Data).(PathGeometry.Figures)[6].(PathFigure.StartPoint)�6G   $ btn_path��6�   .'�5�   .      $ 0:0:0.05��6B    0,186U   5�   +   *� 5�   *   $X R(Path.Data).(PathGeometry.Figures)[6].(PathFigure.Segments)[0].(LineSegment.Point)�6G   $ btn_path��6�   .'�5�   .      $ 0:0:0.05��6B    0,186U   5�   +   5�   '   5�   #   5�      5�      5�      5�      �� 5�      " m�6@   .R�5�   
   �� $  templateRoot��6   #��z��6'   #��z��6S    . ._�5�      � $��Center=�6   .+�5�      �� $ headerContent��6#   #��z��5�   #   #��z��5�   #   # z 5�   #   $��Header��5�   #   #��z��5�   #   ��. # z 5�   #   � 5�      $ 
PART_Popup��6    . |�.  $��Slide=�5�      $
��Left=�5�      $ 30��5�      $ 30��5�      ��5�      �� *IsSubmenuOpen+ �� *TemplatedParent+.��5�      �� $  SubMenuBorder��6   $��0q�65   $��1��6I   
������ $��5q�6o    5�        5�      $  Black��6/   $! 5Q�6=   $" 0Q�6L   $	# 0.5Q�6\   ._�5�      � $ 5�      �� 5�   "   $��5 �60   �� 5�   "   $��* �60   .+�5�      �� $��0q�6%   $��1��69   #���  6G   ._�5�   "   �� $% SubMenuScrollViewer��6/   ��6L   C� *�� $& MenuScrollViewer��"' �+.��5�   &   � $( Enabled=�6+   .+�5�   *   �� $
��Left=�61   $��0��6L   $	��Top=�6W   $��0��6o   .+�5�   .   �� $) 
OpaqueRect��68   ��6L   �� *
Background+$* SubMenuBorder����6�   �� *ActualHeight+$* SubMenuBorder����6�   �� *ActualWidth+$* SubMenuBorder��5�   +   �� 5�   *   $+ ItemsPresenter��69   $, Cycle=�6Q   - . # z 6�   $. Cycle=�6�   5�   '   5�   #   5�      5�      5�      5�      5�      5�      
 5�   
   P� 5�      " �@m�IsSuspendingPopupAnimation . . �5�      �� $ 
PART_Popup��63    � ��$
 None=�6K   5�      P� 5�       � {� .  . �5�      �� $ templateRoot��6;    � �� �	#FF7070706U   5�      P� 5�      $/ SubMenuScrollViewer��62    � �� .  . �5�      �� $ 
OpaqueRect��6/    6G   �� *VerticalOffset+$* SubMenuScrollViewer�� �@��Top�� 5�      $ 
OpaqueRect��60    6H   �� *HorizontalOffset+$* SubMenuScrollViewer�� �@��Left5�      5�      �� 5�      " m�6B   .R�5�   
   �� $  templateRoot��6   #��z��6'   #��z��6S    . ._�5�      � .+�5�      �� $) bg_rect��6   #��z��6-   #��z��6M   #���  6o   $0 0Q�6�   � 5�      $��Center=�6   .+�5�      �� $ headerContent��6'   #��z��5�   #   #��z��5�   #   # z 5�   #   $��Header��5�   #   #��z��5�   #   ��. # z 5�   #   � 5�      $ 
PART_Popup��6    . |�.  $��Slide=�5�      $
��Left=�5�      ��5�      �� *IsSubmenuOpen+ �� *TemplatedParent+.��5�      �� $  SubMenuBorder��6!   $��0q�69   $��1��6M   
������ $��5q�6s    5�        5�   "   $  Black��63   $! 5Q�6A   $" 0Q�6P   $	# 0.5Q�6`   ._�5�      � $ 5�   "   �� 5�   &   $��5 �64   �� 5�   &   $��* �64   .+�5�   "   �� $��0q�6)   $��1��6=   #���  6K   ._�5�   &   �� $% SubMenuScrollViewer��63   ��6P   C� *�� $& MenuScrollViewer��"' �+.��5�   *   � $( Enabled=�6/   .+�5�   .   �� $
��Left=�65   $��0��6P   $	��Top=�6[   $��0��6s   .+�5�   2   �� $) 
OpaqueRect��6<   ��6P   �� *
Background+$* SubMenuBorder����6�   �� *ActualHeight+$* SubMenuBorder����6�   �� *ActualWidth+$* SubMenuBorder��5�   /   �� 5�   .   $+ ItemsPresenter��6=   $, Cycle=�6U   - . # z 6�   $. Cycle=�6�   5�   +   5�   '   5�   #   5�      5�      5�      5�      5�      5�      
 5�   
   P� 5�      " �@m�IsSuspendingPopupAnimation . . �5�      �� $ 
PART_Popup��63    � ��$
 None=�6K   5      P� 5      � {� .  . �5     �� $ templateRoot��6;    � �� �	#FF7070706U   5     P� 5      �@m�IsHighlighted . . �5     �� $ headerContent��6;    � ��
 �����6V   5     P� 5      �@J�IsMouseOver .  5     �� 5	     .��5
     �� .��5     U� $ (UIElement.Opacity)�6<   $ bg_rect��6l   .\�5  "     $1 0��67   2 06C     5  "   $1 0:0:0.1��67   2 16I   5     5     5      5     �� 5     .��5     �� .��5     U� $ (UIElement.Opacity)�6<   $ bg_rect��6l   .\�5  "     $1 0��67   2 16C     5  "   $1 0:0:0.1��67   2 06I   5     5     5     5     P� 5     $/ SubMenuScrollViewer��62    � �� .  . �5     �� $ 
OpaqueRect��6/    6G   �� *VerticalOffset+$* SubMenuScrollViewer�� �@��Top�� 5     $ 
OpaqueRect��60    6H   �� *HorizontalOffset+$* SubMenuScrollViewer�� �@��Left5      5"     �� 5$     " m�6:   .R�5%  
   �� $  templateRoot��6    . ._�5'     � .+�5(     �� $) bg_rect��6   #��z��6-   #��z��6M   #���  6o   $0 0Q�6�   � 5)     $
3 grid��6   $��Center=�6%   .+�5*     �� $ headerContent��6'   #��z��5+  #   #��z��5,  #   # z 5-  #   $��Header��5.  #   #��z��5/  #   ��. # z 51  #   � 52     $ 
PART_Popup��6    . |�.  $
��Fade=�54     $
��Left=�55     ��53     �� *IsSubmenuOpen+ �� *TemplatedParent+.��56     �� $  SubMenuBorder��6!   ._�57     �� $% SubMenuScrollViewer��6+   ��6H   C� *�� $& MenuScrollViewer��"' �+.��58  "   � $( Enabled=�6'   .+�59  &   �� $
��Left=�6-   $��0��6H   $	��Top=�6S   $��0��6k   .+�5:  *   �� $) 
OpaqueRect��64   ��5;  0   �� *
Background+$* SubMenuBorder����5<  0   �� *ActualHeight+$* SubMenuBorder����5=  0   �� *ActualWidth+$* SubMenuBorder��5>  '   �� 5?  &   $+ ItemsPresenter��65   $, Cycle=�6M   - . # z 6�   $. Cycle=�6�   5@  #   5A     5B     5C     5D     5F     5G     
 5H  
   P� 5I     " �@m�IsSuspendingPopupAnimation . . �5J     �� $ 
PART_Popup��63    � ��$
 None=�6K   5K     P� 5L      �@m�IsHighlighted . . �5M     �� $ headerContent��6;    � ��
 �����6V   5N     P� 5O      �@J�IsMouseOver .  5P     �� 5Q     .��5R     �� .��5S     U� $ (UIElement.Opacity)�6<   $ bg_rect��6l   .\�5T  "     $1 0��67   2 06C     5U  "   $1 0:0:0.15��67   2 16J   5V     5W     5X      5Z     �� 5[     .��5\     �� .��5]     U� $ (UIElement.Opacity)�6<   $ bg_rect��6l   .\�5^  "     $1 0��67   2 16C     5_  "   $1 0:0:0.15��67   2 06J   5`     5a     5b     5d     P� 5e      � {� .  . �5f     �� $ templateRoot��6;    � �� �	#FF7070706U   5g     P� 5h     $/ SubMenuScrollViewer��62    � �� .  . �5i     �� $ 
OpaqueRect��6/    6G   �� *VerticalOffset+$* SubMenuScrollViewer�� �@��Top�� 5j     $ 
OpaqueRect��60    6H   �� *HorizontalOffset+$* SubMenuScrollViewer�� �@��Left5k     5m     �� 5o     "4 ��6'   .�5p  
   ��  � �� �	#FFD7D7D76'   �� 5q  
    � �� �	#FFD7D7D76(   �� 5r  
    � ��$ 1��6&   �� 5s  
    �@J�SnapsToDevicePixels . 60   �� 5t  
    � �� 5u     �� 5v     " ��6"   .R�5w     �� #��z��6   #��z��6I   #��z��6}   $��0,0,0,0q�6�   5x     5z     5{     �� 5}     "4 m�6&   .�5~  
   ��  � �� 67   �� *HorizontalContentAlignment+ �� *FindAncestor+$5 1��" ���� 5  
    � �� 65   �� *VerticalContentAlignment+ �� *FindAncestor+$5 1��" ���� 5�  
    � ��
 ���� 6'   �� 5�  
    � ��
 ���� 6(   �� 5�  
    � ��$ 1q�6,   �� 5�  
    �@��PanningMode$
 Both=�65   �� 5�  
    �@��IsFlicksEnabled .  63   �� 5�  
    � �� 6%   C� *�� $& SubmenuItemTemplateKey��"' m�+6 5�  
   P� 5�      �@m�Role$ TopLevelHeader=�6&   . �5�     ��  � �� 6-   C� *�� $& TopLevelHeaderTemplateKey��"' m�+�� 5�      � ��$	 6,0q�6,   5�     P� 5�      �@m�Role$ TopLevelItem=�6&   . �5�     ��  � �� 6-   C� *�� $& TopLevelItemTemplateKey��"' m�+�� 5�      � ��$	 6,0q�6,   5�     P� 5�      �@m�Role$ SubmenuHeader=�6&   . �5�     ��  � �� 6-   C� *�� $& SubmenuHeaderTemplateKey��"' m�+5�     5�     �� 5�     "4 o�6"   .�5�  
   ��  � ��
 ���� 6'   �� 5�  
    � ��$ Center=�60   �� 5�  
    � ��$ Center=�6.   �� 5�  
    � �� .  6&   6 5�  
   P� 5�      �@J�IsMouseOver . . �5�     ��  � ��
 ���� 6/   5�     5�     5�     