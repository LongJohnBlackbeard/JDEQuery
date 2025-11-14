using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CF16C - .
/// </summary>
public class F90CF16C : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CCEXTMSG.
        /// </summary>
        public const string CCEXTMSG = "CCEXTMSG";

        /// <summary>
        /// CCUSER.
        /// </summary>
        public const string CCUSER = "CCUSER";

        /// <summary>
        /// CCUDTTM.
        /// </summary>
        public const string CCUDTTM = "CCUDTTM";

        /// <summary>
        /// CCMKEY.
        /// </summary>
        public const string CCMKEY = "CCMKEY";

        /// <summary>
        /// CCLANG.
        /// </summary>
        public const string CCLANG = "CCLANG";

        /// <summary>
        /// CCSCRPTID.
        /// </summary>
        public const string CCSCRPTID = "CCSCRPTID";

        /// <summary>
        /// CCJOBN.
        /// </summary>
        public const string CCJOBN = "CCJOBN";

        /// <summary>
        /// CCSTEXTMSG.
        /// </summary>
        public const string CCSTEXTMSG = "CCSTEXTMSG";
    }

    /// <inheritdoc />
    public override string TableName => "F90CF16C";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CCEXTMSG", "CCEXTMSG", JdeDataType.String, 510),
        new JdeField("CCUSER", "CCUSER", JdeDataType.String, 20),
        new JdeField("CCUDTTM", "CCUDTTM", JdeDataType.Date),
        new JdeField("CCMKEY", "CCMKEY", JdeDataType.String, 30),
        new JdeField("CCLANG", "CCLANG", JdeDataType.String, 4, true, true),
        new JdeField("CCSCRPTID", "CCSCRPTID", JdeDataType.Numeric, null, true, true),
        new JdeField("CCJOBN", "CCJOBN", JdeDataType.String, 20),
        new JdeField("CCSTEXTMSG", "CCSTEXTMSG", JdeDataType.String, 510)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CF16C_0", "Primary Key on CCSCRPTID, CCLANG", new[] { "CCSCRPTID", "CCLANG" }, isUnique: true, isPrimaryKey: true)
    };
}
