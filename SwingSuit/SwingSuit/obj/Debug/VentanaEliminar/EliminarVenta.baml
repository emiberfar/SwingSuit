   M S B A M L   `   `   `  ����D  @SwingSuit, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:SwingSuit.VentanaAnadirSwingSuit.VentanaAnadir  5   	   -    'SwingSuit.VentanaEliminar.EliminarVenta   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   
   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:SwingSuit.VentanaAnadir     5   	     � Title$  AnadirCliente��5   	   $	��562��6   $
��1000��6,    � 
ResizeMode$ NoResize=�69    � WindowStartupLocation$ CenterScreen=�6O    � WindowStyle$
 None=�6t    � Icon$4 ./SwingSuit;component/MenuPrincipal/diamond.png��6�   ��5	      �� 5
   
    �� ImageSource$ VentanaEliminarVentas.png��6   .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ mostrar��5      $
��Left=�6D   $	��254��6_   $��
35,272,0,0q�6l   $	��Top=�6�   $	��683��6�   ���	#FF212121���	#FF4C4949��6$   �� *	cliente+6�   �� 5   
   -   5         ��Name$ id��5      $
��Left=�6   $��31��69   $��217,117,0,0q�6E    �� TextWrapping$
 Wrap=�6Z   $	��Top=�6n   $��61��6�   ���	#FF595959	 �� 
CaretBrush	 �	#FF323232
 �� SelectionBrush

 �   �
�������$��Yu Gothic UI Light)�6�   $��16(�6	  ���	#FF2323236/  �� 5   
   -   5        $ 	idCliente��5      $
��Left=�6%   $��31��6@   $��298,206,0,0q�6L   $
 Wrap=�6a   $	��Top=�6u   $	��236��6�   ���	#FF595959	 �	#FF323232

 �   �
�������$��Yu Gothic UI Light)�6�   $��16(�6  ���	#FF23232367  �� 5   
   -   5         ��Name$ aceptar��5      $��Button��6"   $
��Left=�63   $��773,250,0,0q�6N   $	��Top=�6c   $	��227��6{   $��95��6�   ��5      �� 5      ��5      �� 5      ��5      �� 5       J� OpacityMask 5      �� 5      5      �� 5   
   -   5        $ Borrar��5      $��Button��6!   $
��Left=�62   $��773,350,0,0q�6M   $	��Top=�6b   $	��227��6z   $��94��6�    5      �� 5       ��5"      �� 5#      ��5%      �� 5&      ��5(      �� 5)      5+      �� 5,   
   -   5        $ Cancelar��5,      $��Button��6#   $
��Left=�64   $��773,451,0,0q�6O   $	��Top=�6d   $	��227��6|   $��92��6�   ��5-      �� 5.      ��50      �� 51      ��53      �� 54       56      �� 57      59      5:      5;      