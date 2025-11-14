using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F007101 - .
/// </summary>
public class F007101 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TAGPBT.
        /// </summary>
        public const string TAGPBT = "TAGPBT";

        /// <summary>
        /// TAGPTN.
        /// </summary>
        public const string TAGPTN = "TAGPTN";

        /// <summary>
        /// TAGPUS.
        /// </summary>
        public const string TAGPUS = "TAGPUS";

        /// <summary>
        /// TADL01.
        /// </summary>
        public const string TADL01 = "TADL01";

        /// <summary>
        /// TAPGM.
        /// </summary>
        public const string TAPGM = "TAPGM";

        /// <summary>
        /// TAVERS.
        /// </summary>
        public const string TAVERS = "TAVERS";

        /// <summary>
        /// TAGPSP.
        /// </summary>
        public const string TAGPSP = "TAGPSP";

        /// <summary>
        /// TAGPDP.
        /// </summary>
        public const string TAGPDP = "TAGPDP";

        /// <summary>
        /// TAGPPR.
        /// </summary>
        public const string TAGPPR = "TAGPPR";

        /// <summary>
        /// TAGPR1.
        /// </summary>
        public const string TAGPR1 = "TAGPR1";

        /// <summary>
        /// TAGPF1.
        /// </summary>
        public const string TAGPF1 = "TAGPF1";

        /// <summary>
        /// TAURC1.
        /// </summary>
        public const string TAURC1 = "TAURC1";

        /// <summary>
        /// TAURRF.
        /// </summary>
        public const string TAURRF = "TAURRF";

        /// <summary>
        /// TAURDT.
        /// </summary>
        public const string TAURDT = "TAURDT";

        /// <summary>
        /// TAURAB.
        /// </summary>
        public const string TAURAB = "TAURAB";

        /// <summary>
        /// TAUSER.
        /// </summary>
        public const string TAUSER = "TAUSER";

        /// <summary>
        /// TAPID.
        /// </summary>
        public const string TAPID = "TAPID";

        /// <summary>
        /// TAJOBN.
        /// </summary>
        public const string TAJOBN = "TAJOBN";

        /// <summary>
        /// TAUPMJ.
        /// </summary>
        public const string TAUPMJ = "TAUPMJ";

        /// <summary>
        /// TAUPMT.
        /// </summary>
        public const string TAUPMT = "TAUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F007101";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TAGPBT", "TAGPBT", JdeDataType.Numeric, null, true, true),
        new JdeField("TAGPTN", "TAGPTN", JdeDataType.String, 28, true, true),
        new JdeField("TAGPUS", "TAGPUS", JdeDataType.String, 20),
        new JdeField("TADL01", "TADL01", JdeDataType.String, 60),
        new JdeField("TAPGM", "TAPGM", JdeDataType.String, 20),
        new JdeField("TAVERS", "TAVERS", JdeDataType.String, 20),
        new JdeField("TAGPSP", "TAGPSP", JdeDataType.String, 2),
        new JdeField("TAGPDP", "TAGPDP", JdeDataType.Numeric),
        new JdeField("TAGPPR", "TAGPPR", JdeDataType.String, 20),
        new JdeField("TAGPR1", "TAGPR1", JdeDataType.String, 28),
        new JdeField("TAGPF1", "TAGPF1", JdeDataType.String, 2),
        new JdeField("TAURC1", "TAURC1", JdeDataType.String, 6),
        new JdeField("TAURRF", "TAURRF", JdeDataType.String, 30),
        new JdeField("TAURDT", "TAURDT", JdeDataType.Numeric),
        new JdeField("TAURAB", "TAURAB", JdeDataType.Numeric),
        new JdeField("TAUSER", "TAUSER", JdeDataType.String, 20),
        new JdeField("TAPID", "TAPID", JdeDataType.String, 20),
        new JdeField("TAJOBN", "TAJOBN", JdeDataType.String, 20),
        new JdeField("TAUPMJ", "TAUPMJ", JdeDataType.Numeric),
        new JdeField("TAUPMT", "TAUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F007101_0", "Primary Key on TAGPBT, TAGPTN", new[] { "TAGPBT", "TAGPTN" }, isUnique: true, isPrimaryKey: true)
    };
}
