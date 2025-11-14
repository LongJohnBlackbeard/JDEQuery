using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0450 - .
/// </summary>
public class F0450 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PCUKID.
        /// </summary>
        public const string PCUKID = "PCUKID";

        /// <summary>
        /// PCPYE.
        /// </summary>
        public const string PCPYE = "PCPYE";

        /// <summary>
        /// PCDTAI.
        /// </summary>
        public const string PCDTAI = "PCDTAI";

        /// <summary>
        /// PCPDV.
        /// </summary>
        public const string PCPDV = "PCPDV";

        /// <summary>
        /// PCRDV.
        /// </summary>
        public const string PCRDV = "PCRDV";

        /// <summary>
        /// PCAN8.
        /// </summary>
        public const string PCAN8 = "PCAN8";

        /// <summary>
        /// PCKCO.
        /// </summary>
        public const string PCKCO = "PCKCO";

        /// <summary>
        /// PCDCT.
        /// </summary>
        public const string PCDCT = "PCDCT";

        /// <summary>
        /// PCDOC.
        /// </summary>
        public const string PCDOC = "PCDOC";

        /// <summary>
        /// PCSFX.
        /// </summary>
        public const string PCSFX = "PCSFX";

        /// <summary>
        /// PCUSER.
        /// </summary>
        public const string PCUSER = "PCUSER";

        /// <summary>
        /// PCPID.
        /// </summary>
        public const string PCPID = "PCPID";

        /// <summary>
        /// PCJOBN.
        /// </summary>
        public const string PCJOBN = "PCJOBN";

        /// <summary>
        /// PCUPMJ.
        /// </summary>
        public const string PCUPMJ = "PCUPMJ";

        /// <summary>
        /// PCUPMT.
        /// </summary>
        public const string PCUPMT = "PCUPMT";

        /// <summary>
        /// PCATIM.
        /// </summary>
        public const string PCATIM = "PCATIM";

        /// <summary>
        /// PCADAT.
        /// </summary>
        public const string PCADAT = "PCADAT";

        /// <summary>
        /// PCUSAP.
        /// </summary>
        public const string PCUSAP = "PCUSAP";
    }

    /// <inheritdoc />
    public override string TableName => "F0450";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PCUKID", "PCUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("PCPYE", "PCPYE", JdeDataType.Numeric),
        new JdeField("PCDTAI", "PCDTAI", JdeDataType.String, 20),
        new JdeField("PCPDV", "PCPDV", JdeDataType.String, 80),
        new JdeField("PCRDV", "PCRDV", JdeDataType.String, 80),
        new JdeField("PCAN8", "PCAN8", JdeDataType.Numeric),
        new JdeField("PCKCO", "PCKCO", JdeDataType.String, 10),
        new JdeField("PCDCT", "PCDCT", JdeDataType.String, 4),
        new JdeField("PCDOC", "PCDOC", JdeDataType.Numeric),
        new JdeField("PCSFX", "PCSFX", JdeDataType.String, 6),
        new JdeField("PCUSER", "PCUSER", JdeDataType.String, 20),
        new JdeField("PCPID", "PCPID", JdeDataType.String, 20),
        new JdeField("PCJOBN", "PCJOBN", JdeDataType.String, 20),
        new JdeField("PCUPMJ", "PCUPMJ", JdeDataType.Numeric),
        new JdeField("PCUPMT", "PCUPMT", JdeDataType.Numeric),
        new JdeField("PCATIM", "PCATIM", JdeDataType.Numeric),
        new JdeField("PCADAT", "PCADAT", JdeDataType.Numeric),
        new JdeField("PCUSAP", "PCUSAP", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0450_0", "Primary Key on PCUKID", new[] { "PCUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0450_2", "Index on PCPYE, PCDTAI", new[] { "PCPYE", "PCDTAI" })
    };
}
