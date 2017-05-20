namespace WillHomeWork1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using WillHomeWork1.Models;
    
    [MetadataType(typeof(客戶聯絡人MetaData))]
    public partial class 客戶聯絡人:IValidatableObject
    {
        客戶資料Entities db = new 客戶資料Entities();

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (this.Id == 0)
            {
                if (db.客戶聯絡人.Where(x => this.客戶Id == x.客戶Id && x.Email == this.Email).Any())
                {
                    yield return new ValidationResult("Email 已重複");
                }
            }
            else
            {
                if (db.客戶聯絡人.Where(x => x.Id != this.Id && x.Email == this.Email && this.客戶Id==x.客戶Id).Any())
                {
                    yield return new ValidationResult("Email 已重複");
                }
            }
        }
    }
    
    public partial class 客戶聯絡人MetaData
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int 客戶Id { get; set; }
        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        [Required]
        public string 職稱 { get; set; }
        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        [Required]
        public string 姓名 { get; set; }
        
        [StringLength(250, ErrorMessage="欄位長度不得大於 250 個字元")]
        [Required]
        public string Email { get; set; }
        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        public string 手機 { get; set; }
        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        public string 電話 { get; set; }
    
        public virtual 客戶資料 客戶資料 { get; set; }
    }
}
