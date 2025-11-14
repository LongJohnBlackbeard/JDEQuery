using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F41509 - .
/// </summary>
public class F41509 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PGDOCO.
        /// </summary>
        public const string PGDOCO = "PGDOCO";

        /// <summary>
        /// PGDCTO.
        /// </summary>
        public const string PGDCTO = "PGDCTO";

        /// <summary>
        /// PGKCOO.
        /// </summary>
        public const string PGKCOO = "PGKCOO";

        /// <summary>
        /// PGLNID.
        /// </summary>
        public const string PGLNID = "PGLNID";

        /// <summary>
        /// PGFPNB.
        /// </summary>
        public const string PGFPNB = "PGFPNB";

        /// <summary>
        /// PGMCU.
        /// </summary>
        public const string PGMCU = "PGMCU";

        /// <summary>
        /// PGVAGE.
        /// </summary>
        public const string PGVAGE = "PGVAGE";

        /// <summary>
        /// PGDL01.
        /// </summary>
        public const string PGDL01 = "PGDL01";

        /// <summary>
        /// PGAN8.
        /// </summary>
        public const string PGAN8 = "PGAN8";

        /// <summary>
        /// PGCARS.
        /// </summary>
        public const string PGCARS = "PGCARS";

        /// <summary>
        /// PGVEHI.
        /// </summary>
        public const string PGVEHI = "PGVEHI";

        /// <summary>
        /// PGMOT.
        /// </summary>
        public const string PGMOT = "PGMOT";

        /// <summary>
        /// PGITM.
        /// </summary>
        public const string PGITM = "PGITM";

        /// <summary>
        /// PGBUM1.
        /// </summary>
        public const string PGBUM1 = "PGBUM1";

        /// <summary>
        /// PGBUM2.
        /// </summary>
        public const string PGBUM2 = "PGBUM2";

        /// <summary>
        /// PGBUM3.
        /// </summary>
        public const string PGBUM3 = "PGBUM3";

        /// <summary>
        /// PGAOB1.
        /// </summary>
        public const string PGAOB1 = "PGAOB1";

        /// <summary>
        /// PGAOB2.
        /// </summary>
        public const string PGAOB2 = "PGAOB2";

        /// <summary>
        /// PGAOB3.
        /// </summary>
        public const string PGAOB3 = "PGAOB3";

        /// <summary>
        /// PGLOD1.
        /// </summary>
        public const string PGLOD1 = "PGLOD1";

        /// <summary>
        /// PGLOD2.
        /// </summary>
        public const string PGLOD2 = "PGLOD2";

        /// <summary>
        /// PGLOD3.
        /// </summary>
        public const string PGLOD3 = "PGLOD3";

        /// <summary>
        /// PGSOB1.
        /// </summary>
        public const string PGSOB1 = "PGSOB1";

        /// <summary>
        /// PGSOB2.
        /// </summary>
        public const string PGSOB2 = "PGSOB2";

        /// <summary>
        /// PGSOB3.
        /// </summary>
        public const string PGSOB3 = "PGSOB3";

        /// <summary>
        /// PGEOB1.
        /// </summary>
        public const string PGEOB1 = "PGEOB1";

        /// <summary>
        /// PGEOB2.
        /// </summary>
        public const string PGEOB2 = "PGEOB2";

        /// <summary>
        /// PGEOB3.
        /// </summary>
        public const string PGEOB3 = "PGEOB3";

        /// <summary>
        /// PGDCH1.
        /// </summary>
        public const string PGDCH1 = "PGDCH1";

        /// <summary>
        /// PGDCH2.
        /// </summary>
        public const string PGDCH2 = "PGDCH2";

        /// <summary>
        /// PGDCH3.
        /// </summary>
        public const string PGDCH3 = "PGDCH3";

        /// <summary>
        /// PGROB1.
        /// </summary>
        public const string PGROB1 = "PGROB1";

        /// <summary>
        /// PGROB2.
        /// </summary>
        public const string PGROB2 = "PGROB2";

        /// <summary>
        /// PGROB3.
        /// </summary>
        public const string PGROB3 = "PGROB3";

        /// <summary>
        /// PGPGMS.
        /// </summary>
        public const string PGPGMS = "PGPGMS";

        /// <summary>
        /// PGTRDJ.
        /// </summary>
        public const string PGTRDJ = "PGTRDJ";

        /// <summary>
        /// PGLOAD.
        /// </summary>
        public const string PGLOAD = "PGLOAD";

        /// <summary>
        /// PGULDT.
        /// </summary>
        public const string PGULDT = "PGULDT";

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

        /// <summary>
        /// PGURRF.
        /// </summary>
        public const string PGURRF = "PGURRF";

        /// <summary>
        /// PGURDT.
        /// </summary>
        public const string PGURDT = "PGURDT";

        /// <summary>
        /// PGUSER.
        /// </summary>
        public const string PGUSER = "PGUSER";

        /// <summary>
        /// PGPID.
        /// </summary>
        public const string PGPID = "PGPID";

        /// <summary>
        /// PGJOBN.
        /// </summary>
        public const string PGJOBN = "PGJOBN";

        /// <summary>
        /// PGUPMJ.
        /// </summary>
        public const string PGUPMJ = "PGUPMJ";

        /// <summary>
        /// PGTDAY.
        /// </summary>
        public const string PGTDAY = "PGTDAY";

        /// <summary>
        /// PGUPFP.
        /// </summary>
        public const string PGUPFP = "PGUPFP";
    }

    /// <inheritdoc />
    public override string TableName => "F41509";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PGDOCO", "PGDOCO", JdeDataType.Numeric),
        new JdeField("PGDCTO", "PGDCTO", JdeDataType.String, 4),
        new JdeField("PGKCOO", "PGKCOO", JdeDataType.String, 10),
        new JdeField("PGLNID", "PGLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("PGFPNB", "PGFPNB", JdeDataType.Numeric, null, true, true),
        new JdeField("PGMCU", "PGMCU", JdeDataType.String, 24),
        new JdeField("PGVAGE", "PGVAGE", JdeDataType.String, 30),
        new JdeField("PGDL01", "PGDL01", JdeDataType.String, 60),
        new JdeField("PGAN8", "PGAN8", JdeDataType.Numeric),
        new JdeField("PGCARS", "PGCARS", JdeDataType.Numeric),
        new JdeField("PGVEHI", "PGVEHI", JdeDataType.String, 24),
        new JdeField("PGMOT", "PGMOT", JdeDataType.String, 6),
        new JdeField("PGITM", "PGITM", JdeDataType.Numeric),
        new JdeField("PGBUM1", "PGBUM1", JdeDataType.String, 4),
        new JdeField("PGBUM2", "PGBUM2", JdeDataType.String, 4),
        new JdeField("PGBUM3", "PGBUM3", JdeDataType.String, 4),
        new JdeField("PGAOB1", "PGAOB1", JdeDataType.Numeric),
        new JdeField("PGAOB2", "PGAOB2", JdeDataType.Numeric),
        new JdeField("PGAOB3", "PGAOB3", JdeDataType.Numeric),
        new JdeField("PGLOD1", "PGLOD1", JdeDataType.Numeric),
        new JdeField("PGLOD2", "PGLOD2", JdeDataType.Numeric),
        new JdeField("PGLOD3", "PGLOD3", JdeDataType.Numeric),
        new JdeField("PGSOB1", "PGSOB1", JdeDataType.Numeric),
        new JdeField("PGSOB2", "PGSOB2", JdeDataType.Numeric),
        new JdeField("PGSOB3", "PGSOB3", JdeDataType.Numeric),
        new JdeField("PGEOB1", "PGEOB1", JdeDataType.Numeric),
        new JdeField("PGEOB2", "PGEOB2", JdeDataType.Numeric),
        new JdeField("PGEOB3", "PGEOB3", JdeDataType.Numeric),
        new JdeField("PGDCH1", "PGDCH1", JdeDataType.Numeric),
        new JdeField("PGDCH2", "PGDCH2", JdeDataType.Numeric),
        new JdeField("PGDCH3", "PGDCH3", JdeDataType.Numeric),
        new JdeField("PGROB1", "PGROB1", JdeDataType.Numeric),
        new JdeField("PGROB2", "PGROB2", JdeDataType.Numeric),
        new JdeField("PGROB3", "PGROB3", JdeDataType.Numeric),
        new JdeField("PGPGMS", "PGPGMS", JdeDataType.String, 2),
        new JdeField("PGTRDJ", "PGTRDJ", JdeDataType.Numeric),
        new JdeField("PGLOAD", "PGLOAD", JdeDataType.Numeric),
        new JdeField("PGULDT", "PGULDT", JdeDataType.Numeric),
        new JdeField("PGURCD", "PGURCD", JdeDataType.String, 4),
        new JdeField("PGURAT", "PGURAT", JdeDataType.Numeric),
        new JdeField("PGURAB", "PGURAB", JdeDataType.Numeric),
        new JdeField("PGURRF", "PGURRF", JdeDataType.String, 30),
        new JdeField("PGURDT", "PGURDT", JdeDataType.Numeric),
        new JdeField("PGUSER", "PGUSER", JdeDataType.String, 20),
        new JdeField("PGPID", "PGPID", JdeDataType.String, 20),
        new JdeField("PGJOBN", "PGJOBN", JdeDataType.String, 20),
        new JdeField("PGUPMJ", "PGUPMJ", JdeDataType.Numeric),
        new JdeField("PGTDAY", "PGTDAY", JdeDataType.Numeric),
        new JdeField("PGUPFP", "PGUPFP", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F41509_0", "Primary Key on PGFPNB, PGLNID", new[] { "PGFPNB", "PGLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F41509_2", "Index on PGDOCO, PGDCTO, PGLNID", new[] { "PGDOCO", "PGDCTO", "PGLNID" })
    };
}
