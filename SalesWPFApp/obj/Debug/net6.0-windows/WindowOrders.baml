   M S B A M L   `   `   `  ����F  BSalesWPFApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SalesWPFAppSalesWPFApp  5   	       SalesWPFApp.WindowOrders   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:SalesWPFApp     5   	     � Title$  WindowOrders��5   	   $	��600��6   $	��800��6+   .��5	      � .+�5
   
   ]� $	��Top=�6   $��10q�6,   .+�5      �  � RowDefinitions 5      �� 5      $
��Auto �6$   �� 5      $��2* �6$   �� 5      $��4* �6$   �� 5      $��2* �6$   .+�5      �� $��0��6   
����ح� �� Orientation$ Vertical=�6A   $
��Left=�6Y   $	��800��6t   .+�5      �� -   5        $��lbTitle��5      
���  ��$��DemiBold"�6<   $��20(�6R   $��Order Information��6`   �� 5      -   5        $��	lbOrderId��5      $��Order Id��6-   �� 5      -   5        $��
txtOrderId��5      $��Stretch=�60   $��25��6N   ��5      ��  �� Path$ OrderId� �� Mode$ OneWay=� � DataContext 6@   ��  �� ElementName$ lvOrders��$ SelectedItem��� 5      -   5        $��
lbMemberId��5      $��	Member Id��6.   �� 5      -   5        $��txtMemberId��5      $��Stretch=�61   $��25��6O   ��5      �� $ MemberId�$ OneWay=� 6A   �� $ lvOrders��$ SelectedItem��� 5      -   5        $��lbOrderDate��5      $��
Order Date��6/   �� 5      -   5        $��txtOrderDate��5      $��Stretch=�62   $��25��6P   ��5      �� $ 	OrderDate�$ OneWay=� 6B   �� $ lvOrders��$ SelectedItem��� 5      -   5        $��lbRequiredDate��5      $��Required Date��62   �� 5      -	   5        $��txtRequiredDate��5      $��Stretch=�65   $��25��6S   ��5       �� $ RequiredDate�$ OneWay=� 6E   �� $ lvOrders��$ SelectedItem��� 5!      -
   5        $��lbShippedDate��5!      $��Shipped Date��61   �� 5"      -   5        $��txtShippedDate��5"      $��Stretch=�64   $��25��6R   ��5#      �� $ ShippedDate�$ OneWay=� 6D   �� $ lvOrders��$ SelectedItem��� 5$      -   5        $��	lbFreight��5$      $��Freight��6-   �� 5%      -   5        $��
txtFreight��5%      $��Stretch=�60   $��25��6N   ��5&      �� $ Freight�$ OneWay=� 6@   �� $ lvOrders��$ SelectedItem�5'      �� 5)      $��1��6   $ 
Horizontal=�6*   $
��Left=�6C   .+�5*      �� -   5         ��Name$ btnLoad��5*      $��10q�6.   $��80��6:   $
��Load��6E   6T   �� 5+      -   5        $ 	btnInsert��5+      $��10q�60   $��80��6<   $��Insert��6G   6X   �� 5,      -   5        $ 	btnUpdate��5,      $��10q�60   $��80��6<   $��Update��6G   6X   �� 5-      -   5        $ 	btnDelete��5-      $��10q�60   $��80��6<   $��Delete��6G   6X   5.      �� 5/      -   5        $��lvOrders��5/   (   $��2��6   $
��Auto��68   $
��Auto��6E    �� View 50      �� 51      .P�52      �� $��Order Id��6-   	 �� Width$	 50��6?   
 �� DisplayMemberBinding
 6J   �� $ OrderId��� 53      $��	Member Id��6-   $		 200��6@   
 6L   �� $ MemberId��� 54      $��
Order Date��6-   $		 200��6A   
 6M   �� $ 	OrderDate��� 55      $��Required Date��6-   $		 100��6D   
 6P   �� $ RequiredDate��� 56      $��Shipped Date��6-   $		 100��6C   
 6O   �� $ ShippedDate��� 57      $��Freight��6-   $		 100��6>   
 6J   �� $ Freight�58      5:      �� 5;      -   5        $ btnClose��5;   &   $��3��6   $��10q�68   $��Right=�6D   $��Bottom=�6`   $��80��5<      $��Close��6   6   5=      5>      5?      5@      