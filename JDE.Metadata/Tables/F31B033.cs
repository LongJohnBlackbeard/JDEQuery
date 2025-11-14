using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B033 - .
/// </summary>
public class F31B033 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BSBARSEG1.
        /// </summary>
        public const string BSBARSEG1 = "BSBARSEG1";

        /// <summary>
        /// BSBARSEG2.
        /// </summary>
        public const string BSBARSEG2 = "BSBARSEG2";

        /// <summary>
        /// BSBARSEG3.
        /// </summary>
        public const string BSBARSEG3 = "BSBARSEG3";

        /// <summary>
        /// BSURCD.
        /// </summary>
        public const string BSURCD = "BSURCD";

        /// <summary>
        /// BSURDT.
        /// </summary>
        public const string BSURDT = "BSURDT";

        /// <summary>
        /// BSURAT.
        /// </summary>
        public const string BSURAT = "BSURAT";

        /// <summary>
        /// BSURRF.
        /// </summary>
        public const string BSURRF = "BSURRF";

        /// <summary>
        /// BSURAB.
        /// </summary>
        public const string BSURAB = "BSURAB";

        /// <summary>
        /// BSWMDT.
        /// </summary>
        public const string BSWMDT = "BSWMDT";

        /// <summary>
        /// BSWNUM.
        /// </summary>
        public const string BSWNUM = "BSWNUM";

        /// <summary>
        /// BSWAB.
        /// </summary>
        public const string BSWAB = "BSWAB";

        /// <summary>
        /// BSWCD.
        /// </summary>
        public const string BSWCD = "BSWCD";

        /// <summary>
        /// BSWRF.
        /// </summary>
        public const string BSWRF = "BSWRF";

        /// <summary>
        /// BSUSER.
        /// </summary>
        public const string BSUSER = "BSUSER";

        /// <summary>
        /// BSPID.
        /// </summary>
        public const string BSPID = "BSPID";

        /// <summary>
        /// BSJOBN.
        /// </summary>
        public const string BSJOBN = "BSJOBN";

        /// <summary>
        /// BSUPMJ.
        /// </summary>
        public const string BSUPMJ = "BSUPMJ";

        /// <summary>
        /// BSUPMT.
        /// </summary>
        public const string BSUPMT = "BSUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F31B033";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BSBARSEG1", "BSBARSEG1", JdeDataType.String, 20, true, true),
        new JdeField("BSBARSEG2", "BSBARSEG2", JdeDataType.String, 8, true, true),
        new JdeField("BSBARSEG3", "BSBARSEG3", JdeDataType.Numeric),
        new JdeField("BSURCD", "BSURCD", JdeDataType.String, 4),
        new JdeField("BSURDT", "BSURDT", JdeDataType.Numeric),
        new JdeField("BSURAT", "BSURAT", JdeDataType.Numeric),
        new JdeField("BSURRF", "BSURRF", JdeDataType.String, 30),
        new JdeField("BSURAB", "BSURAB", JdeDataType.Numeric),
        new JdeField("BSWMDT", "BSWMDT", JdeDataType.Numeric),
        new JdeField("BSWNUM", "BSWNUM", JdeDataType.Numeric),
        new JdeField("BSWAB", "BSWAB", JdeDataType.Numeric),
        new JdeField("BSWCD", "BSWCD", JdeDataType.String, 6),
        new JdeField("BSWRF", "BSWRF", JdeDataType.String, 60),
        new JdeField("BSUSER", "BSUSER", JdeDataType.String, 20),
        new JdeField("BSPID", "BSPID", JdeDataType.String, 20),
        new JdeField("BSJOBN", "BSJOBN", JdeDataType.String, 20),
        new JdeField("BSUPMJ", "BSUPMJ", JdeDataType.Numeric),
        new JdeField("BSUPMT", "BSUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B033_0", "Primary Key on BSBARSEG1, BSBARSEG2", new[] { "BSBARSEG1", "BSBARSEG2" }, isUnique: true, isPrimaryKey: true)
    };
}
