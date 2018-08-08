namespace AspNet21_Swagger.Models
{
    /// <summary>
    /// Request object to list Values
    /// </summary>
    public class ValuesRequest
    {
        /// <summary>
        /// Index of Page
        /// </summary>
        public int PageIndex { get; set; }
        /// <summary>
        /// Size of Page 
        /// </summary>
        public int PageSize { get; set; }
    }
}
