using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4277750 - .
/// </summary>
public class F4277750 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BSORDTYP.
        /// </summary>
        public const string BSORDTYP = "BSORDTYP";

        /// <summary>
        /// BSLINTYP.
        /// </summary>
        public const string BSLINTYP = "BSLINTYP";

        /// <summary>
        /// BSCUSPRI.
        /// </summary>
        public const string BSCUSPRI = "BSCUSPRI";

        /// <summary>
        /// BSRQDTAG.
        /// </summary>
        public const string BSRQDTAG = "BSRQDTAG";

        /// <summary>
        /// BSCUFNPR.
        /// </summary>
        public const string BSCUFNPR = "BSCUFNPR";

        /// <summary>
        /// BSOSCORE.
        /// </summary>
        public const string BSOSCORE = "BSOSCORE";

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
        /// BSURAB.
        /// </summary>
        public const string BSURAB = "BSURAB";

        /// <summary>
        /// BSURRF.
        /// </summary>
        public const string BSURRF = "BSURRF";

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
        /// BSTDAY.
        /// </summary>
        public const string BSTDAY = "BSTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F4277750";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BSORDTYP", "BSORDTYP", JdeDataType.String, 4, true, true),
        new JdeField("BSLINTYP", "BSLINTYP", JdeDataType.String, 4, true, true),
        new JdeField("BSCUSPRI", "BSCUSPRI", JdeDataType.Numeric, null, true, true),
        new JdeField("BSRQDTAG", "BSRQDTAG", JdeDataType.Numeric, null, true, true),
        new JdeField("BSCUFNPR", "BSCUFNPR", JdeDataType.Numeric, null, true, true),
        new JdeField("BSOSCORE", "BSOSCORE", JdeDataType.Numeric),
        new JdeField("BSURCD", "BSURCD", JdeDataType.String, 4),
        new JdeField("BSURDT", "BSURDT", JdeDataType.Numeric),
        new JdeField("BSURAT", "BSURAT", JdeDataType.Numeric),
        new JdeField("BSURAB", "BSURAB", JdeDataType.Numeric),
        new JdeField("BSURRF", "BSURRF", JdeDataType.String, 30),
        new JdeField("BSUSER", "BSUSER", JdeDataType.String, 20),
        new JdeField("BSPID", "BSPID", JdeDataType.String, 20),
        new JdeField("BSJOBN", "BSJOBN", JdeDataType.String, 20),
        new JdeField("BSUPMJ", "BSUPMJ", JdeDataType.Numeric),
        new JdeField("BSTDAY", "BSTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4277750_0", "Primary Key on BSORDTYP, BSLINTYP, BSCUSPRI, BSRQDTAG, BSCUFNPR", new[] { "BSORDTYP", "BSLINTYP", "BSCUSPRI", "BSRQDTAG", "BSCUFNPR" }, isUnique: true, isPrimaryKey: true)
    };
}
