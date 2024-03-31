using FluentValidation;

namespace DoIT.Data.Model.DTO
{
    public class LectorCreateDTO
    {
        public string Name { get; set; }
        public string Email {  get; set; }
        
 /*       public string Url { get; set; }*/

    }

    public class LectorCreateValidator : AbstractValidator<LectorCreateDTO>
    {
        public LectorCreateValidator()
        {
            RuleFor(l => l.Name).NotEmpty();
            RuleFor(l => l.Email).NotEmpty().EmailAddress();
            /*RuleFor(l => l.Url).NotEmpty().Must(isValidUrl);*/

        }

        /*private bool isValidUrl(string url)
        {
            return Uri.TryCreate(url, UriKind.Absolute, out var uri) && (uri.Scheme == Uri.UriSchemeHttp
                ||  uri.Scheme == Uri.UriSchemeHttps);
        }*/
    }
}
