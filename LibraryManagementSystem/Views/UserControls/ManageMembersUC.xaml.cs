﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using LibraryManagementSystem.Views.MemberForms;

namespace LibraryManagementSystem.Views.UserControls
{
    /// <summary>
    /// Interaction logic for ManageMembersUC.xaml
    /// </summary>
    public partial class ManageMembersUC : UserControl
    {
        public ManageMembersUC()
        {
            InitializeComponent();
        }

        private void AddMemberBtn_Click(object sender, RoutedEventArgs e)
        {
            AddMemberForm addMemberForm = new AddMemberForm();
            addMemberForm.Show();             
        }

        private void DeleteMemberBtn_Click(object sender, RoutedEventArgs e)
        {
            DeleteMemberForm deleteMemberForm = new DeleteMemberForm();
            deleteMemberForm.Show();
        }

        private void UpdateMemberBtn_Click(object sender, RoutedEventArgs e)
        {
            UpdateMemberForm updateMemberForm = new UpdateMemberForm();
            updateMemberForm.Show();
        }
    }
}
