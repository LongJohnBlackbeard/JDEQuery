using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F415091 - .
/// </summary>
public class F415091 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PGFPNB.
        /// </summary>
        public const string PGFPNB = "PGFPNB";

        /// <summary>
        /// PGDOCO.
        /// </summary>
        public const string PGDOCO = "PGDOCO";

        /// <summary>
        /// PGDCTO.
        /// </summary>
        public const string PGDCTO = "PGDCTO";

        /// <summary>
        /// PGLNID.
        /// </summary>
        public const string PGLNID = "PGLNID";

        /// <summary>
        /// PGDTAI.
        /// </summary>
        public const string PGDTAI = "PGDTAI";

        /// <summary>
        /// PGTEMP.
        /// </summary>
        public const string PGTEMP = "PGTEMP";

        /// <summary>
        /// PGSTPU.
        /// </summary>
        public const string PGSTPU = "PGSTPU";

        /// <summary>
        /// PGDNTY.
        /// </summary>
        public const string PGDNTY = "PGDNTY";

        /// <summary>
        /// PGDNTP.
        /// </summary>
        public const string PGDNTP = "PGDNTP";

        /// <summary>
        /// PGDETP.
        /// </summary>
        public const string PGDETP = "PGDETP";

        /// <summary>
        /// PGDTPU.
        /// </summary>
        public const string PGDTPU = "PGDTPU";

        /// <summary>
        /// PGUSER.
        /// </summary>
        public const string PGUSER = "PGUSER";

        /// <summary>
        /// PGUPMJ.
        /// </summary>
        public const string PGUPMJ = "PGUPMJ";

        /// <summary>
        /// PGURRF.
        /// </summary>
        public const string PGURRF = "PGURRF";

        /// <summary>
        /// PGURDT.
        /// </summary>
        public const string PGURDT = "PGURDT";

        /// <summary>
        /// PGURCD.
        /// </summary>
        public const string PGURCD = "PGURCD";

        /// <summary>
        /// PGURAT.
        /// </summary>
        public const string PGURAT = "PGURAT";

        /// <summary>
        /// PGURAB.
        /// </summary>
        public const string PGURAB = "PGURAB";
    }

    /// <inheritdoc />
    public override string TableName => "F415091";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PGFPNB", "PGFPNB", JdeDataType.Numeric, null, true, true),
        new JdeField("PGDOCO", "PGDOCO", JdeDataType.Numeric),
        new JdeField("PGDCTO", "PGDCTO", JdeDataType.String, 4),
        new JdeField("PGLNID", "PGLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("PGDTAI", "PGDTAI", JdeDataType.String, 20, true, true),
        new JdeField("PGTEMP", "PGTEMP", JdeDataType.Numeric),
        new JdeField("PGSTPU", "PGSTPU", JdeDataType.String, 2),
        new JdeField("PGDNTY", "PGDNTY", JdeDataType.Numeric),
        new JdeField("PGDNTP", "PGDNTP", JdeDataType.String, 2),
        new JdeField("PGDETP", "PGDETP", JdeDataType.Numeric),
        new JdeField("PGDTPU", "PGDTPU", JdeDataType.String, 2),
        new JdeField("PGUSER", "PGUSER", JdeDataType.String, 20),
        new JdeField("PGUPMJ", "PGUPMJ", JdeDataType.Numeric),
        new JdeField("PGURRF", "PGURRF", JdeDataType.String, 30),
        new JdeField("PGURDT", "PGURDT", JdeDataType.Numeric),
        new JdeField("PGURCD", "PGURCD", JdeDataType.String, 4),
        new JdeField("PGURAT", "PGURAT", JdeDataType.Numeric),
        new JdeField("PGURAB", "PGURAB", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F415091_0", "Primary Key on PGFPNB, PGLNID, PGDTAI", new[] { "PGFPNB", "PGLNID", "PGDTAI" }, isUnique: true, isPrimaryKey: true)
    };
}
