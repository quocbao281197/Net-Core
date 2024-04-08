namespace BlazingPizza.API.Services
{
    public class PizzaServices
    {
        public async Task<List<Data.Pizza>> GetPizzasAsync()
        {
            List<Data.Pizza> pizzas = new List<Data.Pizza>();
            pizzas.Add(new Data.Pizza()
            {
                Name = "Margherita",
                Description = "False",
                PizzaId = 1,
                Vegetarian = false,
                Price = 1,
                Vegan = false
            });
            return pizzas;
        }
    }
}
