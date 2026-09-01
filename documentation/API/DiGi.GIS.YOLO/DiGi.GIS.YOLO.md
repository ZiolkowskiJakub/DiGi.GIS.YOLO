#### [DiGi\.GIS\.YOLO](DiGi.GIS.YOLO.Overview.md 'DiGi\.GIS\.YOLO\.Overview')

## DiGi\.GIS\.YOLO Namespace
### Classes

<a name='DiGi.GIS.YOLO.Create'></a>

## Create Class

```csharp
public static class Create
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Create
### Methods

<a name='DiGi.GIS.YOLO.Create.Building2DYearBuiltPredictions(thisDiGi.YOLO.Classes.BoundingBoxResultFile)'></a>

## Create\.Building2DYearBuiltPredictions\(this BoundingBoxResultFile\) Method

Creates a list of [DiGi\.GIS\.Classes\.Building2DYearBuiltPredictions](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.building2dyearbuiltpredictions 'DiGi\.GIS\.Classes\.Building2DYearBuiltPredictions') instances from the specified bounding box result file\.

```csharp
public static System.Collections.Generic.List<DiGi.GIS.Classes.Building2DYearBuiltPredictions>? Building2DYearBuiltPredictions(this DiGi.YOLO.Classes.BoundingBoxResultFile? boundingBoxResultFile);
```
#### Parameters

<a name='DiGi.GIS.YOLO.Create.Building2DYearBuiltPredictions(thisDiGi.YOLO.Classes.BoundingBoxResultFile).boundingBoxResultFile'></a>

`boundingBoxResultFile` [DiGi\.YOLO\.Classes\.BoundingBoxResultFile](https://learn.microsoft.com/en-us/dotnet/api/digi.yolo.classes.boundingboxresultfile 'DiGi\.YOLO\.Classes\.BoundingBoxResultFile')

The bounding box result file containing YOLO predictions\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.GIS\.Classes\.Building2DYearBuiltPredictions](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.building2dyearbuiltpredictions 'DiGi\.GIS\.Classes\.Building2DYearBuiltPredictions')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of [DiGi\.GIS\.Classes\.Building2DYearBuiltPredictions](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.building2dyearbuiltpredictions 'DiGi\.GIS\.Classes\.Building2DYearBuiltPredictions') objects grouped by building reference if valid; otherwise, `null`\.

<a name='DiGi.GIS.YOLO.Create.Building2DYearBuiltPredictions(thisDiGi.YOLO.Classes.YOLOPredictionResult)'></a>

## Create\.Building2DYearBuiltPredictions\(this YOLOPredictionResult\) Method

Creates a list of [DiGi\.GIS\.Classes\.Building2DYearBuiltPredictions](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.building2dyearbuiltpredictions 'DiGi\.GIS\.Classes\.Building2DYearBuiltPredictions') instances from the specified YOLO prediction result\.

```csharp
public static System.Collections.Generic.List<DiGi.GIS.Classes.Building2DYearBuiltPredictions>? Building2DYearBuiltPredictions(this DiGi.YOLO.Classes.YOLOPredictionResult? yOLOPredictionResult);
```
#### Parameters

<a name='DiGi.GIS.YOLO.Create.Building2DYearBuiltPredictions(thisDiGi.YOLO.Classes.YOLOPredictionResult).yOLOPredictionResult'></a>

`yOLOPredictionResult` [DiGi\.YOLO\.Classes\.YOLOPredictionResult](https://learn.microsoft.com/en-us/dotnet/api/digi.yolo.classes.yolopredictionresult 'DiGi\.YOLO\.Classes\.YOLOPredictionResult')

The YOLO prediction result containing bounding box data\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.GIS\.Classes\.Building2DYearBuiltPredictions](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.building2dyearbuiltpredictions 'DiGi\.GIS\.Classes\.Building2DYearBuiltPredictions')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of [DiGi\.GIS\.Classes\.Building2DYearBuiltPredictions](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.building2dyearbuiltpredictions 'DiGi\.GIS\.Classes\.Building2DYearBuiltPredictions') objects grouped by building reference if valid; otherwise, `null`\.