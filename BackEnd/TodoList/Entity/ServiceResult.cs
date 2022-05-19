using TodoList.Enum;

namespace TodoList.Entity
{
    public class ServiceResult
    {
        /// <summary>
        /// Dữ liệu trả về
        /// </summary>
        /// Created by: PNToan 5.7.2021
        public object Data { get; set; }

        /// <summary>
        /// Tin nhắn trả về
        /// </summary>
        /// Created by: PNToan 5.7.2021
        public string Messenger { get; set; }

        /// <summary>
        /// Mã code
        /// </summary>
        /// Created by: PNToan 5.7.2021
        public ResponseCode ResponseCode { get; set; }

    }
}
