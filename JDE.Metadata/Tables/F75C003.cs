using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75C003 - .
/// </summary>
public class F75C003 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RIC75RID.
        /// </summary>
        public const string RIC75RID = "RIC75RID";

        /// <summary>
        /// RIC75SEQN.
        /// </summary>
        public const string RIC75SEQN = "RIC75SEQN";

        /// <summary>
        /// RIC75LNNUM.
        /// </summary>
        public const string RIC75LNNUM = "RIC75LNNUM";

        /// <summary>
        /// RIC75LNDS1.
        /// </summary>
        public const string RIC75LNDS1 = "RIC75LNDS1";

        /// <summary>
        /// RIC75LNDS2.
        /// </summary>
        public const string RIC75LNDS2 = "RIC75LNDS2";

        /// <summary>
        /// RIC75ORN.
        /// </summary>
        public const string RIC75ORN = "RIC75ORN";

        /// <summary>
        /// RIGFL1.
        /// </summary>
        public const string RIGFL1 = "RIGFL1";

        /// <summary>
        /// RIUSER.
        /// </summary>
        public const string RIUSER = "RIUSER";

        /// <summary>
        /// RIPID.
        /// </summary>
        public const string RIPID = "RIPID";

        /// <summary>
        /// RIJOBN.
        /// </summary>
        public const string RIJOBN = "RIJOBN";

        /// <summary>
        /// RIUPMJ.
        /// </summary>
        public const string RIUPMJ = "RIUPMJ";

        /// <summary>
        /// RIUPMT.
        /// </summary>
        public const string RIUPMT = "RIUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75C003";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RIC75RID", "RIC75RID", JdeDataType.String, 6, true, true),
        new JdeField("RIC75SEQN", "RIC75SEQN", JdeDataType.Numeric, null, true, true),
        new JdeField("RIC75LNNUM", "RIC75LNNUM", JdeDataType.Numeric),
        new JdeField("RIC75LNDS1", "RIC75LNDS1", JdeDataType.String, 510),
        new JdeField("RIC75LNDS2", "RIC75LNDS2", JdeDataType.String, 510),
        new JdeField("RIC75ORN", "RIC75ORN", JdeDataType.Numeric),
        new JdeField("RIGFL1", "RIGFL1", JdeDataType.String, 2),
        new JdeField("RIUSER", "RIUSER", JdeDataType.String, 20),
        new JdeField("RIPID", "RIPID", JdeDataType.String, 20),
        new JdeField("RIJOBN", "RIJOBN", JdeDataType.String, 20),
        new JdeField("RIUPMJ", "RIUPMJ", JdeDataType.Numeric),
        new JdeField("RIUPMT", "RIUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75C003_0", "Primary Key on RIC75RID, RIC75SEQN", new[] { "RIC75RID", "RIC75SEQN" }, isUnique: true, isPrimaryKey: true)
    };
}
