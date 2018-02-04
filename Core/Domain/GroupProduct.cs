using System.Runtime.Serialization;

namespace Core.Domain
{
    /// <summary>
    /// Группа товара.
    /// </summary>
    [DataContract]
    public class GroupProduct
    {
        #region Constructors

        public GroupProduct()
        { }

        public GroupProduct(string name)
        {
            Name = name;
        }

        #endregion

        #region Data Properties

        /// <summary>
        /// Ид группы товара.
        /// </summary>
        [DataMember]
        public int Id { get; set; }

        /// <summary>
        /// Имя группы товара.
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        #endregion

        public override string ToString()
        {
            return Name;
        }
    }
}
