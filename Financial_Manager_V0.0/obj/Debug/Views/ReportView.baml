   M S B A M L   `   `   `  ����Q  MFinancial_Manager_V0.0, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:Financial_Manager_V0._0.ViewsFinancial_Manager_V0._0.Views  5      U/clr-namespace:Financial_Manager_V0._0.ViewModel!Financial_Manager_V0._0.ViewModel  5      .    (Financial_Manager_V0._0.Views.ReportView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      =local+clr-namespace:Financial_Manager_V0._0.Views     5      F
modelviews/clr-namespace:Financial_Manager_V0._0.ViewModel     5        � 	Resources  5
      7  1Financial_Manager_V0._0.ViewModel.ReportViewModel   	ModelView��%   &	          5   
   6%   5       � DataContext 5      �� 5   
    �� Source# [  6   .��5      � 
������� � RowDefinitions 5   
   �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $��0��6    �� Orientation$ Vertical=�6%   .+�5      �� $ 
Horizontal=�6   .+�5      �� $#��Number of Income Transactions��6   $��12(�6A   $��Century Gothic)�6O   $��
20,20,10,0q�6k   �� 5      $��12(�6S   $��Century Gothic)�6a   $��
17,20,10,0q�6}   ��6   �� *NumberIncomeTransactions+ �� Mode$ TwoWay=�6}   5      �� 5      $ 
Horizontal=�6   .+�5      �� $$��Number of Expense Transactions��6   $��12(�6B   $��Century Gothic)�6P   $��
20,20,10,0q�6l   �� 5      $��12(�6T   $��Century Gothic)�6b   $��
13,20,10,0q�6~   ��6   �� *NumberExpenseTransactions+$ TwoWay=�6~   5       �� 5!      $ 
Horizontal=�6   .+�5"      �� $��Top Selling product��6   $��12(�67   $��Century Gothic)�6E   $��
20,20,10,0q�6a   �� 5#      $��12(�6L   $��Century Gothic)�6Z   $��
90,20,10,0q�6v   ��6   �� *TopSellingProduct+$ TwoWay=�6v   5$      �� 5%      $ 
Horizontal=�6   .+�5&      �� $��Most Bought Item��6   $��12(�64   $��Century Gothic)�6B   $��
20,20,10,0q�6^   �� 5'      $��12(�6L   $��Century Gothic)�6Z   $��100,20,10,0q�6v   ��6   �� *MostBoughtProduct+$ TwoWay=�6v   5(      �� 5)      $ 
Horizontal=�6   .+�5*      �� $��
Top Client��6   $��12(�6.   $��Century Gothic)�6<   $��
20,20,10,0q�6X   �� 5+      $��12(�6D   $��Century Gothic)�6R   $��145,20,10,0q�6n   ��6   �� *	TopClient+$ TwoWay=�6n   5,      �� 5-      $ 
Horizontal=�6   .+�5.      �� $��Top Supplier ��6   $��12(�61   $��Century Gothic)�6?   $��
20,20,10,0q�6[   �� 5/      $��12(�6F   $��Century Gothic)�6T   $��130,20,10,0q�6p   ��6   �� *TopSupplier+$ TwoWay=�6p   50      �� 51      $ 
Horizontal=�6   .+�52      �� $��Total Income��6   $��12(�60   $��Century Gothic)�6>   $��
20,20,10,0q�6Z   �� 53      $��12(�6F   $��Century Gothic)�6T   $��127,20,10,0q�6p   ��6   �� *TotalIncome+$ TwoWay=�6p   54      �� 55      $ 
Horizontal=�6   .+�56      �� $��Total Expense��6   $��12(�61   $��Century Gothic)�6?   $��
20,20,10,0q�6[   �� 57      $��12(�6G   $��Century Gothic)�6U   $��127,20,10,0q�6q   ��6   �� *TotalExpense+$ TwoWay=�6q   58      �� 59      $��Print to PDF��6   $	��100��6,   $��Right=�68   $��0,30,0,0q�6T   5;      5=      5>      