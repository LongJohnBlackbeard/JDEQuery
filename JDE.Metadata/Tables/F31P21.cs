using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31P21 - .
/// </summary>
public class F31P21 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CCMMCU.
        /// </summary>
        public const string CCMMCU = "CCMMCU";

        /// <summary>
        /// CCPRJM.
        /// </summary>
        public const string CCPRJM = "CCPRJM";

        /// <summary>
        /// CCCOST.
        /// </summary>
        public const string CCCOST = "CCCOST";

        /// <summary>
        /// CCAID.
        /// </summary>
        public const string CCAID = "CCAID";

        /// <summary>
        /// CCCTCL.
        /// </summary>
        public const string CCCTCL = "CCCTCL";

        /// <summary>
        /// CCUSER.
        /// </summary>
        public const string CCUSER = "CCUSER";

        /// <summary>
        /// CCPID.
        /// </summary>
        public const string CCPID = "CCPID";

        /// <summary>
        /// CCJOBN.
        /// </summary>
        public const string CCJOBN = "CCJOBN";

        /// <summary>
        /// CCUPMJ.
        /// </summary>
        public const string CCUPMJ = "CCUPMJ";

        /// <summary>
        /// CCUPMT.
        /// </summary>
        public const string CCUPMT = "CCUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F31P21";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CCMMCU", "CCMMCU", JdeDataType.String, 24, true, true),
        new JdeField("CCPRJM", "CCPRJM", JdeDataType.Numeric, null, true, true),
        new JdeField("CCCOST", "CCCOST", JdeDataType.String, 6, true, true),
        new JdeField("CCAID", "CCAID", JdeDataType.String, 16, true, true),
        new JdeField("CCCTCL", "CCCTCL", JdeDataType.String, 4),
        new JdeField("CCUSER", "CCUSER", JdeDataType.String, 20),
        new JdeField("CCPID", "CCPID", JdeDataType.String, 20),
        new JdeField("CCJOBN", "CCJOBN", JdeDataType.String, 20),
        new JdeField("CCUPMJ", "CCUPMJ", JdeDataType.Numeric),
        new JdeField("CCUPMT", "CCUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31P21_0", "Primary Key on CCMMCU, CCPRJM, CCCOST, CCAID", new[] { "CCMMCU", "CCPRJM", "CCCOST", "CCAID" }, isUnique: true, isPrimaryKey: true)
    };
}
