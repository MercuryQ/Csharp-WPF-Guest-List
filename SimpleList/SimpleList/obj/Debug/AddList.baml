   M S B A M L   `   `   `  ����E  ASimpleList, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:SimpleList
SimpleList  5   	       SimpleList.AddList   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:SimpleList     5   	     � Title$  AddList��5   	   $��648.385��6   $��795.668��6*   .��5	      � -   5         �Name$ backM��5	   	   #��� ��6   $��0,0,-0.4,-3.6q�6_    � ColumnDefinitions 5
      �� 5      $
��793* �6   �� 5      .+�5      �� -   5         ��Name$ addName��5      $
��Left=�6   $��30��6:   $��
10,452,0,0q�6F    �� TextWrapping$
 Wrap=�6Z   $	��Top=�6n   $	��225��6�   $��Times New Roman)�6�   $��20(�6�    �� 	MaxLength$ 20��6�   �� 5      $��
Enter Name��6   $
��Left=�6!   $��
10,380,0,0q�6<   $	��Top=�6P   $	��201��6h   $��Vivaldi)�6t   $��36(�6�   $��
ExtraBlack"�6�   &   System.Windows.Media.TextOptions   TextHintingMode$ Fixed=�6�   $��54��6�   �� 5      -   5         ��Name$ GoHome��5      $
��Back��6   $
��Left=�6,   $��692,514,0,0q�6G   $	��Top=�6\   $��75��6t   $��Times New Roman)�6   $��20(�6�   $��27��6�   �� 5      -   5        $ 	AddPerson��5      $	��Add��6    $
��Left=�6.   $��
10,507,0,0q�6I   $	��Top=�6]   $��75��6u   $��Times New Roman)�6�   $��20(�6�   $��27��6�   �� 5      -   5         ��Name$ myNames��5      $
��Left=�6   $	��413��6:   $��
268,21,0,0q�6G   $	��Top=�6[   $	��297��6s   $��Times New Roman)�6   $��20(�6�   �� 5      -   5        $ 
ShowPeople��5      $��View Current List��6!   $
��Left=�6=   $��268,455,0,0q�6X   $	��Top=�6m   $	��180��6�   $��Times New Roman)�6�   $��20(�6�   	 J� RenderTransformOrigin$	 
0.41,2.406&�6�   �� 5      -   5        $ 	ResetList��5      $��Reset��6    $
��Left=�60   $��490,455,0,0q�6K   $	��Top=�6`   $��75��6x   $��27��6�   $��Times New Roman)�6�   $��20(�6�   6�   �� 5      -   5        $ RemoveLastG��5      $��
Remove All��6"   $
��Left=�67   $��268,507,0,0q�6R   $	��Top=�6g   $	��180��6   $��27��6�   $��Times New Roman)�6�   $��20(�6�   6�   5      5      