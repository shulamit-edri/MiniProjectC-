   M S B A M L   `   `   `  ����@  <PLWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:PLWPF.TesterPLWPF.Tester  5   	   "    PLWPF.Tester.WindowAddTester   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:PLWPF.Tester     5   	     � Title$  WindowAddTester��5   	   $��557.292��6!   $��1001.906��62   .��5	      � -   5         �Name$
 Grid��5	      ���	#FFB4E0E9.+�5
   
   �� $��
ADD TESTER��6   $��Center=�6%   $��377,25,379.333,0q�6B   $	��Top=�6\   $��56��6t   $	��239��6�   $��Rockwell Nova Cond Light)�6�   $��30(�6�   $
��Bold"�6�   �� 5   
   $	��Id:��6   $
��Left=�6   $��
94,128,0,0q�69   $	��Top=�6M   $��33��6e   $��20(�6p   �� 5   
   -   5         ��Name$
 TxId��5       �� 	MaxLength$ 9��6    $
��Left=�6.   $��30��6I   $��246,135,0,0q�6U    �� TextWrapping$
 Wrap=�6j   $	��Top=�6�   $	��190��6�   ��6~   ��  �� Path$ Id� �� Mode$ TwoWay=� �� NotifyOnValidationError .  �� ValidatesOnExceptions . 6�   �� 5   
   $��
Last Name:��6   $
��Left=�6%   $��
94,168,0,0q�6@   $	��Top=�6T   $	��110��6l   $��20(�6x   �� 5   
   -   5        $ 
TxLastName��5      $
��Left=�6&   $��30��6A   $��246,172,0,0q�6M   $
 Wrap=�6b   $	��Top=�6�   $	��190��6�   ��6v   �� *
LastName+$ TwoWay=� .  . 6�   �� 5   
   $��First Name:��6   $
��Left=�6&   $��
94,204,0,0q�6A   $	��Top=�6U   $	��110��6m   $��20(�6y   �� 5   
   -   5        $ TxFirstName��5      $
��Left=�6'   $��30��6B   $��248,211,0,0q�6N   $
 Wrap=�6c   $	��Top=�6�   $	��190��6�   ��6w   �� $ 	FirstName�$ TwoWay=� .  . 6�   �� 5   
   $��Birth Date:��6   $
��Left=�6&   $��
94,243,0,0q�6A   $	��Top=�6U   $	��110��6m   $��20(�6y   (  "System.Windows.Controls.DatePicker  5   
   -   5        	  Name$	 DpBirthDate��5      $
��Left=�6*   $��30��6E   $	��190��6Q   $��246,250,0,0q�6]   $	��Top=�6r   
   IsTodayHighlighted
 .    Text$ 
12/12/1949��6     DisplayDateStart$ 1/1/1949X�6&     DisplayDateEnd$ 
12/12/1979X�6B     IsDropDownOpen .     DisplayDate$ 1/1/1949��6u     SelectedDate 6�   �� $ Birthday�$ TwoWay=� .  . 6u  �� 5   
   $��Gender:��6   $
��Left=�6"   $��
94,280,0,0q�6=   $	��Top=�6Q   $	��110��6i   $��20(�6u   �� 5   
   -   5         ��Name$ 	CmbGender��5      $
��Left=�6&   $��30��6A   $��246,287,0,0q�6M   $	��Top=�6b   $	��190��6z    �� SelectedItem 6�   �� $ Gender�$ TwoWay=� �� ValidatesOnDataErrors .  .  . �� 5   
   $��Phon number:��6   $
��Left=�6'   $��
94,317,0,0q�6B   $	��Top=�6V   $	��143��6n   $��20(�6z   �� 5   
   -   5        $ CmbPhonPrefix��5      $
��Left=�6*   $��30��6E   $��246,323,0,0q�6Q   $	��Top=�6f   $��59��6~    �� SelectedValue 6�   �� *	PhonNum+$ TwoWay=� .  .  . .@�5      �� $	��050��6   �� 5      $	��051��6   �� 5      $	��052��6   �� 5      $	��053��6   �� 5      $	��054��6   �� 5      $	��055��6   �� 5      $	��058��6   5      �� 5   
   -   5        $ TxPhonNumber��5      $
��Left=�6(   $��30��6C   $��310,323,0,0q�6O   $
 Wrap=�6d   $	��Top=�6�   $	��126��6�   ��6x   �� $ PhonNum�$ TwoWay=� .  . 6�   �� 5    
   $��Address:��6   $
��Left=�6#   $��
94,353,0,0q�6>   $	��Top=�6R   $	��143��6j   $��20(�6v   �� 5!   
   $��Street:��6   $
��Left=�6"   $��238,359,0,0q�6=   $	��Top=�6R   $��59��6j   $��15(�6u   �� 5"   
   -	   5        $ TxAddressStreet��5"      $
��Left=�6+   $��30��6F   $��310,358,0,0q�6R   $
 Wrap=�6g   $	��Top=�6�   $	��126��6  ��6{   �� $ Address.street�$ TwoWay=� .  . 6  �� 5#   
   $��Number:��6   $
��Left=�6"   $��238,394,0,0q�6=   $	��Top=�6R   $��68��6j   $��15(�6u   �� 5$   
   -
   5        $ TxAddressNumber��5$      $
��Left=�6+   $��30��6F   $��310,393,0,0q�6R   $
 Wrap=�6g   $	��Top=�6�   $	��126��6  ��6{   �� $ Address.number�$ TwoWay=� .  . 6  �� 5%   
   $��City:��6   $
��Left=�6    $��238,429,0,0q�6;   $	��Top=�6P   $��68��6h   $��15(�6s   �� 5&   
   -   5        $ TxAddressCity��5&      $
��Left=�6)   $��30��6D   $��311,429,0,0q�6P   $
 Wrap=�6e   $	��Top=�6�   $	��126��6�   ��6y   �� $ Address.city�$ TwoWay=� .  . 6�   �� 5'   
   $��Years of experience:��6   $
��Left=�6/   $��488,129,0,0q�6J   $	��Top=�6_   $	��183��6w   $��20(�6�   �� 5(   
   -   5        $ TxYearsExperience��5(      $
��Left=�6-   $��30��6H   $��693,135,0,0q�6T   $
 Wrap=�6i   $	��Top=�6�   $	��190��6  ��6}   �� $ YearsExperience�$ TwoWay=� .  . 6  �� 5)   
   $��	Type Car:��6   $
��Left=�6$   $��488,168,0,0q�6?   $	��Top=�6T   $	��183��6l   $��20(�6x   �� 5*   
   -   5        $ 
CmbTypeCar��5*      $
��Left=�6'   $��30��6B   $��693,175,0,0q�6N   $	��Top=�6c   $	��190��6{    6�   �� $ 	TesterCar�$ TwoWay=� .  .  . �� 5+   
   $1��+Max distance you can do to take a treainee:��6   $
��Left=�6F   $��488,210,0,0q�6a   $	��Top=�6v   $	��395��6�   $��20(�6�   �� 5,   
   -   5        $ TxMaxDistance��5,      $
��Left=�6)   $��30��6D   $��883,216,0,0q�6P   $
 Wrap=�6e   $	��Top=�6�   $��72��6�   ��6y   �� $ MaxDistance�$ TwoWay=� .  . 6�   �� 5-   
   -   5         ��Name$ BtAddTester��5-      $	��ADD��6&   $
��Left=�64   $��673,379,0,0q�6O   $	��Top=�6d   $	��282��6|   $��78��6�   $��30(�6�   $��Rockwell Nova Cond Light)�6�   ���	#FF57A8D16�   �� 5.   
   -   5         ��Name$ image��5.      $
��Left=�6   $
��auto��6:   $��678,469,0,0q�6H   $	��Top=�6]   $	��307��6u   $9��3/PLWPF;component/images/משרד התחבורה.png��6�   51      52      