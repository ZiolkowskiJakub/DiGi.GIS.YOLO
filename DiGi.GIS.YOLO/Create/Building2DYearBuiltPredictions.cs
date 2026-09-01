using DiGi.Geometry.Planar.Classes;
using DiGi.GIS.Classes;
using DiGi.YOLO.Classes;
using System.Collections.Generic;
using System.IO;

namespace DiGi.GIS.YOLO
{
    public static partial class Create
    {
        /// <summary>
        /// Creates a list of <see cref="GIS.Classes.Building2DYearBuiltPredictions"/> instances from the specified bounding box result file.
        /// </summary>
        /// <param name="boundingBoxResultFile">The bounding box result file containing YOLO predictions.</param>
        /// <returns>A list of <see cref="GIS.Classes.Building2DYearBuiltPredictions"/> objects grouped by building reference if valid; otherwise, <c>null</c>.</returns>
        public static List<Building2DYearBuiltPredictions>? Building2DYearBuiltPredictions(this BoundingBoxResultFile? boundingBoxResultFile)
        {
            if (boundingBoxResultFile is null)
            {
                return null;
            }

            Dictionary<string, List<YearBuiltPrediction>> dictionary = [];
            foreach (BoundingBoxResult boundingBoxResult in boundingBoxResultFile)
            {
                string? name = boundingBoxResult?.Name;
                if (string.IsNullOrWhiteSpace(name))
                {
                    continue;
                }

                string cleanName = Path.GetFileNameWithoutExtension(name!);
                int lastUnderscoreIndex = cleanName.LastIndexOf('_');
                if (lastUnderscoreIndex <= 0 || lastUnderscoreIndex == cleanName.Length - 1)
                {
                    continue;
                }

                string yearString = cleanName[(lastUnderscoreIndex + 1)..].Trim();
                if (!ushort.TryParse(yearString, out ushort year))
                {
                    continue;
                }

                string reference = cleanName[..lastUnderscoreIndex].Trim();
                if (string.IsNullOrWhiteSpace(reference))
                {
                    continue;
                }

                if (!dictionary.TryGetValue(reference, out List<YearBuiltPrediction>? yearBuiltPredictions) || yearBuiltPredictions is null)
                {
                    yearBuiltPredictions = [];
                    dictionary[reference] = yearBuiltPredictions;
                }

                BoundingBox2D boundingBox2D = new(boundingBoxResult!.X, boundingBoxResult.Y, boundingBoxResult.Width, boundingBoxResult.Height);
                YearBuiltPrediction yearBuiltPrediction = new(year, boundingBox2D, boundingBoxResult.Confidence);
                yearBuiltPredictions.Add(yearBuiltPrediction);
            }

            List<Building2DYearBuiltPredictions> result = [];
            foreach (KeyValuePair<string, List<YearBuiltPrediction>> keyValuePair in dictionary)
            {
                result.Add(new Building2DYearBuiltPredictions(keyValuePair.Key, keyValuePair.Value));
            }

            return result;
        }

        /// <summary>
        /// Creates a list of <see cref="GIS.Classes.Building2DYearBuiltPredictions"/> instances from the specified YOLO prediction result.
        /// </summary>
        /// <param name="yOLOPredictionResult">The YOLO prediction result containing bounding box data.</param>
        /// <returns>A list of <see cref="GIS.Classes.Building2DYearBuiltPredictions"/> objects grouped by building reference if valid; otherwise, <c>null</c>.</returns>
        public static List<Building2DYearBuiltPredictions>? Building2DYearBuiltPredictions(this YOLOPredictionResult? yOLOPredictionResult)
        {
            if (yOLOPredictionResult is null)
            {
                return null;
            }

            BoundingBoxResultFile? boundingBoxResultFile = DiGi.YOLO.Create.BoundingBoxResultFile(yOLOPredictionResult);
            if (boundingBoxResultFile is null)
            {
                return null;
            }

            return Building2DYearBuiltPredictions(boundingBoxResultFile);
        }
    }
}
