   M S B A M L   `   `   `  ����   WpfApp1*    $PSGPathToGlory.Pages.MatchDetailPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       N� Title$  MatchDetailPage��.��� $��10q� � RowDefinitions �� $��80 ��� $��* ��� $��60 �.+�]� $��0�����	#FF1E2A38$��0,0,0,10q�.+��� $��psg_logo.png��$��50��$��50��$
��10,0q�$��Center=��� $��Paris Saint-Germain��$��24(�$
��Bold"�
�������$��Center=�$
��10,0q�$��Center=��� $��1��.���� $��20q�.+��� -   $��← Back��$��0��$��0��$
��Left=�$	��Top=�$��
10,10,0,15q�$
��10,5q����	#FF1E2A38
�������$
��Bold"�
������ � $��0,0,0,20q� � ColumnDefinitions �� $��* ��� $
��Auto ��� $��* �.+��� $��0��$��Center=�.+��� $��psg_logo.png��$��60��$��60���� $��Paris SG��$
��Bold"�$��16(�$��Center=��� $��1��$��Center=�$
��20,0q�.+��� $��28(�$
��Bold"�$��Center=����� *SelectedMatch.FinalScore+�� $��14(�$��Center=����� *SelectedMatch.Date+�� $��14(�$��Center=����� *SelectedMatch.Competition+�� $��12(�$��Center=�
����������� *SelectedMatch.Stadium+�� $��2��$��Center=�.+��� $��60��$��60������ *SelectedMatch.TeamPhotoPath+�� $
��Bold"�$��16(�$��Center=����� *SelectedMatch.Team+�  �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto � �� $��* ��� $
��Auto ��� $��* �.+��� $��0��$��0��$��Right=����� *SelectedMatch.Possession1+�� $��0��$��1��$��
Possession��$
��Bold"�$
��10,0q��� $��0��$��2��$
��Left=����� *SelectedMatch.Possession2+�� $��1��$��0��$��Right=����� *SelectedMatch.XGoals1+�� $��1��$��1��$��Expected Goals (xG)��$
��Bold"�$
��10,0q��� $��1��$��2��$
��Left=����� *SelectedMatch.XGoals2+�� $��2��$��0��$��Right=����� *SelectedMatch.TotalShots1+�� $��2��$��1��$��Total Shots��$
��Bold"�$
��10,0q��� $��2��$��2��$
��Left=����� *SelectedMatch.TotalShots2+�� $��3��$��0��$��Right=����� *SelectedMatch.BigChances1+�� $��3��$��1��$��Big Chances��$
��Bold"�$
��10,0q��� $��3��$��2��$
��Left=����� *SelectedMatch.BigChances2+�� $��4��$��0��$��Right=����� * SelectedMatch.GoalkeeperSaves1+�� $��4��$��1��$��Goalkeeper Saves��$
��Bold"�$
��10,0q��� $��4��$��2��$
��Left=����� * SelectedMatch.GoalkeeperSaves2+�� $��5��$��0��$��Right=����� *SelectedMatch.CornerKicks1+�� $��5��$��1��$��Corner Kicks��$
��Bold"�$
��10,0q��� $��5��$��2��$
��Left=����� *SelectedMatch.CornerKicks2+�� $��6��$��0��$��Right=����� *SelectedMatch.Tackles1+�� $��6��$��1��$��Tackles��$
��Bold"�$
��10,0q��� $��6��$��2��$
��Left=����� *SelectedMatch.Tackles2+�� $��7��$��0��$��Right=����� *SelectedMatch.Fouls1+�� $��7��$��1��$��Fouls��$
��Bold"�$
��10,0q��� $��7��$��2��$
��Left=����� *SelectedMatch.Fouls2+�� $��Player of the Match:��$
��Bold"�$��16(�$��0,20,0,5q��� $��14(����� *%#SelectedMatch.PlayerOfTheMatch.Name+�� $��Scorers:��$
��Bold"�$��16(�$��0,20,0,5q��� $��14(����� *SelectedMatch.Score+�� $��Lineup:��$
��Bold"�$��16(�$��0,20,0,5q�� $��1�� �� $��5* ��� $��2* �.+�� $��0�����#F0F0F0$��0,0,0,10q� �� $��* ��� $��* ��� $��* ��� $��* �.+�� $��0�� �� $��* ��� $��* ��� $��* �.+��� $��0�� �� Orientation$ Vertical=�$��Center=�.+��� -   $��60��$��60������ *LW.PhotoPath+�� $��12(�$��Center=����� *	LW.Name+�� $��1��$ Vertical=�$��Center=�.+��� -   $��60��$��60������ *ST.PhotoPath+�� $��12(�$��Center=����� *	ST.Name+�� $��2��$ Vertical=�$��Center=�.+��� -   $��60��$��60������ *RW.PhotoPath+�� $��12(�$��Center=����� *	RW.Name+� $��1�� �� $��* ��� $��* ��� $��* �.+��� $��0��$ Vertical=�$��Center=�.+��� -   $��60��$��60������ *CAM.PhotoPath+�� $��12(�$��Center=����� *
CAM.Name+�� $��1��$ Vertical=�$��Center=�.+��� -   $��60��$��60������ *CM.PhotoPath+�� $��12(�$��Center=����� *	CM.Name+�� $��2��$ Vertical=�$��Center=�.+��� -   $��60��$��60������ *CDM.PhotoPath+�� $��12(�$��Center=����� *
CDM.Name+� $��2�� �� $��* ��� $��* ��� $��* ��� $��* �.+��� $��0��$ Vertical=�$��Center=�.+��� -   $��60��$��60������ *LB.PhotoPath+�� $��12(�$��Center=����� *	LB.Name+�� $��1��$ Vertical=�$��Center=�.+��� -	   $��60��$��60������ *CB1.PhotoPath+�� $��12(�$��Center=����� *
CB1.Name+�� $��2��$ Vertical=�$��Center=�.+��� -
   $��60��$��60������ *CB2.PhotoPath+�� $��12(�$��Center=����� *
CB2.Name+�� $��3��$ Vertical=�$��Center=�.+��� -   $��60��$��60������ *RB.PhotoPath+�� $��12(�$��Center=����� *	RB.Name+� $��3��.+��� $��0��$ Vertical=�$��Center=�.+��� -   $��60��$��60������ *GK.PhotoPath+�� $��12(�$��Center=����� *	GK.Name+�� -    ��Name$ DetailPanel��$��1��
�������$y�	Collapsed=�
�������$��1q�$	��200��$��Bottom=�$��0,10,0,0q�._��� $��10q�.+��� $��Close��$��Right=��� $
��Bold"�$��16(����� *SelectedPlayer.Name+�� ���� *SelectedPlayer.Position+�� ���� *SelectedPlayer.Age+ �� StringFormat$ Age: {0}���� ���� *SelectedPlayer.Nationality+�� $
��Wrap=����� *SelectedPlayer.Qualities+�� $��1��.+��� $��Bench:��$
��Bold"�$��16(�$��0,20,0,5q��� $
��Auto=�$��Disabled=�$	��150��
������ $��0q�$��Center=����� *PrioritySubstitutes+���� .R��� $ 
Horizontal=����� .R��� $��80��.+��� $��60��$��60��$��UniformToFill=�$��Center=�$��Center=����� *	PhotoPath+�� $��12(� �� TextAlignment$ Center=�$
��Wrap=�$��0,5,0,0q����� *Name+]� $��2�����	#FF1E2A38.+��� -    ��Name$ 
bt_players��$��Team Overview��$
��Left=�
������ 
�������$	��150��
������ �� -   $ bt_team��$��Lineup��$
��Left=�
������ 
�������$	��150��$
��Bold"��� -   $ 
bt_matches��$��Matches��$
��Left=�
������ 
�������$	��150��
������ 