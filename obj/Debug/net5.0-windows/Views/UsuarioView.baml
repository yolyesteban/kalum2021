   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   fCclr-namespace:MahApps.Metro.Controls.Dialogs;assembly=MahApps.MetroMahApps.Metro.Controls.Dialogs  5   	   D @kalum2021, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:kalum2021	kalum2021 5	   	   !   kalum2021.Views.UsuarioView   5      R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Kmah;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   VDialogCclr-namespace:MahApps.Metro.Controls.Dialogs;assembly=MahApps.Metro     5   	   )localclr-namespace:kalum2021     5	   	   -   5        $��
FrmUsuario��5   X     � Title$  Usuarios��6	   $	��300��6   $	��800��6'    � WindowStartupLocation$ CenterScreen=�63   8   2MahApps.Metro.Controls.Dialogs.DialogParticipation   Register 5   	   �� .��5      �  � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��80 �6    � ColumnDefinitions 5   
   �� 5      $	��120 �6   �� 5      .+�5   
   �� $��	Apellidos��6   $��0��6$   $��0��62   �� 5   
   $��0��6   $��0,5,0,0q�6   $��1��60   ��6@   �� *	Apellidos+�� 5   
   $��Nombres��6   $��1��6"   $��0��6/   �� 5   
   $��1��6   $��0,5,0,0q�6   $��1��60   ��6@   �� *	Nombres+�� 5    
   $��Email��6   $��2��6    $��0��6.   �� 5!   
   $��2��6   $��0,5,0,0q�6   $��1��60   ��6@   �� *Email+�� 5#   
   $��Username��6   $��3��6#   $��0��60   �� 5$   
   $��3��6   $��0,5,0,0q�6   $��1��60   ��6@   �� *
Username+�� 5&   
   $��Password��6   $��4��6#   $��0��60   ��6@   �� *HeightLblPassword+G� 5'   
   -   5         G�Name$ TxtPassword��5'   '   $��0,5,0,0q�6   $��4��6<   $��1��6I   ��6Y   �� *HeightTxtPassword+]� 5*   
   $��5q�6   $��5��6   $��2��6-   .+�5+      �� $	��200��6   $��Right=�6!   $��Guardar��6=   ��6O   �� *	Instancia+��6m   ��  �� ElementName$ 
FrmUsuario��5,      5.      5/      