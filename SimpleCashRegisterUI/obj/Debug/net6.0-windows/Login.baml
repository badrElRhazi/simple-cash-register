   M S B A M L   `   `   `  ����O  KSimpleCashRegisterUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:SimpleCashRegisterUISimpleCashRegisterUI  5           SimpleCashRegisterUI.Login   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:SimpleCashRegisterUI     5      .��5	      �� $	��300��6   $	��400��5
      
�������  �� CornerRadius$  6��5      ._�5   
   ��  �� Orientation$ Vertical=�6   $��20q�5      .+�5      �� $��Login��6   $��25(�5      $��Center=�5      $	��Top=�5      $
��Bold"�5       �� Padding$ 10q�5      ���	#FF2EB7C86%   � 5      $��Center=�6    � RowDefinitions 5      �� 5      $��* �6$   �� 5      $��* �6$   �� 5      $��* �6$   �� 5      $��* �6$   .+�5      �� $��	User Name��6   $��0��5      $
��0,15q�5       $
��Left=�5!      ���	#FF2EB7C86/   �� 5"      -   5         ��Name$	 nom��5"      $��1��6(   $��1��5#      $	��0,5q�5$      $	��255��5%      $��0,0,0,1q�5&      $
��Left=�5'      �� 5(      $��Password��6   $��2��5)      $
��0,15q�5*      $
��Left=�5+      ���	#FF2EB7C86/   G� 5,      -   5         G�Name$ password��5,      $��3��60   $	��0,5q�5-      $	��255��5.      $��0,0,0,1q�5/      $
��Left=�50      51      �� 52      -   5         ��Name$ 
ErrorLabel��52      $��*��6(   
���  ��$
��Bold"�6E   $y�Hidden=�6W   �� 53      -   5         ��Name$ buttonLogin��53      $��Login��54      
����������	#FF2EB7C8$��35��57      $	��250��58      ��5:      �� 5;       �� 
TargetType" ��6   .�5<      �� 	 �� Property	 � ��
 �� Value
 5=      �� 5>   "    �� 
TargetType" ��62   .R�5?   &   ��  ��Name$ LoginBorder��6-   #��z��6B   $  16��5@   -   ._�5A   *   �� $��Center=�6;   $��Center=�5B   ;   5C   '    �� Triggers 5D   &   P� 5E   *    P� Property �@J�IsMouseOver P� Value$
 True��6I   . �5F   .   ��  �� 
TargetName$ LoginBorder��6[   	 � ��
 �#21909e�� 5G   .   $ LoginBorder��6d   	 � ��

 �   �5H   +   5J   #   5L      5M      5O      �� 5P      -   5        $ CreateNewCash��5P      $1��+Totally new? Welcome! Create a new Cashier.��6+   $
��Bold"�6a   ���	#FF21909E6s   �� 5Q      -   5        $ buttonSignUp��5Q      $��Sign Up��5R      
����������	#FF2EB7C8$��35��5U      $	��250��5V      ��5X      �� 5Y      " ��6   .�5Z      �� 	 � ��
 5[      �� 5\   "   " ��62   .R�5]   &   �� $ SignUpBorder��6-   #��z��6C   $  16��5^   )   ._�5_   *   �� $��Center=�6;   $��Center=�5`   -   5a   '    5b   &   P� 5c   *    �@J�IsMouseOver$
 True��6I   . �5d   .   �� $ SignUpBorder��6[   	 � ��
 �#21909e�� 5e   .   $ SignUpBorder��6d   	 � ��

 �   �5f   +   5h   #   5j      5k      5m      5o      5p      5q      