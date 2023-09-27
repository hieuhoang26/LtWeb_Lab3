using System.ComponentModel.DataAnnotations;

namespace ThucHanh1.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập tên.")]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "Tên phải có ít nhất 4 ký tự và tối đa 100 ký tự.")]
        [Display(Name = "Họ và tên")]
        public string? Name { get; set; }

        //[Required(ErrorMessage = "Email bắt buộc phải được nhập")]
        //[RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}")]
        [Required(ErrorMessage = "Vui lòng nhập email.")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@gmail\.com$", ErrorMessage = "Email phải có địa chỉ gmail.com.")]
        [Display(Name = "Email")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập mật khẩu.")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@#$%^&+=]).{8,}$", ErrorMessage = "Mật khẩu phải từ 8 ký tự trở lên, bao gồm ít nhất một ký tự viết hoa, một ký tự viết thường, một chữ số và một ký tự đặc biệt.")]
        [Display(Name = "Mật khẩu")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn chi nhánh.")]
        [Display(Name = "Chi nhánh")]
        public Branch? Branch { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn giới tính.")]
        [Display(Name = "Giới tính")]
        public Gender? Gender { get; set; }

        [DataType(DataType.MultilineText)]

        [Display(Name = "Học viên thường xuyên")]
        public bool IsRegular { get; set; }

        [Display(Name = "Địa chỉ")]
        public string? Address { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập ngày sinh.")]
        [Display(Name = "Ngày sinh")]
        [DataType(DataType.Date)]
        [Range(typeof(DateTime), "1/1/1963", "12/31/2005", ErrorMessage = "Ngày sinh phải nằm trong khoảng từ 1/1/1963 đến 12/31/2005.")]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập điểm.")]
        [Display(Name = "Điểm")]
        [Range(0.0, 10.0, ErrorMessage = "Điểm phải nằm trong khoảng từ 0.0 đến 10.0.")]
        public double? Score { get; set; }
    }
}

