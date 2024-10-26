public abstract class BankBase{

    public abstract void Pay(PaymentRequest request);
    public abstract void Refund(RefundRequest request);

    public virtual void  Bonus(BonusRequest request){

        Console.WriteLine(request.BonusAmount);
    }
    public virtual void Installment(InstallmentRequest request){

        foreach (var item in request.InstallmentList){
            Console.WriteLine(item);
        }
    }
}