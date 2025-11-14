using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F34006 - .
/// </summary>
public class F34006 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SJITM.
        /// </summary>
        public const string SJITM = "SJITM";

        /// <summary>
        /// SJMCU.
        /// </summary>
        public const string SJMCU = "SJMCU";

        /// <summary>
        /// SJTYPF.
        /// </summary>
        public const string SJTYPF = "SJTYPF";

        /// <summary>
        /// SJSFKY.
        /// </summary>
        public const string SJSFKY = "SJSFKY";

        /// <summary>
        /// SJKVER.
        /// </summary>
        public const string SJKVER = "SJKVER";
    }

    /// <inheritdoc />
    public override string TableName => "F34006";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SJITM", "SJITM", JdeDataType.Numeric, null, true, true),
        new JdeField("SJMCU", "SJMCU", JdeDataType.String, 24, true, true),
        new JdeField("SJTYPF", "SJTYPF", JdeDataType.String, 4, true, true),
        new JdeField("SJSFKY", "SJSFKY", JdeDataType.Numeric, null, true, true),
        new JdeField("SJKVER", "SJKVER", JdeDataType.String, 6, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F34006_0", "Primary Key on SJKVER, SJTYPF, SJITM, SJSFKY, SJMCU", new[] { "SJKVER", "SJTYPF", "SJITM", "SJSFKY", "SJMCU" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F34006_2", "Index on SJKVER, SJSFKY", new[] { "SJKVER", "SJSFKY" }),
        new JdeIndex("F34006_3", "Index on SJKVER, SJTYPF, SJITM, SJMCU, SJSFKY", new[] { "SJKVER", "SJTYPF", "SJITM", "SJMCU", "SJSFKY" })
    };
}
