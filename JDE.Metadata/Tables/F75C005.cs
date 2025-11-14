using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75C005 - .
/// </summary>
public class F75C005 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RFC75RID.
        /// </summary>
        public const string RFC75RID = "RFC75RID";

        /// <summary>
        /// RFC75SEQN.
        /// </summary>
        public const string RFC75SEQN = "RFC75SEQN";

        /// <summary>
        /// RFC75FSEQN.
        /// </summary>
        public const string RFC75FSEQN = "RFC75FSEQN";

        /// <summary>
        /// RFC75OPN.
        /// </summary>
        public const string RFC75OPN = "RFC75OPN";

        /// <summary>
        /// RFUSER.
        /// </summary>
        public const string RFUSER = "RFUSER";

        /// <summary>
        /// RFPID.
        /// </summary>
        public const string RFPID = "RFPID";

        /// <summary>
        /// RFJOBN.
        /// </summary>
        public const string RFJOBN = "RFJOBN";

        /// <summary>
        /// RFUPMJ.
        /// </summary>
        public const string RFUPMJ = "RFUPMJ";

        /// <summary>
        /// RFUPMT.
        /// </summary>
        public const string RFUPMT = "RFUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75C005";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RFC75RID", "RFC75RID", JdeDataType.String, 6, true, true),
        new JdeField("RFC75SEQN", "RFC75SEQN", JdeDataType.Numeric, null, true, true),
        new JdeField("RFC75FSEQN", "RFC75FSEQN", JdeDataType.Numeric, null, true, true),
        new JdeField("RFC75OPN", "RFC75OPN", JdeDataType.String, 2),
        new JdeField("RFUSER", "RFUSER", JdeDataType.String, 20),
        new JdeField("RFPID", "RFPID", JdeDataType.String, 20),
        new JdeField("RFJOBN", "RFJOBN", JdeDataType.String, 20),
        new JdeField("RFUPMJ", "RFUPMJ", JdeDataType.Numeric),
        new JdeField("RFUPMT", "RFUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75C005_0", "Primary Key on RFC75RID, RFC75SEQN, RFC75FSEQN", new[] { "RFC75RID", "RFC75SEQN", "RFC75FSEQN" }, isUnique: true, isPrimaryKey: true)
    };
}
