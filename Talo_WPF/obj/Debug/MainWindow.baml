   M S B A M L   `   `   `  ����C  ?Talo_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:Talo_WPFTalo_WPF  5   	       Talo_WPF.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Talo_WPF     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��99* �6   �� 5      $
��118* �6   .+�5   
   �� -   5         ��Name$ btn_keittiövalot��5      $��Keittiön valot��6+   $
��Left=�6D   $��542,126,0,0q�6_   $	��Top=�6t   $��82��6�   6�   �� 5   
   -   5        $ btn_OlohuoneenValot��5      $��Olohuoneen valot��6.   $
��Left=�6I   $��542,162,0,0q�6d   $	��Top=�6y   6�   �� 5   
   -   5        $ btn_OviLukkoon��5      $��Ovi Lukkoon��6)   $
��Left=�6?   $��	542,4,0,0q�6Z   $	��Top=�6m    J� RenderTransformOrigin$ 0.336,0.122&�6�   $��1��6�   �� 5   
   -   5         ��Name$ txt_lämpötila��5      $
��Left=�6+   $��	351,0,0,0q�6F   $
��Wrap=�6Y   $��	TextBlock��6m   $��Center=�6~   �� 5   
   -   5        $ txt_keittiönvalot��5      $
��Left=�6/   $��676,130,0,0q�6J   $
��Wrap=�6_   $��	TextBlock��6s   $	��Top=�6�   �� 5   
   -   5        $ txt_olohuoneenvalot��5      $
��Left=�61   $��676,166,0,0q�6L   $
��Wrap=�6a   $��	TextBlock��6u   $	��Top=�6�   �� 5   
   -   5        $ txt_ovilukkoon��5      $
��Left=�6,   $��	676,8,0,0q�6G   $
��Wrap=�6Z   $��	TextBlock��6n   $	��Top=�6   $��1��6�   �� 5   
   -   5         ��Name$ slider_lämpötila��5      $
��Left=�6+   $��316,166,0,0q�6F   $	��Top=�6[   $	��120��6s    � SmallChange$ 0Q�6�    � Maximum$ 25Q�6�    � Minimum$ 15Q�6�   	 � Value$	 15Q�6�   �� 5   
   $
��Left=�6   $	��100��6+   $��100,126,0,0q�68   $	��Top=�6M   $	��100��6e   $��2��6q   �� 5   
   $��44,80,569,201q�6   $��/Image1.png��6'   $
��Fill=�6<   $��2��6K   5      5      