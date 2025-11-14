using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40305R - .
/// </summary>
public class F40305R : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RMUKID.
        /// </summary>
        public const string RMUKID = "RMUKID";

        /// <summary>
        /// RMREFC.
        /// </summary>
        public const string RMREFC = "RMREFC";

        /// <summary>
        /// RMAN8.
        /// </summary>
        public const string RMAN8 = "RMAN8";

        /// <summary>
        /// RMCS05.
        /// </summary>
        public const string RMCS05 = "RMCS05";

        /// <summary>
        /// RMITM.
        /// </summary>
        public const string RMITM = "RMITM";

        /// <summary>
        /// RMIT05.
        /// </summary>
        public const string RMIT05 = "RMIT05";

        /// <summary>
        /// RMEFTJ.
        /// </summary>
        public const string RMEFTJ = "RMEFTJ";

        /// <summary>
        /// RMEXDJ.
        /// </summary>
        public const string RMEXDJ = "RMEXDJ";

        /// <summary>
        /// RMMNQ.
        /// </summary>
        public const string RMMNQ = "RMMNQ";

        /// <summary>
        /// RMMXQ.
        /// </summary>
        public const string RMMXQ = "RMMXQ";

        /// <summary>
        /// RMUOM.
        /// </summary>
        public const string RMUOM = "RMUOM";

        /// <summary>
        /// RMTXID.
        /// </summary>
        public const string RMTXID = "RMTXID";

        /// <summary>
        /// RMSTPR.
        /// </summary>
        public const string RMSTPR = "RMSTPR";

        /// <summary>
        /// RMOSEQ.
        /// </summary>
        public const string RMOSEQ = "RMOSEQ";

        /// <summary>
        /// RMMCU.
        /// </summary>
        public const string RMMCU = "RMMCU";

        /// <summary>
        /// RMINMG.
        /// </summary>
        public const string RMINMG = "RMINMG";

        /// <summary>
        /// RMURCD.
        /// </summary>
        public const string RMURCD = "RMURCD";

        /// <summary>
        /// RMURDT.
        /// </summary>
        public const string RMURDT = "RMURDT";

        /// <summary>
        /// RMURAT.
        /// </summary>
        public const string RMURAT = "RMURAT";

        /// <summary>
        /// RMURAB.
        /// </summary>
        public const string RMURAB = "RMURAB";

        /// <summary>
        /// RMURRF.
        /// </summary>
        public const string RMURRF = "RMURRF";

        /// <summary>
        /// RMUSER.
        /// </summary>
        public const string RMUSER = "RMUSER";

        /// <summary>
        /// RMPID.
        /// </summary>
        public const string RMPID = "RMPID";

        /// <summary>
        /// RMJOBN.
        /// </summary>
        public const string RMJOBN = "RMJOBN";

        /// <summary>
        /// RMUPMJ.
        /// </summary>
        public const string RMUPMJ = "RMUPMJ";

        /// <summary>
        /// RMTDAY.
        /// </summary>
        public const string RMTDAY = "RMTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F40305R";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RMUKID", "RMUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("RMREFC", "RMREFC", JdeDataType.Numeric),
        new JdeField("RMAN8", "RMAN8", JdeDataType.Numeric),
        new JdeField("RMCS05", "RMCS05", JdeDataType.String, 16),
        new JdeField("RMITM", "RMITM", JdeDataType.Numeric),
        new JdeField("RMIT05", "RMIT05", JdeDataType.String, 16),
        new JdeField("RMEFTJ", "RMEFTJ", JdeDataType.Numeric),
        new JdeField("RMEXDJ", "RMEXDJ", JdeDataType.Numeric),
        new JdeField("RMMNQ", "RMMNQ", JdeDataType.Numeric),
        new JdeField("RMMXQ", "RMMXQ", JdeDataType.Numeric),
        new JdeField("RMUOM", "RMUOM", JdeDataType.String, 4),
        new JdeField("RMTXID", "RMTXID", JdeDataType.Numeric),
        new JdeField("RMSTPR", "RMSTPR", JdeDataType.String, 2),
        new JdeField("RMOSEQ", "RMOSEQ", JdeDataType.Numeric),
        new JdeField("RMMCU", "RMMCU", JdeDataType.String, 24),
        new JdeField("RMINMG", "RMINMG", JdeDataType.String, 20),
        new JdeField("RMURCD", "RMURCD", JdeDataType.String, 4),
        new JdeField("RMURDT", "RMURDT", JdeDataType.Numeric),
        new JdeField("RMURAT", "RMURAT", JdeDataType.Numeric),
        new JdeField("RMURAB", "RMURAB", JdeDataType.Numeric),
        new JdeField("RMURRF", "RMURRF", JdeDataType.String, 30),
        new JdeField("RMUSER", "RMUSER", JdeDataType.String, 20),
        new JdeField("RMPID", "RMPID", JdeDataType.String, 20),
        new JdeField("RMJOBN", "RMJOBN", JdeDataType.String, 20),
        new JdeField("RMUPMJ", "RMUPMJ", JdeDataType.Numeric),
        new JdeField("RMTDAY", "RMTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40305R_0", "Primary Key on RMUKID", new[] { "RMUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F40305R_2", "Index on RMAN8, RMCS05, RMITM, RMIT05, RMEXDJ, RMMXQ, RMUOM, RMINMG, RMUPMJ, RMTDAY", new[] { "RMAN8", "RMCS05", "RMITM", "RMIT05", "RMEXDJ", "RMMXQ", "RMUOM", "RMINMG", "RMUPMJ", "RMTDAY" })
    };
}
