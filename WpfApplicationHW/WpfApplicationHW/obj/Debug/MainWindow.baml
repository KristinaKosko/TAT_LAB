   M S B A M L   `   `   `  ����K  GWpfApplicationHW, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:WpfApplicationHWWpfApplicationHW  5   	   !    WpfApplicationHW.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:WpfApplicationHW     5   	     � Title$'  !Choose Folder Which Includes Dlls��5   	   $��500.792��63   $��700.176��6D    � 
ResizeMode$ NoResize=�6T   .��5	      �  J� RenderTransformOrigin$ 0.5,0.5&�6    � ColumnDefinitions 5
   
   �� 5      $
��239* �6   �� 5      $
��108* �6   �� 5      $��0* �6    � LayoutTransform 5   
   u� 5       u� Matrix$ Identityx�6   z�5   
   V� 5      .~�5      �� �� 5      �� 5      T� 5      5      .+�5   
   �� -   5         ��Name$ button��5      $��Browse��6!   $
��Left=�62   $��81.169,10,0,0q�6M   $	��Top=�6d   $��96��6|   $��26��6�   $��1��6�   �� 5   
   -   5         ��Name$ selectFolder��5      $��	24,12,0,0q�6(    �� TextWrapping$
 Wrap=�6;   $��Select folder...��6O   $	��493��6g   
�������$��14(�6�   $��Italic$�6�   ���	#FFB0B0B0$��2��6�   $
��Left=�6�   "	 �� VerticalScrollBarVisibility$
	 Auto=�6  $	��Top=�6+  $��24��6C  
 �� TextDecorations
 6�   Z� 6C  �� 5   
   -   5        $ dllExplorer��5      $
��Left=�6'   $��21��6B   $��
24,426,0,0q�6N   $
 Wrap=�6b   $��DLL Explorer��6v   $	��Top=�6�   $	��180��6�   {�.  $
��Bold"�6�   $��13(�6�    �� TextAlignment$ Center=�6�   �� 5   
   -   5        $ classesOfDll��5      $
��Left=�6(   $��21��6C   $��248,426,0,0q�6O   $
 Wrap=�6d   $��Classes of Dll��6x   $	��Top=�6�   $	��193��6�   {�.  $��13(�6�   $
��Bold"�6�   $ Center=�6�   �� 5   
   -   5        $ Content��5      $
��Left=�6#   $��21��6>   $��5.169,426,0,0q�6J   $
 Wrap=�6a   $��Content Of Class��6u   $	��Top=�6�   $	��183��6�   {�.  $��13(�6�   $
��Bold"�6�   $ Center=�6�   $��1��6�   �� 5   
   -   5         ��Name$
 dlls��5      $
��Left=�6    $	��306��6;   $��	24,89,0,0q�6H   $	��Top=�6[   $	��180��6s   6   �� 5    
   -   5        $ classes��5       $
��Left=�6#   $	��306��6>   $��
248,89,0,0q�6K   $	��Top=�6_   $	��193��6w   6�   �� 5!   
   -   5        $ methods��5!      $
��Left=�6#   $	��306��6>   $��5.169,89,0,0q�6K   $	��Top=�6a   $	��183��6y   $��1��6�   �� 5"   
   -	   5         ��Name$ chooseProperties��5"      $
��Left=�6-   $��81.169,51,0,0q�6H   $	��Top=�6_   $��96��6w   $��22��6�   $��1��6�   .@�5#      �� $	��All��6    �� 
IsSelected . 6)   �� 5$      $��Fields��6   �� 5%      $��
Properties��6   �� 5&      $��Methods��6   5'      5)      5*      