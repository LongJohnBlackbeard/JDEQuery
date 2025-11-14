using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B132 - .
/// </summary>
public class F76B132 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TCADDS.
        /// </summary>
        public const string TCADDS = "TCADDS";

        /// <summary>
        /// TCGICN.
        /// </summary>
        public const string TCGICN = "TCGICN";

        /// <summary>
        /// TCGICC.
        /// </summary>
        public const string TCGICC = "TCGICC";

        /// <summary>
        /// TCGIURC.
        /// </summary>
        public const string TCGIURC = "TCGIURC";

        /// <summary>
        /// TCGIURD.
        /// </summary>
        public const string TCGIURD = "TCGIURD";

        /// <summary>
        /// TCGIURA.
        /// </summary>
        public const string TCGIURA = "TCGIURA";

        /// <summary>
        /// TCGIURN.
        /// </summary>
        public const string TCGIURN = "TCGIURN";

        /// <summary>
        /// TCGIURR.
        /// </summary>
        public const string TCGIURR = "TCGIURR";

        /// <summary>
        /// TCUSER.
        /// </summary>
        public const string TCUSER = "TCUSER";

        /// <summary>
        /// TCPID.
        /// </summary>
        public const string TCPID = "TCPID";

        /// <summary>
        /// TCJOBN.
        /// </summary>
        public const string TCJOBN = "TCJOBN";

        /// <summary>
        /// TCUPMJ.
        /// </summary>
        public const string TCUPMJ = "TCUPMJ";

        /// <summary>
        /// TCUPMT.
        /// </summary>
        public const string TCUPMT = "TCUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B132";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TCADDS", "TCADDS", JdeDataType.String, 6, true, true),
        new JdeField("TCGICN", "TCGICN", JdeDataType.String, 60, true, true),
        new JdeField("TCGICC", "TCGICC", JdeDataType.String, 10),
        new JdeField("TCGIURC", "TCGIURC", JdeDataType.String, 4),
        new JdeField("TCGIURD", "TCGIURD", JdeDataType.Numeric),
        new JdeField("TCGIURA", "TCGIURA", JdeDataType.Numeric),
        new JdeField("TCGIURN", "TCGIURN", JdeDataType.Numeric),
        new JdeField("TCGIURR", "TCGIURR", JdeDataType.String, 30),
        new JdeField("TCUSER", "TCUSER", JdeDataType.String, 20),
        new JdeField("TCPID", "TCPID", JdeDataType.String, 20),
        new JdeField("TCJOBN", "TCJOBN", JdeDataType.String, 20),
        new JdeField("TCUPMJ", "TCUPMJ", JdeDataType.Numeric),
        new JdeField("TCUPMT", "TCUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B132_0", "Primary Key on TCADDS, TCGICN", new[] { "TCADDS", "TCGICN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76B132_2", "Index on TCGICC", new[] { "TCGICC" })
    };
}
