using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F34X010 - .
/// </summary>
public class F34X010 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CCMCU.
        /// </summary>
        public const string CCMCU = "CCMCU";

        /// <summary>
        /// CCITM.
        /// </summary>
        public const string CCITM = "CCITM";

        /// <summary>
        /// CCLITM.
        /// </summary>
        public const string CCLITM = "CCLITM";

        /// <summary>
        /// CCAITM.
        /// </summary>
        public const string CCAITM = "CCAITM";

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
    public override string TableName => "F34X010";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CCMCU", "CCMCU", JdeDataType.String, 24, true, true),
        new JdeField("CCITM", "CCITM", JdeDataType.Numeric, null, true, true),
        new JdeField("CCLITM", "CCLITM", JdeDataType.String, 50),
        new JdeField("CCAITM", "CCAITM", JdeDataType.String, 50),
        new JdeField("CCUSER", "CCUSER", JdeDataType.String, 20),
        new JdeField("CCPID", "CCPID", JdeDataType.String, 20),
        new JdeField("CCJOBN", "CCJOBN", JdeDataType.String, 20),
        new JdeField("CCUPMJ", "CCUPMJ", JdeDataType.Numeric),
        new JdeField("CCUPMT", "CCUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F34X010_0", "Primary Key on CCMCU, CCITM", new[] { "CCMCU", "CCITM" }, isUnique: true, isPrimaryKey: true)
    };
}
