using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I052 - .
/// </summary>
public class F75I052 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// INI75SRCT.
        /// </summary>
        public const string INI75SRCT = "INI75SRCT";

        /// <summary>
        /// INI75FRC.
        /// </summary>
        public const string INI75FRC = "INI75FRC";

        /// <summary>
        /// INI75PSP.
        /// </summary>
        public const string INI75PSP = "INI75PSP";

        /// <summary>
        /// INI75PSR.
        /// </summary>
        public const string INI75PSR = "INI75PSR";

        /// <summary>
        /// INEFTJ.
        /// </summary>
        public const string INEFTJ = "INEFTJ";

        /// <summary>
        /// INI75PST.
        /// </summary>
        public const string INI75PST = "INI75PST";

        /// <summary>
        /// INI75PEC.
        /// </summary>
        public const string INI75PEC = "INI75PEC";

        /// <summary>
        /// INI75PHC.
        /// </summary>
        public const string INI75PHC = "INI75PHC";

        /// <summary>
        /// INI75GL01.
        /// </summary>
        public const string INI75GL01 = "INI75GL01";

        /// <summary>
        /// INI75GL02.
        /// </summary>
        public const string INI75GL02 = "INI75GL02";

        /// <summary>
        /// INI75GL03.
        /// </summary>
        public const string INI75GL03 = "INI75GL03";

        /// <summary>
        /// INUSER.
        /// </summary>
        public const string INUSER = "INUSER";

        /// <summary>
        /// INPID.
        /// </summary>
        public const string INPID = "INPID";

        /// <summary>
        /// INJOBN.
        /// </summary>
        public const string INJOBN = "INJOBN";

        /// <summary>
        /// INUPMJ.
        /// </summary>
        public const string INUPMJ = "INUPMJ";

        /// <summary>
        /// INUPMT.
        /// </summary>
        public const string INUPMT = "INUPMT";

        /// <summary>
        /// INURCD.
        /// </summary>
        public const string INURCD = "INURCD";

        /// <summary>
        /// INURDT.
        /// </summary>
        public const string INURDT = "INURDT";

        /// <summary>
        /// INURAT.
        /// </summary>
        public const string INURAT = "INURAT";

        /// <summary>
        /// INURAB.
        /// </summary>
        public const string INURAB = "INURAB";

        /// <summary>
        /// INURRF.
        /// </summary>
        public const string INURRF = "INURRF";

        /// <summary>
        /// INI75PSBC.
        /// </summary>
        public const string INI75PSBC = "INI75PSBC";

        /// <summary>
        /// INI75GL04.
        /// </summary>
        public const string INI75GL04 = "INI75GL04";

        /// <summary>
        /// INI75KKC.
        /// </summary>
        public const string INI75KKC = "INI75KKC";

        /// <summary>
        /// INI75GL05.
        /// </summary>
        public const string INI75GL05 = "INI75GL05";
    }

    /// <inheritdoc />
    public override string TableName => "F75I052";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("INI75SRCT", "INI75SRCT", JdeDataType.String, 12, true, true),
        new JdeField("INI75FRC", "INI75FRC", JdeDataType.String, 2),
        new JdeField("INI75PSP", "INI75PSP", JdeDataType.Numeric),
        new JdeField("INI75PSR", "INI75PSR", JdeDataType.Numeric),
        new JdeField("INEFTJ", "INEFTJ", JdeDataType.Numeric, null, true, true),
        new JdeField("INI75PST", "INI75PST", JdeDataType.Numeric),
        new JdeField("INI75PEC", "INI75PEC", JdeDataType.Numeric),
        new JdeField("INI75PHC", "INI75PHC", JdeDataType.Numeric),
        new JdeField("INI75GL01", "INI75GL01", JdeDataType.String, 8),
        new JdeField("INI75GL02", "INI75GL02", JdeDataType.String, 8),
        new JdeField("INI75GL03", "INI75GL03", JdeDataType.String, 8),
        new JdeField("INUSER", "INUSER", JdeDataType.String, 20),
        new JdeField("INPID", "INPID", JdeDataType.String, 20),
        new JdeField("INJOBN", "INJOBN", JdeDataType.String, 20),
        new JdeField("INUPMJ", "INUPMJ", JdeDataType.Numeric),
        new JdeField("INUPMT", "INUPMT", JdeDataType.Numeric),
        new JdeField("INURCD", "INURCD", JdeDataType.String, 4),
        new JdeField("INURDT", "INURDT", JdeDataType.Numeric),
        new JdeField("INURAT", "INURAT", JdeDataType.Numeric),
        new JdeField("INURAB", "INURAB", JdeDataType.Numeric),
        new JdeField("INURRF", "INURRF", JdeDataType.String, 30),
        new JdeField("INI75PSBC", "INI75PSBC", JdeDataType.Numeric),
        new JdeField("INI75GL04", "INI75GL04", JdeDataType.String, 8),
        new JdeField("INI75KKC", "INI75KKC", JdeDataType.Numeric),
        new JdeField("INI75GL05", "INI75GL05", JdeDataType.String, 8)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I052_0", "Primary Key on INI75SRCT, INEFTJ", new[] { "INI75SRCT", "INEFTJ" }, isUnique: true, isPrimaryKey: true)
    };
}
