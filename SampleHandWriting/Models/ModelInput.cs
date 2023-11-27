using Microsoft.ML.Data;

namespace SampleHandWriting.Models;

public class ModelInput
{
    [ColumnName("PixelValues"), LoadColumn(0, 63)]
    [VectorType(64)]
    public float[] PixelValues { get; set; }


    [ColumnName("Number"), LoadColumn(64)]
    public float Number { get; set; }
}