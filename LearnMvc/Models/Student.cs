using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LearnMvc.Models
{
    public class Student
    {
        [Required(ErrorMessage = "姓名不能为空")]
        public string Name { get; set; }
        [Required(ErrorMessage = "姓名不能为空")]
        [RegularExpression(".+\\@.+\\..+",ErrorMessage = "请输入有效的Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "电话号码不能为空")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "请选择是否到场")]
        public bool? WillAtend { get; set; }
    }
}