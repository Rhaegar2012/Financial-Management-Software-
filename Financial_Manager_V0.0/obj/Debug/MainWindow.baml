   M S B A M L   `   `   `  ����Q  MFinancial_Manager_V0.0, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Financial_Manager_V0._0Financial_Manager_V0._0  5   	   U/clr-namespace:Financial_Manager_V0._0.ViewModel!Financial_Manager_V0._0.ViewModel  5   	   M+clr-namespace:Financial_Manager_V0._0.ViewsFinancial_Manager_V0._0.Views  5   	   (    "Financial_Manager_V0._0.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:Financial_Manager_V0._0     5   	   F
viewmodels/clr-namespace:Financial_Manager_V0._0.ViewModel     5   	   =views+clr-namespace:Financial_Manager_V0._0.Views     5   	     � Title$  Financial Manager ��5
   	   $	��450��6$   $	��800��61    � 	Resources 5       �� DataType8  2Financial_Manager_V0._0.ViewModel.AccountViewModel3   -Financial_Manager_V0._0.Views.RegisterAccount � DataContext7  1Financial_Manager_V0._0.ViewModel.ReportViewModel.   (Financial_Manager_V0._0.Views.ReportView:  4Financial_Manager_V0._0.ViewModel.InventoryViewModel1   +Financial_Manager_V0._0.Views.InventoryView7  1Financial_Manager_V0._0.ViewModel.ClientViewModel.   (Financial_Manager_V0._0.Views.ClientView��%�  (��       5   ,   *, +)(�� P     5   +   *, +)(�� �     5   .   *, +)(�� �     5   +   *, +)�� 5   
   AccountView��"  6,   .R�5         6$   �� 5      �� 5   
   
ReportView��"  6+   .R�5         6   �� 5      �� 5   
   InventoryView��"  6.   .R�5         6"   �� 5      �� 5   
   
ClientView��"  6+   .R�5         6   �� 5      5      .��5      � 
������� � ColumnDefinitions 5   
   �� 5      $	��150 �6   �� 5      $
��Auto �6    � RowDefinitions 5   
   �� 5       �� 5!      .+�5#   
   ]� -   5         ]�Name$ 	MenuPanel��5#      $��0��6'   $��0��67   $��2��6D   
����� �$
��Left=�6n   $	��150��6�   .+�5$      ��  �� Orientation$ Vertical=�6   .+�5%      �� -   5        
������ 
������ $��30��5%   L   $��Right=�6X   $	��Top=�6t   .��5&      �� $��Icons/Menu.png��6   5'      �� 5(      
������ 
������ $��Century Gothic)�6R   $��12(�6n   
���   �.@�5)      �� $��30��6#   .��5*      �� $ 
Horizontal=�6%   .+�5+      �� -   5        
������ 
������ $��30��5+   Y   .��5,   "   �� $��icons/Account_filled.png��6(    J� Opacity$	 110Q�6J   5-      �� 5.      $��Register Account��6(   $��6q�6@   5/      50      �� 51      $��30��6#   .��52      �� $ 
Horizontal=�6%   .+�53      �� -   5        
������ 
������ $��30��53   X   .��54   "   �� $��icons/Report_filled.png��6(   $	 110Q�6I   55      �� 56      $��Report��6(   $��6,6,2,0q�66   57      58      �� 59      $��30��6#   .��5:      �� $ 
Horizontal=�6%   .+�5;      �� 
������ 
������ $��30��6X   .��5<   "   �� $ ��icons/Analytics_filled.png��6(   5=      �� 5>      $��	Analytics��6(   $��6q�69   5?      5@      �� 5A      $��30��6#   .��5B      �� $ 
Horizontal=�6%   .+�5C      �� -   5        
������ 
������ $��30��5C   X   .��5D   "   �� $!��Icons/Client_Filled.png.png��6(   5E      �� 5F      $��Clients��6(   $��6,6,2,0q�67   5G      5H      �� 5I      $��30��6#   .��5J      �� $ 
Horizontal=�6%   .+�5K      �� -   5        
������ 
������ $��30��5K   X   .��5L   "   �� $��icons/Quote_filled.png��6(   $	 110Q�6H   5M      �� 5N      $��	Inventory��6(   $��6,6,2,0q�69   5O      5P      5R      5S      5U      �� 5V   
   $��1��6   $��0��6)   $��2��66   ��6G   �� 5W      5X      