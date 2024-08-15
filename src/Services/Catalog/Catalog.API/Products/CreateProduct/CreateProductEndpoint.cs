using Carter;
using Mapster;
using MediatR;

namespace Catalog.API.Products.CreateProduct;

public record CreateProductRequest(
    string Name,
    List<string> Category,
    string Description,
    string ImageFile,
    decimal Price)
{
    public CreateProductRequest() : this(string.Empty, new List<string>(), string.Empty, string.Empty, 0)
    {
    }
}

public abstract record CreateProductResponse(Guid Id);

public class CreateProductEndpoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapPost("/products", async (CreateProductRequest request, ISender sender) =>
        {
            // var command = request.Adapt<CreateProductCommand>();
            var createProductResult = new CreateProductResult(Guid.NewGuid());

            // var result = await sender.Send(command);
            //
            // var response = result.Adapt<CreateProductResponse>();

            return createProductResult;
        });
    }
}