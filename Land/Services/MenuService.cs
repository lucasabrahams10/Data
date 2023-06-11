using LandLord.Models.Entities;

namespace LandLord.Services;

internal class MenuService
{
    private readonly OrderService _orderService = new();
    private readonly OrderRowService _orderRowService = new();
    private readonly PersonService _personService = new();

    public async Task MainMenu()
    {
        Console.Clear();
        Console.WriteLine("############ HuvudMenyn ###############");
        Console.WriteLine("1. Visa alla personer");
        Console.WriteLine("2. Visa alla aktiva ordra");
        Console.WriteLine("3. Sök efter en order");
        Console.WriteLine("4. Skapa en order");
        Console.WriteLine("5. Uppdatera status på en order");
        Console.WriteLine("6. Lägg till kommentar på order");
        var option = Console.ReadLine();

        switch (option)
        {
            case "1":
                await GetAllPersonsAsync();
                break;
            case "2":
                await OrdersAsync();
                break;
            case "3":
                await OneOrdersAsync();
                break;
            case "4":
                await CreateOneOrderAsync();
                break;
            case "5":
                await GetAllActiveOrderRowsAsync();
                break;
            case "6":
                await UpdateStatusOnOrder();
                break;
            case "7":
                await AddCommentAsync();
                break;
            default:
                break;

        }
    }

    private async Task GetAllPersonsAsync()
    {
        Console.Clear();
        Console.WriteLine("############ Alla personer ###############");
        foreach( var _allPerson in await _personService.GetAllPersonsAsync())
        {
            Console.WriteLine($"Id: {_allPerson.Id}");
            Console.WriteLine($"Namn: {_allPerson.FirstName} {_allPerson.LastName}");
            Console.WriteLine($"Telefon nummer: {_allPerson.PhoneNumber}");
            Console.WriteLine($"Telefon nummer: {_allPerson.Email}");
            Console.WriteLine();
        }
    }
    private async Task OrdersAsync()
    {
        Console.Clear();
        Console.WriteLine("############ Alla ordra ###############");
        foreach(var _orders in await _orderService.GetAllOrdersAsync())
        {
            Console.WriteLine($"Namn: {_orders.Tenant.Person.FirstName} {_orders.Tenant.Person.LastName}");
            Console.WriteLine($"Stad: {_orders.Tenant.Apartment.City}");
            Console.WriteLine($"Postnummer: {_orders.Tenant.Apartment.ZipCode}");
            Console.WriteLine($"Gata: {_orders.Tenant.Apartment.StreetName} {_orders.Tenant.Apartment.HouseNumber} {_orders.Tenant.Apartment.Entrance}");
            Console.WriteLine($"Lägenhetsnummer: {_orders.Tenant.Apartment.ApartmentNumber}");
            Console.WriteLine($"Skapad: {_orders.CreatedAt}");
        }
        
    }

    private async Task OneOrdersAsync()
    {
        
    }

    private async Task CreateOneOrderAsync()
    {
        var _entityOrder = new OrderEntity();
        Console.Clear();
        Console.WriteLine("############ Ny order ###############");
        Console.WriteLine("Ange Hyresgäst Id");
        string input = Console.ReadLine() ?? "";
        int tenantId;
        if (int.TryParse(input, out tenantId))
        {
            _entityOrder.TenantId = tenantId;
        }
        else
        {
            Console.WriteLine("TenantId måste vara ett nummer.");
        }

        var _entityRow = new OrderRowEntity {OrderId = _entityOrder.Id };
    }

    private async Task GetAllActiveOrderRowsAsync()
    {
        Console.Clear();
        Console.WriteLine("############ Pågånde orderader ###############");
        foreach( var _activeOrderRows in await _orderRowService.GetAllActiveOrderRowsAsync())
        {
            Console.WriteLine($"OrderId: {_activeOrderRows.OrderId}");
            Console.WriteLine($"Beskrivning: {_activeOrderRows.Description}");
            Console.WriteLine($"Status: {_activeOrderRows.StatusCode}");
            Console.WriteLine($"Uppdaterad: {_activeOrderRows.UpdateAt}");
        }
    }

    private async Task UpdateStatusOnOrder()
    {

    }

    private async Task AddCommentAsync()
    {

    }
}