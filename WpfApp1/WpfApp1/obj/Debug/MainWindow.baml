   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � ShowGridLines .  � RowDefinitions 5
   
   �� 5      $
��auto �6   �� 5      �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      $	��200 �6   �� 5      .+�5   
   �� $��./Photo/photo.jpg��5      $��2��5      �� 5   
    �� Orientation$ Vertical=�5   	   $��3��5   	   $��Bottom=�5   	   .+�5      �� -   5         ��Name$ 
ExitButton��5      $��
Выход��5      $��50��5       5!      � 5#   
    � Orientation$ 
Horizontal=�5$   	   $��1��5%   	   $��50��5&   	   .+�5'      �� $��Город:��5(      $��Center=�5)      �� 5*      -   5        $��CityFilterComboBox��5+      $��Center=�5-      $	��100��5.       �� SelectedIndex$ 0��5/      ��50      �� *
CityList+��51      �� 52      .R�53      �� ��54      �� *Title+55      57      �� 58      $��Искать��59      $��Center=�5:      �� 5;      -   5         ��Name$ SearchFilterTexBox��5>      $	��200��5<      $��Center=�5=      5?      �� 5@      $��Сумма покупки��5A      $��Center=�5B      	� 5D      -   5        	 	� 	GroupName$	 Summapokupki��5E      

 � Tag$
 1��5F      $!��по возрастанию��5G       d� 	IsChecked$
 TrueY�5H      $��Center=�5J      	� 5K      -   5        $	 Summapokupki��5L      $
 2��5M      $��по убыванию��5N      $��Center=�5P      5R      &   System.Windows.Controls.DataGrid  5S   
   $��1��5T      $��1��5U         CanUserAddRows .     AutoGenerateColumns .  ��5X      �� *PokupateliList+   Columns 5Y      0  *System.Windows.Controls.DataGridTextColumn  5Z      ,  &System.Windows.Controls.DataGridColumn   Header$ Имя��5[      1  +System.Windows.Controls.DataGridBoundColumn   Binding 5\      �� *Name+  5]      $ Возраст��5^       5_      �� *Age+  5`      $ 
Город��5a       5b      �� *City+  5c      $ Сумма покупки��5d       5e      �� *Summapokupki+  5f      $ Дата покупки��5g       5h      �� *Data+  5i      $ Магазин��5j       5k      �� *	Magazin+5o      5t      5u      