using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76H6105 - .
/// </summary>
public class F76H6105 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ACH76LECO.
        /// </summary>
        public const string ACH76LECO = "ACH76LECO";

        /// <summary>
        /// ACCFY.
        /// </summary>
        public const string ACCFY = "ACCFY";

        /// <summary>
        /// ACFFP.
        /// </summary>
        public const string ACFFP = "ACFFP";

        /// <summary>
        /// ACITM.
        /// </summary>
        public const string ACITM = "ACITM";

        /// <summary>
        /// ACMCU.
        /// </summary>
        public const string ACMCU = "ACMCU";

        /// <summary>
        /// ACLOCN.
        /// </summary>
        public const string ACLOCN = "ACLOCN";

        /// <summary>
        /// ACLOTN.
        /// </summary>
        public const string ACLOTN = "ACLOTN";

        /// <summary>
        /// ACLEDG.
        /// </summary>
        public const string ACLEDG = "ACLEDG";

        /// <summary>
        /// ACUNCS.
        /// </summary>
        public const string ACUNCS = "ACUNCS";

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
        /// ACTDAY.
        /// </summary>
        public const string ACTDAY = "ACTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F76H6105";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ACH76LECO", "ACH76LECO", JdeDataType.String, 10, true, true),
        new JdeField("ACCFY", "ACCFY", JdeDataType.Numeric, null, true, true),
        new JdeField("ACFFP", "ACFFP", JdeDataType.Numeric, null, true, true),
        new JdeField("ACITM", "ACITM", JdeDataType.Numeric, null, true, true),
        new JdeField("ACMCU", "ACMCU", JdeDataType.String, 24, true, true),
        new JdeField("ACLOCN", "ACLOCN", JdeDataType.String, 40, true, true),
        new JdeField("ACLOTN", "ACLOTN", JdeDataType.String, 60, true, true),
        new JdeField("ACLEDG", "ACLEDG", JdeDataType.String, 4, true, true),
        new JdeField("ACUNCS", "ACUNCS", JdeDataType.Numeric),
        new JdeField("ACUSER", "ACUSER", JdeDataType.String, 20),
        new JdeField("ACPID", "ACPID", JdeDataType.String, 20),
        new JdeField("ACJOBN", "ACJOBN", JdeDataType.String, 20),
        new JdeField("ACUPMJ", "ACUPMJ", JdeDataType.Numeric),
        new JdeField("ACTDAY", "ACTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76H6105_0", "Primary Key on ACH76LECO, ACCFY, ACFFP, ACITM, ACMCU, ACLOCN, ACLOTN, ACLEDG", new[] { "ACH76LECO", "ACCFY", "ACFFP", "ACITM", "ACMCU", "ACLOCN", "ACLOTN", "ACLEDG" }, isUnique: true, isPrimaryKey: true)
    };
}
