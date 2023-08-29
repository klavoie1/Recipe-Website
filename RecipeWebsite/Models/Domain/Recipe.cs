namespace RecipeWebsite.Models.Domain
{
    public class Recipe
    {
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public int NumOfPeopleServed { get; set; }
        public string Difficulty { get; set; }
        public string ListOfIngredients { get; set; }
    }
}
