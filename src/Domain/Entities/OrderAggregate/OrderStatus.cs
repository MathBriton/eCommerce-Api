namespace Core.Entities.OrderAggregate;

public enum OrderStatus

{
    pending,
    PaymentReceived,
    PaymentFailed,
    PaymentMismatch,
    Refunded
}