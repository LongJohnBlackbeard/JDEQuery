using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B019 - .
/// </summary>
public class F76B019 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EXBNNF.
        /// </summary>
        public const string EXBNNF = "EXBNNF";

        /// <summary>
        /// EXBSER.
        /// </summary>
        public const string EXBSER = "EXBSER";

        /// <summary>
        /// EXN001.
        /// </summary>
        public const string EXN001 = "EXN001";

        /// <summary>
        /// EXDCT.
        /// </summary>
        public const string EXDCT = "EXDCT";

        /// <summary>
        /// EXB76ASUF.
        /// </summary>
        public const string EXB76ASUF = "EXB76ASUF";

        /// <summary>
        /// EXB76ASPN.
        /// </summary>
        public const string EXB76ASPN = "EXB76ASPN";

        /// <summary>
        /// EXUSER.
        /// </summary>
        public const string EXUSER = "EXUSER";

        /// <summary>
        /// EXPID.
        /// </summary>
        public const string EXPID = "EXPID";

        /// <summary>
        /// EXJOBN.
        /// </summary>
        public const string EXJOBN = "EXJOBN";

        /// <summary>
        /// EXUPMJ.
        /// </summary>
        public const string EXUPMJ = "EXUPMJ";

        /// <summary>
        /// EXUPMT.
        /// </summary>
        public const string EXUPMT = "EXUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B019";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EXBNNF", "EXBNNF", JdeDataType.Numeric, null, true, true),
        new JdeField("EXBSER", "EXBSER", JdeDataType.String, 4, true, true),
        new JdeField("EXN001", "EXN001", JdeDataType.Numeric, null, true, true),
        new JdeField("EXDCT", "EXDCT", JdeDataType.String, 4, true, true),
        new JdeField("EXB76ASUF", "EXB76ASUF", JdeDataType.String, 6),
        new JdeField("EXB76ASPN", "EXB76ASPN", JdeDataType.String, 6),
        new JdeField("EXUSER", "EXUSER", JdeDataType.String, 20),
        new JdeField("EXPID", "EXPID", JdeDataType.String, 20),
        new JdeField("EXJOBN", "EXJOBN", JdeDataType.String, 20),
        new JdeField("EXUPMJ", "EXUPMJ", JdeDataType.Numeric),
        new JdeField("EXUPMT", "EXUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B019_0", "Primary Key on EXBNNF, EXBSER, EXN001, EXDCT", new[] { "EXBNNF", "EXBSER", "EXN001", "EXDCT" }, isUnique: true, isPrimaryKey: true)
    };
}
