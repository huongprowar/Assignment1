   M S B A M L   `   `   `  ����F  BSalesWPFApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SalesWPFAppSalesWPFApp  5   	       SalesWPFApp.WindowMembers   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:SalesWPFApp     5   	     � Title$  WindowMembers��5   	   $	��600��6   $	��800��6,   .��5	      � .+�5
   
   ]� $	��Top=�6   $��10q�6,   .+�5      �  � RowDefinitions 5      �� 5      $
��Auto �6$   �� 5      $��2* �6$   �� 5      $��4* �6$   �� 5      $��2* �6$   .+�5      �� $��0��6   
����ح� �� Orientation$ Vertical=�6A   $
��Left=�6Y   $	��800��6t   .+�5      �� -   5        $��lbTitle��5      
���  ��$��DemiBold"�6<   $��20(�6R   $��Member Information��6`   �� 5      -   5        $��
lbMemberId��5      $��	Member Id��6.   �� 5      -   5        $��txtMemberId��5      $��Stretch=�61   $��25��6O   ��5      ��  �� Path$ MemberId� �� Mode$ OneWay=� � DataContext 6A   ��  �� ElementName$ 	lvMembers��$ SelectedItem��� 5      -   5        $��lbEmail��5      $��Email��6+   �� 5      -   5        $��txtEmail��5      $��Stretch=�6.   $��25��6L   ��5      �� $ Email�$ OneWay=� 6>   �� $ 	lvMembers��$ SelectedItem��� 5      -   5        $��lbCompanyName��5      $��CompanyName��61   �� 5      -   5        $��txtCompanyName��5      $��Stretch=�64   $��25��6R   ��5      �� $ CompanyName�$ OneWay=� 6D   �� $ 	lvMembers��$ SelectedItem��� 5      -   5        $��lbCity��5      $
��City��6*   �� 5      -	   5        $��txtCity��5      $��Stretch=�6-   $��25��6K   ��5       �� $
 City�$ OneWay=� 6=   �� $ 	lvMembers��$ SelectedItem��� 5!      -
   5        $��	lbCountry��5!      $��Country��6-   �� 5"      -   5        $��
txtCountry��5"      $��Stretch=�60   $��25��6N   ��5#      �� $ Country�$ OneWay=� 6@   �� $ 	lvMembers��$ SelectedItem��� 5$      -   5        $��
lbPassword��5$      $��Password��6.   �� 5%      -   5        $��txtPassword��5%      $��Stretch=�61   $��25��6O   ��5&      �� $ Password�$ OneWay=� 6A   �� $ 	lvMembers��$ SelectedItem�5'      �� 5)      $��1��6   $ 
Horizontal=�6*   $
��Left=�6C   .+�5*      �� -   5         ��Name$ btnLoad��5*      $��10q�6.   $��80��6:   $
��Load��6E   6T   �� 5+      -   5        $ 	btnInsert��5+      $��10q�60   $��80��6<   $��Insert��6G   6X   �� 5,      -   5        $ 	btnUpdate��5,      $��10q�60   $��80��6<   $��Update��6G   6X   �� 5-      -   5        $ 	btnDelete��5-      $��10q�60   $��80��6<   $��Delete��6G   6X   5.      �� 5/      -   5        $��	lvMembers��5/   (   $��2��6   $
��Auto��69   $
��Auto��6F    �� View 50      �� 51      .P�52      �� $��	Member Id��6-   	 �� Width$	 50��6@   
 �� DisplayMemberBinding
 6K   �� $ MemberId��� 53      $��Email��6-   $		 200��6<   
 6H   �� $ Email��� 54      $��Company Name��6-   $		 200��6C   
 6O   �� $ CompanyName��� 55      $
��City��6-   $		 100��6;   
 6G   �� $
 City��� 56      $��Country��6-   $		 100��6>   
 6J   �� $ Country��� 57      $��Password��6-   $		 100��6?   
 6K   �� $ Password�58      5:      �� 5;      -   5        $ btnClose��5;   &   $��3��6   $��10q�68   $��Right=�6D   $��Bottom=�6`   $��80��5<      $��Close��6   6   5=      5>      5?      5@      