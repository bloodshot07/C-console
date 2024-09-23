
class GetSet
{
    private string _model;

    public string Model
    {
        get {return _model;}
        set { _model = value}
    }
}

class person 
{
    private string _name;
    {
        get { return _name; }
        set
    {
        if(!string.IsNullOrEmpty(value))
        {
            _name = value
        }
    }
    }
}

class short
{
    public string Cut { get; set; }
}

class BankAccount 
{
    private decimal _balance
    public decimal Balance
    {
        get{ return _balance; }
        set{
            if(value >= 0)
            {
                _balance = value;
            }
        }

    }
    

}