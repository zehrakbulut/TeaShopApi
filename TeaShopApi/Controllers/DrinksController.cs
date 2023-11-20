using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TeaShopApi.BusinessLayer.Abstract;
using TeaShopApi.DtoLayer.DrinkDtos;
using TeaShopApi.EntityLayer.Concrete;

namespace TeaShopApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DrinksController : ControllerBase
    {
        private readonly IDrinkService _drinkService;

        public DrinksController(IDrinkService drinkService)
        {
            _drinkService = drinkService;
        }

        [HttpGet]
        public IActionResult DrinkList()
        {
            var values=_drinkService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateDrink(CreateDrinkDto createDrinkDto)
        {
            Drink drink = new Drink()
            {
                DrinkImageUrl = createDrinkDto.DrinkImageUrl,
                DrinkName = createDrinkDto.DrinkName,
                DrinkPrice = createDrinkDto.DrinkPrice
            };
            _drinkService.TInsert(drink);
            return Ok("İçeceğiniz Eklendi");
        }
    }
}
