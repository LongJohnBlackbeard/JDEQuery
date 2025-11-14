using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F05401 - .
/// </summary>
public class F05401 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DTEECD.
        /// </summary>
        public const string DTEECD = "DTEECD";

        /// <summary>
        /// DTCO.
        /// </summary>
        public const string DTCO = "DTCO";

        /// <summary>
        /// DTCCPR.
        /// </summary>
        public const string DTCCPR = "DTCCPR";

        /// <summary>
        /// DTUKID.
        /// </summary>
        public const string DTUKID = "DTUKID";

        /// <summary>
        /// DTLNGP.
        /// </summary>
        public const string DTLNGP = "DTLNGP";

        /// <summary>
        /// DTUSER.
        /// </summary>
        public const string DTUSER = "DTUSER";

        /// <summary>
        /// DTPID.
        /// </summary>
        public const string DTPID = "DTPID";

        /// <summary>
        /// DTJOBN.
        /// </summary>
        public const string DTJOBN = "DTJOBN";

        /// <summary>
        /// DTUPMJ.
        /// </summary>
        public const string DTUPMJ = "DTUPMJ";

        /// <summary>
        /// DTUPMT.
        /// </summary>
        public const string DTUPMT = "DTUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F05401";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DTEECD", "DTEECD", JdeDataType.String, 6, true, true),
        new JdeField("DTCO", "DTCO", JdeDataType.String, 10, true, true),
        new JdeField("DTCCPR", "DTCCPR", JdeDataType.String, 6, true, true),
        new JdeField("DTUKID", "DTUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("DTLNGP", "DTLNGP", JdeDataType.String, 4, true, true),
        new JdeField("DTUSER", "DTUSER", JdeDataType.String, 20),
        new JdeField("DTPID", "DTPID", JdeDataType.String, 20),
        new JdeField("DTJOBN", "DTJOBN", JdeDataType.String, 20),
        new JdeField("DTUPMJ", "DTUPMJ", JdeDataType.Numeric),
        new JdeField("DTUPMT", "DTUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F05401_0", "Primary Key on DTEECD, DTCO, DTCCPR, DTUKID, DTLNGP", new[] { "DTEECD", "DTCO", "DTCCPR", "DTUKID", "DTLNGP" }, isUnique: true, isPrimaryKey: true)
    };
}
