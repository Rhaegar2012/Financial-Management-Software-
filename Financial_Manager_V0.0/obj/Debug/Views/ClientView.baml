   M S B A M L   `   `   `  ����Q  MFinancial_Manager_V0.0, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:Financial_Manager_V0._0.ViewsFinancial_Manager_V0._0.Views  5      U/clr-namespace:Financial_Manager_V0._0.ViewModel!Financial_Manager_V0._0.ViewModel  5      .    (Financial_Manager_V0._0.Views.ClientView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      =local+clr-namespace:Financial_Manager_V0._0.Views     5      F
viewmodels/clr-namespace:Financial_Manager_V0._0.ViewModel     5        � 	Resources  5
      7  1Financial_Manager_V0._0.ViewModel.ClientViewModel   	ModelView��%   &	          5   
   6%   5       � DataContext 5      �� 5   
    �� Source# [  6   .��5      � 
�������.+�5   
   � 
������� � RowDefinitions 5      �� 5      �� 5      .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $ Vertical=�6   .+�5      �� $
��Name��6    $��12(�6,   $��Century Gothic)�6:   $��20,20,10,20q�6V   �� 5      $��Email��6    $��12(�6-   $��Century Gothic)�6;   $��
20,10,5,20q�6W   �� 5      $��Phone��6    $��12(�6-   $��Century Gothic)�6;   $��	20,7,5,20q�6W   �� 5      $��Address��6    $��12(�6/   $��Century Gothic)�6=   $��
20,0,10,20q�6Y   �� 5      $
��City��6    $��12(�6,   $��Century Gothic)�6:   $��
20,0,10,20q�6V   �� 5      $��Zip Code��6    $��12(�60   $��Century Gothic)�6>   $��
20,0,10,20q�6Z   5      �� 5      $ Vertical=�6   .+�5       �� $��	15,20,0,5q�6F   $	��100��6Y   ��6   �� *
ClientName+ �� Mode$ TwoWay=�6Y   �� 5!      $��	15,20,0,5q�6G   $	��100��6Z   ��6   �� *ClientEmail+$ TwoWay=�6Z   �� 5"      $��	15,20,0,5q�6H   $	��100��6[   ��6   �� *ClientPhone+$ TwoWay=�6[   �� 5#      $��	15,10,0,5q�6J   $	��100��6]   ��6   �� *ClientAddress+$ TwoWay=�6]   �� 5$      $��	15,12,0,5q�6G   $	��100��6Z   ��6   �� *
ClientCity+$ TwoWay=�6Z   �� 5%      $��	15,12,0,5q�6J   $	��100��6]   ��6   �� *ClientZipCode+$ TwoWay=�6]   �� 5&      -   5         ��Name$ AddItemButton��5&      
������ 
������ $��	10,10,5,0q�5)      ��5*      �� *AddClientButton+.��5+      �� $��Add_button.png��6    $��25��68   $��25��6D   5,      5-      �� 5.      $ Vertical=�6   $��	30,0,20,0q�64   .+�5/      �� $��
Add Client��6    $��12(�62   $��Century Gothic)�6@   $��0,23,0,0q�6\   �� 50      $��Search Client��6    $��12(�65   $��Century Gothic)�6C   $��0,30,0,0q�6_   �� 51      -   5        $ SearchItemButton��51      $��0,22,0,0q�52      $��12(�53      $��Century Gothic)�54      
����� �
�������$��Search��57      ��58      �� *SearchClientButton+59      �� 5:      $ Vertical=�6   $��2,0,20,0q�64   .+�5;      �� -   5        $ AddClientButton��5;      
������ 
������ $��	10,15,5,0q�5>      ��5?      �� *AddClientButton+.��5@      �� $��Add_button.png��6    $��25��68   $��25��6D   5A      �� 5B      $��0,22,0,5q�6H   $	��100��6Z   ��6   �� *ClientQuery+$ TwoWay=�6Z   5C      5D      �� 5E      $ Vertical=�6   $��1��60   .+�5F      �� $��Search Results��6   $��12(�62   $��Century Gothic)�6@   $��	15,23,0,0q�6\   �� 5G      $ 
Horizontal=�6   .+�5H      �� $��Client Name��6    $��12(�63   $��Century Gothic)�6A   $��	15,23,0,0q�6]   �� 5I      $��Email��6    $��12(�6-   $��Century Gothic)�6;   $��	15,23,0,0q�6W   �� 5J      $��Phone��6    $��12(�6-   $��Century Gothic)�6;   $��	15,23,0,0q�6W   �� 5K      $��Address��6    $��12(�6/   $��Century Gothic)�6=   $��	15,23,0,0q�6Y   �� 5L      $
��City��6    $��12(�6,   $��Century Gothic)�6:   $��	15,23,0,0q�6V   �� 5M      $��Zip Code��6    $��12(�60   $��Century Gothic)�6>   $��	15,23,0,0q�6Z   5N      �� 5O      $ 
Horizontal=�6   .+�5P      �� $��12(�6G   $��Century Gothic)�6U   $��	15,23,0,0q�6q   ��6    �� *	QueryName+$ TwoWay=�6q   �� 5Q      $��12(�6H   $��Century Gothic)�6V   $��	15,23,0,0q�6r   ��6    �� *
QueryEmail+$ TwoWay=�6r   �� 5R      $��12(�6I   $��Century Gothic)�6W   $��	15,23,0,0q�6s   ��6    �� *
QueryPhone+$ TwoWay=�6s   �� 5S      $��12(�6J   $��Century Gothic)�6X   $��	15,23,0,0q�6t   ��6    �� *QueryAddress+$ TwoWay=�6t   �� 5T      $��12(�6H   $��Century Gothic)�6V   $��	15,23,0,0q�6r   ��6    �� *	QueryCity+$ TwoWay=�6r   �� 5U      $��12(�6G   $��Century Gothic)�6U   $��	15,23,0,0q�6q   ��6    �� *
QueryZip+$ TwoWay=�6q   5V      5W      5X      5Y      5Z      