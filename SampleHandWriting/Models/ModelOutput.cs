using Microsoft.ML.Data;

namespace SampleHandWriting.Models;

public class ModelOutput
{
    // ColumnName attribute is used to change the column name from
    // its default value, which is the name of the field.
    [ColumnName("PredictedLabel")]
    public float Prediction { get; set; }
    public float[] Score { get; set; }
}