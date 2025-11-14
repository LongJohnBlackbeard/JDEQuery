using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F48S84 - .
/// </summary>
public class F48S84 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PGBPGC.
        /// </summary>
        public const string PGBPGC = "PGBPGC";

        /// <summary>
        /// PGEFTB.
        /// </summary>
        public const string PGEFTB = "PGEFTB";

        /// <summary>
        /// PGBUCA.
        /// </summary>
        public const string PGBUCA = "PGBUCA";

        /// <summary>
        /// PGSEGMID.
        /// </summary>
        public const string PGSEGMID = "PGSEGMID";

        /// <summary>
        /// PGPOOLID.
        /// </summary>
        public const string PGPOOLID = "PGPOOLID";

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
        /// PGUPMT.
        /// </summary>
        public const string PGUPMT = "PGUPMT";

        /// <summary>
        /// PGEFTE.
        /// </summary>
        public const string PGEFTE = "PGEFTE";
    }

    /// <inheritdoc />
    public override string TableName => "F48S84";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PGBPGC", "PGBPGC", JdeDataType.String, 6, true, true),
        new JdeField("PGEFTB", "PGEFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("PGBUCA", "PGBUCA", JdeDataType.String, 10, true, true),
        new JdeField("PGSEGMID", "PGSEGMID", JdeDataType.String, 6),
        new JdeField("PGPOOLID", "PGPOOLID", JdeDataType.String, 8),
        new JdeField("PGUSER", "PGUSER", JdeDataType.String, 20),
        new JdeField("PGPID", "PGPID", JdeDataType.String, 20),
        new JdeField("PGJOBN", "PGJOBN", JdeDataType.String, 20),
        new JdeField("PGUPMJ", "PGUPMJ", JdeDataType.Numeric),
        new JdeField("PGUPMT", "PGUPMT", JdeDataType.Numeric),
        new JdeField("PGEFTE", "PGEFTE", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F48S84_0", "Primary Key on PGBPGC, PGEFTB, PGBUCA", new[] { "PGBPGC", "PGEFTB", "PGBUCA" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F48S84_2", "Index on PGSEGMID, PGEFTB", new[] { "PGSEGMID", "PGEFTB" }),
        new JdeIndex("F48S84_3", "Index on PGBPGC, SYS_NC00012$, PGBUCA", new[] { "PGBPGC", "SYS_NC00012$", "PGBUCA" })
    };
}
