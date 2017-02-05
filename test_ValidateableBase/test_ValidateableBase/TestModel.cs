using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_ValidateableBase
{
    public class TestModel : ValidateableBase
    {
        [Required(ErrorMessage = "何か入力してください")]
        [MaxLength(10, ErrorMessage = "10文字以内で入力してください")]
        public string InputString { get; set; } = string.Empty;

        public string NoCheckProperty { get; set; } = string.Empty;



        //public void InputCheck()
        //{
        //    RemoveError(nameof(InputString));
        //    ValidateProperty(InputString, nameof(InputString));
        //}
    }
}
