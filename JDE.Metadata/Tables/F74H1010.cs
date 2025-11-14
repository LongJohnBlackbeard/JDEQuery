using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74H1010 - .
/// </summary>
public class F74H1010 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AEAN8.
        /// </summary>
        public const string AEAN8 = "AEAN8";

        /// <summary>
        /// AEEFTB.
        /// </summary>
        public const string AEEFTB = "AEEFTB";

        /// <summary>
        /// AETXCT.
        /// </summary>
        public const string AETXCT = "AETXCT";

        /// <summary>
        /// AEJOBN.
        /// </summary>
        public const string AEJOBN = "AEJOBN";

        /// <summary>
        /// AEPID.
        /// </summary>
        public const string AEPID = "AEPID";

        /// <summary>
        /// AEUSER.
        /// </summary>
        public const string AEUSER = "AEUSER";

        /// <summary>
        /// AEUPMJ.
        /// </summary>
        public const string AEUPMJ = "AEUPMJ";

        /// <summary>
        /// AEUPMT.
        /// </summary>
        public const string AEUPMT = "AEUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74H1010";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AEAN8", "AEAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("AEEFTB", "AEEFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("AETXCT", "AETXCT", JdeDataType.String, 40),
        new JdeField("AEJOBN", "AEJOBN", JdeDataType.String, 20),
        new JdeField("AEPID", "AEPID", JdeDataType.String, 20),
        new JdeField("AEUSER", "AEUSER", JdeDataType.String, 20),
        new JdeField("AEUPMJ", "AEUPMJ", JdeDataType.Numeric),
        new JdeField("AEUPMT", "AEUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74H1010_0", "Primary Key on AEAN8, AEEFTB", new[] { "AEAN8", "AEEFTB" }, isUnique: true, isPrimaryKey: true)
    };
}
