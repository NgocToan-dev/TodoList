using System;
using System.ComponentModel.DataAnnotations;

namespace TodoList.Entity
{
    public class TodoItem : BaseEntity
    {
        #region Declare
        /// <summary>
        /// ID
        /// </summary>
        [Key]
        public int TodoItemID { get; set; }
        /// <summary>
        /// Thuộc về user nào
        /// </summary>
        public int UserID { get; set; }
        /// <summary>
        /// Tên công việc
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Mô tả thêm
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Thời gian nhắc nhở
        /// </summary>
        public DateTime DeadlineTime { get; set; }

        #endregion

        #region Contructor
        public TodoItem()
        {
        }
        #endregion

    }
}
