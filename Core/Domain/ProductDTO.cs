using System.Runtime.Serialization;

namespace Core.Domain
{
    /// <summary>
    /// DTO Товара.
    /// </summary>
    [DataContract]
    public class ProductDTO
    {
        #region Data Properties

        /// <summary>
        /// Ид товара.
        /// </summary>
        [DataMember]
        public int Id { get; set; }

        /// <summary>
        /// Имя товара.
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        #endregion
    }
}
