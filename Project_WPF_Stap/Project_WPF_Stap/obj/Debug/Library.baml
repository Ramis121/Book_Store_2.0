   M S B A M L   `   `   `  ����K  GProject_WPF_Stap, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Project_WPF_StapProject_WPF_Stap  5   	       Project_WPF_Stap.Library   5   	   U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Project_WPF_Stap     5   	      MaterialDesignFont#���   5   	     � Title$  Library��5
   	   $	��300��6   $	��600��6&    � 	Resources 5      $   Project_WPF_Stap.Categoty_Book  keyValuePairs��%   &	         5   
   6   5      .��5      � ���#403130 � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      .+�5   
   �� $��0��6   ��6"   �� *categoty_Book+ �� SelectedItem 6H   �� *SelectedPhone+��5      �� 5      .R�5      �� $��0��6!   .+�5      �� 
�������$��10(�67   $��Italic$�6e   ��6E   ��  �� Path$ 	Name_Book�6{   �� 5      
�������$��10(�67   $��Italic$�6a   ��6E   �� $ Price�6w   5      5      5      �� 5!   
   $��1��6;    � DataContext 6   �� *SelectedPhone+.+�5"      �� $��Italic$�6   
�������$��20(�6>   $��Title of the book��6L   6g   �� 5#      -   5         ��Name$ textbox1��5#      ��6+   �� *	Name_Book+ �� UpdateSourceTrigger$ PropertyChanged=�6m   �� 5$      $��Italic$�6   $��Price��6+   
�������$��20(�6K   6[   �� 5%      -   5        $ textbox2��5%      ��6*   �� *Price+$ PropertyChanged=�6h   5&      �� 5'   
   -   5         ��Name$	 btn��5'      $	��Add��6   ���#291d1c$��5.6,233,10,5.4q�6A   $��1��6Y   $
��Auto��6{   6�   �� 5(   
   $��Italic$�6   $��20(�6'   
�������$��2��6H   $��Added��6X   $��66,0,-0.4,240.4q�6e   6�   �� 5)      -   5        	 ��Name$	 listBox��5)   #   $��2��6   $��5,55,-0.4,76.4q�64   �� 5*   
   -   5        $��Delete��5*      $��2��6"   ���#291d1c$��103,199,-0.4,37.4q�6G   $
��Auto��6b   6�   �� 5+   
   -   5        $	��Buy��5+      $��2��6   ���#291d1c$��5,233,9.6,5.4q�6D   6r   '  !MaterialDesignThemes.Wpf.Snackbar  5,   
   -   5        
  Name$
 SnackBar��5,   .   $��66��6"   
���   �$��144,0,161.6,0.4q�6�   $��11��6�   $��3��6�      MessageQueue 6@   4  .MaterialDesignThemes.Wpf.MessageQueueExtension  6�   5-      5.      