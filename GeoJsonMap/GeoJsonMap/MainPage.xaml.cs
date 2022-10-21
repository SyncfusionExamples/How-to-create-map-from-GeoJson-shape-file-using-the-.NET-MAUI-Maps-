using Microsoft.Maui.Controls;
using Syncfusion.Maui.Maps;
using System.Xml;

namespace GeoJsonMap;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

        StackLayout verticalStackLayout = new StackLayout
        {
            Orientation = StackOrientation.Vertical,
        };
        
        SfMaps map = new SfMaps();
        MapShapeLayer layer = new MapShapeLayer();
        layer.ShapesSource = MapSource.FromResource("GeoJsonMap.ShapeFiles.world1.shp");
        map.Layer = layer;

        SfMaps Jsonmap = new SfMaps();
        MapShapeLayer shapeLayer = new MapShapeLayer();
        shapeLayer.ShapesSource = MapSource.FromResource("GeoJsonMap.ShapeFiles.world-map.json");
        Jsonmap.Layer = shapeLayer;

        verticalStackLayout.Add(map);
        verticalStackLayout.Add(Jsonmap);
        ScrollView scrollView = new ScrollView
        {
            Margin = new Thickness(20),
            Content = verticalStackLayout
        };

        Content = scrollView;
    }
}