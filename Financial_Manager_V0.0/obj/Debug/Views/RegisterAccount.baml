   M S B A M L   `   `   `  ����Q  MFinancial_Manager_V0.0, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:Financial_Manager_V0._0.ViewsFinancial_Manager_V0._0.Views  5      U/clr-namespace:Financial_Manager_V0._0.ViewModel!Financial_Manager_V0._0.ViewModel  5      A%clr-namespace:Financial_Manager_V0._0Financial_Manager_V0._0  5      3    -Financial_Manager_V0._0.Views.RegisterAccount   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      =local+clr-namespace:Financial_Manager_V0._0.Views     5      F
viewmodels/clr-namespace:Financial_Manager_V0._0.ViewModel     5      9folders%clr-namespace:Financial_Manager_V0._0     5        � 	Resources  5      8  2Financial_Manager_V0._0.ViewModel.AccountViewModel   	ModelView��%   &	          5   
   6&   5       � DataContext 5      �� 5   
    �� Source# [  6   .��5      � 
������� � RowDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $��0��6    �� Orientation$ Vertical=�6#   $��Center=�6:   .+�5      �� $ 
Horizontal=�6   
�������.+�5      �� $ Vertical=�6   $��Center=�64   $��20,0,0,0q�6O   .+�5      �� -   5         ��Name$ InvoiceInput��5      
������ ��6N   �� *InvoiceNumber+ �� Mode$ TwoWay=��� 5      $��
Invoice No��6    $��12(�62   $��Century Gothic)�6@   5      �� 5      $ Vertical=�6   $��Center=�64   $��20,0,0,0q�6O   .+�5      �� -   5        $ ClientNameInput��5      
������ $
��Left=�6Q   $��80��6l   ��6w   �� *
ClientName+$ TwoWay=��� 5      $��Client/Supplier��6    $��12(�67   $��Century Gothic)�6E   5      �� 5       $ Vertical=�6   $��Center=�64   $��20,0,0,0q�6O   .+�5!      �� -   5         ��Name$ AccountComBox��5!      $��80��66   $��20��6A   $��0,0,0,0q�6M   $
��Left=�6^    �� SelectedItem 6y   �� *BillingType+$ TwoWay=�.@�5"      �� $��Invoice��6'   6;   �� 5#      $
��Bill��6'   68   5$      �� 5%      $��Account Type��6    $��12(�64   $��Century Gothic)�6B   5&      �� 5'      $ Vertical=�6   $��Center=�64   $��20,0,0,0q�6O   .+�5(      �� -   5        $ 	DateInput��5(      
������ $��80��6K   $
��Left=�6V   ��6r   �� *Date+$ TwoWay=��� 5)      $��Date MM/DD/YY��6    $��12(�65   $��Century Gothic)�6C   5*      5+      �� 5,      $ 
Horizontal=�6   .+�5-      �� $ Vertical=�6   $��Center=�64   $��20,0,0,0q�6O   .+�5.      �� -   5        $ 	ItemInput��5.      
������ $	��150��6K   $
��Left=�6W   ��6r   �� *
ItemName+$ TwoWay=��� 5/      $
��Item��6    $��12(�6,   $��Century Gothic)�6:   50      �� 51      $ Vertical=�6   $��Center=�64   $��20,0,0,0q�6O   .+�52      �� -   5        $ QuantityInput��52      
������ $��60��6O   $
��Left=�6Z   ��6u   �� *
Quantity+$ TwoWay=��� 53      $��Quantity��6    $��12(�60   $��Century Gothic)�6>   54      �� 55      $ Vertical=�6   $��Center=�64   $��20,0,0,0q�6O   .+�56      �� -   5        $ UnityPriceInput��56      
������ $��60��6Q   $
��Left=�6\   ��6w   �� *	UnitPrice+$ TwoWay=��� 57      $��
Unit Price��6    $��12(�62   $��Century Gothic)�6@   58      �� 59      -   5        	 ��Name$	 AddAccountButton��59      $��Center=�5:      $��60,20,20,20q�5;      
������ 
������ ��5>      �� *AddAccountButton+.��5?      �� $��Add_button.png��6   $��25��64   $��25��6@   5@      5A      �� 5B      -	   5        
 ��Name$
 ListViewLabel��5B      $��Recent Transaction��6/   $��12(�6I   $��Century Gothic)�6W   $��
20,20,10,0q�6s   �� 5C      $ 
Horizontal=�6   .+�5D      �� $ Vertical=�6   .+�5E      �� $��Client��6    $��12(�6.   $��Century Gothic)�6<   $��
20,20,10,0q�6X   �� 5F      $��1��6   $��2��6,   
�������
������ $��12(�6m   $��Century Gothic)�6{   $��
20,20,10,0q�6�   ��6�   �� *AddedClientList+6�   5G      �� 5H      $ Vertical=�6   .+�5I      �� $��
Invoice No��6    $��12(�62   $��Century Gothic)�6@   $��
20,20,10,0q�6\   �� 5J      $��1��6   $��2��6,   
�������
������ $��12(�6m   $��Century Gothic)�6{   $��
20,20,10,0q�6�   ��6�   �� *AddedInvoiceNumberList+6�   5L      �� 5M      $ Vertical=�6   .+�5N      �� $��Transaction Type��6    $��12(�68   $��Century Gothic)�6F   $��
20,20,10,0q�6b   �� 5O      $��1��6   $��2��6,   
�������
������ $��12(�6m   $��Century Gothic)�6{   $��
20,20,10,0q�6�   ��6�   �� *AddedTransactionTypeList+6�   5P      �� 5Q      $ Vertical=�6   .+�5R      �� $
��Item��6    $��12(�6,   $��Century Gothic)�6:   $��
20,20,10,0q�6V   �� 5S      $��1��6   $��2��6,   
�������
������ $��12(�6m   $��Century Gothic)�6{   $��
20,20,10,0q�6�   ��6�   �� *AddedItemNameList+6�   5U      �� 5V      $ Vertical=�6   .+�5W      �� $��Total Transaction��6    $��12(�69   $��Century Gothic)�6G   $��
20,20,10,0q�6c   �� 5X      $��1��6   $��2��6,   
�������
������ $��12(�6m   $��Century Gothic)�6{   $��
20,20,10,0q�6�   ��6�   �� *AddedTotalTransactionList+6�   5Z      �� 5[      $ Vertical=�6   .+�5\      �� $
��Date��6    $��12(�6,   $��Century Gothic)�6:   $��
20,20,10,0q�6V   �� 5]      $��1��6   $��2��6,   
�������
������ $��12(�6m   $��Century Gothic)�6{   $��
20,20,10,0q�6�   ��6�   �� *AddedDateList+6�   5^      5_      5`      5a      5b      