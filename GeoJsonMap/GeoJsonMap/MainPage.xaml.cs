using Microsoft.Maui.Controls;
using Syncfusion.Maui.Maps;
using System.Xml;

namespace GeoJsonMap;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

        //Load an map using shape file from embedded resource
       /* SfMaps map = new SfMaps();
        MapShapeLayer layer = new MapShapeLayer();
        layer.ShapesSource = MapSource.FromResource("GeoJsonMap.ShapeFiles.world1.shp");
        map.Layer = layer;
        this.Content = map;*/

        //Load an map using json file from embedded resource
        SfMaps JsonMap = new SfMaps();
        MapShapeLayer shapeLayer = new MapShapeLayer();
        shapeLayer.ShapesSource = MapSource.FromResource("GeoJsonMap.ShapeFiles.world-map.json");
        JsonMap.Layer = shapeLayer;
        this.Content = JsonMap;
    }
}