using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;

namespace test_ValidateableBase
{
    [POCOViewModel]
    class MainWindowViewModel : ValidateableBase
    {


        public MainWindowViewModel()
        {
            TestModel = new TestModel();
        }

        public TestModel TestModel { get; set; }


        [Command]
        public void ErrorCheck()
        {
            TestModel.InputCheck();

            if(TestModel.InputString == "222")
            {
                TestModel.AddError("InputString", "相関チェックエラーです。");
            }

            bool has_error = TestModel.HasErrors;

            Console.WriteLine(has_error);
        }
    }
}
