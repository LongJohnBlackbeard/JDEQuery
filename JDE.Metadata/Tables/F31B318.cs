using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B318 - .
/// </summary>
public class F31B318 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ACMCU.
        /// </summary>
        public const string ACMCU = "ACMCU";

        /// <summary>
        /// ACWLOTN.
        /// </summary>
        public const string ACWLOTN = "ACWLOTN";

        /// <summary>
        /// ACITM.
        /// </summary>
        public const string ACITM = "ACITM";

        /// <summary>
        /// ACACQTY.
        /// </summary>
        public const string ACACQTY = "ACACQTY";

        /// <summary>
        /// ACACUOM.
        /// </summary>
        public const string ACACUOM = "ACACUOM";

        /// <summary>
        /// ACPID.
        /// </summary>
        public const string ACPID = "ACPID";

        /// <summary>
        /// ACUSER.
        /// </summary>
        public const string ACUSER = "ACUSER";

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

        /// <summary>
        /// ACURCD.
        /// </summary>
        public const string ACURCD = "ACURCD";

        /// <summary>
        /// ACURDT.
        /// </summary>
        public const string ACURDT = "ACURDT";

        /// <summary>
        /// ACURAT.
        /// </summary>
        public const string ACURAT = "ACURAT";

        /// <summary>
        /// ACURRF.
        /// </summary>
        public const string ACURRF = "ACURRF";

        /// <summary>
        /// ACURAB.
        /// </summary>
        public const string ACURAB = "ACURAB";
    }

    /// <inheritdoc />
    public override string TableName => "F31B318";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ACMCU", "ACMCU", JdeDataType.String, 24, true, true),
        new JdeField("ACWLOTN", "ACWLOTN", JdeDataType.String, 60, true, true),
        new JdeField("ACITM", "ACITM", JdeDataType.Numeric, null, true, true),
        new JdeField("ACACQTY", "ACACQTY", JdeDataType.Numeric),
        new JdeField("ACACUOM", "ACACUOM", JdeDataType.String, 6),
        new JdeField("ACPID", "ACPID", JdeDataType.String, 20),
        new JdeField("ACUSER", "ACUSER", JdeDataType.String, 20),
        new JdeField("ACJOBN", "ACJOBN", JdeDataType.String, 20),
        new JdeField("ACUPMJ", "ACUPMJ", JdeDataType.Numeric),
        new JdeField("ACUPMT", "ACUPMT", JdeDataType.Numeric),
        new JdeField("ACURCD", "ACURCD", JdeDataType.String, 4),
        new JdeField("ACURDT", "ACURDT", JdeDataType.Numeric),
        new JdeField("ACURAT", "ACURAT", JdeDataType.Numeric),
        new JdeField("ACURRF", "ACURRF", JdeDataType.String, 30),
        new JdeField("ACURAB", "ACURAB", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B318_0", "Primary Key on ACMCU, ACWLOTN, ACITM", new[] { "ACMCU", "ACWLOTN", "ACITM" }, isUnique: true, isPrimaryKey: true)
    };
}
