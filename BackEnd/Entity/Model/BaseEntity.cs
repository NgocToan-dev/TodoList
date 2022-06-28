using System;

namespace Entity.Model
{
    public class BaseEntity
    {
        #region declare
        /// <summary>
        /// Ngày tạo
        /// </summary>
        public DateTime CreatedDate { get; set; }
        /// <summary>
        /// Ngày chỉnh sửa
        /// </summary>
        public DateTime UpdatedDate { get; set; }
        #endregion
    }
}
