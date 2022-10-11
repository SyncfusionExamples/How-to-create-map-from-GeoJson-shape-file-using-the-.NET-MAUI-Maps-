using Syncfusion.Maui.Maps;
using System.Xml;

namespace GeoJsonMap;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}
}

[ContentProperty("Source")]
public class ImageResourceExtension : IMarkupExtension<MapSource>
{
    public string Source { set; get; }

    public MapSource ProvideValue(IServiceProvider serviceProvider)
    {
        if (String.IsNullOrEmpty(Source))
        {
            IXmlLineInfoProvider lineInfoProvider = serviceProvider.GetService(typeof(IXmlLineInfoProvider)) as IXmlLineInfoProvider;
            IXmlLineInfo lineInfo = (lineInfoProvider != null) ? lineInfoProvider.XmlLineInfo : new XmlLineInfo();
            throw new XamlParseException("ImageResourceExtension requires Source property to be set", lineInfo);
        }

        // string assemblyName = GetType().GetTypeInfo().Assembly.GetName().Name;
        return MapSource.FromResource(Source);
    }

    object IMarkupExtension.ProvideValue(IServiceProvider serviceProvider)
    {
        return (this as IMarkupExtension<MapSource>).ProvideValue(serviceProvider);
    }
}


