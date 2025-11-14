using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F15L302 - .
/// </summary>
public class F15L302 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PGCTID.
        /// </summary>
        public const string PGCTID = "PGCTID";

        /// <summary>
        /// PGMCU.
        /// </summary>
        public const string PGMCU = "PGMCU";

        /// <summary>
        /// PGRVNB.
        /// </summary>
        public const string PGRVNB = "PGRVNB";

        /// <summary>
        /// PGDOCO.
        /// </summary>
        public const string PGDOCO = "PGDOCO";

        /// <summary>
        /// PGUNIT.
        /// </summary>
        public const string PGUNIT = "PGUNIT";

        /// <summary>
        /// PGLNID.
        /// </summary>
        public const string PGLNID = "PGLNID";

        /// <summary>
        /// PGLSVR.
        /// </summary>
        public const string PGLSVR = "PGLSVR";

        /// <summary>
        /// PGBCI.
        /// </summary>
        public const string PGBCI = "PGBCI";

        /// <summary>
        /// PGSOTY.
        /// </summary>
        public const string PGSOTY = "PGSOTY";

        /// <summary>
        /// PGBPN.
        /// </summary>
        public const string PGBPN = "PGBPN";

        /// <summary>
        /// PGYR.
        /// </summary>
        public const string PGYR = "PGYR";

        /// <summary>
        /// PGCTRY.
        /// </summary>
        public const string PGCTRY = "PGCTRY";

        /// <summary>
        /// PGPRDC.
        /// </summary>
        public const string PGPRDC = "PGPRDC";

        /// <summary>
        /// PGDBAN.
        /// </summary>
        public const string PGDBAN = "PGDBAN";

        /// <summary>
        /// PGGLC.
        /// </summary>
        public const string PGGLC = "PGGLC";

        /// <summary>
        /// PGSOBT.
        /// </summary>
        public const string PGSOBT = "PGSOBT";

        /// <summary>
        /// PGDSV.
        /// </summary>
        public const string PGDSV = "PGDSV";

        /// <summary>
        /// PGAG.
        /// </summary>
        public const string PGAG = "PGAG";

        /// <summary>
        /// PGMCUS.
        /// </summary>
        public const string PGMCUS = "PGMCUS";

        /// <summary>
        /// PGUSER.
        /// </summary>
        public const string PGUSER = "PGUSER";

        /// <summary>
        /// PGPID.
        /// </summary>
        public const string PGPID = "PGPID";

        /// <summary>
        /// PGUPMJ.
        /// </summary>
        public const string PGUPMJ = "PGUPMJ";

        /// <summary>
        /// PGUPMT.
        /// </summary>
        public const string PGUPMT = "PGUPMT";

        /// <summary>
        /// PGJOBN.
        /// </summary>
        public const string PGJOBN = "PGJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F15L302";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PGCTID", "PGCTID", JdeDataType.String, 30, true, true),
        new JdeField("PGMCU", "PGMCU", JdeDataType.String, 24, true, true),
        new JdeField("PGRVNB", "PGRVNB", JdeDataType.Numeric, null, true, true),
        new JdeField("PGDOCO", "PGDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("PGUNIT", "PGUNIT", JdeDataType.String, 16, true, true),
        new JdeField("PGLNID", "PGLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("PGLSVR", "PGLSVR", JdeDataType.Numeric),
        new JdeField("PGBCI", "PGBCI", JdeDataType.Numeric),
        new JdeField("PGSOTY", "PGSOTY", JdeDataType.String, 4),
        new JdeField("PGBPN", "PGBPN", JdeDataType.Numeric),
        new JdeField("PGYR", "PGYR", JdeDataType.Numeric),
        new JdeField("PGCTRY", "PGCTRY", JdeDataType.Numeric),
        new JdeField("PGPRDC", "PGPRDC", JdeDataType.String, 8),
        new JdeField("PGDBAN", "PGDBAN", JdeDataType.Numeric),
        new JdeField("PGGLC", "PGGLC", JdeDataType.String, 8),
        new JdeField("PGSOBT", "PGSOBT", JdeDataType.String, 4),
        new JdeField("PGDSV", "PGDSV", JdeDataType.Numeric),
        new JdeField("PGAG", "PGAG", JdeDataType.Numeric),
        new JdeField("PGMCUS", "PGMCUS", JdeDataType.String, 24),
        new JdeField("PGUSER", "PGUSER", JdeDataType.String, 20),
        new JdeField("PGPID", "PGPID", JdeDataType.String, 20),
        new JdeField("PGUPMJ", "PGUPMJ", JdeDataType.Numeric),
        new JdeField("PGUPMT", "PGUPMT", JdeDataType.Numeric),
        new JdeField("PGJOBN", "PGJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F15L302_0", "Primary Key on PGCTID, PGMCU, PGRVNB, PGDOCO, PGUNIT, PGLNID", new[] { "PGCTID", "PGMCU", "PGRVNB", "PGDOCO", "PGUNIT", "PGLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F15L302_2", "Index on PGMCU, PGRVNB, PGUNIT, PGPRDC, PGCTRY, PGYR, PGBPN", new[] { "PGMCU", "PGRVNB", "PGUNIT", "PGPRDC", "PGCTRY", "PGYR", "PGBPN" }),
        new JdeIndex("F15L302_3", "Index on PGCTID, PGMCU, PGRVNB, PGDOCO, PGUNIT, SYS_NC00025$", new[] { "PGCTID", "PGMCU", "PGRVNB", "PGDOCO", "PGUNIT", "SYS_NC00025$" })
    };
}
