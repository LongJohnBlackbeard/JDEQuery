using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F07885 - .
/// </summary>
public class F07885 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YWHMCO.
        /// </summary>
        public const string YWHMCO = "YWHMCO";

        /// <summary>
        /// YWTARA.
        /// </summary>
        public const string YWTARA = "YWTARA";

        /// <summary>
        /// YWSEAN.
        /// </summary>
        public const string YWSEAN = "YWSEAN";

        /// <summary>
        /// YWCKDT.
        /// </summary>
        public const string YWCKDT = "YWCKDT";

        /// <summary>
        /// YWSEQ.
        /// </summary>
        public const string YWSEQ = "YWSEQ";

        /// <summary>
        /// YWPQTR.
        /// </summary>
        public const string YWPQTR = "YWPQTR";

        /// <summary>
        /// YWCTRY.
        /// </summary>
        public const string YWCTRY = "YWCTRY";

        /// <summary>
        /// YWDTEY.
        /// </summary>
        public const string YWDTEY = "YWDTEY";

        /// <summary>
        /// YWTAXX.
        /// </summary>
        public const string YWTAXX = "YWTAXX";

        /// <summary>
        /// YWSUIAW.
        /// </summary>
        public const string YWSUIAW = "YWSUIAW";

        /// <summary>
        /// YWSUIAD.
        /// </summary>
        public const string YWSUIAD = "YWSUIAD";

        /// <summary>
        /// YWSUIGST01.
        /// </summary>
        public const string YWSUIGST01 = "YWSUIGST01";

        /// <summary>
        /// YWSUIGST02.
        /// </summary>
        public const string YWSUIGST02 = "YWSUIGST02";

        /// <summary>
        /// YWSUIGST03.
        /// </summary>
        public const string YWSUIGST03 = "YWSUIGST03";

        /// <summary>
        /// YWSUIGST04.
        /// </summary>
        public const string YWSUIGST04 = "YWSUIGST04";

        /// <summary>
        /// YWSUIGDT01.
        /// </summary>
        public const string YWSUIGDT01 = "YWSUIGDT01";

        /// <summary>
        /// YWSUIGDT02.
        /// </summary>
        public const string YWSUIGDT02 = "YWSUIGDT02";

        /// <summary>
        /// YWSUIGMN01.
        /// </summary>
        public const string YWSUIGMN01 = "YWSUIGMN01";

        /// <summary>
        /// YWSUIGMN02.
        /// </summary>
        public const string YWSUIGMN02 = "YWSUIGMN02";

        /// <summary>
        /// YWSUIGMN03.
        /// </summary>
        public const string YWSUIGMN03 = "YWSUIGMN03";

        /// <summary>
        /// YWSUIGMN04.
        /// </summary>
        public const string YWSUIGMN04 = "YWSUIGMN04";

        /// <summary>
        /// YWSUIGCH01.
        /// </summary>
        public const string YWSUIGCH01 = "YWSUIGCH01";

        /// <summary>
        /// YWSUIGCH02.
        /// </summary>
        public const string YWSUIGCH02 = "YWSUIGCH02";

        /// <summary>
        /// YWUSER.
        /// </summary>
        public const string YWUSER = "YWUSER";

        /// <summary>
        /// YWPID.
        /// </summary>
        public const string YWPID = "YWPID";

        /// <summary>
        /// YWUPMJ.
        /// </summary>
        public const string YWUPMJ = "YWUPMJ";

        /// <summary>
        /// YWUPMT.
        /// </summary>
        public const string YWUPMT = "YWUPMT";

        /// <summary>
        /// YWJOBN.
        /// </summary>
        public const string YWJOBN = "YWJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F07885";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YWHMCO", "YWHMCO", JdeDataType.String, 10, true, true),
        new JdeField("YWTARA", "YWTARA", JdeDataType.String, 20, true, true),
        new JdeField("YWSEAN", "YWSEAN", JdeDataType.String, 24, true, true),
        new JdeField("YWCKDT", "YWCKDT", JdeDataType.Numeric, null, true, true),
        new JdeField("YWSEQ", "YWSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("YWPQTR", "YWPQTR", JdeDataType.String, 2),
        new JdeField("YWCTRY", "YWCTRY", JdeDataType.Numeric),
        new JdeField("YWDTEY", "YWDTEY", JdeDataType.Numeric),
        new JdeField("YWTAXX", "YWTAXX", JdeDataType.String, 40),
        new JdeField("YWSUIAW", "YWSUIAW", JdeDataType.Numeric),
        new JdeField("YWSUIAD", "YWSUIAD", JdeDataType.Numeric),
        new JdeField("YWSUIGST01", "YWSUIGST01", JdeDataType.String, 40),
        new JdeField("YWSUIGST02", "YWSUIGST02", JdeDataType.String, 40),
        new JdeField("YWSUIGST03", "YWSUIGST03", JdeDataType.String, 40),
        new JdeField("YWSUIGST04", "YWSUIGST04", JdeDataType.String, 40),
        new JdeField("YWSUIGDT01", "YWSUIGDT01", JdeDataType.Numeric),
        new JdeField("YWSUIGDT02", "YWSUIGDT02", JdeDataType.Numeric),
        new JdeField("YWSUIGMN01", "YWSUIGMN01", JdeDataType.Numeric),
        new JdeField("YWSUIGMN02", "YWSUIGMN02", JdeDataType.Numeric),
        new JdeField("YWSUIGMN03", "YWSUIGMN03", JdeDataType.Numeric),
        new JdeField("YWSUIGMN04", "YWSUIGMN04", JdeDataType.Numeric),
        new JdeField("YWSUIGCH01", "YWSUIGCH01", JdeDataType.String, 2),
        new JdeField("YWSUIGCH02", "YWSUIGCH02", JdeDataType.String, 2),
        new JdeField("YWUSER", "YWUSER", JdeDataType.String, 20),
        new JdeField("YWPID", "YWPID", JdeDataType.String, 20),
        new JdeField("YWUPMJ", "YWUPMJ", JdeDataType.Numeric),
        new JdeField("YWUPMT", "YWUPMT", JdeDataType.Numeric),
        new JdeField("YWJOBN", "YWJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F07885_0", "Primary Key on YWHMCO, YWTARA, YWSEAN, YWCKDT, YWSEQ", new[] { "YWHMCO", "YWTARA", "YWSEAN", "YWCKDT", "YWSEQ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F07885_2", "Index on YWHMCO, YWTARA, YWSEQ", new[] { "YWHMCO", "YWTARA", "YWSEQ" }),
        new JdeIndex("F07885_3", "Index on YWHMCO, YWTARA, YWDTEY, YWPQTR", new[] { "YWHMCO", "YWTARA", "YWDTEY", "YWPQTR" })
    };
}
