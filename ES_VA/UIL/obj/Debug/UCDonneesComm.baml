   M S B A M L   `   `   `  ����>  :UIL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:UILUIL  5          UIL.UCDonneesComm   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5	      @d2http://schemas.microsoft.com/expression/blend/2008     5
      #localclr-namespace:UIL     5      $��350px��5      .��5      �   � 	Resources  5   
    �� 
TargetType �� Property �� Value��%U  '��       '�� �     �� 5      " ��6   .�5      ��  � ��$
 20px(�6-   6<   �� 5       � ��$ Center=�68   6I   �� 5       � ��
 �����6?   5      �� 5      " ��6   .�5      ��  � ��
 �����6C   �� 5       � ��
 �   �6?   �� 5       � ��$ DemiBold"�6/   6B   5      5      .+�5   
   �� .��5      �� .+�5      �� DonnéeComme6&   � 5      $��Center=�6   .+�5       �� -   5         ��Name$ cbOrdre��5       .@�5!      ��  �� 
IsSelected . .��65   	Croissant6@   �� 5"      .��6#   Decroissant60   5#      �� 5$      -   5        $ 	cbElement��5$      .@�5%      �� -   5        $��Annee��5%   #    . .��6B   Année6I   �� 5&      -   5        $��NbUnites��5&   #   .��63    Nombre d'unité commercialisé6Q   �� 5'      -   5        $��PrixMoyenPar1000��5'   #   .��6;   Prix moyen par 10006P   5(      5)      &   System.Windows.Controls.DataGrid  5+      -   5        $��dgVente��5,      $	��Top=�5-      $
��Left=�5.         AutoGenerateColumns .  
�������   AlternatingRowBackground
 �����   Columns 52      0  *System.Windows.Controls.DataGridTextColumn  53      ,  &System.Windows.Controls.DataGridColumn	   Header$	 NomProvince��54      
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 * 56         
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 57      �� *NomProvince.NomProvince+58        59      $	 TypeVehicule��5:      $
 * 5;       5<      �� *TypeVehicule.TypeVehicule+  5=      $	 Annee��5>      -   5        colAnnee��$
 * 5@       5A      �� *Annee+  5B      $	 NbUnites��5C      $
 * 5D      -   5        
colNbUnite�� 5G      �� *
NbUnites+  5H      $	 
MntPar1000��5I      $
 * 5J       5L      �� *
MntPar1000+  5M      $	 PrixMoyenPar1000��5N      $
 * 5O      -	   5        colPrix�� 5Q      �� *PrixMoyenPar1000+5U      5W      5X      5Z      5[      