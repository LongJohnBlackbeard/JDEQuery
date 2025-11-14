using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08731 - .
/// </summary>
public class F08731 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SLSTCTY.
        /// </summary>
        public const string SLSTCTY = "SLSTCTY";

        /// <summary>
        /// SLDTAI.
        /// </summary>
        public const string SLDTAI = "SLDTAI";

        /// <summary>
        /// SLREQE.
        /// </summary>
        public const string SLREQE = "SLREQE";

        /// <summary>
        /// SLUPMJ.
        /// </summary>
        public const string SLUPMJ = "SLUPMJ";

        /// <summary>
        /// SLUPMT.
        /// </summary>
        public const string SLUPMT = "SLUPMT";

        /// <summary>
        /// SLUSER.
        /// </summary>
        public const string SLUSER = "SLUSER";

        /// <summary>
        /// SLPID.
        /// </summary>
        public const string SLPID = "SLPID";

        /// <summary>
        /// SLJOBN.
        /// </summary>
        public const string SLJOBN = "SLJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F08731";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SLSTCTY", "SLSTCTY", JdeDataType.String, 16, true, true),
        new JdeField("SLDTAI", "SLDTAI", JdeDataType.String, 20, true, true),
        new JdeField("SLREQE", "SLREQE", JdeDataType.String, 2),
        new JdeField("SLUPMJ", "SLUPMJ", JdeDataType.Numeric),
        new JdeField("SLUPMT", "SLUPMT", JdeDataType.Numeric),
        new JdeField("SLUSER", "SLUSER", JdeDataType.String, 20),
        new JdeField("SLPID", "SLPID", JdeDataType.String, 20),
        new JdeField("SLJOBN", "SLJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08731_0", "Primary Key on SLSTCTY, SLDTAI", new[] { "SLSTCTY", "SLDTAI" }, isUnique: true, isPrimaryKey: true)
    };
}
