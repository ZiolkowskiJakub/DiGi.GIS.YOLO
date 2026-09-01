#### [DiGi\.GIS\.YOLO](DiGi.GIS.YOLO.Overview.md 'DiGi\.GIS\.YOLO\.Overview')

## DiGi\.GIS\.YOLO Namespace
### Classes

<a name='DiGi.GIS.YOLO.Modify'></a>

## Modify Class

```csharp
public static class Modify
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Modify
### Methods

<a name='DiGi.GIS.YOLO.Modify.ExportPredictionImagesAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,int,string,int,bool,System.Threading.CancellationToken)'></a>

## Modify\.ExportPredictionImagesAsync\(this GISWebAPIManager, int, string, int, bool, CancellationToken\) Method

Exports orthophoto prediction images from the database for a specified county to the designated output directory\.

Decodes binary payloads from [DiGi\.GIS\.Classes\.OrtoData\.Bytes](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.ortodata.bytes 'DiGi\.GIS\.Classes\.OrtoData\.Bytes') and re-encodes them as JPEG files named `{reference}_{year}.jpeg`.

```csharp
public static System.Threading.Tasks.Task<bool> ExportPredictionImagesAsync(this DiGi.GIS.WebAPI.Classes.GISWebAPIManager? gisWebAPIManager, int countyId, string? destinationDirectory, int maxConcurrentRequests=8, bool resume=true, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.YOLO.Modify.ExportPredictionImagesAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,int,string,int,bool,System.Threading.CancellationToken).gisWebAPIManager'></a>

`gisWebAPIManager` [DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIManager](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.webapi.classes.giswebapimanager 'DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIManager')

The [DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIManager](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.webapi.classes.giswebapimanager 'DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIManager') instance used to communicate with the WebAPI\.

<a name='DiGi.GIS.YOLO.Modify.ExportPredictionImagesAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,int,string,int,bool,System.Threading.CancellationToken).countyId'></a>

`countyId` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The integer identifier of the county partition to export images for\.

<a name='DiGi.GIS.YOLO.Modify.ExportPredictionImagesAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,int,string,int,bool,System.Threading.CancellationToken).destinationDirectory'></a>

`destinationDirectory` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The target directory path on disk where JPEG files will be saved\.

<a name='DiGi.GIS.YOLO.Modify.ExportPredictionImagesAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,int,string,int,bool,System.Threading.CancellationToken).maxConcurrentRequests'></a>

`maxConcurrentRequests` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The maximum number of concurrent WebAPI requests allowed during image fetching\. Defaults to 8\.

<a name='DiGi.GIS.YOLO.Modify.ExportPredictionImagesAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,int,string,int,bool,System.Threading.CancellationToken).resume'></a>

`resume` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

When [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool'), skips downloading or re\-encoding images already present on disk\. Defaults to [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.GIS.YOLO.Modify.ExportPredictionImagesAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,int,string,int,bool,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

A cancellation token to observe while performing the operation\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task returning [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the export completed successfully; otherwise [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.