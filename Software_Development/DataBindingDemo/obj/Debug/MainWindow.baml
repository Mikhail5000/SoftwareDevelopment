   M S B A M L   `   `   `  ����J  FDataBindingDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:DataBindingDemoDataBindingDemo  5           DataBindingDemo.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      /localclr-namespace:DataBindingDemo     5        � Title$  Databinding Demo��5      $	��300��6   $	��300��6+    � 	Resources 5      !  DataBindingDemo.StudentList   studentCollection  DataBindingDemo.Student   StudentName   
IsEnrolled*   $DataBindingDemo.BoolToBrushConverter  boolToBrushConverter  listBoxTemplate �� Orientation �� Path �� 	Converter��%.  &	        &	     &	     7    5   
     5      $ 
Syed Abbas��6    .  65     5	      $ 	Lori Kane��6    . 64     5
      $ Steve Masters��6    .  68     5      $ Tai Yee��6    . 62     5      $ Brenda Diaz��6    . 66   5        5   
   6%   �� 5   
   .R�5      �� $ 
Horizontal=�6   .+�5      �� $��10��5      $��10��5      $��0,0,5,0q�5      ��5      �� $ 
IsEnrolled�8   5      �� 5      ��6   �� $ StudentName�5      5      5      .��5      � .+�5   
   �� $
��Left=�6   $	��180��6-   $��	33,21,0,0q�6:   $	��Top=�6M   $	��186��6e   #���  6�   ��6q   ��  �� Mode$ OneWay=� �� Source# [  6�   5      5      