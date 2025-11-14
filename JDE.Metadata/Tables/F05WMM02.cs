using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F05WMM02 - .
/// </summary>
public class F05WMM02 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DDOBNM.
        /// </summary>
        public const string DDOBNM = "DDOBNM";

        /// <summary>
        /// DDOWDI.
        /// </summary>
        public const string DDOWDI = "DDOWDI";

        /// <summary>
        /// DDINT01.
        /// </summary>
        public const string DDINT01 = "DDINT01";

        /// <summary>
        /// DDDTAI.
        /// </summary>
        public const string DDDTAI = "DDDTAI";

        /// <summary>
        /// DDOWTP.
        /// </summary>
        public const string DDOWTP = "DDOWTP";

        /// <summary>
        /// DDUSER.
        /// </summary>
        public const string DDUSER = "DDUSER";

        /// <summary>
        /// DDJOBN.
        /// </summary>
        public const string DDJOBN = "DDJOBN";

        /// <summary>
        /// DDPID.
        /// </summary>
        public const string DDPID = "DDPID";

        /// <summary>
        /// DDUPMJ.
        /// </summary>
        public const string DDUPMJ = "DDUPMJ";

        /// <summary>
        /// DDUPMT.
        /// </summary>
        public const string DDUPMT = "DDUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F05WMM02";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DDOBNM", "DDOBNM", JdeDataType.String, 20, true, true),
        new JdeField("DDOWDI", "DDOWDI", JdeDataType.String, 80),
        new JdeField("DDINT01", "DDINT01", JdeDataType.Numeric, null, true, true),
        new JdeField("DDDTAI", "DDDTAI", JdeDataType.String, 20),
        new JdeField("DDOWTP", "DDOWTP", JdeDataType.String, 4),
        new JdeField("DDUSER", "DDUSER", JdeDataType.String, 20),
        new JdeField("DDJOBN", "DDJOBN", JdeDataType.String, 20),
        new JdeField("DDPID", "DDPID", JdeDataType.String, 20),
        new JdeField("DDUPMJ", "DDUPMJ", JdeDataType.Numeric),
        new JdeField("DDUPMT", "DDUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F05WMM02_0", "Primary Key on DDOBNM, DDINT01", new[] { "DDOBNM", "DDINT01" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F05WMM02_2", "Index on DDOBNM, SYS_NC00011$", new[] { "DDOBNM", "SYS_NC00011$" }),
        new JdeIndex("F05WMM02_3", "Unique Index on DDOBNM, DDOWDI", new[] { "DDOBNM", "DDOWDI" }, isUnique: true)
    };
}
