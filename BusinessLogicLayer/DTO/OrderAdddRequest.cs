namespace eCommerce.OrdersMicroservice.BusinessLogicLayer.DTO;

public record OrderAddRequest(Guid UserID, DateTime OrderDate, List<OrderItemAddRequest> OrderItems)
{
    //El this is for constructor chaining para llamar el constructor con parámetros. Se hace esto por que automapper requiere un
    //constructor sin parámetros para poder mapear el objeto.
    public OrderAddRequest() : this(default, default, default)
    {
    }
}