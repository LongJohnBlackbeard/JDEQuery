using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4094TEM - .
/// </summary>
public class F4094TEM : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TCICID.
        /// </summary>
        public const string TCICID = "TCICID";

        /// <summary>
        /// TCPRGR.
        /// </summary>
        public const string TCPRGR = "TCPRGR";

        /// <summary>
        /// TCIGP1.
        /// </summary>
        public const string TCIGP1 = "TCIGP1";

        /// <summary>
        /// TCIGP2.
        /// </summary>
        public const string TCIGP2 = "TCIGP2";

        /// <summary>
        /// TCIGP3.
        /// </summary>
        public const string TCIGP3 = "TCIGP3";

        /// <summary>
        /// TCIGP4.
        /// </summary>
        public const string TCIGP4 = "TCIGP4";

        /// <summary>
        /// TCCPGP.
        /// </summary>
        public const string TCCPGP = "TCCPGP";

        /// <summary>
        /// TCCGP1.
        /// </summary>
        public const string TCCGP1 = "TCCGP1";

        /// <summary>
        /// TCCGP2.
        /// </summary>
        public const string TCCGP2 = "TCCGP2";

        /// <summary>
        /// TCCGP3.
        /// </summary>
        public const string TCCGP3 = "TCCGP3";

        /// <summary>
        /// TCCGP4.
        /// </summary>
        public const string TCCGP4 = "TCCGP4";

        /// <summary>
        /// TCIGID.
        /// </summary>
        public const string TCIGID = "TCIGID";

        /// <summary>
        /// TCCGID.
        /// </summary>
        public const string TCCGID = "TCCGID";
    }

    /// <inheritdoc />
    public override string TableName => "F4094TEM";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TCICID", "TCICID", JdeDataType.Numeric, null, true, true),
        new JdeField("TCPRGR", "TCPRGR", JdeDataType.String, 16),
        new JdeField("TCIGP1", "TCIGP1", JdeDataType.String, 12),
        new JdeField("TCIGP2", "TCIGP2", JdeDataType.String, 12),
        new JdeField("TCIGP3", "TCIGP3", JdeDataType.String, 12),
        new JdeField("TCIGP4", "TCIGP4", JdeDataType.String, 12),
        new JdeField("TCCPGP", "TCCPGP", JdeDataType.String, 16),
        new JdeField("TCCGP1", "TCCGP1", JdeDataType.String, 6),
        new JdeField("TCCGP2", "TCCGP2", JdeDataType.String, 6),
        new JdeField("TCCGP3", "TCCGP3", JdeDataType.String, 6),
        new JdeField("TCCGP4", "TCCGP4", JdeDataType.String, 6),
        new JdeField("TCIGID", "TCIGID", JdeDataType.Numeric),
        new JdeField("TCCGID", "TCCGID", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4094TEM_0", "Primary Key on TCICID", new[] { "TCICID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4094TEM_2", "Index on TCPRGR, TCIGP1, TCIGP2, TCIGP3, TCIGP4", new[] { "TCPRGR", "TCIGP1", "TCIGP2", "TCIGP3", "TCIGP4" }),
        new JdeIndex("F4094TEM_3", "Index on TCCPGP, TCCGP1, TCCGP2, TCCGP3, TCCGP4", new[] { "TCCPGP", "TCCGP1", "TCCGP2", "TCCGP3", "TCCGP4" })
    };
}
