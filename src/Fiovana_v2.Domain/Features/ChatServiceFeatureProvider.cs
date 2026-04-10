using Volo.Abp.Features;
using Volo.Chat;
using System.Linq;

namespace Fiovana_v2.ChatService.Features;

public class ChatServiceFeatureProvider : FeatureDefinitionProvider 
{
    public override void Define(IFeatureDefinitionContext context)
    {
        context
            .GetGroupOrNull(ChatFeatures.GroupName)!
            .Features
            .FirstOrDefault(f => f.Name == ChatFeatures.Enable)!
            .DefaultValue = "true";
    }
}