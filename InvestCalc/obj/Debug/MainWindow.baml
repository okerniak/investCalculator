   M S B A M L   `   `   `  ����E  AInvestCalc, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:InvestCalc
InvestCalc  5   	       InvestCalc.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:InvestCalc     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� -   5        $��AgrDate_Label��5
      $��Agreement date��6&   $
��Left=�6?   $��	31,10,0,0q�6Z   $	��Top=�6m   $	��106��6�   �� 5   
   -   5        $��CalcDate_Label��5      $��Calculation date��6'   $
��Left=�6B   $��	31,40,0,0q�6]   $	��Top=�6p   $	��106��6�   �� 5   
   -   5        $��Amount_Label��5      $��Amonth��6%   $
��Left=�66   $��	31,70,0,0q�6Q   $	��Top=�6d   $��93��6|   �� 5   
   -   5        $��Percent_Label��5      $��Persent��6&   $
��Left=�68   $��
31,100,0,0q�6S   $	��Top=�6g   $��93��6   �� 5   
   -   5        $��CountYears_Label��5      $��Count Years��6)   $
��Left=�6?   $��
31,130,0,0q�6Z   $	��Top=�6n   $��93��6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ AgrDate_Box��5      $
��Left=�6+   $��
142,12,0,0q�6F   $	��Top=�6Z     5   
   -   5        $ CalcDate_Box��5      $
��Left=�6,   $��
142,42,0,0q�6G   $	��Top=�6[   �� 5   
   -   5         ��Name$ Start_Button��5      $��Push Me��6'   $
��Left=�69   $��
268,15,0,0q�6T   $	��Top=�6h   $	��480��6�   $	��141��6�   6�   �� 5   
   -	   5         ��Name$ 
Amount_Box��5      $��100000��6&   $
��Left=�6d   $��23��6   $��
142,70,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��102��6�    �� MaxLines$ 1��6�    �� 	MaxLength$ 10��6�   �� 5   
   -
   5        $ Persent_Box��5      $��30��6'   $
��Left=�6b   $��23��6}   $��142,100,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��102��6�   $ 1��6�   $ 3��6�   �� 5   
   -   5        $ 	Years_Box��5      $��3��6%   $
��Left=�6\   $��23��6w   $��142,130,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��102��6�   $ 1��6�   $ 2��6�   �� 5   
   -   5        $ 
Result_Box��5      $
��Left=�6&   $	��215��6A   $��
31,180,0,0q�6N   $
 Wrap=�6b   $�� ��6v   $	��Top=�6~   $	��717��6�   " �� VerticalScrollBarVisibility$
 Auto=�6�   5      5      