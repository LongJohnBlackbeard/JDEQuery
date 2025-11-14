using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75C004 - .
/// </summary>
public class F75C004 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RNC75RID.
        /// </summary>
        public const string RNC75RID = "RNC75RID";

        /// <summary>
        /// RNC75SEQN.
        /// </summary>
        public const string RNC75SEQN = "RNC75SEQN";

        /// <summary>
        /// RNC75NAC.
        /// </summary>
        public const string RNC75NAC = "RNC75NAC";

        /// <summary>
        /// RNCO.
        /// </summary>
        public const string RNCO = "RNCO";

        /// <summary>
        /// RNC75OPN.
        /// </summary>
        public const string RNC75OPN = "RNC75OPN";

        /// <summary>
        /// RNUSER.
        /// </summary>
        public const string RNUSER = "RNUSER";

        /// <summary>
        /// RNPID.
        /// </summary>
        public const string RNPID = "RNPID";

        /// <summary>
        /// RNJOBN.
        /// </summary>
        public const string RNJOBN = "RNJOBN";

        /// <summary>
        /// RNUPMJ.
        /// </summary>
        public const string RNUPMJ = "RNUPMJ";

        /// <summary>
        /// RNUPMT.
        /// </summary>
        public const string RNUPMT = "RNUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75C004";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RNC75RID", "RNC75RID", JdeDataType.String, 6, true, true),
        new JdeField("RNC75SEQN", "RNC75SEQN", JdeDataType.Numeric, null, true, true),
        new JdeField("RNC75NAC", "RNC75NAC", JdeDataType.String, 60, true, true),
        new JdeField("RNCO", "RNCO", JdeDataType.String, 10, true, true),
        new JdeField("RNC75OPN", "RNC75OPN", JdeDataType.String, 2),
        new JdeField("RNUSER", "RNUSER", JdeDataType.String, 20),
        new JdeField("RNPID", "RNPID", JdeDataType.String, 20),
        new JdeField("RNJOBN", "RNJOBN", JdeDataType.String, 20),
        new JdeField("RNUPMJ", "RNUPMJ", JdeDataType.Numeric),
        new JdeField("RNUPMT", "RNUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75C004_0", "Primary Key on RNC75RID, RNC75SEQN, RNCO, RNC75NAC", new[] { "RNC75RID", "RNC75SEQN", "RNCO", "RNC75NAC" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75C004_2", "Index on RNCO, RNC75NAC", new[] { "RNCO", "RNC75NAC" })
    };
}
