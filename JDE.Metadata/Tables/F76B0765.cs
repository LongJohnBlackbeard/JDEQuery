using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B0765 - .
/// </summary>
public class F76B0765 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CTITM.
        /// </summary>
        public const string CTITM = "CTITM";

        /// <summary>
        /// CTEFFF.
        /// </summary>
        public const string CTEFFF = "CTEFFF";

        /// <summary>
        /// CTUPMT.
        /// </summary>
        public const string CTUPMT = "CTUPMT";

        /// <summary>
        /// CTDSC1.
        /// </summary>
        public const string CTDSC1 = "CTDSC1";

        /// <summary>
        /// CTURCD.
        /// </summary>
        public const string CTURCD = "CTURCD";

        /// <summary>
        /// CTURDT.
        /// </summary>
        public const string CTURDT = "CTURDT";

        /// <summary>
        /// CTURAT.
        /// </summary>
        public const string CTURAT = "CTURAT";

        /// <summary>
        /// CTURAB.
        /// </summary>
        public const string CTURAB = "CTURAB";

        /// <summary>
        /// CTURRF.
        /// </summary>
        public const string CTURRF = "CTURRF";

        /// <summary>
        /// CTUSER.
        /// </summary>
        public const string CTUSER = "CTUSER";

        /// <summary>
        /// CTPID.
        /// </summary>
        public const string CTPID = "CTPID";

        /// <summary>
        /// CTJOBN.
        /// </summary>
        public const string CTJOBN = "CTJOBN";

        /// <summary>
        /// CTUPMJ.
        /// </summary>
        public const string CTUPMJ = "CTUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F76B0765";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CTITM", "CTITM", JdeDataType.Numeric, null, true, true),
        new JdeField("CTEFFF", "CTEFFF", JdeDataType.Numeric, null, true, true),
        new JdeField("CTUPMT", "CTUPMT", JdeDataType.Numeric, null, true, true),
        new JdeField("CTDSC1", "CTDSC1", JdeDataType.String, 60),
        new JdeField("CTURCD", "CTURCD", JdeDataType.String, 4),
        new JdeField("CTURDT", "CTURDT", JdeDataType.Numeric),
        new JdeField("CTURAT", "CTURAT", JdeDataType.Numeric),
        new JdeField("CTURAB", "CTURAB", JdeDataType.Numeric),
        new JdeField("CTURRF", "CTURRF", JdeDataType.String, 30),
        new JdeField("CTUSER", "CTUSER", JdeDataType.String, 20),
        new JdeField("CTPID", "CTPID", JdeDataType.String, 20),
        new JdeField("CTJOBN", "CTJOBN", JdeDataType.String, 20),
        new JdeField("CTUPMJ", "CTUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B0765_0", "Primary Key on CTITM, CTEFFF, CTUPMT", new[] { "CTITM", "CTEFFF", "CTUPMT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76B0765_2", "Index on CTITM, SYS_NC00014$, SYS_NC00015$", new[] { "CTITM", "SYS_NC00014$", "SYS_NC00015$" })
    };
}
