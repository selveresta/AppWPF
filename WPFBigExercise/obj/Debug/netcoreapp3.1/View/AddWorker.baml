   M S B A M L   `   `   `  ����I  EWPFBigExercise, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:WPFBigExercise.ViewWPFBigExercise.View  5   	   M+clr-namespace:WPFBigExercise.InfrastructureWPFBigExercise.Infrastructure  5   	   #    WPFBigExercise.View.AddWorker   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:WPFBigExercise.View     5   	   ;loc+clr-namespace:WPFBigExercise.Infrastructure     5   	   -   5          �Name$  	addWindow��5	   	    � Title$ 	AddWorker��5
   	   $	��292��6   $	��779��6(    � 	Resources 5      1  +WPFBigExercise.Infrastructure.DataConverter   DataConvert��%   &	          5   
   62   5      .��5      � .+�5   
   �� $
��Name��6   $
��Left=�6   $��	10,10,0,0q�6:   $	��Top=�6M   $��31��6e   $��73��6q   �� 5   
   $
��Left=�6u   $��	97,10,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��648��6�   $��31��6�    � DataContext 6   �� *TemplateWorker+��6:   �� *Name+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   $��Position��6   $
��Left=�6#   $��	10,79,0,0q�6?   $	��Top=�6R   $��31��6j   $��73��6v   �� 5   
   $
��Left=�6y   $��	97,79,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��648��6�   $��31��6�    6   �� *TemplateWorker+��6:   �� *
Position+$ PropertyChanged=�6�   �� 5   
   $��Date of Birth��6   $
��Left=�6(   $��
10,151,0,0q�6C   $	��Top=�6W   $��31��6o   $��82��6{   �� 5   
   $
��Left=�6�   $��
97,151,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��648��6�   $��31��6�    6   �� *TemplateWorker+��6:   �� *DateOfBirth+$ 	LostFocus=� �� Mode$ OneWayToSource=�6�   �� 5   
   $��Ok��65   $
��Left=�6B   $��555,217,0,0q�6]   $	��Top=�6r   $��28��6�   $��89��6�   ��6   �� *AddToOwnerList+6�   �� 5   
   $��Cancel��6e   $
��Left=�6v   $��656,217,0,0q�6�   $	��Top=�6�   $��28��6�   $��89��6�   ��6   �� *CloseWindow+��61   ��  �� ElementName$ 	addWindow��6�   5      5      