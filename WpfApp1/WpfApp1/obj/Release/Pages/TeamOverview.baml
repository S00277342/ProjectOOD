   M S B A M L   `   `   `  ����   WpfApp1'    !PSGPathToGlory.Pages.TeamOverview   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       N� Title$  TeamOverview��.��� $��10q� � RowDefinitions �� $��80 ��� $��* ��� $��60 �.+�]� $��0�����	#FF1E2A38$��0,0,0,10q�.+��� $��psg_logo.png��$��50��$��50��$
��10,0q�$��Center=��� $��Paris Saint-Germain��$��24(�$
��Bold"�
�������$��Center=�$
��10,0q�$��Center=��� $��1��$
��Auto=�.���� $��10q�.+��� $��Coach��$��20(�$
��Bold"�$��0,10,0,5q��� $
��Auto=�$��Disabled=�.���� ���	#FFE0E0E0 �� Padding$ 10q� �� CornerRadius$ 10��$��0,0,0,20q�._�]� .+��� $	��100��$	��100��$��10q����� *Coach.PhotoPath+��  �� Orientation$ Vertical=�$
��10,0q�.+��� $��16(�$
��Bold"����� *
Coach.Name+�� $
��Age:��$
��Bold"��� ���� *	Coach.Age+�� $��Past Teams:��$
��Bold"��� ���� *Coach.Past_Teams+�� $
��Wrap=�$��20,0,0,0q�$	��300��$	��Top=����� *Coach.Strategy+�� $��	Attackers��$��20(�$
��Bold"�$��0,10,0,5q��� -    ��Name$ AttackersListBox��$	��130�����	#FFF0F0F0$
��Auto=�$��Disabled=����� *	Attackers+���� .R��� $ 
Horizontal=����� .R��� $��5q�$	��100��.+��� $��80��$��80������ *	PhotoPath+��  �� TextAlignment$ Center=�$��14(����� *Name+�� $��Midfielders��$��20(�$
��Bold"�$��0,20,0,5q��� -   $ MidfieldersListBox��$	��130�����	#FFF0F0F0$
��Auto=�$��Disabled=����� *Midfielders+���� .R��� $ 
Horizontal=����� .R��� $��5q�$	��100��.+��� $��80��$��80������ *	PhotoPath+�� $ Center=�$��14(����� *Name+�� $��	Defenders��$��20(�$
��Bold"�$��0,20,0,5q��� -   $ DefendersListBox��$	��130�����	#FFF0F0F0$
��Auto=�$��Disabled=����� *	Defenders+���� .R��� $ 
Horizontal=����� .R��� $��5q�$	��100��.+��� $��80��$��80������ *	PhotoPath+�� $ Center=�$��14(����� *Name+�� $��Goalkeepers��$��20(�$
��Bold"�$��0,20,0,5q��� -   $ GoalkeepersListBox��$	��130�����	#FFF0F0F0$
��Auto=�$��Disabled=����� *Goalkeepers+���� .R��� $ 
Horizontal=����� .R��� $��5q�$	��100��.+��� $��80��$��80������ *	PhotoPath+�� $ Center=�$��14(����� *Name+]� $��2�����	#FF1E2A38.+��� -    ��Name$ 
bt_players��$��Team Overview��$
��Left=�
�������
���   �$	��150��
������ �� -   $ bt_team��$��Lineup��$
��Left=�
������ 
�������$	��150��$
��Bold"��� -   $ 
bt_matches��$��Matches��$
��Left=�
������ 
�������$	��150��
������ 