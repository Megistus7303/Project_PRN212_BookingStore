   M S B A M L   `   `   `  ����I  EProject_PRN212, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:PRN212_AssignmentPRN212_Assignment  5   	   d `Microsoft.Web.WebView2.Wpf, Version=1.0.864.35, Culture=neutral, PublicKeyToken=2a8ab48044d2601ekLclr-namespace:Microsoft.Web.WebView2.Wpf;assembly=Microsoft.Web.WebView2.WpfMicrosoft.Web.WebView2.Wpf 5   	        PRN212_Assignment.HomePage   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:PRN212_Assignment     5   	   \WpfLclr-namespace:Microsoft.Web.WebView2.Wpf;assembly=Microsoft.Web.WebView2.Wpf     5   	     � Title$  HomePage��5	   	   $	��550��6   $	��800��6'   .��5
      � .+�5   
   �� $	��Top=�6   $��44��6,   $��	0,0,587,0q�68   $��25(�6K   �� 5   
   $
�Book��6   $
��Bold"�6    �� 5   
   $�Shopping��6   $
��Bold"�6   
���  ��60   5      � 5   
    � Orientation$ 
Horizontal=�6   $��0,12,10,362q�6-   $��Right=�6B   $	��524��6^   .+�5      �� -   5         ��Name$ btnHomePage��5      $��	Home Page��6*   $	��108��6>   $��30��6J   �� 5      -   5        $ btnCart��5      $
��Cart��6&   $��12q�65   $	��100��6A   $��30��6M   6Y   �� 5      -   5        $ btnLogIn��5      $��Login��6(   $��12q�68   $	��100��6D   $��30��6P   6\   �� 5      -   5        $ 	btnSignUp��5      $��Sign Up��6)   $��12q�6;   $	��100��6G   $��30��6S   6_   5      �� 5   
   -   5         ��Name$ 
lvBookList��5      $��10,215,56,71q�6'    �� View 5      �� 5      .P�5      �� $��Image��6%    �� Width$	 100��64    �� CellTemplate 5      �� 5      .R�5   "   �� $	��100��6J   $	��100��6V   ��6(   ��  �� Path$ 	BookImage�6V   5      5      �� 5      $��	Book Name��6%   $	 200��68    �� DisplayMemberBinding 6D   �� *
BookName+�� 5       $��Author Name ��6%   $	 100��6;    6G   �� *
AuthorName+�� 5!      $��Genre��6%   $	 100��64    6@   �� *	GenreName+�� 5"      $��Number��6%   $	 100��65    6A   �� *
Quantity+�� 5#      $��Price��6%   $	 100��64    6@   �� *Price+5$      5&      � 5'   
   $��10,71,566,405q�6   .+�5(      �� -   5        	 ��Name$	 	txtSearch��5(      $
��Left=�6)   $��33��6D   $	��128��6P   �� 5)      -   5        $ 	btnSearch��5)      $��Search��6)   $��82��6:   6E   5*      5,      5-      