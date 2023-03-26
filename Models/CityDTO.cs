namespace CityInfo.API.Models
{
    /// <summary>
    /// A city with points of interest and the number of points of interest.
    /// </summary>
    public class CityDTO
    {
        /// <summary>
        /// The Id of the city.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The Name of the city.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// The description of the city.
        /// </summary>
        public string? Description { get; set; }

        public int NumberOfPointsOfInterest
        {
            get
            {
                return PointsOfInterest.Count;
            }
        }
        public ICollection<PointOfInterestDTO> PointsOfInterest { get; set; } = new List<PointOfInterestDTO>();   
    }
}
