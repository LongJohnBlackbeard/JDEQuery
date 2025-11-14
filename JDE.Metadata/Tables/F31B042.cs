using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B042 - .
/// </summary>
public class F31B042 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MTMATYP.
        /// </summary>
        public const string MTMATYP = "MTMATYP";

        /// <summary>
        /// MTMATYP2.
        /// </summary>
        public const string MTMATYP2 = "MTMATYP2";

        /// <summary>
        /// MTMATYPR.
        /// </summary>
        public const string MTMATYPR = "MTMATYPR";

        /// <summary>
        /// MTURCD.
        /// </summary>
        public const string MTURCD = "MTURCD";

        /// <summary>
        /// MTURDT.
        /// </summary>
        public const string MTURDT = "MTURDT";

        /// <summary>
        /// MTURAT.
        /// </summary>
        public const string MTURAT = "MTURAT";

        /// <summary>
        /// MTURRF.
        /// </summary>
        public const string MTURRF = "MTURRF";

        /// <summary>
        /// MTURAB.
        /// </summary>
        public const string MTURAB = "MTURAB";

        /// <summary>
        /// MTUPMT.
        /// </summary>
        public const string MTUPMT = "MTUPMT";

        /// <summary>
        /// MTUPMJ.
        /// </summary>
        public const string MTUPMJ = "MTUPMJ";

        /// <summary>
        /// MTMKEY.
        /// </summary>
        public const string MTMKEY = "MTMKEY";

        /// <summary>
        /// MTPID.
        /// </summary>
        public const string MTPID = "MTPID";
    }

    /// <inheritdoc />
    public override string TableName => "F31B042";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MTMATYP", "MTMATYP", JdeDataType.String, 8, true, true),
        new JdeField("MTMATYP2", "MTMATYP2", JdeDataType.String, 8, true, true),
        new JdeField("MTMATYPR", "MTMATYPR", JdeDataType.String, 8),
        new JdeField("MTURCD", "MTURCD", JdeDataType.String, 4),
        new JdeField("MTURDT", "MTURDT", JdeDataType.Numeric),
        new JdeField("MTURAT", "MTURAT", JdeDataType.Numeric),
        new JdeField("MTURRF", "MTURRF", JdeDataType.String, 30),
        new JdeField("MTURAB", "MTURAB", JdeDataType.Numeric),
        new JdeField("MTUPMT", "MTUPMT", JdeDataType.Numeric),
        new JdeField("MTUPMJ", "MTUPMJ", JdeDataType.Numeric),
        new JdeField("MTMKEY", "MTMKEY", JdeDataType.String, 30),
        new JdeField("MTPID", "MTPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B042_0", "Primary Key on MTMATYP, MTMATYP2", new[] { "MTMATYP", "MTMATYP2" }, isUnique: true, isPrimaryKey: true)
    };
}
