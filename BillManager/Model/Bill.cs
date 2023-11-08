namespace BillManager.Model;

public class Bill
{
    public string Name { get; set; }
    public string Receiver { get; set; }
    public float Price { get; set; }
    public DateOnly DueDate { get; set; }
}