namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Category")]
    public partial class Category
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(15,ErrorMessage ="Tên danh mục quá dài")]
        [DisplayName("Tên Danh Mục")]
        [Required(ErrorMessage = "Tên danh mục trống")]
        public string Name { get; set; }
        [DisplayName("Alias")]
        [StringLength(50)]
        public string Alias { get; set; }
        [DisplayName("Danh Mục Cha")]
        public int? ParentID { get; set; }
        [DisplayName("Ngày tạo")]
        public DateTime? CreateDate { get; set; }
        [DisplayName("Thứ tự")]
        [Range (0,Int32.MaxValue, ErrorMessage = "Thứ tự đã nhập không hợp lệ")]
        public int? Order { get; set; }
        [DisplayName("Trạng Thái")]
        public bool? Status { get; set; }
    }
}
