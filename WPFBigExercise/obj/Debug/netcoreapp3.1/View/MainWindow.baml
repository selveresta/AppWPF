   M S B A M L   `   `   `  ����I  EWPFBigExercise, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WPFBigExerciseWPFBigExercise  5   	   M+clr-namespace:WPFBigExercise.InfrastructureWPFBigExercise.Infrastructure  5   	       WPFBigExercise.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:WPFBigExercise     5   	   ;loc+clr-namespace:WPFBigExercise.Infrastructure     5   	   -   5          �Name$  mnWindow��5	   	    � Title$ 
MainWindow��5
   	   $	��450��6   $	��900��6)    � 	Resources 5      1  +WPFBigExercise.Infrastructure.DataConverter   DataConvert��%   &	          5   
   62   5      .��5      �  � RowDefinitions 5   
   �� 5      $	��10* �6   6+   �� 5      6    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   �� 5      6!   .+�5   
   �� -   5         ��Name$ ListViewSelected��5   2   $��3��6L   ��6   �� *Sorted+ �� View 5      �� 5      .P�5      ��  �� Width$	 291��6&    �� DisplayMemberBinding 63   �� *Name+.��5      �� -   5        	 ��Name$
	 name��5   s   $��Center=�6/   

 � Tag$

 Name��6�   ��6S   �� *SortCommand+��6�   ��  �� ElementName$
 name��.��6�   Worker6�   5      �� 5      $	 293��6%    61   �� *
Position+.��5      �� -   5        $	 position��5   s   $��Center=�6/   $
 Position��6�   ��6S   �� *SortCommand+��6�   �� $ position��.��6�   
Position6�   5       �� 5!      $	 291��6%    61   �� *DateOfBirth+ �� 	Converter# [  .��5"      �� -   5        $		 age��5"   s   $��Center=�6/   $
 DateOfBirth��6�   ��6S   �� *SortCommand+��6�   �� $	 age��.��6�   Age6�   5#      5$      5&      �� 5'   
   $��1��60   ��6   �� *
AddCommand+.��6=   Add6B   �� 5(   
   $��1��6j   $��1��6w   ��6   �� *
DelCommand+��60   �� $ ListViewSelected��.��6�   Remove6�   �� 5)   
   $��1��6j   $��2��6w   ��6   �� *
ChaCommand+��60   �� $ ListViewSelected��.��6�   Change Position6�   5+      5,      