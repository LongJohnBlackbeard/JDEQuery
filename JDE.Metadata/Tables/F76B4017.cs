using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B4017 - .
/// </summary>
public class F76B4017 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ACBRG.
        /// </summary>
        public const string ACBRG = "ACBRG";

        /// <summary>
        /// ACB76COID.
        /// </summary>
        public const string ACB76COID = "ACB76COID";

        /// <summary>
        /// ACB76ACTT.
        /// </summary>
        public const string ACB76ACTT = "ACB76ACTT";

        /// <summary>
        /// ACCENTYR.
        /// </summary>
        public const string ACCENTYR = "ACCENTYR";

        /// <summary>
        /// ACMNTH.
        /// </summary>
        public const string ACMNTH = "ACMNTH";

        /// <summary>
        /// ACAG.
        /// </summary>
        public const string ACAG = "ACAG";

        /// <summary>
        /// ACSTAM.
        /// </summary>
        public const string ACSTAM = "ACSTAM";

        /// <summary>
        /// ACB76MXMN.
        /// </summary>
        public const string ACB76MXMN = "ACB76MXMN";

        /// <summary>
        /// ACUSER.
        /// </summary>
        public const string ACUSER = "ACUSER";

        /// <summary>
        /// ACPID.
        /// </summary>
        public const string ACPID = "ACPID";

        /// <summary>
        /// ACJOBN.
        /// </summary>
        public const string ACJOBN = "ACJOBN";

        /// <summary>
        /// ACUPMJ.
        /// </summary>
        public const string ACUPMJ = "ACUPMJ";

        /// <summary>
        /// ACUPMT.
        /// </summary>
        public const string ACUPMT = "ACUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B4017";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ACBRG", "ACBRG", JdeDataType.String, 18, true, true),
        new JdeField("ACB76COID", "ACB76COID", JdeDataType.String, 18, true, true),
        new JdeField("ACB76ACTT", "ACB76ACTT", JdeDataType.String, 6, true, true),
        new JdeField("ACCENTYR", "ACCENTYR", JdeDataType.Numeric, null, true, true),
        new JdeField("ACMNTH", "ACMNTH", JdeDataType.Numeric, null, true, true),
        new JdeField("ACAG", "ACAG", JdeDataType.Numeric),
        new JdeField("ACSTAM", "ACSTAM", JdeDataType.Numeric),
        new JdeField("ACB76MXMN", "ACB76MXMN", JdeDataType.Numeric),
        new JdeField("ACUSER", "ACUSER", JdeDataType.String, 20),
        new JdeField("ACPID", "ACPID", JdeDataType.String, 20),
        new JdeField("ACJOBN", "ACJOBN", JdeDataType.String, 20),
        new JdeField("ACUPMJ", "ACUPMJ", JdeDataType.Numeric),
        new JdeField("ACUPMT", "ACUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B4017_0", "Primary Key on ACBRG, ACB76COID, ACB76ACTT, ACCENTYR, ACMNTH", new[] { "ACBRG", "ACB76COID", "ACB76ACTT", "ACCENTYR", "ACMNTH" }, isUnique: true, isPrimaryKey: true)
    };
}
