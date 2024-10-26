public class Garanti : BankBase
{
    public override void Pay(PaymentRequest request)
    {
        Console.WriteLine(request.CardHolder);
    }

    public override void Refund(RefundRequest request)
    {
        Console.WriteLine(request.RefundAmount);
    }
    public override void Installment(InstallmentRequest request)
    {
        base.Installment(request);
    }
}