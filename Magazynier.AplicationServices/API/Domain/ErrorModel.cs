namespace Magazynier.AplicationServices.API.Domain
{
    public class ErrorModel
    {
        public ErrorModel(string error)
        {
            this.Error= error;
        }
        public string Error { get;  }
    }
}