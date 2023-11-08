namespace BillManager.Model;

public class Bill
{
    public string name { get; set; }
    public string receiver { get; set; }
    public float price { get; set; }
    public DateOnly dueDate { get; set; }
}