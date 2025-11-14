using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B0520 - .
/// </summary>
public class F76B0520 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ABJOBS.
        /// </summary>
        public const string ABJOBS = "ABJOBS";

        /// <summary>
        /// ABAN8.
        /// </summary>
        public const string ABAN8 = "ABAN8";

        /// <summary>
        /// ABALPH.
        /// </summary>
        public const string ABALPH = "ABALPH";

        /// <summary>
        /// ABURCD.
        /// </summary>
        public const string ABURCD = "ABURCD";

        /// <summary>
        /// ABURDT.
        /// </summary>
        public const string ABURDT = "ABURDT";

        /// <summary>
        /// ABURAT.
        /// </summary>
        public const string ABURAT = "ABURAT";

        /// <summary>
        /// ABURAB.
        /// </summary>
        public const string ABURAB = "ABURAB";

        /// <summary>
        /// ABURRF.
        /// </summary>
        public const string ABURRF = "ABURRF";

        /// <summary>
        /// ABUSER.
        /// </summary>
        public const string ABUSER = "ABUSER";

        /// <summary>
        /// ABPID.
        /// </summary>
        public const string ABPID = "ABPID";

        /// <summary>
        /// ABJOBN.
        /// </summary>
        public const string ABJOBN = "ABJOBN";

        /// <summary>
        /// ABUPMJ.
        /// </summary>
        public const string ABUPMJ = "ABUPMJ";

        /// <summary>
        /// ABUPMT.
        /// </summary>
        public const string ABUPMT = "ABUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B0520";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ABJOBS", "ABJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("ABAN8", "ABAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("ABALPH", "ABALPH", JdeDataType.String, 80),
        new JdeField("ABURCD", "ABURCD", JdeDataType.String, 4),
        new JdeField("ABURDT", "ABURDT", JdeDataType.Numeric),
        new JdeField("ABURAT", "ABURAT", JdeDataType.Numeric),
        new JdeField("ABURAB", "ABURAB", JdeDataType.Numeric),
        new JdeField("ABURRF", "ABURRF", JdeDataType.String, 30),
        new JdeField("ABUSER", "ABUSER", JdeDataType.String, 20),
        new JdeField("ABPID", "ABPID", JdeDataType.String, 20),
        new JdeField("ABJOBN", "ABJOBN", JdeDataType.String, 20),
        new JdeField("ABUPMJ", "ABUPMJ", JdeDataType.Numeric),
        new JdeField("ABUPMT", "ABUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B0520_0", "Primary Key on ABJOBS, ABAN8", new[] { "ABJOBS", "ABAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
