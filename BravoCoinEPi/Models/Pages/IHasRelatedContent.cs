using EPiServer.Core;

namespace BravoCoinEPi.Models.Pages
{
    public interface IHasRelatedContent
    {
        ContentArea RelatedContentArea { get; }
    }
}
