   M S B A M L   `   `   `  ����D  @WpfAppSMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:WpfAppSMS	WpfAppSMS  5   	       WpfAppSMS.Window1   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:WpfAppSMS     5   	     � Title$  Window1��5   	   $	��450��6   $	��800��6&   .��5	      � .+�5
   
   �� -   5         ��Name$ studentIdBlc��5
      $
��Left=�6*   $��
121,87,0,0q�6E   $
��Wrap=�6Y   $��	TextBlock��6m   $	��Top=�6~   �� 5   
   -   5        $ firstNameBlc��5      $
��Left=�6*   $��121,124,0,0q�6E   $
��Wrap=�6Z   $��	TextBlock��6n   $	��Top=�6   �� 5   
   -   5        $ lastNameBlc��5      $
��Left=�6)   $��121,162,0,0q�6D   $
��Wrap=�6Y   $��	TextBlock��6m   $	��Top=�6~   �� 5   
   -   5        $ 
programBlc��5      $
��Left=�6(   $��121,201,0,0q�6C   $
��Wrap=�6X   $��	TextBlock��6l   $	��Top=�6}   �� 5   
   $��Student ID:��6   $
��Left=�6&   $��	41,82,0,0q�6A   $	��Top=�6T   �� 5   
   $��First Name:��6   $
��Left=�6&   $��
41,119,0,0q�6A   $	��Top=�6U   �� 5   
   $��	Last Name��6   $
��Left=�6$   $��
41,157,0,0q�6?   $	��Top=�6S   �� 5   
   $��Program:��6   $
��Left=�6#   $��
41,196,0,0q�6>   $	��Top=�6R   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGridCourses��5      $��217,69,34,191q�6W   �� 5   
   -   5         ��Name$ 	enrollBtn��5      $��Enroll��6$   $
��Left=�65   $��
41,263,0,0q�6P   $	��Top=�6d   $	��118��6�   �� 5   
   -   5        $ deleteEnrollmentBtn��5      $��Delete Enrollment��6.   $
��Left=�6J   $��
41,304,0,0q�6e   $	��Top=�6y   $	��118��6�   �� 5   
   -   5         ��Name$ listBoxCourses��5      $��366,273,34,41q�6U   5      5      