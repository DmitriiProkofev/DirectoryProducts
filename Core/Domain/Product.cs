using System.Runtime.Serialization;

namespace Core.Domain
{
    /// <summary>
    /// Товар.
    /// </summary>
    [DataContract]
    public class Product
    {
        #region Constructors

        public Product()
        { }

        public Product(string name, GroupProduct groupProduct)
        {
            Name = name;
            GroupProduct = groupProduct;
        }

        #endregion

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

        /// <summary>
        /// Группа товара.
        /// </summary>
        [DataMember]
        public GroupProduct GroupProduct { get; set; }

        #endregion

        public override string ToString()
        {
            return Name;
        }
    }
}
