   M S B A M L   `   `   `  ����M  IBibliotek.WPF.MVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Bibliotek.WPF.MVVMBibliotek.WPF.MVVM  5   	   M+clr-namespace:Bibliotek.WPF.MVVM.ViewModelsBibliotek.WPF.MVVM.ViewModels  5   	   )    #Bibliotek.WPF.MVVM.Views.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Bibliotek.WPF.MVVM     5   	   :vm+clr-namespace:Bibliotek.WPF.MVVM.ViewModels     5   	     � Title$  
MainWindow��5	   	   $	��550��6   $	��800��6)    � DataContext 5      .   (Bibliotek.WPF.MVVM.ViewModels.Mainwindow  5   
   .��5      ]� $
��True��6   .+�5   
   o� $	��Top=�6   
����ح�$��10,10,10,10q�6;   .@�5      m� $��_File��6   .@�5      m� $��E_xit��6    m� Command 6*   �� *ExitCommand+5      5      �� 5   
   .@�5      �� $��Bokning��6    6'   �� *	Bokning+.��5      � $��0,0,0,0q�6   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ bokLista��5      $��0��61      AutoGenerateColumns$ False��5         SelectionMode$ Single=�63      SelectionUnit$ FullRow=�5         
IsReadOnly$
 True��6/   $��10,38,436,186q�5!   R   ��5   A   �� *TillgängligaBöcker+ �� SelectedItem 5       �� *BöckerSelectedItem+	 �� Mode$	 TwoWay=�
 �� SelectedIndex
 5!      �� *BöckerSelectedIndex+$	 TwoWay=�   Columns 5"      0  *System.Windows.Controls.DataGridTextColumn  5#      ,  &System.Windows.Controls.DataGridColumn   Header$ BokId��61   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6@   �� *BokId+  5$      $
 ISPN��61    6?   �� *ISPN+  5%      $ Boktitel��61    6C   �� *
Boktitel+  5&      $ Tillgänglig��61    6F   �� *Tillgänglig+5(        5*      -   5        $ valdaBöcker��5*      $��0��64   $ False��5+      $ Single=�63   $ FullRow=�5,      $
 True��6/   $��436,33,10,186q�5.   R   ��5*   D   �� *ValdaBöcker+ 5-      �� *BöckerSelectedItem+$	 TwoWay=�
 5.      �� *BöckerSelectedIndex+$	 TwoWay=� 5/        50      $ BokId��61    6@   �� *BokId+  51      $
 ISPN��61    6?   �� *ISPN+  52      $ Boktitel��61    6C   �� *
Boktitel+  53      $ Tillgänglig��61    6F   �� *Tillgänglig+55      �� 56      $��
Lägg till��6   $��Center=�61   $��0,90,0,0q�6m   $	��Top=�6   $��68��6�   ��6N   �� *
AddCommand+6�   �� 57      $��Ta bort��6   $��Center=�6/   $��	0,154,0,0q�6o   $	��Top=�6�   $��69��6�   ��6L   �� *RemoveCommand+6�   (  "System.Windows.Controls.DatePicker  58      $
��Left=�6!   $��
10,364,0,0q�6<   $	��Top=�6P   $	��137��6h      SelectedDate 6t   �� *	ValtDatum+�� 59      $
��Left=�6   $��
10,314,0,0q�69    �� TextWrapping$
 Wrap=�6M   $	��Top=�6�   $	��137��6�   ��6a   �� *Medlemsnummer+6�   �� 5:      $
��Left=�6   $��	8,419,0,0q�69   $
 Wrap=�6L   $	��Top=�6�   $	��137��6�   ��6`   �� *
AntalDagar+$	 TwoWay=�6�   �� 5;      $��Tillgängliga böcker:��6   $
��Left=�6;   $��10,7,0,0q�6V   $	��Top=�6h   �� 5<      $��Valda böcker:��6   $
��Left=�64   $��	439,7,0,0q�6O   $	��Top=�6b   �� 5=      $��Ange medlemsnummer:��6   $
��Left=�6:   $��
10,286,0,0q�6U   $	��Top=�6i   �� 5>      $��Ange startdatum:��6   $
��Left=�67   $��
10,338,0,0q�6R   $	��Top=�6f   �� 5?      $��Ange antal dagar:��6   $
��Left=�68   $��	8,393,0,0q�6S   $	��Top=�6f   �� 5@      $!��Bekräfta och skapa bokning��6   $
��Left=�6B   $��516,314,0,0q�6]   $	��Top=�6r   $��70��6�   $	��206��6�   ��6�   �� *SkapaBokningCommand+5B      5D      �� 5E      $��Återlämning��6    6+   �� *Återlämning+.��5G      � $��0,0,0,0q�6    � ColumnDefinitions 5H      �� 5I      $��6* �6+   �� 5J      $	��11* �6+   �� 5K      $	��14* �6+   �� 5L      $	��16* �6+   �� 5M      $
��747* �6+   .+�5O        -   5        $ återlämning��5O      $��1��64   $ False��5P      $ Single=�63   $ FullRow=�5Q      $
 True��6/   $��4,31,10,161q�5T   ;   $��4��6P   ��5O   D   �� *AktivaBokningar+ 5R      �� *AktivaBokningarSelectedItem+$	 TwoWay=�
 5S      �� *AktivaBokningarSelectedIndex+$	 TwoWay=�{�5T      �� *IsNotModified+ 5U        5V      $ Bokningsnummer��61    6I   �� *Bokningsnummer+  5W      $ Aktiv��61    6@   �� *Aktiv+  5X      $ Medlemsnummer��61    6H   �� *Medlemsnummer+  5Y      $ Utlämningsdatum��61    6J   �� *Utlämningsdatum+  5Z      $ Återlämningsdatum��61    6L   �� *Återlämningsdatum+5\      �� 5]      $��Aktiva bokningar:��6   $
��Left=�68   $��4,5,0,0q�6S   $	��Top=�6d   $��4��6|   $��1��6�   �� 5^      $��Tillbaka��6   $
��Left=�60   $��	4,332,0,0q�6K   $	��Top=�6^   $	��126��6v   $	��102��6�   $��4��6�   $��1��6�   �� 5_      $��	Returnera��6   $
��Left=�61   $��638,332,0,0q�6L   $	��Top=�6a   $	��126��6y   $��99��6�   $��4��6�   ��6�   �� *RetuneraCommand+6�   5a      5b      5c      5d      5f      