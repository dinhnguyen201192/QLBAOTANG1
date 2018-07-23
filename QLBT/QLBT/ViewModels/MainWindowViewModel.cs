using System.Collections.Generic;
using System.Collections.ObjectModel;
using Prism.Mvvm;
using QLBT.Views;

namespace QLBT.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private List<SinhVien> listSinhVien;

        private List<SinhVien> ListSinhVien
        {
            get { return listSinhVien; }
            set { listSinhVien = value; }
        }

        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public object lsvShow { get; private set; }

        public MainWindowViewModel()
        {

            listSinhVien = new List<SinhVien>();
            listSinhVien.Add(new SinhVien() {Id=1, Ten = "Long" });
            listSinhVien.Add(new SinhVien() { Id = 2, Ten = "Linh" });
            listSinhVien.Add(new SinhVien() { Id = 3, Ten = "Nguyen" });
            listSinhVien.Add(new SinhVien() { Id = 4, Ten = "Minh" });
            listSinhVien.Add(new SinhVien() { Id = 5, Ten = "Long" });

            
        }
        public class SinhVien {
            private int id;

            public int Id
            {
                get { return id; }
                set { id= value; }
            }

            private string ten;
            public string Ten
            {
                get { return ten; }
                set { ten = value; }
            }
            public string Error
            {
                get { return null; }
            }
            
        }

    }
}
