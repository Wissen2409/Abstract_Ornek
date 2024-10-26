using System.Collections;
using System.Diagnostics.Contracts;
public class RequestBase{

  public string Url { get; set; }
}
public class PaymentRequest:RequestBase{
  
    public string CardHolder { get; set; }
    
    public string CardNumber{ get; set; }   

    public decimal Amount { get; set; }
}
public class RefundRequest:RequestBase{
    public decimal RefundAmount { get; set; }

}
public class BonusRequest:RequestBase{

    public int BonusAmount { get; set; }    
}
public class InstallmentRequest:RequestBase{

    public ArrayList InstallmentList{ get; set; }

}