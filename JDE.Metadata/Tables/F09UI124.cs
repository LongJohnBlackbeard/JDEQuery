using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09UI124 - .
/// </summary>
public class F09UI124 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PGJOBS.
        /// </summary>
        public const string PGJOBS = "PGJOBS";

        /// <summary>
        /// PGUKID.
        /// </summary>
        public const string PGUKID = "PGUKID";

        /// <summary>
        /// PGRTAL.
        /// </summary>
        public const string PGRTAL = "PGRTAL";

        /// <summary>
        /// PGBPGC.
        /// </summary>
        public const string PGBPGC = "PGBPGC";

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
    }

    /// <inheritdoc />
    public override string TableName => "F09UI124";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PGJOBS", "PGJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("PGUKID", "PGUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("PGRTAL", "PGRTAL", JdeDataType.String, 2, true, true),
        new JdeField("PGBPGC", "PGBPGC", JdeDataType.String, 6, true, true),
        new JdeField("PGUSER", "PGUSER", JdeDataType.String, 20),
        new JdeField("PGPID", "PGPID", JdeDataType.String, 20),
        new JdeField("PGJOBN", "PGJOBN", JdeDataType.String, 20),
        new JdeField("PGUPMJ", "PGUPMJ", JdeDataType.Numeric),
        new JdeField("PGUPMT", "PGUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09UI124_0", "Primary Key on PGJOBS, PGUKID, PGRTAL, PGBPGC", new[] { "PGJOBS", "PGUKID", "PGRTAL", "PGBPGC" }, isUnique: true, isPrimaryKey: true)
    };
}
