using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using Abp.Dependency;
using PLC.Instrument.Users;

namespace PLC.Instrument.App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, ISingletonDependency
    {
        private readonly IUserAppService _userAppService;

        public MainWindow(IUserAppService userAppService)
        {
            _userAppService = userAppService;
            InitializeComponent();
        }


        private async void AddNewPersonButton_Click(object sender, RoutedEventArgs e)
        {
            //try
            //{
            //    await _personAppService.AddNewPerson(new AddNewPersonInput
            //    {
            //        Name = NameTextBox.Text
            //    });

            //    await LoadAllPeopleAsync();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
        }

        private async void LoadAllUsersButton_Click(object sender, RoutedEventArgs e)
        {
            //PeopleList.Items.Clear();
            //var result = await _personAppService.GetAllPeopleAsync();
            //foreach (var person in result.People)
            //{
            //    PeopleList.Items.Add(person.Name);
            //}
            //
            var users =await _userAppService.GetAllAsync(new Abp.Application.Services.Dto.PagedResultRequestDto());
            MessageBox.Show(users.TotalCount.ToString()) ;
        }
    }
}
