using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F12141 - .
/// </summary>
public class F12141 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DTCO.
        /// </summary>
        public const string DTCO = "DTCO";

        /// <summary>
        /// DTEQST.
        /// </summary>
        public const string DTEQST = "DTEQST";

        /// <summary>
        /// DTLT.
        /// </summary>
        public const string DTLT = "DTLT";

        /// <summary>
        /// DTCHCD.
        /// </summary>
        public const string DTCHCD = "DTCHCD";

        /// <summary>
        /// DTMCU.
        /// </summary>
        public const string DTMCU = "DTMCU";

        /// <summary>
        /// DTOBJ.
        /// </summary>
        public const string DTOBJ = "DTOBJ";

        /// <summary>
        /// DTSUB.
        /// </summary>
        public const string DTSUB = "DTSUB";
    }

    /// <inheritdoc />
    public override string TableName => "F12141";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DTCO", "DTCO", JdeDataType.String, 10, true, true),
        new JdeField("DTEQST", "DTEQST", JdeDataType.String, 4, true, true),
        new JdeField("DTLT", "DTLT", JdeDataType.String, 4, true, true),
        new JdeField("DTCHCD", "DTCHCD", JdeDataType.String, 2, true, true),
        new JdeField("DTMCU", "DTMCU", JdeDataType.String, 24),
        new JdeField("DTOBJ", "DTOBJ", JdeDataType.String, 12),
        new JdeField("DTSUB", "DTSUB", JdeDataType.String, 16)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F12141_0", "Primary Key on DTCO, DTEQST, DTLT, DTCHCD", new[] { "DTCO", "DTEQST", "DTLT", "DTCHCD" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F12141_2", "Index on DTOBJ, DTSUB", new[] { "DTOBJ", "DTSUB" }),
        new JdeIndex("F12141_3", "Index on DTCO, DTLT, DTMCU, DTOBJ, DTSUB", new[] { "DTCO", "DTLT", "DTMCU", "DTOBJ", "DTSUB" })
    };
}
